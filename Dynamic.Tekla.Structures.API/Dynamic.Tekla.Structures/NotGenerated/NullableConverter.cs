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

namespace Dynamic.Tekla.Structures
{
    internal static class NullableConverter
    {
        public static dynamic ToTSObjects(dynamic input)
        {
            var inputGenericType = input.GetValueOrDefault().GetType();

            if (inputGenericType.ToString().StartsWith("Dynamic.Tekla.Structures.", StringComparison.InvariantCulture))
            {
                var hasValue = input.HasValue;
                var value = input.GetValueOrDefault();

                var convertedNullableType = typeof(System.Nullable<>);
                convertedNullableType = convertedNullableType.MakeGenericType(TypeConverter.ToTSObjects(inputGenericType));
                dynamic convertedNullableObject = Activator.CreateInstance(convertedNullableType);

                if (hasValue)
                {
                    var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                    string converterName = inputGenericType.ToString() + "_";
                    var converterType = assembly.GetType(converterName);
                    var parameters = new object[] { value };
                    var getTSObjectMethod = TSActivator.GetMethod("GetTSObject", parameters, converterType);

                    convertedNullableObject = getTSObjectMethod.Invoke(null, parameters);
                    return convertedNullableObject;
                }
                else
                {
                    convertedNullableObject = null;
                    return convertedNullableObject;
                }
            }
            else return input;
        }

        public static dynamic FromTSObject<T>(dynamic input) where T: struct
        {
            var inputGenericType = input.GetValueOrDefault().GetType();

            if (inputGenericType.ToString().StartsWith("Tekla.Structures.", StringComparison.InvariantCulture))
            {
                var hasValue = input.HasValue;
                var value = input.GetValueOrDefault();
                
                var convertedNullableObject = new System.Nullable<T>();

                if (hasValue)
                {
                    var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                    string converterName = "Dynamic." + inputGenericType.ToString() + "_";
                    var converterType = assembly.GetType(converterName);
                    var parameters = new object[] { value };
                    var getTSObjectMethod = TSActivator.GetMethod("GetTSObject", parameters, converterType);

                    convertedNullableObject = (System.Nullable<T>)getTSObjectMethod.Invoke(null, parameters);
                    return convertedNullableObject;
                }
                else
                {
                    convertedNullableObject = null;
                    return (System.Nullable<T>)convertedNullableObject;
                }
            }
            return input;
         }
    }
}
