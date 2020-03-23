/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class ModuleManager 
    {

		public Dynamic.Tekla.Structures.ModuleManager.ProgramConfigurationEnum Configuration
		{
			get => Dynamic.Tekla.Structures.ModuleManager.ProgramConfigurationEnum_.FromTSObject(teklaObject.Configuration);
			set { teklaObject.Configuration = Dynamic.Tekla.Structures.ModuleManager.ProgramConfigurationEnum_.GetTSObject(value); }
		}

		public System.Boolean MultimaterialModeling
		{
			get => teklaObject.MultimaterialModeling;
			set { teklaObject.MultimaterialModeling = value; }
		}

		public System.Boolean LoadModeling
		{
			get => teklaObject.LoadModeling;
			set { teklaObject.LoadModeling = value; }
		}

		public System.Boolean SteelDetailing
		{
			get => teklaObject.SteelDetailing;
			set { teklaObject.SteelDetailing = value; }
		}

		public System.Boolean ConcreteDetailing
		{
			get => teklaObject.ConcreteDetailing;
			set { teklaObject.ConcreteDetailing = value; }
		}

		public System.Boolean RebarModeling
		{
			get => teklaObject.RebarModeling;
			set { teklaObject.RebarModeling = value; }
		}

		public System.Boolean AnalysisAndDesign
		{
			get => teklaObject.AnalysisAndDesign;
			set { teklaObject.AnalysisAndDesign = value; }
		}

		public System.Boolean TaskManagement
		{
			get => teklaObject.TaskManagement;
			set { teklaObject.TaskManagement = value; }
		}

        

        internal dynamic teklaObject;

		public ModuleManager()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.ModuleManager");
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
            var tsType = TSActivator.CreateInstance("Tekla.Structures.ModuleManager.ProgramConfigurationEnum").GetType();

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
            return dynObject.teklaObject;
        }

        public static ModuleManager FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.ModuleManager)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
