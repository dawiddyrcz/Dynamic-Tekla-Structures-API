/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class BasePoint 
    {

		public System.Int32 Id
		{
			get => teklaObject.Id;
			set { teklaObject.Id = value; }
		}

		public System.Guid Guid
		{
			get => teklaObject.Guid;
			set { teklaObject.Guid = value; }
		}

		public System.String InitialGuid
		{
			get => teklaObject.InitialGuid;
			set { teklaObject.InitialGuid = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String Description
		{
			get => teklaObject.Description;
			set { teklaObject.Description = value; }
		}

		public System.String CoordinateSystem
		{
			get => teklaObject.CoordinateSystem;
			set { teklaObject.CoordinateSystem = value; }
		}

		public System.Double NorthSouth
		{
			get => teklaObject.NorthSouth;
			set { teklaObject.NorthSouth = value; }
		}

		public System.Double EastWest
		{
			get => teklaObject.EastWest;
			set { teklaObject.EastWest = value; }
		}

		public System.Double Elevation
		{
			get => teklaObject.Elevation;
			set { teklaObject.Elevation = value; }
		}

		public System.Double Latitude
		{
			get => teklaObject.Latitude;
			set { teklaObject.Latitude = value; }
		}

		public System.Double Longitude
		{
			get => teklaObject.Longitude;
			set { teklaObject.Longitude = value; }
		}

		public System.Double LocationInModelX
		{
			get => teklaObject.LocationInModelX;
			set { teklaObject.LocationInModelX = value; }
		}

		public System.Double LocationInModelY
		{
			get => teklaObject.LocationInModelY;
			set { teklaObject.LocationInModelY = value; }
		}

		public System.Double LocationInModelZ
		{
			get => teklaObject.LocationInModelZ;
			set { teklaObject.LocationInModelZ = value; }
		}

		public System.Double AngleToNorth
		{
			get => teklaObject.AngleToNorth;
			set { teklaObject.AngleToNorth = value; }
		}

		public System.Boolean IsProjectBasePoint
		{
			get => teklaObject.IsProjectBasePoint;
			set { teklaObject.IsProjectBasePoint = value; }
		}

		public System.Boolean IsCurrentBasePoint
		{
			get => teklaObject.IsCurrentBasePoint;
			set { teklaObject.IsCurrentBasePoint = value; }
		}

		public System.Boolean IsScopedCurrentBasePoint
		{
			get => teklaObject.IsScopedCurrentBasePoint;
			set { teklaObject.IsScopedCurrentBasePoint = value; }
		}

        

        internal dynamic teklaObject;

		internal BasePoint() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BasePoint(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public BasePoint(System.String name)
		{
			var args = new object[1];
			args[0] = name;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BasePoint", args);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BasePoint", args);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem(Dynamic.Tekla.Structures.Model.BasePoint.CoordinateSystemType CoordsysType)
		{
			return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.GetCoordinateSystem(Dynamic.Tekla.Structures.Model.BasePoint.CoordinateSystemType_.GetTSObject(CoordsysType)));
		}

		public System.Tuple<System.Boolean, System.Int32, System.Int32, System.Int32> GetCompoundPlaneAngleLatitude()
		{
			return teklaObject.GetCompoundPlaneAngleLatitude();
		}

		public System.Tuple<System.Boolean, System.Int32, System.Int32, System.Int32> GetCompoundPlaneAngleLongitude()
		{
			return teklaObject.GetCompoundPlaneAngleLongitude();
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point point)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ConvertToBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point point)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ConvertFromBasePoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point)));
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(Dynamic.Tekla.Structures.Model.BasePoint basePoint, Dynamic.Tekla.Structures.Geometry3d.Point point)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.BasePoint", "ConvertToBasePoint", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(Dynamic.Tekla.Structures.Model.BasePoint basePoint, Dynamic.Tekla.Structures.Geometry3d.Point point)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.BasePoint", "ConvertFromBasePoint", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}




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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static BasePoint FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BasePoint)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BasePointArray_
    {
        public static dynamic GetTSObject(BasePoint[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BasePoint_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BasePoint[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<BasePoint>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BasePoint_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
