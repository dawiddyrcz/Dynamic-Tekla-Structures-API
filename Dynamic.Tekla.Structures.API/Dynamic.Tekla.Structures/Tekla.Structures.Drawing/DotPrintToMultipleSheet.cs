/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DotPrintToMultipleSheet
    {
			Off,
			LeftToRightAndTopToBottom,
			BottomToTopAndRightToLeft        
    }

    internal static class DotPrintToMultipleSheet_
    {
        public static dynamic GetTSObject(DotPrintToMultipleSheet dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DotPrintToMultipleSheet").GetType();

            switch (dynEnum)
            {
				case DotPrintToMultipleSheet.Off:
					return System.Enum.Parse(tsType, "Off");
				case DotPrintToMultipleSheet.LeftToRightAndTopToBottom:
					return System.Enum.Parse(tsType, "LeftToRightAndTopToBottom");
				case DotPrintToMultipleSheet.BottomToTopAndRightToLeft:
					return System.Enum.Parse(tsType, "BottomToTopAndRightToLeft");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DotPrintToMultipleSheet FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Off", System.StringComparison.InvariantCulture))
				return DotPrintToMultipleSheet.Off;
			else if (tsEnumValue.Equals("LeftToRightAndTopToBottom", System.StringComparison.InvariantCulture))
				return DotPrintToMultipleSheet.LeftToRightAndTopToBottom;
			else if (tsEnumValue.Equals("BottomToTopAndRightToLeft", System.StringComparison.InvariantCulture))
				return DotPrintToMultipleSheet.BottomToTopAndRightToLeft;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
