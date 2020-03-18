//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarLengthAdjustmentDataNullable 
    {

		public Tekla.Structures.Model.RebarLengthAdjustmentDataNullable.LengthAdjustmentTypeEnum AdjustmentType
		{
			get => rebarlengthadjustmentdatanullable.AdjustmentType;
			set { rebarlengthadjustmentdatanullable.AdjustmentType = value; }
		}

		public System.Double AdjustmentLength
		{
			get => rebarlengthadjustmentdatanullable.AdjustmentLength;
			set { rebarlengthadjustmentdatanullable.AdjustmentLength = value; }
		}

        

        dynamic rebarlengthadjustmentdatanullable;
        
        public RebarLengthAdjustmentDataNullable()
        {
            this.rebarlengthadjustmentdatanullable =  TSActivator.CreateInstance("Tekla.Structures.Model.RebarLengthAdjustmentDataNullable");
        }

        public RebarLengthAdjustmentDataNullable(dynamic tsObject)
        {
            this.rebarlengthadjustmentdatanullable = tsObject;
        }

        internal dynamic GetTSObject() => rebarlengthadjustmentdatanullable;




    public enum LengthAdjustmentTypeEnum
    {
			NO_ADJUSTMENT,
			END_OFFSET,
			LEG_LENGTH        
    }

    public static class LengthAdjustmentTypeEnum_
    {
        public static dynamic GetTSObject(LengthAdjustmentTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LengthAdjustmentTypeEnum");

            switch (dynEnum)
            {
				case LengthAdjustmentTypeEnum.NO_ADJUSTMENT:
					return System.Enum.Parse(tsType, "NO_ADJUSTMENT");
				case LengthAdjustmentTypeEnum.END_OFFSET:
					return System.Enum.Parse(tsType, "END_OFFSET");
				case LengthAdjustmentTypeEnum.LEG_LENGTH:
					return System.Enum.Parse(tsType, "LEG_LENGTH");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LengthAdjustmentTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NO_ADJUSTMENT", System.StringComparison.InvariantCulture))
				return LengthAdjustmentTypeEnum.NO_ADJUSTMENT;
			else if (tsEnumValue.Equals("END_OFFSET", System.StringComparison.InvariantCulture))
				return LengthAdjustmentTypeEnum.END_OFFSET;
			else if (tsEnumValue.Equals("LEG_LENGTH", System.StringComparison.InvariantCulture))
				return LengthAdjustmentTypeEnum.LEG_LENGTH;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
