/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DotPrintColor
    {
			Color,
			BlackAndWhite,
			GreyScale        
    }

    internal static class DotPrintColor_
    {
        public static dynamic GetTSObject(DotPrintColor dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DotPrintColor").GetType();

            switch (dynEnum)
            {
				case DotPrintColor.Color:
					return System.Enum.Parse(tsType, "Color");
				case DotPrintColor.BlackAndWhite:
					return System.Enum.Parse(tsType, "BlackAndWhite");
				case DotPrintColor.GreyScale:
					return System.Enum.Parse(tsType, "GreyScale");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DotPrintColor FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Color", System.StringComparison.InvariantCulture))
				return DotPrintColor.Color;
			else if (tsEnumValue.Equals("BlackAndWhite", System.StringComparison.InvariantCulture))
				return DotPrintColor.BlackAndWhite;
			else if (tsEnumValue.Equals("GreyScale", System.StringComparison.InvariantCulture))
				return DotPrintColor.GreyScale;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
