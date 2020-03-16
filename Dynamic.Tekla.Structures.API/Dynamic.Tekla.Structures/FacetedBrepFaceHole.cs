//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class FacetedBrepFaceHole 
    {

		public System.Int32 Count
		{
			get => facetedbrepfacehole.Count;
			set { facetedbrepfacehole.Count = value; }
		}

		public System.Boolean IsReadOnly
		{
			get => facetedbrepfacehole.IsReadOnly;
			set { facetedbrepfacehole.IsReadOnly = value; }
		}

		public System.Collections.Generic.IList<System.Int32> VerticeIndexes
		{
			get => facetedbrepfacehole.VerticeIndexes;
			set { facetedbrepfacehole.VerticeIndexes = value; }
		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Vector> Vertices
		{
			get => facetedbrepfacehole.Vertices;
			set { facetedbrepfacehole.Vertices = value; }
		}

        

        dynamic facetedbrepfacehole;
        
        public FacetedBrepFaceHole()
        {
            this.facetedbrepfacehole =  new Tekla.Structures.Geometry3d.FacetedBrepFaceHole();
        }

        public FacetedBrepFaceHole(dynamic tsObject)
        {
            this.facetedbrepfacehole = tsObject;
			this.Count = facetedbrepfacehole.Count;
			this.IsReadOnly = facetedbrepfacehole.IsReadOnly;
			this.VerticeIndexes = facetedbrepfacehole.VerticeIndexes;
			this.Vertices = facetedbrepfacehole.Vertices;

        }


        public dynamic GetTSObject() => facetedbrepfacehole;





    }

}
    
