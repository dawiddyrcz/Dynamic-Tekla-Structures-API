/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class CoordinateSystem 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
			set { teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector AxisX
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.AxisX);
			set { teklaObject.AxisX = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector AxisY
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.AxisY);
			set { teklaObject.AxisY = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public CoordinateSystem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.CoordinateSystem");
		}
		public CoordinateSystem(Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Vector AxisX, Dynamic.Tekla.Structures.Geometry3d.Vector AxisY)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(AxisX);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(AxisY);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.CoordinateSystem", args);
		}





    }

    internal static class CoordinateSystem_
    {
        public static dynamic GetTSObject(CoordinateSystem dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CoordinateSystem FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.CoordinateSystem)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
