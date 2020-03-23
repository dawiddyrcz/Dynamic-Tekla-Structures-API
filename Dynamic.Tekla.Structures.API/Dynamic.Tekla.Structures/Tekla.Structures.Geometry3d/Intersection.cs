/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class Intersection 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Geometry3d.LineSegment LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line line1, Dynamic.Tekla.Structures.Geometry3d.Line line2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line2);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Intersection", "LineToLine", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Point LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Intersection", "LineToPlane", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Point LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Intersection", "LineSegmentToPlane", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Line PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane1, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane2);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Intersection", "PlaneToPlane", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.LineSegment LineToObb(Dynamic.Tekla.Structures.Geometry3d.Line line, Dynamic.Tekla.Structures.Geometry3d.OBB obb)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.OBB_.GetTSObject(obb);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Intersection", "LineToObb", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegmentToObb(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment, Dynamic.Tekla.Structures.Geometry3d.OBB obb)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.OBB_.GetTSObject(obb);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Intersection", "LineSegmentToObb", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
		}





    }

    internal static class Intersection_
    {
        public static dynamic GetTSObject(Intersection dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Intersection FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Intersection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IntersectionArray_
    {
        public static dynamic GetTSObject(Intersection[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Intersection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Intersection[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Intersection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Intersection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
