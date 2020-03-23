/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum ArrowheadPositions
    {
			None,
			Start,
			End,
			Both        
    }

    internal static class ArrowheadPositions_
    {
        public static dynamic GetTSObject(ArrowheadPositions dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.ArrowheadPositions").GetType();

            switch (dynEnum)
            {
				case ArrowheadPositions.None:
					return System.Enum.Parse(tsType, "None");
				case ArrowheadPositions.Start:
					return System.Enum.Parse(tsType, "Start");
				case ArrowheadPositions.End:
					return System.Enum.Parse(tsType, "End");
				case ArrowheadPositions.Both:
					return System.Enum.Parse(tsType, "Both");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ArrowheadPositions FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("None", System.StringComparison.InvariantCulture))
				return ArrowheadPositions.None;
			else if (tsEnumValue.Equals("Start", System.StringComparison.InvariantCulture))
				return ArrowheadPositions.Start;
			else if (tsEnumValue.Equals("End", System.StringComparison.InvariantCulture))
				return ArrowheadPositions.End;
			else if (tsEnumValue.Equals("Both", System.StringComparison.InvariantCulture))
				return ArrowheadPositions.Both;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    