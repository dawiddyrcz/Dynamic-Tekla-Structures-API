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
    public static class MethodGeneratorSingle
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

            return methodCode.Replace(System.Environment.NewLine + System.Environment.NewLine, System.Environment.NewLine);
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
                sb.Append("\t").Append(parameter.MethodDeclaration).AppendLine(",");
            }

            sb.Remove(sb.Length - 3, 2);
            sb.Append("\t");

            return sb.ToString();
        }

        private static string GetParametersConvertersToTS(List<MethodParameter> parameters)
        {
            if (parameters.Count.Equals(0)) return string.Empty;
            var sb = new StringBuilder(200);

            foreach (var parameter in parameters)
            {
                sb.Append("\t").AppendLine(parameter.ConverterToTS);
            }

            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }

        private static string GetMethodCall(MethodInfo methodInfo, List<MethodParameter> parameters)
        {
            var sb = new StringBuilder(200);
            sb.Append("\t");

            if (!IsVoid(methodInfo))
                sb.Append("var result = ");
            
            if (methodInfo.IsStatic)
            {
                sb.Append("MethodInvoker.InvokeStaticMethod(\"").Append("$typeFullName").Append("\", \"")
                .Append(methodInfo.Name).Append("\"");

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
                    sb.Append(parameter.MethodCall).Append(", ");
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
                sb.Append("\t").AppendLine(parameter.ConverterFromTS);
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
                    sb.Append("\t").AppendLine(Converters.FromTSObjects(type, "result", "var _result"));
                    sb.Append("\t").Append("return _result;");
                }
                else
                {
                    sb.Append("\t").Append("return result;");
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
