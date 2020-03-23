/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum IncludeRevisionMarkEnum
    {
			Never,
			Always,
			ByFormatString        
    }

    internal static class IncludeRevisionMarkEnum_
    {
        public static dynamic GetTSObject(IncludeRevisionMarkEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.IncludeRevisionMarkEnum").GetType();

            switch (dynEnum)
            {
				case IncludeRevisionMarkEnum.Never:
					return System.Enum.Parse(tsType, "Never");
				case IncludeRevisionMarkEnum.Always:
					return System.Enum.Parse(tsType, "Always");
				case IncludeRevisionMarkEnum.ByFormatString:
					return System.Enum.Parse(tsType, "ByFormatString");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static IncludeRevisionMarkEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Never", System.StringComparison.InvariantCulture))
				return IncludeRevisionMarkEnum.Never;
			else if (tsEnumValue.Equals("Always", System.StringComparison.InvariantCulture))
				return IncludeRevisionMarkEnum.Always;
			else if (tsEnumValue.Equals("ByFormatString", System.StringComparison.InvariantCulture))
				return IncludeRevisionMarkEnum.ByFormatString;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    