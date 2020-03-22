/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum AutoSizeOptions
    {
			CalculatedSizes,
			FixedSizes,
			CalculatedAndFixedSizes        
    }

    internal static class AutoSizeOptions_
    {
        public static dynamic GetTSObject(AutoSizeOptions dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.AutoSizeOptions").GetType();

            switch (dynEnum)
            {
				case AutoSizeOptions.CalculatedSizes:
					return System.Enum.Parse(tsType, "CalculatedSizes");
				case AutoSizeOptions.FixedSizes:
					return System.Enum.Parse(tsType, "FixedSizes");
				case AutoSizeOptions.CalculatedAndFixedSizes:
					return System.Enum.Parse(tsType, "CalculatedAndFixedSizes");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AutoSizeOptions FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CalculatedSizes", System.StringComparison.InvariantCulture))
				return AutoSizeOptions.CalculatedSizes;
			else if (tsEnumValue.Equals("FixedSizes", System.StringComparison.InvariantCulture))
				return AutoSizeOptions.FixedSizes;
			else if (tsEnumValue.Equals("CalculatedAndFixedSizes", System.StringComparison.InvariantCulture))
				return AutoSizeOptions.CalculatedAndFixedSizes;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
