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
			get => new Dynamic.Tekla.Structures.Model.Contour(polygonnode.Contour.GetTSObject());
			set { polygonnode.Contour = value.GetTSObject(); }
		}

        

        dynamic polygonnode;
        
        public PolygonNode()
        {
            this.polygonnode =  TSActivator.CreateInstance("Tekla.Structures.Model.PolygonNode");
        }

        public PolygonNode(dynamic tsObject)
        {
            this.polygonnode = tsObject;
			this.IsAutomatic = polygonnode.IsAutomatic;
			this.Contour = new Dynamic.Tekla.Structures.Model.Contour(polygonnode.Contour);

        }


        public dynamic GetTSObject() => polygonnode;

		




    }

}
    
