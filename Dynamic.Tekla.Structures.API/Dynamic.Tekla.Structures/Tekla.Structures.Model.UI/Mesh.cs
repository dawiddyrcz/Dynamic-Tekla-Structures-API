/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class Mesh 
    {

		public System.Collections.ArrayList Points
		{
			get => teklaObject.Points;

		}

		public System.Collections.ArrayList Triangles
		{
			get => teklaObject.Triangles;

		}

		public System.Collections.ArrayList Lines
		{
			get => teklaObject.Lines;

		}

        

        internal dynamic teklaObject;

		public Mesh()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Mesh");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Mesh(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Mesh(System.Collections.ArrayList Points, System.Collections.ArrayList Triangles, System.Collections.ArrayList Lines)
		{
			var args = new object[3];
			args[0] = Points;
			args[1] = Triangles;
			args[2] = Lines;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Mesh", args);
		}

		public System.Int32 AddPoint(Dynamic.Tekla.Structures.Geometry3d.Point Point)
		{
			return teklaObject.AddPoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point));
		}

		public void AddTriangle(System.Int32 Index1, System.Int32 Index2, System.Int32 Index3)
		{
			teklaObject.AddTriangle(Index1, Index2, Index3);
		}

		public void AddLine(System.Int32 Index1, System.Int32 Index2)
		{
			teklaObject.AddLine(Index1, Index2);
		}





    }

    internal static class Mesh_
    {
        public static dynamic GetTSObject(Mesh dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Mesh FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.Mesh)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MeshArray_
    {
        public static dynamic GetTSObject(Mesh[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Mesh_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Mesh[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Mesh>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Mesh_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
