//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class AABB 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point MinPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(aabb.MinPoint.GetTSObject());
			set { aabb.MinPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point MaxPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(aabb.MaxPoint.GetTSObject());
			set { aabb.MaxPoint = value.GetTSObject(); }
		}

        

        dynamic aabb;
        
        public AABB()
        {
            this.aabb =  new Tekla.Structures.Geometry3d.AABB();
        }

        public AABB(dynamic tsObject)
        {
            this.aabb = tsObject;
			this.MinPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(aabb.MinPoint);
			this.MaxPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(aabb.MaxPoint);

        }


        public dynamic GetTSObject() => aabb;

		public System.Boolean IsInside(Dynamic.Tekla.Structures.Geometry3d.Point Point)
			 => aabb.IsInside(Point.GetTSObject());

		public System.Boolean IsInside(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment)
			 => aabb.IsInside(LineSegment.GetTSObject());

		public Dynamic.Tekla.Structures.Geometry3d.Point GetCenterPoint()
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(aabb.GetCenterPoint());

		public System.Boolean Collide(Dynamic.Tekla.Structures.Geometry3d.AABB Other)
			 => aabb.Collide(Other.GetTSObject());

		public Dynamic.Tekla.Structures.Geometry3d.AABB op_Addition(Dynamic.Tekla.Structures.Geometry3d.AABB AABB1, Dynamic.Tekla.Structures.Geometry3d.AABB AABB2)
			 => new Dynamic.Tekla.Structures.Geometry3d.AABB(aabb.op_Addition(AABB1.GetTSObject(), AABB2.GetTSObject()));

		public Dynamic.Tekla.Structures.Geometry3d.AABB op_Addition(Dynamic.Tekla.Structures.Geometry3d.AABB AABB, Dynamic.Tekla.Structures.Geometry3d.Point Point)
			 => new Dynamic.Tekla.Structures.Geometry3d.AABB(aabb.op_Addition(AABB.GetTSObject(), Point.GetTSObject()));

		public Dynamic.Tekla.Structures.Geometry3d.AABB op_Addition(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.AABB AABB)
			 => new Dynamic.Tekla.Structures.Geometry3d.AABB(aabb.op_Addition(Point.GetTSObject(), AABB.GetTSObject()));





    }

}
    
