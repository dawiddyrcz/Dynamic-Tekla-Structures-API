/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class ElementBase 
    {

        

        internal dynamic teklaObject;


		public System.Object Clone()
		{
			try {
			var result = teklaObject.Clone();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Clone()"); }
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			try {
			var result = teklaObject.IsEqual(ObjectToCompare);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsEqual()"); }
		}

		public System.String GetUnformattedString()
		{
			try {
			var result = teklaObject.GetUnformattedString();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUnformattedString()"); }
		}





    }

    internal static class ElementBase_
    {
        public static dynamic GetTSObject(ElementBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ElementBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ElementBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ElementBaseArray_
    {
        public static dynamic GetTSObject(ElementBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ElementBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ElementBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ElementBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ElementBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
