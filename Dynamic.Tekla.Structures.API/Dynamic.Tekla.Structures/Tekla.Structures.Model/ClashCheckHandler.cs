/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ClashCheckHandler 
    {

        

        internal dynamic teklaObject;

		internal ClashCheckHandler() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ClashCheckHandler(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean RunClashCheck()
		{
			try {
			var result = teklaObject.RunClashCheck();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RunClashCheck()", ex); }
		}

		public System.Boolean StopClashCheck()
		{
			try {
			var result = teklaObject.StopClashCheck();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("StopClashCheck()", ex); }
		}

		public System.Collections.ArrayList GetIntersectionBoundingBoxes(Dynamic.Tekla.Structures.Identifier ID1, Dynamic.Tekla.Structures.Identifier ID2)
		{
			try {
			var result = teklaObject.GetIntersectionBoundingBoxes(Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID1), Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID2));
			return TSActivator.ConvertArrayList(result);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetIntersectionBoundingBoxes()", ex); }
		}





    }

    internal static class ClashCheckHandler_
    {
        public static dynamic GetTSObject(ClashCheckHandler dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ClashCheckHandler FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ClashCheckHandler)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClashCheckHandlerArray_
    {
        public static dynamic GetTSObject(ClashCheckHandler[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ClashCheckHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ClashCheckHandler[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ClashCheckHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ClashCheckHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
