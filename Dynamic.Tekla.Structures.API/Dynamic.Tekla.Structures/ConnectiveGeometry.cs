//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ConnectiveGeometry 
    {

        

        dynamic connectivegeometry;
        
        public ConnectiveGeometry()
        {
            this.connectivegeometry =  new Tekla.Structures.Model.ConnectiveGeometry();
        }

        public ConnectiveGeometry(dynamic tsObject)
        {
            this.connectivegeometry = tsObject;

        }


        public dynamic GetTSObject() => connectivegeometry;

		public System.Boolean IsEmpty()
			 => connectivegeometry.IsEmpty();

		public Dynamic.Tekla.Structures.Model.GeometrySectionEnumerator GetGeometryEnumerator()
			 => new Dynamic.Tekla.Structures.Model.GeometrySectionEnumerator(connectivegeometry.GetGeometryEnumerator());

		public System.Collections.Generic.IListTekla.Structures.Model.GeometrySection<Dynamic.Tekla.Structures.Model.GeometrySection> GetNeighborSections(Dynamic.Tekla.Structures.Model.GeometrySection geometrySection)
			 => connectivegeometry.GetNeighborSections(geometrySection.GetTSObject());

		public System.Collections.Generic.IListTekla.Structures.Model.GeometrySection<Dynamic.Tekla.Structures.Model.GeometrySection> GetGeometryLegSections()
			 => connectivegeometry.GetGeometryLegSections();

		public System.Collections.Generic.IListTekla.Structures.Geometry3d.LineSegment<Dynamic.Tekla.Structures.Geometry3d.LineSegment> GetConnection(Dynamic.Tekla.Structures.Model.GeometrySection geometrySection1, Dynamic.Tekla.Structures.Model.GeometrySection geometrySection2)
			 => connectivegeometry.GetConnection(geometrySection1.GetTSObject(), geometrySection2.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => connectivegeometry.Equals(obj);

		public System.Int32 GetHashCode()
			 => connectivegeometry.GetHashCode();

		public System.Type GetType()
			 => connectivegeometry.GetType();

		public System.String ToString()
			 => connectivegeometry.ToString();





    }

}
    
