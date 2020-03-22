/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class FacetedBrepFace 
    {

		public System.Boolean HasHoles
		{
			get => teklaObject.HasHoles;
			set { teklaObject.HasHoles = value; }
		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFaceHole> Holes
		{
			get => teklaObject.Holes;
			set { teklaObject.Holes = value; }
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

		public FacetedBrepFace() {}





    }

    internal static class FacetedBrepFace_
    {
        public static dynamic GetTSObject(FacetedBrepFace dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FacetedBrepFace FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.FacetedBrepFace)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
