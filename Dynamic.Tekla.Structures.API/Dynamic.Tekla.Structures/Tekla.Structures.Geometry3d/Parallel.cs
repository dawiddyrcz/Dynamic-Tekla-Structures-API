/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class Parallel 
    {

        

        internal dynamic teklaObject;


		public static System.Boolean VectorToVector(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "VectorToVector", parameters);
			return result;		}

		public static System.Boolean VectorToVector(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2, System.Double Tolerance)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2);
			parameters[2] = Tolerance;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "VectorToVector", parameters);
			return result;		}

		public static System.Boolean LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line Line1, Dynamic.Tekla.Structures.Geometry3d.Line Line2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line2);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineToLine", parameters);
			return result;		}

		public static System.Boolean LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line Line1, Dynamic.Tekla.Structures.Geometry3d.Line Line2, System.Double Tolerance)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line2);
			parameters[2] = Tolerance;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineToLine", parameters);
			return result;		}

		public static System.Boolean LineSegmentToLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment1, Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment2);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineSegmentToLineSegment", parameters);
			return result;		}

		public static System.Boolean LineSegmentToLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment1, Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment2, System.Double Tolerance)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment2);
			parameters[2] = Tolerance;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineSegmentToLineSegment", parameters);
			return result;		}

		public static System.Boolean PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane1, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane2);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "PlaneToPlane", parameters);
			return result;		}

		public static System.Boolean PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane1, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane2, System.Double Tolerance)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane2);
			parameters[2] = Tolerance;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "PlaneToPlane", parameters);
			return result;		}

		public static System.Boolean VectorToPlane(Dynamic.Tekla.Structures.Geometry3d.Vector Vector, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "VectorToPlane", parameters);
			return result;		}

		public static System.Boolean VectorToPlane(Dynamic.Tekla.Structures.Geometry3d.Vector Vector, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane, System.Double Tolerance)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			parameters[2] = Tolerance;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "VectorToPlane", parameters);
			return result;		}

		public static System.Boolean LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineToPlane", parameters);
			return result;		}

		public static System.Boolean LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane, System.Double Tolerance)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			parameters[2] = Tolerance;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineToPlane", parameters);
			return result;		}

		public static System.Boolean LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineSegmentToPlane", parameters);
			return result;		}

		public static System.Boolean LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane, System.Double Tolerance)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			parameters[2] = Tolerance;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineSegmentToPlane", parameters);
			return result;		}





    }

    internal static class Parallel_
    {
        public static dynamic GetTSObject(Parallel dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Parallel FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.Parallel)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
