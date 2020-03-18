//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class Matrix 
    {

		public System.Double Item
		{
			get => matrix.Item;
			set { matrix.Item = value; }
		}

        

        internal dynamic matrix;
        
        public Matrix()
        {
            this.matrix =  TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Matrix");
        }

        internal Matrix(dynamic tsObject)
        {
            this.matrix = tsObject;
        }

		public void Transpose()
			 => matrix.Transpose();

		public Dynamic.Tekla.Structures.Geometry3d.Matrix GetTranspose()
			 => Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(matrix.GetTranspose());

		public Dynamic.Tekla.Structures.Geometry3d.Matrix op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Matrix B, Dynamic.Tekla.Structures.Geometry3d.Matrix A)
			 => Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(matrix.op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Matrix_.GetTSObject(B), Dynamic.Tekla.Structures.Geometry3d.Matrix_.GetTSObject(A)));

		public Dynamic.Tekla.Structures.Geometry3d.Point Transform(Dynamic.Tekla.Structures.Geometry3d.Point p)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(matrix.Transform(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p)));

		public Dynamic.Tekla.Structures.Geometry3d.Point op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Matrix A, Dynamic.Tekla.Structures.Geometry3d.Point p)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(matrix.op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Matrix_.GetTSObject(A), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p)));





    }

    internal static class Matrix_
    {
        public static dynamic GetTSObject(Matrix dynObject)
        {
            return dynObject.matrix;
        }

        public static Matrix FromTSObject(dynamic tsObject)
        {
            return new Matrix(tsObject);
        }
    }


}
    