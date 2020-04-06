/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

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
            return string.Empty;
        }
    }
}
