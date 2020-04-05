/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public enum DateTimeOperatorType
    {
			IS_EQUAL,
			IS_NOT_EQUAL,
			EARLIER_THAN,
			EARLIER_OR_EQUAL,
			LATER_THAN,
			LATER_OR_EQUEL        
    }

    internal static class DateTimeOperatorType_
    {
        public static dynamic GetTSObject(DateTimeOperatorType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Filtering.DateTimeOperatorType").GetType();

            switch (dynEnum)
            {
				case DateTimeOperatorType.IS_EQUAL:
					return System.Enum.Parse(tsType, "IS_EQUAL");
				case DateTimeOperatorType.IS_NOT_EQUAL:
					return System.Enum.Parse(tsType, "IS_NOT_EQUAL");
				case DateTimeOperatorType.EARLIER_THAN:
					return System.Enum.Parse(tsType, "EARLIER_THAN");
				case DateTimeOperatorType.EARLIER_OR_EQUAL:
					return System.Enum.Parse(tsType, "EARLIER_OR_EQUAL");
				case DateTimeOperatorType.LATER_THAN:
					return System.Enum.Parse(tsType, "LATER_THAN");
				case DateTimeOperatorType.LATER_OR_EQUEL:
					return System.Enum.Parse(tsType, "LATER_OR_EQUEL");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DateTimeOperatorType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("IS_EQUAL", System.StringComparison.InvariantCulture))
				return DateTimeOperatorType.IS_EQUAL;
			else if (tsEnumValue.Equals("IS_NOT_EQUAL", System.StringComparison.InvariantCulture))
				return DateTimeOperatorType.IS_NOT_EQUAL;
			else if (tsEnumValue.Equals("EARLIER_THAN", System.StringComparison.InvariantCulture))
				return DateTimeOperatorType.EARLIER_THAN;
			else if (tsEnumValue.Equals("EARLIER_OR_EQUAL", System.StringComparison.InvariantCulture))
				return DateTimeOperatorType.EARLIER_OR_EQUAL;
			else if (tsEnumValue.Equals("LATER_THAN", System.StringComparison.InvariantCulture))
				return DateTimeOperatorType.LATER_THAN;
			else if (tsEnumValue.Equals("LATER_OR_EQUEL", System.StringComparison.InvariantCulture))
				return DateTimeOperatorType.LATER_OR_EQUEL;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
