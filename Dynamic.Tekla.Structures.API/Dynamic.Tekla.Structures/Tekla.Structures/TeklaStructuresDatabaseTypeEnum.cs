/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public enum TeklaStructuresDatabaseTypeEnum
    {
			UNKNOWN,
			POINT,
			PART,
			CONNECTION,
			COMPONENT,
			GRID,
			FITTING,
			BOLT,
			PART_CUT,
			PLANE_CUT,
			WELDING,
			ASSEMBLY,
			CONSTRUCTION_LINE,
			PLANE,
			DRAWING,
			DB_CONNECTION,
			PART_ADD,
			WELD_CUT,
			CONSTRUCTION_CIRCLE,
			CONSTRUCTION_ARC,
			DB_COMPONENT,
			REBAR,
			FOREIGN_OBJECT,
			LOAD_LOAD,
			LOAD_POINT,
			LOAD_LINE,
			LOAD_AREA,
			LOAD_UNIFORM,
			LOAD_GROUP,
			LOAD_TEMPERATURELOAD,
			SURFACE_TREATMENT,
			REBAR_SPLICE,
			ANALYSIS_MODEL,
			EDGE_CHAMFER,
			TASK,
			TASK_DEPENDENCY,
			TASK_WORKTYPE,
			HIERARCHIC_DEFINITION,
			HIERARCHIC_OBJECT,
			DB_POUR_BREAK,
			DB_POUR_OBJECT,
			REBARSET_ADDITION,
			REBARSET_MODIFIER,
			SURFACE_OBJECT,
			BENT_PLATE,
			HELIX,
			DB_POUR_UNIT,
			CONSTRUCTION_POLYCURVE        
    }

    internal static class TeklaStructuresDatabaseTypeEnum_
    {
        public static dynamic GetTSObject(TeklaStructuresDatabaseTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.TeklaStructuresDatabaseTypeEnum").GetType();

            switch (dynEnum)
            {
				case TeklaStructuresDatabaseTypeEnum.UNKNOWN:
					return System.Enum.Parse(tsType, "UNKNOWN");
				case TeklaStructuresDatabaseTypeEnum.POINT:
					return System.Enum.Parse(tsType, "POINT");
				case TeklaStructuresDatabaseTypeEnum.PART:
					return System.Enum.Parse(tsType, "PART");
				case TeklaStructuresDatabaseTypeEnum.CONNECTION:
					return System.Enum.Parse(tsType, "CONNECTION");
				case TeklaStructuresDatabaseTypeEnum.COMPONENT:
					return System.Enum.Parse(tsType, "COMPONENT");
				case TeklaStructuresDatabaseTypeEnum.GRID:
					return System.Enum.Parse(tsType, "GRID");
				case TeklaStructuresDatabaseTypeEnum.FITTING:
					return System.Enum.Parse(tsType, "FITTING");
				case TeklaStructuresDatabaseTypeEnum.BOLT:
					return System.Enum.Parse(tsType, "BOLT");
				case TeklaStructuresDatabaseTypeEnum.PART_CUT:
					return System.Enum.Parse(tsType, "PART_CUT");
				case TeklaStructuresDatabaseTypeEnum.PLANE_CUT:
					return System.Enum.Parse(tsType, "PLANE_CUT");
				case TeklaStructuresDatabaseTypeEnum.WELDING:
					return System.Enum.Parse(tsType, "WELDING");
				case TeklaStructuresDatabaseTypeEnum.ASSEMBLY:
					return System.Enum.Parse(tsType, "ASSEMBLY");
				case TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_LINE:
					return System.Enum.Parse(tsType, "CONSTRUCTION_LINE");
				case TeklaStructuresDatabaseTypeEnum.PLANE:
					return System.Enum.Parse(tsType, "PLANE");
				case TeklaStructuresDatabaseTypeEnum.DRAWING:
					return System.Enum.Parse(tsType, "DRAWING");
				case TeklaStructuresDatabaseTypeEnum.DB_CONNECTION:
					return System.Enum.Parse(tsType, "DB_CONNECTION");
				case TeklaStructuresDatabaseTypeEnum.PART_ADD:
					return System.Enum.Parse(tsType, "PART_ADD");
				case TeklaStructuresDatabaseTypeEnum.WELD_CUT:
					return System.Enum.Parse(tsType, "WELD_CUT");
				case TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_CIRCLE:
					return System.Enum.Parse(tsType, "CONSTRUCTION_CIRCLE");
				case TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_ARC:
					return System.Enum.Parse(tsType, "CONSTRUCTION_ARC");
				case TeklaStructuresDatabaseTypeEnum.DB_COMPONENT:
					return System.Enum.Parse(tsType, "DB_COMPONENT");
				case TeklaStructuresDatabaseTypeEnum.REBAR:
					return System.Enum.Parse(tsType, "REBAR");
				case TeklaStructuresDatabaseTypeEnum.FOREIGN_OBJECT:
					return System.Enum.Parse(tsType, "FOREIGN_OBJECT");
				case TeklaStructuresDatabaseTypeEnum.LOAD_LOAD:
					return System.Enum.Parse(tsType, "LOAD_LOAD");
				case TeklaStructuresDatabaseTypeEnum.LOAD_POINT:
					return System.Enum.Parse(tsType, "LOAD_POINT");
				case TeklaStructuresDatabaseTypeEnum.LOAD_LINE:
					return System.Enum.Parse(tsType, "LOAD_LINE");
				case TeklaStructuresDatabaseTypeEnum.LOAD_AREA:
					return System.Enum.Parse(tsType, "LOAD_AREA");
				case TeklaStructuresDatabaseTypeEnum.LOAD_UNIFORM:
					return System.Enum.Parse(tsType, "LOAD_UNIFORM");
				case TeklaStructuresDatabaseTypeEnum.LOAD_GROUP:
					return System.Enum.Parse(tsType, "LOAD_GROUP");
				case TeklaStructuresDatabaseTypeEnum.LOAD_TEMPERATURELOAD:
					return System.Enum.Parse(tsType, "LOAD_TEMPERATURELOAD");
				case TeklaStructuresDatabaseTypeEnum.SURFACE_TREATMENT:
					return System.Enum.Parse(tsType, "SURFACE_TREATMENT");
				case TeklaStructuresDatabaseTypeEnum.REBAR_SPLICE:
					return System.Enum.Parse(tsType, "REBAR_SPLICE");
				case TeklaStructuresDatabaseTypeEnum.ANALYSIS_MODEL:
					return System.Enum.Parse(tsType, "ANALYSIS_MODEL");
				case TeklaStructuresDatabaseTypeEnum.EDGE_CHAMFER:
					return System.Enum.Parse(tsType, "EDGE_CHAMFER");
				case TeklaStructuresDatabaseTypeEnum.TASK:
					return System.Enum.Parse(tsType, "TASK");
				case TeklaStructuresDatabaseTypeEnum.TASK_DEPENDENCY:
					return System.Enum.Parse(tsType, "TASK_DEPENDENCY");
				case TeklaStructuresDatabaseTypeEnum.TASK_WORKTYPE:
					return System.Enum.Parse(tsType, "TASK_WORKTYPE");
				case TeklaStructuresDatabaseTypeEnum.HIERARCHIC_DEFINITION:
					return System.Enum.Parse(tsType, "HIERARCHIC_DEFINITION");
				case TeklaStructuresDatabaseTypeEnum.HIERARCHIC_OBJECT:
					return System.Enum.Parse(tsType, "HIERARCHIC_OBJECT");
				case TeklaStructuresDatabaseTypeEnum.DB_POUR_BREAK:
					return System.Enum.Parse(tsType, "DB_POUR_BREAK");
				case TeklaStructuresDatabaseTypeEnum.DB_POUR_OBJECT:
					return System.Enum.Parse(tsType, "DB_POUR_OBJECT");
				case TeklaStructuresDatabaseTypeEnum.REBARSET_ADDITION:
					return System.Enum.Parse(tsType, "REBARSET_ADDITION");
				case TeklaStructuresDatabaseTypeEnum.REBARSET_MODIFIER:
					return System.Enum.Parse(tsType, "REBARSET_MODIFIER");
				case TeklaStructuresDatabaseTypeEnum.SURFACE_OBJECT:
					return System.Enum.Parse(tsType, "SURFACE_OBJECT");
				case TeklaStructuresDatabaseTypeEnum.BENT_PLATE:
					return System.Enum.Parse(tsType, "BENT_PLATE");
				case TeklaStructuresDatabaseTypeEnum.HELIX:
					return System.Enum.Parse(tsType, "HELIX");
				case TeklaStructuresDatabaseTypeEnum.DB_POUR_UNIT:
					return System.Enum.Parse(tsType, "DB_POUR_UNIT");
				case TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_POLYCURVE:
					return System.Enum.Parse(tsType, "CONSTRUCTION_POLYCURVE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static TeklaStructuresDatabaseTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UNKNOWN", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.UNKNOWN;
			else if (tsEnumValue.Equals("POINT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.POINT;
			else if (tsEnumValue.Equals("PART", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.PART;
			else if (tsEnumValue.Equals("CONNECTION", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.CONNECTION;
			else if (tsEnumValue.Equals("COMPONENT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.COMPONENT;
			else if (tsEnumValue.Equals("GRID", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.GRID;
			else if (tsEnumValue.Equals("FITTING", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.FITTING;
			else if (tsEnumValue.Equals("BOLT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.BOLT;
			else if (tsEnumValue.Equals("PART_CUT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.PART_CUT;
			else if (tsEnumValue.Equals("PLANE_CUT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.PLANE_CUT;
			else if (tsEnumValue.Equals("WELDING", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.WELDING;
			else if (tsEnumValue.Equals("ASSEMBLY", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.ASSEMBLY;
			else if (tsEnumValue.Equals("CONSTRUCTION_LINE", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_LINE;
			else if (tsEnumValue.Equals("PLANE", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.PLANE;
			else if (tsEnumValue.Equals("DRAWING", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.DRAWING;
			else if (tsEnumValue.Equals("DB_CONNECTION", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.DB_CONNECTION;
			else if (tsEnumValue.Equals("PART_ADD", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.PART_ADD;
			else if (tsEnumValue.Equals("WELD_CUT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.WELD_CUT;
			else if (tsEnumValue.Equals("CONSTRUCTION_CIRCLE", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_CIRCLE;
			else if (tsEnumValue.Equals("CONSTRUCTION_ARC", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_ARC;
			else if (tsEnumValue.Equals("DB_COMPONENT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.DB_COMPONENT;
			else if (tsEnumValue.Equals("REBAR", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.REBAR;
			else if (tsEnumValue.Equals("FOREIGN_OBJECT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.FOREIGN_OBJECT;
			else if (tsEnumValue.Equals("LOAD_LOAD", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.LOAD_LOAD;
			else if (tsEnumValue.Equals("LOAD_POINT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.LOAD_POINT;
			else if (tsEnumValue.Equals("LOAD_LINE", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.LOAD_LINE;
			else if (tsEnumValue.Equals("LOAD_AREA", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.LOAD_AREA;
			else if (tsEnumValue.Equals("LOAD_UNIFORM", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.LOAD_UNIFORM;
			else if (tsEnumValue.Equals("LOAD_GROUP", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.LOAD_GROUP;
			else if (tsEnumValue.Equals("LOAD_TEMPERATURELOAD", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.LOAD_TEMPERATURELOAD;
			else if (tsEnumValue.Equals("SURFACE_TREATMENT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.SURFACE_TREATMENT;
			else if (tsEnumValue.Equals("REBAR_SPLICE", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.REBAR_SPLICE;
			else if (tsEnumValue.Equals("ANALYSIS_MODEL", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.ANALYSIS_MODEL;
			else if (tsEnumValue.Equals("EDGE_CHAMFER", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.EDGE_CHAMFER;
			else if (tsEnumValue.Equals("TASK", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.TASK;
			else if (tsEnumValue.Equals("TASK_DEPENDENCY", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.TASK_DEPENDENCY;
			else if (tsEnumValue.Equals("TASK_WORKTYPE", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.TASK_WORKTYPE;
			else if (tsEnumValue.Equals("HIERARCHIC_DEFINITION", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.HIERARCHIC_DEFINITION;
			else if (tsEnumValue.Equals("HIERARCHIC_OBJECT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.HIERARCHIC_OBJECT;
			else if (tsEnumValue.Equals("DB_POUR_BREAK", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.DB_POUR_BREAK;
			else if (tsEnumValue.Equals("DB_POUR_OBJECT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.DB_POUR_OBJECT;
			else if (tsEnumValue.Equals("REBARSET_ADDITION", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.REBARSET_ADDITION;
			else if (tsEnumValue.Equals("REBARSET_MODIFIER", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.REBARSET_MODIFIER;
			else if (tsEnumValue.Equals("SURFACE_OBJECT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.SURFACE_OBJECT;
			else if (tsEnumValue.Equals("BENT_PLATE", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.BENT_PLATE;
			else if (tsEnumValue.Equals("HELIX", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.HELIX;
			else if (tsEnumValue.Equals("DB_POUR_UNIT", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.DB_POUR_UNIT;
			else if (tsEnumValue.Equals("CONSTRUCTION_POLYCURVE", System.StringComparison.InvariantCulture))
				return TeklaStructuresDatabaseTypeEnum.CONSTRUCTION_POLYCURVE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
