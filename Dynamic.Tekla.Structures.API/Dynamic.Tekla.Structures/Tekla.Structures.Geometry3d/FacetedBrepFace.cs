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
			get
			{
				try {
					return teklaObject.HasHoles;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HasHoles", ex); }
			}

		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFaceHole> Holes
		{
			get
			{
				try {
					return teklaObject.Holes;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Holes", ex); }
			}

		}

		public System.Boolean IsReadOnly
		{
			get
			{
				try {
					return teklaObject.IsReadOnly;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadOnly", ex); }
			}

		}

		public System.Collections.Generic.IList<System.Int32> VerticeIndexes
		{
			get
			{
				try {
					return teklaObject.VerticeIndexes;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("VerticeIndexes", ex); }
			}

		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Vector> Vertices
		{
			get
			{
				try {
					return teklaObject.Vertices;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Vertices", ex); }
			}

		}

        

        internal dynamic teklaObject;

		internal FacetedBrepFace() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public FacetedBrepFace(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class FacetedBrepFace_
    {
        public static dynamic GetTSObject(FacetedBrepFace dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static FacetedBrepFace FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFace)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FacetedBrepFaceArray_
    {
        public static dynamic GetTSObject(FacetedBrepFace[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FacetedBrepFace_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FacetedBrepFace[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<FacetedBrepFace>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FacetedBrepFace_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
