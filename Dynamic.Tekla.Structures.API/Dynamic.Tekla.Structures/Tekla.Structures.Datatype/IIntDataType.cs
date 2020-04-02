/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public abstract class IIntDataType 
    {

		public System.Int32 Value
		{
			get => teklaObject.Value;
			set { teklaObject.Value = value; }
		}

        

        internal dynamic teklaObject;






    }

    internal static class IIntDataType_
    {
        public static dynamic GetTSObject(IIntDataType dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static IIntDataType FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Datatype.IIntDataType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IIntDataTypeArray_
    {
        public static dynamic GetTSObject(IIntDataType[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IIntDataType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IIntDataType[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<IIntDataType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IIntDataType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    