/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum ArrowheadTypes
    {
			NoArrow,
			FilledArrow,
			LineArrow,
			CircleArrow,
			FilledCircleArrow        
    }

    internal static class ArrowheadTypes_
    {
        public static dynamic GetTSObject(ArrowheadTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.ArrowheadTypes").GetType();

            switch (dynEnum)
            {
				case ArrowheadTypes.NoArrow:
					return System.Enum.Parse(tsType, "NoArrow");
				case ArrowheadTypes.FilledArrow:
					return System.Enum.Parse(tsType, "FilledArrow");
				case ArrowheadTypes.LineArrow:
					return System.Enum.Parse(tsType, "LineArrow");
				case ArrowheadTypes.CircleArrow:
					return System.Enum.Parse(tsType, "CircleArrow");
				case ArrowheadTypes.FilledCircleArrow:
					return System.Enum.Parse(tsType, "FilledCircleArrow");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ArrowheadTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NoArrow", System.StringComparison.InvariantCulture))
				return ArrowheadTypes.NoArrow;
			else if (tsEnumValue.Equals("FilledArrow", System.StringComparison.InvariantCulture))
				return ArrowheadTypes.FilledArrow;
			else if (tsEnumValue.Equals("LineArrow", System.StringComparison.InvariantCulture))
				return ArrowheadTypes.LineArrow;
			else if (tsEnumValue.Equals("CircleArrow", System.StringComparison.InvariantCulture))
				return ArrowheadTypes.CircleArrow;
			else if (tsEnumValue.Equals("FilledCircleArrow", System.StringComparison.InvariantCulture))
				return ArrowheadTypes.FilledCircleArrow;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
