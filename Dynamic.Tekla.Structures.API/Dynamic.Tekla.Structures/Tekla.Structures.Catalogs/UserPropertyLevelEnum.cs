/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public enum UserPropertyLevelEnum
    {
			LEVEL_MODEL,
			LEVEL_PROJECT,
			LEVEL_FIRM,
			LEVEL_ENVIRONMENT,
			LEVEL_COMMONDEFAULT        
    }

    internal static class UserPropertyLevelEnum_
    {
        public static dynamic GetTSObject(UserPropertyLevelEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.UserPropertyLevelEnum").GetType();

            switch (dynEnum)
            {
				case UserPropertyLevelEnum.LEVEL_MODEL:
					return System.Enum.Parse(tsType, "LEVEL_MODEL");
				case UserPropertyLevelEnum.LEVEL_PROJECT:
					return System.Enum.Parse(tsType, "LEVEL_PROJECT");
				case UserPropertyLevelEnum.LEVEL_FIRM:
					return System.Enum.Parse(tsType, "LEVEL_FIRM");
				case UserPropertyLevelEnum.LEVEL_ENVIRONMENT:
					return System.Enum.Parse(tsType, "LEVEL_ENVIRONMENT");
				case UserPropertyLevelEnum.LEVEL_COMMONDEFAULT:
					return System.Enum.Parse(tsType, "LEVEL_COMMONDEFAULT");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static UserPropertyLevelEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LEVEL_MODEL", System.StringComparison.InvariantCulture))
				return UserPropertyLevelEnum.LEVEL_MODEL;
			else if (tsEnumValue.Equals("LEVEL_PROJECT", System.StringComparison.InvariantCulture))
				return UserPropertyLevelEnum.LEVEL_PROJECT;
			else if (tsEnumValue.Equals("LEVEL_FIRM", System.StringComparison.InvariantCulture))
				return UserPropertyLevelEnum.LEVEL_FIRM;
			else if (tsEnumValue.Equals("LEVEL_ENVIRONMENT", System.StringComparison.InvariantCulture))
				return UserPropertyLevelEnum.LEVEL_ENVIRONMENT;
			else if (tsEnumValue.Equals("LEVEL_COMMONDEFAULT", System.StringComparison.InvariantCulture))
				return UserPropertyLevelEnum.LEVEL_COMMONDEFAULT;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
