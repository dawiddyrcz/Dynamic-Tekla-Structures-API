//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public enum DetailTypeEnum
    {
			END,
			INTERMEDIATE,
			INTERMEDIATE_REVERSE        
    }

    internal static class DetailTypeEnum_
    {
        public static dynamic GetTSObject(DetailTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.DetailTypeEnum").GetType();

            switch (dynEnum)
            {
				case DetailTypeEnum.END:
					return System.Enum.Parse(tsType, "END");
				case DetailTypeEnum.INTERMEDIATE:
					return System.Enum.Parse(tsType, "INTERMEDIATE");
				case DetailTypeEnum.INTERMEDIATE_REVERSE:
					return System.Enum.Parse(tsType, "INTERMEDIATE_REVERSE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DetailTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("END", System.StringComparison.InvariantCulture))
				return DetailTypeEnum.END;
			else if (tsEnumValue.Equals("INTERMEDIATE", System.StringComparison.InvariantCulture))
				return DetailTypeEnum.INTERMEDIATE;
			else if (tsEnumValue.Equals("INTERMEDIATE_REVERSE", System.StringComparison.InvariantCulture))
				return DetailTypeEnum.INTERMEDIATE_REVERSE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
