//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class IGeometryNode 
    {

		public System.Boolean IsAutomatic
		{
			get => igeometrynode.IsAutomatic;
			set { igeometrynode.IsAutomatic = value; }
		}

        

        internal dynamic igeometrynode;
        
        private IGeometryNode()
        {
            this.igeometrynode =  TSActivator.CreateInstance("Tekla.Structures.Model.IGeometryNode");
        }

        internal IGeometryNode(dynamic tsObject)
        {
            this.igeometrynode = tsObject;
        }

		public void AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor visitor)
			 => igeometrynode.AcceptVisitor(Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor_.GetTSObject(visitor));





    }

    internal static class IGeometryNode_
    {
        public static dynamic GetTSObject(IGeometryNode dynObject)
        {
            return dynObject.igeometrynode;
        }

        public static IGeometryNode FromTSObject(dynamic tsObject)
        {
            return new IGeometryNode(tsObject);
        }
    }


}
    
