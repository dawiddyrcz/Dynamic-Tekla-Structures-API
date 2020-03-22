/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LoadGroup  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.String GroupName
		{
			get => teklaObject.GroupName;
			set { teklaObject.GroupName = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup.LoadGroupType GroupType
		{
			get => Dynamic.Tekla.Structures.Model.LoadGroup.LoadGroupType_.FromTSObject(teklaObject.GroupType);
			set { teklaObject.GroupType = Dynamic.Tekla.Structures.Model.LoadGroup.LoadGroupType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup.LoadGroupDirection Direction
		{
			get => Dynamic.Tekla.Structures.Model.LoadGroup.LoadGroupDirection_.FromTSObject(teklaObject.Direction);
			set { teklaObject.Direction = Dynamic.Tekla.Structures.Model.LoadGroup.LoadGroupDirection_.GetTSObject(value); }
		}

		public System.Int32 Compatible
		{
			get => teklaObject.Compatible;
			set { teklaObject.Compatible = value; }
		}

		public System.Int32 Incompatible
		{
			get => teklaObject.Incompatible;
			set { teklaObject.Incompatible = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup.Colors Color
		{
			get => Dynamic.Tekla.Structures.Model.LoadGroup.Colors_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Model.LoadGroup.Colors_.GetTSObject(value); }
		}

        

        

		public LoadGroup()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadGroup");
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}




    public enum LoadGroupType
    {
			EUROCODE_DEFAULT_GROUP,
			EUROCODE_SELF_WEIGHT,
			EUROCODE_PERMANENT_LOAD,
			EUROCODE_PRE_STRESS_LOAD,
			EUROCODE_LIVE_LOAD_HOUSING,
			EUROCODE_LIVE_LOAD_PUBLIC_BUILDINGS,
			EUROCODE_LIVE_LOAD_THEATRES_RESTAURANTS,
			EUROCODE_LIVE_LOAD_WAREHOUSES,
			EUROCODE_LIVE_LOAD_STORAGE_BUILDINGS,
			EUROCODE_TRAFFIC_LOAD_LIGHT_VEHICLES,
			EUROCODE_TRAFFIC_LOAD_HEAVY_VEHICLES,
			EUROCODE_TRAFFIC_LOAD_ROOFS,
			EUROCODE_SNOW_LOAD,
			EUROCODE_WIND_LOAD,
			EUROCODE_FORCES_DUE_TO_TEMPERATURE_EFFECTS,
			EUROCODE_IMPERFECTION_LOAD_DUE_TO_DEAD_LOADS,
			EUROCODE_IMPERFECTION_LOAD_DUE_TO_LIVE_LOADS,
			EUROCODE_IMPERFECTION_LOAD_DUE_TO_SNOW_LOADS,
			EUROCODE_ACCIDENTAL_LOAD,
			EUROCODE_EARTHQUAKE_LOAD,
			BRITISH_CODE_DEAD_LOAD_ALONE,
			BRITISH_CODE_DEADLOAD,
			BRITISH_CODE_IMPOSED_LOAD,
			BRITISH_CODE_WIND_LOAD,
			BRITISH_CODE_TEMPERATURE_LOAD,
			BRITISH_CODE_VERTICAL_CRANE_LOAD,
			BRITISH_CODE_HORIZONTAL_CRANE_LOAD,
			AISC_DEAD_LOAD_ALONE,
			AISC_DEAD_LOAD,
			AISC_LIVE_LOAD,
			AISC_ROOF_LIVE_LOAD,
			AISC_WIND_LOAD,
			AISC_SNOW_LOAD,
			AISC_RAINWATER_LOAD,
			AISC_EARTHQUAKE_LOAD,
			CM66_PERMANENT_LOAD_FR,
			CM66_EXPLOITATION_LOAD_FR,
			CM66_TEMPERATURE_LOAD_FR,
			CM66_WIND_LOAD_FR,
			CM66_SNOW_LOAD_FR,
			CM66_SEISMIC_LOAD_HORIZONTAL_FR,
			CM66_SEISMIC_LOAD_VERTICAL_FR,
			BAEL91_PERMANENT_LOAD_FR,
			BAEL91_EXPLOITATION_LOAD_FR,
			BAEL91_TEMPERATURE_LOAD_FR,
			BAEL91_WIND_LOAD_FR,
			BAEL91_SNOW_LOAD_FR,
			BAEL91_SEISMIC_LOAD_FR,
			BAEL91_ACCIDENTAL_LOAD_FR,
			UBC_DEAD_LOAD,
			UBC_LIVE_LOAD,
			UBC_ROOF_LIVE_LOAD,
			UBC_WIND_LOAD,
			UBC_SNOW_LOAD,
			UBC_TEMPERATURE_LOAD,
			UBC_FLUIDS_LOAD,
			UBC_SOIL_LOAD,
			UBC_PONDING_LOAD,
			UBC_SEISMIC_LOAD,
			IBC_DEAD_LOAD,
			IBC_LIVE_LOAD,
			IBC_ROOF_LIVE_LOAD,
			IBC_WIND_LOAD,
			IBC_SNOW_LOAD,
			IBC_TEMPERATURE_LOAD,
			IBC_FLUIDS_LOAD,
			IBC_SOIL_LOAD,
			IBC_RAIN_LOAD,
			IBC_PONDING_LOAD,
			IBC_SEISMIC_LOAD,
			ACI_DEAD_LOAD,
			ACI_LIVE_LOAD,
			ACI_ROOF_LIVE_LOAD,
			ACI_WIND_LOAD,
			ACI_SEISMIC_LOAD,
			ACI_SNOW_LOAD,
			ACI_FLUIDS_LOAD,
			ACI_SOIL_LOAD,
			ACI_RAIN_LOAD,
			ACI_TEMPERATURE_LOAD        
    }

    internal static class LoadGroupType_
    {
        public static dynamic GetTSObject(LoadGroupType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoadGroup.LoadGroupType").GetType();

            switch (dynEnum)
            {
				case LoadGroupType.EUROCODE_DEFAULT_GROUP:
					return System.Enum.Parse(tsType, "EUROCODE_DEFAULT_GROUP");
				case LoadGroupType.EUROCODE_SELF_WEIGHT:
					return System.Enum.Parse(tsType, "EUROCODE_SELF_WEIGHT");
				case LoadGroupType.EUROCODE_PERMANENT_LOAD:
					return System.Enum.Parse(tsType, "EUROCODE_PERMANENT_LOAD");
				case LoadGroupType.EUROCODE_PRE_STRESS_LOAD:
					return System.Enum.Parse(tsType, "EUROCODE_PRE_STRESS_LOAD");
				case LoadGroupType.EUROCODE_LIVE_LOAD_HOUSING:
					return System.Enum.Parse(tsType, "EUROCODE_LIVE_LOAD_HOUSING");
				case LoadGroupType.EUROCODE_LIVE_LOAD_PUBLIC_BUILDINGS:
					return System.Enum.Parse(tsType, "EUROCODE_LIVE_LOAD_PUBLIC_BUILDINGS");
				case LoadGroupType.EUROCODE_LIVE_LOAD_THEATRES_RESTAURANTS:
					return System.Enum.Parse(tsType, "EUROCODE_LIVE_LOAD_THEATRES_RESTAURANTS");
				case LoadGroupType.EUROCODE_LIVE_LOAD_WAREHOUSES:
					return System.Enum.Parse(tsType, "EUROCODE_LIVE_LOAD_WAREHOUSES");
				case LoadGroupType.EUROCODE_LIVE_LOAD_STORAGE_BUILDINGS:
					return System.Enum.Parse(tsType, "EUROCODE_LIVE_LOAD_STORAGE_BUILDINGS");
				case LoadGroupType.EUROCODE_TRAFFIC_LOAD_LIGHT_VEHICLES:
					return System.Enum.Parse(tsType, "EUROCODE_TRAFFIC_LOAD_LIGHT_VEHICLES");
				case LoadGroupType.EUROCODE_TRAFFIC_LOAD_HEAVY_VEHICLES:
					return System.Enum.Parse(tsType, "EUROCODE_TRAFFIC_LOAD_HEAVY_VEHICLES");
				case LoadGroupType.EUROCODE_TRAFFIC_LOAD_ROOFS:
					return System.Enum.Parse(tsType, "EUROCODE_TRAFFIC_LOAD_ROOFS");
				case LoadGroupType.EUROCODE_SNOW_LOAD:
					return System.Enum.Parse(tsType, "EUROCODE_SNOW_LOAD");
				case LoadGroupType.EUROCODE_WIND_LOAD:
					return System.Enum.Parse(tsType, "EUROCODE_WIND_LOAD");
				case LoadGroupType.EUROCODE_FORCES_DUE_TO_TEMPERATURE_EFFECTS:
					return System.Enum.Parse(tsType, "EUROCODE_FORCES_DUE_TO_TEMPERATURE_EFFECTS");
				case LoadGroupType.EUROCODE_IMPERFECTION_LOAD_DUE_TO_DEAD_LOADS:
					return System.Enum.Parse(tsType, "EUROCODE_IMPERFECTION_LOAD_DUE_TO_DEAD_LOADS");
				case LoadGroupType.EUROCODE_IMPERFECTION_LOAD_DUE_TO_LIVE_LOADS:
					return System.Enum.Parse(tsType, "EUROCODE_IMPERFECTION_LOAD_DUE_TO_LIVE_LOADS");
				case LoadGroupType.EUROCODE_IMPERFECTION_LOAD_DUE_TO_SNOW_LOADS:
					return System.Enum.Parse(tsType, "EUROCODE_IMPERFECTION_LOAD_DUE_TO_SNOW_LOADS");
				case LoadGroupType.EUROCODE_ACCIDENTAL_LOAD:
					return System.Enum.Parse(tsType, "EUROCODE_ACCIDENTAL_LOAD");
				case LoadGroupType.EUROCODE_EARTHQUAKE_LOAD:
					return System.Enum.Parse(tsType, "EUROCODE_EARTHQUAKE_LOAD");
				case LoadGroupType.BRITISH_CODE_DEAD_LOAD_ALONE:
					return System.Enum.Parse(tsType, "BRITISH_CODE_DEAD_LOAD_ALONE");
				case LoadGroupType.BRITISH_CODE_DEADLOAD:
					return System.Enum.Parse(tsType, "BRITISH_CODE_DEADLOAD");
				case LoadGroupType.BRITISH_CODE_IMPOSED_LOAD:
					return System.Enum.Parse(tsType, "BRITISH_CODE_IMPOSED_LOAD");
				case LoadGroupType.BRITISH_CODE_WIND_LOAD:
					return System.Enum.Parse(tsType, "BRITISH_CODE_WIND_LOAD");
				case LoadGroupType.BRITISH_CODE_TEMPERATURE_LOAD:
					return System.Enum.Parse(tsType, "BRITISH_CODE_TEMPERATURE_LOAD");
				case LoadGroupType.BRITISH_CODE_VERTICAL_CRANE_LOAD:
					return System.Enum.Parse(tsType, "BRITISH_CODE_VERTICAL_CRANE_LOAD");
				case LoadGroupType.BRITISH_CODE_HORIZONTAL_CRANE_LOAD:
					return System.Enum.Parse(tsType, "BRITISH_CODE_HORIZONTAL_CRANE_LOAD");
				case LoadGroupType.AISC_DEAD_LOAD_ALONE:
					return System.Enum.Parse(tsType, "AISC_DEAD_LOAD_ALONE");
				case LoadGroupType.AISC_DEAD_LOAD:
					return System.Enum.Parse(tsType, "AISC_DEAD_LOAD");
				case LoadGroupType.AISC_LIVE_LOAD:
					return System.Enum.Parse(tsType, "AISC_LIVE_LOAD");
				case LoadGroupType.AISC_ROOF_LIVE_LOAD:
					return System.Enum.Parse(tsType, "AISC_ROOF_LIVE_LOAD");
				case LoadGroupType.AISC_WIND_LOAD:
					return System.Enum.Parse(tsType, "AISC_WIND_LOAD");
				case LoadGroupType.AISC_SNOW_LOAD:
					return System.Enum.Parse(tsType, "AISC_SNOW_LOAD");
				case LoadGroupType.AISC_RAINWATER_LOAD:
					return System.Enum.Parse(tsType, "AISC_RAINWATER_LOAD");
				case LoadGroupType.AISC_EARTHQUAKE_LOAD:
					return System.Enum.Parse(tsType, "AISC_EARTHQUAKE_LOAD");
				case LoadGroupType.CM66_PERMANENT_LOAD_FR:
					return System.Enum.Parse(tsType, "CM66_PERMANENT_LOAD_FR");
				case LoadGroupType.CM66_EXPLOITATION_LOAD_FR:
					return System.Enum.Parse(tsType, "CM66_EXPLOITATION_LOAD_FR");
				case LoadGroupType.CM66_TEMPERATURE_LOAD_FR:
					return System.Enum.Parse(tsType, "CM66_TEMPERATURE_LOAD_FR");
				case LoadGroupType.CM66_WIND_LOAD_FR:
					return System.Enum.Parse(tsType, "CM66_WIND_LOAD_FR");
				case LoadGroupType.CM66_SNOW_LOAD_FR:
					return System.Enum.Parse(tsType, "CM66_SNOW_LOAD_FR");
				case LoadGroupType.CM66_SEISMIC_LOAD_HORIZONTAL_FR:
					return System.Enum.Parse(tsType, "CM66_SEISMIC_LOAD_HORIZONTAL_FR");
				case LoadGroupType.CM66_SEISMIC_LOAD_VERTICAL_FR:
					return System.Enum.Parse(tsType, "CM66_SEISMIC_LOAD_VERTICAL_FR");
				case LoadGroupType.BAEL91_PERMANENT_LOAD_FR:
					return System.Enum.Parse(tsType, "BAEL91_PERMANENT_LOAD_FR");
				case LoadGroupType.BAEL91_EXPLOITATION_LOAD_FR:
					return System.Enum.Parse(tsType, "BAEL91_EXPLOITATION_LOAD_FR");
				case LoadGroupType.BAEL91_TEMPERATURE_LOAD_FR:
					return System.Enum.Parse(tsType, "BAEL91_TEMPERATURE_LOAD_FR");
				case LoadGroupType.BAEL91_WIND_LOAD_FR:
					return System.Enum.Parse(tsType, "BAEL91_WIND_LOAD_FR");
				case LoadGroupType.BAEL91_SNOW_LOAD_FR:
					return System.Enum.Parse(tsType, "BAEL91_SNOW_LOAD_FR");
				case LoadGroupType.BAEL91_SEISMIC_LOAD_FR:
					return System.Enum.Parse(tsType, "BAEL91_SEISMIC_LOAD_FR");
				case LoadGroupType.BAEL91_ACCIDENTAL_LOAD_FR:
					return System.Enum.Parse(tsType, "BAEL91_ACCIDENTAL_LOAD_FR");
				case LoadGroupType.UBC_DEAD_LOAD:
					return System.Enum.Parse(tsType, "UBC_DEAD_LOAD");
				case LoadGroupType.UBC_LIVE_LOAD:
					return System.Enum.Parse(tsType, "UBC_LIVE_LOAD");
				case LoadGroupType.UBC_ROOF_LIVE_LOAD:
					return System.Enum.Parse(tsType, "UBC_ROOF_LIVE_LOAD");
				case LoadGroupType.UBC_WIND_LOAD:
					return System.Enum.Parse(tsType, "UBC_WIND_LOAD");
				case LoadGroupType.UBC_SNOW_LOAD:
					return System.Enum.Parse(tsType, "UBC_SNOW_LOAD");
				case LoadGroupType.UBC_TEMPERATURE_LOAD:
					return System.Enum.Parse(tsType, "UBC_TEMPERATURE_LOAD");
				case LoadGroupType.UBC_FLUIDS_LOAD:
					return System.Enum.Parse(tsType, "UBC_FLUIDS_LOAD");
				case LoadGroupType.UBC_SOIL_LOAD:
					return System.Enum.Parse(tsType, "UBC_SOIL_LOAD");
				case LoadGroupType.UBC_PONDING_LOAD:
					return System.Enum.Parse(tsType, "UBC_PONDING_LOAD");
				case LoadGroupType.UBC_SEISMIC_LOAD:
					return System.Enum.Parse(tsType, "UBC_SEISMIC_LOAD");
				case LoadGroupType.IBC_DEAD_LOAD:
					return System.Enum.Parse(tsType, "IBC_DEAD_LOAD");
				case LoadGroupType.IBC_LIVE_LOAD:
					return System.Enum.Parse(tsType, "IBC_LIVE_LOAD");
				case LoadGroupType.IBC_ROOF_LIVE_LOAD:
					return System.Enum.Parse(tsType, "IBC_ROOF_LIVE_LOAD");
				case LoadGroupType.IBC_WIND_LOAD:
					return System.Enum.Parse(tsType, "IBC_WIND_LOAD");
				case LoadGroupType.IBC_SNOW_LOAD:
					return System.Enum.Parse(tsType, "IBC_SNOW_LOAD");
				case LoadGroupType.IBC_TEMPERATURE_LOAD:
					return System.Enum.Parse(tsType, "IBC_TEMPERATURE_LOAD");
				case LoadGroupType.IBC_FLUIDS_LOAD:
					return System.Enum.Parse(tsType, "IBC_FLUIDS_LOAD");
				case LoadGroupType.IBC_SOIL_LOAD:
					return System.Enum.Parse(tsType, "IBC_SOIL_LOAD");
				case LoadGroupType.IBC_RAIN_LOAD:
					return System.Enum.Parse(tsType, "IBC_RAIN_LOAD");
				case LoadGroupType.IBC_PONDING_LOAD:
					return System.Enum.Parse(tsType, "IBC_PONDING_LOAD");
				case LoadGroupType.IBC_SEISMIC_LOAD:
					return System.Enum.Parse(tsType, "IBC_SEISMIC_LOAD");
				case LoadGroupType.ACI_DEAD_LOAD:
					return System.Enum.Parse(tsType, "ACI_DEAD_LOAD");
				case LoadGroupType.ACI_LIVE_LOAD:
					return System.Enum.Parse(tsType, "ACI_LIVE_LOAD");
				case LoadGroupType.ACI_ROOF_LIVE_LOAD:
					return System.Enum.Parse(tsType, "ACI_ROOF_LIVE_LOAD");
				case LoadGroupType.ACI_WIND_LOAD:
					return System.Enum.Parse(tsType, "ACI_WIND_LOAD");
				case LoadGroupType.ACI_SEISMIC_LOAD:
					return System.Enum.Parse(tsType, "ACI_SEISMIC_LOAD");
				case LoadGroupType.ACI_SNOW_LOAD:
					return System.Enum.Parse(tsType, "ACI_SNOW_LOAD");
				case LoadGroupType.ACI_FLUIDS_LOAD:
					return System.Enum.Parse(tsType, "ACI_FLUIDS_LOAD");
				case LoadGroupType.ACI_SOIL_LOAD:
					return System.Enum.Parse(tsType, "ACI_SOIL_LOAD");
				case LoadGroupType.ACI_RAIN_LOAD:
					return System.Enum.Parse(tsType, "ACI_RAIN_LOAD");
				case LoadGroupType.ACI_TEMPERATURE_LOAD:
					return System.Enum.Parse(tsType, "ACI_TEMPERATURE_LOAD");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LoadGroupType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EUROCODE_DEFAULT_GROUP", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_DEFAULT_GROUP;
			else if (tsEnumValue.Equals("EUROCODE_SELF_WEIGHT", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_SELF_WEIGHT;
			else if (tsEnumValue.Equals("EUROCODE_PERMANENT_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_PERMANENT_LOAD;
			else if (tsEnumValue.Equals("EUROCODE_PRE_STRESS_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_PRE_STRESS_LOAD;
			else if (tsEnumValue.Equals("EUROCODE_LIVE_LOAD_HOUSING", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_LIVE_LOAD_HOUSING;
			else if (tsEnumValue.Equals("EUROCODE_LIVE_LOAD_PUBLIC_BUILDINGS", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_LIVE_LOAD_PUBLIC_BUILDINGS;
			else if (tsEnumValue.Equals("EUROCODE_LIVE_LOAD_THEATRES_RESTAURANTS", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_LIVE_LOAD_THEATRES_RESTAURANTS;
			else if (tsEnumValue.Equals("EUROCODE_LIVE_LOAD_WAREHOUSES", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_LIVE_LOAD_WAREHOUSES;
			else if (tsEnumValue.Equals("EUROCODE_LIVE_LOAD_STORAGE_BUILDINGS", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_LIVE_LOAD_STORAGE_BUILDINGS;
			else if (tsEnumValue.Equals("EUROCODE_TRAFFIC_LOAD_LIGHT_VEHICLES", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_TRAFFIC_LOAD_LIGHT_VEHICLES;
			else if (tsEnumValue.Equals("EUROCODE_TRAFFIC_LOAD_HEAVY_VEHICLES", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_TRAFFIC_LOAD_HEAVY_VEHICLES;
			else if (tsEnumValue.Equals("EUROCODE_TRAFFIC_LOAD_ROOFS", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_TRAFFIC_LOAD_ROOFS;
			else if (tsEnumValue.Equals("EUROCODE_SNOW_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_SNOW_LOAD;
			else if (tsEnumValue.Equals("EUROCODE_WIND_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_WIND_LOAD;
			else if (tsEnumValue.Equals("EUROCODE_FORCES_DUE_TO_TEMPERATURE_EFFECTS", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_FORCES_DUE_TO_TEMPERATURE_EFFECTS;
			else if (tsEnumValue.Equals("EUROCODE_IMPERFECTION_LOAD_DUE_TO_DEAD_LOADS", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_IMPERFECTION_LOAD_DUE_TO_DEAD_LOADS;
			else if (tsEnumValue.Equals("EUROCODE_IMPERFECTION_LOAD_DUE_TO_LIVE_LOADS", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_IMPERFECTION_LOAD_DUE_TO_LIVE_LOADS;
			else if (tsEnumValue.Equals("EUROCODE_IMPERFECTION_LOAD_DUE_TO_SNOW_LOADS", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_IMPERFECTION_LOAD_DUE_TO_SNOW_LOADS;
			else if (tsEnumValue.Equals("EUROCODE_ACCIDENTAL_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_ACCIDENTAL_LOAD;
			else if (tsEnumValue.Equals("EUROCODE_EARTHQUAKE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.EUROCODE_EARTHQUAKE_LOAD;
			else if (tsEnumValue.Equals("BRITISH_CODE_DEAD_LOAD_ALONE", System.StringComparison.InvariantCulture))
				return LoadGroupType.BRITISH_CODE_DEAD_LOAD_ALONE;
			else if (tsEnumValue.Equals("BRITISH_CODE_DEADLOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.BRITISH_CODE_DEADLOAD;
			else if (tsEnumValue.Equals("BRITISH_CODE_IMPOSED_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.BRITISH_CODE_IMPOSED_LOAD;
			else if (tsEnumValue.Equals("BRITISH_CODE_WIND_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.BRITISH_CODE_WIND_LOAD;
			else if (tsEnumValue.Equals("BRITISH_CODE_TEMPERATURE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.BRITISH_CODE_TEMPERATURE_LOAD;
			else if (tsEnumValue.Equals("BRITISH_CODE_VERTICAL_CRANE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.BRITISH_CODE_VERTICAL_CRANE_LOAD;
			else if (tsEnumValue.Equals("BRITISH_CODE_HORIZONTAL_CRANE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.BRITISH_CODE_HORIZONTAL_CRANE_LOAD;
			else if (tsEnumValue.Equals("AISC_DEAD_LOAD_ALONE", System.StringComparison.InvariantCulture))
				return LoadGroupType.AISC_DEAD_LOAD_ALONE;
			else if (tsEnumValue.Equals("AISC_DEAD_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.AISC_DEAD_LOAD;
			else if (tsEnumValue.Equals("AISC_LIVE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.AISC_LIVE_LOAD;
			else if (tsEnumValue.Equals("AISC_ROOF_LIVE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.AISC_ROOF_LIVE_LOAD;
			else if (tsEnumValue.Equals("AISC_WIND_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.AISC_WIND_LOAD;
			else if (tsEnumValue.Equals("AISC_SNOW_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.AISC_SNOW_LOAD;
			else if (tsEnumValue.Equals("AISC_RAINWATER_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.AISC_RAINWATER_LOAD;
			else if (tsEnumValue.Equals("AISC_EARTHQUAKE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.AISC_EARTHQUAKE_LOAD;
			else if (tsEnumValue.Equals("CM66_PERMANENT_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.CM66_PERMANENT_LOAD_FR;
			else if (tsEnumValue.Equals("CM66_EXPLOITATION_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.CM66_EXPLOITATION_LOAD_FR;
			else if (tsEnumValue.Equals("CM66_TEMPERATURE_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.CM66_TEMPERATURE_LOAD_FR;
			else if (tsEnumValue.Equals("CM66_WIND_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.CM66_WIND_LOAD_FR;
			else if (tsEnumValue.Equals("CM66_SNOW_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.CM66_SNOW_LOAD_FR;
			else if (tsEnumValue.Equals("CM66_SEISMIC_LOAD_HORIZONTAL_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.CM66_SEISMIC_LOAD_HORIZONTAL_FR;
			else if (tsEnumValue.Equals("CM66_SEISMIC_LOAD_VERTICAL_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.CM66_SEISMIC_LOAD_VERTICAL_FR;
			else if (tsEnumValue.Equals("BAEL91_PERMANENT_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.BAEL91_PERMANENT_LOAD_FR;
			else if (tsEnumValue.Equals("BAEL91_EXPLOITATION_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.BAEL91_EXPLOITATION_LOAD_FR;
			else if (tsEnumValue.Equals("BAEL91_TEMPERATURE_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.BAEL91_TEMPERATURE_LOAD_FR;
			else if (tsEnumValue.Equals("BAEL91_WIND_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.BAEL91_WIND_LOAD_FR;
			else if (tsEnumValue.Equals("BAEL91_SNOW_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.BAEL91_SNOW_LOAD_FR;
			else if (tsEnumValue.Equals("BAEL91_SEISMIC_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.BAEL91_SEISMIC_LOAD_FR;
			else if (tsEnumValue.Equals("BAEL91_ACCIDENTAL_LOAD_FR", System.StringComparison.InvariantCulture))
				return LoadGroupType.BAEL91_ACCIDENTAL_LOAD_FR;
			else if (tsEnumValue.Equals("UBC_DEAD_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_DEAD_LOAD;
			else if (tsEnumValue.Equals("UBC_LIVE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_LIVE_LOAD;
			else if (tsEnumValue.Equals("UBC_ROOF_LIVE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_ROOF_LIVE_LOAD;
			else if (tsEnumValue.Equals("UBC_WIND_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_WIND_LOAD;
			else if (tsEnumValue.Equals("UBC_SNOW_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_SNOW_LOAD;
			else if (tsEnumValue.Equals("UBC_TEMPERATURE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_TEMPERATURE_LOAD;
			else if (tsEnumValue.Equals("UBC_FLUIDS_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_FLUIDS_LOAD;
			else if (tsEnumValue.Equals("UBC_SOIL_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_SOIL_LOAD;
			else if (tsEnumValue.Equals("UBC_PONDING_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_PONDING_LOAD;
			else if (tsEnumValue.Equals("UBC_SEISMIC_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.UBC_SEISMIC_LOAD;
			else if (tsEnumValue.Equals("IBC_DEAD_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_DEAD_LOAD;
			else if (tsEnumValue.Equals("IBC_LIVE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_LIVE_LOAD;
			else if (tsEnumValue.Equals("IBC_ROOF_LIVE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_ROOF_LIVE_LOAD;
			else if (tsEnumValue.Equals("IBC_WIND_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_WIND_LOAD;
			else if (tsEnumValue.Equals("IBC_SNOW_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_SNOW_LOAD;
			else if (tsEnumValue.Equals("IBC_TEMPERATURE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_TEMPERATURE_LOAD;
			else if (tsEnumValue.Equals("IBC_FLUIDS_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_FLUIDS_LOAD;
			else if (tsEnumValue.Equals("IBC_SOIL_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_SOIL_LOAD;
			else if (tsEnumValue.Equals("IBC_RAIN_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_RAIN_LOAD;
			else if (tsEnumValue.Equals("IBC_PONDING_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_PONDING_LOAD;
			else if (tsEnumValue.Equals("IBC_SEISMIC_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.IBC_SEISMIC_LOAD;
			else if (tsEnumValue.Equals("ACI_DEAD_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_DEAD_LOAD;
			else if (tsEnumValue.Equals("ACI_LIVE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_LIVE_LOAD;
			else if (tsEnumValue.Equals("ACI_ROOF_LIVE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_ROOF_LIVE_LOAD;
			else if (tsEnumValue.Equals("ACI_WIND_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_WIND_LOAD;
			else if (tsEnumValue.Equals("ACI_SEISMIC_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_SEISMIC_LOAD;
			else if (tsEnumValue.Equals("ACI_SNOW_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_SNOW_LOAD;
			else if (tsEnumValue.Equals("ACI_FLUIDS_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_FLUIDS_LOAD;
			else if (tsEnumValue.Equals("ACI_SOIL_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_SOIL_LOAD;
			else if (tsEnumValue.Equals("ACI_RAIN_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_RAIN_LOAD;
			else if (tsEnumValue.Equals("ACI_TEMPERATURE_LOAD", System.StringComparison.InvariantCulture))
				return LoadGroupType.ACI_TEMPERATURE_LOAD;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum Colors
    {
			BLACK,
			WHITE,
			RED,
			GREEN,
			BLUE,
			CYAN,
			YELLOW,
			MAGENTA        
    }

    internal static class Colors_
    {
        public static dynamic GetTSObject(Colors dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoadGroup.Colors").GetType();

            switch (dynEnum)
            {
				case Colors.BLACK:
					return System.Enum.Parse(tsType, "BLACK");
				case Colors.WHITE:
					return System.Enum.Parse(tsType, "WHITE");
				case Colors.RED:
					return System.Enum.Parse(tsType, "RED");
				case Colors.GREEN:
					return System.Enum.Parse(tsType, "GREEN");
				case Colors.BLUE:
					return System.Enum.Parse(tsType, "BLUE");
				case Colors.CYAN:
					return System.Enum.Parse(tsType, "CYAN");
				case Colors.YELLOW:
					return System.Enum.Parse(tsType, "YELLOW");
				case Colors.MAGENTA:
					return System.Enum.Parse(tsType, "MAGENTA");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Colors FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BLACK", System.StringComparison.InvariantCulture))
				return Colors.BLACK;
			else if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
				return Colors.WHITE;
			else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
				return Colors.RED;
			else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
				return Colors.GREEN;
			else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
				return Colors.BLUE;
			else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
				return Colors.CYAN;
			else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
				return Colors.YELLOW;
			else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
				return Colors.MAGENTA;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum LoadGroupDirection
    {
			DIR_X,
			DIR_Y,
			DIR_Z,
			DIR_NEG_X,
			DIR_NEG_Y,
			DIR_NEG_Z        
    }

    internal static class LoadGroupDirection_
    {
        public static dynamic GetTSObject(LoadGroupDirection dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoadGroup.LoadGroupDirection").GetType();

            switch (dynEnum)
            {
				case LoadGroupDirection.DIR_X:
					return System.Enum.Parse(tsType, "DIR_X");
				case LoadGroupDirection.DIR_Y:
					return System.Enum.Parse(tsType, "DIR_Y");
				case LoadGroupDirection.DIR_Z:
					return System.Enum.Parse(tsType, "DIR_Z");
				case LoadGroupDirection.DIR_NEG_X:
					return System.Enum.Parse(tsType, "DIR_NEG_X");
				case LoadGroupDirection.DIR_NEG_Y:
					return System.Enum.Parse(tsType, "DIR_NEG_Y");
				case LoadGroupDirection.DIR_NEG_Z:
					return System.Enum.Parse(tsType, "DIR_NEG_Z");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LoadGroupDirection FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("DIR_X", System.StringComparison.InvariantCulture))
				return LoadGroupDirection.DIR_X;
			else if (tsEnumValue.Equals("DIR_Y", System.StringComparison.InvariantCulture))
				return LoadGroupDirection.DIR_Y;
			else if (tsEnumValue.Equals("DIR_Z", System.StringComparison.InvariantCulture))
				return LoadGroupDirection.DIR_Z;
			else if (tsEnumValue.Equals("DIR_NEG_X", System.StringComparison.InvariantCulture))
				return LoadGroupDirection.DIR_NEG_X;
			else if (tsEnumValue.Equals("DIR_NEG_Y", System.StringComparison.InvariantCulture))
				return LoadGroupDirection.DIR_NEG_Y;
			else if (tsEnumValue.Equals("DIR_NEG_Z", System.StringComparison.InvariantCulture))
				return LoadGroupDirection.DIR_NEG_Z;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LoadGroup_
    {
        public static dynamic GetTSObject(LoadGroup dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LoadGroup FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.LoadGroup)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
