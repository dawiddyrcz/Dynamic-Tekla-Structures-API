/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class Matrix 
    {

		public System.Double Item
		{
			get => teklaObject.Item;
			set { teklaObject.Item = value; }
		}

        

        internal dynamic teklaObject;

		public Matrix()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Matrix");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Matrix(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Matrix(Dynamic.Tekla.Structures.Geometry3d.Matrix m)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Matrix_.GetTSObject(m);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Matrix", args);
		}

		public void Transpose()
		{
			teklaObject.Transpose();
		}

		public Dynamic.Tekla.Structures.Geometry3d.Matrix GetTranspose()
		{
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.GetTranspose());
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Matrix op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Matrix B, Dynamic.Tekla.Structures.Geometry3d.Matrix A)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Matrix_.GetTSObject(B);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Matrix_.GetTSObject(A);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Matrix", "op_Multiply", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(result);
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Transform(Dynamic.Tekla.Structures.Geometry3d.Point p)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Transform(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p)));
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Point op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Matrix A, Dynamic.Tekla.Structures.Geometry3d.Point p)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Matrix_.GetTSObject(A);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Matrix", "op_Multiply", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}





    }

    internal static class Matrix_
    {
        public static dynamic GetTSObject(Matrix dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Matrix FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Matrix)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MatrixArray_
    {
        public static dynamic GetTSObject(Matrix[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Matrix_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Matrix[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Matrix>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Matrix_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
