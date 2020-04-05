/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ControlCircle  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.Double Extension
		{
			get
			{
				try {
					return teklaObject.Extension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extension"); }
			}
			set
			{
				try {
					teklaObject.Extension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extension"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum Color
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum_.FromTSObject(teklaObject.Color);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
			}
			set
			{
				try {
				teklaObject.Color = Dynamic.Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.ControlObjectLineType LineType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(teklaObject.LineType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType"); }
			}
			set
			{
				try {
				teklaObject.LineType = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point1"); }
			}
			set
			{
				try {
				teklaObject.Point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point1"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point2"); }
			}
			set
			{
				try {
				teklaObject.Point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point2"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point3
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point3);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point3"); }
			}
			set
			{
				try {
				teklaObject.Point3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point3"); }
			}
		}

        

        

		public ControlCircle()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlCircle");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ControlCircle(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ControlCircle(Dynamic.Tekla.Structures.Geometry3d.Point point1, Dynamic.Tekla.Structures.Geometry3d.Point point2, Dynamic.Tekla.Structures.Geometry3d.Point point3)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point2);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point3);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlCircle", args);
		}




    public enum ControlCircleColorEnum
    {
			BLACK,
			WHITE,
			RED,
			GREEN,
			BLUE,
			CYAN,
			YELLOW,
			MAGENTA,
			YELLOW_RED        
    }

    internal static class ControlCircleColorEnum_
    {
        public static dynamic GetTSObject(ControlCircleColorEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum").GetType();

            switch (dynEnum)
            {
				case ControlCircleColorEnum.BLACK:
					return System.Enum.Parse(tsType, "BLACK");
				case ControlCircleColorEnum.WHITE:
					return System.Enum.Parse(tsType, "WHITE");
				case ControlCircleColorEnum.RED:
					return System.Enum.Parse(tsType, "RED");
				case ControlCircleColorEnum.GREEN:
					return System.Enum.Parse(tsType, "GREEN");
				case ControlCircleColorEnum.BLUE:
					return System.Enum.Parse(tsType, "BLUE");
				case ControlCircleColorEnum.CYAN:
					return System.Enum.Parse(tsType, "CYAN");
				case ControlCircleColorEnum.YELLOW:
					return System.Enum.Parse(tsType, "YELLOW");
				case ControlCircleColorEnum.MAGENTA:
					return System.Enum.Parse(tsType, "MAGENTA");
				case ControlCircleColorEnum.YELLOW_RED:
					return System.Enum.Parse(tsType, "YELLOW_RED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ControlCircleColorEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BLACK", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.BLACK;
			else if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.WHITE;
			else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.RED;
			else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.GREEN;
			else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.BLUE;
			else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.CYAN;
			else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.YELLOW;
			else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.MAGENTA;
			else if (tsEnumValue.Equals("YELLOW_RED", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.YELLOW_RED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ControlCircle_
    {
        public static dynamic GetTSObject(ControlCircle dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ControlCircle FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ControlCircle)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ControlCircleArray_
    {
        public static dynamic GetTSObject(ControlCircle[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ControlCircle_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ControlCircle[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ControlCircle>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ControlCircle_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
