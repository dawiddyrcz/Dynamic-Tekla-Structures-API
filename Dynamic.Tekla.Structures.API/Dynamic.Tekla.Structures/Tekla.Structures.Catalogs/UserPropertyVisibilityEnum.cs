/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public enum UserPropertyVisibilityEnum
    {
			VISIBILITY_NORMAL,
			VISIBILITY_READONLY,
			VISIBILITY_HIDDEN        
    }

    internal static class UserPropertyVisibilityEnum_
    {
        public static dynamic GetTSObject(UserPropertyVisibilityEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.UserPropertyVisibilityEnum").GetType();

            switch (dynEnum)
            {
				case UserPropertyVisibilityEnum.VISIBILITY_NORMAL:
					return System.Enum.Parse(tsType, "VISIBILITY_NORMAL");
				case UserPropertyVisibilityEnum.VISIBILITY_READONLY:
					return System.Enum.Parse(tsType, "VISIBILITY_READONLY");
				case UserPropertyVisibilityEnum.VISIBILITY_HIDDEN:
					return System.Enum.Parse(tsType, "VISIBILITY_HIDDEN");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static UserPropertyVisibilityEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("VISIBILITY_NORMAL", System.StringComparison.InvariantCulture))
				return UserPropertyVisibilityEnum.VISIBILITY_NORMAL;
			else if (tsEnumValue.Equals("VISIBILITY_READONLY", System.StringComparison.InvariantCulture))
				return UserPropertyVisibilityEnum.VISIBILITY_READONLY;
			else if (tsEnumValue.Equals("VISIBILITY_HIDDEN", System.StringComparison.InvariantCulture))
				return UserPropertyVisibilityEnum.VISIBILITY_HIDDEN;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
