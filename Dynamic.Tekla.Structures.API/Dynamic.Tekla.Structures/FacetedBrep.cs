//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class FacetedBrep 
    {

		public System.Collections.Generic.ICollectionTekla.Structures.Geometry3d.FacetedBrepFace<Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFace> Faces
		{
			get => facetedbrep.Faces;
			set { facetedbrep.Faces = value; }
		}

		public System.Collections.Generic.IDictionarySystem.Int32<System.Int32, System.Int32> InnerWires
		{
			get => facetedbrep.InnerWires;
			set { facetedbrep.InnerWires = value; }
		}

		public System.Int32 OuterWires
		{
			get => facetedbrep.OuterWires;
			set { facetedbrep.OuterWires = value; }
		}

		public System.Collections.Generic.IListTekla.Structures.Geometry3d.IndirectPolymeshEdge<Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge> GetEdges
		{
			get => facetedbrep.GetEdges;
			set { facetedbrep.GetEdges = value; }
		}

		public System.Collections.Generic.IListTekla.Structures.Geometry3d.Vector<Dynamic.Tekla.Structures.Geometry3d.Vector> Vertices
		{
			get => facetedbrep.Vertices;
			set { facetedbrep.Vertices = value; }
		}

        

        dynamic facetedbrep;
        
        public FacetedBrep()
        {
            this.facetedbrep =  new Tekla.Structures.Geometry3d.FacetedBrep();
        }

        public FacetedBrep(dynamic tsObject)
        {
            this.facetedbrep = tsObject;
			this.Faces = facetedbrep.Faces;
			this.InnerWires = facetedbrep.InnerWires;
			this.OuterWires = facetedbrep.OuterWires;
			this.GetEdges = facetedbrep.GetEdges;
			this.Vertices = facetedbrep.Vertices;

        }


        public dynamic GetTSObject() => facetedbrep;

		public System.Boolean CheckForTwoManifold()
			 => facetedbrep.CheckForTwoManifold();

		public System.Int32 GetInnerFace(System.Int32 faceIndex)
			 => facetedbrep.GetInnerFace(faceIndex);

		public System.Int32 GetInnerFaceCount(System.Int32 faceIndex)
			 => facetedbrep.GetInnerFaceCount(faceIndex);

		public System.Int32 GetOuterFace(System.Int32 faceIndex)
			 => facetedbrep.GetOuterFace(faceIndex);

		public System.Boolean Equals(System.Object obj)
			 => facetedbrep.Equals(obj);

		public System.Int32 GetHashCode()
			 => facetedbrep.GetHashCode();

		public System.Type GetType()
			 => facetedbrep.GetType();

		public System.String ToString()
			 => facetedbrep.ToString();





    }

}
    
