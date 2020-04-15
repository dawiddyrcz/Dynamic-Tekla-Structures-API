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

using Dynamic.Tekla.Structures;
using System;
using System.Reflection;

namespace CodeGenerator
{
    public static class SinglePropertyGenerator
    {
        public static string GetCode(MemberInfo propertyOrField)
        {
            Type currentType = null;

            var hasGet = false;
            var hasSet = false;
            var isStatic = false;

            if (propertyOrField is PropertyInfo pi)
            {
                currentType = pi.PropertyType;
                hasGet = pi.GetMethod != null;
                hasSet = pi.SetMethod != null;
                isStatic = pi.GetMethod.IsStatic;
            }
            else if (propertyOrField is FieldInfo fi)
            {
                currentType = fi.FieldType;
                hasGet = true;
                hasSet = !(fi.IsInitOnly || fi.IsLiteral);
                isStatic = fi.IsStatic;
            }

            if (isStatic)
            {
                return StaticProperty(propertyOrField, currentType, hasGet, hasSet);
            }
            else
            {
                return NonStaticProperty(propertyOrField, currentType, hasGet, hasSet);
            }
        }

        private static string StaticProperty(MemberInfo propertyOrField, Type currentType, bool hasGet, bool hasSet)
        {
            var typeFullNameWithDynamic = TypeFullName.GetTypeFullName_WithDynamic(currentType);

            string staticGet = string.Empty;
            if (hasGet) staticGet = GetStaticGet(propertyOrField, currentType);
            string staticSet = string.Empty;
            if (hasSet) staticSet = GetStaticSet(propertyOrField, currentType);

            return $@"
        public static {typeFullNameWithDynamic} {propertyOrField.Name}
        {{
            {staticGet}
            {staticSet}
        }}";
        }

        private static string GetStaticGet(MemberInfo propertyOrField, Type propertyOrFieldType)
        {

            var propTypeFullName = TypeFullName.GetTypeFullName_WithDynamic(propertyOrFieldType);
            string valueConverter = $"return ({propTypeFullName}) value;";

            if (Converters.HaveToBeConverted(propertyOrFieldType))
            {
                valueConverter = Converters.FromTSObjects(propertyOrFieldType, "value", "var value_");
                valueConverter += $"\n\treturn ({propTypeFullName}) value_;";
            }

            return $@"get
            {{
                var value = PropertyInvoker.GetStaticPropertyOrFieldValue(""$typeFullName"", ""{propertyOrField.Name}"");
                {valueConverter}
            }}";
        }

        private static string GetStaticSet(MemberInfo propertyOrField, Type propertyOrFieldType)
        {
            string valueConverter = "var value_ = value;";

            if (Converters.HaveToBeConverted(propertyOrFieldType))
                valueConverter = Converters.ToTSObjects(propertyOrFieldType, "value", "var value_");

            return $@"set
            {{
                {valueConverter}
                PropertyInvoker.SetStaticPropertyOrFieldValue(""$typeFullName"", ""{propertyOrField.Name}"", value_);
            }}";
        }

        private static string NonStaticProperty(MemberInfo propertyOrField, Type currentType, bool hasGet, bool hasSet)
        {
            var typeFullNameWithDynamic = TypeFullName.GetTypeFullName_WithDynamic(currentType);

            string nonstaticGet = string.Empty;
            if (hasGet) nonstaticGet = GetNonStaticGet(propertyOrField, currentType);
            string nonstaticSet = string.Empty;
            if (hasSet) nonstaticSet = GetNonStaticSet(propertyOrField, currentType);

            return $@"
        public {typeFullNameWithDynamic} {propertyOrField.Name}
        {{
            {nonstaticGet}
            {nonstaticSet}
        }}
";
        }

        private static string GetNonStaticGet(MemberInfo propertyOrField, Type propertyOrFieldType)
        {
            string getCode = string.Empty;

            if (Converters.HaveToBeConverted(propertyOrFieldType))
            {
                getCode = $@"
                var value = teklaObject.{propertyOrField.Name};
                {Converters.FromTSObjects(propertyOrFieldType, "value", "var value_")}
                return ({TypeFullName.GetTypeFullName_WithDynamic(propertyOrFieldType)}) value_;";
            }
            else
            {
                getCode = $@"
                return teklaObject.{ propertyOrField.Name};";
            }

            return $@"get
            {{
                try
                {{{getCode}
                }}
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {{
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof({propertyOrField.Name}), ex); 
                }}
            }}";
        }

        private static string GetNonStaticSet(MemberInfo propertyOrField, Type propertyOrFieldType)
        {
            string setCode = string.Empty;

            if (Converters.HaveToBeConverted(propertyOrFieldType))
            {
                setCode = $@"
                {Converters.ToTSObjects(propertyOrFieldType, "value", "var value_")}
                teklaObject.{propertyOrField.Name} = value_;";
            }
            else
            {
                setCode = $@"
                teklaObject.{ propertyOrField.Name} = value;";
            }

            return $@"set
            {{
                try
                {{{setCode}
                }}
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {{
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof({propertyOrField.Name}), ex); 
                }}
            }}";
        }
        
    }
}
