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

namespace Dynamic.Tekla.Structures
{

    public enum DetailTypeEnum
    {
			END,
			INTERMEDIATE,
			INTERMEDIATE_REVERSE        
    }

    internal static class DetailTypeEnum_
    {
        public static dynamic GetTSObject(DetailTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.DetailTypeEnum").GetType();

            switch (dynEnum)
            {
				case DetailTypeEnum.END:
					return System.Enum.Parse(tsType, "END");
				case DetailTypeEnum.INTERMEDIATE:
					return System.Enum.Parse(tsType, "INTERMEDIATE");
				case DetailTypeEnum.INTERMEDIATE_REVERSE:
					return System.Enum.Parse(tsType, "INTERMEDIATE_REVERSE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DetailTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("END", System.StringComparison.InvariantCulture))
				return DetailTypeEnum.END;
			else if (tsEnumValue.Equals("INTERMEDIATE", System.StringComparison.InvariantCulture))
				return DetailTypeEnum.INTERMEDIATE;
			else if (tsEnumValue.Equals("INTERMEDIATE_REVERSE", System.StringComparison.InvariantCulture))
				return DetailTypeEnum.INTERMEDIATE_REVERSE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
