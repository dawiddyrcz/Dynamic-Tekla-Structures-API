//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class CylindricalSurfaceNode 
    {

		public Dynamic.Tekla.Structures.Model.CylindricalSurface Surface
		{
			get => Dynamic.Tekla.Structures.Model.CylindricalSurface_.FromTSObject(cylindricalsurfacenode.Surface);
			set { cylindricalsurfacenode.Surface = Dynamic.Tekla.Structures.Model.CylindricalSurface_.GetTSObject(value); }
		}

		public System.Boolean IsAutomatic
		{
			get => cylindricalsurfacenode.IsAutomatic;
			set { cylindricalsurfacenode.IsAutomatic = value; }
		}

        

        internal dynamic cylindricalsurfacenode;
        
        public CylindricalSurfaceNode()
        {
            this.cylindricalsurfacenode =  TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurfaceNode");
        }

        internal CylindricalSurfaceNode(dynamic tsObject)
        {
            this.cylindricalsurfacenode = tsObject;
        }




    }

    internal static class CylindricalSurfaceNode_
    {
        public static dynamic GetTSObject(CylindricalSurfaceNode dynObject)
        {
            return dynObject.cylindricalsurfacenode;
        }

        public static CylindricalSurfaceNode FromTSObject(dynamic tsObject)
        {
            return new CylindricalSurfaceNode(tsObject);
        }
    }


}
    
