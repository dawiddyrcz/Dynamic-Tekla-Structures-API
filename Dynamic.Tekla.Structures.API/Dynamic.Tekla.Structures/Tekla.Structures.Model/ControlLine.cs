/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ControlLine  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment Line
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.Line);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Line", ex); }
			}
			set
			{
				try {
				teklaObject.Line = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Line", ex); }
			}
		}

		public System.Boolean IsMagnetic
		{
			get
			{
				try {
					return teklaObject.IsMagnetic;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMagnetic", ex); }
			}
			set
			{
				try {
					teklaObject.IsMagnetic = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMagnetic", ex); }
			}
		}

		public System.Double Extension
		{
			get
			{
				try {
					return teklaObject.Extension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extension", ex); }
			}
			set
			{
				try {
					teklaObject.Extension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extension", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.ControlLine.ControlLineColorEnum Color
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ControlLine.ControlLineColorEnum_.FromTSObject(teklaObject.Color);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
			set
			{
				try {
				teklaObject.Color = Dynamic.Tekla.Structures.Model.ControlLine.ControlLineColorEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.ControlObjectLineType LineType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(teklaObject.LineType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType", ex); }
			}
			set
			{
				try {
				teklaObject.LineType = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType", ex); }
			}
		}

        

        

		public ControlLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ControlLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ControlLine(Dynamic.Tekla.Structures.Geometry3d.LineSegment Line, System.Boolean IsMagnetic)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(Line);
			args[1] = IsMagnetic;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine", args);
		}




    public enum ControlLineColorEnum
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

    internal static class ControlLineColorEnum_
    {
        public static dynamic GetTSObject(ControlLineColorEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine.ControlLineColorEnum").GetType();

            switch (dynEnum)
            {
				case ControlLineColorEnum.BLACK:
					return System.Enum.Parse(tsType, "BLACK");
				case ControlLineColorEnum.WHITE:
					return System.Enum.Parse(tsType, "WHITE");
				case ControlLineColorEnum.RED:
					return System.Enum.Parse(tsType, "RED");
				case ControlLineColorEnum.GREEN:
					return System.Enum.Parse(tsType, "GREEN");
				case ControlLineColorEnum.BLUE:
					return System.Enum.Parse(tsType, "BLUE");
				case ControlLineColorEnum.CYAN:
					return System.Enum.Parse(tsType, "CYAN");
				case ControlLineColorEnum.YELLOW:
					return System.Enum.Parse(tsType, "YELLOW");
				case ControlLineColorEnum.MAGENTA:
					return System.Enum.Parse(tsType, "MAGENTA");
				case ControlLineColorEnum.YELLOW_RED:
					return System.Enum.Parse(tsType, "YELLOW_RED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ControlLineColorEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BLACK", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.BLACK;
			else if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.WHITE;
			else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.RED;
			else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.GREEN;
			else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.BLUE;
			else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.CYAN;
			else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.YELLOW;
			else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.MAGENTA;
			else if (tsEnumValue.Equals("YELLOW_RED", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.YELLOW_RED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ControlLine_
    {
        public static dynamic GetTSObject(ControlLine dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ControlLine FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ControlLine)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ControlLineArray_
    {
        public static dynamic GetTSObject(ControlLine[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ControlLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ControlLine[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ControlLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ControlLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
