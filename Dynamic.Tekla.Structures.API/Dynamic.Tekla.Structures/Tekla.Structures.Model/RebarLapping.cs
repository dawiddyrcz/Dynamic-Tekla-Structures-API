/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarLapping 
    {

		public System.Double LapLength
		{
			get => teklaObject.LapLength;
			set { teklaObject.LapLength = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarLapping.LapSideEnum LapSide
		{
			get => Dynamic.Tekla.Structures.Model.RebarLapping.LapSideEnum_.FromTSObject(teklaObject.LapSide);
			set { teklaObject.LapSide = Dynamic.Tekla.Structures.Model.RebarLapping.LapSideEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarLapping.LapPlacementEnum LapPlacement
		{
			get => Dynamic.Tekla.Structures.Model.RebarLapping.LapPlacementEnum_.FromTSObject(teklaObject.LapPlacement);
			set { teklaObject.LapPlacement = Dynamic.Tekla.Structures.Model.RebarLapping.LapPlacementEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarLapping.LappingTypeEnum LappingType
		{
			get => Dynamic.Tekla.Structures.Model.RebarLapping.LappingTypeEnum_.FromTSObject(teklaObject.LappingType);
			set { teklaObject.LappingType = Dynamic.Tekla.Structures.Model.RebarLapping.LappingTypeEnum_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public RebarLapping()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLapping");
		}




    public enum LapSideEnum
    {
			LAP_LEFT,
			LAP_RIGHT,
			LAP_MIDDLE        
    }

    internal static class LapSideEnum_
    {
        public static dynamic GetTSObject(LapSideEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLapping.LapSideEnum").GetType();

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

    internal static class LapPlacementEnum_
    {
        public static dynamic GetTSObject(LapPlacementEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLapping.LapPlacementEnum").GetType();

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

    internal static class LappingTypeEnum_
    {
        public static dynamic GetTSObject(LappingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLapping.LappingTypeEnum").GetType();

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

    internal static class RebarLapping_
    {
        public static dynamic GetTSObject(RebarLapping dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarLapping FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.RebarLapping)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarLappingArray_
    {
        public static dynamic GetTSObject(RebarLapping[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarLapping_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarLapping[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<RebarLapping>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarLapping_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
