using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeGenerator
{
    public class ClassGenerator
    {
        public ClassGenerator() { }

        public string GetTextFromType(Type type)
        {
            if (!(type.IsClass || type.IsInterface)) return string.Empty;

            string outputText = String.Copy(text);

            if (type.IsAbstract)
                outputText = outputText.Replace("$abstract", "abstract");
            else
                outputText = outputText.Replace("$abstract", "");

            outputText = outputText.Replace("$constructors", ConstructorsText(type));
            outputText = outputText.Replace("$dproperties", PropertiesAndFieldsText(type));
            outputText = outputText.Replace("$dmethods", MethodsText(type));
            outputText = outputText.Replace("$classname", type.Name);

            var accessor = "public";
            if (type.IsAbstract) accessor = "private";
            outputText = outputText.Replace("$firstConstructorAccessor", accessor);


            string baseClassText = string.Empty;
            string dfieldDeclaration = string.Empty;

            if (type.BaseType != null)
            {
                if (IsTeklaType(type.BaseType))
                {
                    baseClassText = " : " + GetTypeFullName(type.BaseType);
                }
                else
                    dfieldDeclaration = "internal dynamic $dfield;";
            }
            else
                dfieldDeclaration = "internal dynamic $dfield;";


            outputText = outputText.Replace("$fieldDeclaration", dfieldDeclaration);
            outputText = outputText.Replace("$dfield", "teklaObject");
            outputText = outputText.Replace("$baseClass", baseClassText);

            var nestedTypeGenerator = new TypeGenerator();
            var nestedTypeText = new StringBuilder(1000);
            var nestedTypes = type.GetNestedTypes();

            foreach (var nestedType in nestedTypes)
            {
                nestedTypeText.AppendLine(nestedTypeGenerator.GetTextFromType(nestedType));
            }
            outputText = outputText.Replace("$nestedTypes", nestedTypeText.ToString());
            outputText = outputText.Replace("$typeFullName", GetTypeFullName(type).Replace("Dynamic.",""));
            outputText = outputText.Replace("$typeDFullDNameDynamic", GetTypeFullName(type));
            
            //
            return outputText;
        }
        
        private string ConstructorsText(Type type)
        {
            var sb = new StringBuilder(500);

            if (type.IsAbstract) return string.Empty;

            if (type.GetConstructors().Any(c => c.GetParameters().Length == 0))
            {
                sb.Append("\t\tpublic $classname()\n\t\t{\n");
                sb.Append("\t\t\tthis.$dfield = TSActivator.CreateInstance(\"$typeFullName\");\n");
                sb.Append("\t\t}\n");
            }
            else sb.Append("\t\tinternal $classname() {}\n");

            sb.Append("\t\t//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument\n");
            sb.Append("\t\tpublic $classname(dynamic tsObject, System.DateTime nonConflictParameter)\n\t\t{\n");
            sb.Append("\t\t\tthis.$dfield = tsObject;\n");
            sb.Append("\t\t}\n");

            var constructors = type.GetConstructors()
                .Where(c => c.GetParameters().Count() > 0)
                .ToList();


            foreach (var constructor in constructors)
            {
                sb.Append("\t\tpublic $classname(");
                foreach (var parameter in constructor.GetParameters())
                {
                    var parameterName = parameter.Name;
                    if (parameter.Name.Equals("object", StringComparison.InvariantCulture))
                        parameterName = "@object";

                    sb.Append(GetTypeFullName(parameter.ParameterType));
                    sb.Append(" ");
                    sb.Append(parameterName);
                    sb.Append(", ");
                }
                if (constructor.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

                sb.Append(")\n");
                sb.Append("\t\t{\n");
                sb.Append("\t\t\tvar args = new object[");
                sb.Append(constructor.GetParameters().Count());
                sb.Append("];\n");

                int i = 0;
                foreach (var parameter in constructor.GetParameters())
                {
                    var parameterName = parameter.Name;
                    if (parameter.Name.Equals("object", StringComparison.InvariantCulture))
                        parameterName = "@object";

                    if (IsTeklaType(parameter.ParameterType))
                    {
                        sb.Append("\t\t\targs["+i+"] = ");
                        sb.Append(CorrectIfArray(GetTypeFullName(parameter.ParameterType)));
                        sb.Append("_.GetTSObject(");
                        sb.Append(parameterName);
                        sb.Append(");\n");
                    }
                    else
                    {
                        sb.Append("\t\t\targs[" + i + "] = ");
                        sb.Append(parameterName);
                        sb.Append(";\n");
                    }
                    i++;
                }

                sb.Append("\t\t\tthis.$dfield = TSActivator.CreateInstance(\"");
                sb.Append(GetTypeFullName(type).Replace("Dynamic.", ""));
                sb.Append("\", args);\n");

                sb.Append("\t\t}\n");
            }

            return sb.ToString();
        }


        private string MethodsText(Type type)
        {
            return MethodGenerator.GetText(type);
        }
        
        private bool IsTeklaType(Type type)
        {
            return type?.FullName?.StartsWith("Tekla.Structures") ?? false;
        }
        
        /// <summary>Generates text from properties and fields. Public fields are made as properties</summary>
        private string PropertiesAndFieldsText(Type type)
        {
            var sb = new StringBuilder();
            var propertiesAndFields = type.GetProperties()
                .GroupBy(t => t.Name)
                .Select(t => t.First())//In one class returned two properties with the same value
                .Where(p => p.DeclaringType.Equals(type) && !p.PropertyType.Namespace.Contains("Internal"))
                .ToList<MemberInfo>();  

            var fields = type.GetFields()
                .GroupBy(t => t.Name)
                .Select(t => t.First())
                .Where(p => p.DeclaringType.Equals(type) && !p.FieldType.Namespace.Contains("Internal"))
                .ToList<MemberInfo>();
            propertiesAndFields.AddRange(fields);

            foreach (var propertyOrField in propertiesAndFields)
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
                    GenerateStatic_FieldOrProperty(ref sb, propertyOrField, currentType, hasGet, hasSet);
                }
                else
                {
                    GenerateNonStatic_FieldOrProperty(ref sb, propertyOrField, currentType, hasGet, hasSet);
                }
            }

            return sb.ToString();
        }

        private void GenerateStatic_FieldOrProperty(ref StringBuilder sb, MemberInfo propertyOrField, Type currentType, bool hasGet, bool hasSet)
        {
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
                    sb.Append("\t\t\tset {  TSActivator.Set_StaticPropertyOrFieldValue(\"$typeFullName\",\"" + propertyOrField.Name +"\","+
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
                    sb.Append("\n\t\t{" + "\n\t\t\tget => ("+ GetTypeFullName(currentType)+
                        ") TSActivator.Get_StaticPropertyOrFieldValue(\"$typeFullName\",\"" + propertyOrField.Name + "\");\n");
                }
                if (hasSet)
                {
                    sb.Append("\t\t\tset { TSActivator.Set_StaticPropertyOrFieldValue(\"$typeFullName\",\"" + propertyOrField.Name + "\", value); }");
                }
                sb.Append("\n\t\t}\n\n");
            }
        }

        private void GenerateNonStatic_FieldOrProperty(ref StringBuilder sb, MemberInfo propertyOrField, Type currentType, bool hasGet, bool hasSet)
        {
            if (IsTeklaType(currentType))
            {
                sb.Append("\t\tpublic ");
                sb.Append(GetTypeFullName(currentType));
                sb.Append(" ");
                sb.Append(propertyOrField.Name);

                if (hasGet)
                {
                    sb.Append("\n\t\t{" +
                    "\n\t\t\tget => " + CorrectIfArray(GetTypeFullName(currentType)) + "_.FromTSObject($dfield." +
                    "" + propertyOrField.Name + ");\n");
                }
                if (hasSet)
                {
                    sb.Append("\t\t\tset { $dfield." + propertyOrField.Name + " = " + CorrectIfArray(GetTypeFullName(currentType)) + "_.GetTSObject(value); }");
                }
                sb.Append("\n\t\t}\n\n");
            }
            else
            {
                sb.Append("\t\tpublic ");
                sb.Append(GetTypeFullName(currentType));
                sb.Append(" ");
                sb.Append(propertyOrField.Name);

                if (hasGet)
                {
                    sb.Append("\n\t\t{" + "\n\t\t\tget => $dfield." + propertyOrField.Name + ";\n");
                }
                if (hasSet)
                {
                    sb.Append("\t\t\tset { $dfield." + propertyOrField.Name + " = value; }");
                }
                sb.Append("\n\t\t}\n\n");
            }
        }

        private string CorrectIfArray(string dynamicTypeFullName)
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

        private string GetTypeFullName(Type type)
        {
            return TypeFullName.GetTypeFullName_WithDynamic(type);
        }

        private readonly string text = @"
    public $abstract class $classname $baseClass
    {

$dproperties        

        $fieldDeclaration

$constructors
$dmethods

$nestedTypes

    }

    internal static class $classname_
    {
        public static dynamic GetTSObject($classname dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.$dfield;
        }

        public static $classname FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = ""Dynamic."" + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = ($typeDFullDNameDynamic)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class $classnameArray_
    {
        public static dynamic GetTSObject($classname[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add($classname_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static $classname[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<$classname>();
            foreach(var tsItem in tsArray)
            {
                list.Add($classname_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }

";
    }
}
