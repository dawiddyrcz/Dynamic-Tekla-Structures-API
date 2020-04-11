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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarHookDataNullable_.FromTSObject(teklaObject.RebarHook);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarHook", ex); }
			}
			set
			{
				try {
				teklaObject.RebarHook = Dynamic.Tekla.Structures.Model.RebarHookDataNullable_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarHook", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable RebarThreading
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable_.FromTSObject(teklaObject.RebarThreading);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarThreading", ex); }
			}
			set
			{
				try {
				teklaObject.RebarThreading = Dynamic.Tekla.Structures.Model.RebarThreadingDataNullable_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarThreading", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable RebarLengthAdjustment
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable_.FromTSObject(teklaObject.RebarLengthAdjustment);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarLengthAdjustment", ex); }
			}
			set
			{
				try {
				teklaObject.RebarLengthAdjustment = Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarLengthAdjustment", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarCrankingNullable RebarCranking
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarCrankingNullable_.FromTSObject(teklaObject.RebarCranking);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarCranking", ex); }
			}
			set
			{
				try {
				teklaObject.RebarCranking = Dynamic.Tekla.Structures.Model.RebarCrankingNullable_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarCranking", ex); }
			}
		}

		public System.Nullable<Dynamic.Tekla.Structures.Model.RebarEndDetailModifier.EndTypeEnum> EndType
		{
			get
			{
				try {
					return teklaObject.EndType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndType", ex); }
			}
			set
			{
				try {
					teklaObject.EndType = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndType", ex); }
			}
		}

        

        

		public RebarEndDetailModifier()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarEndDetailModifier");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarEndDetailModifier(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAffectedBars(
	Dynamic.Tekla.Structures.Model.BaseRebarModifier.AffectedRebarEnum whichEnd_
	)
{
	var whichEnd = Dynamic.Tekla.Structures.Model.BaseRebarModifier.AffectedRebarEnum_.GetTSObject(whichEnd_);
    try
    {
        	var result = teklaObject.GetAffectedBars(whichEnd);

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAffectedBars), ex);
    }
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarEndDetailModifier_
    {
        public static dynamic GetTSObject(RebarEndDetailModifier dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarEndDetailModifier FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarEndDetailModifier)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarEndDetailModifierArray_
    {
        public static dynamic GetTSObject(RebarEndDetailModifier[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarEndDetailModifier_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarEndDetailModifier[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarEndDetailModifier>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarEndDetailModifier_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
