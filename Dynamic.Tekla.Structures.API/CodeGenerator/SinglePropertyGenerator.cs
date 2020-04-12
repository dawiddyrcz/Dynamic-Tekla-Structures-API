/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using Dynamic.Tekla.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public static class SinglePropertyGenerator
    {
        public static string GetCode(MemberInfo propertyOrField)
        {
            Type currentType = null;

            var hasGet = false;
            var hasSet = false;
            var isStatic = false;

            if (propertyOrField is PropertyInfo pi)
            {
                currentType = pi.PropertyType;
                hasGet = pi.GetMethod != null;
                hasSet = pi.SetMethod != null;
                isStatic = pi.GetMethod.IsStatic;
            }
            else if (propertyOrField is FieldInfo fi)
            {
                currentType = fi.FieldType;
                hasGet = true;
                hasSet = !(fi.IsInitOnly || fi.IsLiteral);
                isStatic = fi.IsStatic;
            }

            if (isStatic)
            {
                //return GenerateStatic_FieldOrProperty(propertyOrField, currentType, hasGet, hasSet);
                return StaticProperty(propertyOrField, currentType, hasGet, hasSet);
            }
            else
            {
                return NonStaticProperty(propertyOrField, currentType, hasGet, hasSet);
                //return GenerateNonStatic_FieldOrProperty(propertyOrField, currentType, hasGet, hasSet);
            }
        }

        private static string StaticProperty(MemberInfo propertyOrField, Type currentType, bool hasGet, bool hasSet)
        {
            var typeFullNameWithDynamic = TypeFullName.GetTypeFullName_WithDynamic(currentType);

            string staticGet = string.Empty;
            if (hasGet) staticGet = GetStaticGet(propertyOrField, currentType);
            string staticSet = string.Empty;
            if (hasSet) staticSet = GetStaticSet(propertyOrField, currentType);

            return $@"
    public static {typeFullNameWithDynamic} {propertyOrField.Name}
    {{
        {staticGet}
        {staticSet}
    }}";
        }

        private static string GetStaticGet(MemberInfo propertyOrField, Type propertyOrFieldType)
        {

            var propTypeFullName = TypeFullName.GetTypeFullName_WithDynamic(propertyOrFieldType);
            string valueConverter = $"return ({propTypeFullName}) value;";

            if (Converters.HaveToBeConverted(propertyOrFieldType))
            {
                valueConverter = Converters.FromTSObjects(propertyOrFieldType, "value", "var value_");
                valueConverter += $"\n\treturn ({propTypeFullName}) value_;";
            }

            return $@"get
        {{
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue(""$typeFullName"", ""{propertyOrField.Name}"");
            {valueConverter}
        }}";
        }

        private static string GetStaticSet(MemberInfo propertyOrField, Type propertyOrFieldType)
        {
            string valueConverter = "var value_ = value;";

            if (Converters.HaveToBeConverted(propertyOrFieldType))
                valueConverter = Converters.ToTSObjects(propertyOrFieldType, "value", "var value_");

            return $@"set
        {{
            {valueConverter}
            PropertyInvoker.SetStaticPropertyOrFieldValue(""$typeFullName"", ""{propertyOrField.Name}"", value_);
        }}";
        }

        private static string NonStaticProperty(MemberInfo propertyOrField, Type currentType, bool hasGet, bool hasSet)
        {
            var typeFullNameWithDynamic = TypeFullName.GetTypeFullName_WithDynamic(currentType);

            string nonstaticGet = string.Empty;
            if (hasGet) nonstaticGet = GetNonStaticGet(propertyOrField, currentType);
            string nonstaticSet = string.Empty;
            if (hasSet) nonstaticSet = GetNonStaticSet(propertyOrField, currentType);

            return $@"
    public {typeFullNameWithDynamic} {propertyOrField.Name}
    {{
        {nonstaticGet}
        {nonstaticSet}
    }}
";
        }

        private static string GetNonStaticGet(MemberInfo propertyOrField, Type propertyOrFieldType)
        {
            string getCode = string.Empty;

            if (Converters.HaveToBeConverted(propertyOrFieldType))
            {
                getCode = $@"
                var value = teklaObject.{propertyOrField.Name};
                {Converters.FromTSObjects(propertyOrFieldType, "value", "var value_")}
                return ({TypeFullName.GetTypeFullName_WithDynamic(propertyOrFieldType)}) value_;";
            }
            else
            {
                getCode = $@"
                return teklaObject.{ propertyOrField.Name};";
            }

            return $@"get
        {{
            try
            {{{getCode}
            }}
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {{
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof({propertyOrField.Name}), ex); 
            }}
        }}";
        }

        private static string GetNonStaticSet(MemberInfo propertyOrField, Type propertyOrFieldType)
        {
            string setCode = string.Empty;

            if (Converters.HaveToBeConverted(propertyOrFieldType))
            {
                setCode = $@"
                {Converters.ToTSObjects(propertyOrFieldType, "value", "var value_")}
                teklaObject.{propertyOrField.Name} = value_;";
            }
            else
            {
                setCode = $@"
                teklaObject.{ propertyOrField.Name} = value;";
            }

            return $@"set
        {{
            try
            {{{setCode}
            }}
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {{
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof({propertyOrField.Name}), ex); 
            }}
        }}";
        }
        
        private static string GenerateStatic_FieldOrProperty(MemberInfo propertyOrField, Type currentType, bool hasGet, bool hasSet)
        {
            var sb = new StringBuilder();
            if (IsTeklaType(currentType))
            {
                sb.Append("\t\tpublic static ");
                sb.Append(GetTypeFullName(currentType));
                sb.Append(" ");
                sb.Append(propertyOrField.Name);

                if (hasGet)
                {
                    sb.Append("\n\t\t{" +
                    "\n\t\t\tget => " + CorrectIfArray(GetTypeFullName(currentType)) +
                    "_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue(\"$typeFullName\",\""
                     + propertyOrField.Name + "\"));\n");
                }
                if (hasSet)
                {
                    sb.Append("\t\t\tset {  TSActivator.Set_StaticPropertyOrFieldValue(\"$typeFullName\",\"" + propertyOrField.Name + "\"," +
                        CorrectIfArray(GetTypeFullName(currentType)) +
                        "_.GetTSObject(value)); }");
                }
                sb.Append("\n\t\t}\n\n");
            }
            else
            {
                sb.Append("\t\tpublic static ");
                sb.Append(GetTypeFullName(currentType));
                sb.Append(" ");
                sb.Append(propertyOrField.Name);

                if (hasGet)
                {
                    sb.Append("\n\t\t{" + "\n\t\t\tget => (" + GetTypeFullName(currentType) +
                        ") TSActivator.Get_StaticPropertyOrFieldValue(\"$typeFullName\",\"" + propertyOrField.Name + "\");\n");
                }
                if (hasSet)
                {
                    sb.Append("\t\t\tset { TSActivator.Set_StaticPropertyOrFieldValue(\"$typeFullName\",\"" + propertyOrField.Name + "\", value); }");
                }
                sb.Append("\n\t\t}\n\n");
            }
            return sb.ToString();
        }

        private static string GenerateNonStatic_FieldOrProperty(MemberInfo propertyOrField, Type propertyOrFieldType, bool hasGet, bool hasSet)
        {
            var sb = new StringBuilder();

            if (IsTeklaType(propertyOrFieldType))
            {
                sb.Append("\t\tpublic ");
                sb.Append(GetTypeFullName(propertyOrFieldType));
                sb.Append(" ");
                sb.Append(propertyOrField.Name);

                if (hasGet)
                {
                    sb.Append("\n\t\t{");
                    sb.Append("\n\t\t\tget\n\t\t\t{\n");
                    sb.Append("\t\t\t\ttry {\n");
                    sb.Append("\t\t\t\treturn ");
                    sb.Append(CorrectIfArray(GetTypeFullName(propertyOrFieldType)));
                    sb.Append("_.FromTSObject($dfield.");
                    sb.Append(propertyOrField.Name);
                    sb.Append(");\n");
                    sb.Append("\t\t\t\t} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)\n");
                    sb.Append("\t\t\t\t { throw DynamicAPINotFoundException.CouldNotFindProperty(\"" + propertyOrField.Name + "\", ex); }\n");
                    sb.Append("\t\t\t}\n");
                }
                if (hasSet)
                {
                    sb.Append("\t\t\tset\n\t\t\t{\n");
                    sb.Append("\t\t\t\ttry {\n");
                    sb.Append("\t\t\t\t$dfield.");
                    sb.Append(propertyOrField.Name);
                    sb.Append(" = ");
                    sb.Append(CorrectIfArray(GetTypeFullName(propertyOrFieldType)));
                    sb.Append("_.GetTSObject(value);\n");
                    sb.Append("\t\t\t\t} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)\n");
                    sb.Append("\t\t\t\t { throw DynamicAPINotFoundException.CouldNotFindProperty(\"" + propertyOrField.Name + "\", ex); }\n");
                    sb.Append("\t\t\t}\n");
                }
                sb.Append("\t\t}\n\n");
            }
            else
            {
                sb.Append("\t\tpublic ");
                sb.Append(GetTypeFullName(propertyOrFieldType));
                sb.Append(" ");
                sb.Append(propertyOrField.Name);

                if (hasGet)
                {
                    sb.Append("\n\t\t{\n");
                    sb.Append("\t\t\tget\n\t\t\t{\n");
                    sb.Append("\t\t\t\ttry {\n");

                    if (propertyOrFieldType.Equals(typeof(System.Collections.ArrayList)))
                    {
                        sb.Append("\t\t\t\t\treturn TSActivator.ConvertArrayList($dfield.");
                        sb.Append(propertyOrField.Name);
                        sb.Append(")");
                    }
                    else
                    {
                        sb.Append("\t\t\t\t\treturn $dfield.");
                        sb.Append(propertyOrField.Name);
                    }

                    sb.Append(";\n");
                    sb.Append("\t\t\t\t} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)\n");
                    sb.Append("\t\t\t\t { throw DynamicAPINotFoundException.CouldNotFindProperty(\"" + propertyOrField.Name + "\", ex); }\n");
                    sb.Append("\t\t\t}\n");
                }
                if (hasSet)
                {
                    sb.Append("\t\t\tset\n\t\t\t{\n");
                    sb.Append("\t\t\t\ttry {\n");
                    sb.Append("\t\t\t\t\t$dfield.");
                    sb.Append(propertyOrField.Name);
                    sb.Append(" = ");

                    if (propertyOrFieldType.Equals(typeof(System.Collections.ArrayList)))
                    {
                        sb.Append("TSActivator.ConvertToTSArrayList(value);");
                    }
                    else
                    {
                        sb.Append("value;");
                    }

                    sb.Append("\n");
                    sb.Append("\t\t\t\t} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)\n");
                    sb.Append("\t\t\t\t { throw DynamicAPINotFoundException.CouldNotFindProperty(\"" + propertyOrField.Name + "\", ex); }\n");
                    sb.Append("\t\t\t}");
                }
                sb.Append("\n\t\t}\n\n");
            }
            return sb.ToString();
        }

        private static string CorrectIfArray(string dynamicTypeFullName)
        {
            if (dynamicTypeFullName.StartsWith("Dynamic."))
            {
                if (dynamicTypeFullName.EndsWith("[]"))
                {
                    return dynamicTypeFullName.Substring(0, dynamicTypeFullName.Length - 2) + "Array";
                }
                else return dynamicTypeFullName;
            }
            else return dynamicTypeFullName;
        }

        private static string GetTypeFullName(Type type)
        {
            return TypeFullName.GetTypeFullName_WithDynamic(type);
        }


        private static bool IsTeklaType(Type type)
        {
            return type?.FullName?.StartsWith("Tekla.Structures") ?? false;
        }

    }
}
