/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Forming
{

    public enum FoldingType
    {
			NOT_SPECIFIED,
			FOLDED,
			UNFOLDED        
    }

    internal static class FoldingType_
    {
        public static dynamic GetTSObject(FoldingType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Forming.FoldingType").GetType();

            switch (dynEnum)
            {
				case FoldingType.NOT_SPECIFIED:
					return System.Enum.Parse(tsType, "NOT_SPECIFIED");
				case FoldingType.FOLDED:
					return System.Enum.Parse(tsType, "FOLDED");
				case FoldingType.UNFOLDED:
					return System.Enum.Parse(tsType, "UNFOLDED");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static FoldingType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NOT_SPECIFIED", System.StringComparison.InvariantCulture))
				return FoldingType.NOT_SPECIFIED;
			else if (tsEnumValue.Equals("FOLDED", System.StringComparison.InvariantCulture))
				return FoldingType.FOLDED;
			else if (tsEnumValue.Equals("UNFOLDED", System.StringComparison.InvariantCulture))
				return FoldingType.UNFOLDED;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
