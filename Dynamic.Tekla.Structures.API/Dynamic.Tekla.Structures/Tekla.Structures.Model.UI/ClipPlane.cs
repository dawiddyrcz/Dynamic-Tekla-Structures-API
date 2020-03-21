//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ClipPlane 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Location
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Location);
			set { teklaObject.Location = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpVector);
			set { teklaObject.UpVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.UI.View View
		{
			get => Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(teklaObject.View);
			set { teklaObject.View = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public ClipPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ClipPlane");
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}





    }

    internal static class ClipPlane_
    {
        public static dynamic GetTSObject(ClipPlane dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClipPlane FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.UI.ClipPlane)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
