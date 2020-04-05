/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarCrankingNullable 
    {

		public System.Nullable<System.Double> CrankRotation
		{
			get
			{
				try {
					return teklaObject.CrankRotation;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankRotation"); }
			}
			set
			{
				try {
					teklaObject.CrankRotation = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankRotation"); }
			}
		}

		public System.Nullable<System.Double> CrankStraightLength
		{
			get
			{
				try {
					return teklaObject.CrankStraightLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankStraightLength"); }
			}
			set
			{
				try {
					teklaObject.CrankStraightLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankStraightLength"); }
			}
		}

		public System.Nullable<Dynamic.Tekla.Structures.Model.RebarCranking.CrankedLengthTypeEnum> CrankedLengthType
		{
			get
			{
				try {
					return teklaObject.CrankedLengthType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLengthType"); }
			}
			set
			{
				try {
					teklaObject.CrankedLengthType = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedLengthType"); }
			}
		}

		public System.Nullable<System.Double> CrankedRatio
		{
			get
			{
				try {
					return teklaObject.CrankedRatio;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedRatio"); }
			}
			set
			{
				try {
					teklaObject.CrankedRatio = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedRatio"); }
			}
		}

		public System.Nullable<System.Double> CrankedDistance
		{
			get
			{
				try {
					return teklaObject.CrankedDistance;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedDistance"); }
			}
			set
			{
				try {
					teklaObject.CrankedDistance = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedDistance"); }
			}
		}

		public System.Nullable<System.Double> CrankedOffset
		{
			get
			{
				try {
					return teklaObject.CrankedOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedOffset"); }
			}
			set
			{
				try {
					teklaObject.CrankedOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankedOffset"); }
			}
		}

		public System.Nullable<Dynamic.Tekla.Structures.Model.RebarCrankingNullable.EndCrankingTypeEnum> CrankingType
		{
			get
			{
				try {
					return teklaObject.CrankingType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankingType"); }
			}
			set
			{
				try {
					teklaObject.CrankingType = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrankingType"); }
			}
		}

        

        internal dynamic teklaObject;

		public RebarCrankingNullable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCrankingNullable");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarCrankingNullable(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum EndCrankingTypeEnum
    {
			NO_CRANKING,
			CUSTOM_CRANKING,
			STANDARD_CRANKING        
    }

    internal static class EndCrankingTypeEnum_
    {
        public static dynamic GetTSObject(EndCrankingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCrankingNullable.EndCrankingTypeEnum").GetType();

            switch (dynEnum)
            {
				case EndCrankingTypeEnum.NO_CRANKING:
					return System.Enum.Parse(tsType, "NO_CRANKING");
				case EndCrankingTypeEnum.CUSTOM_CRANKING:
					return System.Enum.Parse(tsType, "CUSTOM_CRANKING");
				case EndCrankingTypeEnum.STANDARD_CRANKING:
					return System.Enum.Parse(tsType, "STANDARD_CRANKING");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static EndCrankingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NO_CRANKING", System.StringComparison.InvariantCulture))
				return EndCrankingTypeEnum.NO_CRANKING;
			else if (tsEnumValue.Equals("CUSTOM_CRANKING", System.StringComparison.InvariantCulture))
				return EndCrankingTypeEnum.CUSTOM_CRANKING;
			else if (tsEnumValue.Equals("STANDARD_CRANKING", System.StringComparison.InvariantCulture))
				return EndCrankingTypeEnum.STANDARD_CRANKING;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarCrankingNullable_
    {
        public static dynamic GetTSObject(RebarCrankingNullable dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarCrankingNullable FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarCrankingNullable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarCrankingNullableArray_
    {
        public static dynamic GetTSObject(RebarCrankingNullable[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarCrankingNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarCrankingNullable[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarCrankingNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarCrankingNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
