/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using Dynamic.Tekla.Structures;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeGenerator
{
    public static class SingleMethodGenerator
    {
        public static string GenerateCode(MethodInfo methodInfo)
        {
            string staticc = string.Empty;
            if (methodInfo.IsStatic)
                staticc = " static";

            var parameters = GetMethodParameters(methodInfo);

            string returnType = GetReturnType(methodInfo);
            string parametersDeclaration = GetParametersDeclaration(parameters);
            string parametersConvertersToTS = GetParametersConvertersToTS(parameters);
            string methodCall = GetMethodCall(methodInfo, parameters);
            string parametersConvertersFromTS = GetParametersConvertersFromTS(parameters);
            string result = GetResult(methodInfo);

            string methodCode = $@"
        public{staticc} {returnType} {methodInfo.Name}({parametersDeclaration})
        {{
            {parametersConvertersToTS}
            {methodCall}
            {parametersConvertersFromTS}
            {result}
        }}
";

            return methodCode.Replace(System.Environment.NewLine + "            " + System.Environment.NewLine, System.Environment.NewLine)
                .Replace(System.Environment.NewLine + System.Environment.NewLine, System.Environment.NewLine);
        }
        
        private static List<MethodParameter> GetMethodParameters(MethodInfo methodInfo)
        {
            var output = new List<MethodParameter>();

            foreach (var parameterInfo in methodInfo.GetParameters())
            {
                var methodParameter = new MethodParameter(parameterInfo);
                output.Add(methodParameter);
            }

            return output;
        }

        private static string GetReturnType(MethodInfo methodInfo)
        {
            var returnType = TypeFullName.GetTypeFullName_WithDynamic(methodInfo.ReturnType);

            if (returnType.Equals("System.Void"))
                returnType = "void";

            return returnType;
        }
        
        private static string GetParametersDeclaration(List<MethodParameter> parameters)
        {
            if (parameters.Count.Equals(0)) return string.Empty;

            var sb = new StringBuilder(200);
            sb.AppendLine();

            foreach (var parameter in parameters)
            {
                sb.Append("\t\t\t").Append(parameter.MethodDeclaration).AppendLine(",");
            }

            sb.Remove(sb.Length - 3, 3);;

            return sb.ToString();
        }

        private static string GetParametersConvertersToTS(List<MethodParameter> parameters)
        {
            if (parameters.Count.Equals(0)) return string.Empty;
            var sb = new StringBuilder(200);

            foreach (var parameter in parameters)
            {
                sb.AppendLine(parameter.ConverterToTS);
            }

            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        private static string GetMethodCall(MethodInfo methodInfo, List<MethodParameter> parameters)
        {
            var sb = new StringBuilder(200);
            
            bool hasOutParameter = methodInfo.GetParameters().Any(p => p.IsOut);

            if (!IsVoid(methodInfo))
                sb.Append("var result = ");

            if (!Converters.HaveToBeConverted(methodInfo.ReturnType))
                sb.Append("(").Append(TypeFullName.GetTypeFullName(methodInfo.ReturnType)).Append(") ");

            if (methodInfo.IsStatic)
            {
                sb.Append("MethodInvoker.InvokeStaticMethod(\"").Append("$typeFullName").Append("\", \"")
                .Append(methodInfo.Name).Append("\"");

                if (parameters.Count > 0)
                    sb.Append(", ");
            }
            else if (hasOutParameter)
            {
                sb.Append("MethodInvoker.InvokeMethod(\"").Append("$typeFullName").Append("\", \"")
                .Append(methodInfo.Name).Append("\", ").Append("teklaObject");

                if (parameters.Count > 0)
                    sb.Append(", ");
            }
            else
            {
                sb.Append("teklaObject.")
               .Append(methodInfo.Name)
               .Append("(");
            }
           
            if (parameters.Count > 0)
            {
                foreach (var parameter in parameters)
                {
                    if (methodInfo.IsStatic)
                        sb.Append(parameter.MethodCall.Replace("out ", "ref "));
                    else
                        sb.Append(parameter.MethodCall);

                    sb.Append(", ");
                }

                sb.Remove(sb.Length - 2, 2);
            }

            sb.Append(");");

            if (methodInfo.IsStatic == false)
            {
                return $@"
            try
            {{
                {sb.ToString()}";
            }
            else
                return sb.ToString();
        }
        
        private static string GetParametersConvertersFromTS(List<MethodParameter> parameters)
        {
            var refOutParameters = parameters.Where(p => p.IsRefOrOut).ToList();
            if (refOutParameters.Count.Equals(0)) return string.Empty;

            var sb = new StringBuilder(200);
            
            foreach (var parameter in refOutParameters)
            {
                sb.AppendLine(parameter.ConverterFromTS);
            }

            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        private static string GetResult(MethodInfo methodInfo)
        {

            var sb = new StringBuilder(200);
            if (!IsVoid(methodInfo))
            {
                var type = methodInfo.ReturnType;

                if (Converters.HaveToBeConverted(type))
                {
                    sb.AppendLine(Converters.FromTSObjects(type, "result", "var _result"));
                    sb.Append("\t\t\t\t").Append("return _result;");
                }
                else
                {
                    sb.Append("return result;");
                }
            }

            if (!methodInfo.IsStatic)
            {
                return $@"
                {sb.ToString()}
            }}
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {{
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof({methodInfo.Name}), ex);
            }}";
            }
            else
                return sb.ToString();
        }

        private static bool IsVoid(MethodInfo methodInfo)
        {
            return methodInfo.ReturnType.Equals(typeof(void));
        }
    }
}
