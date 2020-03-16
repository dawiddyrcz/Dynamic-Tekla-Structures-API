//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class GeometrySection 
    {

		public System.Int32 Index
		{
			get => geometrysection.Index;
			set { geometrysection.Index = value; }
		}

		public Dynamic.Tekla.Structures.Model.IGeometryNode GeometryNode
		{
			get => new Dynamic.Tekla.Structures.Model.IGeometryNode(geometrysection.GeometryNode.GetTSObject());
			set { geometrysection.GeometryNode = value.GetTSObject(); }
		}

        

        dynamic geometrysection;
        
        public GeometrySection()
        {
            this.geometrysection =  new Tekla.Structures.Model.GeometrySection();
        }

        public GeometrySection(dynamic tsObject)
        {
            this.geometrysection = tsObject;
			this.Index = geometrysection.Index;
			this.GeometryNode = new Dynamic.Tekla.Structures.Model.IGeometryNode(geometrysection.GeometryNode);

        }


        public dynamic GetTSObject() => geometrysection;

		public System.Boolean Equals(System.Object obj)
			 => geometrysection.Equals(obj);

		public System.Int32 GetHashCode()
			 => geometrysection.GetHashCode();

		public System.Type GetType()
			 => geometrysection.GetType();

		public System.String ToString()
			 => geometrysection.ToString();





    }

}
    
