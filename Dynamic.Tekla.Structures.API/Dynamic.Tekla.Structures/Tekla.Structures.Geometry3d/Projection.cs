//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class Projection 
    {

        

        internal dynamic teklaObject;

		internal Projection() {}

		public Dynamic.Tekla.Structures.Geometry3d.Point PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.Line Line)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line)));

		public Dynamic.Tekla.Structures.Geometry3d.Point PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane)));

		public Dynamic.Tekla.Structures.Geometry3d.Line LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(teklaObject.LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane)));

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane)));





    }

    internal static class Projection_
    {
        public static dynamic GetTSObject(Projection dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Projection FromTSObject(dynamic tsObject)
        {
            return new Projection() { teklaObject = tsObject };
        }
    }


}
    
