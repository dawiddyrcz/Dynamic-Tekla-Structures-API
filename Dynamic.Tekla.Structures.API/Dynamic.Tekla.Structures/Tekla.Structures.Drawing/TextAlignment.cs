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

    public enum TextAlignment
    {
			Left,
			Center,
			Right,
			LeaderLine        
    }

    internal static class TextAlignment_
    {
        public static dynamic GetTSObject(TextAlignment dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.TextAlignment").GetType();

            switch (dynEnum)
            {
				case TextAlignment.Left:
					return System.Enum.Parse(tsType, "Left");
				case TextAlignment.Center:
					return System.Enum.Parse(tsType, "Center");
				case TextAlignment.Right:
					return System.Enum.Parse(tsType, "Right");
				case TextAlignment.LeaderLine:
					return System.Enum.Parse(tsType, "LeaderLine");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static TextAlignment FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Left", System.StringComparison.InvariantCulture))
				return TextAlignment.Left;
			else if (tsEnumValue.Equals("Center", System.StringComparison.InvariantCulture))
				return TextAlignment.Center;
			else if (tsEnumValue.Equals("Right", System.StringComparison.InvariantCulture))
				return TextAlignment.Right;
			else if (tsEnumValue.Equals("LeaderLine", System.StringComparison.InvariantCulture))
				return TextAlignment.LeaderLine;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
