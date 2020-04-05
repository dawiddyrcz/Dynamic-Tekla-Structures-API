/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class CutPlane  : Dynamic.Tekla.Structures.Model.Boolean
    {

		public Dynamic.Tekla.Structures.Model.Plane Plane
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Plane_.FromTSObject(teklaObject.Plane);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Plane"); }
			}
			set
			{
				try {
				teklaObject.Plane = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Plane"); }
			}
		}

        

        

		public CutPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CutPlane");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CutPlane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class CutPlane_
    {
        public static dynamic GetTSObject(CutPlane dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CutPlane FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.CutPlane)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CutPlaneArray_
    {
        public static dynamic GetTSObject(CutPlane[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CutPlane_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CutPlane[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CutPlane>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CutPlane_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
