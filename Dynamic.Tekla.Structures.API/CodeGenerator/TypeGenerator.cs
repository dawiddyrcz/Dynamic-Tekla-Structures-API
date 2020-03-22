using System;
using System.IO;

namespace CodeGenerator
{
    public class TypeGenerator
    {
        public TypeGenerator() { }

        public string GetTextFromType(Type type)
        {
            string outputText = String.Empty;
            
            if (type.Name.Contains("IGeometryNodeVisitor"))
            {
                int a = 0;
            }

             if (type.IsClass || type.IsInterface)
            {
                var generator = new ClassGenerator();
                return generator.GetTextFromType(type);
            }
            else if (type.IsEnum)
            {
                var generator = new EnumGenerator();
                return generator.GetTextFromType(type);
            }
            else if (type.IsValueType)
            {
                var generator = new StructGenerator();
                return generator.GetTextFromType(type);
            }
            else System.Diagnostics.Debug.WriteLine("Type not supported " + type.FullName);

             //TODO insert not typical elements to type

            return string.Empty;
        }
    }
}
