/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum Units
    {
			Automatic,
			Millimeters,
			Centimeters,
			Meters,
			FeetAndInches,
			CentimetersOrMeters,
			Inches        
    }

    internal static class Units_
    {
        public static dynamic GetTSObject(Units dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Units").GetType();

            switch (dynEnum)
            {
				case Units.Automatic:
					return System.Enum.Parse(tsType, "Automatic");
				case Units.Millimeters:
					return System.Enum.Parse(tsType, "Millimeters");
				case Units.Centimeters:
					return System.Enum.Parse(tsType, "Centimeters");
				case Units.Meters:
					return System.Enum.Parse(tsType, "Meters");
				case Units.FeetAndInches:
					return System.Enum.Parse(tsType, "FeetAndInches");
				case Units.CentimetersOrMeters:
					return System.Enum.Parse(tsType, "CentimetersOrMeters");
				case Units.Inches:
					return System.Enum.Parse(tsType, "Inches");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Units FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Automatic", System.StringComparison.InvariantCulture))
				return Units.Automatic;
			else if (tsEnumValue.Equals("Millimeters", System.StringComparison.InvariantCulture))
				return Units.Millimeters;
			else if (tsEnumValue.Equals("Centimeters", System.StringComparison.InvariantCulture))
				return Units.Centimeters;
			else if (tsEnumValue.Equals("Meters", System.StringComparison.InvariantCulture))
				return Units.Meters;
			else if (tsEnumValue.Equals("FeetAndInches", System.StringComparison.InvariantCulture))
				return Units.FeetAndInches;
			else if (tsEnumValue.Equals("CentimetersOrMeters", System.StringComparison.InvariantCulture))
				return Units.CentimetersOrMeters;
			else if (tsEnumValue.Equals("Inches", System.StringComparison.InvariantCulture))
				return Units.Inches;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
