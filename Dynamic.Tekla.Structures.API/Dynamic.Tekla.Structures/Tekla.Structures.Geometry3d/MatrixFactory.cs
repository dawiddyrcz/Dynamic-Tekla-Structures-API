/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class MatrixFactory 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Geometry3d.Matrix Rotate(System.Double Angle, Dynamic.Tekla.Structures.Geometry3d.Vector Axis)
		{
			var parameters = new object[2];
			parameters[0] = Angle;
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Axis);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.MatrixFactory", "Rotate", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Matrix ToCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.MatrixFactory", "ToCoordinateSystem", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Matrix FromCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.MatrixFactory", "FromCoordinateSystem", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Matrix ByCoordinateSystems(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys1, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys2);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.MatrixFactory", "ByCoordinateSystems", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(result);
		}





    }

    internal static class MatrixFactory_
    {
        public static dynamic GetTSObject(MatrixFactory dynObject)
        {
            return dynObject.teklaObject;
        }

        public static MatrixFactory FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.MatrixFactory)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
