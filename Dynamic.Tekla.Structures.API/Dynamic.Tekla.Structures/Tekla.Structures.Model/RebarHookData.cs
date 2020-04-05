/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarHookData 
    {

		public Dynamic.Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum Shape
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum_.FromTSObject(teklaObject.Shape);
			set { teklaObject.Shape = Dynamic.Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum_.GetTSObject(value); }
		}

		public System.Double Angle
		{
			get => teklaObject.Angle;
			set { teklaObject.Angle = value; }
		}

		public System.Double Radius
		{
			get => teklaObject.Radius;
			set { teklaObject.Radius = value; }
		}

		public System.Double Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

        

        internal dynamic teklaObject;

		public RebarHookData()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarHookData");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarHookData(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum RebarHookShapeEnum
    {
			NO_HOOK,
			HOOK_90_DEGREES,
			HOOK_135_DEGREES,
			HOOK_180_DEGREES,
			CUSTOM_HOOK        
    }

    internal static class RebarHookShapeEnum_
    {
        public static dynamic GetTSObject(RebarHookShapeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum").GetType();

            switch (dynEnum)
            {
				case RebarHookShapeEnum.NO_HOOK:
					return System.Enum.Parse(tsType, "NO_HOOK");
				case RebarHookShapeEnum.HOOK_90_DEGREES:
					return System.Enum.Parse(tsType, "HOOK_90_DEGREES");
				case RebarHookShapeEnum.HOOK_135_DEGREES:
					return System.Enum.Parse(tsType, "HOOK_135_DEGREES");
				case RebarHookShapeEnum.HOOK_180_DEGREES:
					return System.Enum.Parse(tsType, "HOOK_180_DEGREES");
				case RebarHookShapeEnum.CUSTOM_HOOK:
					return System.Enum.Parse(tsType, "CUSTOM_HOOK");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarHookShapeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NO_HOOK", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.NO_HOOK;
			else if (tsEnumValue.Equals("HOOK_90_DEGREES", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.HOOK_90_DEGREES;
			else if (tsEnumValue.Equals("HOOK_135_DEGREES", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.HOOK_135_DEGREES;
			else if (tsEnumValue.Equals("HOOK_180_DEGREES", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.HOOK_180_DEGREES;
			else if (tsEnumValue.Equals("CUSTOM_HOOK", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.CUSTOM_HOOK;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarHookData_
    {
        public static dynamic GetTSObject(RebarHookData dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarHookData FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarHookData)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarHookDataArray_
    {
        public static dynamic GetTSObject(RebarHookData[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarHookData_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarHookData[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarHookData>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarHookData_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
