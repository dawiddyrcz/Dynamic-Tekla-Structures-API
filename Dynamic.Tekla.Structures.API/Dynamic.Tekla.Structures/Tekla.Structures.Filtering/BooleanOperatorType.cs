/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public enum BooleanOperatorType
    {
			IS_EQUAL,
			IS_NOT_EQUAL,
			BOOLEAN_OR,
			BOOLEAN_AND        
    }

    internal static class BooleanOperatorType_
    {
        public static dynamic GetTSObject(BooleanOperatorType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Filtering.BooleanOperatorType").GetType();

            switch (dynEnum)
            {
				case BooleanOperatorType.IS_EQUAL:
					return System.Enum.Parse(tsType, "IS_EQUAL");
				case BooleanOperatorType.IS_NOT_EQUAL:
					return System.Enum.Parse(tsType, "IS_NOT_EQUAL");
				case BooleanOperatorType.BOOLEAN_OR:
					return System.Enum.Parse(tsType, "BOOLEAN_OR");
				case BooleanOperatorType.BOOLEAN_AND:
					return System.Enum.Parse(tsType, "BOOLEAN_AND");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BooleanOperatorType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("IS_EQUAL", System.StringComparison.InvariantCulture))
				return BooleanOperatorType.IS_EQUAL;
			else if (tsEnumValue.Equals("IS_NOT_EQUAL", System.StringComparison.InvariantCulture))
				return BooleanOperatorType.IS_NOT_EQUAL;
			else if (tsEnumValue.Equals("BOOLEAN_OR", System.StringComparison.InvariantCulture))
				return BooleanOperatorType.BOOLEAN_OR;
			else if (tsEnumValue.Equals("BOOLEAN_AND", System.StringComparison.InvariantCulture))
				return BooleanOperatorType.BOOLEAN_AND;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
