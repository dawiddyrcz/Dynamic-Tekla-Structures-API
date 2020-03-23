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
			get => teklaObject.Faces;

		}

		public System.Collections.Generic.IDictionary<System.Int32, System.Int32[][]> InnerWires
		{
			get => teklaObject.InnerWires;

		}

		public System.Int32[][] OuterWires
		{
			get => teklaObject.OuterWires;

		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge> GetEdges
		{
			get => teklaObject.GetEdges;

		}

		public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Vector> Vertices
		{
			get => teklaObject.Vertices;

		}

        

        internal dynamic teklaObject;

		public FacetedBrep() {}
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
			return teklaObject.CheckForTwoManifold();
		}

		public System.Int32[] GetInnerFace(System.Int32 faceIndex)
		{
			return teklaObject.GetInnerFace(faceIndex);
		}

		public System.Int32 GetInnerFaceCount(System.Int32 faceIndex)
		{
			return teklaObject.GetInnerFaceCount(faceIndex);
		}

		public System.Int32[] GetOuterFace(System.Int32 faceIndex)
		{
			return teklaObject.GetOuterFace(faceIndex);
		}





    }

    internal static class FacetedBrep_
    {
        public static dynamic GetTSObject(FacetedBrep dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FacetedBrep FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FacetedBrep_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FacetedBrep[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<FacetedBrep>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FacetedBrep_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
