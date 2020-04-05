/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public enum OperatorType
    {
			IS_EQUAL,
			IS_NOT_EQUAL,
			BOOLEAN_OR,
			BOOLEAN_AND,
			SMALLER_THAN,
			SMALLER_OR_EQUAL,
			GREATER_THAN,
			GREATER_OR_EQUAL,
			CONTAINS,
			NOT_CONTAINS,
			STARTS_WITH,
			NOT_STARTS_WITH,
			ENDS_WITH,
			NOT_ENDS_WITH,
			EARLIER_THAN,
			EARLIER_OR_EQUAL,
			LATER_THAN,
			LATER_OR_EQUAL        
    }

    internal static class OperatorType_
    {
        public static dynamic GetTSObject(OperatorType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Filtering.OperatorType").GetType();

            switch (dynEnum)
            {
				case OperatorType.IS_EQUAL:
					return System.Enum.Parse(tsType, "IS_EQUAL");
				case OperatorType.IS_NOT_EQUAL:
					return System.Enum.Parse(tsType, "IS_NOT_EQUAL");
				case OperatorType.BOOLEAN_OR:
					return System.Enum.Parse(tsType, "BOOLEAN_OR");
				case OperatorType.BOOLEAN_AND:
					return System.Enum.Parse(tsType, "BOOLEAN_AND");
				case OperatorType.SMALLER_THAN:
					return System.Enum.Parse(tsType, "SMALLER_THAN");
				case OperatorType.SMALLER_OR_EQUAL:
					return System.Enum.Parse(tsType, "SMALLER_OR_EQUAL");
				case OperatorType.GREATER_THAN:
					return System.Enum.Parse(tsType, "GREATER_THAN");
				case OperatorType.GREATER_OR_EQUAL:
					return System.Enum.Parse(tsType, "GREATER_OR_EQUAL");
				case OperatorType.CONTAINS:
					return System.Enum.Parse(tsType, "CONTAINS");
				case OperatorType.NOT_CONTAINS:
					return System.Enum.Parse(tsType, "NOT_CONTAINS");
				case OperatorType.STARTS_WITH:
					return System.Enum.Parse(tsType, "STARTS_WITH");
				case OperatorType.NOT_STARTS_WITH:
					return System.Enum.Parse(tsType, "NOT_STARTS_WITH");
				case OperatorType.ENDS_WITH:
					return System.Enum.Parse(tsType, "ENDS_WITH");
				case OperatorType.NOT_ENDS_WITH:
					return System.Enum.Parse(tsType, "NOT_ENDS_WITH");
				case OperatorType.EARLIER_THAN:
					return System.Enum.Parse(tsType, "EARLIER_THAN");
				case OperatorType.EARLIER_OR_EQUAL:
					return System.Enum.Parse(tsType, "EARLIER_OR_EQUAL");
				case OperatorType.LATER_THAN:
					return System.Enum.Parse(tsType, "LATER_THAN");
				case OperatorType.LATER_OR_EQUAL:
					return System.Enum.Parse(tsType, "LATER_OR_EQUAL");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static OperatorType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("IS_EQUAL", System.StringComparison.InvariantCulture))
				return OperatorType.IS_EQUAL;
			else if (tsEnumValue.Equals("IS_NOT_EQUAL", System.StringComparison.InvariantCulture))
				return OperatorType.IS_NOT_EQUAL;
			else if (tsEnumValue.Equals("BOOLEAN_OR", System.StringComparison.InvariantCulture))
				return OperatorType.BOOLEAN_OR;
			else if (tsEnumValue.Equals("BOOLEAN_AND", System.StringComparison.InvariantCulture))
				return OperatorType.BOOLEAN_AND;
			else if (tsEnumValue.Equals("SMALLER_THAN", System.StringComparison.InvariantCulture))
				return OperatorType.SMALLER_THAN;
			else if (tsEnumValue.Equals("SMALLER_OR_EQUAL", System.StringComparison.InvariantCulture))
				return OperatorType.SMALLER_OR_EQUAL;
			else if (tsEnumValue.Equals("GREATER_THAN", System.StringComparison.InvariantCulture))
				return OperatorType.GREATER_THAN;
			else if (tsEnumValue.Equals("GREATER_OR_EQUAL", System.StringComparison.InvariantCulture))
				return OperatorType.GREATER_OR_EQUAL;
			else if (tsEnumValue.Equals("CONTAINS", System.StringComparison.InvariantCulture))
				return OperatorType.CONTAINS;
			else if (tsEnumValue.Equals("NOT_CONTAINS", System.StringComparison.InvariantCulture))
				return OperatorType.NOT_CONTAINS;
			else if (tsEnumValue.Equals("STARTS_WITH", System.StringComparison.InvariantCulture))
				return OperatorType.STARTS_WITH;
			else if (tsEnumValue.Equals("NOT_STARTS_WITH", System.StringComparison.InvariantCulture))
				return OperatorType.NOT_STARTS_WITH;
			else if (tsEnumValue.Equals("ENDS_WITH", System.StringComparison.InvariantCulture))
				return OperatorType.ENDS_WITH;
			else if (tsEnumValue.Equals("NOT_ENDS_WITH", System.StringComparison.InvariantCulture))
				return OperatorType.NOT_ENDS_WITH;
			else if (tsEnumValue.Equals("EARLIER_THAN", System.StringComparison.InvariantCulture))
				return OperatorType.EARLIER_THAN;
			else if (tsEnumValue.Equals("EARLIER_OR_EQUAL", System.StringComparison.InvariantCulture))
				return OperatorType.EARLIER_OR_EQUAL;
			else if (tsEnumValue.Equals("LATER_THAN", System.StringComparison.InvariantCulture))
				return OperatorType.LATER_THAN;
			else if (tsEnumValue.Equals("LATER_OR_EQUAL", System.StringComparison.InvariantCulture))
				return OperatorType.LATER_OR_EQUAL;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
