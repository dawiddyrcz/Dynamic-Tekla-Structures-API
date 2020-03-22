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


		public System.Boolean VectorToVector(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2)
		{
			return teklaObject.VectorToVector(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2));
		}

		public System.Boolean VectorToVector(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2, System.Double Tolerance)
		{
			return teklaObject.VectorToVector(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2), Tolerance);
		}

		public System.Boolean LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line Line1, Dynamic.Tekla.Structures.Geometry3d.Line Line2)
		{
			return teklaObject.LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line1), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line2));
		}

		public System.Boolean LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line Line1, Dynamic.Tekla.Structures.Geometry3d.Line Line2, System.Double Tolerance)
		{
			return teklaObject.LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line1), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line2), Tolerance);
		}

		public System.Boolean LineSegmentToLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment1, Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment2)
		{
			return teklaObject.LineSegmentToLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment1), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment2));
		}

		public System.Boolean LineSegmentToLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment1, Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment2, System.Double Tolerance)
		{
			return teklaObject.LineSegmentToLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment1), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment2), Tolerance);
		}

		public System.Boolean PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane1, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane2)
		{
			return teklaObject.PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane1), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane2));
		}

		public System.Boolean PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane1, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane2, System.Double Tolerance)
		{
			return teklaObject.PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane1), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane2), Tolerance);
		}

		public System.Boolean VectorToPlane(Dynamic.Tekla.Structures.Geometry3d.Vector Vector, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			return teklaObject.VectorToPlane(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane));
		}

		public System.Boolean VectorToPlane(Dynamic.Tekla.Structures.Geometry3d.Vector Vector, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane, System.Double Tolerance)
		{
			return teklaObject.VectorToPlane(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane), Tolerance);
		}

		public System.Boolean LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			return teklaObject.LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane));
		}

		public System.Boolean LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane, System.Double Tolerance)
		{
			return teklaObject.LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane), Tolerance);
		}

		public System.Boolean LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			return teklaObject.LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane));
		}

		public System.Boolean LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane, System.Double Tolerance)
		{
			return teklaObject.LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane), Tolerance);
		}





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
    
