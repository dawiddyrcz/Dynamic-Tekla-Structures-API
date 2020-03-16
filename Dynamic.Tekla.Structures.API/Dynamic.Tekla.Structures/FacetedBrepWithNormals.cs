//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class FacetedBrepWithNormals 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Vector Normals
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(facetedbrepwithnormals.Normals.GetTSObject());
			set { facetedbrepwithnormals.Normals = value.GetTSObject(); }
		}

		public System.Collections.Generic.ICollectionTekla.Structures.Geometry3d.FacetedBrepFace<Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFace> Faces
		{
			get => facetedbrepwithnormals.Faces;
			set { facetedbrepwithnormals.Faces = value; }
		}

		public System.Collections.Generic.IDictionarySystem.Int32<System.Int32, System.Int32> InnerWires
		{
			get => facetedbrepwithnormals.InnerWires;
			set { facetedbrepwithnormals.InnerWires = value; }
		}

		public System.Int32 OuterWires
		{
			get => facetedbrepwithnormals.OuterWires;
			set { facetedbrepwithnormals.OuterWires = value; }
		}

		public System.Collections.Generic.IListTekla.Structures.Geometry3d.IndirectPolymeshEdge<Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge> GetEdges
		{
			get => facetedbrepwithnormals.GetEdges;
			set { facetedbrepwithnormals.GetEdges = value; }
		}

		public System.Collections.Generic.IListTekla.Structures.Geometry3d.Vector<Dynamic.Tekla.Structures.Geometry3d.Vector> Vertices
		{
			get => facetedbrepwithnormals.Vertices;
			set { facetedbrepwithnormals.Vertices = value; }
		}

        

        dynamic facetedbrepwithnormals;
        
        public FacetedBrepWithNormals()
        {
            this.facetedbrepwithnormals =  new Tekla.Structures.Geometry3d.FacetedBrepWithNormals();
        }

        public FacetedBrepWithNormals(dynamic tsObject)
        {
            this.facetedbrepwithnormals = tsObject;
			this.Normals = new Dynamic.Tekla.Structures.Geometry3d.Vector(facetedbrepwithnormals.Normals);
			this.Faces = facetedbrepwithnormals.Faces;
			this.InnerWires = facetedbrepwithnormals.InnerWires;
			this.OuterWires = facetedbrepwithnormals.OuterWires;
			this.GetEdges = facetedbrepwithnormals.GetEdges;
			this.Vertices = facetedbrepwithnormals.Vertices;

        }


        public dynamic GetTSObject() => facetedbrepwithnormals;

		public System.Boolean CheckForTwoManifold()
			 => facetedbrepwithnormals.CheckForTwoManifold();

		public System.Int32 GetInnerFace(System.Int32 faceIndex)
			 => facetedbrepwithnormals.GetInnerFace(faceIndex);

		public System.Int32 GetInnerFaceCount(System.Int32 faceIndex)
			 => facetedbrepwithnormals.GetInnerFaceCount(faceIndex);

		public System.Int32 GetOuterFace(System.Int32 faceIndex)
			 => facetedbrepwithnormals.GetOuterFace(faceIndex);

		public System.Boolean Equals(System.Object obj)
			 => facetedbrepwithnormals.Equals(obj);

		public System.Int32 GetHashCode()
			 => facetedbrepwithnormals.GetHashCode();

		public System.Type GetType()
			 => facetedbrepwithnormals.GetType();

		public System.String ToString()
			 => facetedbrepwithnormals.ToString();





    }

}
    
