/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using Dynamic.Tekla.Structures;

namespace CodeGenerator
{
    public class EnumGenerator
    {
        public EnumGenerator() { }

        public string GetTextFromType(Type type)
        {
            if (type.IsEnum == false) return string.Empty;

            var sb = new StringBuilder(text.Length * 5);
            sb.Append(text);

            sb.Replace("$enumValues", GetEnumValuesText(type));
            sb.Replace("$switch1Values", GetSwitch1Values(type));
            sb.Replace("$switch2Values", GetSwitch2Values(type));
            
            sb.Replace("$classname", type.Name);
            sb.Replace("$typeFullName", TypeFullName.GetTypeFullName_WithDynamic(type).Replace("Dynamic.",""));
            
            return sb.ToString();
        }

        private Array GetEnumValues(Type type)
        {
            var output = new List<object>();
            foreach(var value in type.GetEnumValues())
            {
                if (!output.Contains(value))
                    output.Add(value);
            }
            return output.ToArray();
        }

        private string GetEnumValuesText(Type type)
        {
            var sb = new StringBuilder(100);

            foreach (var value in GetEnumValues(type))
            {
                sb.Append("\t\t\t");
                sb.Append(value);
                sb.Append(",\n");
            }

            if (type.GetEnumValues().Length > 0) sb.Remove(sb.Length - 2, 2);

            return sb.ToString();
        }

        private string GetSwitch1Values(Type type)
        {
            var sb = new StringBuilder();

            foreach (var value in GetEnumValues(type))
            {
                sb.Append("\t\t\t\tcase $classname.");
                sb.Append(value);
                sb.Append(":\n\t\t\t\t\treturn System.Enum.Parse(tsType, \"");
                sb.Append(value);
                sb.Append("\");\n");
            }

            return sb.ToString();
        }

        private string GetSwitch2Values(Type type)
        {
            var sb = new StringBuilder();

            int i = 0;
            foreach (var value in GetEnumValues(type))
            {
                sb.Append("\t\t\t");
                if (i != 0) sb.Append("else ");
                sb.Append("if (tsEnumValue.Equals(\"");
                sb.Append(value);
                sb.Append("\", System.StringComparison.InvariantCulture))\n");
                sb.Append("\t\t\t\treturn $classname.");
                sb.Append(value);
                sb.Append(";\n");
                i++;
            }

            return sb.ToString();
        }

        private readonly string text = @"
    public enum $classname
    {
$enumValues        
    }

    internal static class $classname_
    {
        public static dynamic GetTSObject($classname dynEnum)
        {
            var tsType = TSActivator.CreateInstance(""$typeFullName"").GetType();

            switch (dynEnum)
            {
$switch1Values
                default:
                    throw new DynamicAPIException(dynEnum.ToString() + ""- enum value is not implemented"");
            }
        }
    
        public static $classname FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString(""G"", System.Globalization.CultureInfo.InvariantCulture);
            
$switch2Values
            else 
                throw new DynamicAPIException(tsEnumValue + ""- enum value is not implemented"");
            
        }
    }
";
    }
}
