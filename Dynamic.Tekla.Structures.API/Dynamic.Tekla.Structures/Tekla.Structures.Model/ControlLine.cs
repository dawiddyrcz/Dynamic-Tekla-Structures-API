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
			get => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.Line);
			set { teklaObject.Line = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value); }
		}

		public System.Boolean IsMagnetic
		{
			get => teklaObject.IsMagnetic;
			set { teklaObject.IsMagnetic = value; }
		}

		public System.Double Extension
		{
			get => teklaObject.Extension;
			set { teklaObject.Extension = value; }
		}

		public Dynamic.Tekla.Structures.Model.ControlLine.ControlLineColorEnum Color
		{
			get => Dynamic.Tekla.Structures.Model.ControlLine.ControlLineColorEnum_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Model.ControlLine.ControlLineColorEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ControlObjectLineType LineType
		{
			get => Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(teklaObject.LineType);
			set { teklaObject.LineType = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.GetTSObject(value); }
		}

        

        

		public ControlLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine");
		}
		public ControlLine(Dynamic.Tekla.Structures.Geometry3d.LineSegment Line, System.Boolean IsMagnetic)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(Line);
			args[1] = IsMagnetic;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine", args);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ControlLine_
    {
        public static dynamic GetTSObject(ControlLine dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ControlLine FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ControlLine)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
