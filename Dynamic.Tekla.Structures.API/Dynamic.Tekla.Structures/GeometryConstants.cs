//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class GeometryConstants 
    {

        

        dynamic geometryconstants;
        
        public GeometryConstants()
        {
            this.geometryconstants =  new Tekla.Structures.Geometry3d.GeometryConstants();
        }

        public GeometryConstants(dynamic tsObject)
        {
            this.geometryconstants = tsObject;

        }


        public dynamic GetTSObject() => geometryconstants;

		public System.Boolean Equals(System.Object obj)
			 => geometryconstants.Equals(obj);

		public System.Int32 GetHashCode()
			 => geometryconstants.GetHashCode();

		public System.Type GetType()
			 => geometryconstants.GetType();

		public System.String ToString()
			 => geometryconstants.ToString();





    }

}
    
