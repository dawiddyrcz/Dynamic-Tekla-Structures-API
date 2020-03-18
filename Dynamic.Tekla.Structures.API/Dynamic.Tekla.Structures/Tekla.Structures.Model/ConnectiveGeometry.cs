//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ConnectiveGeometry 
    {

        

        internal dynamic connectivegeometry;
        
        public ConnectiveGeometry()
        {
            this.connectivegeometry =  TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometry");
        }

        internal ConnectiveGeometry(dynamic tsObject)
        {
            this.connectivegeometry = tsObject;
        }

		public System.Boolean IsEmpty()
			 => connectivegeometry.IsEmpty();

		public Dynamic.Tekla.Structures.Model.GeometrySectionEnumerator GetGeometryEnumerator()
			 => Dynamic.Tekla.Structures.Model.GeometrySectionEnumerator_.FromTSObject(connectivegeometry.GetGeometryEnumerator());





    }

    internal static class ConnectiveGeometry_
    {
        public static dynamic GetTSObject(ConnectiveGeometry dynObject)
        {
            return dynObject.connectivegeometry;
        }

        public static ConnectiveGeometry FromTSObject(dynamic tsObject)
        {
            return new ConnectiveGeometry(tsObject);
        }
    }


}
    
