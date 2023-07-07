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

namespace Dynamic.Tekla.Structures.Catalogs
{

    public enum BrepType
    {
			BuildingProduct,
			StructuralShape        
    }

    internal static class BrepType_
    {
        public static dynamic GetTSObject(BrepType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.BrepType").GetType();

            switch (dynEnum)
            {
				case BrepType.BuildingProduct:
					return System.Enum.Parse(tsType, "BuildingProduct");
				case BrepType.StructuralShape:
					return System.Enum.Parse(tsType, "StructuralShape");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BrepType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BuildingProduct", System.StringComparison.InvariantCulture))
				return BrepType.BuildingProduct;
			else if (tsEnumValue.Equals("StructuralShape", System.StringComparison.InvariantCulture))
				return BrepType.StructuralShape;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    