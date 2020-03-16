//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public enum TemporaryTransparency
    {
			HIDDEN,
			TRANSPARENT,
			SEMITRANSPARENT,
			SEMIVISIBLE,
			VISIBLE        
    }

    public static class TemporaryTransparency_
    {
        public static dynamic GetTSObject(TemporaryTransparency dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.TemporaryTransparency");

            switch (dynEnum)
            {
				case TemporaryTransparency.HIDDEN:
					return System.Enum.Parse(tsType, "HIDDEN");
				case TemporaryTransparency.TRANSPARENT:
					return System.Enum.Parse(tsType, "TRANSPARENT");
				case TemporaryTransparency.SEMITRANSPARENT:
					return System.Enum.Parse(tsType, "SEMITRANSPARENT");
				case TemporaryTransparency.SEMIVISIBLE:
					return System.Enum.Parse(tsType, "SEMIVISIBLE");
				case TemporaryTransparency.VISIBLE:
					return System.Enum.Parse(tsType, "VISIBLE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static TemporaryTransparency FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("HIDDEN", System.StringComparison.InvariantCulture))
				return TemporaryTransparency.HIDDEN;
			else if (tsEnumValue.Equals("TRANSPARENT", System.StringComparison.InvariantCulture))
				return TemporaryTransparency.TRANSPARENT;
			else if (tsEnumValue.Equals("SEMITRANSPARENT", System.StringComparison.InvariantCulture))
				return TemporaryTransparency.SEMITRANSPARENT;
			else if (tsEnumValue.Equals("SEMIVISIBLE", System.StringComparison.InvariantCulture))
				return TemporaryTransparency.SEMIVISIBLE;
			else if (tsEnumValue.Equals("VISIBLE", System.StringComparison.InvariantCulture))
				return TemporaryTransparency.VISIBLE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
