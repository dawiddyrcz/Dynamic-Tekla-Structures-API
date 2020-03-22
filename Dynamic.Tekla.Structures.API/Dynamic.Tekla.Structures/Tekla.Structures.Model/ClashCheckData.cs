/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ClashCheckData 
    {

		public Dynamic.Tekla.Structures.Model.ModelObject Object1
		{
			get => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.Object1);
			set { teklaObject.Object1 = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Object2
		{
			get => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.Object2);
			set { teklaObject.Object2 = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ClashCheckData.ClashTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.ClashCheckData.ClashTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Model.ClashCheckData.ClashTypeEnum_.GetTSObject(value); }
		}

		public System.Double Overlap
		{
			get => teklaObject.Overlap;
			set { teklaObject.Overlap = value; }
		}

        

        internal dynamic teklaObject;

		public ClashCheckData()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ClashCheckData");
		}




    public enum ClashTypeEnum
    {
			CLASH_TYPE_INVALID,
			CLASH_TYPE_ISINSIDE,
			CLASH_TYPE_EXACTMATCH,
			CLASH_TYPE_CLASH,
			CLASH_TYPE_MINDISTANCE,
			CLASH_TYPE_FAILEDSOLID,
			CLASH_TYPE_CUTTHROUGH,
			CLASH_TYPE_COMPLEXCLASH,
			CLASH_TYPE_FAILEDTEST        
    }

    internal static class ClashTypeEnum_
    {
        public static dynamic GetTSObject(ClashTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ClashCheckData.ClashTypeEnum").GetType();

            switch (dynEnum)
            {
				case ClashTypeEnum.CLASH_TYPE_INVALID:
					return System.Enum.Parse(tsType, "CLASH_TYPE_INVALID");
				case ClashTypeEnum.CLASH_TYPE_ISINSIDE:
					return System.Enum.Parse(tsType, "CLASH_TYPE_ISINSIDE");
				case ClashTypeEnum.CLASH_TYPE_EXACTMATCH:
					return System.Enum.Parse(tsType, "CLASH_TYPE_EXACTMATCH");
				case ClashTypeEnum.CLASH_TYPE_CLASH:
					return System.Enum.Parse(tsType, "CLASH_TYPE_CLASH");
				case ClashTypeEnum.CLASH_TYPE_MINDISTANCE:
					return System.Enum.Parse(tsType, "CLASH_TYPE_MINDISTANCE");
				case ClashTypeEnum.CLASH_TYPE_FAILEDSOLID:
					return System.Enum.Parse(tsType, "CLASH_TYPE_FAILEDSOLID");
				case ClashTypeEnum.CLASH_TYPE_CUTTHROUGH:
					return System.Enum.Parse(tsType, "CLASH_TYPE_CUTTHROUGH");
				case ClashTypeEnum.CLASH_TYPE_COMPLEXCLASH:
					return System.Enum.Parse(tsType, "CLASH_TYPE_COMPLEXCLASH");
				case ClashTypeEnum.CLASH_TYPE_FAILEDTEST:
					return System.Enum.Parse(tsType, "CLASH_TYPE_FAILEDTEST");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ClashTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CLASH_TYPE_INVALID", System.StringComparison.InvariantCulture))
				return ClashTypeEnum.CLASH_TYPE_INVALID;
			else if (tsEnumValue.Equals("CLASH_TYPE_ISINSIDE", System.StringComparison.InvariantCulture))
				return ClashTypeEnum.CLASH_TYPE_ISINSIDE;
			else if (tsEnumValue.Equals("CLASH_TYPE_EXACTMATCH", System.StringComparison.InvariantCulture))
				return ClashTypeEnum.CLASH_TYPE_EXACTMATCH;
			else if (tsEnumValue.Equals("CLASH_TYPE_CLASH", System.StringComparison.InvariantCulture))
				return ClashTypeEnum.CLASH_TYPE_CLASH;
			else if (tsEnumValue.Equals("CLASH_TYPE_MINDISTANCE", System.StringComparison.InvariantCulture))
				return ClashTypeEnum.CLASH_TYPE_MINDISTANCE;
			else if (tsEnumValue.Equals("CLASH_TYPE_FAILEDSOLID", System.StringComparison.InvariantCulture))
				return ClashTypeEnum.CLASH_TYPE_FAILEDSOLID;
			else if (tsEnumValue.Equals("CLASH_TYPE_CUTTHROUGH", System.StringComparison.InvariantCulture))
				return ClashTypeEnum.CLASH_TYPE_CUTTHROUGH;
			else if (tsEnumValue.Equals("CLASH_TYPE_COMPLEXCLASH", System.StringComparison.InvariantCulture))
				return ClashTypeEnum.CLASH_TYPE_COMPLEXCLASH;
			else if (tsEnumValue.Equals("CLASH_TYPE_FAILEDTEST", System.StringComparison.InvariantCulture))
				return ClashTypeEnum.CLASH_TYPE_FAILEDTEST;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ClashCheckData_
    {
        public static dynamic GetTSObject(ClashCheckData dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ClashCheckData FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ClashCheckData)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
