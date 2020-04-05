/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarCranking 
    {

		public Dynamic.Tekla.Structures.Model.RebarCranking.CrankSideEnum CrankSide
		{
			get => Dynamic.Tekla.Structures.Model.RebarCranking.CrankSideEnum_.FromTSObject(teklaObject.CrankSide);
			set { teklaObject.CrankSide = Dynamic.Tekla.Structures.Model.RebarCranking.CrankSideEnum_.GetTSObject(value); }
		}

		public System.Double CrankRotation
		{
			get => teklaObject.CrankRotation;
			set { teklaObject.CrankRotation = value; }
		}

		public System.Double CrankStraightLength
		{
			get => teklaObject.CrankStraightLength;
			set { teklaObject.CrankStraightLength = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarCranking.CrankedLengthTypeEnum CrankedLengthType
		{
			get => Dynamic.Tekla.Structures.Model.RebarCranking.CrankedLengthTypeEnum_.FromTSObject(teklaObject.CrankedLengthType);
			set { teklaObject.CrankedLengthType = Dynamic.Tekla.Structures.Model.RebarCranking.CrankedLengthTypeEnum_.GetTSObject(value); }
		}

		public System.Double CrankedRatio
		{
			get => teklaObject.CrankedRatio;
			set { teklaObject.CrankedRatio = value; }
		}

		public System.Double CrankedDistance
		{
			get => teklaObject.CrankedDistance;
			set { teklaObject.CrankedDistance = value; }
		}

		public System.Double CrankedOffset
		{
			get => teklaObject.CrankedOffset;
			set { teklaObject.CrankedOffset = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarCranking.CrankingTypeEnum CrankingType
		{
			get => Dynamic.Tekla.Structures.Model.RebarCranking.CrankingTypeEnum_.FromTSObject(teklaObject.CrankingType);
			set { teklaObject.CrankingType = Dynamic.Tekla.Structures.Model.RebarCranking.CrankingTypeEnum_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public RebarCranking()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCranking");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarCranking(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum CrankSideEnum
    {
			CRANK_LEFT,
			CRANK_RIGHT        
    }

    internal static class CrankSideEnum_
    {
        public static dynamic GetTSObject(CrankSideEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCranking.CrankSideEnum").GetType();

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

    internal static class CrankedLengthTypeEnum_
    {
        public static dynamic GetTSObject(CrankedLengthTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCranking.CrankedLengthTypeEnum").GetType();

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

    internal static class CrankingTypeEnum_
    {
        public static dynamic GetTSObject(CrankingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCranking.CrankingTypeEnum").GetType();

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

    internal static class RebarCranking_
    {
        public static dynamic GetTSObject(RebarCranking dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarCranking FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarCranking)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarCrankingArray_
    {
        public static dynamic GetTSObject(RebarCranking[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarCranking_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarCranking[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarCranking>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarCranking_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
