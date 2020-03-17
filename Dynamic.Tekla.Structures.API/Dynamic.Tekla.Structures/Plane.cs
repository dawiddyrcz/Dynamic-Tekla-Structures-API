//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Plane 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(plane.Origin.GetTSObject());
			set { plane.Origin = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector AxisX
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(plane.AxisX.GetTSObject());
			set { plane.AxisX = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector AxisY
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(plane.AxisY.GetTSObject());
			set { plane.AxisY = value.GetTSObject(); }
		}

        

        dynamic plane;
        
        public Plane()
        {
            this.plane =  TSActivator.CreateInstance("Tekla.Structures.Model.Plane");
        }

        public Plane(dynamic tsObject)
        {
            this.plane = tsObject;
			this.Origin = new Dynamic.Tekla.Structures.Geometry3d.Point(plane.Origin);
			this.AxisX = new Dynamic.Tekla.Structures.Geometry3d.Vector(plane.AxisX);
			this.AxisY = new Dynamic.Tekla.Structures.Geometry3d.Vector(plane.AxisY);

        }


        public dynamic GetTSObject() => plane;





    }

}
    
