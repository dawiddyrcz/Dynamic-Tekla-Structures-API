using System;
using System.Reflection;

namespace Dynamic.Tekla.Structures
{
    public static class TSActivator
    {
        private static readonly string TSFile = @"E:\prog\sharp\Dynamic-Tekla-Structures-API\Dynamic.Tekla.Structures.API\CodeGenerator\Tekla.Structures.dll";
        private static readonly string TSMFile = @"E:\prog\sharp\Dynamic-Tekla-Structures-API\Dynamic.Tekla.Structures.API\CodeGenerator\Tekla.Structures.Model.dll";

        private static string GetFileName(string typeName)
        {
            string fileTS = string.Empty;

            if (typeName.Contains("Tekla.Structures.Model"))
            {
                fileTS = TSMFile;
            }
            else
            {
                fileTS = TSFile;
            }

            return fileTS;
        }

        public static dynamic CreateInstance(string typeName)
        {
            string fileTS = GetFileName(typeName);

            var assembly = Assembly.LoadFrom(fileTS);
            var type = assembly.GetType(typeName);

            if (type == null)
                type = TryGetNestedType(typeName, ref assembly);

            return Activator.CreateInstance(type);
        }

        private static Type TryGetNestedType(string typeName, ref Assembly assembly)
        {
            string output = string.Copy(typeName);
            var lastDotPosition = typeName.LastIndexOf('.');
            output = typeName.Insert(lastDotPosition,"+");
            output = output.Remove(lastDotPosition+1,1);

            return assembly.GetType(output);
        }

        public static dynamic CreateInstance(string typeName, object[] args)
        {
            string fileTS = GetFileName(typeName);

            var assembly = Assembly.LoadFrom(fileTS);
            var type = assembly.GetType(typeName);
            return Activator.CreateInstance(type, args);
        }
    }
}
