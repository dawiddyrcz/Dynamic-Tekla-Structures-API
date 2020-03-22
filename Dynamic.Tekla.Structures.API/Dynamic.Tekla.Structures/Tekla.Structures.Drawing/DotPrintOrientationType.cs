/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DotPrintOrientationType
    {
			Auto,
			Landscape,
			Portrait        
    }

    internal static class DotPrintOrientationType_
    {
        public static dynamic GetTSObject(DotPrintOrientationType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DotPrintOrientationType").GetType();

            switch (dynEnum)
            {
				case DotPrintOrientationType.Auto:
					return System.Enum.Parse(tsType, "Auto");
				case DotPrintOrientationType.Landscape:
					return System.Enum.Parse(tsType, "Landscape");
				case DotPrintOrientationType.Portrait:
					return System.Enum.Parse(tsType, "Portrait");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DotPrintOrientationType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Auto", System.StringComparison.InvariantCulture))
				return DotPrintOrientationType.Auto;
			else if (tsEnumValue.Equals("Landscape", System.StringComparison.InvariantCulture))
				return DotPrintOrientationType.Landscape;
			else if (tsEnumValue.Equals("Portrait", System.StringComparison.InvariantCulture))
				return DotPrintOrientationType.Portrait;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
