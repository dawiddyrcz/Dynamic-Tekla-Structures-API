/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class FacetedBrepFaceHole 
    {

		public System.Int32 Count
		{
			get => teklaObject.Count;

		}

		public System.Boolean IsReadOnly
		{
			get => teklaObject.IsReadOnly;

		}

		public System.Collections.Generic.IList<System.Int32> VerticeIndexes
		{
			get => teklaObject.VerticeIndexes;

		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Vector> Vertices
		{
			get => teklaObject.Vertices;

		}

        

        internal dynamic teklaObject;

		internal FacetedBrepFaceHole() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public FacetedBrepFaceHole(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class FacetedBrepFaceHole_
    {
        public static dynamic GetTSObject(FacetedBrepFaceHole dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static FacetedBrepFaceHole FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFaceHole)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FacetedBrepFaceHoleArray_
    {
        public static dynamic GetTSObject(FacetedBrepFaceHole[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FacetedBrepFaceHole_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FacetedBrepFaceHole[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<FacetedBrepFaceHole>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FacetedBrepFaceHole_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
