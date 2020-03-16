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

        

        dynamic basepoint;
        
        public BasePoint()
        {
            this.basepoint =  new Tekla.Structures.Model.BasePoint();
        }

        public BasePoint(dynamic tsObject)
        {
            this.basepoint = tsObject;
			this.Id = basepoint.Id;
			this.Guid = basepoint.Guid;
			this.InitialGuid = basepoint.InitialGuid;
			this.Name = basepoint.Name;
			this.Description = basepoint.Description;
			this.CoordinateSystem = basepoint.CoordinateSystem;
			this.NorthSouth = basepoint.NorthSouth;
			this.EastWest = basepoint.EastWest;
			this.Elevation = basepoint.Elevation;
			this.Latitude = basepoint.Latitude;
			this.Longitude = basepoint.Longitude;
			this.LocationInModelX = basepoint.LocationInModelX;
			this.LocationInModelY = basepoint.LocationInModelY;
			this.LocationInModelZ = basepoint.LocationInModelZ;
			this.AngleToNorth = basepoint.AngleToNorth;
			this.IsProjectBasePoint = basepoint.IsProjectBasePoint;
			this.IsCurrentBasePoint = basepoint.IsCurrentBasePoint;
			this.IsScopedCurrentBasePoint = basepoint.IsScopedCurrentBasePoint;

        }


        public dynamic GetTSObject() => basepoint;

		public System.Boolean Insert()
			 => basepoint.Insert();

		public System.Boolean Modify()
			 => basepoint.Modify();

		public System.Boolean Delete()
			 => basepoint.Delete();

		public System.IDisposable SetAsCurrent()
			 => basepoint.SetAsCurrent();

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem(Dynamic.Tekla.Structures.Model.BasePoint.CoordinateSystemType CoordsysType)
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(basepoint.GetCoordinateSystem(CoordsysType.GetTSObject()));

		public System.TupleSystem.Boolean<System.Boolean, System.Int32, System.Int32, System.Int32> GetCompoundPlaneAngleLatitude()
			 => basepoint.GetCompoundPlaneAngleLatitude();

		public System.TupleSystem.Boolean<System.Boolean, System.Int32, System.Int32, System.Int32> GetCompoundPlaneAngleLongitude()
			 => basepoint.GetCompoundPlaneAngleLongitude();

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point point)
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(basepoint.ConvertToBasePoint(point.GetTSObject()));

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point point)
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(basepoint.ConvertFromBasePoint(point.GetTSObject()));

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(Dynamic.Tekla.Structures.Model.BasePoint basePoint, Dynamic.Tekla.Structures.Geometry3d.Point point)
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(basepoint.ConvertToBasePoint(basePoint.GetTSObject(), point.GetTSObject()));

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(Dynamic.Tekla.Structures.Model.BasePoint basePoint, Dynamic.Tekla.Structures.Geometry3d.Point point)
			 => new Dynamic.Tekla.Structures.Geometry3d.Point(basepoint.ConvertFromBasePoint(basePoint.GetTSObject(), point.GetTSObject()));

		public System.Boolean Equals(System.Object obj)
			 => basepoint.Equals(obj);

		public System.Int32 GetHashCode()
			 => basepoint.GetHashCode();

		public System.Type GetType()
			 => basepoint.GetType();

		public System.String ToString()
			 => basepoint.ToString();




    public enum CoordinateSystemType
    {
			GLOBAL,
			WORKPLANE        
    }

    public static class CoordinateSystemType_
    {
        public static dynamic GetTSObject(CoordinateSystemType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.CoordinateSystemType");

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

}
    
