//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BaseRebarGroup  : Dynamic.Tekla.Structures.Model.Reinforcement
    {

		public System.String Size
		{
			get => teklaObject.Size;
			set { teklaObject.Size = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData StartHook
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.StartHook);
			set { teklaObject.StartHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData EndHook
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.EndHook);
			set { teklaObject.EndHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value); }
		}

		public System.Double FromPlaneOffset
		{
			get => teklaObject.FromPlaneOffset;
			set { teklaObject.FromPlaneOffset = value; }
		}

		public System.Double StartFromPlaneOffset
		{
			get => teklaObject.StartFromPlaneOffset;
			set { teklaObject.StartFromPlaneOffset = value; }
		}

		public System.Double EndFromPlaneOffset
		{
			get => teklaObject.EndFromPlaneOffset;
			set { teklaObject.EndFromPlaneOffset = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum ExcludeType
		{
			get => Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.FromTSObject(teklaObject.ExcludeType);
			set { teklaObject.ExcludeType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum SpacingType
		{
			get => Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(teklaObject.SpacingType);
			set { teklaObject.SpacingType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.GetTSObject(value); }
		}

		public System.Collections.ArrayList Spacings
		{
			get => teklaObject.Spacings;
			set { teklaObject.Spacings = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.Father);
			set { teklaObject.Father = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value); }
		}

		public System.String Grade
		{
			get => teklaObject.Grade;
			set { teklaObject.Grade = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.Int32 Class
		{
			get => teklaObject.Class;
			set { teklaObject.Class = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries NumberingSeries
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(teklaObject.NumberingSeries);
			set { teklaObject.NumberingSeries = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public System.Collections.ArrayList OnPlaneOffsets
		{
			get => teklaObject.OnPlaneOffsets;
			set { teklaObject.OnPlaneOffsets = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum StartPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(teklaObject.StartPointOffsetType);
			set { teklaObject.StartPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.GetTSObject(value); }
		}

		public System.Double StartPointOffsetValue
		{
			get => teklaObject.StartPointOffsetValue;
			set { teklaObject.StartPointOffsetValue = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum EndPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(teklaObject.EndPointOffsetType);
			set { teklaObject.EndPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.GetTSObject(value); }
		}

		public System.Double EndPointOffsetValue
		{
			get => teklaObject.EndPointOffsetValue;
			set { teklaObject.EndPointOffsetValue = value; }
		}

		public System.Collections.ArrayList RadiusValues
		{
			get => teklaObject.RadiusValues;
			set { teklaObject.RadiusValues = value; }
		}

		public Dynamic.Tekla.Structures.Forming.DeformingType InputPointDeformingState
		{
			get => Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(teklaObject.InputPointDeformingState);
			set { teklaObject.InputPointDeformingState = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => teklaObject.ModificationTime;
			set { teklaObject.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => teklaObject.IsUpToDate;
			set { teklaObject.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.Identifier);
			set { teklaObject.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;


		public System.Collections.ArrayList GetRebarGeometries(Dynamic.Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum options)
			 => teklaObject.GetRebarGeometries(Dynamic.Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum_.GetTSObject(options));

		public System.Collections.ArrayList GetRebarGeometries(System.Boolean withHooks)
			 => teklaObject.GetRebarGeometries(withHooks);

		public System.Collections.ArrayList GetRebarGeometriesWithoutClashes(System.Boolean withHooks)
			 => teklaObject.GetRebarGeometriesWithoutClashes(withHooks);

		public System.Boolean IsGeometryValid()
			 => teklaObject.IsGeometryValid();

		public System.Int32 GetNumberOfRebars()
			 => teklaObject.GetNumberOfRebars();

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebar(System.Int32 index, System.Boolean withHooks)
			 => Dynamic.Tekla.Structures.Model.RebarGeometry_.FromTSObject(teklaObject.GetSingleRebar(index, withHooks));

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebarWithoutClash(System.Int32 index, System.Boolean withHooks)
			 => Dynamic.Tekla.Structures.Model.RebarGeometry_.FromTSObject(teklaObject.GetSingleRebarWithoutClash(index, withHooks));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => Dynamic.Tekla.Structures.Model.PourObject_.FromTSObject(teklaObject.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(teklaObject.GetFatherPourUnit());

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Select()
			 => teklaObject.Select();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(teklaObject.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => teklaObject.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => teklaObject.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => teklaObject.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => teklaObject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => teklaObject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => teklaObject.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => teklaObject.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => teklaObject.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => teklaObject.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => teklaObject.CompareTo(obj);




    public enum ExcludeTypeEnum
    {
			EXCLUDE_TYPE_NONE,
			EXCLUDE_TYPE_FIRST,
			EXCLUDE_TYPE_LAST,
			EXCLUDE_TYPE_BOTH        
    }

    internal static class ExcludeTypeEnum_
    {
        public static dynamic GetTSObject(ExcludeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum").GetType();

            switch (dynEnum)
            {
				case ExcludeTypeEnum.EXCLUDE_TYPE_NONE:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_NONE");
				case ExcludeTypeEnum.EXCLUDE_TYPE_FIRST:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_FIRST");
				case ExcludeTypeEnum.EXCLUDE_TYPE_LAST:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_LAST");
				case ExcludeTypeEnum.EXCLUDE_TYPE_BOTH:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_BOTH");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ExcludeTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EXCLUDE_TYPE_NONE", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_NONE;
			else if (tsEnumValue.Equals("EXCLUDE_TYPE_FIRST", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_FIRST;
			else if (tsEnumValue.Equals("EXCLUDE_TYPE_LAST", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_LAST;
			else if (tsEnumValue.Equals("EXCLUDE_TYPE_BOTH", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_BOTH;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarGroupSpacingTypeEnum
    {
			SPACING_TYPE_UNDEFINED,
			SPACING_TYPE_EXACT_SPACINGS,
			SPACING_TYPE_EXACT_NUMBER,
			SPACING_TYPE_TARGET_SPACE,
			SPACING_TYPE_EXACT_SPACE_FLEX_AT_START,
			SPACING_TYPE_EXACT_SPACE_FLEX_AT_END,
			SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH,
			SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE        
    }

    internal static class RebarGroupSpacingTypeEnum_
    {
        public static dynamic GetTSObject(RebarGroupSpacingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum").GetType();

            switch (dynEnum)
            {
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_UNDEFINED:
					return System.Enum.Parse(tsType, "SPACING_TYPE_UNDEFINED");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACINGS:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACINGS");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_NUMBER:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_NUMBER");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_TARGET_SPACE:
					return System.Enum.Parse(tsType, "SPACING_TYPE_TARGET_SPACE");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_START:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_START");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_END:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_END");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH");
				case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE:
					return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarGroupSpacingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPACING_TYPE_UNDEFINED", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_UNDEFINED;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACINGS", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACINGS;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_NUMBER", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_NUMBER;
			else if (tsEnumValue.Equals("SPACING_TYPE_TARGET_SPACE", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_TARGET_SPACE;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_START", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_START;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_END", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_END;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH;
			else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE", System.StringComparison.InvariantCulture))
				return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BaseRebarGroup_
    {
        public static dynamic GetTSObject(BaseRebarGroup dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BaseRebarGroup FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.BaseRebarGroup)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
