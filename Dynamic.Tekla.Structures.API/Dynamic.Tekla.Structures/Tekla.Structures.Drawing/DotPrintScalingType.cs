/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DotPrintScalingType
    {
			Auto,
			Scale        
    }

    internal static class DotPrintScalingType_
    {
        public static dynamic GetTSObject(DotPrintScalingType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DotPrintScalingType").GetType();

            switch (dynEnum)
            {
				case DotPrintScalingType.Auto:
					return System.Enum.Parse(tsType, "Auto");
				case DotPrintScalingType.Scale:
					return System.Enum.Parse(tsType, "Scale");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DotPrintScalingType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Auto", System.StringComparison.InvariantCulture))
				return DotPrintScalingType.Auto;
			else if (tsEnumValue.Equals("Scale", System.StringComparison.InvariantCulture))
				return DotPrintScalingType.Scale;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
