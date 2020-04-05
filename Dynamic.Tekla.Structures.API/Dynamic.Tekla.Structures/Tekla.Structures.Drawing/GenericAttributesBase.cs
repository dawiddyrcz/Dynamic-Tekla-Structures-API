/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class GenericAttributesBase 
    {

        

        internal dynamic teklaObject;


		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			try {
			return teklaObject.IsEqual(ObjectToCompare);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsEqual()"); }
		}





    }

    internal static class GenericAttributesBase_
    {
        public static dynamic GetTSObject(GenericAttributesBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GenericAttributesBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.GenericAttributesBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GenericAttributesBaseArray_
    {
        public static dynamic GetTSObject(GenericAttributesBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GenericAttributesBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GenericAttributesBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GenericAttributesBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GenericAttributesBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
