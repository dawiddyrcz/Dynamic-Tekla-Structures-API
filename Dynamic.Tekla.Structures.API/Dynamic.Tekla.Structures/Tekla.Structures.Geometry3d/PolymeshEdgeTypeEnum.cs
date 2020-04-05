/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public enum PolymeshEdgeTypeEnum
    {
			VISIBLE_EDGE,
			INVISIBLE_EDGE        
    }

    internal static class PolymeshEdgeTypeEnum_
    {
        public static dynamic GetTSObject(PolymeshEdgeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.PolymeshEdgeTypeEnum").GetType();

            switch (dynEnum)
            {
				case PolymeshEdgeTypeEnum.VISIBLE_EDGE:
					return System.Enum.Parse(tsType, "VISIBLE_EDGE");
				case PolymeshEdgeTypeEnum.INVISIBLE_EDGE:
					return System.Enum.Parse(tsType, "INVISIBLE_EDGE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PolymeshEdgeTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("VISIBLE_EDGE", System.StringComparison.InvariantCulture))
				return PolymeshEdgeTypeEnum.VISIBLE_EDGE;
			else if (tsEnumValue.Equals("INVISIBLE_EDGE", System.StringComparison.InvariantCulture))
				return PolymeshEdgeTypeEnum.INVISIBLE_EDGE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
