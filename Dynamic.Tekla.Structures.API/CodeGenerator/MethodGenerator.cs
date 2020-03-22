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

                //if (method.IsStatic) sb.Append("static "); //TODO static methods should have different template ;(

                if (IsTeklaType(method.ReturnType))
                {
                    GenerateForTeklaReturnType(sb, method, name);
                }
                else
                {
                    GenerateForNotTeklaReturnType(sb, method, name);
                }

                sb.Append("\n\n");
            }


            return sb.ToString();
        }

        private static void GenerateForNotTeklaReturnType(StringBuilder sb, MethodInfo method, string name)
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

        private static void GenerateForTeklaReturnType(StringBuilder sb, MethodInfo method, string name)
        {
            sb.Append("\t\t");
            sb.Append("public ");
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

    }
}
