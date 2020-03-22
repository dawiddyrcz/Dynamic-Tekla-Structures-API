/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum TagLocation
    {
			AboveLine,
			BelowLine,
			MiddleLevelOfSymbol,
			AboveSymbolCenterLine,
			BelowSymbolCenterLine,
			CustomRelativeToSymbol        
    }

    internal static class TagLocation_
    {
        public static dynamic GetTSObject(TagLocation dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.TagLocation").GetType();

            switch (dynEnum)
            {
				case TagLocation.AboveLine:
					return System.Enum.Parse(tsType, "AboveLine");
				case TagLocation.BelowLine:
					return System.Enum.Parse(tsType, "BelowLine");
				case TagLocation.MiddleLevelOfSymbol:
					return System.Enum.Parse(tsType, "MiddleLevelOfSymbol");
				case TagLocation.AboveSymbolCenterLine:
					return System.Enum.Parse(tsType, "AboveSymbolCenterLine");
				case TagLocation.BelowSymbolCenterLine:
					return System.Enum.Parse(tsType, "BelowSymbolCenterLine");
				case TagLocation.CustomRelativeToSymbol:
					return System.Enum.Parse(tsType, "CustomRelativeToSymbol");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static TagLocation FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("AboveLine", System.StringComparison.InvariantCulture))
				return TagLocation.AboveLine;
			else if (tsEnumValue.Equals("BelowLine", System.StringComparison.InvariantCulture))
				return TagLocation.BelowLine;
			else if (tsEnumValue.Equals("MiddleLevelOfSymbol", System.StringComparison.InvariantCulture))
				return TagLocation.MiddleLevelOfSymbol;
			else if (tsEnumValue.Equals("AboveSymbolCenterLine", System.StringComparison.InvariantCulture))
				return TagLocation.AboveSymbolCenterLine;
			else if (tsEnumValue.Equals("BelowSymbolCenterLine", System.StringComparison.InvariantCulture))
				return TagLocation.BelowSymbolCenterLine;
			else if (tsEnumValue.Equals("CustomRelativeToSymbol", System.StringComparison.InvariantCulture))
				return TagLocation.CustomRelativeToSymbol;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
