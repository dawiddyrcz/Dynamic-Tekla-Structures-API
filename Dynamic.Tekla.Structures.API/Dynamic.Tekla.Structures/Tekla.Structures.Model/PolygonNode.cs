//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class PolygonNode 
    {

		public System.Boolean IsAutomatic
		{
			get => polygonnode.IsAutomatic;
			set { polygonnode.IsAutomatic = value; }
		}

		public Dynamic.Tekla.Structures.Model.Contour Contour
		{
			get => Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(polygonnode.Contour);
			set { polygonnode.Contour = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value); }
		}

        

        internal dynamic polygonnode;
        
        public PolygonNode()
        {
            this.polygonnode =  TSActivator.CreateInstance("Tekla.Structures.Model.PolygonNode");
        }

        internal PolygonNode(dynamic tsObject)
        {
            this.polygonnode = tsObject;
        }

	



    }

    internal static class PolygonNode_
    {
        public static dynamic GetTSObject(PolygonNode dynObject)
        {
            return dynObject.polygonnode;
        }

        public static PolygonNode FromTSObject(dynamic tsObject)
        {
            return new PolygonNode(tsObject);
        }
    }


}
    