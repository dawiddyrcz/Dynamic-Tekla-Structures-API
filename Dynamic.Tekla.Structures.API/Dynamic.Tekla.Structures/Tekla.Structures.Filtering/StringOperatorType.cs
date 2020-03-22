/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public enum StringOperatorType
    {
			IS_EQUAL,
			IS_NOT_EQUAL,
			CONTAINS,
			NOT_CONTAINS,
			STARTS_WITH,
			NOT_STARTS_WITH,
			ENDS_WITH,
			NOT_ENDS_WITH        
    }

    internal static class StringOperatorType_
    {
        public static dynamic GetTSObject(StringOperatorType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Filtering.StringOperatorType").GetType();

            switch (dynEnum)
            {
				case StringOperatorType.IS_EQUAL:
					return System.Enum.Parse(tsType, "IS_EQUAL");
				case StringOperatorType.IS_NOT_EQUAL:
					return System.Enum.Parse(tsType, "IS_NOT_EQUAL");
				case StringOperatorType.CONTAINS:
					return System.Enum.Parse(tsType, "CONTAINS");
				case StringOperatorType.NOT_CONTAINS:
					return System.Enum.Parse(tsType, "NOT_CONTAINS");
				case StringOperatorType.STARTS_WITH:
					return System.Enum.Parse(tsType, "STARTS_WITH");
				case StringOperatorType.NOT_STARTS_WITH:
					return System.Enum.Parse(tsType, "NOT_STARTS_WITH");
				case StringOperatorType.ENDS_WITH:
					return System.Enum.Parse(tsType, "ENDS_WITH");
				case StringOperatorType.NOT_ENDS_WITH:
					return System.Enum.Parse(tsType, "NOT_ENDS_WITH");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static StringOperatorType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("IS_EQUAL", System.StringComparison.InvariantCulture))
				return StringOperatorType.IS_EQUAL;
			else if (tsEnumValue.Equals("IS_NOT_EQUAL", System.StringComparison.InvariantCulture))
				return StringOperatorType.IS_NOT_EQUAL;
			else if (tsEnumValue.Equals("CONTAINS", System.StringComparison.InvariantCulture))
				return StringOperatorType.CONTAINS;
			else if (tsEnumValue.Equals("NOT_CONTAINS", System.StringComparison.InvariantCulture))
				return StringOperatorType.NOT_CONTAINS;
			else if (tsEnumValue.Equals("STARTS_WITH", System.StringComparison.InvariantCulture))
				return StringOperatorType.STARTS_WITH;
			else if (tsEnumValue.Equals("NOT_STARTS_WITH", System.StringComparison.InvariantCulture))
				return StringOperatorType.NOT_STARTS_WITH;
			else if (tsEnumValue.Equals("ENDS_WITH", System.StringComparison.InvariantCulture))
				return StringOperatorType.ENDS_WITH;
			else if (tsEnumValue.Equals("NOT_ENDS_WITH", System.StringComparison.InvariantCulture))
				return StringOperatorType.NOT_ENDS_WITH;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
