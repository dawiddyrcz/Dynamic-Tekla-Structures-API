//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class ViewCamera 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Location
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(viewcamera.Location);
			set { viewcamera.Location = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector DirectionVector
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(viewcamera.DirectionVector);
			set { viewcamera.DirectionVector = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(viewcamera.UpVector);
			set { viewcamera.UpVector = value.GetTSObject(); }
		}

		public System.Double FieldOfView
		{
			get => viewcamera.FieldOfView;
			set { viewcamera.FieldOfView = value; }
		}

		public System.Double ZoomFactor
		{
			get => viewcamera.ZoomFactor;
			set { viewcamera.ZoomFactor = value; }
		}

		public Dynamic.Tekla.Structures.Model.UI.View View
		{
			get => new Dynamic.Tekla.Structures.Model.UI.View(viewcamera.View);
			set { viewcamera.View = value.GetTSObject(); }
		}

        

        dynamic viewcamera;
        
        public ViewCamera()
        {
            this.viewcamera =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewCamera");
        }

        public ViewCamera(dynamic tsObject)
        {
            this.viewcamera = tsObject;
        }

        internal dynamic GetTSObject() => viewcamera;

		public System.Boolean Select()
			 => viewcamera.Select();

		public System.Boolean Modify()
			 => viewcamera.Modify();





    }

}
    
