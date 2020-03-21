//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class CutPlane  : Dynamic.Tekla.Structures.Model.Boolean
    {

		public Dynamic.Tekla.Structures.Model.Plane Plane
		{
			get => Dynamic.Tekla.Structures.Model.Plane_.FromTSObject(teklaObject.Plane);
			set { teklaObject.Plane = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(value); }
		}

        

        

		public CutPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CutPlane");
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}





    }

    internal static class CutPlane_
    {
        public static dynamic GetTSObject(CutPlane dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CutPlane FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.CutPlane)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
