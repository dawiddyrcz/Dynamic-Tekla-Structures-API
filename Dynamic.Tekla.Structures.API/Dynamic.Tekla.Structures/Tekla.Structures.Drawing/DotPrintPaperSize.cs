/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DotPrintPaperSize
    {
			Auto,
			A0,
			A1,
			A2,
			A3,
			A4,
			A5        
    }

    internal static class DotPrintPaperSize_
    {
        public static dynamic GetTSObject(DotPrintPaperSize dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DotPrintPaperSize").GetType();

            switch (dynEnum)
            {
				case DotPrintPaperSize.Auto:
					return System.Enum.Parse(tsType, "Auto");
				case DotPrintPaperSize.A0:
					return System.Enum.Parse(tsType, "A0");
				case DotPrintPaperSize.A1:
					return System.Enum.Parse(tsType, "A1");
				case DotPrintPaperSize.A2:
					return System.Enum.Parse(tsType, "A2");
				case DotPrintPaperSize.A3:
					return System.Enum.Parse(tsType, "A3");
				case DotPrintPaperSize.A4:
					return System.Enum.Parse(tsType, "A4");
				case DotPrintPaperSize.A5:
					return System.Enum.Parse(tsType, "A5");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DotPrintPaperSize FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Auto", System.StringComparison.InvariantCulture))
				return DotPrintPaperSize.Auto;
			else if (tsEnumValue.Equals("A0", System.StringComparison.InvariantCulture))
				return DotPrintPaperSize.A0;
			else if (tsEnumValue.Equals("A1", System.StringComparison.InvariantCulture))
				return DotPrintPaperSize.A1;
			else if (tsEnumValue.Equals("A2", System.StringComparison.InvariantCulture))
				return DotPrintPaperSize.A2;
			else if (tsEnumValue.Equals("A3", System.StringComparison.InvariantCulture))
				return DotPrintPaperSize.A3;
			else if (tsEnumValue.Equals("A4", System.StringComparison.InvariantCulture))
				return DotPrintPaperSize.A4;
			else if (tsEnumValue.Equals("A5", System.StringComparison.InvariantCulture))
				return DotPrintPaperSize.A5;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
