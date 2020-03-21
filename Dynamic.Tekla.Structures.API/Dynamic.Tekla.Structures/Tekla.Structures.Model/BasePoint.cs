//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class BasePoint 
    {

		public System.Int32 Id
		{
			get => basepoint.Id;
			set { basepoint.Id = value; }
		}

		public System.Guid Guid
		{
			get => basepoint.Guid;
			set { basepoint.Guid = value; }
		}

		public System.String InitialGuid
		{
			get => basepoint.InitialGuid;
			set { basepoint.InitialGuid = value; }
		}

		public System.String Name
		{
			get => basepoint.Name;
			set { basepoint.Name = value; }
		}

		public System.String Description
		{
			get => basepoint.Description;
			set { basepoint.Description = value; }
		}

		public System.String CoordinateSystem
		{
			get => basepoint.CoordinateSystem;
			set { basepoint.CoordinateSystem = value; }
		}

		public System.Double NorthSouth
		{
			get => basepoint.NorthSouth;
			set { basepoint.NorthSouth = value; }
		}

		public System.Double EastWest
		{
			get => basepoint.EastWest;
			set { basepoint.EastWest = value; }
		}

		public System.Double Elevation
		{
			get => basepoint.Elevation;
			set { basepoint.Elevation = value; }
		}

		public System.Double Latitude
		{
			get => basepoint.Latitude;
			set { basepoint.Latitude = value; }
		}

		public System.Double Longitude
		{
			get => basepoint.Longitude;
			set { basepoint.Longitude = value; }
		}

		public System.Double LocationInModelX
		{
			get => basepoint.LocationInModelX;
			set { basepoint.LocationInModelX = value; }
		}

		public System.Double LocationInModelY
		{
			get => basepoint.LocationInModelY;
			set { basepoint.LocationInModelY = value; }
		}

		public System.Double LocationInModelZ
		{
			get => basepoint.LocationInModelZ;
			set { basepoint.LocationInModelZ = value; }
		}

		public System.Double AngleToNorth
		{
			get => basepoint.AngleToNorth;
			set { basepoint.AngleToNorth = value; }
		}

		public System.Boolean IsProjectBasePoint
		{
			get => basepoint.IsProjectBasePoint;
			set { basepoint.IsProjectBasePoint = value; }
		}

		public System.Boolean IsCurrentBasePoint
		{
			get => basepoint.IsCurrentBasePoint;
			set { basepoint.IsCurrentBasePoint = value; }
		}

		public System.Boolean IsScopedCurrentBasePoint
		{
			get => basepoint.IsScopedCurrentBasePoint;
			set { basepoint.IsScopedCurrentBasePoint = value; }
		}

        

        internal dynamic basepoint;
        
        public BasePoint()
        {
            this.basepoint =  TSActivator.CreateInstance("Tekla.Structures.Model.BasePoint");
        }

        internal BasePoint(dynamic tsObject)
        {
            this.basepoint = tsObject;
        }
		public BasePoint(System.String name)
		{
			var args = new object[1];
			args[0] = name;
			this.basepoint = TSActivator.CreateInstance("Tekla.Structures.Model.BasePoint", args);
		}
		public BasePoint(System.Int32 id, System.Guid guid, System.String initialGuid, System.String name, System.String description, System.String coordinateSystem, System.Double northSouth, System.Double eastWest, System.Double elevation, System.Double latitude, System.Double longitude, System.Double locationInModelX, System.Double locationInModelY, System.Double locationInModelZ, System.Double angleToNorth, System.Boolean isProjectBasePoint, System.Boolean isCurrentBasePoint)
		{
			var args = new object[17];
			args[0] = id;
			args[1] = guid;
			args[2] = initialGuid;
			args[3] = name;
			args[4] = description;
			args[5] = coordinateSystem;
			args[6] = northSouth;
			args[7] = eastWest;
			args[8] = elevation;
			args[9] = latitude;
			args[10] = longitude;
			args[11] = locationInModelX;
			args[12] = locationInModelY;
			args[13] = locationInModelZ;
			args[14] = angleToNorth;
			args[15] = isProjectBasePoint;
			args[16] = isCurrentBasePoint;
			this.basepoint = TSActivator.CreateInstance("Tekla.Structures.Model.BasePoint", args);
		}

		public System.Boolean Insert()
			 => basepoint.Insert();

		public System.Boolean Modify()
			 => basepoint.Modify();

		public System.Boolean Delete()
			 => basepoint.Delete();

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem(Dynamic.Tekla.Structures.Model.BasePoint.CoordinateSystemType CoordsysType)
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(basepoint.GetCoordinateSystem(Dynamic.Tekla.Structures.Model.BasePoint.CoordinateSystemType_.GetTSObject(CoordsysType)));

		public System.Tuple<System.Boolean, System.Int32, System.Int32, System.Int32> GetCompoundPlaneAngleLatitude()
			 => basepoint.GetCompoundPlaneAngleLatitude();

		public System.Tuple<System.Boolean, System.Int32, System.Int32, System.Int32> GetCompoundPlaneAngleLongitude()
			 => basepoint.GetCompoundPlaneAngleLongitude();

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point point)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(basepoint.ConvertToBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point)));

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point point)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(basepoint.ConvertFromBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point)));

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(Dynamic.Tekla.Structures.Model.BasePoint basePoint, Dynamic.Tekla.Structures.Geometry3d.Point point)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(basepoint.ConvertToBasePoint(Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point)));

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(Dynamic.Tekla.Structures.Model.BasePoint basePoint, Dynamic.Tekla.Structures.Geometry3d.Point point)
			 => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(basepoint.ConvertFromBasePoint(Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point)));




    public enum CoordinateSystemType
    {
			GLOBAL,
			WORKPLANE        
    }

    internal static class CoordinateSystemType_
    {
        public static dynamic GetTSObject(CoordinateSystemType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BasePoint.CoordinateSystemType").GetType();

            switch (dynEnum)
            {
				case CoordinateSystemType.GLOBAL:
					return System.Enum.Parse(tsType, "GLOBAL");
				case CoordinateSystemType.WORKPLANE:
					return System.Enum.Parse(tsType, "WORKPLANE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CoordinateSystemType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("GLOBAL", System.StringComparison.InvariantCulture))
				return CoordinateSystemType.GLOBAL;
			else if (tsEnumValue.Equals("WORKPLANE", System.StringComparison.InvariantCulture))
				return CoordinateSystemType.WORKPLANE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BasePoint_
    {
        public static dynamic GetTSObject(BasePoint dynObject)
        {
            return dynObject.basepoint;
        }

        public static BasePoint FromTSObject(dynamic tsObject)
        {
            return new BasePoint(tsObject);
        }
    }


}
    
