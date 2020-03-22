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


		public Dynamic.Tekla.Structures.Geometry3d.Matrix Rotate(System.Double Angle, Dynamic.Tekla.Structures.Geometry3d.Vector Axis)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.Rotate(Angle, Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Axis)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Matrix ToCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.ToCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Matrix FromCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.FromCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Matrix ByCoordinateSystems(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys1, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys2)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.ByCoordinateSystems(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys1), Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys2)));
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
    
