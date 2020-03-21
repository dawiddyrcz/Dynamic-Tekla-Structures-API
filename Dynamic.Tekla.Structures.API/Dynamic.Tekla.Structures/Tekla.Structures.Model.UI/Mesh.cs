//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class Mesh 
    {

		public System.Collections.ArrayList Points
		{
			get => mesh.Points;
			set { mesh.Points = value; }
		}

		public System.Collections.ArrayList Triangles
		{
			get => mesh.Triangles;
			set { mesh.Triangles = value; }
		}

		public System.Collections.ArrayList Lines
		{
			get => mesh.Lines;
			set { mesh.Lines = value; }
		}

        

        internal dynamic mesh;
        
        public Mesh()
        {
            this.mesh =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.Mesh");
        }

        internal Mesh(dynamic tsObject)
        {
            this.mesh = tsObject;
        }
		public Mesh(System.Collections.ArrayList Points, System.Collections.ArrayList Triangles, System.Collections.ArrayList Lines)
		{
			var args = new object[3];
			args[0] = Points;
			args[1] = Triangles;
			args[2] = Lines;
			this.mesh = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Mesh", args);
		}

		public System.Int32 AddPoint(Dynamic.Tekla.Structures.Geometry3d.Point Point)
			 => mesh.AddPoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point));

		public void AddTriangle(System.Int32 Index1, System.Int32 Index2, System.Int32 Index3)
			 => mesh.AddTriangle(Index1, Index2, Index3);

		public void AddLine(System.Int32 Index1, System.Int32 Index2)
			 => mesh.AddLine(Index1, Index2);





    }

    internal static class Mesh_
    {
        public static dynamic GetTSObject(Mesh dynObject)
        {
            return dynObject.mesh;
        }

        public static Mesh FromTSObject(dynamic tsObject)
        {
            return new Mesh(tsObject);
        }
    }


}
    
