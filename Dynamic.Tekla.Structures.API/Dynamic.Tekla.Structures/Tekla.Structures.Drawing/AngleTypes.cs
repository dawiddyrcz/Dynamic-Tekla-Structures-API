/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum AngleTypes
    {
			AngleOnSide,
			Triangle,
			AngleAtVertex,
			TriangleWithDegrees        
    }

    internal static class AngleTypes_
    {
        public static dynamic GetTSObject(AngleTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.AngleTypes").GetType();

            switch (dynEnum)
            {
				case AngleTypes.AngleOnSide:
					return System.Enum.Parse(tsType, "AngleOnSide");
				case AngleTypes.Triangle:
					return System.Enum.Parse(tsType, "Triangle");
				case AngleTypes.AngleAtVertex:
					return System.Enum.Parse(tsType, "AngleAtVertex");
				case AngleTypes.TriangleWithDegrees:
					return System.Enum.Parse(tsType, "TriangleWithDegrees");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AngleTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("AngleOnSide", System.StringComparison.InvariantCulture))
				return AngleTypes.AngleOnSide;
			else if (tsEnumValue.Equals("Triangle", System.StringComparison.InvariantCulture))
				return AngleTypes.Triangle;
			else if (tsEnumValue.Equals("AngleAtVertex", System.StringComparison.InvariantCulture))
				return AngleTypes.AngleAtVertex;
			else if (tsEnumValue.Equals("TriangleWithDegrees", System.StringComparison.InvariantCulture))
				return AngleTypes.TriangleWithDegrees;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    