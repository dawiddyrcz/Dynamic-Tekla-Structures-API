//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarLapping 
    {

		public System.Double LapLength
		{
			get => rebarlapping.LapLength;
			set { rebarlapping.LapLength = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarLapping.LapSideEnum LapSide
		{
			get => Dynamic.Tekla.Structures.Model.RebarLapping.LapSideEnum_.FromTSObject(rebarlapping.LapSide);
			set { rebarlapping.LapSide = Dynamic.Tekla.Structures.Model.RebarLapping.LapSideEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarLapping.LapPlacementEnum LapPlacement
		{
			get => Dynamic.Tekla.Structures.Model.RebarLapping.LapPlacementEnum_.FromTSObject(rebarlapping.LapPlacement);
			set { rebarlapping.LapPlacement = Dynamic.Tekla.Structures.Model.RebarLapping.LapPlacementEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarLapping.LappingTypeEnum LappingType
		{
			get => Dynamic.Tekla.Structures.Model.RebarLapping.LappingTypeEnum_.FromTSObject(rebarlapping.LappingType);
			set { rebarlapping.LappingType = Dynamic.Tekla.Structures.Model.RebarLapping.LappingTypeEnum_.FromTSObject(value); }
		}

        

        dynamic rebarlapping;
        
        public RebarLapping()
        {
            this.rebarlapping =  TSActivator.CreateInstance("Tekla.Structures.Model.RebarLapping");
        }

        public RebarLapping(dynamic tsObject)
        {
            this.rebarlapping = tsObject;
        }

        internal dynamic GetTSObject() => rebarlapping;




    public enum LapSideEnum
    {
			LAP_LEFT,
			LAP_RIGHT,
			LAP_MIDDLE        
    }

    public static class LapSideEnum_
    {
        public static dynamic GetTSObject(LapSideEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LapSideEnum");

            switch (dynEnum)
            {
				case LapSideEnum.LAP_LEFT:
					return System.Enum.Parse(tsType, "LAP_LEFT");
				case LapSideEnum.LAP_RIGHT:
					return System.Enum.Parse(tsType, "LAP_RIGHT");
				case LapSideEnum.LAP_MIDDLE:
					return System.Enum.Parse(tsType, "LAP_MIDDLE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LapSideEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LAP_LEFT", System.StringComparison.InvariantCulture))
				return LapSideEnum.LAP_LEFT;
			else if (tsEnumValue.Equals("LAP_RIGHT", System.StringComparison.InvariantCulture))
				return LapSideEnum.LAP_RIGHT;
			else if (tsEnumValue.Equals("LAP_MIDDLE", System.StringComparison.InvariantCulture))
				return LapSideEnum.LAP_MIDDLE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum LapPlacementEnum
    {
			ON_LEG_FACE,
			PERPENDICULAR_TO_LEG_FACE        
    }

    public static class LapPlacementEnum_
    {
        public static dynamic GetTSObject(LapPlacementEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LapPlacementEnum");

            switch (dynEnum)
            {
				case LapPlacementEnum.ON_LEG_FACE:
					return System.Enum.Parse(tsType, "ON_LEG_FACE");
				case LapPlacementEnum.PERPENDICULAR_TO_LEG_FACE:
					return System.Enum.Parse(tsType, "PERPENDICULAR_TO_LEG_FACE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LapPlacementEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ON_LEG_FACE", System.StringComparison.InvariantCulture))
				return LapPlacementEnum.ON_LEG_FACE;
			else if (tsEnumValue.Equals("PERPENDICULAR_TO_LEG_FACE", System.StringComparison.InvariantCulture))
				return LapPlacementEnum.PERPENDICULAR_TO_LEG_FACE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum LappingTypeEnum
    {
			CUSTOM_LAPPING,
			STANDARD_LAPPING        
    }

    public static class LappingTypeEnum_
    {
        public static dynamic GetTSObject(LappingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LappingTypeEnum");

            switch (dynEnum)
            {
				case LappingTypeEnum.CUSTOM_LAPPING:
					return System.Enum.Parse(tsType, "CUSTOM_LAPPING");
				case LappingTypeEnum.STANDARD_LAPPING:
					return System.Enum.Parse(tsType, "STANDARD_LAPPING");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LappingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CUSTOM_LAPPING", System.StringComparison.InvariantCulture))
				return LappingTypeEnum.CUSTOM_LAPPING;
			else if (tsEnumValue.Equals("STANDARD_LAPPING", System.StringComparison.InvariantCulture))
				return LappingTypeEnum.STANDARD_LAPPING;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
