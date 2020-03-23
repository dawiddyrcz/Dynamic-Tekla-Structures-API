/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarEndDetailModifier  : Dynamic.Tekla.Structures.Model.BaseRebarModifier
    {

		public Dynamic.Tekla.Structures.Model.RebarHookDataNullable RebarHook
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookDataNullable_.FromTSObject(teklaObject.RebarHook);
			set { teklaObject.RebarHook = Dynamic.Tekla.Structures.Model.RebarHookDataNullable_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable RebarThreading
		{
			get => Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable_.FromTSObject(teklaObject.RebarThreading);
			set { teklaObject.RebarThreading = Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable RebarLengthAdjustment
		{
			get => Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable_.FromTSObject(teklaObject.RebarLengthAdjustment);
			set { teklaObject.RebarLengthAdjustment = Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarCrankingNullable RebarCranking
		{
			get => Dynamic.Tekla.Structures.Model.RebarCrankingNullable_.FromTSObject(teklaObject.RebarCranking);
			set { teklaObject.RebarCranking = Dynamic.Tekla.Structures.Model.RebarCrankingNullable_.GetTSObject(value); }
		}

		public System.Nullable<Dynamic.Tekla.Structures.Model.RebarEndDetailModifier.EndTypeEnum> EndType
		{
			get => teklaObject.EndType;
			set { teklaObject.EndType = value; }
		}

        

        

		public RebarEndDetailModifier()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarEndDetailModifier");
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAffectedBars(Dynamic.Tekla.Structures.Model.BaseRebarModifier.AffectedRebarEnum whichEnd)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetAffectedBars(Dynamic.Tekla.Structures.Model.BaseRebarModifier.AffectedRebarEnum_.GetTSObject(whichEnd)));
		}




    public enum EndTypeEnum
    {
			HOOK,
			CRANKING        
    }

    internal static class EndTypeEnum_
    {
        public static dynamic GetTSObject(EndTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarEndDetailModifier.EndTypeEnum").GetType();

            switch (dynEnum)
            {
				case EndTypeEnum.HOOK:
					return System.Enum.Parse(tsType, "HOOK");
				case EndTypeEnum.CRANKING:
					return System.Enum.Parse(tsType, "CRANKING");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static EndTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("HOOK", System.StringComparison.InvariantCulture))
				return EndTypeEnum.HOOK;
			else if (tsEnumValue.Equals("CRANKING", System.StringComparison.InvariantCulture))
				return EndTypeEnum.CRANKING;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarEndDetailModifier_
    {
        public static dynamic GetTSObject(RebarEndDetailModifier dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarEndDetailModifier FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.RebarEndDetailModifier)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
