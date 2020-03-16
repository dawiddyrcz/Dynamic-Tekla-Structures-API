//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class Point 
    {

        

        dynamic point;
        
        public Point()
        {
            this.point =  new Tekla.Structures.Geometry3d.Point();
        }

        public Point(dynamic tsObject)
        {
            this.point = tsObject;

        }


        public dynamic GetTSObject() => point;

		public void Zero()
			 => point.Zero();

		public System.String ToString()
			 => point.ToString();

		public void Translate(System.Double X, System.Double Y, System.Double Z)
			 => point.Translate(X, Y, Z);

		public Dynamic.Tekla.Structures.Geometry3d.Point op_Addition(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(point.op_Addition(p1.GetTSObject(), p2.GetTSObject()));

		public Dynamic.Tekla.Structures.Geometry3d.Point op_Subtraction(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(point.op_Subtraction(p1.GetTSObject(), p2.GetTSObject()));

		public System.Boolean op_Equality(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
			 => point.op_Equality(p1.GetTSObject(), p2.GetTSObject());

		public System.Boolean op_Inequality(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
			 => point.op_Inequality(p1.GetTSObject(), p2.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => point.Equals(obj);

		public System.Int32 GetHashCode()
			 => point.GetHashCode();

		public System.Boolean AreEqual(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2)
			 => point.AreEqual(Point1.GetTSObject(), Point2.GetTSObject());

		public System.Int32 CompareTo(System.Object obj)
			 => point.CompareTo(obj);

		public System.Type GetType()
			 => point.GetType();





    }

}
    
