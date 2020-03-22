using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Dynamic.Tekla.Structures
{
    internal static class TSActivator
    {
        public static dynamic CreateInstance(string typeName)
        {
            string fileTS = GetFileName(typeName);

            var assembly = Assembly.LoadFrom(fileTS);
            var type = assembly.GetType(typeName);

            if (type == null)
                type = TryGetNestedType(typeName, ref assembly);

            return Activator.CreateInstance(type);
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object[] parameters)
        {
            string fileTS = GetFileName(typeName);

            var assembly = Assembly.LoadFrom(fileTS);
            var type = assembly.GetType(typeName);

            var parametersTypesList = parameters.Select(p => p.GetType()).ToList();

            //TODO zastanowić się co jeżeli są przeciążenia metod z tą samą liczbą parametrów ale z różnymi parametrami
            var method = type.GetMethods()
                .Where(m => m.Name.Equals(methodName, StringComparison.InvariantCulture)
                && m.GetParameters().Count().Equals(parameters.Count())
                ).FirstOrDefault();

            return method.Invoke(null, parameters);
        }

        public static dynamic CreateInstance(string typeName, object[] args)
        {
            string fileTS = GetFileName(typeName);

            var assembly = Assembly.LoadFrom(fileTS);
            var type = assembly.GetType(typeName);
            return Activator.CreateInstance(type, args);
        }

        private static Type TryGetNestedType(string typeName, ref Assembly assembly)
        {
            string output = string.Copy(typeName);
            var lastDotPosition = typeName.LastIndexOf('.');
            output = typeName.Insert(lastDotPosition, "+");
            output = output.Remove(lastDotPosition + 1, 1);

            return assembly.GetType(output);
        }

        private static string GetFileName(string typeName)
        {
            string fileTS = string.Empty;

            if (IsTeklaRunning(out string pluginPath))
            {
                var dll = new DLLFiles(pluginPath);

                if (typeName.StartsWith("Tekla.Structures.Model"))
                    fileTS = dll.TSM;
                else if (typeName.StartsWith("Tekla.Structures.Drawing"))
                    fileTS = dll.TSD;
                else if (typeName.StartsWith("Tekla.Structures"))
                    fileTS = dll.TS;
                else
                    throw new Exception("Unknown namespace: " + typeName); //TODO exception
            }
            else
            {
                throw new Exception("Tekla is not running");//TODO exception
            }

            return fileTS;
        }

        private static TeklaProcess teklaProcess;

        private static bool IsTeklaRunning(out string pluginPath)
        {
            if (teklaProcess == null)
                teklaProcess = new TeklaProcess();

            if (teklaProcess.IsTeklaRunning() == false)
                teklaProcess = new TeklaProcess();

            if (teklaProcess.IsTeklaRunning())
            {
                pluginPath = Path.Combine(teklaProcess.GetTeklaProcessDirectoryPath(), "plugins");
                return true;
            }

            pluginPath = string.Empty;
            return false;
        }

        private class DLLFiles
        {
            public string TS { get; set; } = string.Empty;
            public string TSM { get; set; } = string.Empty;
            public string TSD { get; set; } = string.Empty;

            public DLLFiles(string pluginPath)
            {
                this.TS = Path.Combine(pluginPath, "Tekla.Structures.dll");
                this.TSM = Path.Combine(pluginPath, "Tekla.Structures.Model.dll");
                this.TSD = Path.Combine(pluginPath, "Tekla.Structures.Drawing.dll");
            }
        }
    }
}
