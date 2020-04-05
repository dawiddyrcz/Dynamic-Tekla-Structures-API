/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public enum InvalidFilterExpressionExceptionReasonsType
    {
			TOO_MANY_NESTED_COLLECTIONS        
    }

    internal static class InvalidFilterExpressionExceptionReasonsType_
    {
        public static dynamic GetTSObject(InvalidFilterExpressionExceptionReasonsType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType").GetType();

            switch (dynEnum)
            {
				case InvalidFilterExpressionExceptionReasonsType.TOO_MANY_NESTED_COLLECTIONS:
					return System.Enum.Parse(tsType, "TOO_MANY_NESTED_COLLECTIONS");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static InvalidFilterExpressionExceptionReasonsType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("TOO_MANY_NESTED_COLLECTIONS", System.StringComparison.InvariantCulture))
				return InvalidFilterExpressionExceptionReasonsType.TOO_MANY_NESTED_COLLECTIONS;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
