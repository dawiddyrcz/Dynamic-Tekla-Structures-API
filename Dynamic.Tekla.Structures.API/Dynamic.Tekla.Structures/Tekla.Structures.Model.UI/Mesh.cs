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
			set { teklaObject.Points = value; }
		}

		public System.Collections.ArrayList Triangles
		{
			get => teklaObject.Triangles;
			set { teklaObject.Triangles = value; }
		}

		public System.Collections.ArrayList Lines
		{
			get => teklaObject.Lines;
			set { teklaObject.Lines = value; }
		}

        

        internal dynamic teklaObject;

		public Mesh()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Mesh");
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
            return dynObject.teklaObject;
        }

        public static Mesh FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.UI.Mesh)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
