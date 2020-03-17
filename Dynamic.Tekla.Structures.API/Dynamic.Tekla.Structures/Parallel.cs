//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class Parallel 
    {

        

        dynamic parallel;
        
        public Parallel()
        {
            this.parallel =  TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Parallel");
        }

        public Parallel(dynamic tsObject)
        {
            this.parallel = tsObject;

        }


        public dynamic GetTSObject() => parallel;

		public System.Boolean VectorToVector(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2)
			 => parallel.VectorToVector(Vector1.GetTSObject(), Vector2.GetTSObject());

		public System.Boolean VectorToVector(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2, System.Double Tolerance)
			 => parallel.VectorToVector(Vector1.GetTSObject(), Vector2.GetTSObject(), Tolerance);

		public System.Boolean LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line Line1, Dynamic.Tekla.Structures.Geometry3d.Line Line2)
			 => parallel.LineToLine(Line1.GetTSObject(), Line2.GetTSObject());

		public System.Boolean LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line Line1, Dynamic.Tekla.Structures.Geometry3d.Line Line2, System.Double Tolerance)
			 => parallel.LineToLine(Line1.GetTSObject(), Line2.GetTSObject(), Tolerance);

		public System.Boolean LineSegmentToLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment1, Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment2)
			 => parallel.LineSegmentToLineSegment(LineSegment1.GetTSObject(), LineSegment2.GetTSObject());

		public System.Boolean LineSegmentToLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment1, Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment2, System.Double Tolerance)
			 => parallel.LineSegmentToLineSegment(LineSegment1.GetTSObject(), LineSegment2.GetTSObject(), Tolerance);

		public System.Boolean PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane1, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane2)
			 => parallel.PlaneToPlane(Plane1.GetTSObject(), Plane2.GetTSObject());

		public System.Boolean PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane1, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane2, System.Double Tolerance)
			 => parallel.PlaneToPlane(Plane1.GetTSObject(), Plane2.GetTSObject(), Tolerance);

		public System.Boolean VectorToPlane(Dynamic.Tekla.Structures.Geometry3d.Vector Vector, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => parallel.VectorToPlane(Vector.GetTSObject(), Plane.GetTSObject());

		public System.Boolean VectorToPlane(Dynamic.Tekla.Structures.Geometry3d.Vector Vector, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane, System.Double Tolerance)
			 => parallel.VectorToPlane(Vector.GetTSObject(), Plane.GetTSObject(), Tolerance);

		public System.Boolean LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => parallel.LineToPlane(Line.GetTSObject(), Plane.GetTSObject());

		public System.Boolean LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane, System.Double Tolerance)
			 => parallel.LineToPlane(Line.GetTSObject(), Plane.GetTSObject(), Tolerance);

		public System.Boolean LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => parallel.LineSegmentToPlane(LineSegment.GetTSObject(), Plane.GetTSObject());

		public System.Boolean LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane, System.Double Tolerance)
			 => parallel.LineSegmentToPlane(LineSegment.GetTSObject(), Plane.GetTSObject(), Tolerance);





    }

}
    
