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
            var typeFullNameWithDynamic = TypeFullName.GetTypeFullName_WithDynamic(type);

            if (TypeFullName.IsTeklaType(type))
            {
                if (typeFullNameWithDynamic.EndsWith("[]", StringComparison.InvariantCulture))
                    return outputName + " = " + typeFullNameWithDynamic.Replace("[]","") + "Array_.GetTSObject(" + inputName + ");";
                else
                    return outputName + " = " + typeFullNameWithDynamic + "_.GetTSObject(" + inputName + ");";

            }
            else if (typeof(ArrayList).IsAssignableFrom(type))
            {
                return outputName + " = ArrayListConverter.ToTSObjects(" + inputName + ");";
            }
            else if (typeFullName.StartsWith("System.Collections.Generic.List<", StringComparison.InvariantCulture)
               || typeFullName.StartsWith("System.Collections.Generic.IList<", StringComparison.InvariantCulture)
               )
            { 
                return outputName + " = ListConverter.ToTSObjects(" + inputName + ");";
            }
            else if (typeof(System.Type).IsAssignableFrom(type)
               || typeof(System.Type[]).IsAssignableFrom(type))
            {
                return outputName + " = TypeConverter.ToTSObjects(" + inputName + ");";
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                //var ienumerableParameters = typeFullName.Substring(typeFullName.IndexOf("<"), typeFullName.Length - typeFullName.IndexOf("<"));
                return outputName + " = IEnumerableConverter.ToTSObjects(" + inputName + ");";
            }
            
            else if (typeFullName.StartsWith("System.Tuple", StringComparison.InvariantCulture))
            {
                var tupleParams = typeFullName.Substring(typeFullName.IndexOf("<"), typeFullName.Length - typeFullName.IndexOf("<"));
                return outputName + " = TupleConverter.ToTSObjects"+ tupleParams+"(" + inputName + ");";
            }
            else if (typeFullName.StartsWith("System.Nullable", StringComparison.InvariantCulture))
            {
                return outputName + " = NullableConverter.ToTSObjects(" + inputName + ");";
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
                if (typeFullName.EndsWith("[]", StringComparison.InvariantCulture))
                    return outputName + " = " + typeFullName.Replace("[]", "") + "Array_.FromTSObject(" + inputName + ");";
                else
                    return outputName + " = " + typeFullName + "_.FromTSObject(" + inputName + ");";
            }
            else if (typeof(ArrayList).IsAssignableFrom(type))
            {
                return outputName + " = ArrayListConverter.FromTSObjects(" + inputName + ");";
            }
            else if (typeFullName.StartsWith("System.Collections.Generic.List<", StringComparison.InvariantCulture)
                || typeFullName.StartsWith("System.Collections.Generic.IList<", StringComparison.InvariantCulture)
                )
            {
                var listParams = typeFullName.Substring(typeFullName.IndexOf("<"), typeFullName.Length - typeFullName.IndexOf("<"));
                return outputName + " = ListConverter.FromTSObjects" + listParams + "(" + inputName + ");";
            }
            else if (typeof(System.Type).IsAssignableFrom(type)
              || typeof(System.Type[]).IsAssignableFrom(type))
            {
                return outputName + " = TypeConverter.FromTSObject(" + inputName + ");";
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                var ienumerableParameters = typeFullName.Substring(typeFullName.IndexOf("<"), typeFullName.Length - typeFullName.IndexOf("<"));
                return outputName + " = IEnumerableConverter.FromTSObjects" + ienumerableParameters + "(" + inputName + ");";
            }
           
            else if (typeFullName.StartsWith("System.Tuple", StringComparison.InvariantCulture))
            {
                var tupleParams = typeFullName.Substring(typeFullName.IndexOf("<"), typeFullName.Length - typeFullName.IndexOf("<"));
                return outputName + " = TupleConverter.FromTSObject" + tupleParams + "(" + inputName + ");";
            }
            else if (typeFullName.StartsWith("System.Nullable", StringComparison.InvariantCulture)) 
            {
                var nulableParams = typeFullName.Substring(typeFullName.IndexOf("<"), typeFullName.Length - typeFullName.IndexOf("<"));
                return outputName + " = NullableConverter.FromTSObject" + nulableParams + "(" + inputName + ");";
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

                || typeof(int[]).IsAssignableFrom(type)
                || typeof(int[][]).IsAssignableFrom(type)

                || typeof(IEnumerable<string>).IsAssignableFrom(type)
                || typeof(IEnumerable<int>).IsAssignableFrom(type)
                || typeof(IEnumerable<double>).IsAssignableFrom(type)

                || typeof(Dictionary<string, string>).IsAssignableFrom(type)
                || typeof(Dictionary<string, int>).IsAssignableFrom(type)
                || typeof(Dictionary<string, double>).IsAssignableFrom(type)

                || typeof(KeyValuePair<int, int>).IsAssignableFrom(type)
                || typeof(KeyValuePair<double, string>).IsAssignableFrom(type)
                || typeof(KeyValuePair<string, string>).IsAssignableFrom(type)

                || typeof(List<KeyValuePair<int, int>>).IsAssignableFrom(type)
                || typeof(List<KeyValuePair<double, string>>).IsAssignableFrom(type)
                || typeof(List<KeyValuePair<string, string>>).IsAssignableFrom(type)
                || typeof(List<KeyValuePair<int, string>>).IsAssignableFrom(type)

                || typeof(string[]).IsAssignableFrom(type)
                || typeof(int[]).IsAssignableFrom(type)
                || typeof(double[]).IsAssignableFrom(type)
                || typeof(bool[]).IsAssignableFrom(type)
                || typeof(System.IAsyncResult).IsAssignableFrom(type)
                || typeof(System.IFormatProvider).IsAssignableFrom(type)
                || typeof(System.IntPtr).IsAssignableFrom(type)
                || typeof(System.Guid).IsAssignableFrom(type)

                || typeof(System.Tuple<System.Boolean, System.Int32, System.Int32, System.Int32>).IsAssignableFrom(type)
                || typeof(System.Collections.Generic.Dictionary<System.Guid, System.Guid>).IsAssignableFrom(type)
                || typeof(System.Nullable<System.DateTime>).IsAssignableFrom(type)
                || typeof(System.DateTime).IsAssignableFrom(type)
                || typeof(System.Uri).IsAssignableFrom(type)

                || typeof(System.Collections.Generic.IDictionary<System.Int32, System.Int32[][]>).IsAssignableFrom(type)


                // 

                || type.Namespace.StartsWith("System.Windows.Forms")
                || type.Namespace.StartsWith("System.Configuration")
                || type.Namespace.StartsWith("System.IO")
                || type.Namespace.StartsWith("System.Drawing")
                || type.Namespace.StartsWith("Microsoft.Win32")

               
                )
            {
                return false;
            }

            return true;
        }

    }
}
