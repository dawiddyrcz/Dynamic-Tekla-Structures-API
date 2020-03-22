/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public enum ScalingOptions
    {
			NoScaling,
			ScaleToFit        
    }

    internal static class ScalingOptions_
    {
        public static dynamic GetTSObject(ScalingOptions dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.ScalingOptions").GetType();

            switch (dynEnum)
            {
				case ScalingOptions.NoScaling:
					return System.Enum.Parse(tsType, "NoScaling");
				case ScalingOptions.ScaleToFit:
					return System.Enum.Parse(tsType, "ScaleToFit");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ScalingOptions FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NoScaling", System.StringComparison.InvariantCulture))
				return ScalingOptions.NoScaling;
			else if (tsEnumValue.Equals("ScaleToFit", System.StringComparison.InvariantCulture))
				return ScalingOptions.ScaleToFit;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
