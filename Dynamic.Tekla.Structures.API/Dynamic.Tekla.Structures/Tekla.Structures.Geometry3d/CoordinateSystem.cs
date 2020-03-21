//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class CoordinateSystem 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(coordinatesystem.Origin);
			set { coordinatesystem.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector AxisX
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(coordinatesystem.AxisX);
			set { coordinatesystem.AxisX = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector AxisY
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(coordinatesystem.AxisY);
			set { coordinatesystem.AxisY = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

        

        internal dynamic coordinatesystem;
        
        public CoordinateSystem()
        {
            this.coordinatesystem =  TSActivator.CreateInstance("Tekla.Structures.Geometry3d.CoordinateSystem");
        }

        internal CoordinateSystem(dynamic tsObject)
        {
            this.coordinatesystem = tsObject;
        }
		public CoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Vector AxisX, Dynamic.Tekla.Structures.Geometry3d.Vector AxisY)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(AxisX);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(AxisY);
			this.coordinatesystem = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.CoordinateSystem", args);
		}





    }

    internal static class CoordinateSystem_
    {
        public static dynamic GetTSObject(CoordinateSystem dynObject)
        {
            return dynObject.coordinatesystem;
        }

        public static CoordinateSystem FromTSObject(dynamic tsObject)
        {
            return new CoordinateSystem(tsObject);
        }
    }


}
    
