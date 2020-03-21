//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class GeometricPlane 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
			set { teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Normal
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Normal);
			set { teklaObject.Normal = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public GeometricPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane");
		}
		public GeometricPlane(Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Vector Normal)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Normal);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane", args);
		}
		public GeometricPlane(Dynamic.Tekla.Structures.Geometry3d.Point Origin, Dynamic.Tekla.Structures.Geometry3d.Vector Xaxis, Dynamic.Tekla.Structures.Geometry3d.Vector Yaxis)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origin);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Xaxis);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Yaxis);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane", args);
		}
		public GeometricPlane(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordSys)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordSys);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane", args);
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector GetNormal()
			 => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.GetNormal());





    }

    internal static class GeometricPlane_
    {
        public static dynamic GetTSObject(GeometricPlane dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GeometricPlane FromTSObject(dynamic tsObject)
        {
            return new GeometricPlane() { teklaObject = tsObject };
        }
    }


}
    
