/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public enum AutoDirectionTypeEnum
    {
			AUTODIR_NA,
			AUTODIR_BASIC,
			AUTODIR_DIAGONAL,
			AUTODIR_SPLICE,
			AUTODIR_DETAIL,
			AUTODIR_GLOBAL_Z,
			AUTODIR_SEATING,
			AUTODIR_PRIMARY_X,
			AUTODIR_FROM_ATTRIBUTE_FILE        
    }

    internal static class AutoDirectionTypeEnum_
    {
        public static dynamic GetTSObject(AutoDirectionTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.AutoDirectionTypeEnum").GetType();

            switch (dynEnum)
            {
				case AutoDirectionTypeEnum.AUTODIR_NA:
					return System.Enum.Parse(tsType, "AUTODIR_NA");
				case AutoDirectionTypeEnum.AUTODIR_BASIC:
					return System.Enum.Parse(tsType, "AUTODIR_BASIC");
				case AutoDirectionTypeEnum.AUTODIR_DIAGONAL:
					return System.Enum.Parse(tsType, "AUTODIR_DIAGONAL");
				case AutoDirectionTypeEnum.AUTODIR_SPLICE:
					return System.Enum.Parse(tsType, "AUTODIR_SPLICE");
				case AutoDirectionTypeEnum.AUTODIR_DETAIL:
					return System.Enum.Parse(tsType, "AUTODIR_DETAIL");
				case AutoDirectionTypeEnum.AUTODIR_GLOBAL_Z:
					return System.Enum.Parse(tsType, "AUTODIR_GLOBAL_Z");
				case AutoDirectionTypeEnum.AUTODIR_SEATING:
					return System.Enum.Parse(tsType, "AUTODIR_SEATING");
				case AutoDirectionTypeEnum.AUTODIR_PRIMARY_X:
					return System.Enum.Parse(tsType, "AUTODIR_PRIMARY_X");
				case AutoDirectionTypeEnum.AUTODIR_FROM_ATTRIBUTE_FILE:
					return System.Enum.Parse(tsType, "AUTODIR_FROM_ATTRIBUTE_FILE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AutoDirectionTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("AUTODIR_NA", System.StringComparison.InvariantCulture))
				return AutoDirectionTypeEnum.AUTODIR_NA;
			else if (tsEnumValue.Equals("AUTODIR_BASIC", System.StringComparison.InvariantCulture))
				return AutoDirectionTypeEnum.AUTODIR_BASIC;
			else if (tsEnumValue.Equals("AUTODIR_DIAGONAL", System.StringComparison.InvariantCulture))
				return AutoDirectionTypeEnum.AUTODIR_DIAGONAL;
			else if (tsEnumValue.Equals("AUTODIR_SPLICE", System.StringComparison.InvariantCulture))
				return AutoDirectionTypeEnum.AUTODIR_SPLICE;
			else if (tsEnumValue.Equals("AUTODIR_DETAIL", System.StringComparison.InvariantCulture))
				return AutoDirectionTypeEnum.AUTODIR_DETAIL;
			else if (tsEnumValue.Equals("AUTODIR_GLOBAL_Z", System.StringComparison.InvariantCulture))
				return AutoDirectionTypeEnum.AUTODIR_GLOBAL_Z;
			else if (tsEnumValue.Equals("AUTODIR_SEATING", System.StringComparison.InvariantCulture))
				return AutoDirectionTypeEnum.AUTODIR_SEATING;
			else if (tsEnumValue.Equals("AUTODIR_PRIMARY_X", System.StringComparison.InvariantCulture))
				return AutoDirectionTypeEnum.AUTODIR_PRIMARY_X;
			else if (tsEnumValue.Equals("AUTODIR_FROM_ATTRIBUTE_FILE", System.StringComparison.InvariantCulture))
				return AutoDirectionTypeEnum.AUTODIR_FROM_ATTRIBUTE_FILE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
