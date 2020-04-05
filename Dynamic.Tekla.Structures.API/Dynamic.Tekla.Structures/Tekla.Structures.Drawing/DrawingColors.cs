/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DrawingColors
    {
			Gray30,
			Gray50,
			Gray70,
			Gray90,
			Invisible,
			Black,
			NewLine1,
			NewLine2,
			NewLine3,
			NewLine4,
			NewLine5,
			NewLine6,
			Red,
			Green,
			Blue,
			Cyan,
			Yellow,
			Magenta        
    }

    internal static class DrawingColors_
    {
        public static dynamic GetTSObject(DrawingColors dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingColors").GetType();

            switch (dynEnum)
            {
				case DrawingColors.Gray30:
					return System.Enum.Parse(tsType, "Gray30");
				case DrawingColors.Gray50:
					return System.Enum.Parse(tsType, "Gray50");
				case DrawingColors.Gray70:
					return System.Enum.Parse(tsType, "Gray70");
				case DrawingColors.Gray90:
					return System.Enum.Parse(tsType, "Gray90");
				case DrawingColors.Invisible:
					return System.Enum.Parse(tsType, "Invisible");
				case DrawingColors.Black:
					return System.Enum.Parse(tsType, "Black");
				case DrawingColors.NewLine1:
					return System.Enum.Parse(tsType, "NewLine1");
				case DrawingColors.NewLine2:
					return System.Enum.Parse(tsType, "NewLine2");
				case DrawingColors.NewLine3:
					return System.Enum.Parse(tsType, "NewLine3");
				case DrawingColors.NewLine4:
					return System.Enum.Parse(tsType, "NewLine4");
				case DrawingColors.NewLine5:
					return System.Enum.Parse(tsType, "NewLine5");
				case DrawingColors.NewLine6:
					return System.Enum.Parse(tsType, "NewLine6");
				case DrawingColors.Red:
					return System.Enum.Parse(tsType, "Red");
				case DrawingColors.Green:
					return System.Enum.Parse(tsType, "Green");
				case DrawingColors.Blue:
					return System.Enum.Parse(tsType, "Blue");
				case DrawingColors.Cyan:
					return System.Enum.Parse(tsType, "Cyan");
				case DrawingColors.Yellow:
					return System.Enum.Parse(tsType, "Yellow");
				case DrawingColors.Magenta:
					return System.Enum.Parse(tsType, "Magenta");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DrawingColors FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Gray30", System.StringComparison.InvariantCulture))
				return DrawingColors.Gray30;
			else if (tsEnumValue.Equals("Gray50", System.StringComparison.InvariantCulture))
				return DrawingColors.Gray50;
			else if (tsEnumValue.Equals("Gray70", System.StringComparison.InvariantCulture))
				return DrawingColors.Gray70;
			else if (tsEnumValue.Equals("Gray90", System.StringComparison.InvariantCulture))
				return DrawingColors.Gray90;
			else if (tsEnumValue.Equals("Invisible", System.StringComparison.InvariantCulture))
				return DrawingColors.Invisible;
			else if (tsEnumValue.Equals("Black", System.StringComparison.InvariantCulture))
				return DrawingColors.Black;
			else if (tsEnumValue.Equals("NewLine1", System.StringComparison.InvariantCulture))
				return DrawingColors.NewLine1;
			else if (tsEnumValue.Equals("NewLine2", System.StringComparison.InvariantCulture))
				return DrawingColors.NewLine2;
			else if (tsEnumValue.Equals("NewLine3", System.StringComparison.InvariantCulture))
				return DrawingColors.NewLine3;
			else if (tsEnumValue.Equals("NewLine4", System.StringComparison.InvariantCulture))
				return DrawingColors.NewLine4;
			else if (tsEnumValue.Equals("NewLine5", System.StringComparison.InvariantCulture))
				return DrawingColors.NewLine5;
			else if (tsEnumValue.Equals("NewLine6", System.StringComparison.InvariantCulture))
				return DrawingColors.NewLine6;
			else if (tsEnumValue.Equals("Red", System.StringComparison.InvariantCulture))
				return DrawingColors.Red;
			else if (tsEnumValue.Equals("Green", System.StringComparison.InvariantCulture))
				return DrawingColors.Green;
			else if (tsEnumValue.Equals("Blue", System.StringComparison.InvariantCulture))
				return DrawingColors.Blue;
			else if (tsEnumValue.Equals("Cyan", System.StringComparison.InvariantCulture))
				return DrawingColors.Cyan;
			else if (tsEnumValue.Equals("Yellow", System.StringComparison.InvariantCulture))
				return DrawingColors.Yellow;
			else if (tsEnumValue.Equals("Magenta", System.StringComparison.InvariantCulture))
				return DrawingColors.Magenta;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
