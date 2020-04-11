/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class GeometricPlane 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin", ex); }
			}
			set
			{
				try {
				teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Normal
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Normal);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Normal", ex); }
			}
			set
			{
				try {
				teklaObject.Normal = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Normal", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public GeometricPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GeometricPlane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public GeometricPlane(Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Vector Normal)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Normal);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane", args);
		}
		public GeometricPlane(Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Vector Xaxis, Dynamic.Tekla.Structures.Geometry3d.Vector Yaxis)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Xaxis);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Yaxis);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane", args);
		}
		public GeometricPlane(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane", args);
		}


public Dynamic.Tekla.Structures.Geometry3d.Vector GetNormal()
{

    try
    {
        	var result = teklaObject.GetNormal();

        	var _result = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetNormal), ex);
    }
}






    }

    internal static class GeometricPlane_
    {
        public static dynamic GetTSObject(GeometricPlane dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GeometricPlane FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.GeometricPlane)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GeometricPlaneArray_
    {
        public static dynamic GetTSObject(GeometricPlane[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GeometricPlane_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GeometricPlane[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GeometricPlane>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GeometricPlane_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
