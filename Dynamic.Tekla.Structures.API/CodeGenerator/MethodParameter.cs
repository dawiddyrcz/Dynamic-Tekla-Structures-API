/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using Dynamic.Tekla.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public class MethodParameter
    {
        private readonly ParameterInfo parameterInfo;
        private readonly bool haveToBeConverted = false;
        private readonly string correctedName = string.Empty;
      
        public MethodParameter(ParameterInfo parameterInfo)
        {
            this.parameterInfo = parameterInfo;
            haveToBeConverted = HaveToBeConverted();
            correctedName = CorrectName();
        }

        private string CorrectName()
        {
            string name = parameterInfo.Name;

            if (name.Equals("object", StringComparison.InvariantCulture))
                return "objectt";
            else if (name.Equals("Type", StringComparison.InvariantCulture))
                return "Ttype";
            else
                return name;
        }

        private bool HaveToBeConverted()
        {
            var type = parameterInfo.ParameterType;

            if (TypeFullName.IsTeklaType(type))
                return true;

            if (type.IsArray)
                return true;

            if (type.IsGenericType && (type.GetGenericTypeDefinition() == typeof(List<>)))
                return true;

            return false;
        }

        public string MethodDeclaration
        {
            get
            {
                string declaration = TypeFullName.GetTypeFullName_WithDynamic(parameterInfo.ParameterType) + " " + correctedName;

                if (haveToBeConverted)
                    return declaration + "_";
                else
                    return declaration;

            }
        }
    }
}
