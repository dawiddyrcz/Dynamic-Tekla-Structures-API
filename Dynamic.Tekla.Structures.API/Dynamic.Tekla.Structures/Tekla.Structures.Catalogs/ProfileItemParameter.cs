/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class ProfileItemParameter 
    {

		public System.String Property
		{
			get => teklaObject.Property;

		}

		public System.Double Value
		{
			get => teklaObject.Value;
			set { teklaObject.Value = value; }
		}

		public System.String StringValue
		{
			get => teklaObject.StringValue;
			set { teklaObject.StringValue = value; }
		}

		public System.String Symbol
		{
			get => teklaObject.Symbol;

		}

		public Dynamic.Tekla.Structures.Catalogs.ProfileItemParameter.ParameterUnitTypeEnum ParameterUnitType
		{
			get => Dynamic.Tekla.Structures.Catalogs.ProfileItemParameter.ParameterUnitTypeEnum_.FromTSObject(teklaObject.ParameterUnitType);

		}

		public System.Int32 CrossSectionNumber
		{
			get => teklaObject.CrossSectionNumber;

		}

        

        internal dynamic teklaObject;

		public ProfileItemParameter()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.ProfileItemParameter");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ProfileItemParameter(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum ParameterUnitTypeEnum
    {
			INPUT_NONE,
			INPUT_RATIO_UNIT,
			INPUT_STRAIN_UNIT,
			INPUT_ANGLE_UNIT,
			OUTPUT_ANGLE_UNIT,
			INPUT_SECTION_ANGLE_UNIT,
			INPUT_LENGTH_UNIT,
			OUTPUT_LENGTH_UNIT,
			INPUT_DEFORMATION_UNIT,
			OUTPUT_DEFORMATION_UNIT,
			INPUT_DIMENSION_UNIT,
			INPUT_RADIUSOFINERTIA_UNIT,
			INPUT_AREA_UNIT,
			OUTPUT_REINFAREA_UNIT,
			OUTPUT_TRANSVREINF_UNIT,
			INPUT_AREAPERLENGTH_UNIT,
			OUTPUT_VOLUME_UNIT,
			INPUT_SECTIONMODULUS_UNIT,
			INPUT_VOLUME_UNIT,
			INPUT_MOMENTOFINERTIA_UNIT,
			INPUT_TORSIONCONSTANT_UNIT,
			INPUT_WARPINGCONSTANT_UNIT,
			INPUT_FORCE_UNIT,
			OUTPUT_FORCE_UNIT,
			INPUT_WEIGHT_UNIT,
			OUTPUT_WEIGHT_UNIT,
			INPUT_DISTRIBLOAD_UNIT,
			OUTPUT_DISTRIBLOAD_UNIT,
			INPUT_SPRINGCONSTANT_UNIT,
			OUTPUT_MASSPERLENGTH_UNIT,
			INPUT_SURFACELOAD_UNIT,
			OUTPUT_SURFACELOAD_UNIT,
			INPUT_STRENGTH_UNIT,
			OUTPUT_STRESS_UNIT,
			INPUT_MODULUS_UNIT,
			INPUT_DENSITY_UNIT,
			INPUT_MOMENT_UNIT,
			OUTPUT_MOMENT_UNIT,
			INPUT_DISTRIBMOMENT_UNIT,
			INPUT_ROTSPRINGCONST_UNIT,
			INPUT_TEMPERATURE_UNIT,
			OUTPUT_TEMPERATURE_UNIT,
			INPUT_THERMDILATCOEFF_UNIT,
			INPUT_FACTOR_UNIT,
			INPUT_DATE_UNIT,
			INPUT_DATE_TIME_MIN_UNIT,
			INPUT_DATE_TIME_SEC_UNIT,
			INPUT_LENGTH_FRACTIONAL_IMPERIAL,
			OUTPUT_LENGTH_FRACTIONAL_IMPERIAL,
			OUTPUT_DEFORMATION_FRACTIONAL_IMPERIAL,
			INPUT_DIMENSION_FRACTIONAL_IMPERIAL,
			INPUT_RADIUSOFINERTIA_FRACTIONAL_IMPERIAL,
			INPUT_BOOLEAN,
			INPUT_INTEGER,
			INPUT_STRING        
    }

    internal static class ParameterUnitTypeEnum_
    {
        public static dynamic GetTSObject(ParameterUnitTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.ProfileItemParameter.ParameterUnitTypeEnum").GetType();

            switch (dynEnum)
            {
				case ParameterUnitTypeEnum.INPUT_NONE:
					return System.Enum.Parse(tsType, "INPUT_NONE");
				case ParameterUnitTypeEnum.INPUT_RATIO_UNIT:
					return System.Enum.Parse(tsType, "INPUT_RATIO_UNIT");
				case ParameterUnitTypeEnum.INPUT_STRAIN_UNIT:
					return System.Enum.Parse(tsType, "INPUT_STRAIN_UNIT");
				case ParameterUnitTypeEnum.INPUT_ANGLE_UNIT:
					return System.Enum.Parse(tsType, "INPUT_ANGLE_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_ANGLE_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_ANGLE_UNIT");
				case ParameterUnitTypeEnum.INPUT_SECTION_ANGLE_UNIT:
					return System.Enum.Parse(tsType, "INPUT_SECTION_ANGLE_UNIT");
				case ParameterUnitTypeEnum.INPUT_LENGTH_UNIT:
					return System.Enum.Parse(tsType, "INPUT_LENGTH_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_LENGTH_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_LENGTH_UNIT");
				case ParameterUnitTypeEnum.INPUT_DEFORMATION_UNIT:
					return System.Enum.Parse(tsType, "INPUT_DEFORMATION_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_DEFORMATION_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_DEFORMATION_UNIT");
				case ParameterUnitTypeEnum.INPUT_DIMENSION_UNIT:
					return System.Enum.Parse(tsType, "INPUT_DIMENSION_UNIT");
				case ParameterUnitTypeEnum.INPUT_RADIUSOFINERTIA_UNIT:
					return System.Enum.Parse(tsType, "INPUT_RADIUSOFINERTIA_UNIT");
				case ParameterUnitTypeEnum.INPUT_AREA_UNIT:
					return System.Enum.Parse(tsType, "INPUT_AREA_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_REINFAREA_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_REINFAREA_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_TRANSVREINF_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_TRANSVREINF_UNIT");
				case ParameterUnitTypeEnum.INPUT_AREAPERLENGTH_UNIT:
					return System.Enum.Parse(tsType, "INPUT_AREAPERLENGTH_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_VOLUME_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_VOLUME_UNIT");
				case ParameterUnitTypeEnum.INPUT_SECTIONMODULUS_UNIT:
					return System.Enum.Parse(tsType, "INPUT_SECTIONMODULUS_UNIT");
				case ParameterUnitTypeEnum.INPUT_VOLUME_UNIT:
					return System.Enum.Parse(tsType, "INPUT_VOLUME_UNIT");
				case ParameterUnitTypeEnum.INPUT_MOMENTOFINERTIA_UNIT:
					return System.Enum.Parse(tsType, "INPUT_MOMENTOFINERTIA_UNIT");
				case ParameterUnitTypeEnum.INPUT_TORSIONCONSTANT_UNIT:
					return System.Enum.Parse(tsType, "INPUT_TORSIONCONSTANT_UNIT");
				case ParameterUnitTypeEnum.INPUT_WARPINGCONSTANT_UNIT:
					return System.Enum.Parse(tsType, "INPUT_WARPINGCONSTANT_UNIT");
				case ParameterUnitTypeEnum.INPUT_FORCE_UNIT:
					return System.Enum.Parse(tsType, "INPUT_FORCE_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_FORCE_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_FORCE_UNIT");
				case ParameterUnitTypeEnum.INPUT_WEIGHT_UNIT:
					return System.Enum.Parse(tsType, "INPUT_WEIGHT_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_WEIGHT_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_WEIGHT_UNIT");
				case ParameterUnitTypeEnum.INPUT_DISTRIBLOAD_UNIT:
					return System.Enum.Parse(tsType, "INPUT_DISTRIBLOAD_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_DISTRIBLOAD_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_DISTRIBLOAD_UNIT");
				case ParameterUnitTypeEnum.INPUT_SPRINGCONSTANT_UNIT:
					return System.Enum.Parse(tsType, "INPUT_SPRINGCONSTANT_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_MASSPERLENGTH_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_MASSPERLENGTH_UNIT");
				case ParameterUnitTypeEnum.INPUT_SURFACELOAD_UNIT:
					return System.Enum.Parse(tsType, "INPUT_SURFACELOAD_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_SURFACELOAD_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_SURFACELOAD_UNIT");
				case ParameterUnitTypeEnum.INPUT_STRENGTH_UNIT:
					return System.Enum.Parse(tsType, "INPUT_STRENGTH_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_STRESS_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_STRESS_UNIT");
				case ParameterUnitTypeEnum.INPUT_MODULUS_UNIT:
					return System.Enum.Parse(tsType, "INPUT_MODULUS_UNIT");
				case ParameterUnitTypeEnum.INPUT_DENSITY_UNIT:
					return System.Enum.Parse(tsType, "INPUT_DENSITY_UNIT");
				case ParameterUnitTypeEnum.INPUT_MOMENT_UNIT:
					return System.Enum.Parse(tsType, "INPUT_MOMENT_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_MOMENT_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_MOMENT_UNIT");
				case ParameterUnitTypeEnum.INPUT_DISTRIBMOMENT_UNIT:
					return System.Enum.Parse(tsType, "INPUT_DISTRIBMOMENT_UNIT");
				case ParameterUnitTypeEnum.INPUT_ROTSPRINGCONST_UNIT:
					return System.Enum.Parse(tsType, "INPUT_ROTSPRINGCONST_UNIT");
				case ParameterUnitTypeEnum.INPUT_TEMPERATURE_UNIT:
					return System.Enum.Parse(tsType, "INPUT_TEMPERATURE_UNIT");
				case ParameterUnitTypeEnum.OUTPUT_TEMPERATURE_UNIT:
					return System.Enum.Parse(tsType, "OUTPUT_TEMPERATURE_UNIT");
				case ParameterUnitTypeEnum.INPUT_THERMDILATCOEFF_UNIT:
					return System.Enum.Parse(tsType, "INPUT_THERMDILATCOEFF_UNIT");
				case ParameterUnitTypeEnum.INPUT_FACTOR_UNIT:
					return System.Enum.Parse(tsType, "INPUT_FACTOR_UNIT");
				case ParameterUnitTypeEnum.INPUT_DATE_UNIT:
					return System.Enum.Parse(tsType, "INPUT_DATE_UNIT");
				case ParameterUnitTypeEnum.INPUT_DATE_TIME_MIN_UNIT:
					return System.Enum.Parse(tsType, "INPUT_DATE_TIME_MIN_UNIT");
				case ParameterUnitTypeEnum.INPUT_DATE_TIME_SEC_UNIT:
					return System.Enum.Parse(tsType, "INPUT_DATE_TIME_SEC_UNIT");
				case ParameterUnitTypeEnum.INPUT_LENGTH_FRACTIONAL_IMPERIAL:
					return System.Enum.Parse(tsType, "INPUT_LENGTH_FRACTIONAL_IMPERIAL");
				case ParameterUnitTypeEnum.OUTPUT_LENGTH_FRACTIONAL_IMPERIAL:
					return System.Enum.Parse(tsType, "OUTPUT_LENGTH_FRACTIONAL_IMPERIAL");
				case ParameterUnitTypeEnum.OUTPUT_DEFORMATION_FRACTIONAL_IMPERIAL:
					return System.Enum.Parse(tsType, "OUTPUT_DEFORMATION_FRACTIONAL_IMPERIAL");
				case ParameterUnitTypeEnum.INPUT_DIMENSION_FRACTIONAL_IMPERIAL:
					return System.Enum.Parse(tsType, "INPUT_DIMENSION_FRACTIONAL_IMPERIAL");
				case ParameterUnitTypeEnum.INPUT_RADIUSOFINERTIA_FRACTIONAL_IMPERIAL:
					return System.Enum.Parse(tsType, "INPUT_RADIUSOFINERTIA_FRACTIONAL_IMPERIAL");
				case ParameterUnitTypeEnum.INPUT_BOOLEAN:
					return System.Enum.Parse(tsType, "INPUT_BOOLEAN");
				case ParameterUnitTypeEnum.INPUT_INTEGER:
					return System.Enum.Parse(tsType, "INPUT_INTEGER");
				case ParameterUnitTypeEnum.INPUT_STRING:
					return System.Enum.Parse(tsType, "INPUT_STRING");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ParameterUnitTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("INPUT_NONE", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_NONE;
			else if (tsEnumValue.Equals("INPUT_RATIO_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_RATIO_UNIT;
			else if (tsEnumValue.Equals("INPUT_STRAIN_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_STRAIN_UNIT;
			else if (tsEnumValue.Equals("INPUT_ANGLE_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_ANGLE_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_ANGLE_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_ANGLE_UNIT;
			else if (tsEnumValue.Equals("INPUT_SECTION_ANGLE_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_SECTION_ANGLE_UNIT;
			else if (tsEnumValue.Equals("INPUT_LENGTH_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_LENGTH_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_LENGTH_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_LENGTH_UNIT;
			else if (tsEnumValue.Equals("INPUT_DEFORMATION_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_DEFORMATION_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_DEFORMATION_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_DEFORMATION_UNIT;
			else if (tsEnumValue.Equals("INPUT_DIMENSION_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_DIMENSION_UNIT;
			else if (tsEnumValue.Equals("INPUT_RADIUSOFINERTIA_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_RADIUSOFINERTIA_UNIT;
			else if (tsEnumValue.Equals("INPUT_AREA_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_AREA_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_REINFAREA_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_REINFAREA_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_TRANSVREINF_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_TRANSVREINF_UNIT;
			else if (tsEnumValue.Equals("INPUT_AREAPERLENGTH_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_AREAPERLENGTH_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_VOLUME_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_VOLUME_UNIT;
			else if (tsEnumValue.Equals("INPUT_SECTIONMODULUS_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_SECTIONMODULUS_UNIT;
			else if (tsEnumValue.Equals("INPUT_VOLUME_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_VOLUME_UNIT;
			else if (tsEnumValue.Equals("INPUT_MOMENTOFINERTIA_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_MOMENTOFINERTIA_UNIT;
			else if (tsEnumValue.Equals("INPUT_TORSIONCONSTANT_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_TORSIONCONSTANT_UNIT;
			else if (tsEnumValue.Equals("INPUT_WARPINGCONSTANT_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_WARPINGCONSTANT_UNIT;
			else if (tsEnumValue.Equals("INPUT_FORCE_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_FORCE_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_FORCE_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_FORCE_UNIT;
			else if (tsEnumValue.Equals("INPUT_WEIGHT_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_WEIGHT_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_WEIGHT_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_WEIGHT_UNIT;
			else if (tsEnumValue.Equals("INPUT_DISTRIBLOAD_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_DISTRIBLOAD_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_DISTRIBLOAD_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_DISTRIBLOAD_UNIT;
			else if (tsEnumValue.Equals("INPUT_SPRINGCONSTANT_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_SPRINGCONSTANT_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_MASSPERLENGTH_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_MASSPERLENGTH_UNIT;
			else if (tsEnumValue.Equals("INPUT_SURFACELOAD_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_SURFACELOAD_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_SURFACELOAD_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_SURFACELOAD_UNIT;
			else if (tsEnumValue.Equals("INPUT_STRENGTH_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_STRENGTH_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_STRESS_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_STRESS_UNIT;
			else if (tsEnumValue.Equals("INPUT_MODULUS_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_MODULUS_UNIT;
			else if (tsEnumValue.Equals("INPUT_DENSITY_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_DENSITY_UNIT;
			else if (tsEnumValue.Equals("INPUT_MOMENT_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_MOMENT_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_MOMENT_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_MOMENT_UNIT;
			else if (tsEnumValue.Equals("INPUT_DISTRIBMOMENT_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_DISTRIBMOMENT_UNIT;
			else if (tsEnumValue.Equals("INPUT_ROTSPRINGCONST_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_ROTSPRINGCONST_UNIT;
			else if (tsEnumValue.Equals("INPUT_TEMPERATURE_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_TEMPERATURE_UNIT;
			else if (tsEnumValue.Equals("OUTPUT_TEMPERATURE_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_TEMPERATURE_UNIT;
			else if (tsEnumValue.Equals("INPUT_THERMDILATCOEFF_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_THERMDILATCOEFF_UNIT;
			else if (tsEnumValue.Equals("INPUT_FACTOR_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_FACTOR_UNIT;
			else if (tsEnumValue.Equals("INPUT_DATE_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_DATE_UNIT;
			else if (tsEnumValue.Equals("INPUT_DATE_TIME_MIN_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_DATE_TIME_MIN_UNIT;
			else if (tsEnumValue.Equals("INPUT_DATE_TIME_SEC_UNIT", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_DATE_TIME_SEC_UNIT;
			else if (tsEnumValue.Equals("INPUT_LENGTH_FRACTIONAL_IMPERIAL", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_LENGTH_FRACTIONAL_IMPERIAL;
			else if (tsEnumValue.Equals("OUTPUT_LENGTH_FRACTIONAL_IMPERIAL", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_LENGTH_FRACTIONAL_IMPERIAL;
			else if (tsEnumValue.Equals("OUTPUT_DEFORMATION_FRACTIONAL_IMPERIAL", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.OUTPUT_DEFORMATION_FRACTIONAL_IMPERIAL;
			else if (tsEnumValue.Equals("INPUT_DIMENSION_FRACTIONAL_IMPERIAL", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_DIMENSION_FRACTIONAL_IMPERIAL;
			else if (tsEnumValue.Equals("INPUT_RADIUSOFINERTIA_FRACTIONAL_IMPERIAL", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_RADIUSOFINERTIA_FRACTIONAL_IMPERIAL;
			else if (tsEnumValue.Equals("INPUT_BOOLEAN", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_BOOLEAN;
			else if (tsEnumValue.Equals("INPUT_INTEGER", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_INTEGER;
			else if (tsEnumValue.Equals("INPUT_STRING", System.StringComparison.InvariantCulture))
				return ParameterUnitTypeEnum.INPUT_STRING;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ProfileItemParameter_
    {
        public static dynamic GetTSObject(ProfileItemParameter dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ProfileItemParameter FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.ProfileItemParameter)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ProfileItemParameterArray_
    {
        public static dynamic GetTSObject(ProfileItemParameter[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ProfileItemParameter_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ProfileItemParameter[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ProfileItemParameter>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ProfileItemParameter_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
