//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarHookDataNullable 
    {

		public Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum Shape
		{
			get => teklaObject.Shape;
			set { teklaObject.Shape = value; }
		}

		public System.Double Angle
		{
			get => teklaObject.Angle;
			set { teklaObject.Angle = value; }
		}

		public System.Double Radius
		{
			get => teklaObject.Radius;
			set { teklaObject.Radius = value; }
		}

		public System.Double Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

		public System.Double Rotation
		{
			get => teklaObject.Rotation;
			set { teklaObject.Rotation = value; }
		}

        

        internal dynamic teklaObject;

		public RebarHookDataNullable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarHookDataNullable");
		}





    }

    internal static class RebarHookDataNullable_
    {
        public static dynamic GetTSObject(RebarHookDataNullable dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarHookDataNullable FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.RebarHookDataNullable)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
