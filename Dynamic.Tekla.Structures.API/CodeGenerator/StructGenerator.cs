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
using System.Linq;
using System.Reflection;
using System.Text;
using Dynamic.Tekla.Structures;

namespace CodeGenerator
{
    public class StructGenerator
    {
        public StructGenerator() { }

        public string GetTextFromType(Type type)
        {
            if (type.IsValueType == false) return string.Empty;

            var sb = new StringBuilder(text.Length * 5);
            sb.Append(text);

            sb.Replace("$structFields", GetFieldsText(type));
            sb.Replace("$fieldsGetTSObject", GetTSObject(type));
            sb.Replace("$fieldsFromTSObject", FromTSObject(type));
            
            sb.Replace("$classname", type.Name);

            return sb.ToString();
        }

        private IEnumerable<FieldInfo> GetFields(Type type)
        {
            return type.GetFields().Where(f => f.IsPublic & !f.DeclaringType.IsEnum);
        }

        private string GetFieldsText(Type type)
        {
            var sb = new StringBuilder(100);
            var fields = GetFields(type);

            foreach (var field in fields)
            {
                sb.Append("\t\t\t");
                sb.Append("public ");
                sb.Append(TypeFullName.GetTypeFullName_WithDynamic(field.FieldType));
                sb.Append(" ");
                sb.Append(field.Name);
                sb.Append(";\n");
            }

            return sb.ToString();
        }

        private string GetTSObject(Type type)
        {
            var sb = new StringBuilder(100);
            var fields = GetFields(type);

            foreach (var field in fields)
            {
                sb.Append("\t\t\t");
                sb.Append("tsType.");
                sb.Append(field.Name);
                sb.Append(" = dynStruct.");
                sb.Append(field.Name);
                sb.Append(";\n");
            }

            return sb.ToString();
        }

        private string FromTSObject(Type type)
        {
            var sb = new StringBuilder(100);
            var fields = GetFields(type);

            foreach (var field in fields)
            {
                sb.Append("\t\t\t");
                sb.Append("dynStruct.");
                sb.Append(field.Name);
                sb.Append(" = tsStruct.");
                sb.Append(field.Name);
                sb.Append(";\n");
            }

            return sb.ToString();
        }

        //private string GetEnumValues(Type type)
        //{
        //    var sb = new StringBuilder(100);

        //    foreach (var value in type.GetEnumValues())
        //    {
        //        sb.Append("\t\t\t");
        //        sb.Append(value);
        //        sb.Append(",\n");
        //    }

        //    if (type.GetEnumValues().Length > 0) sb.Remove(sb.Length - 2, 2);

        //    return sb.ToString();
        //}

        //private string GetSwitch1Values(Type type)
        //{
        //    var sb = new StringBuilder();

        //    foreach (var value in type.GetEnumValues())
        //    {
        //        sb.Append("\t\t\t\tcase $classname.");
        //        sb.Append(value);
        //        sb.Append(":\n\t\t\t\t\treturn System.Enum.Parse(tsType, \"");
        //        sb.Append(value);
        //        sb.Append("\");\n");
        //    }

        //    return sb.ToString();
        //}

        //private string GetSwitch2Values(Type type)
        //{
        //    var sb = new StringBuilder();

        //    int i = 0;
        //    foreach (var value in type.GetEnumValues())
        //    {
        //        sb.Append("\t\t\t");
        //        if (i != 0) sb.Append("else ");
        //        sb.Append("if (tsEnumValue.Equals(\"");
        //        sb.Append(value);
        //        sb.Append("\", System.StringComparison.InvariantCulture))\n");
        //        sb.Append("\t\t\t\treturn $classname.");
        //        sb.Append(value);
        //        sb.Append(";\n");
        //        i++;
        //    }

        //    return sb.ToString();
        //}

        private readonly string text = @"
    public struct $classname
    {
$structFields       
    }

    internal static class $classname_
    {
        public static dynamic GetTSObject($classname dynStruct)
        {
            var tsType = TSActivator.CreateInstance(""$namespace.$classname"");
$fieldsGetTSObject
            return tsType;
        }
    
        public static $classname FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new $classname();
$fieldsFromTSObject 
            return dynStruct;
        }
    }
";
    }
}
