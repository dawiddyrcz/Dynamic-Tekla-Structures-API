using System;

namespace Dynamic.Tekla.Structures
{
    public static class TSActivator
    {
        public static dynamic CreateInstance(string typeName)
        {
            if (typeName.Contains("Tekla.Structures.Model"))
            {
                string fileTS = @"E:\prog\sharp\Dynamic-Tekla-Structures-API\Dynamic.Tekla.Structures.API\CodeGenerator\Tekla.Structures.Model.dll";
                return Activator.CreateInstanceFrom(fileTS, typeName).Unwrap();
            }
            else
            {
                string fileTS = @"E:\prog\sharp\Dynamic-Tekla-Structures-API\Dynamic.Tekla.Structures.API\CodeGenerator\Tekla.Structures.dll";
                return Activator.CreateInstanceFrom(fileTS, typeName).Unwrap();
            }
        }
    }
}
