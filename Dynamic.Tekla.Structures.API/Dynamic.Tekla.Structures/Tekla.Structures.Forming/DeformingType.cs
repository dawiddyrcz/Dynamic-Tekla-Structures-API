/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Forming
{

    public enum DeformingType
    {
			NOT_SPECIFIED,
			DEFORMED,
			UNDEFORMED        
    }

    internal static class DeformingType_
    {
        public static dynamic GetTSObject(DeformingType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Forming.DeformingType").GetType();

            switch (dynEnum)
            {
				case DeformingType.NOT_SPECIFIED:
					return System.Enum.Parse(tsType, "NOT_SPECIFIED");
				case DeformingType.DEFORMED:
					return System.Enum.Parse(tsType, "DEFORMED");
				case DeformingType.UNDEFORMED:
					return System.Enum.Parse(tsType, "UNDEFORMED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DeformingType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NOT_SPECIFIED", System.StringComparison.InvariantCulture))
				return DeformingType.NOT_SPECIFIED;
			else if (tsEnumValue.Equals("DEFORMED", System.StringComparison.InvariantCulture))
				return DeformingType.DEFORMED;
			else if (tsEnumValue.Equals("UNDEFORMED", System.StringComparison.InvariantCulture))
				return DeformingType.UNDEFORMED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
