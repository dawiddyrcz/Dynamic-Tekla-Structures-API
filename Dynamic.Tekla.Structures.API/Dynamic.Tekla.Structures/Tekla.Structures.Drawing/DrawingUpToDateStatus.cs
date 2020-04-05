/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum DrawingUpToDateStatus
    {
			DrawingIsUpToDate,
			PartsWereModified,
			DrawingIsUpToDateButMayNeedChecking,
			IncludedDrawingModified,
			OriginalPartDeleted,
			AllPartsDeleted,
			NumberOfPartsInNumberingSeriesIncreased,
			NumberOfPartsInNumberingSeriesDecreased,
			DrawingWasCloned,
			DrawingWasUpdated,
			CopiedViewChanged,
			DrawingWasSplitted,
			MovedViewDeleted,
			MovedViewLabelChanged        
    }

    internal static class DrawingUpToDateStatus_
    {
        public static dynamic GetTSObject(DrawingUpToDateStatus dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DrawingUpToDateStatus").GetType();

            switch (dynEnum)
            {
				case DrawingUpToDateStatus.DrawingIsUpToDate:
					return System.Enum.Parse(tsType, "DrawingIsUpToDate");
				case DrawingUpToDateStatus.PartsWereModified:
					return System.Enum.Parse(tsType, "PartsWereModified");
				case DrawingUpToDateStatus.DrawingIsUpToDateButMayNeedChecking:
					return System.Enum.Parse(tsType, "DrawingIsUpToDateButMayNeedChecking");
				case DrawingUpToDateStatus.IncludedDrawingModified:
					return System.Enum.Parse(tsType, "IncludedDrawingModified");
				case DrawingUpToDateStatus.OriginalPartDeleted:
					return System.Enum.Parse(tsType, "OriginalPartDeleted");
				case DrawingUpToDateStatus.AllPartsDeleted:
					return System.Enum.Parse(tsType, "AllPartsDeleted");
				case DrawingUpToDateStatus.NumberOfPartsInNumberingSeriesIncreased:
					return System.Enum.Parse(tsType, "NumberOfPartsInNumberingSeriesIncreased");
				case DrawingUpToDateStatus.NumberOfPartsInNumberingSeriesDecreased:
					return System.Enum.Parse(tsType, "NumberOfPartsInNumberingSeriesDecreased");
				case DrawingUpToDateStatus.DrawingWasCloned:
					return System.Enum.Parse(tsType, "DrawingWasCloned");
				case DrawingUpToDateStatus.DrawingWasUpdated:
					return System.Enum.Parse(tsType, "DrawingWasUpdated");
				case DrawingUpToDateStatus.CopiedViewChanged:
					return System.Enum.Parse(tsType, "CopiedViewChanged");
				case DrawingUpToDateStatus.DrawingWasSplitted:
					return System.Enum.Parse(tsType, "DrawingWasSplitted");
				case DrawingUpToDateStatus.MovedViewDeleted:
					return System.Enum.Parse(tsType, "MovedViewDeleted");
				case DrawingUpToDateStatus.MovedViewLabelChanged:
					return System.Enum.Parse(tsType, "MovedViewLabelChanged");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DrawingUpToDateStatus FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("DrawingIsUpToDate", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.DrawingIsUpToDate;
			else if (tsEnumValue.Equals("PartsWereModified", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.PartsWereModified;
			else if (tsEnumValue.Equals("DrawingIsUpToDateButMayNeedChecking", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.DrawingIsUpToDateButMayNeedChecking;
			else if (tsEnumValue.Equals("IncludedDrawingModified", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.IncludedDrawingModified;
			else if (tsEnumValue.Equals("OriginalPartDeleted", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.OriginalPartDeleted;
			else if (tsEnumValue.Equals("AllPartsDeleted", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.AllPartsDeleted;
			else if (tsEnumValue.Equals("NumberOfPartsInNumberingSeriesIncreased", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.NumberOfPartsInNumberingSeriesIncreased;
			else if (tsEnumValue.Equals("NumberOfPartsInNumberingSeriesDecreased", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.NumberOfPartsInNumberingSeriesDecreased;
			else if (tsEnumValue.Equals("DrawingWasCloned", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.DrawingWasCloned;
			else if (tsEnumValue.Equals("DrawingWasUpdated", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.DrawingWasUpdated;
			else if (tsEnumValue.Equals("CopiedViewChanged", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.CopiedViewChanged;
			else if (tsEnumValue.Equals("DrawingWasSplitted", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.DrawingWasSplitted;
			else if (tsEnumValue.Equals("MovedViewDeleted", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.MovedViewDeleted;
			else if (tsEnumValue.Equals("MovedViewLabelChanged", System.StringComparison.InvariantCulture))
				return DrawingUpToDateStatus.MovedViewLabelChanged;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
