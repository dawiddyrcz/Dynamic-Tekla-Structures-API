//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarCranking 
    {

		public Dynamic.Tekla.Structures.Model.RebarCranking.CrankSideEnum CrankSide
		{
			get => Dynamic.Tekla.Structures.Model.RebarCranking.CrankSideEnum_.FromTSObject(rebarcranking.CrankSide);
			set { rebarcranking.CrankSide = Dynamic.Tekla.Structures.Model.RebarCranking.CrankSideEnum_.FromTSObject(value); }
		}

		public System.Double CrankRotation
		{
			get => rebarcranking.CrankRotation;
			set { rebarcranking.CrankRotation = value; }
		}

		public System.Double CrankStraightLength
		{
			get => rebarcranking.CrankStraightLength;
			set { rebarcranking.CrankStraightLength = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarCranking.CrankedLengthTypeEnum CrankedLengthType
		{
			get => Dynamic.Tekla.Structures.Model.RebarCranking.CrankedLengthTypeEnum_.FromTSObject(rebarcranking.CrankedLengthType);
			set { rebarcranking.CrankedLengthType = Dynamic.Tekla.Structures.Model.RebarCranking.CrankedLengthTypeEnum_.FromTSObject(value); }
		}

		public System.Double CrankedRatio
		{
			get => rebarcranking.CrankedRatio;
			set { rebarcranking.CrankedRatio = value; }
		}

		public System.Double CrankedDistance
		{
			get => rebarcranking.CrankedDistance;
			set { rebarcranking.CrankedDistance = value; }
		}

		public System.Double CrankedOffset
		{
			get => rebarcranking.CrankedOffset;
			set { rebarcranking.CrankedOffset = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarCranking.CrankingTypeEnum CrankingType
		{
			get => Dynamic.Tekla.Structures.Model.RebarCranking.CrankingTypeEnum_.FromTSObject(rebarcranking.CrankingType);
			set { rebarcranking.CrankingType = Dynamic.Tekla.Structures.Model.RebarCranking.CrankingTypeEnum_.FromTSObject(value); }
		}

        

        dynamic rebarcranking;
        
        public RebarCranking()
        {
            this.rebarcranking =  TSActivator.CreateInstance("Tekla.Structures.Model.RebarCranking");
        }

        public RebarCranking(dynamic tsObject)
        {
            this.rebarcranking = tsObject;
        }

        internal dynamic GetTSObject() => rebarcranking;




    public enum CrankSideEnum
    {
			CRANK_LEFT,
			CRANK_RIGHT        
    }

    public static class CrankSideEnum_
    {
        public static dynamic GetTSObject(CrankSideEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.CrankSideEnum");

            switch (dynEnum)
            {
				case CrankSideEnum.CRANK_LEFT:
					return System.Enum.Parse(tsType, "CRANK_LEFT");
				case CrankSideEnum.CRANK_RIGHT:
					return System.Enum.Parse(tsType, "CRANK_RIGHT");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CrankSideEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CRANK_LEFT", System.StringComparison.InvariantCulture))
				return CrankSideEnum.CRANK_LEFT;
			else if (tsEnumValue.Equals("CRANK_RIGHT", System.StringComparison.InvariantCulture))
				return CrankSideEnum.CRANK_RIGHT;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum CrankedLengthTypeEnum
    {
			DIAGONAL_RATIO,
			DIAGONAL_DISTANCE,
			HORIZONTAL_RATIO,
			HORIZONTAL_DISTANCE        
    }

    public static class CrankedLengthTypeEnum_
    {
        public static dynamic GetTSObject(CrankedLengthTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.CrankedLengthTypeEnum");

            switch (dynEnum)
            {
				case CrankedLengthTypeEnum.DIAGONAL_RATIO:
					return System.Enum.Parse(tsType, "DIAGONAL_RATIO");
				case CrankedLengthTypeEnum.DIAGONAL_DISTANCE:
					return System.Enum.Parse(tsType, "DIAGONAL_DISTANCE");
				case CrankedLengthTypeEnum.HORIZONTAL_RATIO:
					return System.Enum.Parse(tsType, "HORIZONTAL_RATIO");
				case CrankedLengthTypeEnum.HORIZONTAL_DISTANCE:
					return System.Enum.Parse(tsType, "HORIZONTAL_DISTANCE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CrankedLengthTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("DIAGONAL_RATIO", System.StringComparison.InvariantCulture))
				return CrankedLengthTypeEnum.DIAGONAL_RATIO;
			else if (tsEnumValue.Equals("DIAGONAL_DISTANCE", System.StringComparison.InvariantCulture))
				return CrankedLengthTypeEnum.DIAGONAL_DISTANCE;
			else if (tsEnumValue.Equals("HORIZONTAL_RATIO", System.StringComparison.InvariantCulture))
				return CrankedLengthTypeEnum.HORIZONTAL_RATIO;
			else if (tsEnumValue.Equals("HORIZONTAL_DISTANCE", System.StringComparison.InvariantCulture))
				return CrankedLengthTypeEnum.HORIZONTAL_DISTANCE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum CrankingTypeEnum
    {
			CUSTOM_CRANKING,
			STANDARD_CRANKING        
    }

    public static class CrankingTypeEnum_
    {
        public static dynamic GetTSObject(CrankingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.CrankingTypeEnum");

            switch (dynEnum)
            {
				case CrankingTypeEnum.CUSTOM_CRANKING:
					return System.Enum.Parse(tsType, "CUSTOM_CRANKING");
				case CrankingTypeEnum.STANDARD_CRANKING:
					return System.Enum.Parse(tsType, "STANDARD_CRANKING");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CrankingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CUSTOM_CRANKING", System.StringComparison.InvariantCulture))
				return CrankingTypeEnum.CUSTOM_CRANKING;
			else if (tsEnumValue.Equals("STANDARD_CRANKING", System.StringComparison.InvariantCulture))
				return CrankingTypeEnum.STANDARD_CRANKING;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
