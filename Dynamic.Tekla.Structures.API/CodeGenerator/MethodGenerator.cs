/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public static class MethodGenerator
    {
        public static string GetText(Type type)
        {
            var sb = new StringBuilder();
            var methods = GetMethodsFromType(type);

            foreach (var method in methods)
            {
                if (type.Name.Equals("Polymesh", StringComparison.InvariantCulture) && method.Name.Equals("Validate", StringComparison.InvariantCulture)) continue;
                if (method.ReturnType.IsInterface) continue;

                var name = method.Name;
                if (name.Equals("GetType") || name.Equals("Equals") || name.Equals("ToString") || name.Equals("GetHashCode")) continue;
                if (name.Contains("get_") || name.Contains("set_")) continue;
                if (method.GetParameters().Any(p => p.IsOut && IsTeklaType(p.ParameterType))) continue;

                if (method.IsStatic)
                {
                    if (IsTeklaType(method.ReturnType))
                    {
                        Static_GenerateForTeklaReturnType(sb, method, name, type);
                    }
                    else
                    {
                        Static_GenerateForNotTeklaReturnType(sb, method, name, type);
                    }
                }
                else
                {
                    if (IsTeklaType(method.ReturnType))
                    {
                        NonStatic_GenerateForTeklaReturnType(sb, method, name);
                    }
                    else
                    {
                        NonStatic_GenerateForNotTeklaReturnType(sb, method, name);
                    }
                }

                sb.Append("\n\n");
            }

            sb.Append(AditionalMethods(type));
            return sb.ToString();
        }

        private static void NonStatic_GenerateForNotTeklaReturnType(StringBuilder sb, MethodInfo method, string name)
        {
            sb.Append("\t\t");
            sb.Append("public ");
            var typeFullName = GetTypeFullName(method.ReturnType).Replace("System.Void", "void");

            sb.Append(typeFullName);
            sb.Append(" ");
            sb.Append(name);
            sb.Append("(");

            //params in method name
            foreach (var param in method.GetParameters())
            {
                var paramName = param.Name;
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                if (param.IsOut) sb.Append("out ");
                else if (param.ParameterType.IsByRef) sb.Append("ref ");

                var paramTypeFullName = GetTypeFullName(param.ParameterType);
                sb.Append(paramTypeFullName);
                sb.Append(" ");
                sb.Append(paramName);
                sb.Append(", ");
            }
            if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

            sb.Append(")\n\t\t{\n");
            sb.Append("\t\t\t");
            if (!typeFullName.Equals("void")) sb.Append("return ");
            sb.Append("$dfield.");
            sb.Append(name);
            sb.Append("(");

            //params in method body
            foreach (var param in method.GetParameters())
            {
                var paramName = param.Name;
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                //it is not possible to out dynamic parameters so it will be moved to extension methods
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
                {
                    if (param.IsOut) sb.Append("out ");
                    else if (param.ParameterType.IsByRef) sb.Append("ref ");
                    sb.Append(paramName);
                }

                sb.Append(", ");
            }
            if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

            sb.Append(");\n\t\t}");
        }

        private static void Static_GenerateForNotTeklaReturnType(StringBuilder sb, MethodInfo method, string name, Type type)
        {
            sb.Append("\t\t");
            sb.Append("public static ");
            var typeFullName = GetTypeFullName(method.ReturnType).Replace("System.Void", "void");

            sb.Append(typeFullName);
            sb.Append(" ");
            sb.Append(name);
            sb.Append("(");

            bool anyParameterIsRefOrOut = false;
            var parameters = method.GetParameters();
            //params in method name
            foreach (var param in parameters)
            {
                var paramName = param.Name;
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                //if (param.IsOut)
                //{
                //    sb.Append("out ");
                //    anyParameterIsRefOrOut = true;
                //}
                //else if (param.ParameterType.IsByRef)
                //{
                //    sb.Append("ref ");
                //    anyParameterIsRefOrOut = true;
                //}

                var paramTypeFullName = GetTypeFullName(param.ParameterType);
                sb.Append(paramTypeFullName);
                sb.Append(" ");
                sb.Append(paramName);
                sb.Append(", ");
            }
            if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

            sb.Append(")\n\t\t{\n");
            sb.Append("\t\t\tvar parameters = new object[" + parameters.Count() + "];\n");

            for (int i = 0; i < parameters.Count(); i++)
            {
                if (IsTeklaType(parameters[i].ParameterType))
                {
                    sb.Append("\t\t\tparameters[" + i + "] = ");
                    sb.Append(GetTypeFullName(parameters[i].ParameterType) + "_.GetTSObject(" + parameters[i].Name + ");\n");
                }
                else
                    sb.Append("\t\t\tparameters["+ i +"] = " + parameters[i].Name + ";\n");
            }

            sb.Append("\t\t\t");
            sb.Append("var result = (" + GetTypeFullName(method.ReturnType) + ") ");
            sb.Append("TSActivator.InvokeStaticMethod(\"");
            sb.Append(GetTypeFullName(type).Replace("Dynamic.", ""));
            sb.Append("\", \"");
            sb.Append(method.Name);
            sb.Append("\", parameters);\n");

            if (!typeFullName.Equals("void"))
            {
                sb.Append("\t\t\treturn result;");

            }
            sb.Append("\t\t}");
        }

        private static void NonStatic_GenerateForTeklaReturnType(StringBuilder sb, MethodInfo method, string name)
        {
            sb.Append("\t\t");
            sb.Append("public ");
            //if (method.IsStatic) sb.Append("static "); //TODO static methods should have different template ;(
            sb.Append(GetTypeFullName(method.ReturnType).Replace("System.Void", "void"));
            sb.Append(" ");
            sb.Append(name);
            sb.Append("(");

            //params in method name
            foreach (var param in method.GetParameters())
            {

                if (param.IsOut) sb.Append("out ");
                else if (param.ParameterType.IsByRef) sb.Append("ref ");

                sb.Append(GetTypeFullName(param.ParameterType));
                sb.Append(" ");
                sb.Append(param.Name);
                sb.Append(", ");
            }
            if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

            sb.Append(")\n\t\t{\n");
            sb.Append("\t\t\treturn ");
            sb.Append(GetTypeFullName(method.ReturnType));
            sb.Append("_.FromTSObject($dfield.");
            sb.Append(name);
            sb.Append("(");

            //params in method body
            foreach (var param in method.GetParameters())
            {
                if (IsTeklaType(param.ParameterType))
                {
                    sb.Append(GetTypeFullName(param.ParameterType));
                    sb.Append("_.GetTSObject(");
                    sb.Append(param.Name);
                    sb.Append(")");
                }
                else
                {
                    if (param.IsOut) sb.Append("out ");
                    else if (param.ParameterType.IsByRef) sb.Append("ref ");

                    sb.Append(param.Name);
                }
                sb.Append(", ");
            }
            if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

            sb.Append("));\n\t\t}");
        }

        private static void Static_GenerateForTeklaReturnType(StringBuilder sb, MethodInfo method, string name, Type type)
        {
            sb.Append("\t\t");
            sb.Append("public static ");
            var typeFullName = GetTypeFullName(method.ReturnType).Replace("System.Void", "void");

            sb.Append(typeFullName);
            sb.Append(" ");
            sb.Append(name);
            sb.Append("(");

            bool anyParameterIsRefOrOut = false;
            var parameters = method.GetParameters();
            //params in method name
            foreach (var param in parameters)
            {
                var paramName = param.Name;
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                //if (param.IsOut)
                //{
                //    sb.Append("out ");
                //    anyParameterIsRefOrOut = true;
                //}
                //else if (param.ParameterType.IsByRef)
                //{
                //    sb.Append("ref ");
                //    anyParameterIsRefOrOut = true;
                //}

                var paramTypeFullName = GetTypeFullName(param.ParameterType);
                sb.Append(paramTypeFullName);
                sb.Append(" ");
                sb.Append(paramName);
                sb.Append(", ");
            }
            if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

            sb.Append(")\n\t\t{\n");
            sb.Append("\t\t\tvar parameters = new object[" + parameters.Count() + "];\n");

            for (int i = 0; i < parameters.Count(); i++)
            {
                if (IsTeklaType(parameters[i].ParameterType))
                {
                    sb.Append("\t\t\tparameters[" + i + "] = ");
                    sb.Append(GetTypeFullName(parameters[i].ParameterType) + "_.GetTSObject(" + parameters[i].Name + ");\n");
                }
                else
                    sb.Append("\t\t\tparameters[" + i + "] = " + parameters[i].Name + ";\n");
            }
            
            sb.Append("\t\t\tdynamic result = TSActivator.InvokeStaticMethod(\"");
            sb.Append(GetTypeFullName(type).Replace("Dynamic.", ""));
            sb.Append("\", \"");
            sb.Append(method.Name);
            sb.Append("\", parameters);\n");

            sb.Append("\t\t\treturn ");
            sb.Append(GetTypeFullName(method.ReturnType) + "_.FromTSObject(result);\n");
            sb.Append("\t\t}");
        }

        private static List<MethodInfo> GetMethodsFromType(Type type)
        {
            return type.GetMethods().Where(
                m => m.IsPublic
                && !m.ReturnType.ToString().Contains("Tekla.Structures.ModelInternal")
                && !m.GetParameters().Any(p => p.ParameterType.ToString().Contains("Tekla.Structures.ModelInternal"))
                && m.DeclaringType.Equals(type))
                .ToList();
        }

        private static bool IsTeklaType(Type type)
        {
            return type?.FullName?.StartsWith("Tekla.Structures") ?? false;
        }

        private static string GetTypeFullName(Type type)
        {
            return TypeFullName.GetTypeFullName(type);
        }


        private static string AditionalMethods(Type type)
        {
            if (type.Name.Equals("PhaseCollection"))
            {
                return @"
        public System.Collections.IEnumerator GetEnumerator()
        {
            var list = new System.Collections.Generic.List<Phase>();
            foreach (var tsPhase in teklaObject)
            {
                list.Add(Phase_.FromTSObject(tsPhase));
            }
            return list.GetEnumerator();
        }

";
            }

            return string.Empty;
        }

    }
}
