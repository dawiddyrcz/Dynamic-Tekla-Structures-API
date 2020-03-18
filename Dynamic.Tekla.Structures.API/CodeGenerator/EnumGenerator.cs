using System;
using System.IO;
using System.Text;

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

            sb.Replace("$enumValues", GetEnumValues(type));
            sb.Replace("$switch1Values", GetSwitch1Values(type));
            sb.Replace("$switch2Values", GetSwitch2Values(type));
            
            sb.Replace("$classname", type.Name);

            return sb.ToString();
        }

        private string GetEnumValues(Type type)
        {
            var sb = new StringBuilder(100);

            foreach (var value in type.GetEnumValues())
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

            foreach (var value in type.GetEnumValues())
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
            foreach (var value in type.GetEnumValues())
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
            var tsType = TSActivator.CreateInstance(""$namespace.$classname"");

            switch (dynEnum)
            {
$switch1Values
                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + ""- enum value is not implemented"");
            }
        }
    
        public static $classname FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString(""G"", System.Globalization.CultureInfo.InvariantCulture);
            
$switch2Values
            else 
                throw new System.NotImplementedException(tsEnumValue + ""- enum value is not implemented"");
            
        }
    }
";
    }
}
