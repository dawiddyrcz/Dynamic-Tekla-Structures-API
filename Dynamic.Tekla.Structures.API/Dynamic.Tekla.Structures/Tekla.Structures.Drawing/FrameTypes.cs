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

    public enum FrameTypes
    {
			None,
			Rectangular,
			Line,
			Round,
			Circle,
			Diamond,
			Hexagon,
			Triangle,
			Sharpened        
    }

    internal static class FrameTypes_
    {
        public static dynamic GetTSObject(FrameTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.FrameTypes").GetType();

            switch (dynEnum)
            {
				case FrameTypes.None:
					return System.Enum.Parse(tsType, "None");
				case FrameTypes.Rectangular:
					return System.Enum.Parse(tsType, "Rectangular");
				case FrameTypes.Line:
					return System.Enum.Parse(tsType, "Line");
				case FrameTypes.Round:
					return System.Enum.Parse(tsType, "Round");
				case FrameTypes.Circle:
					return System.Enum.Parse(tsType, "Circle");
				case FrameTypes.Diamond:
					return System.Enum.Parse(tsType, "Diamond");
				case FrameTypes.Hexagon:
					return System.Enum.Parse(tsType, "Hexagon");
				case FrameTypes.Triangle:
					return System.Enum.Parse(tsType, "Triangle");
				case FrameTypes.Sharpened:
					return System.Enum.Parse(tsType, "Sharpened");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static FrameTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("None", System.StringComparison.InvariantCulture))
				return FrameTypes.None;
			else if (tsEnumValue.Equals("Rectangular", System.StringComparison.InvariantCulture))
				return FrameTypes.Rectangular;
			else if (tsEnumValue.Equals("Line", System.StringComparison.InvariantCulture))
				return FrameTypes.Line;
			else if (tsEnumValue.Equals("Round", System.StringComparison.InvariantCulture))
				return FrameTypes.Round;
			else if (tsEnumValue.Equals("Circle", System.StringComparison.InvariantCulture))
				return FrameTypes.Circle;
			else if (tsEnumValue.Equals("Diamond", System.StringComparison.InvariantCulture))
				return FrameTypes.Diamond;
			else if (tsEnumValue.Equals("Hexagon", System.StringComparison.InvariantCulture))
				return FrameTypes.Hexagon;
			else if (tsEnumValue.Equals("Triangle", System.StringComparison.InvariantCulture))
				return FrameTypes.Triangle;
			else if (tsEnumValue.Equals("Sharpened", System.StringComparison.InvariantCulture))
				return FrameTypes.Sharpened;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
