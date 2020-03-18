//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class BendSurfaceNode 
    {

		public System.Boolean IsAutomatic
		{
			get => bendsurfacenode.IsAutomatic;
			set { bendsurfacenode.IsAutomatic = value; }
		}

		public Dynamic.Tekla.Structures.Model.BendSurface Surface
		{
			get => new Dynamic.Tekla.Structures.Model.BendSurface(bendsurfacenode.Surface);
			set { bendsurfacenode.Surface = value.GetTSObject(); }
		}

        

        dynamic bendsurfacenode;
        
        private BendSurfaceNode()
        {
            this.bendsurfacenode =  TSActivator.CreateInstance("Tekla.Structures.Model.BendSurfaceNode");
        }

        public BendSurfaceNode(dynamic tsObject)
        {
            this.bendsurfacenode = tsObject;
        }

        internal dynamic GetTSObject() => bendsurfacenode;

		public void AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor)
			 => bendsurfacenode.AcceptVisitor(visitor.GetTSObject());





    }

}
    
