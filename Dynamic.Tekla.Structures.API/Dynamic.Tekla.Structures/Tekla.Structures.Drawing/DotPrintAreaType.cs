/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DotPrintAreaType
    {
			EntireDrawing,
			VisibleArea        
    }

    internal static class DotPrintAreaType_
    {
        public static dynamic GetTSObject(DotPrintAreaType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DotPrintAreaType").GetType();

            switch (dynEnum)
            {
				case DotPrintAreaType.EntireDrawing:
					return System.Enum.Parse(tsType, "EntireDrawing");
				case DotPrintAreaType.VisibleArea:
					return System.Enum.Parse(tsType, "VisibleArea");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DotPrintAreaType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EntireDrawing", System.StringComparison.InvariantCulture))
				return DotPrintAreaType.EntireDrawing;
			else if (tsEnumValue.Equals("VisibleArea", System.StringComparison.InvariantCulture))
				return DotPrintAreaType.VisibleArea;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
