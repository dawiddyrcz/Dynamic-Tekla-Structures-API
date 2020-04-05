/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public abstract class IDoubleDataType 
    {

		public System.Double Value
		{
			get
			{
				try {
					return teklaObject.Value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value"); }
			}
			set
			{
				try {
					teklaObject.Value = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value"); }
			}
		}

        

        internal dynamic teklaObject;






    }

    internal static class IDoubleDataType_
    {
        public static dynamic GetTSObject(IDoubleDataType dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IDoubleDataType FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Datatype.IDoubleDataType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IDoubleDataTypeArray_
    {
        public static dynamic GetTSObject(IDoubleDataType[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IDoubleDataType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IDoubleDataType[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IDoubleDataType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IDoubleDataType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
