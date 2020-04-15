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

namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DrawingHatchColors
    {
			Special,
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

    internal static class DrawingHatchColors_
    {
        public static dynamic GetTSObject(DrawingHatchColors dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingHatchColors").GetType();

            switch (dynEnum)
            {
				case DrawingHatchColors.Special:
					return System.Enum.Parse(tsType, "Special");
				case DrawingHatchColors.Gray30:
					return System.Enum.Parse(tsType, "Gray30");
				case DrawingHatchColors.Gray50:
					return System.Enum.Parse(tsType, "Gray50");
				case DrawingHatchColors.Gray70:
					return System.Enum.Parse(tsType, "Gray70");
				case DrawingHatchColors.Gray90:
					return System.Enum.Parse(tsType, "Gray90");
				case DrawingHatchColors.Invisible:
					return System.Enum.Parse(tsType, "Invisible");
				case DrawingHatchColors.Black:
					return System.Enum.Parse(tsType, "Black");
				case DrawingHatchColors.NewLine1:
					return System.Enum.Parse(tsType, "NewLine1");
				case DrawingHatchColors.NewLine2:
					return System.Enum.Parse(tsType, "NewLine2");
				case DrawingHatchColors.NewLine3:
					return System.Enum.Parse(tsType, "NewLine3");
				case DrawingHatchColors.NewLine4:
					return System.Enum.Parse(tsType, "NewLine4");
				case DrawingHatchColors.NewLine5:
					return System.Enum.Parse(tsType, "NewLine5");
				case DrawingHatchColors.NewLine6:
					return System.Enum.Parse(tsType, "NewLine6");
				case DrawingHatchColors.Red:
					return System.Enum.Parse(tsType, "Red");
				case DrawingHatchColors.Green:
					return System.Enum.Parse(tsType, "Green");
				case DrawingHatchColors.Blue:
					return System.Enum.Parse(tsType, "Blue");
				case DrawingHatchColors.Cyan:
					return System.Enum.Parse(tsType, "Cyan");
				case DrawingHatchColors.Yellow:
					return System.Enum.Parse(tsType, "Yellow");
				case DrawingHatchColors.Magenta:
					return System.Enum.Parse(tsType, "Magenta");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DrawingHatchColors FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Special", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Special;
			else if (tsEnumValue.Equals("Gray30", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Gray30;
			else if (tsEnumValue.Equals("Gray50", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Gray50;
			else if (tsEnumValue.Equals("Gray70", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Gray70;
			else if (tsEnumValue.Equals("Gray90", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Gray90;
			else if (tsEnumValue.Equals("Invisible", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Invisible;
			else if (tsEnumValue.Equals("Black", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Black;
			else if (tsEnumValue.Equals("NewLine1", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.NewLine1;
			else if (tsEnumValue.Equals("NewLine2", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.NewLine2;
			else if (tsEnumValue.Equals("NewLine3", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.NewLine3;
			else if (tsEnumValue.Equals("NewLine4", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.NewLine4;
			else if (tsEnumValue.Equals("NewLine5", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.NewLine5;
			else if (tsEnumValue.Equals("NewLine6", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.NewLine6;
			else if (tsEnumValue.Equals("Red", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Red;
			else if (tsEnumValue.Equals("Green", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Green;
			else if (tsEnumValue.Equals("Blue", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Blue;
			else if (tsEnumValue.Equals("Cyan", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Cyan;
			else if (tsEnumValue.Equals("Yellow", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Yellow;
			else if (tsEnumValue.Equals("Magenta", System.StringComparison.InvariantCulture))
				return DrawingHatchColors.Magenta;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
