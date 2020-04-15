/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures
{

    public enum Configuration
    {
			Viewer,
			ProductionPlanner,
			Drafter,
			ProjectManagement,
			Engineering,
			ReinforcedConcreteDetailing,
			PrecastConcreteDetailing,
			SteelDetailing,
			Full,
			Primary,
			Educational,
			Developer,
			ConstructionManagement,
			Partner,
			EPMModeler        
    }

    internal static class Configuration_
    {
        public static dynamic GetTSObject(Configuration dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Configuration").GetType();

            switch (dynEnum)
            {
				case Configuration.Viewer:
					return System.Enum.Parse(tsType, "Viewer");
				case Configuration.ProductionPlanner:
					return System.Enum.Parse(tsType, "ProductionPlanner");
				case Configuration.Drafter:
					return System.Enum.Parse(tsType, "Drafter");
				case Configuration.ProjectManagement:
					return System.Enum.Parse(tsType, "ProjectManagement");
				case Configuration.Engineering:
					return System.Enum.Parse(tsType, "Engineering");
				case Configuration.ReinforcedConcreteDetailing:
					return System.Enum.Parse(tsType, "ReinforcedConcreteDetailing");
				case Configuration.PrecastConcreteDetailing:
					return System.Enum.Parse(tsType, "PrecastConcreteDetailing");
				case Configuration.SteelDetailing:
					return System.Enum.Parse(tsType, "SteelDetailing");
				case Configuration.Full:
					return System.Enum.Parse(tsType, "Full");
				case Configuration.Primary:
					return System.Enum.Parse(tsType, "Primary");
				case Configuration.Educational:
					return System.Enum.Parse(tsType, "Educational");
				case Configuration.Developer:
					return System.Enum.Parse(tsType, "Developer");
				case Configuration.ConstructionManagement:
					return System.Enum.Parse(tsType, "ConstructionManagement");
				case Configuration.Partner:
					return System.Enum.Parse(tsType, "Partner");
				case Configuration.EPMModeler:
					return System.Enum.Parse(tsType, "EPMModeler");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Configuration FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Viewer", System.StringComparison.InvariantCulture))
				return Configuration.Viewer;
			else if (tsEnumValue.Equals("ProductionPlanner", System.StringComparison.InvariantCulture))
				return Configuration.ProductionPlanner;
			else if (tsEnumValue.Equals("Drafter", System.StringComparison.InvariantCulture))
				return Configuration.Drafter;
			else if (tsEnumValue.Equals("ProjectManagement", System.StringComparison.InvariantCulture))
				return Configuration.ProjectManagement;
			else if (tsEnumValue.Equals("Engineering", System.StringComparison.InvariantCulture))
				return Configuration.Engineering;
			else if (tsEnumValue.Equals("ReinforcedConcreteDetailing", System.StringComparison.InvariantCulture))
				return Configuration.ReinforcedConcreteDetailing;
			else if (tsEnumValue.Equals("PrecastConcreteDetailing", System.StringComparison.InvariantCulture))
				return Configuration.PrecastConcreteDetailing;
			else if (tsEnumValue.Equals("SteelDetailing", System.StringComparison.InvariantCulture))
				return Configuration.SteelDetailing;
			else if (tsEnumValue.Equals("Full", System.StringComparison.InvariantCulture))
				return Configuration.Full;
			else if (tsEnumValue.Equals("Primary", System.StringComparison.InvariantCulture))
				return Configuration.Primary;
			else if (tsEnumValue.Equals("Educational", System.StringComparison.InvariantCulture))
				return Configuration.Educational;
			else if (tsEnumValue.Equals("Developer", System.StringComparison.InvariantCulture))
				return Configuration.Developer;
			else if (tsEnumValue.Equals("ConstructionManagement", System.StringComparison.InvariantCulture))
				return Configuration.ConstructionManagement;
			else if (tsEnumValue.Equals("Partner", System.StringComparison.InvariantCulture))
				return Configuration.Partner;
			else if (tsEnumValue.Equals("EPMModeler", System.StringComparison.InvariantCulture))
				return Configuration.EPMModeler;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
