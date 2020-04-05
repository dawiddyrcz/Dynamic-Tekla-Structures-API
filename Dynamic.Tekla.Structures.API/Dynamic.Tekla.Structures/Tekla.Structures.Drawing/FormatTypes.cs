/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum FormatTypes
    {
			Automatic,
			WholeNumber,
			OneDecimalIfValidDecimal,
			OneDecimal,
			TwoDecimalsIfValidDecimals,
			TwoDecimals,
			ThreeDecimalsIfValidDecimals,
			ThreeDecimals,
			Fractional        
    }

    internal static class FormatTypes_
    {
        public static dynamic GetTSObject(FormatTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.FormatTypes").GetType();

            switch (dynEnum)
            {
				case FormatTypes.Automatic:
					return System.Enum.Parse(tsType, "Automatic");
				case FormatTypes.WholeNumber:
					return System.Enum.Parse(tsType, "WholeNumber");
				case FormatTypes.OneDecimalIfValidDecimal:
					return System.Enum.Parse(tsType, "OneDecimalIfValidDecimal");
				case FormatTypes.OneDecimal:
					return System.Enum.Parse(tsType, "OneDecimal");
				case FormatTypes.TwoDecimalsIfValidDecimals:
					return System.Enum.Parse(tsType, "TwoDecimalsIfValidDecimals");
				case FormatTypes.TwoDecimals:
					return System.Enum.Parse(tsType, "TwoDecimals");
				case FormatTypes.ThreeDecimalsIfValidDecimals:
					return System.Enum.Parse(tsType, "ThreeDecimalsIfValidDecimals");
				case FormatTypes.ThreeDecimals:
					return System.Enum.Parse(tsType, "ThreeDecimals");
				case FormatTypes.Fractional:
					return System.Enum.Parse(tsType, "Fractional");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static FormatTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Automatic", System.StringComparison.InvariantCulture))
				return FormatTypes.Automatic;
			else if (tsEnumValue.Equals("WholeNumber", System.StringComparison.InvariantCulture))
				return FormatTypes.WholeNumber;
			else if (tsEnumValue.Equals("OneDecimalIfValidDecimal", System.StringComparison.InvariantCulture))
				return FormatTypes.OneDecimalIfValidDecimal;
			else if (tsEnumValue.Equals("OneDecimal", System.StringComparison.InvariantCulture))
				return FormatTypes.OneDecimal;
			else if (tsEnumValue.Equals("TwoDecimalsIfValidDecimals", System.StringComparison.InvariantCulture))
				return FormatTypes.TwoDecimalsIfValidDecimals;
			else if (tsEnumValue.Equals("TwoDecimals", System.StringComparison.InvariantCulture))
				return FormatTypes.TwoDecimals;
			else if (tsEnumValue.Equals("ThreeDecimalsIfValidDecimals", System.StringComparison.InvariantCulture))
				return FormatTypes.ThreeDecimalsIfValidDecimals;
			else if (tsEnumValue.Equals("ThreeDecimals", System.StringComparison.InvariantCulture))
				return FormatTypes.ThreeDecimals;
			else if (tsEnumValue.Equals("Fractional", System.StringComparison.InvariantCulture))
				return FormatTypes.Fractional;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
