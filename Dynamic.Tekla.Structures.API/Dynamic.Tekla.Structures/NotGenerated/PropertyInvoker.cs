/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/

namespace Dynamic.Tekla.Structures
{
    internal static class PropertyInvoker
    {
        /// <summary>Gets the method from the type</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find metod</exception>
        public static object GetStaticPropertyOrFieldValue(string typeName, string fieldOrPropertyName)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var fieldInfo = type.GetField(fieldOrPropertyName);
            if (fieldInfo != null)
            {
                var result = fieldInfo.GetValue(null);
                if (result is null) return null;

                return result;
            }

            var propertyInfo = type.GetProperty(fieldOrPropertyName);
            if (propertyInfo != null)
            {
                var result = propertyInfo.GetValue(null);
                if (result is null) return null;

                return result;
            }

            throw new DynamicAPINotFoundException("Could not find static property or field " + fieldOrPropertyName + " in type " + typeName);
        }

        ///<summary>Sets value of static field or property in type with typeName</summary>
        /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
        public static void SetStaticPropertyOrFieldValue(string typeName, string fieldOrPropertyName, object value)
        {
            var type = TSActivator.GetTypeFromTypeName(typeName);
            var fieldInfo = type.GetField(fieldOrPropertyName);

            if (fieldInfo != null)
            {
                fieldInfo.SetValue(null, value);
                return;
            }

            var propertyInfo = type.GetProperty(fieldOrPropertyName);
            if (propertyInfo != null)
            {
                propertyInfo.SetValue(null, value);
                return;
            }

            throw new DynamicAPINotFoundException("Could not find static property or field " + fieldOrPropertyName + " in type " + typeName);
        }

    }
}
