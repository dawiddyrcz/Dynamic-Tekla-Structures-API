/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

using Dynamic.Tekla.Structures;
using System;
using System.Collections;

namespace CodeGenerator
{
    public static class Converters
    {
        public static string ToTSObjects(Type type, string inputName, string outputName)
        {
            if (TypeFullName.IsTeklaType(type))
            {
                return outputName + " = " + TypeFullName.GetTypeFullName_WithDynamic(type) + "_.GetTSObject(" + inputName + ");";
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                return outputName + " = IEnumerableConverter.ToTSObjects(" + inputName + ");";
            }
            else
            {
                return outputName + " = ObjectConverter.ToTSObject(" + inputName + ");";
            }
        }

        public static string FromTSObjects(Type type, string inputName, string outputName)
        {
            if (TypeFullName.IsTeklaType(type))
            {
                return outputName + " = " + TypeFullName.GetTypeFullName_WithDynamic(type) + "_.FromTSObject(" + inputName + ");";
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                return outputName + " = IEnumerableConverter.FromTSObjects(" + inputName + ");";
            }
            else
            {
                return outputName + " = ObjectConverter.FromTSObject(" + inputName + ");";
            }
        }

        public static bool HaveToBeConverted(Type type)
        {
            //if (TypeFullName.IsTeklaType(type))
            //    return true;

            //if (type.IsArray)
            //    return true;

            //if (type.IsAssignableFrom(typeof(System.Collections.ArrayList)))
            //    return true;

            //if (type.IsGenericType && (type.GetGenericTypeDefinition() == typeof(List<>)))
            //    return true;

            //if (type.IsAssignableFrom(typeof(System.Type)))
            //    return true;

            //return false;

            if (
                type.IsAssignableFrom(typeof(int))
                || type.IsAssignableFrom(typeof(string))
                || type.IsAssignableFrom(typeof(double))
                || type.IsAssignableFrom(typeof(bool))
                ) return false;

            return true;
        }

    }
}
