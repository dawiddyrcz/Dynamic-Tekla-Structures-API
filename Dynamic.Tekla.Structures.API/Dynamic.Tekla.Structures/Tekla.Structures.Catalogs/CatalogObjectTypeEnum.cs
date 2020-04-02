/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public enum CatalogObjectTypeEnum
    {
			PART,
			STEEL_BEAM,
			STEEL_COLUMN,
			STEEL_ORTHOGONAL_BEAM,
			STEEL_TWIN_PROFILE_BEAM,
			STEEL_CONTOUR_PLATE,
			STEEL_FOLDED_PLATE,
			CONCRETE_BEAM,
			CONCRETE_COLUMN,
			CONCRETE_PAD_FOOTING,
			CONCRETE_STRIP_FOOTING,
			CONCRETE_PANEL,
			CONCRETE_SLAB,
			REINFORCING_BAR,
			SURFACING,
			WELD,
			BOLT,
			STEEL_ASSEMBLY,
			PRECAST_CONCRETE_ASSEMBLY,
			INSITU_CONCRETE_ASSEMBLY,
			POUR_OBJECT,
			POUR_BREAK,
			GRID,
			PROJECT,
			PHASE,
			TASK,
			REFERENCE_MODEL,
			REFERENCE_MODEL_OBJECT,
			SINGLE_PART_DRAWING,
			ASSEMBLY_DRAWING,
			GA_DRAWING,
			MULTI_DRAWING,
			CAST_UNIT_DRAWING,
			BENT_PLATE,
			STEEL_BREP_PART,
			CONCRETE_BREP_PART,
			CHAMFER_OBJECT,
			SURFACE_OBJECT,
			GRID_PLANE,
			STEEL_SPIRAL_BEAM,
			CONCRETE_SPIRAL_BEAM,
			STEEL_LOFTED_PLATE,
			CONCRETE_LOFTED_SLAB        
    }

    internal static class CatalogObjectTypeEnum_
    {
        public static dynamic GetTSObject(CatalogObjectTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.CatalogObjectTypeEnum").GetType();

            switch (dynEnum)
            {
				case CatalogObjectTypeEnum.PART:
					return System.Enum.Parse(tsType, "PART");
				case CatalogObjectTypeEnum.STEEL_BEAM:
					return System.Enum.Parse(tsType, "STEEL_BEAM");
				case CatalogObjectTypeEnum.STEEL_COLUMN:
					return System.Enum.Parse(tsType, "STEEL_COLUMN");
				case CatalogObjectTypeEnum.STEEL_ORTHOGONAL_BEAM:
					return System.Enum.Parse(tsType, "STEEL_ORTHOGONAL_BEAM");
				case CatalogObjectTypeEnum.STEEL_TWIN_PROFILE_BEAM:
					return System.Enum.Parse(tsType, "STEEL_TWIN_PROFILE_BEAM");
				case CatalogObjectTypeEnum.STEEL_CONTOUR_PLATE:
					return System.Enum.Parse(tsType, "STEEL_CONTOUR_PLATE");
				case CatalogObjectTypeEnum.STEEL_FOLDED_PLATE:
					return System.Enum.Parse(tsType, "STEEL_FOLDED_PLATE");
				case CatalogObjectTypeEnum.CONCRETE_BEAM:
					return System.Enum.Parse(tsType, "CONCRETE_BEAM");
				case CatalogObjectTypeEnum.CONCRETE_COLUMN:
					return System.Enum.Parse(tsType, "CONCRETE_COLUMN");
				case CatalogObjectTypeEnum.CONCRETE_PAD_FOOTING:
					return System.Enum.Parse(tsType, "CONCRETE_PAD_FOOTING");
				case CatalogObjectTypeEnum.CONCRETE_STRIP_FOOTING:
					return System.Enum.Parse(tsType, "CONCRETE_STRIP_FOOTING");
				case CatalogObjectTypeEnum.CONCRETE_PANEL:
					return System.Enum.Parse(tsType, "CONCRETE_PANEL");
				case CatalogObjectTypeEnum.CONCRETE_SLAB:
					return System.Enum.Parse(tsType, "CONCRETE_SLAB");
				case CatalogObjectTypeEnum.REINFORCING_BAR:
					return System.Enum.Parse(tsType, "REINFORCING_BAR");
				case CatalogObjectTypeEnum.SURFACING:
					return System.Enum.Parse(tsType, "SURFACING");
				case CatalogObjectTypeEnum.WELD:
					return System.Enum.Parse(tsType, "WELD");
				case CatalogObjectTypeEnum.BOLT:
					return System.Enum.Parse(tsType, "BOLT");
				case CatalogObjectTypeEnum.STEEL_ASSEMBLY:
					return System.Enum.Parse(tsType, "STEEL_ASSEMBLY");
				case CatalogObjectTypeEnum.PRECAST_CONCRETE_ASSEMBLY:
					return System.Enum.Parse(tsType, "PRECAST_CONCRETE_ASSEMBLY");
				case CatalogObjectTypeEnum.INSITU_CONCRETE_ASSEMBLY:
					return System.Enum.Parse(tsType, "INSITU_CONCRETE_ASSEMBLY");
				case CatalogObjectTypeEnum.POUR_OBJECT:
					return System.Enum.Parse(tsType, "POUR_OBJECT");
				case CatalogObjectTypeEnum.POUR_BREAK:
					return System.Enum.Parse(tsType, "POUR_BREAK");
				case CatalogObjectTypeEnum.GRID:
					return System.Enum.Parse(tsType, "GRID");
				case CatalogObjectTypeEnum.PROJECT:
					return System.Enum.Parse(tsType, "PROJECT");
				case CatalogObjectTypeEnum.PHASE:
					return System.Enum.Parse(tsType, "PHASE");
				case CatalogObjectTypeEnum.TASK:
					return System.Enum.Parse(tsType, "TASK");
				case CatalogObjectTypeEnum.REFERENCE_MODEL:
					return System.Enum.Parse(tsType, "REFERENCE_MODEL");
				case CatalogObjectTypeEnum.REFERENCE_MODEL_OBJECT:
					return System.Enum.Parse(tsType, "REFERENCE_MODEL_OBJECT");
				case CatalogObjectTypeEnum.SINGLE_PART_DRAWING:
					return System.Enum.Parse(tsType, "SINGLE_PART_DRAWING");
				case CatalogObjectTypeEnum.ASSEMBLY_DRAWING:
					return System.Enum.Parse(tsType, "ASSEMBLY_DRAWING");
				case CatalogObjectTypeEnum.GA_DRAWING:
					return System.Enum.Parse(tsType, "GA_DRAWING");
				case CatalogObjectTypeEnum.MULTI_DRAWING:
					return System.Enum.Parse(tsType, "MULTI_DRAWING");
				case CatalogObjectTypeEnum.CAST_UNIT_DRAWING:
					return System.Enum.Parse(tsType, "CAST_UNIT_DRAWING");
				case CatalogObjectTypeEnum.BENT_PLATE:
					return System.Enum.Parse(tsType, "BENT_PLATE");
				case CatalogObjectTypeEnum.STEEL_BREP_PART:
					return System.Enum.Parse(tsType, "STEEL_BREP_PART");
				case CatalogObjectTypeEnum.CONCRETE_BREP_PART:
					return System.Enum.Parse(tsType, "CONCRETE_BREP_PART");
				case CatalogObjectTypeEnum.CHAMFER_OBJECT:
					return System.Enum.Parse(tsType, "CHAMFER_OBJECT");
				case CatalogObjectTypeEnum.SURFACE_OBJECT:
					return System.Enum.Parse(tsType, "SURFACE_OBJECT");
				case CatalogObjectTypeEnum.GRID_PLANE:
					return System.Enum.Parse(tsType, "GRID_PLANE");
				case CatalogObjectTypeEnum.STEEL_SPIRAL_BEAM:
					return System.Enum.Parse(tsType, "STEEL_SPIRAL_BEAM");
				case CatalogObjectTypeEnum.CONCRETE_SPIRAL_BEAM:
					return System.Enum.Parse(tsType, "CONCRETE_SPIRAL_BEAM");
				case CatalogObjectTypeEnum.STEEL_LOFTED_PLATE:
					return System.Enum.Parse(tsType, "STEEL_LOFTED_PLATE");
				case CatalogObjectTypeEnum.CONCRETE_LOFTED_SLAB:
					return System.Enum.Parse(tsType, "CONCRETE_LOFTED_SLAB");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CatalogObjectTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PART", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.PART;
			else if (tsEnumValue.Equals("STEEL_BEAM", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_BEAM;
			else if (tsEnumValue.Equals("STEEL_COLUMN", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_COLUMN;
			else if (tsEnumValue.Equals("STEEL_ORTHOGONAL_BEAM", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_ORTHOGONAL_BEAM;
			else if (tsEnumValue.Equals("STEEL_TWIN_PROFILE_BEAM", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_TWIN_PROFILE_BEAM;
			else if (tsEnumValue.Equals("STEEL_CONTOUR_PLATE", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_CONTOUR_PLATE;
			else if (tsEnumValue.Equals("STEEL_FOLDED_PLATE", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_FOLDED_PLATE;
			else if (tsEnumValue.Equals("CONCRETE_BEAM", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CONCRETE_BEAM;
			else if (tsEnumValue.Equals("CONCRETE_COLUMN", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CONCRETE_COLUMN;
			else if (tsEnumValue.Equals("CONCRETE_PAD_FOOTING", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CONCRETE_PAD_FOOTING;
			else if (tsEnumValue.Equals("CONCRETE_STRIP_FOOTING", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CONCRETE_STRIP_FOOTING;
			else if (tsEnumValue.Equals("CONCRETE_PANEL", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CONCRETE_PANEL;
			else if (tsEnumValue.Equals("CONCRETE_SLAB", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CONCRETE_SLAB;
			else if (tsEnumValue.Equals("REINFORCING_BAR", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.REINFORCING_BAR;
			else if (tsEnumValue.Equals("SURFACING", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.SURFACING;
			else if (tsEnumValue.Equals("WELD", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.WELD;
			else if (tsEnumValue.Equals("BOLT", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.BOLT;
			else if (tsEnumValue.Equals("STEEL_ASSEMBLY", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_ASSEMBLY;
			else if (tsEnumValue.Equals("PRECAST_CONCRETE_ASSEMBLY", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.PRECAST_CONCRETE_ASSEMBLY;
			else if (tsEnumValue.Equals("INSITU_CONCRETE_ASSEMBLY", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.INSITU_CONCRETE_ASSEMBLY;
			else if (tsEnumValue.Equals("POUR_OBJECT", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.POUR_OBJECT;
			else if (tsEnumValue.Equals("POUR_BREAK", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.POUR_BREAK;
			else if (tsEnumValue.Equals("GRID", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.GRID;
			else if (tsEnumValue.Equals("PROJECT", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.PROJECT;
			else if (tsEnumValue.Equals("PHASE", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.PHASE;
			else if (tsEnumValue.Equals("TASK", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.TASK;
			else if (tsEnumValue.Equals("REFERENCE_MODEL", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.REFERENCE_MODEL;
			else if (tsEnumValue.Equals("REFERENCE_MODEL_OBJECT", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.REFERENCE_MODEL_OBJECT;
			else if (tsEnumValue.Equals("SINGLE_PART_DRAWING", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.SINGLE_PART_DRAWING;
			else if (tsEnumValue.Equals("ASSEMBLY_DRAWING", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.ASSEMBLY_DRAWING;
			else if (tsEnumValue.Equals("GA_DRAWING", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.GA_DRAWING;
			else if (tsEnumValue.Equals("MULTI_DRAWING", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.MULTI_DRAWING;
			else if (tsEnumValue.Equals("CAST_UNIT_DRAWING", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CAST_UNIT_DRAWING;
			else if (tsEnumValue.Equals("BENT_PLATE", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.BENT_PLATE;
			else if (tsEnumValue.Equals("STEEL_BREP_PART", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_BREP_PART;
			else if (tsEnumValue.Equals("CONCRETE_BREP_PART", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CONCRETE_BREP_PART;
			else if (tsEnumValue.Equals("CHAMFER_OBJECT", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CHAMFER_OBJECT;
			else if (tsEnumValue.Equals("SURFACE_OBJECT", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.SURFACE_OBJECT;
			else if (tsEnumValue.Equals("GRID_PLANE", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.GRID_PLANE;
			else if (tsEnumValue.Equals("STEEL_SPIRAL_BEAM", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_SPIRAL_BEAM;
			else if (tsEnumValue.Equals("CONCRETE_SPIRAL_BEAM", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CONCRETE_SPIRAL_BEAM;
			else if (tsEnumValue.Equals("STEEL_LOFTED_PLATE", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.STEEL_LOFTED_PLATE;
			else if (tsEnumValue.Equals("CONCRETE_LOFTED_SLAB", System.StringComparison.InvariantCulture))
				return CatalogObjectTypeEnum.CONCRETE_LOFTED_SLAB;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }

}
    
