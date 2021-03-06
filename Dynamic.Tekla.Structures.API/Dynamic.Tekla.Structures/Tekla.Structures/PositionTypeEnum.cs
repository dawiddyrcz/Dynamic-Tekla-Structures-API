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

    public enum PositionTypeEnum
    {
			MIDDLE_PLANE,
			BOX_PLANE,
			COLLISION_PLANE,
			END_END_PLANE,
			GUSSET_PLANE        
    }

    internal static class PositionTypeEnum_
    {
        public static dynamic GetTSObject(PositionTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.PositionTypeEnum").GetType();

            switch (dynEnum)
            {
				case PositionTypeEnum.MIDDLE_PLANE:
					return System.Enum.Parse(tsType, "MIDDLE_PLANE");
				case PositionTypeEnum.BOX_PLANE:
					return System.Enum.Parse(tsType, "BOX_PLANE");
				case PositionTypeEnum.COLLISION_PLANE:
					return System.Enum.Parse(tsType, "COLLISION_PLANE");
				case PositionTypeEnum.END_END_PLANE:
					return System.Enum.Parse(tsType, "END_END_PLANE");
				case PositionTypeEnum.GUSSET_PLANE:
					return System.Enum.Parse(tsType, "GUSSET_PLANE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PositionTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("MIDDLE_PLANE", System.StringComparison.InvariantCulture))
				return PositionTypeEnum.MIDDLE_PLANE;
			else if (tsEnumValue.Equals("BOX_PLANE", System.StringComparison.InvariantCulture))
				return PositionTypeEnum.BOX_PLANE;
			else if (tsEnumValue.Equals("COLLISION_PLANE", System.StringComparison.InvariantCulture))
				return PositionTypeEnum.COLLISION_PLANE;
			else if (tsEnumValue.Equals("END_END_PLANE", System.StringComparison.InvariantCulture))
				return PositionTypeEnum.END_END_PLANE;
			else if (tsEnumValue.Equals("GUSSET_PLANE", System.StringComparison.InvariantCulture))
				return PositionTypeEnum.GUSSET_PLANE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
