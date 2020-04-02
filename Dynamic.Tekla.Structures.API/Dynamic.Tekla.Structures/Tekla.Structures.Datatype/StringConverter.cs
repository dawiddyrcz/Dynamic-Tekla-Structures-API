/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public  class StringConverter 
    {

        

        internal dynamic teklaObject;

		public StringConverter()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Datatype.StringConverter");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StringConverter(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType)
		{
			return teklaObject.CanConvertFrom(context, sourceType);
		}

		public System.Boolean CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
		{
			return teklaObject.CanConvertTo(context, destinationType);
		}

		public System.Object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value)
		{
			return teklaObject.ConvertFrom(context, culture, value);
		}

		public System.Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, System.Object value, System.Type destinationType)
		{
			return teklaObject.ConvertTo(context, culture, value, destinationType);
		}





    }

    internal static class StringConverter_
    {
        public static dynamic GetTSObject(StringConverter dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static StringConverter FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Datatype.StringConverter)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StringConverterArray_
    {
        public static dynamic GetTSObject(StringConverter[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StringConverter_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StringConverter[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<StringConverter>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StringConverter_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
