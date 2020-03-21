//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class FacetedBrepFaceHole 
    {

		public System.Int32 Count
		{
			get => teklaObject.Count;
			set { teklaObject.Count = value; }
		}

		public System.Boolean IsReadOnly
		{
			get => teklaObject.IsReadOnly;
			set { teklaObject.IsReadOnly = value; }
		}

		public System.Collections.Generic.IList<System.Int32> VerticeIndexes
		{
			get => teklaObject.VerticeIndexes;
			set { teklaObject.VerticeIndexes = value; }
		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Vector> Vertices
		{
			get => teklaObject.Vertices;
			set { teklaObject.Vertices = value; }
		}

        

        internal dynamic teklaObject;

		public FacetedBrepFaceHole() {}





    }

    internal static class FacetedBrepFaceHole_
    {
        public static dynamic GetTSObject(FacetedBrepFaceHole dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FacetedBrepFaceHole FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.FacetedBrepFaceHole)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
