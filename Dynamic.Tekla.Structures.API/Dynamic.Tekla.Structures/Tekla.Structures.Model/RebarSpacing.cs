/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSpacing 
    {

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarSpacingZone> Zones
		{
			get => teklaObject.Zones;
			set { teklaObject.Zones = value; }
		}

		public System.Double StartOffset
		{
			get => teklaObject.StartOffset;
			set { teklaObject.StartOffset = value; }
		}

		public System.Double EndOffset
		{
			get => teklaObject.EndOffset;
			set { teklaObject.EndOffset = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum StartOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum_.FromTSObject(teklaObject.StartOffsetType);
			set { teklaObject.StartOffsetType = Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum EndOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum_.FromTSObject(teklaObject.EndOffsetType);
			set { teklaObject.EndOffsetType = Dynamic.Tekla.Structures.Model.RebarSpacing.OffsetEnum_.GetTSObject(value); }
		}

		public System.Boolean StartOffsetIsAutomatic
		{
			get => teklaObject.StartOffsetIsAutomatic;
			set { teklaObject.StartOffsetIsAutomatic = value; }
		}

		public System.Boolean EndOffsetIsAutomatic
		{
			get => teklaObject.EndOffsetIsAutomatic;
			set { teklaObject.EndOffsetIsAutomatic = value; }
		}

		public System.Boolean InheritFromPrimary
		{
			get => teklaObject.InheritFromPrimary;
			set { teklaObject.InheritFromPrimary = value; }
		}

        

        internal dynamic teklaObject;

		public RebarSpacing()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing");
		}




    public enum OffsetEnum
    {
			EXACT,
			MINIMUM        
    }

    internal static class OffsetEnum_
    {
        public static dynamic GetTSObject(OffsetEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing.OffsetEnum").GetType();

            switch (dynEnum)
            {
				case OffsetEnum.EXACT:
					return System.Enum.Parse(tsType, "EXACT");
				case OffsetEnum.MINIMUM:
					return System.Enum.Parse(tsType, "MINIMUM");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static OffsetEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EXACT", System.StringComparison.InvariantCulture))
				return OffsetEnum.EXACT;
			else if (tsEnumValue.Equals("MINIMUM", System.StringComparison.InvariantCulture))
				return OffsetEnum.MINIMUM;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarSpacing_
    {
        public static dynamic GetTSObject(RebarSpacing dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarSpacing FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.RebarSpacing)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
