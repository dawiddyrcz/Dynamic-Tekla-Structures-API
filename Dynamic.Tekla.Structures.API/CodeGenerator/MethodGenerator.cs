/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Dynamic.Tekla.Structures;

namespace CodeGenerator
{
    public static class MethodGenerator
    {
        public static string GetText(Type type)
        {
            var sb = new StringBuilder();
            var methods = GetMethodsFromType(type).Where(m=>!m.IsSpecialName);

            foreach (var method in methods)
            {
                if (type.Name.Equals("Polymesh", StringComparison.InvariantCulture) && method.Name.Equals("Validate", StringComparison.InvariantCulture)) continue;
                if (method.ReturnType.IsInterface) continue;
                if (method.GetBaseDefinition() != method) continue;

                if (method.GetParameters().Length == 1)
                {
                    if (method.GetParameters()[0].ParameterType.Equals(typeof(System.Type[])))
                    {
                        continue;
                    }
                }

                var name = method.Name;
                if (name.Equals("GetType") || name.Equals("Equals") || name.Equals("ToString") || name.Equals("GetHashCode")) continue;
               

                if (type.Name.Equals("Beam") && method.Name.Equals("Insert"))
                {
                    var m = method;
                }

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
                    if (method.GetParameters().Any(p => p.IsOut && IsTeklaType(p.ParameterType)))
                    {
                        if (IsTeklaType(method.ReturnType))
                        {
                            Ref_Out_GenerateForTeklaReturnType(sb, method, name, type);
                        }
                        else
                        {
                            Ref_Out_GenerateForNotTeklaReturnType(sb, method, name, type);
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
                }

                sb.Append("\n\n");
            }

            if (type.Name.Equals("Settings"))
            {
                sb.Replace("public static System.Boolean TryGetValue(System.String name, out Dynamic.Tekla.Structures.Datatype.Settings.T obj)"
                    ,
                    "public static System.Boolean TryGetValue<T>(System.String name, out T obj)");
                sb.Replace("obj = new Dynamic.Tekla.Structures.Datatype.Settings.T();"
                    ,
                    "obj = default(T);");
                sb.Replace("obj = (Dynamic.Tekla.Structures.Datatype.Settings.T) parameters[1];"
                    ,
                    "obj = (T) parameters[1];");
            }

            sb.Append(AditionalMethods(type));
            return sb.ToString();
        }

        private static bool IsParams(ParameterInfo parameter)
        {
            return parameter.GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0;
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
                var paramName = param.Name.Replace("result","resultt");
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                if (param.IsOut) sb.Append("out ");
                else if (param.ParameterType.IsByRef) sb.Append("ref ");

                if (IsParams(param)) sb.Append(" params ");
                var paramTypeFullName = GetTypeFullName(param.ParameterType);
                sb.Append(paramTypeFullName);
                sb.Append(" ");
                sb.Append(paramName);
                sb.Append(", ");
            }
            if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

            sb.Append(")\n\t\t{\n");
            sb.Append("\t\t\ttry {\n");
            sb.Append("\t\t\t");
            if (!typeFullName.Equals("void")) sb.Append("return ");
            sb.Append("$dfield.");
            sb.Append(name);
            sb.Append("(");

            //params in method body
            foreach (var param in method.GetParameters())
            {
                var paramName = param.Name.Replace("result", "resultt");
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                if (IsTeklaType(param.ParameterType))
                {
                    sb.Append(CorrectIfArray(GetTypeFullName(param.ParameterType)));
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

            sb.Append(");\n");
            sb.Append("\t\t\t}\n\t\t\tcatch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)\n");
            sb.Append("\t\t\t { throw DynamicAPINotFoundException.CouldNotFindMethod(\"" + method.Name + "()\"); }\n");
            sb.Append("\t\t}");
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

        private static void Static_GenerateForNotTeklaReturnType(StringBuilder sb, MethodInfo method, string name, Type type)
        {
            sb.Append("\t\t");
            sb.Append("public static ");
            var typeFullName = GetTypeFullName(method.ReturnType).Replace("System.Void", "void");

            sb.Append(typeFullName);
            sb.Append(" ");
            sb.Append(name);
            sb.Append("(");
            
            var parameters = method.GetParameters();
            //params in method name
            foreach (var param in parameters)
            {
                var paramName = param.Name.Replace("result", "resultt");
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";
                var paramTypeFullName = GetTypeFullName(param.ParameterType);

                if (param.IsOut)
                    sb.Append("out ");
                else if (param.ParameterType.IsByRef)
                    sb.Append("ref ");

                if (IsParams(param)) sb.Append(" params ");
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
                var paramName = parameters[i].Name.Replace("result", "resultt");
                string paramTypeFullName = GetTypeFullName(parameters[i].ParameterType);

                if (parameters[i].IsOut)
                {
                    if (paramTypeFullName.Equals("System.String", StringComparison.InvariantCulture))
                        sb.Append("\t\t\t" + paramName + " = string.Empty;\n");
                    else
                    {
                        sb.Append("\t\t\t" + paramName + " = new " + paramTypeFullName + "();\n");
                    }
                }

                if (IsTeklaType(parameters[i].ParameterType))
                {
                    sb.Append("\t\t\tparameters[" + i + "] = ");
                    sb.Append(CorrectIfArray(paramTypeFullName) + "_.GetTSObject(" + paramName + ");\n");
                }
                else
                    sb.Append("\t\t\tparameters["+ i +"] = " + paramName + ";\n");
            }

            sb.Append("\t\t\t");
            if (!typeFullName.Equals("void"))
                sb.Append("var result = (" + GetTypeFullName(method.ReturnType) + ") ");
            sb.Append("TSActivator.InvokeStaticMethod(\"");
            sb.Append(GetTypeFullName(type).Replace("Dynamic.", ""));
            sb.Append("\", \"");
            sb.Append(method.Name);
            sb.Append("\", parameters);\n");

            //ref out parameters            
            int j = 0;
            foreach (var param in parameters)
            {
                var paramName = param.Name.Replace("result", "resultt");
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                if (param.IsOut || param.ParameterType.IsByRef)
                {
                    sb.Append("\t\t\t");
                    sb.Append(paramName);
                    sb.Append(" = ");

                    var paramTypeFullName = GetTypeFullName(param.ParameterType);

                    if (IsTeklaType(param.ParameterType))
                    {
                        sb.Append(CorrectIfArray(paramTypeFullName) + "_.FromTSObject(");
                        sb.Append("parameters[" + j + "]);\n");
                    }
                    else
                    {
                        sb.Append("(" + paramTypeFullName + ") ");
                        sb.Append("parameters[" + j + "];\n");
                    }

                }
                j++;
            }

            if (!typeFullName.Equals("void"))
            {
                sb.Append("\t\t\treturn result;\n");

            }
            sb.Append("\t\t}");
        }

        private static void Ref_Out_GenerateForNotTeklaReturnType(StringBuilder sb, MethodInfo method, string name, Type type)
        {
            sb.Append("\t\t");
            sb.Append("public ");
            var typeFullName = GetTypeFullName(method.ReturnType).Replace("System.Void", "void");

            sb.Append(typeFullName);
            sb.Append(" ");
            sb.Append(name);
            sb.Append("(");

            var parameters = method.GetParameters();
            //params in method name
            foreach (var param in parameters)
            {
                var paramName = param.Name.Replace("result", "resultt");
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";
                var paramTypeFullName = GetTypeFullName(param.ParameterType);

                if (param.IsOut)
                    sb.Append("out ");
                else if (param.ParameterType.IsByRef)
                    sb.Append("ref ");

                if (IsParams(param)) sb.Append(" params ");
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
                string paramTypeFullName = GetTypeFullName(parameters[i].ParameterType);

                if (parameters[i].IsOut)
                {
                    if (paramTypeFullName.Equals("System.String", StringComparison.InvariantCulture))
                        sb.Append("\t\t\t" + parameters[i].Name + " = string.Empty;\n");
                    else
                    {
                        sb.Append("\t\t\t" + parameters[i].Name + " = null;\n");
                        //sb.Append("\t\t\t" + parameters[i].Name + " = new " + paramTypeFullName + "();\n"); 
                    }
                }

                if (IsTeklaType(parameters[i].ParameterType))
                {
                    sb.Append("\t\t\tparameters[" + i + "] = ");
                    sb.Append(CorrectIfArray(paramTypeFullName) + "_.GetTSObject(" + parameters[i].Name + ");\n");
                }
                else
                    sb.Append("\t\t\tparameters[" + i + "] = " + parameters[i].Name + ";\n");
            }

            sb.Append("\t\t\t");
            if (!typeFullName.Equals("void"))
                sb.Append("var result = (" + GetTypeFullName(method.ReturnType) + ") ");
            sb.Append("TSActivator.InvokeMethod(teklaObject, \"");
            sb.Append(GetTypeFullName(type).Replace("Dynamic.", ""));
            sb.Append("\", \"");
            sb.Append(method.Name);
            sb.Append("\", parameters);\n");

            //ref out parameters            
            int j = 0;
            foreach (var param in parameters)
            {
                var paramName = param.Name;
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                if (param.IsOut || param.ParameterType.IsByRef)
                {
                    sb.Append("\t\t\t");
                    sb.Append(paramName);
                    sb.Append(" = ");

                    var paramTypeFullName = GetTypeFullName(param.ParameterType);

                    if (IsTeklaType(param.ParameterType))
                    {
                        sb.Append(CorrectIfArray(paramTypeFullName) + "_.FromTSObject(");
                        sb.Append("parameters[" + j + "]);\n");
                    }
                    else
                    {
                        sb.Append("(" + paramTypeFullName + ") ");
                        sb.Append("parameters[" + j + "];\n");
                    }

                }
                j++;
            }

            if (!typeFullName.Equals("void"))
            {
                sb.Append("\t\t\treturn result;\n");

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
                var paramName = param.Name.Replace("result", "resultt");
                if (param.IsOut) sb.Append("out ");
                else if (param.ParameterType.IsByRef) sb.Append("ref ");

                if (IsParams(param)) sb.Append(" params ");
                sb.Append(GetTypeFullName(param.ParameterType));
                sb.Append(" ");
                sb.Append(paramName);
                sb.Append(", ");
            }
            if (method.GetParameters().Length > 0) sb.Remove(sb.Length - 2, 2);

            sb.Append(")\n\t\t{\n");
            sb.Append("\t\t\ttry {\n");
            sb.Append("\t\t\treturn ");
            sb.Append(CorrectIfArray(GetTypeFullName(method.ReturnType)));
            sb.Append("_.FromTSObject($dfield.");
            sb.Append(name);
            sb.Append("(");

            //params in method body
            foreach (var param in method.GetParameters())
            {
                var paramName = param.Name.Replace("result", "resultt");
                if (IsTeklaType(param.ParameterType))
                {
                    sb.Append(CorrectIfArray(GetTypeFullName(param.ParameterType)));
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

            sb.Append("));\n");

            sb.Append("\t\t\t}\n\t\t\tcatch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)\n");
            sb.Append("\t\t\t { throw DynamicAPINotFoundException.CouldNotFindMethod(\"" + method.Name +"()\"); }\n");

            sb.Append("\t\t}");
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
            
            var parameters = method.GetParameters();
            //params in method name
            foreach (var param in parameters)
            {
                var paramName = param.Name.Replace("result", "resultt");
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                if (param.IsOut)
                    sb.Append("out ");
                else if (param.ParameterType.IsByRef)
                    sb.Append("ref ");

                var paramTypeFullName = GetTypeFullName(param.ParameterType);
                if (IsParams(param)) sb.Append(" params ");
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
                var paramName = parameters[i].Name.Replace("result", "resultt");
                if (IsTeklaType(parameters[i].ParameterType))
                {
                    sb.Append("\t\t\tparameters[" + i + "] = ");
                    sb.Append(CorrectIfArray(GetTypeFullName(parameters[i].ParameterType)) + "_.GetTSObject(" + paramName + ");\n");
                }
                else
                    sb.Append("\t\t\tparameters[" + i + "] = " + paramName + ";\n");
            }
            
            sb.Append("\t\t\tdynamic result = TSActivator.InvokeStaticMethod(\"");
            sb.Append(GetTypeFullName(type).Replace("Dynamic.", ""));
            sb.Append("\", \"");
            sb.Append(method.Name);
            sb.Append("\", parameters);\n");

            //ref out parameters            
            int j = 0;
            foreach (var param in parameters)
            {
                var paramName = param.Name.Replace("result", "resultt"); 

                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                if (param.IsOut || param.ParameterType.IsByRef)
                {
                    sb.Append("\t\t\t");
                    sb.Append(paramName);
                    sb.Append(" = ");

                    var paramTypeFullName = GetTypeFullName(param.ParameterType);

                    if (IsTeklaType(param.ParameterType))
                    {
                        sb.Append(CorrectIfArray(paramTypeFullName) + "_.FromTSObject(");
                        sb.Append("parameters[" + j + "]);\n");
                    }
                    else
                    {
                        sb.Append("(" + paramTypeFullName + ") ");
                        sb.Append("parameters[" + j + "];\n");
                    }

                }
                j++;
            }

            sb.Append("\t\t\treturn ");
            sb.Append(CorrectIfArray(GetTypeFullName(method.ReturnType)) + "_.FromTSObject(result);\n");
            sb.Append("\t\t}");
        }

        private static void Ref_Out_GenerateForTeklaReturnType(StringBuilder sb, MethodInfo method, string name, Type type)
        {
            sb.Append("\t\t");
            sb.Append("public ");
            var typeFullName = GetTypeFullName(method.ReturnType).Replace("System.Void", "void");

            sb.Append(typeFullName);
            sb.Append(" ");
            sb.Append(name);
            sb.Append("(");

            var parameters = method.GetParameters();
            //params in method name
            foreach (var param in parameters)
            {
                var paramName = param.Name.Replace("result", "resultt");
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                if (param.IsOut)
                    sb.Append("out ");
                else if (param.ParameterType.IsByRef)
                    sb.Append("ref ");

                var paramTypeFullName = GetTypeFullName(param.ParameterType);
                if (IsParams(param)) sb.Append(" params ");
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
                var paramName = parameters[i].Name.Replace("result", "resultt");
                if (IsTeklaType(parameters[i].ParameterType))
                {
                    sb.Append("\t\t\tparameters[" + i + "] = ");
                    sb.Append(CorrectIfArray(GetTypeFullName(parameters[i].ParameterType)) + "_.GetTSObject(" + paramName + ");\n");
                }
                else
                    sb.Append("\t\t\tparameters[" + i + "] = " + paramName + ";\n");
            }

            sb.Append("\t\t\tdynamic result = TSActivator.InvokeMethod(teklaObject, \"");
            sb.Append(GetTypeFullName(type).Replace("Dynamic.", ""));
            sb.Append("\", \"");
            sb.Append(method.Name);
            sb.Append("\", parameters);\n");

            //ref out parameters            
            int j = 0;
            foreach (var param in parameters)
            {
                var paramName = param.Name.Replace("result", "resultt");
                if (paramName.Equals("object", StringComparison.InvariantCulture))
                    paramName = "@object";

                if (param.IsOut || param.ParameterType.IsByRef)
                {
                    sb.Append("\t\t\t");
                    sb.Append(paramName);
                    sb.Append(" = ");

                    var paramTypeFullName = GetTypeFullName(param.ParameterType);

                    if (IsTeklaType(param.ParameterType))
                    {
                        sb.Append(CorrectIfArray(paramTypeFullName) + "_.FromTSObject(");
                        sb.Append("parameters[" + j + "]);\n");
                    }
                    else
                    {
                        sb.Append("(" + paramTypeFullName + ") ");
                        sb.Append("parameters[" + j + "];\n");
                    }

                }
                j++;
            }

            sb.Append("\t\t\treturn ");
            sb.Append(CorrectIfArray(GetTypeFullName(method.ReturnType)) + "_.FromTSObject(result);\n");
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
            return TypeFullName.GetTypeFullName_WithDynamic(type);
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
