/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public enum ShapeUpAxis
    {
			Undefined,
			X_Axis,
			Y_Axis,
			Z_Axis        
    }

    internal static class ShapeUpAxis_
    {
        public static dynamic GetTSObject(ShapeUpAxis dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.ShapeUpAxis").GetType();

            switch (dynEnum)
            {
				case ShapeUpAxis.Undefined:
					return System.Enum.Parse(tsType, "Undefined");
				case ShapeUpAxis.X_Axis:
					return System.Enum.Parse(tsType, "X_Axis");
				case ShapeUpAxis.Y_Axis:
					return System.Enum.Parse(tsType, "Y_Axis");
				case ShapeUpAxis.Z_Axis:
					return System.Enum.Parse(tsType, "Z_Axis");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ShapeUpAxis FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Undefined", System.StringComparison.InvariantCulture))
				return ShapeUpAxis.Undefined;
			else if (tsEnumValue.Equals("X_Axis", System.StringComparison.InvariantCulture))
				return ShapeUpAxis.X_Axis;
			else if (tsEnumValue.Equals("Y_Axis", System.StringComparison.InvariantCulture))
				return ShapeUpAxis.Y_Axis;
			else if (tsEnumValue.Equals("Z_Axis", System.StringComparison.InvariantCulture))
				return ShapeUpAxis.Z_Axis;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    