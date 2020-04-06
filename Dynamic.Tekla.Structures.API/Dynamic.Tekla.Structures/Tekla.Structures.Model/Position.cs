/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Position 
    {

		public System.Double PlaneOffset
		{
			get
			{
				try {
					return teklaObject.PlaneOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlaneOffset", ex); }
			}
			set
			{
				try {
					teklaObject.PlaneOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlaneOffset", ex); }
			}
		}

		public System.Double DepthOffset
		{
			get
			{
				try {
					return teklaObject.DepthOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DepthOffset", ex); }
			}
			set
			{
				try {
					teklaObject.DepthOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DepthOffset", ex); }
			}
		}

		public System.Double RotationOffset
		{
			get
			{
				try {
					return teklaObject.RotationOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationOffset", ex); }
			}
			set
			{
				try {
					teklaObject.RotationOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationOffset", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Position.PlaneEnum Plane
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Position.PlaneEnum_.FromTSObject(teklaObject.Plane);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Plane", ex); }
			}
			set
			{
				try {
				teklaObject.Plane = Dynamic.Tekla.Structures.Model.Position.PlaneEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Plane", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Position.DepthEnum Depth
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Position.DepthEnum_.FromTSObject(teklaObject.Depth);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Depth", ex); }
			}
			set
			{
				try {
				teklaObject.Depth = Dynamic.Tekla.Structures.Model.Position.DepthEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Depth", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Position.RotationEnum Rotation
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Position.RotationEnum_.FromTSObject(teklaObject.Rotation);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Rotation", ex); }
			}
			set
			{
				try {
				teklaObject.Rotation = Dynamic.Tekla.Structures.Model.Position.RotationEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Rotation", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public Position()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Position");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Position(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum PlaneEnum
    {
			MIDDLE,
			LEFT,
			RIGHT        
    }

    internal static class PlaneEnum_
    {
        public static dynamic GetTSObject(PlaneEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Position.PlaneEnum").GetType();

            switch (dynEnum)
            {
				case PlaneEnum.MIDDLE:
					return System.Enum.Parse(tsType, "MIDDLE");
				case PlaneEnum.LEFT:
					return System.Enum.Parse(tsType, "LEFT");
				case PlaneEnum.RIGHT:
					return System.Enum.Parse(tsType, "RIGHT");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PlaneEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("MIDDLE", System.StringComparison.InvariantCulture))
				return PlaneEnum.MIDDLE;
			else if (tsEnumValue.Equals("LEFT", System.StringComparison.InvariantCulture))
				return PlaneEnum.LEFT;
			else if (tsEnumValue.Equals("RIGHT", System.StringComparison.InvariantCulture))
				return PlaneEnum.RIGHT;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum DepthEnum
    {
			MIDDLE,
			FRONT,
			BEHIND        
    }

    internal static class DepthEnum_
    {
        public static dynamic GetTSObject(DepthEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Position.DepthEnum").GetType();

            switch (dynEnum)
            {
				case DepthEnum.MIDDLE:
					return System.Enum.Parse(tsType, "MIDDLE");
				case DepthEnum.FRONT:
					return System.Enum.Parse(tsType, "FRONT");
				case DepthEnum.BEHIND:
					return System.Enum.Parse(tsType, "BEHIND");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DepthEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("MIDDLE", System.StringComparison.InvariantCulture))
				return DepthEnum.MIDDLE;
			else if (tsEnumValue.Equals("FRONT", System.StringComparison.InvariantCulture))
				return DepthEnum.FRONT;
			else if (tsEnumValue.Equals("BEHIND", System.StringComparison.InvariantCulture))
				return DepthEnum.BEHIND;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RotationEnum
    {
			FRONT,
			TOP,
			BACK,
			BELOW        
    }

    internal static class RotationEnum_
    {
        public static dynamic GetTSObject(RotationEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Position.RotationEnum").GetType();

            switch (dynEnum)
            {
				case RotationEnum.FRONT:
					return System.Enum.Parse(tsType, "FRONT");
				case RotationEnum.TOP:
					return System.Enum.Parse(tsType, "TOP");
				case RotationEnum.BACK:
					return System.Enum.Parse(tsType, "BACK");
				case RotationEnum.BELOW:
					return System.Enum.Parse(tsType, "BELOW");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RotationEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("FRONT", System.StringComparison.InvariantCulture))
				return RotationEnum.FRONT;
			else if (tsEnumValue.Equals("TOP", System.StringComparison.InvariantCulture))
				return RotationEnum.TOP;
			else if (tsEnumValue.Equals("BACK", System.StringComparison.InvariantCulture))
				return RotationEnum.BACK;
			else if (tsEnumValue.Equals("BELOW", System.StringComparison.InvariantCulture))
				return RotationEnum.BELOW;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Position_
    {
        public static dynamic GetTSObject(Position dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Position FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Position)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PositionArray_
    {
        public static dynamic GetTSObject(Position[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Position_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Position[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Position>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Position_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
