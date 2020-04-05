/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum MarkSymbolShape
    {
			None,
			Circular,
			SlashedCircular,
			Custom        
    }

    internal static class MarkSymbolShape_
    {
        public static dynamic GetTSObject(MarkSymbolShape dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.MarkSymbolShape").GetType();

            switch (dynEnum)
            {
				case MarkSymbolShape.None:
					return System.Enum.Parse(tsType, "None");
				case MarkSymbolShape.Circular:
					return System.Enum.Parse(tsType, "Circular");
				case MarkSymbolShape.SlashedCircular:
					return System.Enum.Parse(tsType, "SlashedCircular");
				case MarkSymbolShape.Custom:
					return System.Enum.Parse(tsType, "Custom");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static MarkSymbolShape FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("None", System.StringComparison.InvariantCulture))
				return MarkSymbolShape.None;
			else if (tsEnumValue.Equals("Circular", System.StringComparison.InvariantCulture))
				return MarkSymbolShape.Circular;
			else if (tsEnumValue.Equals("SlashedCircular", System.StringComparison.InvariantCulture))
				return MarkSymbolShape.SlashedCircular;
			else if (tsEnumValue.Equals("Custom", System.StringComparison.InvariantCulture))
				return MarkSymbolShape.Custom;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
