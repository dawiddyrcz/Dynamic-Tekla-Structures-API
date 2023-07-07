/*Copyright (C) Yury Isachenkov 2023
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

namespace Dynamic.Tekla.Structures.Model.Welding
{

    public enum WeldSeamPositionEnum
    {
			SEAM_ABOVE,
			SEAM_BELOW        
    }

    internal static class WeldSeamPositionEnum_
    {
        public static dynamic GetTSObject(WeldSeamPositionEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Welding.WeldSeamPositionEnum").GetType();

            switch (dynEnum)
            {
				case WeldSeamPositionEnum.SEAM_ABOVE:
					return System.Enum.Parse(tsType, "SEAM_ABOVE");
				case WeldSeamPositionEnum.SEAM_BELOW:
					return System.Enum.Parse(tsType, "SEAM_BELOW");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldSeamPositionEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SEAM_ABOVE", System.StringComparison.InvariantCulture))
				return WeldSeamPositionEnum.SEAM_ABOVE;
			else if (tsEnumValue.Equals("SEAM_BELOW", System.StringComparison.InvariantCulture))
				return WeldSeamPositionEnum.SEAM_BELOW;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
