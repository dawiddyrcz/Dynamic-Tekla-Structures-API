/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class Projection 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Geometry3d.Point PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.Line Line)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Projection", "PointToLine", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Point PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Projection", "PointToPlane", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Line LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Projection", "LineToPlane", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Projection", "LineSegmentToPlane", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
		}





    }

    internal static class Projection_
    {
        public static dynamic GetTSObject(Projection dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Projection FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Projection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ProjectionArray_
    {
        public static dynamic GetTSObject(Projection[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Projection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Projection[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Projection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Projection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
