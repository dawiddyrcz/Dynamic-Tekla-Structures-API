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
            //
            return outputText;
        }
        
        private string ConstructorsText(Type type)
        {
            var sb = new StringBuilder(500);

            if (type.IsAbstract) return string.Empty;

            if (type.GetConstructors().Any(c => c.GetParameters().Count() == 0))
            {
                sb.Append("\t\tpublic $classname()\n\t\t{\n");
                sb.Append("\t\t\tthis.$dfield = TSActivator.CreateInstance(\"$typeFullName\");\n");
                sb.Append("\t\t}\n");
            }
            else sb.Append("\t\tpublic $classname() {}\n"); 


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
                        sb.Append(GetTypeFullName(parameter.ParameterType));
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

        /*
         
            
         public System.Boolean GetPhase(out Dynamic.Tekla.Structures.Model.Phase phase)
		{
            dynamic ph = null;
            var result = teklaObject.GetPhase(out ph);
            phase = Dynamic.Tekla.Structures.Model.Phase_.FromTSObject(ph);
            return result;
		}

         */


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
                .Where(p => p.DeclaringType.Equals(type))
                .ToList<MemberInfo>();  

            var fields = type.GetFields()
                .Where(f => f.IsPublic & f.IsStatic == false)
                .GroupBy(t => t.Name)
                .Select(t => t.First())
                .Where(p => p.DeclaringType.Equals(type))
                .ToList<MemberInfo>();
            propertiesAndFields.AddRange(fields);

            foreach (var propertyOrField in propertiesAndFields)
            {
                Type currentType = null;

                if (propertyOrField is PropertyInfo pi)
                    currentType = pi.PropertyType;
                else if (propertyOrField is FieldInfo fi)
                    currentType = fi.FieldType;

                if (IsTeklaType(currentType))
                {
                    sb.Append("\t\tpublic ");
                    sb.Append(GetTypeFullName(currentType));
                    sb.Append(" ");
                    sb.Append(propertyOrField.Name);
                    sb.Append("\n\t\t{" +
                        "\n\t\t\tget => " + GetTypeFullName(currentType) + "_.FromTSObject($dfield." +
                        "" + propertyOrField.Name + ");" +
                        "\n\t\t\tset { $dfield." + propertyOrField.Name + " = " + GetTypeFullName(currentType) + "_.GetTSObject(value); }" +
                        "\n\t\t}\n\n");
                }
                else
                {
                    sb.Append("\t\tpublic ");
                    sb.Append(GetTypeFullName(currentType));
                    sb.Append(" ");
                    sb.Append(propertyOrField.Name);
                    sb.Append("\n\t\t{" +
                        "\n\t\t\tget => $dfield." + propertyOrField.Name + ";" +
                        "\n\t\t\tset { $dfield." + propertyOrField.Name + " = value; }" +
                        "\n\t\t}\n\n");
                }
            }

            return sb.ToString();
        }

        private string GetTypeFullName(Type type)
        {
            return TypeFullName.GetTypeFullName(type);
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
            return dynObject.$dfield;
        }

        public static $classname FromTSObject(dynamic tsObject)
        {
            var typeName = ""Dynamic."" + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = ($typeFullName)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

";
    }
}
