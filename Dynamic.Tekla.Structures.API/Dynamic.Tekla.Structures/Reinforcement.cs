//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Reinforcement 
    {

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(reinforcement.Father.GetTSObject());
			set { reinforcement.Father = value.GetTSObject(); }
		}

		public System.String Grade
		{
			get => reinforcement.Grade;
			set { reinforcement.Grade = value; }
		}

		public System.String Name
		{
			get => reinforcement.Name;
			set { reinforcement.Name = value; }
		}

		public System.Int32 Class
		{
			get => reinforcement.Class;
			set { reinforcement.Class = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries NumberingSeries
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(reinforcement.NumberingSeries.GetTSObject());
			set { reinforcement.NumberingSeries = value.GetTSObject(); }
		}

		public System.Collections.ArrayList OnPlaneOffsets
		{
			get => reinforcement.OnPlaneOffsets;
			set { reinforcement.OnPlaneOffsets = value; }
		}

		public System.Double FromPlaneOffset
		{
			get => reinforcement.FromPlaneOffset;
			set { reinforcement.FromPlaneOffset = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum StartPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(reinforcement.StartPointOffsetType);
			set { reinforcement.StartPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(value); }
		}

		public System.Double StartPointOffsetValue
		{
			get => reinforcement.StartPointOffsetValue;
			set { reinforcement.StartPointOffsetValue = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum EndPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(reinforcement.EndPointOffsetType);
			set { reinforcement.EndPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(value); }
		}

		public System.Double EndPointOffsetValue
		{
			get => reinforcement.EndPointOffsetValue;
			set { reinforcement.EndPointOffsetValue = value; }
		}

		public System.Collections.ArrayList RadiusValues
		{
			get => reinforcement.RadiusValues;
			set { reinforcement.RadiusValues = value; }
		}

		public Dynamic.Tekla.Structures.Forming.DeformingType InputPointDeformingState
		{
			get => Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(reinforcement.InputPointDeformingState);
			set { reinforcement.InputPointDeformingState = Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => reinforcement.ModificationTime;
			set { reinforcement.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => reinforcement.IsUpToDate;
			set { reinforcement.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(reinforcement.Identifier.GetTSObject());
			set { reinforcement.Identifier = value.GetTSObject(); }
		}

        

        dynamic reinforcement;
        
        public Reinforcement()
        {
            this.reinforcement =  new Tekla.Structures.Model.Reinforcement();
        }

        public Reinforcement(dynamic tsObject)
        {
            this.reinforcement = tsObject;
			this.Father = new Dynamic.Tekla.Structures.Model.ModelObject(reinforcement.Father);
			this.Grade = reinforcement.Grade;
			this.Name = reinforcement.Name;
			this.Class = reinforcement.Class;
			this.NumberingSeries = new Dynamic.Tekla.Structures.Model.NumberingSeries(reinforcement.NumberingSeries);
			this.OnPlaneOffsets = reinforcement.OnPlaneOffsets;
			this.FromPlaneOffset = reinforcement.FromPlaneOffset;
			this.StartPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(reinforcement.StartPointOffsetType);
			this.StartPointOffsetValue = reinforcement.StartPointOffsetValue;
			this.EndPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(reinforcement.EndPointOffsetType);
			this.EndPointOffsetValue = reinforcement.EndPointOffsetValue;
			this.RadiusValues = reinforcement.RadiusValues;
			this.InputPointDeformingState = Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(reinforcement.InputPointDeformingState);
			this.ModificationTime = reinforcement.ModificationTime;
			this.IsUpToDate = reinforcement.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(reinforcement.Identifier);

        }


        public dynamic GetTSObject() => reinforcement;

		public System.Collections.ArrayList GetRebarGeometries(Dynamic.Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum options)
			 => reinforcement.GetRebarGeometries(options.GetTSObject());

		public System.Collections.ArrayList GetRebarGeometries(System.Boolean withHooks)
			 => reinforcement.GetRebarGeometries(withHooks);

		public System.Collections.ArrayList GetRebarGeometriesWithoutClashes(System.Boolean withHooks)
			 => reinforcement.GetRebarGeometriesWithoutClashes(withHooks);

		public System.Boolean IsGeometryValid()
			 => reinforcement.IsGeometryValid();

		public System.Int32 GetNumberOfRebars()
			 => reinforcement.GetNumberOfRebars();

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebar(System.Int32 index, System.Boolean withHooks)
			 => new Dynamic.Tekla.Structures.Model.RebarGeometry(reinforcement.GetSingleRebar(index, withHooks));

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebarWithoutClash(System.Int32 index, System.Boolean withHooks)
			 => new Dynamic.Tekla.Structures.Model.RebarGeometry(reinforcement.GetSingleRebarWithoutClash(index, withHooks));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(reinforcement.GetSolid());

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => new Dynamic.Tekla.Structures.Model.PourObject(reinforcement.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => new Dynamic.Tekla.Structures.Model.PourUnit(reinforcement.GetFatherPourUnit());

		public System.Boolean Insert()
			 => reinforcement.Insert();

		public System.Boolean Select()
			 => reinforcement.Select();

		public System.Boolean Modify()
			 => reinforcement.Modify();

		public System.Boolean Delete()
			 => reinforcement.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(reinforcement.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(reinforcement.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(reinforcement.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => reinforcement.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => reinforcement.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => reinforcement.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => reinforcement.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => reinforcement.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => reinforcement.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => reinforcement.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => reinforcement.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => reinforcement.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => reinforcement.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => reinforcement.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => reinforcement.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => reinforcement.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => reinforcement.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => reinforcement.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => reinforcement.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => reinforcement.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => reinforcement.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => reinforcement.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(reinforcement.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => reinforcement.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => reinforcement.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => reinforcement.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => reinforcement.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => reinforcement.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => reinforcement.Equals(obj);

		public System.Int32 GetHashCode()
			 => reinforcement.GetHashCode();

		public System.Type GetType()
			 => reinforcement.GetType();

		public System.String ToString()
			 => reinforcement.ToString();




    public enum RebarGeometryOptionEnum
    {
			NONE,
			HOOKS,
			AVOID_CLASH,
			LENGTH_ADJUSTMENTS        
    }

    public static class RebarGeometryOptionEnum_
    {
        public static dynamic GetTSObject(RebarGeometryOptionEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarGeometryOptionEnum");

            switch (dynEnum)
            {
				case RebarGeometryOptionEnum.NONE:
					return System.Enum.Parse(tsType, "NONE");
				case RebarGeometryOptionEnum.HOOKS:
					return System.Enum.Parse(tsType, "HOOKS");
				case RebarGeometryOptionEnum.AVOID_CLASH:
					return System.Enum.Parse(tsType, "AVOID_CLASH");
				case RebarGeometryOptionEnum.LENGTH_ADJUSTMENTS:
					return System.Enum.Parse(tsType, "LENGTH_ADJUSTMENTS");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarGeometryOptionEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NONE", System.StringComparison.InvariantCulture))
				return RebarGeometryOptionEnum.NONE;
			else if (tsEnumValue.Equals("HOOKS", System.StringComparison.InvariantCulture))
				return RebarGeometryOptionEnum.HOOKS;
			else if (tsEnumValue.Equals("AVOID_CLASH", System.StringComparison.InvariantCulture))
				return RebarGeometryOptionEnum.AVOID_CLASH;
			else if (tsEnumValue.Equals("LENGTH_ADJUSTMENTS", System.StringComparison.InvariantCulture))
				return RebarGeometryOptionEnum.LENGTH_ADJUSTMENTS;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarOffsetTypeEnum
    {
			OFFSET_TYPE_COVER_THICKNESS,
			OFFSET_TYPE_LEG_LENGTH        
    }

    public static class RebarOffsetTypeEnum_
    {
        public static dynamic GetTSObject(RebarOffsetTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarOffsetTypeEnum");

            switch (dynEnum)
            {
				case RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS:
					return System.Enum.Parse(tsType, "OFFSET_TYPE_COVER_THICKNESS");
				case RebarOffsetTypeEnum.OFFSET_TYPE_LEG_LENGTH:
					return System.Enum.Parse(tsType, "OFFSET_TYPE_LEG_LENGTH");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarOffsetTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("OFFSET_TYPE_COVER_THICKNESS", System.StringComparison.InvariantCulture))
				return RebarOffsetTypeEnum.OFFSET_TYPE_COVER_THICKNESS;
			else if (tsEnumValue.Equals("OFFSET_TYPE_LEG_LENGTH", System.StringComparison.InvariantCulture))
				return RebarOffsetTypeEnum.OFFSET_TYPE_LEG_LENGTH;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
