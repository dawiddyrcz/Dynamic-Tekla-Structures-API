//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSetAddition  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarLegFace> LegFaces
		{
			get => teklaObject.LegFaces;
			set { teklaObject.LegFaces = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarSet Father
		{
			get => Dynamic.Tekla.Structures.Model.RebarSet_.FromTSObject(teklaObject.Father);
			set { teklaObject.Father = Dynamic.Tekla.Structures.Model.RebarSet_.GetTSObject(value); }
		}

        

        

		public RebarSetAddition()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSetAddition");
		}

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public System.Boolean Select()
			 => teklaObject.Select();





    }

    internal static class RebarSetAddition_
    {
        public static dynamic GetTSObject(RebarSetAddition dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarSetAddition FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.RebarSetAddition)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
