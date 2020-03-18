//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class Intersection 
    {

        

        internal dynamic intersection;
        
        private Intersection()
        {
            this.intersection =  TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Intersection");
        }

        internal Intersection(dynamic tsObject)
        {
            this.intersection = tsObject;
        }

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line line1, Dynamic.Tekla.Structures.Geometry3d.Line line2)
			 => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(intersection.LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line1), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line2)));

		public Dynamic.Tekla.Structures.Geometry3d.Point LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(intersection.LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane)));

		public Dynamic.Tekla.Structures.Geometry3d.Point LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(intersection.LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane)));

		public Dynamic.Tekla.Structures.Geometry3d.Line PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane1, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane2)
			 => Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(intersection.PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane1), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane2)));

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment LineToObb(Dynamic.Tekla.Structures.Geometry3d.Line line, Dynamic.Tekla.Structures.Geometry3d.OBB obb)
			 => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(intersection.LineToObb(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line), Dynamic.Tekla.Structures.Geometry3d.OBB_.GetTSObject(obb)));

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegmentToObb(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment, Dynamic.Tekla.Structures.Geometry3d.OBB obb)
			 => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(intersection.LineSegmentToObb(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment), Dynamic.Tekla.Structures.Geometry3d.OBB_.GetTSObject(obb)));





    }

    internal static class Intersection_
    {
        public static dynamic GetTSObject(Intersection dynObject)
        {
            return dynObject.intersection;
        }

        public static Intersection FromTSObject(dynamic tsObject)
        {
            return new Intersection(tsObject);
        }
    }


}
    