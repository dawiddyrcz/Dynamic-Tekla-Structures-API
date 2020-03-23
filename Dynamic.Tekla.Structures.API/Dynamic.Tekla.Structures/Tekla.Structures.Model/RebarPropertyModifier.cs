/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarPropertyModifier  : Dynamic.Tekla.Structures.Model.BaseRebarModifier
    {

		public Dynamic.Tekla.Structures.Model.RebarPropertiesNullable RebarProperties
		{
			get => Dynamic.Tekla.Structures.Model.RebarPropertiesNullable_.FromTSObject(teklaObject.RebarProperties);
			set { teklaObject.RebarProperties = Dynamic.Tekla.Structures.Model.RebarPropertiesNullable_.GetTSObject(value); }
		}

		public System.Nullable<Dynamic.Tekla.Structures.Model.RebarPropertyModifier.GroupingTypeEnum> GroupingType
		{
			get => teklaObject.GroupingType;
			set { teklaObject.GroupingType = value; }
		}

        

        

		public RebarPropertyModifier()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarPropertyModifier");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarPropertyModifier(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAffectedBars()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetAffectedBars());
		}




    public enum GroupingTypeEnum
    {
			AUTOMATIC,
			MANUAL,
			NO_GROUPING        
    }

    internal static class GroupingTypeEnum_
    {
        public static dynamic GetTSObject(GroupingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarPropertyModifier.GroupingTypeEnum").GetType();

            switch (dynEnum)
            {
				case GroupingTypeEnum.AUTOMATIC:
					return System.Enum.Parse(tsType, "AUTOMATIC");
				case GroupingTypeEnum.MANUAL:
					return System.Enum.Parse(tsType, "MANUAL");
				case GroupingTypeEnum.NO_GROUPING:
					return System.Enum.Parse(tsType, "NO_GROUPING");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static GroupingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("AUTOMATIC", System.StringComparison.InvariantCulture))
				return GroupingTypeEnum.AUTOMATIC;
			else if (tsEnumValue.Equals("MANUAL", System.StringComparison.InvariantCulture))
				return GroupingTypeEnum.MANUAL;
			else if (tsEnumValue.Equals("NO_GROUPING", System.StringComparison.InvariantCulture))
				return GroupingTypeEnum.NO_GROUPING;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarPropertyModifier_
    {
        public static dynamic GetTSObject(RebarPropertyModifier dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarPropertyModifier FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarPropertyModifier)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarPropertyModifierArray_
    {
        public static dynamic GetTSObject(RebarPropertyModifier[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarPropertyModifier_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarPropertyModifier[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<RebarPropertyModifier>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarPropertyModifier_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
