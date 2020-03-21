﻿using System;
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

            //if (type.IsAbstract)
            //    outputText = outputText.Replace("$abstract", "abstract");
            //else
                outputText = outputText.Replace("$abstract", "");

            outputText = outputText.Replace("$constructors", ConstructorsText(type));
            outputText = outputText.Replace("$dproperties", PropertiesAndFieldsText(type));
            outputText = outputText.Replace("$dmethods", MethodsText(type));
            outputText = outputText.Replace("$classname", type.Name);

            var accessor = "public";
            if (type.IsAbstract) accessor = "private";
            outputText = outputText.Replace("$firstConstructorAccessor", accessor);

            outputText = outputText.Replace("$dfield", "teklaObject");

            string baseClassText = string.Empty;

            if (type.BaseType != null)
            {
                if (IsTeklaType(type.BaseType))
                    baseClassText = " : " + GetTypeFullName(type.BaseType); 
            }

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
            
            if (type.GetConstructors().Any(c => c.GetParameters().Count() == 0) && !type.IsAbstract)
            {
                sb.Append("\t\tpublic $classname()\n\t\t{\n");
                sb.Append("\t\t\tthis.$dfield = TSActivator.CreateInstance(\"$typeFullName\");\n");
                sb.Append("\t\t}\n");
            }
            else sb.Append("\t\tinternal $classname() {}\n");

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
            var sb = new StringBuilder();
            var methods = type.GetMethods().Where(
                m => m.IsPublic 
                && !m.ReturnType.ToString().Contains("Tekla.Structures.ModelInternal")
                && !m.GetParameters().Any(p => p.ParameterType.ToString().Contains("Tekla.Structures.ModelInternal"))
                );

            foreach (var method in methods)
            {
                if (method.ReturnType.IsInterface) continue;

                var name = method.Name;
                if (name.Equals("GetType")||name.Equals("Equals")||name.Equals("ToString") || name.Equals("GetHashCode")) continue;


                if (name.Contains("get_") || name.Contains("set_")) continue;
                
                sb.Append("\t\t");
                sb.Append("public ");
                
                if (IsTeklaType(method.ReturnType))
                {
                    sb.Append(GetTypeFullName(method.ReturnType).Replace("System.Void", "void"));
                    sb.Append(" ");
                    sb.Append(name);
                    sb.Append("(");

                    foreach (var param in method.GetParameters())
                    {
                        if (param.ParameterType.IsByRef) sb.Append("ref ");
                        //if (param.IsOut) sb.Append("out ");
                        sb.Append(GetTypeFullName(param.ParameterType));
                        sb.Append(" ");
                        sb.Append(param.Name);
                        sb.Append(", ");
                    }
                    if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

                    sb.Append(")\n\t\t\t => ");
                    sb.Append(GetTypeFullName(method.ReturnType));
                    sb.Append("_.FromTSObject($dfield.");
                    sb.Append(name);
                    sb.Append("(");

                    foreach (var param in method.GetParameters())
                    {
                        if (param.ParameterType.IsByRef) sb.Append("ref ");
                        //if (param.IsOut) sb.Append("out ");
                        
                        if (IsTeklaType(param.ParameterType))
                        {
                            sb.Append(GetTypeFullName(param.ParameterType));
                            sb.Append("_.GetTSObject(");
                            sb.Append(param.Name);
                            sb.Append(")");
                        }
                        else
                            sb.Append(param.Name);
                        sb.Append(", ");
                    }
                    if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

                    sb.Append("));");
                }
                else
                {
                    var typeFullName = GetTypeFullName(method.ReturnType);

                    sb.Append(typeFullName.Replace("System.Void", "void"));
                    sb.Append(" ");
                    sb.Append(name);
                    sb.Append("(");

                    foreach (var param in method.GetParameters())
                    {
                        var paramName = param.Name;
                        if (paramName.Equals("object", StringComparison.InvariantCulture))
                            paramName = "@object";

                        //if (param.ParameterType.IsByRef) sb.Append("ref ");
                        //if (param.IsOut) sb.Append("out ");

                        var paramTypeFullName = GetTypeFullName(param.ParameterType);
                        sb.Append(paramTypeFullName);
                        sb.Append(" ");
                        sb.Append(paramName);
                        sb.Append(", ");
                    }
                    if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

                    sb.Append(")\n\t\t\t => ");
                    sb.Append("$dfield.");
                    sb.Append(name);
                    sb.Append("(");

                    foreach (var param in method.GetParameters())
                    {
                        var paramName = param.Name;
                        if (paramName.Equals("object", StringComparison.InvariantCulture))
                            paramName = "@object";

                        // if (param.ParameterType.IsByRef) sb.Append("ref ");
                        //if (param.IsOut) sb.Append("out ");

                        if (IsTeklaType(param.ParameterType))
                        {
                            sb.Append(GetTypeFullName(param.ParameterType));
                            sb.Append("_.GetTSObject(");
                            sb.Append(paramName);
                            sb.Append(")");
                        }
                        else
                            sb.Append(paramName);

                        sb.Append(", ");
                    }
                    if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

                    sb.Append(");");
                }

                sb.Append("\n\n");
            }

            
            return sb.ToString();
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
                .ToList<MemberInfo>();  

            var fields = type.GetFields()
                .Where(f => f.IsPublic & f.IsStatic == false)
                .GroupBy(t => t.Name)
                .Select(t => t.First()).ToList<MemberInfo>();
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

        internal dynamic $dfield;

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
            return new $classname() { teklaObject = tsObject };
        }
    }

";
    }
}
