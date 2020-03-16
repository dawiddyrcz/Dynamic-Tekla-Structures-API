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

            if (type.IsClass)
            {
                var generator = new ClassGenerator();
                return generator.GetTextFromType(type);
            }
            else if (type.IsEnum)
            {
                var generator = new EnumGenerator();
                return generator.GetTextFromType(type);
            }
            else System.Diagnostics.Debug.WriteLine("Type not supported " + type.FullName);

            return string.Empty;
        }
    }
}
