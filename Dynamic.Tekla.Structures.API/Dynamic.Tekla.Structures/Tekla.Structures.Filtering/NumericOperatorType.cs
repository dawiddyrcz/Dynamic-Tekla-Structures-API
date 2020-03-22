/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public enum NumericOperatorType
    {
			IS_EQUAL,
			IS_NOT_EQUAL,
			SMALLER_THAN,
			SMALLER_OR_EQUAL,
			GREATER_THAN,
			GREATER_OR_EQUAL        
    }

    internal static class NumericOperatorType_
    {
        public static dynamic GetTSObject(NumericOperatorType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericOperatorType").GetType();

            switch (dynEnum)
            {
				case NumericOperatorType.IS_EQUAL:
					return System.Enum.Parse(tsType, "IS_EQUAL");
				case NumericOperatorType.IS_NOT_EQUAL:
					return System.Enum.Parse(tsType, "IS_NOT_EQUAL");
				case NumericOperatorType.SMALLER_THAN:
					return System.Enum.Parse(tsType, "SMALLER_THAN");
				case NumericOperatorType.SMALLER_OR_EQUAL:
					return System.Enum.Parse(tsType, "SMALLER_OR_EQUAL");
				case NumericOperatorType.GREATER_THAN:
					return System.Enum.Parse(tsType, "GREATER_THAN");
				case NumericOperatorType.GREATER_OR_EQUAL:
					return System.Enum.Parse(tsType, "GREATER_OR_EQUAL");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static NumericOperatorType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("IS_EQUAL", System.StringComparison.InvariantCulture))
				return NumericOperatorType.IS_EQUAL;
			else if (tsEnumValue.Equals("IS_NOT_EQUAL", System.StringComparison.InvariantCulture))
				return NumericOperatorType.IS_NOT_EQUAL;
			else if (tsEnumValue.Equals("SMALLER_THAN", System.StringComparison.InvariantCulture))
				return NumericOperatorType.SMALLER_THAN;
			else if (tsEnumValue.Equals("SMALLER_OR_EQUAL", System.StringComparison.InvariantCulture))
				return NumericOperatorType.SMALLER_OR_EQUAL;
			else if (tsEnumValue.Equals("GREATER_THAN", System.StringComparison.InvariantCulture))
				return NumericOperatorType.GREATER_THAN;
			else if (tsEnumValue.Equals("GREATER_OR_EQUAL", System.StringComparison.InvariantCulture))
				return NumericOperatorType.GREATER_OR_EQUAL;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
