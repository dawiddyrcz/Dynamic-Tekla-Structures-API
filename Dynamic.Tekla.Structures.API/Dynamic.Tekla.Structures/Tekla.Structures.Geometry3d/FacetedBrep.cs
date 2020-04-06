/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class FacetedBrep 
    {

		public System.Collections.Generic.ICollection<Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFace> Faces
		{
			get
			{
				try {
					return teklaObject.Faces;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Faces", ex); }
			}

		}

		public System.Collections.Generic.IDictionary<System.Int32, System.Int32[][]> InnerWires
		{
			get
			{
				try {
					return teklaObject.InnerWires;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InnerWires", ex); }
			}

		}

		public System.Int32[][] OuterWires
		{
			get
			{
				try {
					return teklaObject.OuterWires;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OuterWires", ex); }
			}

		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge> GetEdges
		{
			get
			{
				try {
					return teklaObject.GetEdges;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GetEdges", ex); }
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

		internal FacetedBrep() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public FacetedBrep(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public FacetedBrep(Dynamic.Tekla.Structures.Geometry3d.Vector[] vertices, System.Int32[][] outerWires, System.Collections.Generic.IDictionary<System.Int32, System.Int32[][]> innerWires)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(vertices);
			args[1] = outerWires;
			args[2] = innerWires;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.FacetedBrep", args);
		}
		public FacetedBrep(Dynamic.Tekla.Structures.Geometry3d.Vector[] vertices, System.Int32[][] outerWires, System.Collections.Generic.IDictionary<System.Int32, System.Int32[][]> innerWires, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge> edges)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(vertices);
			args[1] = outerWires;
			args[2] = innerWires;
			args[3] = edges;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.FacetedBrep", args);
		}

		public System.Boolean CheckForTwoManifold()
		{
			try {
			var result = teklaObject.CheckForTwoManifold();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CheckForTwoManifold()", ex); }
		}

		public System.Int32[] GetInnerFace(System.Int32 faceIndex)
		{
			try {
			var result = teklaObject.GetInnerFace(faceIndex);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetInnerFace()", ex); }
		}

		public System.Int32 GetInnerFaceCount(System.Int32 faceIndex)
		{
			try {
			var result = teklaObject.GetInnerFaceCount(faceIndex);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetInnerFaceCount()", ex); }
		}

		public System.Int32[] GetOuterFace(System.Int32 faceIndex)
		{
			try {
			var result = teklaObject.GetOuterFace(faceIndex);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetOuterFace()", ex); }
		}





    }

    internal static class FacetedBrep_
    {
        public static dynamic GetTSObject(FacetedBrep dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static FacetedBrep FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.FacetedBrep)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FacetedBrepArray_
    {
        public static dynamic GetTSObject(FacetedBrep[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FacetedBrep_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FacetedBrep[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<FacetedBrep>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FacetedBrep_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
