/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public abstract class IStringDataType 
    {

		public System.String Value
		{
			get
			{
				try {
					return teklaObject.Value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value", ex); }
			}
			set
			{
				try {
					teklaObject.Value = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value", ex); }
			}
		}

        

        internal dynamic teklaObject;






    }

    internal static class IStringDataType_
    {
        public static dynamic GetTSObject(IStringDataType dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IStringDataType FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Datatype.IStringDataType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IStringDataTypeArray_
    {
        public static dynamic GetTSObject(IStringDataType[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IStringDataType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IStringDataType[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IStringDataType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IStringDataType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
