//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarHookDataNullable 
    {

		public Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum Shape
		{
			get => rebarhookdatanullable.Shape;
			set { rebarhookdatanullable.Shape = value; }
		}

		public System.Double Angle
		{
			get => rebarhookdatanullable.Angle;
			set { rebarhookdatanullable.Angle = value; }
		}

		public System.Double Radius
		{
			get => rebarhookdatanullable.Radius;
			set { rebarhookdatanullable.Radius = value; }
		}

		public System.Double Length
		{
			get => rebarhookdatanullable.Length;
			set { rebarhookdatanullable.Length = value; }
		}

		public System.Double Rotation
		{
			get => rebarhookdatanullable.Rotation;
			set { rebarhookdatanullable.Rotation = value; }
		}

        

        dynamic rebarhookdatanullable;
        
        public RebarHookDataNullable()
        {
            this.rebarhookdatanullable =  TSActivator.CreateInstance("Tekla.Structures.Model.RebarHookDataNullable");
        }

        public RebarHookDataNullable(dynamic tsObject)
        {
            this.rebarhookdatanullable = tsObject;
			this.Shape = rebarhookdatanullable.Shape;
			this.Angle = rebarhookdatanullable.Angle;
			this.Radius = rebarhookdatanullable.Radius;
			this.Length = rebarhookdatanullable.Length;
			this.Rotation = rebarhookdatanullable.Rotation;

        }


        public dynamic GetTSObject() => rebarhookdatanullable;





    }

}
    
