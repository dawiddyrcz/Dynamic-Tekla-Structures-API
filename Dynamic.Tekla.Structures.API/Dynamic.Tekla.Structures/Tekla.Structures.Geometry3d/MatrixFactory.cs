//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class MatrixFactory 
    {

        

        internal dynamic teklaObject;

		internal MatrixFactory() {}

		public Dynamic.Tekla.Structures.Geometry3d.Matrix Rotate(System.Double Angle, Dynamic.Tekla.Structures.Geometry3d.Vector Axis)
			 => Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.Rotate(Angle, Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Axis)));

		public Dynamic.Tekla.Structures.Geometry3d.Matrix ToCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys)
			 => Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.ToCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys)));

		public Dynamic.Tekla.Structures.Geometry3d.Matrix FromCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys)
			 => Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.FromCoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys)));

		public Dynamic.Tekla.Structures.Geometry3d.Matrix ByCoordinateSystems(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys1, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys2)
			 => Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(teklaObject.ByCoordinateSystems(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys1), Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys2)));





    }

    internal static class MatrixFactory_
    {
        public static dynamic GetTSObject(MatrixFactory dynObject)
        {
            return dynObject.teklaObject;
        }

        public static MatrixFactory FromTSObject(dynamic tsObject)
        {
            return new MatrixFactory() { teklaObject = tsObject };
        }
    }


}
    
