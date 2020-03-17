//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class CylindricalSurfaceNode 
    {

		public Dynamic.Tekla.Structures.Model.CylindricalSurface Surface
		{
			get => new Dynamic.Tekla.Structures.Model.CylindricalSurface(cylindricalsurfacenode.Surface.GetTSObject());
			set { cylindricalsurfacenode.Surface = value.GetTSObject(); }
		}

		public System.Boolean IsAutomatic
		{
			get => cylindricalsurfacenode.IsAutomatic;
			set { cylindricalsurfacenode.IsAutomatic = value; }
		}


        

        dynamic cylindricalsurfacenode;
        
        public CylindricalSurfaceNode()
        {
            this.cylindricalsurfacenode =  TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurfaceNode");
        }

        public CylindricalSurfaceNode(dynamic tsObject)
        {
            this.cylindricalsurfacenode = tsObject;
			this.IsAutomatic = cylindricalsurfacenode.IsAutomatic;

        }


        public dynamic GetTSObject() => cylindricalsurfacenode;





    }

}
    
