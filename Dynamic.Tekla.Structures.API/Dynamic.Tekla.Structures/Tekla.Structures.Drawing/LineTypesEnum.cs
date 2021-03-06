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

namespace Dynamic.Tekla.Structures.Drawing
{

    public enum LineTypesEnum
    {
			UndefinedLine,
			SolidLine,
			DashedLine,
			SlashedLine,
			DashDot,
			DottedLine,
			DashDoubleDot,
			SlashDash,
			Custom        
    }

    internal static class LineTypesEnum_
    {
        public static dynamic GetTSObject(LineTypesEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.LineTypesEnum").GetType();

            switch (dynEnum)
            {
				case LineTypesEnum.UndefinedLine:
					return System.Enum.Parse(tsType, "UndefinedLine");
				case LineTypesEnum.SolidLine:
					return System.Enum.Parse(tsType, "SolidLine");
				case LineTypesEnum.DashedLine:
					return System.Enum.Parse(tsType, "DashedLine");
				case LineTypesEnum.SlashedLine:
					return System.Enum.Parse(tsType, "SlashedLine");
				case LineTypesEnum.DashDot:
					return System.Enum.Parse(tsType, "DashDot");
				case LineTypesEnum.DottedLine:
					return System.Enum.Parse(tsType, "DottedLine");
				case LineTypesEnum.DashDoubleDot:
					return System.Enum.Parse(tsType, "DashDoubleDot");
				case LineTypesEnum.SlashDash:
					return System.Enum.Parse(tsType, "SlashDash");
				case LineTypesEnum.Custom:
					return System.Enum.Parse(tsType, "Custom");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LineTypesEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UndefinedLine", System.StringComparison.InvariantCulture))
				return LineTypesEnum.UndefinedLine;
			else if (tsEnumValue.Equals("SolidLine", System.StringComparison.InvariantCulture))
				return LineTypesEnum.SolidLine;
			else if (tsEnumValue.Equals("DashedLine", System.StringComparison.InvariantCulture))
				return LineTypesEnum.DashedLine;
			else if (tsEnumValue.Equals("SlashedLine", System.StringComparison.InvariantCulture))
				return LineTypesEnum.SlashedLine;
			else if (tsEnumValue.Equals("DashDot", System.StringComparison.InvariantCulture))
				return LineTypesEnum.DashDot;
			else if (tsEnumValue.Equals("DottedLine", System.StringComparison.InvariantCulture))
				return LineTypesEnum.DottedLine;
			else if (tsEnumValue.Equals("DashDoubleDot", System.StringComparison.InvariantCulture))
				return LineTypesEnum.DashDoubleDot;
			else if (tsEnumValue.Equals("SlashDash", System.StringComparison.InvariantCulture))
				return LineTypesEnum.SlashDash;
			else if (tsEnumValue.Equals("Custom", System.StringComparison.InvariantCulture))
				return LineTypesEnum.Custom;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
