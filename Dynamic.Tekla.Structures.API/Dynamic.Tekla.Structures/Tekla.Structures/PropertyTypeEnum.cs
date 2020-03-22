/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public enum PropertyTypeEnum
    {
			TYPE_INT,
			TYPE_DOUBLE,
			TYPE_STRING        
    }

    internal static class PropertyTypeEnum_
    {
        public static dynamic GetTSObject(PropertyTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.PropertyTypeEnum").GetType();

            switch (dynEnum)
            {
				case PropertyTypeEnum.TYPE_INT:
					return System.Enum.Parse(tsType, "TYPE_INT");
				case PropertyTypeEnum.TYPE_DOUBLE:
					return System.Enum.Parse(tsType, "TYPE_DOUBLE");
				case PropertyTypeEnum.TYPE_STRING:
					return System.Enum.Parse(tsType, "TYPE_STRING");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PropertyTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("TYPE_INT", System.StringComparison.InvariantCulture))
				return PropertyTypeEnum.TYPE_INT;
			else if (tsEnumValue.Equals("TYPE_DOUBLE", System.StringComparison.InvariantCulture))
				return PropertyTypeEnum.TYPE_DOUBLE;
			else if (tsEnumValue.Equals("TYPE_STRING", System.StringComparison.InvariantCulture))
				return PropertyTypeEnum.TYPE_STRING;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
