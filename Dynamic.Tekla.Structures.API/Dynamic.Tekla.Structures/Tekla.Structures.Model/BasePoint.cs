/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model
{

    public  class BasePoint 
    {


        public System.Int32 Id
        {
            get
            {
                try
                {
                return teklaObject.Id;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Id), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Id = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Id), ex); 
                }
            }
        }

        public System.Guid Guid
        {
            get
            {
                try
                {
                return teklaObject.Guid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Guid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guid), ex); 
                }
            }
        }

        public System.String InitialGuid
        {
            get
            {
                try
                {
                return teklaObject.InitialGuid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InitialGuid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.InitialGuid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InitialGuid), ex); 
                }
            }
        }

        public System.String Name
        {
            get
            {
                try
                {
                return teklaObject.Name;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Name = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
        }

        public System.String Description
        {
            get
            {
                try
                {
                return teklaObject.Description;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Description), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Description = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Description), ex); 
                }
            }
        }

        public System.String CoordinateSystem
        {
            get
            {
                try
                {
                return teklaObject.CoordinateSystem;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateSystem), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.CoordinateSystem = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateSystem), ex); 
                }
            }
        }

        public System.Double NorthSouth
        {
            get
            {
                try
                {
                return teklaObject.NorthSouth;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NorthSouth), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.NorthSouth = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NorthSouth), ex); 
                }
            }
        }

        public System.Double EastWest
        {
            get
            {
                try
                {
                return teklaObject.EastWest;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EastWest), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.EastWest = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EastWest), ex); 
                }
            }
        }

        public System.Double Elevation
        {
            get
            {
                try
                {
                return teklaObject.Elevation;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Elevation), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Elevation = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Elevation), ex); 
                }
            }
        }

        public System.Double Latitude
        {
            get
            {
                try
                {
                return teklaObject.Latitude;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Latitude), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Latitude = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Latitude), ex); 
                }
            }
        }

        public System.Double Longitude
        {
            get
            {
                try
                {
                return teklaObject.Longitude;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Longitude), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Longitude = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Longitude), ex); 
                }
            }
        }

        public System.Double LocationInModelX
        {
            get
            {
                try
                {
                return teklaObject.LocationInModelX;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelX), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LocationInModelX = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelX), ex); 
                }
            }
        }

        public System.Double LocationInModelY
        {
            get
            {
                try
                {
                return teklaObject.LocationInModelY;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelY), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LocationInModelY = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelY), ex); 
                }
            }
        }

        public System.Double LocationInModelZ
        {
            get
            {
                try
                {
                return teklaObject.LocationInModelZ;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelZ), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LocationInModelZ = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationInModelZ), ex); 
                }
            }
        }

        public System.Double AngleToNorth
        {
            get
            {
                try
                {
                return teklaObject.AngleToNorth;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngleToNorth), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.AngleToNorth = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AngleToNorth), ex); 
                }
            }
        }

        public System.Boolean IsProjectBasePoint
        {
            get
            {
                try
                {
                return teklaObject.IsProjectBasePoint;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsProjectBasePoint), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IsProjectBasePoint = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsProjectBasePoint), ex); 
                }
            }
        }

        public System.Boolean IsCurrentBasePoint
        {
            get
            {
                try
                {
                return teklaObject.IsCurrentBasePoint;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsCurrentBasePoint), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IsCurrentBasePoint = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsCurrentBasePoint), ex); 
                }
            }
        }

        public System.Boolean IsScopedCurrentBasePoint
        {
            get
            {
                try
                {
                return teklaObject.IsScopedCurrentBasePoint;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsScopedCurrentBasePoint), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IsScopedCurrentBasePoint = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsScopedCurrentBasePoint), ex); 
                }
            }
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
            
            try
            {
                var result = (System.Boolean) teklaObject.Insert();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
            }
        }



        public System.Boolean Modify()
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.Modify();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
            }
        }



        public System.Boolean Delete()
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.Delete();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Delete), ex);
            }
        }



        public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem(
			Dynamic.Tekla.Structures.Model.BasePoint.CoordinateSystemType CoordsysType_)
        {
            var CoordsysType = Dynamic.Tekla.Structures.Model.BasePoint.CoordinateSystemType_.GetTSObject(CoordsysType_);
            try
            {
                var result = teklaObject.GetCoordinateSystem(CoordsysType);
            
                var _result = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCoordinateSystem), ex);
            }
        }



        public System.Tuple<System.Boolean, System.Int32, System.Int32, System.Int32> GetCompoundPlaneAngleLatitude()
        {
            
            try
            {
                var result = (System.Tuple<System.Boolean, System.Int32, System.Int32, System.Int32>) teklaObject.GetCompoundPlaneAngleLatitude();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCompoundPlaneAngleLatitude), ex);
            }
        }



        public System.Tuple<System.Boolean, System.Int32, System.Int32, System.Int32> GetCompoundPlaneAngleLongitude()
        {
            
            try
            {
                var result = (System.Tuple<System.Boolean, System.Int32, System.Int32, System.Int32>) teklaObject.GetCompoundPlaneAngleLongitude();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCompoundPlaneAngleLongitude), ex);
            }
        }



        public Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(
			Dynamic.Tekla.Structures.Geometry3d.Point point_)
        {
            var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
            try
            {
                var result = teklaObject.ConvertToBasePoint(point);
            
                var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ConvertToBasePoint), ex);
            }
        }



        public Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(
			Dynamic.Tekla.Structures.Geometry3d.Point point_)
        {
            var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
            try
            {
                var result = teklaObject.ConvertFromBasePoint(point);
            
                var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ConvertFromBasePoint), ex);
            }
        }



        public static Dynamic.Tekla.Structures.Geometry3d.Point ConvertToBasePoint(
			Dynamic.Tekla.Structures.Model.BasePoint basePoint_,
			Dynamic.Tekla.Structures.Geometry3d.Point point_)
        {
            var basePoint = Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint_);
var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.BasePoint", "ConvertToBasePoint", basePoint, point);
            var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Geometry3d.Point ConvertFromBasePoint(
			Dynamic.Tekla.Structures.Model.BasePoint basePoint_,
			Dynamic.Tekla.Structures.Geometry3d.Point point_)
        {
            var basePoint = Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint_);
var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.BasePoint", "ConvertFromBasePoint", basePoint, point);
            var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
				return _result;
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BasePoint_
    {
        public static dynamic GetTSObject(BasePoint dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BasePoint FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BasePoint_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BasePoint[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BasePoint>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BasePoint_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
