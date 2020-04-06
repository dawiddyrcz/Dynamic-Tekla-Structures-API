/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class FacetedBrepWithNormals  : Dynamic.Tekla.Structures.Geometry3d.FacetedBrep
    {

		public Dynamic.Tekla.Structures.Geometry3d.Vector[] Normals
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.VectorArray_.FromTSObject(teklaObject.Normals);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Normals", ex); }
			}
			set
			{
				try {
				teklaObject.Normals = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Normals", ex); }
			}
		}

        

        

		internal FacetedBrepWithNormals() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public FacetedBrepWithNormals(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public FacetedBrepWithNormals(Dynamic.Tekla.Structures.Geometry3d.Vector[] vertices, System.Int32[][] outerWires, System.Collections.Generic.IDictionary<System.Int32, System.Int32[][]> innerWires, Dynamic.Tekla.Structures.Geometry3d.Vector[] normals)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(vertices);
			args[1] = outerWires;
			args[2] = innerWires;
			args[3] = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(normals);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.FacetedBrepWithNormals", args);
		}





    }

    internal static class FacetedBrepWithNormals_
    {
        public static dynamic GetTSObject(FacetedBrepWithNormals dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static FacetedBrepWithNormals FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.FacetedBrepWithNormals)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FacetedBrepWithNormalsArray_
    {
        public static dynamic GetTSObject(FacetedBrepWithNormals[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FacetedBrepWithNormals_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FacetedBrepWithNormals[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<FacetedBrepWithNormals>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FacetedBrepWithNormals_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
