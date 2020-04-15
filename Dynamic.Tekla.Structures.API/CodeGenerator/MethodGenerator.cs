/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

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
                if (method.GetBaseDefinition() != method) continue;
                if (method.Name.Equals("CopyTo")) continue;
                if (method.Name.Equals("RegisterLocalizationCallback")) continue;

                if (method.IsGenericMethod)
                    continue;
                
                var name = method.Name;
                if (name.Equals("GetType") || name.Equals("Equals") || name.Equals("ToString") || name.Equals("GetHashCode")) continue;


                sb.Append(SingleMethodGenerator.GenerateCode(method));
                sb.Append("\n\n");
            }

            sb.Append(AditionalMethods(type));
            return sb.ToString();
        }
        
        private static List<MethodInfo> GetMethodsFromType(Type type)
        {
            return type.GetMethods().Where(
                m => m.IsPublic
                && !m.IsSpecialName
                && !m.ReturnType.ToString().Contains("Tekla.Structures.ModelInternal")
                && !m.GetParameters().Any(p => p.ParameterType.ToString().Contains("Tekla.Structures.ModelInternal"))
                && m.DeclaringType.Equals(type))
                .ToList();
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
