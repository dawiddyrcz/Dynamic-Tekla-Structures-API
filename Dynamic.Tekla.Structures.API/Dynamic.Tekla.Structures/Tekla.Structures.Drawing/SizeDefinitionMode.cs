/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public enum SizeDefinitionMode
    {
			AutoSize,
			SpecifiedSize        
    }

    internal static class SizeDefinitionMode_
    {
        public static dynamic GetTSObject(SizeDefinitionMode dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.SizeDefinitionMode").GetType();

            switch (dynEnum)
            {
				case SizeDefinitionMode.AutoSize:
					return System.Enum.Parse(tsType, "AutoSize");
				case SizeDefinitionMode.SpecifiedSize:
					return System.Enum.Parse(tsType, "SpecifiedSize");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SizeDefinitionMode FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("AutoSize", System.StringComparison.InvariantCulture))
				return SizeDefinitionMode.AutoSize;
			else if (tsEnumValue.Equals("SpecifiedSize", System.StringComparison.InvariantCulture))
				return SizeDefinitionMode.SpecifiedSize;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
