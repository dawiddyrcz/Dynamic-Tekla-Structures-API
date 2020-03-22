/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public enum FilterExpressionFileType
    {
			OBJECT_GROUP_SELECTION,
			OBJECT_GROUP_VIEW,
			DRAWING_SINGLE_PART,
			DRAWING_ASSEMBLY,
			DRAWING_CAST_UNIT,
			DRAWING_GENERAL        
    }

    internal static class FilterExpressionFileType_
    {
        public static dynamic GetTSObject(FilterExpressionFileType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Filtering.FilterExpressionFileType").GetType();

            switch (dynEnum)
            {
				case FilterExpressionFileType.OBJECT_GROUP_SELECTION:
					return System.Enum.Parse(tsType, "OBJECT_GROUP_SELECTION");
				case FilterExpressionFileType.OBJECT_GROUP_VIEW:
					return System.Enum.Parse(tsType, "OBJECT_GROUP_VIEW");
				case FilterExpressionFileType.DRAWING_SINGLE_PART:
					return System.Enum.Parse(tsType, "DRAWING_SINGLE_PART");
				case FilterExpressionFileType.DRAWING_ASSEMBLY:
					return System.Enum.Parse(tsType, "DRAWING_ASSEMBLY");
				case FilterExpressionFileType.DRAWING_CAST_UNIT:
					return System.Enum.Parse(tsType, "DRAWING_CAST_UNIT");
				case FilterExpressionFileType.DRAWING_GENERAL:
					return System.Enum.Parse(tsType, "DRAWING_GENERAL");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static FilterExpressionFileType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("OBJECT_GROUP_SELECTION", System.StringComparison.InvariantCulture))
				return FilterExpressionFileType.OBJECT_GROUP_SELECTION;
			else if (tsEnumValue.Equals("OBJECT_GROUP_VIEW", System.StringComparison.InvariantCulture))
				return FilterExpressionFileType.OBJECT_GROUP_VIEW;
			else if (tsEnumValue.Equals("DRAWING_SINGLE_PART", System.StringComparison.InvariantCulture))
				return FilterExpressionFileType.DRAWING_SINGLE_PART;
			else if (tsEnumValue.Equals("DRAWING_ASSEMBLY", System.StringComparison.InvariantCulture))
				return FilterExpressionFileType.DRAWING_ASSEMBLY;
			else if (tsEnumValue.Equals("DRAWING_CAST_UNIT", System.StringComparison.InvariantCulture))
				return FilterExpressionFileType.DRAWING_CAST_UNIT;
			else if (tsEnumValue.Equals("DRAWING_GENERAL", System.StringComparison.InvariantCulture))
				return FilterExpressionFileType.DRAWING_GENERAL;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
