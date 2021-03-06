/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Forming
{

    public enum WrappingType
    {
			NOT_SPECIFIED,
			WRAPPED,
			UNWRAPPED        
    }

    internal static class WrappingType_
    {
        public static dynamic GetTSObject(WrappingType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Forming.WrappingType").GetType();

            switch (dynEnum)
            {
				case WrappingType.NOT_SPECIFIED:
					return System.Enum.Parse(tsType, "NOT_SPECIFIED");
				case WrappingType.WRAPPED:
					return System.Enum.Parse(tsType, "WRAPPED");
				case WrappingType.UNWRAPPED:
					return System.Enum.Parse(tsType, "UNWRAPPED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WrappingType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NOT_SPECIFIED", System.StringComparison.InvariantCulture))
				return WrappingType.NOT_SPECIFIED;
			else if (tsEnumValue.Equals("WRAPPED", System.StringComparison.InvariantCulture))
				return WrappingType.WRAPPED;
			else if (tsEnumValue.Equals("UNWRAPPED", System.StringComparison.InvariantCulture))
				return WrappingType.UNWRAPPED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
