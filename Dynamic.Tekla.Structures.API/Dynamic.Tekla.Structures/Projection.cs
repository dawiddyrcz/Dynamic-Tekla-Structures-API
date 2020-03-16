//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class Projection 
    {

        

        dynamic projection;
        
        public Projection()
        {
            this.projection =  new Tekla.Structures.Geometry3d.Projection();
        }

        public Projection(dynamic tsObject)
        {
            this.projection = tsObject;

        }


        public dynamic GetTSObject() => projection;

		public Dynamic.Tekla.Structures.Geometry3d.Point PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.Line Line)
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(projection.PointToLine(Point.GetTSObject(), Line.GetTSObject()));

		public Dynamic.Tekla.Structures.Geometry3d.Point PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(projection.PointToPlane(Point.GetTSObject(), Plane.GetTSObject()));

		public Dynamic.Tekla.Structures.Geometry3d.Line LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => new Dynamic.Tekla.Structures.Geometry3d.Line(projection.LineToPlane(Line.GetTSObject(), Plane.GetTSObject()));

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => new Dynamic.Tekla.Structures.Geometry3d.LineSegment(projection.LineSegmentToPlane(LineSegment.GetTSObject(), Plane.GetTSObject()));





    }

}
    
