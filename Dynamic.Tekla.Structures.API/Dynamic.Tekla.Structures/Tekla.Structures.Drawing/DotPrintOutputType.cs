/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DotPrintOutputType
    {
			Printer,
			PDF,
			Plot,
			Image        
    }

    internal static class DotPrintOutputType_
    {
        public static dynamic GetTSObject(DotPrintOutputType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DotPrintOutputType").GetType();

            switch (dynEnum)
            {
				case DotPrintOutputType.Printer:
					return System.Enum.Parse(tsType, "Printer");
				case DotPrintOutputType.PDF:
					return System.Enum.Parse(tsType, "PDF");
				case DotPrintOutputType.Plot:
					return System.Enum.Parse(tsType, "Plot");
				case DotPrintOutputType.Image:
					return System.Enum.Parse(tsType, "Image");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DotPrintOutputType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Printer", System.StringComparison.InvariantCulture))
				return DotPrintOutputType.Printer;
			else if (tsEnumValue.Equals("PDF", System.StringComparison.InvariantCulture))
				return DotPrintOutputType.PDF;
			else if (tsEnumValue.Equals("Plot", System.StringComparison.InvariantCulture))
				return DotPrintOutputType.Plot;
			else if (tsEnumValue.Equals("Image", System.StringComparison.InvariantCulture))
				return DotPrintOutputType.Image;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
