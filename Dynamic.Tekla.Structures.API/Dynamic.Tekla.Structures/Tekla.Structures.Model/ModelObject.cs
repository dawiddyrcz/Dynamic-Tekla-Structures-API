/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class ModelObject  : Dynamic.Tekla.Structures.Model.Object
    {

		public System.Nullable<System.DateTime> ModificationTime
		{
			get => teklaObject.ModificationTime;

		}

		public System.Boolean IsUpToDate
		{
			get => teklaObject.IsUpToDate;

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

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetChildren());
		}

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
		{
			return Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(teklaObject.GetFatherComponent());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetHierarchicObjects());
		}

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
		{
			return teklaObject.GetAllUserProperties(ref values);
		}

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
		{
			return teklaObject.GetIntegerUserProperties(ref values);
		}

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
		{
			return teklaObject.GetDoubleUserProperties(ref values);
		}

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
		{
			return teklaObject.GetStringUserProperties(ref values);
		}

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
		{
			return teklaObject.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);
		}

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
		{
			return teklaObject.GetIntegerReportProperties(names, ref values);
		}

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
		{
			return teklaObject.GetDoubleReportProperties(names, ref values);
		}

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
		{
			return teklaObject.GetStringReportProperties(names, ref values);
		}

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
		{
			return teklaObject.GetUserProperty(name, ref value);
		}

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
		{
			return teklaObject.GetReportProperty(name, ref value);
		}

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
		{
			return teklaObject.GetUserProperty(name, ref value);
		}

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
		{
			return teklaObject.GetReportProperty(name, ref value);
		}

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
		{
			return teklaObject.GetUserProperty(name, ref value);
		}

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
		{
			return teklaObject.GetReportProperty(name, ref value);
		}

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
		{
			return teklaObject.GetDynamicStringProperty(name, ref value);
		}

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
		{
			return teklaObject.SetDynamicStringProperty(name, value);
		}

		public System.Boolean SetUserProperty(System.String name, System.String value)
		{
			return teklaObject.SetUserProperty(name, value);
		}

		public System.Boolean SetUserProperty(System.String name, System.Double value)
		{
			return teklaObject.SetUserProperty(name, value);
		}

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
		{
			return teklaObject.SetUserProperty(name, value);
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
		{
			return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.GetCoordinateSystem());
		}

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
		{
			return teklaObject.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));
		}

		public System.Boolean GetPhase(out Dynamic.Tekla.Structures.Model.Phase phase)
		{
			var parameters = new object[1];
			phase = null;
			parameters[0] = Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase);
			var result = (System.Boolean) TSActivator.InvokeMethod(teklaObject, "Tekla.Structures.Model.ModelObject", "GetPhase", parameters);
			phase = Dynamic.Tekla.Structures.Model.Phase_.FromTSObject(parameters[0]);
			return result;
		}

		public System.Boolean SetLabel(System.String label)
		{
			return teklaObject.SetLabel(label);
		}

		public System.Int32 CompareTo(System.Object obj)
		{
			return teklaObject.CompareTo(obj);
		}




    public enum ModelObjectEnum
    {
			UNKNOWN,
			BEAM,
			POLYBEAM,
			CONTOURPLATE,
			BOOLEANPART,
			FITTING,
			CUTPLANE,
			SURFACE_TREATMENT,
			WELD,
			ASSEMBLY,
			SINGLEREBAR,
			REBARGROUP,
			REBARMESH,
			REBARSTRAND,
			CONTROL_PLANE,
			BOLT_ARRAY,
			BOLT_CIRCLE,
			BOLT_XYLIST,
			LOAD_POINT,
			LOAD_LINE,
			LOAD_AREA,
			LOAD_UNIFORM,
			GRID,
			GRIDPLANE,
			CONNECTION,
			COMPONENT,
			SEAM,
			DETAIL,
			REFERENCE_MODEL,
			REBAR_SPLICE,
			LOAD_GROUP,
			TASK,
			TASK_DEPENDENCY,
			TASK_WORKTYPE,
			POLYGON_WELD,
			LOGICAL_WELD,
			CIRCLEREBAR,
			HIERARCHIC_DEFINITION,
			HIERARCHIC_OBJECT,
			ANALYSIS_GEOMETRY,
			ANALYSIS_PART,
			REFERENCE_MODEL_OBJECT,
			CUSTOM_PART,
			CIRCLE_REBARGROUP,
			CURVED_REBARGROUP,
			EDGE_CHAMFER,
			POUR_OBJECT,
			POUR_BREAK,
			CONTROL_LINE,
			LOAD_TEMPERATURE,
			BREP,
			CONTROL_CIRCLE,
			CONTROL_POINT,
			REBAR_SET,
			REBAR_SET_ADDITION,
			REBAR_PROPERTY_MODIFIER,
			REBAR_END_DETAIL_MODIFIER,
			REBAR_SPLITTER,
			SURFACE_OBJECT,
			BENT_PLATE,
			SPIRAL_BEAM,
			POUR_UNIT,
			CONTROL_ARC,
			CONTROL_SPLINE,
			CONTROL_POLYCURVE,
			RADIAL_GRID,
			GRID_CYLINDRICAL_SURFACE,
			LOFTED_PLATE        
    }

    internal static class ModelObjectEnum_
    {
        public static dynamic GetTSObject(ModelObjectEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ModelObject.ModelObjectEnum").GetType();

            switch (dynEnum)
            {
				case ModelObjectEnum.UNKNOWN:
					return System.Enum.Parse(tsType, "UNKNOWN");
				case ModelObjectEnum.BEAM:
					return System.Enum.Parse(tsType, "BEAM");
				case ModelObjectEnum.POLYBEAM:
					return System.Enum.Parse(tsType, "POLYBEAM");
				case ModelObjectEnum.CONTOURPLATE:
					return System.Enum.Parse(tsType, "CONTOURPLATE");
				case ModelObjectEnum.BOOLEANPART:
					return System.Enum.Parse(tsType, "BOOLEANPART");
				case ModelObjectEnum.FITTING:
					return System.Enum.Parse(tsType, "FITTING");
				case ModelObjectEnum.CUTPLANE:
					return System.Enum.Parse(tsType, "CUTPLANE");
				case ModelObjectEnum.SURFACE_TREATMENT:
					return System.Enum.Parse(tsType, "SURFACE_TREATMENT");
				case ModelObjectEnum.WELD:
					return System.Enum.Parse(tsType, "WELD");
				case ModelObjectEnum.ASSEMBLY:
					return System.Enum.Parse(tsType, "ASSEMBLY");
				case ModelObjectEnum.SINGLEREBAR:
					return System.Enum.Parse(tsType, "SINGLEREBAR");
				case ModelObjectEnum.REBARGROUP:
					return System.Enum.Parse(tsType, "REBARGROUP");
				case ModelObjectEnum.REBARMESH:
					return System.Enum.Parse(tsType, "REBARMESH");
				case ModelObjectEnum.REBARSTRAND:
					return System.Enum.Parse(tsType, "REBARSTRAND");
				case ModelObjectEnum.CONTROL_PLANE:
					return System.Enum.Parse(tsType, "CONTROL_PLANE");
				case ModelObjectEnum.BOLT_ARRAY:
					return System.Enum.Parse(tsType, "BOLT_ARRAY");
				case ModelObjectEnum.BOLT_CIRCLE:
					return System.Enum.Parse(tsType, "BOLT_CIRCLE");
				case ModelObjectEnum.BOLT_XYLIST:
					return System.Enum.Parse(tsType, "BOLT_XYLIST");
				case ModelObjectEnum.LOAD_POINT:
					return System.Enum.Parse(tsType, "LOAD_POINT");
				case ModelObjectEnum.LOAD_LINE:
					return System.Enum.Parse(tsType, "LOAD_LINE");
				case ModelObjectEnum.LOAD_AREA:
					return System.Enum.Parse(tsType, "LOAD_AREA");
				case ModelObjectEnum.LOAD_UNIFORM:
					return System.Enum.Parse(tsType, "LOAD_UNIFORM");
				case ModelObjectEnum.GRID:
					return System.Enum.Parse(tsType, "GRID");
				case ModelObjectEnum.GRIDPLANE:
					return System.Enum.Parse(tsType, "GRIDPLANE");
				case ModelObjectEnum.CONNECTION:
					return System.Enum.Parse(tsType, "CONNECTION");
				case ModelObjectEnum.COMPONENT:
					return System.Enum.Parse(tsType, "COMPONENT");
				case ModelObjectEnum.SEAM:
					return System.Enum.Parse(tsType, "SEAM");
				case ModelObjectEnum.DETAIL:
					return System.Enum.Parse(tsType, "DETAIL");
				case ModelObjectEnum.REFERENCE_MODEL:
					return System.Enum.Parse(tsType, "REFERENCE_MODEL");
				case ModelObjectEnum.REBAR_SPLICE:
					return System.Enum.Parse(tsType, "REBAR_SPLICE");
				case ModelObjectEnum.LOAD_GROUP:
					return System.Enum.Parse(tsType, "LOAD_GROUP");
				case ModelObjectEnum.TASK:
					return System.Enum.Parse(tsType, "TASK");
				case ModelObjectEnum.TASK_DEPENDENCY:
					return System.Enum.Parse(tsType, "TASK_DEPENDENCY");
				case ModelObjectEnum.TASK_WORKTYPE:
					return System.Enum.Parse(tsType, "TASK_WORKTYPE");
				case ModelObjectEnum.POLYGON_WELD:
					return System.Enum.Parse(tsType, "POLYGON_WELD");
				case ModelObjectEnum.LOGICAL_WELD:
					return System.Enum.Parse(tsType, "LOGICAL_WELD");
				case ModelObjectEnum.CIRCLEREBAR:
					return System.Enum.Parse(tsType, "CIRCLEREBAR");
				case ModelObjectEnum.HIERARCHIC_DEFINITION:
					return System.Enum.Parse(tsType, "HIERARCHIC_DEFINITION");
				case ModelObjectEnum.HIERARCHIC_OBJECT:
					return System.Enum.Parse(tsType, "HIERARCHIC_OBJECT");
				case ModelObjectEnum.ANALYSIS_GEOMETRY:
					return System.Enum.Parse(tsType, "ANALYSIS_GEOMETRY");
				case ModelObjectEnum.ANALYSIS_PART:
					return System.Enum.Parse(tsType, "ANALYSIS_PART");
				case ModelObjectEnum.REFERENCE_MODEL_OBJECT:
					return System.Enum.Parse(tsType, "REFERENCE_MODEL_OBJECT");
				case ModelObjectEnum.CUSTOM_PART:
					return System.Enum.Parse(tsType, "CUSTOM_PART");
				case ModelObjectEnum.CIRCLE_REBARGROUP:
					return System.Enum.Parse(tsType, "CIRCLE_REBARGROUP");
				case ModelObjectEnum.CURVED_REBARGROUP:
					return System.Enum.Parse(tsType, "CURVED_REBARGROUP");
				case ModelObjectEnum.EDGE_CHAMFER:
					return System.Enum.Parse(tsType, "EDGE_CHAMFER");
				case ModelObjectEnum.POUR_OBJECT:
					return System.Enum.Parse(tsType, "POUR_OBJECT");
				case ModelObjectEnum.POUR_BREAK:
					return System.Enum.Parse(tsType, "POUR_BREAK");
				case ModelObjectEnum.CONTROL_LINE:
					return System.Enum.Parse(tsType, "CONTROL_LINE");
				case ModelObjectEnum.LOAD_TEMPERATURE:
					return System.Enum.Parse(tsType, "LOAD_TEMPERATURE");
				case ModelObjectEnum.BREP:
					return System.Enum.Parse(tsType, "BREP");
				case ModelObjectEnum.CONTROL_CIRCLE:
					return System.Enum.Parse(tsType, "CONTROL_CIRCLE");
				case ModelObjectEnum.CONTROL_POINT:
					return System.Enum.Parse(tsType, "CONTROL_POINT");
				case ModelObjectEnum.REBAR_SET:
					return System.Enum.Parse(tsType, "REBAR_SET");
				case ModelObjectEnum.REBAR_SET_ADDITION:
					return System.Enum.Parse(tsType, "REBAR_SET_ADDITION");
				case ModelObjectEnum.REBAR_PROPERTY_MODIFIER:
					return System.Enum.Parse(tsType, "REBAR_PROPERTY_MODIFIER");
				case ModelObjectEnum.REBAR_END_DETAIL_MODIFIER:
					return System.Enum.Parse(tsType, "REBAR_END_DETAIL_MODIFIER");
				case ModelObjectEnum.REBAR_SPLITTER:
					return System.Enum.Parse(tsType, "REBAR_SPLITTER");
				case ModelObjectEnum.SURFACE_OBJECT:
					return System.Enum.Parse(tsType, "SURFACE_OBJECT");
				case ModelObjectEnum.BENT_PLATE:
					return System.Enum.Parse(tsType, "BENT_PLATE");
				case ModelObjectEnum.SPIRAL_BEAM:
					return System.Enum.Parse(tsType, "SPIRAL_BEAM");
				case ModelObjectEnum.POUR_UNIT:
					return System.Enum.Parse(tsType, "POUR_UNIT");
				case ModelObjectEnum.CONTROL_ARC:
					return System.Enum.Parse(tsType, "CONTROL_ARC");
				case ModelObjectEnum.CONTROL_SPLINE:
					return System.Enum.Parse(tsType, "CONTROL_SPLINE");
				case ModelObjectEnum.CONTROL_POLYCURVE:
					return System.Enum.Parse(tsType, "CONTROL_POLYCURVE");
				case ModelObjectEnum.RADIAL_GRID:
					return System.Enum.Parse(tsType, "RADIAL_GRID");
				case ModelObjectEnum.GRID_CYLINDRICAL_SURFACE:
					return System.Enum.Parse(tsType, "GRID_CYLINDRICAL_SURFACE");
				case ModelObjectEnum.LOFTED_PLATE:
					return System.Enum.Parse(tsType, "LOFTED_PLATE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ModelObjectEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UNKNOWN", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.UNKNOWN;
			else if (tsEnumValue.Equals("BEAM", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.BEAM;
			else if (tsEnumValue.Equals("POLYBEAM", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.POLYBEAM;
			else if (tsEnumValue.Equals("CONTOURPLATE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CONTOURPLATE;
			else if (tsEnumValue.Equals("BOOLEANPART", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.BOOLEANPART;
			else if (tsEnumValue.Equals("FITTING", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.FITTING;
			else if (tsEnumValue.Equals("CUTPLANE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CUTPLANE;
			else if (tsEnumValue.Equals("SURFACE_TREATMENT", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.SURFACE_TREATMENT;
			else if (tsEnumValue.Equals("WELD", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.WELD;
			else if (tsEnumValue.Equals("ASSEMBLY", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.ASSEMBLY;
			else if (tsEnumValue.Equals("SINGLEREBAR", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.SINGLEREBAR;
			else if (tsEnumValue.Equals("REBARGROUP", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REBARGROUP;
			else if (tsEnumValue.Equals("REBARMESH", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REBARMESH;
			else if (tsEnumValue.Equals("REBARSTRAND", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REBARSTRAND;
			else if (tsEnumValue.Equals("CONTROL_PLANE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CONTROL_PLANE;
			else if (tsEnumValue.Equals("BOLT_ARRAY", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.BOLT_ARRAY;
			else if (tsEnumValue.Equals("BOLT_CIRCLE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.BOLT_CIRCLE;
			else if (tsEnumValue.Equals("BOLT_XYLIST", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.BOLT_XYLIST;
			else if (tsEnumValue.Equals("LOAD_POINT", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.LOAD_POINT;
			else if (tsEnumValue.Equals("LOAD_LINE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.LOAD_LINE;
			else if (tsEnumValue.Equals("LOAD_AREA", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.LOAD_AREA;
			else if (tsEnumValue.Equals("LOAD_UNIFORM", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.LOAD_UNIFORM;
			else if (tsEnumValue.Equals("GRID", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.GRID;
			else if (tsEnumValue.Equals("GRIDPLANE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.GRIDPLANE;
			else if (tsEnumValue.Equals("CONNECTION", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CONNECTION;
			else if (tsEnumValue.Equals("COMPONENT", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.COMPONENT;
			else if (tsEnumValue.Equals("SEAM", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.SEAM;
			else if (tsEnumValue.Equals("DETAIL", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.DETAIL;
			else if (tsEnumValue.Equals("REFERENCE_MODEL", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REFERENCE_MODEL;
			else if (tsEnumValue.Equals("REBAR_SPLICE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REBAR_SPLICE;
			else if (tsEnumValue.Equals("LOAD_GROUP", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.LOAD_GROUP;
			else if (tsEnumValue.Equals("TASK", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.TASK;
			else if (tsEnumValue.Equals("TASK_DEPENDENCY", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.TASK_DEPENDENCY;
			else if (tsEnumValue.Equals("TASK_WORKTYPE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.TASK_WORKTYPE;
			else if (tsEnumValue.Equals("POLYGON_WELD", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.POLYGON_WELD;
			else if (tsEnumValue.Equals("LOGICAL_WELD", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.LOGICAL_WELD;
			else if (tsEnumValue.Equals("CIRCLEREBAR", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CIRCLEREBAR;
			else if (tsEnumValue.Equals("HIERARCHIC_DEFINITION", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.HIERARCHIC_DEFINITION;
			else if (tsEnumValue.Equals("HIERARCHIC_OBJECT", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.HIERARCHIC_OBJECT;
			else if (tsEnumValue.Equals("ANALYSIS_GEOMETRY", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.ANALYSIS_GEOMETRY;
			else if (tsEnumValue.Equals("ANALYSIS_PART", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.ANALYSIS_PART;
			else if (tsEnumValue.Equals("REFERENCE_MODEL_OBJECT", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REFERENCE_MODEL_OBJECT;
			else if (tsEnumValue.Equals("CUSTOM_PART", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CUSTOM_PART;
			else if (tsEnumValue.Equals("CIRCLE_REBARGROUP", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CIRCLE_REBARGROUP;
			else if (tsEnumValue.Equals("CURVED_REBARGROUP", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CURVED_REBARGROUP;
			else if (tsEnumValue.Equals("EDGE_CHAMFER", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.EDGE_CHAMFER;
			else if (tsEnumValue.Equals("POUR_OBJECT", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.POUR_OBJECT;
			else if (tsEnumValue.Equals("POUR_BREAK", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.POUR_BREAK;
			else if (tsEnumValue.Equals("CONTROL_LINE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CONTROL_LINE;
			else if (tsEnumValue.Equals("LOAD_TEMPERATURE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.LOAD_TEMPERATURE;
			else if (tsEnumValue.Equals("BREP", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.BREP;
			else if (tsEnumValue.Equals("CONTROL_CIRCLE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CONTROL_CIRCLE;
			else if (tsEnumValue.Equals("CONTROL_POINT", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CONTROL_POINT;
			else if (tsEnumValue.Equals("REBAR_SET", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REBAR_SET;
			else if (tsEnumValue.Equals("REBAR_SET_ADDITION", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REBAR_SET_ADDITION;
			else if (tsEnumValue.Equals("REBAR_PROPERTY_MODIFIER", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REBAR_PROPERTY_MODIFIER;
			else if (tsEnumValue.Equals("REBAR_END_DETAIL_MODIFIER", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REBAR_END_DETAIL_MODIFIER;
			else if (tsEnumValue.Equals("REBAR_SPLITTER", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.REBAR_SPLITTER;
			else if (tsEnumValue.Equals("SURFACE_OBJECT", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.SURFACE_OBJECT;
			else if (tsEnumValue.Equals("BENT_PLATE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.BENT_PLATE;
			else if (tsEnumValue.Equals("SPIRAL_BEAM", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.SPIRAL_BEAM;
			else if (tsEnumValue.Equals("POUR_UNIT", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.POUR_UNIT;
			else if (tsEnumValue.Equals("CONTROL_ARC", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CONTROL_ARC;
			else if (tsEnumValue.Equals("CONTROL_SPLINE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CONTROL_SPLINE;
			else if (tsEnumValue.Equals("CONTROL_POLYCURVE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.CONTROL_POLYCURVE;
			else if (tsEnumValue.Equals("RADIAL_GRID", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.RADIAL_GRID;
			else if (tsEnumValue.Equals("GRID_CYLINDRICAL_SURFACE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.GRID_CYLINDRICAL_SURFACE;
			else if (tsEnumValue.Equals("LOFTED_PLATE", System.StringComparison.InvariantCulture))
				return ModelObjectEnum.LOFTED_PLATE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ModelObject_
    {
        public static dynamic GetTSObject(ModelObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ModelObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelObjectArray_
    {
        public static dynamic GetTSObject(ModelObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
