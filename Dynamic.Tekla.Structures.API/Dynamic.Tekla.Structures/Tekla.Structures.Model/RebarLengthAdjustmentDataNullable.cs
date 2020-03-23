/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarLengthAdjustmentDataNullable 
    {

		public System.Nullable<Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable.LengthAdjustmentTypeEnum> AdjustmentType
		{
			get => teklaObject.AdjustmentType;
			set { teklaObject.AdjustmentType = value; }
		}

		public System.Nullable<System.Double> AdjustmentLength
		{
			get => teklaObject.AdjustmentLength;
			set { teklaObject.AdjustmentLength = value; }
		}

        

        internal dynamic teklaObject;

		public RebarLengthAdjustmentDataNullable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLengthAdjustmentDataNullable");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarLengthAdjustmentDataNullable(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum LengthAdjustmentTypeEnum
    {
			NO_ADJUSTMENT,
			END_OFFSET,
			LEG_LENGTH        
    }

    internal static class LengthAdjustmentTypeEnum_
    {
        public static dynamic GetTSObject(LengthAdjustmentTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLengthAdjustmentDataNullable.LengthAdjustmentTypeEnum").GetType();

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

    internal static class RebarLengthAdjustmentDataNullable_
    {
        public static dynamic GetTSObject(RebarLengthAdjustmentDataNullable dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static RebarLengthAdjustmentDataNullable FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarLengthAdjustmentDataNullable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarLengthAdjustmentDataNullableArray_
    {
        public static dynamic GetTSObject(RebarLengthAdjustmentDataNullable[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarLengthAdjustmentDataNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarLengthAdjustmentDataNullable[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<RebarLengthAdjustmentDataNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarLengthAdjustmentDataNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
