//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarHookData 
    {

		public Dynamic.Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum Shape
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum_.FromTSObject(rebarhookdata.Shape);
			set { rebarhookdata.Shape = Dynamic.Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum_.FromTSObject(value); }
		}

		public System.Double Angle
		{
			get => rebarhookdata.Angle;
			set { rebarhookdata.Angle = value; }
		}

		public System.Double Radius
		{
			get => rebarhookdata.Radius;
			set { rebarhookdata.Radius = value; }
		}

		public System.Double Length
		{
			get => rebarhookdata.Length;
			set { rebarhookdata.Length = value; }
		}

        

        dynamic rebarhookdata;
        
        public RebarHookData()
        {
            this.rebarhookdata =  new Tekla.Structures.Model.RebarHookData();
        }

        public RebarHookData(dynamic tsObject)
        {
            this.rebarhookdata = tsObject;
			this.Shape = Dynamic.Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum_.FromTSObject(rebarhookdata.Shape);
			this.Angle = rebarhookdata.Angle;
			this.Radius = rebarhookdata.Radius;
			this.Length = rebarhookdata.Length;

        }


        public dynamic GetTSObject() => rebarhookdata;

		public System.Boolean Equals(System.Object obj)
			 => rebarhookdata.Equals(obj);

		public System.Int32 GetHashCode()
			 => rebarhookdata.GetHashCode();

		public System.Type GetType()
			 => rebarhookdata.GetType();

		public System.String ToString()
			 => rebarhookdata.ToString();




    public enum RebarHookShapeEnum
    {
			NO_HOOK,
			HOOK_90_DEGREES,
			HOOK_135_DEGREES,
			HOOK_180_DEGREES,
			CUSTOM_HOOK        
    }

    public static class RebarHookShapeEnum_
    {
        public static dynamic GetTSObject(RebarHookShapeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarHookShapeEnum");

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

}
    
