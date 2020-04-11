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
using System.Collections.Generic;

namespace CodeGenerator
{
    public static class Converters
    {
        public static string ToTSObjects(Type type, string inputName, string outputName)
        {
            var typeFullName = TypeFullName.GetTypeFullName(type);

            if (TypeFullName.IsTeklaType(type))
            {
                return outputName + " = " + TypeFullName.GetTypeFullName_WithDynamic(type) + "_.GetTSObject(" + inputName + ");";
            }
            else if (typeof(ArrayList).IsAssignableFrom(type))
            {
                return outputName + " = ArrayListConverter.ToTSObjects(" + inputName + ");";
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                return outputName + " = IEnumerableConverter.ToTSObjects<" + typeFullName + ">(" + inputName + ");";
            }
            else
            {
                return outputName + " = ObjectConverter.ToTSObject(" + inputName + ");";
            }
        }

        public static string FromTSObjects(Type type, string inputName, string outputName)
        {
            var typeFullName = TypeFullName.GetTypeFullName_WithDynamic(type);
            if (TypeFullName.IsTeklaType(type))
            {
                return outputName + " = " + TypeFullName.GetTypeFullName_WithDynamic(type) + "_.FromTSObject(" + inputName + ");";
            }
            else if (typeof(ArrayList).IsAssignableFrom(type))
            {
                return  outputName + " = ArrayListConverter.FromTSObjects(" + inputName + ");";
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                return outputName + " = IEnumerableConverter.FromTSObjects<"+typeFullName+">(" + inputName + ");";
            }
            else
            {
                return outputName + " = ObjectConverter.FromTSObject(" + inputName + ");";
            }
        }

        public static bool HaveToBeConverted(Type type2)
        {
            Type type;
            if (type2.IsByRef)
                type = type2.GetElementType();
            else
                type = type2;

            if (
                type.IsAssignableFrom(typeof(int))
                || type.IsAssignableFrom(typeof(string))
                || type.IsAssignableFrom(typeof(double))
                || type.IsAssignableFrom(typeof(bool))
                
                || typeof(Hashtable).IsAssignableFrom(type) //I know the hashtables are only with report properties which are string, int, double
                
                || typeof(List<string>).IsAssignableFrom(type)
                || typeof(List<int>).IsAssignableFrom(type)
                || typeof(List<double>).IsAssignableFrom(type)
                || typeof(List<bool>).IsAssignableFrom(type)

                || typeof(Dictionary<string, string>).IsAssignableFrom(type)
                || typeof(Dictionary<string, int>).IsAssignableFrom(type)
                || typeof(Dictionary<string, double>).IsAssignableFrom(type)


                )
            {
                return false;
            }

            return true;
        }

    }
}
