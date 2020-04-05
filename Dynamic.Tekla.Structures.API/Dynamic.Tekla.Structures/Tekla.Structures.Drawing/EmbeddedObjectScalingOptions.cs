/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum EmbeddedObjectScalingOptions
    {
			ScaleX,
			ScaleXY,
			ScaleToFit,
			ScaleBestFit        
    }

    internal static class EmbeddedObjectScalingOptions_
    {
        public static dynamic GetTSObject(EmbeddedObjectScalingOptions dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.EmbeddedObjectScalingOptions").GetType();

            switch (dynEnum)
            {
				case EmbeddedObjectScalingOptions.ScaleX:
					return System.Enum.Parse(tsType, "ScaleX");
				case EmbeddedObjectScalingOptions.ScaleXY:
					return System.Enum.Parse(tsType, "ScaleXY");
				case EmbeddedObjectScalingOptions.ScaleToFit:
					return System.Enum.Parse(tsType, "ScaleToFit");
				case EmbeddedObjectScalingOptions.ScaleBestFit:
					return System.Enum.Parse(tsType, "ScaleBestFit");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static EmbeddedObjectScalingOptions FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ScaleX", System.StringComparison.InvariantCulture))
				return EmbeddedObjectScalingOptions.ScaleX;
			else if (tsEnumValue.Equals("ScaleXY", System.StringComparison.InvariantCulture))
				return EmbeddedObjectScalingOptions.ScaleXY;
			else if (tsEnumValue.Equals("ScaleToFit", System.StringComparison.InvariantCulture))
				return EmbeddedObjectScalingOptions.ScaleToFit;
			else if (tsEnumValue.Equals("ScaleBestFit", System.StringComparison.InvariantCulture))
				return EmbeddedObjectScalingOptions.ScaleBestFit;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
