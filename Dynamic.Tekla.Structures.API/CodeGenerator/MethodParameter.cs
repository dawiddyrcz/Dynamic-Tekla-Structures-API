/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/


//TODO ref and out parameters


using Dynamic.Tekla.Structures;
using System;
using System.Reflection;

namespace CodeGenerator
{
    public class MethodParameter
    {
        private readonly ParameterInfo parameterInfo;
        private readonly bool haveToBeConverted = false;
        private readonly string correctedName = string.Empty;
        private readonly string correctedName_ = string.Empty;

        public MethodParameter(ParameterInfo parameterInfo)
        {
            if (parameterInfo is null)
                throw new ArgumentNullException(nameof(parameterInfo));

            this.parameterInfo = parameterInfo;
            haveToBeConverted = Converters.HaveToBeConverted(parameterInfo.ParameterType);
            correctedName = CorrectName();
            correctedName_ = correctedName + "_";
        }

        private string CorrectName()
        {
            string name = parameterInfo.Name;

            if (name.Equals("object", StringComparison.InvariantCulture))
                return "objectt";
            else
                return name;
        }


        public string MethodDeclaration
        {
            get
            {
                var declaration = TypeFullName.GetTypeFullName_WithDynamic(parameterInfo.ParameterType) + " ";

                if (haveToBeConverted)
                    declaration += correctedName_;
                else
                    declaration += correctedName;

                if (parameterInfo.ParameterType.IsByRef)
                    declaration = "ref " + declaration;
                else if (parameterInfo.IsOut)
                    declaration = "out " + declaration;

                return declaration;
            }
        }

        public string ParameterName
        {
            get
            {
                return correctedName;
            }
        }

        public string MethodCall
        {
            get
            {
                if (parameterInfo.ParameterType.IsByRef)
                    return "ref " + correctedName;
                else if (parameterInfo.IsOut)
                    return "out " + correctedName;
                else
                    return correctedName;
            }
        }

        public string ConverterToTS
        {
            get
            {
                if (!haveToBeConverted)
                {
                     return string.Empty;
                }

                return Converters.ToTSObjects(parameterInfo.ParameterType, correctedName_, "var " + correctedName);
            }
        }

        public string ConverterFromTS
        {
            get
            {
                if (!haveToBeConverted)
                {
                    return string.Empty;
                }

                return Converters.FromTSObjects(parameterInfo.ParameterType, correctedName, correctedName_);
            }
        }

        public bool IsRefOrOut
        {
            get
            {
                return parameterInfo.IsOut || parameterInfo.ParameterType.IsByRef;
            }
        }
    }
}
