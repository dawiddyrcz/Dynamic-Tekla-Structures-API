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
			get => Dynamic.Tekla.Structures.Model.BendSurface_.FromTSObject(bendsurfacenode.Surface);
			set { bendsurfacenode.Surface = Dynamic.Tekla.Structures.Model.BendSurface_.GetTSObject(value); }
		}

        

        internal dynamic bendsurfacenode;
        
        private BendSurfaceNode()
        {
            this.bendsurfacenode =  TSActivator.CreateInstance("Tekla.Structures.Model.BendSurfaceNode");
        }

        internal BendSurfaceNode(dynamic tsObject)
        {
            this.bendsurfacenode = tsObject;
        }
		public BendSurfaceNode(Dynamic.Tekla.Structures.Model.BendSurface surface)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.BendSurface_.GetTSObject(surface);
			this.bendsurfacenode = TSActivator.CreateInstance("Tekla.Structures.Model.BendSurfaceNode", args);
		}

		public void AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor)
			 => bendsurfacenode.AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor_.GetTSObject(visitor));





    }

    internal static class BendSurfaceNode_
    {
        public static dynamic GetTSObject(BendSurfaceNode dynObject)
        {
            return dynObject.bendsurfacenode;
        }

        public static BendSurfaceNode FromTSObject(dynamic tsObject)
        {
            return new BendSurfaceNode(tsObject);
        }
    }


}
    
