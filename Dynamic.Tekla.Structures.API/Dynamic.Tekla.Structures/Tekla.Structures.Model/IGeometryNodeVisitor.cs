//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class IGeometryNodeVisitor 
    {

        

        internal dynamic teklaObject;

		internal IGeometryNodeVisitor() {}

		public void Visit(Dynamic.Tekla.Structures.Model.PolygonNode node)
			 => teklaObject.Visit(Dynamic.Tekla.Structures.Model.PolygonNode_.GetTSObject(node));

		public void Visit(Dynamic.Tekla.Structures.Model.CylindricalSurfaceNode node)
			 => teklaObject.Visit(Dynamic.Tekla.Structures.Model.CylindricalSurfaceNode_.GetTSObject(node));





    }

    internal static class IGeometryNodeVisitor_
    {
        public static dynamic GetTSObject(IGeometryNodeVisitor dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IGeometryNodeVisitor FromTSObject(dynamic tsObject)
        {
            return new IGeometryNodeVisitor() { teklaObject = tsObject };
        }
    }


}
    
