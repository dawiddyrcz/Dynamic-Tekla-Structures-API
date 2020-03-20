//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public sealed class ModuleManager 
    {

		public Dynamic.Tekla.Structures.ModuleManager.ProgramConfigurationEnum Configuration
		{
			get => Dynamic.Tekla.Structures.ModuleManager.ProgramConfigurationEnum_.FromTSObject(modulemanager.Configuration);
			set { modulemanager.Configuration = Dynamic.Tekla.Structures.ModuleManager.ProgramConfigurationEnum_.GetTSObject(value); }
		}

		public System.Boolean MultimaterialModeling
		{
			get => modulemanager.MultimaterialModeling;
			set { modulemanager.MultimaterialModeling = value; }
		}

		public System.Boolean LoadModeling
		{
			get => modulemanager.LoadModeling;
			set { modulemanager.LoadModeling = value; }
		}

		public System.Boolean SteelDetailing
		{
			get => modulemanager.SteelDetailing;
			set { modulemanager.SteelDetailing = value; }
		}

		public System.Boolean ConcreteDetailing
		{
			get => modulemanager.ConcreteDetailing;
			set { modulemanager.ConcreteDetailing = value; }
		}

		public System.Boolean RebarModeling
		{
			get => modulemanager.RebarModeling;
			set { modulemanager.RebarModeling = value; }
		}

		public System.Boolean AnalysisAndDesign
		{
			get => modulemanager.AnalysisAndDesign;
			set { modulemanager.AnalysisAndDesign = value; }
		}

		public System.Boolean TaskManagement
		{
			get => modulemanager.TaskManagement;
			set { modulemanager.TaskManagement = value; }
		}

        

        internal dynamic modulemanager;
        
        public ModuleManager()
        {
            this.modulemanager =  TSActivator.CreateInstance("Tekla.Structures.ModuleManager");
        }

        internal ModuleManager(dynamic tsObject)
        {
            this.modulemanager = tsObject;
        }




    public enum ProgramConfigurationEnum
    {
			CONFIGURATION_VIEWER,
			CONFIGURATION_PRODUCTION_PLANNER,
			CONFIGURATION_DRAFTER,
			CONFIGURATION_PROJECT_MANAGEMENT,
			CONFIGURATION_ENGINEERING,
			CONFIGURATION_REINFORCED_CONCRETE_DETAILING,
			CONFIGURATION_PRECAST_CONCRETE_DETAILING,
			CONFIGURATION_STEEL_DETAILING,
			CONFIGURATION_FULL,
			CONFIGURATION_PRIMARY,
			CONFIGURATION_EDUCATIONAL,
			CONFIGURATION_DEVELOPER,
			CONFIGURATION_CONSTRUCTION_VIEWER,
			CONFIGURATION_PARTNER,
			CONFIGURATION_EPM_MODELER        
    }

    internal static class ProgramConfigurationEnum_
    {
        public static dynamic GetTSObject(ProgramConfigurationEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.ProgramConfigurationEnum");

            switch (dynEnum)
            {
				case ProgramConfigurationEnum.CONFIGURATION_VIEWER:
					return System.Enum.Parse(tsType, "CONFIGURATION_VIEWER");
				case ProgramConfigurationEnum.CONFIGURATION_PRODUCTION_PLANNER:
					return System.Enum.Parse(tsType, "CONFIGURATION_PRODUCTION_PLANNER");
				case ProgramConfigurationEnum.CONFIGURATION_DRAFTER:
					return System.Enum.Parse(tsType, "CONFIGURATION_DRAFTER");
				case ProgramConfigurationEnum.CONFIGURATION_PROJECT_MANAGEMENT:
					return System.Enum.Parse(tsType, "CONFIGURATION_PROJECT_MANAGEMENT");
				case ProgramConfigurationEnum.CONFIGURATION_ENGINEERING:
					return System.Enum.Parse(tsType, "CONFIGURATION_ENGINEERING");
				case ProgramConfigurationEnum.CONFIGURATION_REINFORCED_CONCRETE_DETAILING:
					return System.Enum.Parse(tsType, "CONFIGURATION_REINFORCED_CONCRETE_DETAILING");
				case ProgramConfigurationEnum.CONFIGURATION_PRECAST_CONCRETE_DETAILING:
					return System.Enum.Parse(tsType, "CONFIGURATION_PRECAST_CONCRETE_DETAILING");
				case ProgramConfigurationEnum.CONFIGURATION_STEEL_DETAILING:
					return System.Enum.Parse(tsType, "CONFIGURATION_STEEL_DETAILING");
				case ProgramConfigurationEnum.CONFIGURATION_FULL:
					return System.Enum.Parse(tsType, "CONFIGURATION_FULL");
				case ProgramConfigurationEnum.CONFIGURATION_PRIMARY:
					return System.Enum.Parse(tsType, "CONFIGURATION_PRIMARY");
				case ProgramConfigurationEnum.CONFIGURATION_EDUCATIONAL:
					return System.Enum.Parse(tsType, "CONFIGURATION_EDUCATIONAL");
				case ProgramConfigurationEnum.CONFIGURATION_DEVELOPER:
					return System.Enum.Parse(tsType, "CONFIGURATION_DEVELOPER");
				case ProgramConfigurationEnum.CONFIGURATION_CONSTRUCTION_VIEWER:
					return System.Enum.Parse(tsType, "CONFIGURATION_CONSTRUCTION_VIEWER");
				case ProgramConfigurationEnum.CONFIGURATION_PARTNER:
					return System.Enum.Parse(tsType, "CONFIGURATION_PARTNER");
				case ProgramConfigurationEnum.CONFIGURATION_EPM_MODELER:
					return System.Enum.Parse(tsType, "CONFIGURATION_EPM_MODELER");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ProgramConfigurationEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CONFIGURATION_VIEWER", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_VIEWER;
			else if (tsEnumValue.Equals("CONFIGURATION_PRODUCTION_PLANNER", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_PRODUCTION_PLANNER;
			else if (tsEnumValue.Equals("CONFIGURATION_DRAFTER", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_DRAFTER;
			else if (tsEnumValue.Equals("CONFIGURATION_PROJECT_MANAGEMENT", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_PROJECT_MANAGEMENT;
			else if (tsEnumValue.Equals("CONFIGURATION_ENGINEERING", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_ENGINEERING;
			else if (tsEnumValue.Equals("CONFIGURATION_REINFORCED_CONCRETE_DETAILING", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_REINFORCED_CONCRETE_DETAILING;
			else if (tsEnumValue.Equals("CONFIGURATION_PRECAST_CONCRETE_DETAILING", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_PRECAST_CONCRETE_DETAILING;
			else if (tsEnumValue.Equals("CONFIGURATION_STEEL_DETAILING", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_STEEL_DETAILING;
			else if (tsEnumValue.Equals("CONFIGURATION_FULL", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_FULL;
			else if (tsEnumValue.Equals("CONFIGURATION_PRIMARY", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_PRIMARY;
			else if (tsEnumValue.Equals("CONFIGURATION_EDUCATIONAL", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_EDUCATIONAL;
			else if (tsEnumValue.Equals("CONFIGURATION_DEVELOPER", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_DEVELOPER;
			else if (tsEnumValue.Equals("CONFIGURATION_CONSTRUCTION_VIEWER", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_CONSTRUCTION_VIEWER;
			else if (tsEnumValue.Equals("CONFIGURATION_PARTNER", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_PARTNER;
			else if (tsEnumValue.Equals("CONFIGURATION_EPM_MODELER", System.StringComparison.InvariantCulture))
				return ProgramConfigurationEnum.CONFIGURATION_EPM_MODELER;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ModuleManager_
    {
        public static dynamic GetTSObject(ModuleManager dynObject)
        {
            return dynObject.modulemanager;
        }

        public static ModuleManager FromTSObject(dynamic tsObject)
        {
            return new ModuleManager(tsObject);
        }
    }


}
    
