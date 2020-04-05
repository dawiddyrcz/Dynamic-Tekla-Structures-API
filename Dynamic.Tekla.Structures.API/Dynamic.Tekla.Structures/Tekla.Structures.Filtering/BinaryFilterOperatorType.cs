/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public enum BinaryFilterOperatorType
    {
			BOOLEAN_OR,
			BOOLEAN_AND,
			EMPTY        
    }

    internal static class BinaryFilterOperatorType_
    {
        public static dynamic GetTSObject(BinaryFilterOperatorType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterOperatorType").GetType();

            switch (dynEnum)
            {
				case BinaryFilterOperatorType.BOOLEAN_OR:
					return System.Enum.Parse(tsType, "BOOLEAN_OR");
				case BinaryFilterOperatorType.BOOLEAN_AND:
					return System.Enum.Parse(tsType, "BOOLEAN_AND");
				case BinaryFilterOperatorType.EMPTY:
					return System.Enum.Parse(tsType, "EMPTY");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BinaryFilterOperatorType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BOOLEAN_OR", System.StringComparison.InvariantCulture))
				return BinaryFilterOperatorType.BOOLEAN_OR;
			else if (tsEnumValue.Equals("BOOLEAN_AND", System.StringComparison.InvariantCulture))
				return BinaryFilterOperatorType.BOOLEAN_AND;
			else if (tsEnumValue.Equals("EMPTY", System.StringComparison.InvariantCulture))
				return BinaryFilterOperatorType.EMPTY;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
