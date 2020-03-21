//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class Offset 
    {

		public System.Double Dx
		{
			get => teklaObject.Dx;
			set { teklaObject.Dx = value; }
		}

		public System.Double Dy
		{
			get => teklaObject.Dy;
			set { teklaObject.Dy = value; }
		}

		public System.Double Dz
		{
			get => teklaObject.Dz;
			set { teklaObject.Dz = value; }
		}

        

        internal dynamic teklaObject;

		public Offset()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Offset");
		}





    }

    internal static class Offset_
    {
        public static dynamic GetTSObject(Offset dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Offset FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Offset)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
