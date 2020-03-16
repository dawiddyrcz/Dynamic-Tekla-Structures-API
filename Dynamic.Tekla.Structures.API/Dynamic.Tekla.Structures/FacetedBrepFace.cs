//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class FacetedBrepFace 
    {

		public System.Boolean HasHoles
		{
			get => facetedbrepface.HasHoles;
			set { facetedbrepface.HasHoles = value; }
		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFaceHole> Holes
		{
			get => facetedbrepface.Holes;
			set { facetedbrepface.Holes = value; }
		}

		public System.Boolean IsReadOnly
		{
			get => facetedbrepface.IsReadOnly;
			set { facetedbrepface.IsReadOnly = value; }
		}

		public System.Collections.Generic.IList<System.Int32> VerticeIndexes
		{
			get => facetedbrepface.VerticeIndexes;
			set { facetedbrepface.VerticeIndexes = value; }
		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Vector> Vertices
		{
			get => facetedbrepface.Vertices;
			set { facetedbrepface.Vertices = value; }
		}

        

        dynamic facetedbrepface;
        
        public FacetedBrepFace()
        {
            this.facetedbrepface =  new Tekla.Structures.Geometry3d.FacetedBrepFace();
        }

        public FacetedBrepFace(dynamic tsObject)
        {
            this.facetedbrepface = tsObject;
			this.HasHoles = facetedbrepface.HasHoles;
			this.Holes = facetedbrepface.Holes;
			this.IsReadOnly = facetedbrepface.IsReadOnly;
			this.VerticeIndexes = facetedbrepface.VerticeIndexes;
			this.Vertices = facetedbrepface.Vertices;

        }


        public dynamic GetTSObject() => facetedbrepface;





    }

}
    
