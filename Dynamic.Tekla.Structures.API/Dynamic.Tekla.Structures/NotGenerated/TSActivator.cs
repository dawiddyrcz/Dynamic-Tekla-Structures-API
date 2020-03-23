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
            var type = GetTypeFromTypeName(typeName, ref assembly);

            return Activator.CreateInstance(type);
        }

        public static object InvokeStaticMethod(string typeName, string methodName, object[] parameters)
        {
            string fileTS = GetFileName(typeName);

            var assembly = Assembly.LoadFrom(fileTS);
            var type = GetTypeFromTypeName(typeName, ref assembly);

            MethodInfo method = GetMethod(methodName, parameters, type);

            return method.Invoke(null, parameters);
        }

        private static MethodInfo GetMethod(string methodName, object[] parameters, Type type)
        {
            var methods = type.GetMethods()
                .Where(m => m.Name.Equals(methodName, StringComparison.InvariantCulture)
                && m.GetParameters().Count().Equals(parameters.Count())
                ).ToList();
            int count = methods.Count();
            
            if (count.Equals(1)) return methods[0];
            else
            {
                foreach (var method in methods)
                {
                    bool parametersMath = true;

                    int i = 0;
                    var methodParameters = method.GetParameters();
                    foreach (var parameter in methodParameters)
                    {
                        if (!(parameter.ParameterType.Equals(parameters[i].GetType())
                            || parameter.ParameterType.Equals(parameters[i].GetType().MakeByRefType())))
                        {
                            parametersMath = false;
                            break;
                        }
                        i++;
                    }

                    if (parametersMath) return method;
                }
            }

            throw new DynamicAPIException("Could not find method " + methodName + " in type " + type.Name);
        }

        public static dynamic CreateInstance(string typeName, object[] args)
        {
            string fileTS = GetFileName(typeName);

            var assembly = Assembly.LoadFrom(fileTS);
            var type = GetTypeFromTypeName(typeName, ref assembly);

            return Activator.CreateInstance(type, args);
        }

        private static Type GetTypeFromTypeName(string typeName,ref  Assembly assembly)
        {
            var type =  assembly.GetType(typeName);
            if (type == null)
                type = TryGetNestedType(typeName, ref assembly);
            return type;
        }

        private static Type TryGetNestedType(string typeName, ref Assembly assembly)
        {
            if (typeName.Contains('.'))
            {
                string output = string.Copy(typeName);
                var lastDotPosition = typeName.LastIndexOf('.');
                output = typeName.Insert(lastDotPosition, "+");
                output = output.Remove(lastDotPosition + 1, 1);

                var type = assembly.GetType(output);  

                if (type != null)
                    return type;
                else
                    return TryGetNestedType(output, ref assembly);
            }
            else return assembly.GetType(typeName);
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
                    throw new DynamicAPIException("Unknown namespace: " + typeName); 
            }
            else
            {
                throw new DynamicAPIException("Tekla is not running");
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
