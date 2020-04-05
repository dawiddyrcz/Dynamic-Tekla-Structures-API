/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public enum HierarchicDefinitionTypeEnum
    {
			DOT_HIERARCHIC_CUSTOM_TYPE,
			DOT_HIERARCHIC_LOGICAL_BUILDING_AREA,
			DOT_HIERARCHIC_OBJECT_TYPE,
			DOT_HIERARCHIC_TASK_WORK_TYPE,
			DOT_HIERARCHIC_TASK_SCENARIO        
    }

    internal static class HierarchicDefinitionTypeEnum_
    {
        public static dynamic GetTSObject(HierarchicDefinitionTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicDefinitionTypeEnum").GetType();

            switch (dynEnum)
            {
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_CUSTOM_TYPE:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_CUSTOM_TYPE");
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_LOGICAL_BUILDING_AREA:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_LOGICAL_BUILDING_AREA");
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_OBJECT_TYPE:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_OBJECT_TYPE");
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_TASK_WORK_TYPE:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_TASK_WORK_TYPE");
				case HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_TASK_SCENARIO:
					return System.Enum.Parse(tsType, "DOT_HIERARCHIC_TASK_SCENARIO");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static HierarchicDefinitionTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("DOT_HIERARCHIC_CUSTOM_TYPE", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_CUSTOM_TYPE;
			else if (tsEnumValue.Equals("DOT_HIERARCHIC_LOGICAL_BUILDING_AREA", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_LOGICAL_BUILDING_AREA;
			else if (tsEnumValue.Equals("DOT_HIERARCHIC_OBJECT_TYPE", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_OBJECT_TYPE;
			else if (tsEnumValue.Equals("DOT_HIERARCHIC_TASK_WORK_TYPE", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_TASK_WORK_TYPE;
			else if (tsEnumValue.Equals("DOT_HIERARCHIC_TASK_SCENARIO", System.StringComparison.InvariantCulture))
				return HierarchicDefinitionTypeEnum.DOT_HIERARCHIC_TASK_SCENARIO;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
