/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.Automation
{

    public enum AutoDrawingsStatusEnum
    {
			OPERATION_OK,
			OPERATION_FAILED,
			ERROR_NUMBERING_NOT_UPTODATE,
			ERROR_DRAWING_EDITOR_MUST_BE_CLOSED        
    }

    internal static class AutoDrawingsStatusEnum_
    {
        public static dynamic GetTSObject(AutoDrawingsStatusEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Automation.AutoDrawingsStatusEnum").GetType();

            switch (dynEnum)
            {
				case AutoDrawingsStatusEnum.OPERATION_OK:
					return System.Enum.Parse(tsType, "OPERATION_OK");
				case AutoDrawingsStatusEnum.OPERATION_FAILED:
					return System.Enum.Parse(tsType, "OPERATION_FAILED");
				case AutoDrawingsStatusEnum.ERROR_NUMBERING_NOT_UPTODATE:
					return System.Enum.Parse(tsType, "ERROR_NUMBERING_NOT_UPTODATE");
				case AutoDrawingsStatusEnum.ERROR_DRAWING_EDITOR_MUST_BE_CLOSED:
					return System.Enum.Parse(tsType, "ERROR_DRAWING_EDITOR_MUST_BE_CLOSED");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AutoDrawingsStatusEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("OPERATION_OK", System.StringComparison.InvariantCulture))
				return AutoDrawingsStatusEnum.OPERATION_OK;
			else if (tsEnumValue.Equals("OPERATION_FAILED", System.StringComparison.InvariantCulture))
				return AutoDrawingsStatusEnum.OPERATION_FAILED;
			else if (tsEnumValue.Equals("ERROR_NUMBERING_NOT_UPTODATE", System.StringComparison.InvariantCulture))
				return AutoDrawingsStatusEnum.ERROR_NUMBERING_NOT_UPTODATE;
			else if (tsEnumValue.Equals("ERROR_DRAWING_EDITOR_MUST_BE_CLOSED", System.StringComparison.InvariantCulture))
				return AutoDrawingsStatusEnum.ERROR_DRAWING_EDITOR_MUST_BE_CLOSED;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    