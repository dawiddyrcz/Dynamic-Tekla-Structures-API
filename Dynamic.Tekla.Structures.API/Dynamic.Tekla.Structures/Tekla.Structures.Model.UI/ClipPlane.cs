//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class ClipPlane 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Location
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(clipplane.Location);
			set { clipplane.Location = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(clipplane.UpVector);
			set { clipplane.UpVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.UI.View View
		{
			get => Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(clipplane.View);
			set { clipplane.View = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(value); }
		}

        

        internal dynamic clipplane;
        
        public ClipPlane()
        {
            this.clipplane =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.ClipPlane");
        }

        internal ClipPlane(dynamic tsObject)
        {
            this.clipplane = tsObject;
        }

		public System.Boolean Insert()
			 => clipplane.Insert();

		public System.Boolean Delete()
			 => clipplane.Delete();

		public System.Boolean Modify()
			 => clipplane.Modify();





    }

    internal static class ClipPlane_
    {
        public static dynamic GetTSObject(ClipPlane dynObject)
        {
            return dynObject.clipplane;
        }

        public static ClipPlane FromTSObject(dynamic tsObject)
        {
            return new ClipPlane(tsObject);
        }
    }


}
    
