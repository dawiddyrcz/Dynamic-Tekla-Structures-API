//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class Distance 
    {

        

        dynamic distance;
        
        public Distance()
        {
            this.distance =  new Tekla.Structures.Geometry3d.Distance();
        }

        public Distance(dynamic tsObject)
        {
            this.distance = tsObject;

        }


        public dynamic GetTSObject() => distance;

		public System.Double PointToPoint(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2)
			 => distance.PointToPoint(Point1.GetTSObject(), Point2.GetTSObject());

		public System.Double PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.Line Line)
			 => distance.PointToLine(Point.GetTSObject(), Line.GetTSObject());

		public System.Double PointToLineSegment(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment)
			 => distance.PointToLineSegment(Point.GetTSObject(), LineSegment.GetTSObject());

		public System.Double PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
			 => distance.PointToPlane(Point.GetTSObject(), Plane.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => distance.Equals(obj);

		public System.Int32 GetHashCode()
			 => distance.GetHashCode();

		public System.Type GetType()
			 => distance.GetType();

		public System.String ToString()
			 => distance.ToString();





    }

}
    
