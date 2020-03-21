﻿using System;
using System.Linq;
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

            outputText = outputText.Replace("$constructors", ConstructorsText(type));
            outputText = outputText.Replace("$dproperties", PropertiesText(type));
            outputText = outputText.Replace("$dmethods", MethodsText(type));
            outputText = outputText.Replace("$classname", type.Name);

            var accessor = "public";
            if (type.IsAbstract) accessor = "private";
            outputText = outputText.Replace("$firstConstructorAccessor", accessor);
            
            if (type.Name.ToLower().Equals("object", StringComparison.InvariantCulture))
                outputText = outputText.Replace("$dfield", "@object");
            else if (type.Name.ToLower().Equals("class", StringComparison.InvariantCulture))
                outputText = outputText.Replace("$dfield", "@class");
            else
                outputText = outputText.Replace("$dfield", type.Name.ToLower());
            
            //TODO father class
            outputText = outputText.Replace("$fatherClass", "");

            var nestedTypeGenerator = new TypeGenerator();
            var nestedTypeText = new StringBuilder(1000);
            var nestedTypes = type.GetNestedTypes();

            foreach (var nestedType in nestedTypes)
            {
                nestedTypeText.AppendLine(nestedTypeGenerator.GetTextFromType(nestedType));
            }
            outputText = outputText.Replace("$nestedTypes", nestedTypeText.ToString());
            
            return outputText;
        }
        
        private string ConstructorsText(Type type)
        {
            return string.Empty;
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
            return type.FullName?.StartsWith("Tekla.Structures") ?? false;
        }
        
        private string PropertiesText(Type type)
        {
            var sb = new StringBuilder();
            var properties = type.GetProperties().GroupBy(t => t.Name).Select(t => t.First());  //In one class returned two properties with the same value

            foreach (var property in properties)
            {
                if (IsTeklaType(property.PropertyType))
                {
                    sb.Append("\t\tpublic ");
                    sb.Append(GetTypeFullName(property.PropertyType));
                    sb.Append(" ");
                    sb.Append(property.Name);
                    sb.Append("\n\t\t{" +
                        "\n\t\t\tget => " + GetTypeFullName(property.PropertyType) + "_.FromTSObject($dfield." +
                        "" + property.Name + ");" +
                        "\n\t\t\tset { $dfield." + property.Name + " = " + GetTypeFullName(property.PropertyType) + "_.GetTSObject(value); }" +
                        "\n\t\t}\n\n");
                }
                else
                {
                    sb.Append("\t\tpublic ");
                    sb.Append(GetTypeFullName(property.PropertyType));
                    sb.Append(" ");
                    sb.Append(property.Name);
                    sb.Append("\n\t\t{" +
                        "\n\t\t\tget => $dfield." + property.Name + ";" +
                        "\n\t\t\tset { $dfield." + property.Name + " = value; }" +
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
    public sealed class $classname $fatherClass
    {

$dproperties        

        internal dynamic $dfield;
        
        $firstConstructorAccessor $classname()
        {
            this.$dfield =  TSActivator.CreateInstance(""$namespace.$classname"");
        }

        internal $classname(dynamic tsObject)
        {
            this.$dfield = tsObject;
        }
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
            return new $classname(tsObject);
        }
    }

";
    }
}
