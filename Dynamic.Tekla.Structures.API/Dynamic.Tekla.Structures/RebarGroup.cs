//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarGroup 
    {

		public System.Collections.ArrayList Polygons
		{
			get => rebargroup.Polygons;
			set { rebargroup.Polygons = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarGroup.RebarGroupStirrupTypeEnum StirrupType
		{
			get => Dynamic.Tekla.Structures.Model.RebarGroup.RebarGroupStirrupTypeEnum_.FromTSObject(rebargroup.StirrupType);
			set { rebargroup.StirrupType = Dynamic.Tekla.Structures.Model.RebarGroup.RebarGroupStirrupTypeEnum_.FromTSObject(value); }
		}

		public System.String Size
		{
			get => rebargroup.Size;
			set { rebargroup.Size = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData StartHook
		{
			get => new Dynamic.Tekla.Structures.Model.RebarHookData(rebargroup.StartHook.GetTSObject());
			set { rebargroup.StartHook = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData EndHook
		{
			get => new Dynamic.Tekla.Structures.Model.RebarHookData(rebargroup.EndHook.GetTSObject());
			set { rebargroup.EndHook = value.GetTSObject(); }
		}

		public System.Double FromPlaneOffset
		{
			get => rebargroup.FromPlaneOffset;
			set { rebargroup.FromPlaneOffset = value; }
		}

		public System.Double StartFromPlaneOffset
		{
			get => rebargroup.StartFromPlaneOffset;
			set { rebargroup.StartFromPlaneOffset = value; }
		}

		public System.Double EndFromPlaneOffset
		{
			get => rebargroup.EndFromPlaneOffset;
			set { rebargroup.EndFromPlaneOffset = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum ExcludeType
		{
			get => Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.FromTSObject(rebargroup.ExcludeType);
			set { rebargroup.ExcludeType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum SpacingType
		{
			get => Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(rebargroup.SpacingType);
			set { rebargroup.SpacingType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(value); }
		}

		public System.Collections.ArrayList Spacings
		{
			get => rebargroup.Spacings;
			set { rebargroup.Spacings = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(rebargroup.StartPoint.GetTSObject());
			set { rebargroup.StartPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(rebargroup.EndPoint.GetTSObject());
			set { rebargroup.EndPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(rebargroup.Father.GetTSObject());
			set { rebargroup.Father = value.GetTSObject(); }
		}

		public System.String Grade
		{
			get => rebargroup.Grade;
			set { rebargroup.Grade = value; }
		}

		public System.String Name
		{
			get => rebargroup.Name;
			set { rebargroup.Name = value; }
		}

		public System.Int32 Class
		{
			get => rebargroup.Class;
			set { rebargroup.Class = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries NumberingSeries
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(rebargroup.NumberingSeries.GetTSObject());
			set { rebargroup.NumberingSeries = value.GetTSObject(); }
		}

		public System.Collections.ArrayList OnPlaneOffsets
		{
			get => rebargroup.OnPlaneOffsets;
			set { rebargroup.OnPlaneOffsets = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum StartPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(rebargroup.StartPointOffsetType);
			set { rebargroup.StartPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(value); }
		}

		public System.Double StartPointOffsetValue
		{
			get => rebargroup.StartPointOffsetValue;
			set { rebargroup.StartPointOffsetValue = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum EndPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(rebargroup.EndPointOffsetType);
			set { rebargroup.EndPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(value); }
		}

		public System.Double EndPointOffsetValue
		{
			get => rebargroup.EndPointOffsetValue;
			set { rebargroup.EndPointOffsetValue = value; }
		}

		public System.Collections.ArrayList RadiusValues
		{
			get => rebargroup.RadiusValues;
			set { rebargroup.RadiusValues = value; }
		}

		public Dynamic.Tekla.Structures.Forming.DeformingType InputPointDeformingState
		{
			get => Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(rebargroup.InputPointDeformingState);
			set { rebargroup.InputPointDeformingState = Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => rebargroup.ModificationTime;
			set { rebargroup.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => rebargroup.IsUpToDate;
			set { rebargroup.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(rebargroup.Identifier.GetTSObject());
			set { rebargroup.Identifier = value.GetTSObject(); }
		}

        

        dynamic rebargroup;
        
        public RebarGroup()
        {
            this.rebargroup =  TSActivator.CreateInstance("Tekla.Structures.Model.RebarGroup");
        }

        public RebarGroup(dynamic tsObject)
        {
            this.rebargroup = tsObject;
			this.Polygons = rebargroup.Polygons;
			this.StirrupType = Dynamic.Tekla.Structures.Model.RebarGroup.RebarGroupStirrupTypeEnum_.FromTSObject(rebargroup.StirrupType);
			this.Size = rebargroup.Size;
			this.StartHook = new Dynamic.Tekla.Structures.Model.RebarHookData(rebargroup.StartHook);
			this.EndHook = new Dynamic.Tekla.Structures.Model.RebarHookData(rebargroup.EndHook);
			this.FromPlaneOffset = rebargroup.FromPlaneOffset;
			this.StartFromPlaneOffset = rebargroup.StartFromPlaneOffset;
			this.EndFromPlaneOffset = rebargroup.EndFromPlaneOffset;
			this.ExcludeType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.FromTSObject(rebargroup.ExcludeType);
			this.SpacingType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(rebargroup.SpacingType);
			this.Spacings = rebargroup.Spacings;
			this.StartPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(rebargroup.StartPoint);
			this.EndPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(rebargroup.EndPoint);
			this.Father = new Dynamic.Tekla.Structures.Model.ModelObject(rebargroup.Father);
			this.Grade = rebargroup.Grade;
			this.Name = rebargroup.Name;
			this.Class = rebargroup.Class;
			this.NumberingSeries = new Dynamic.Tekla.Structures.Model.NumberingSeries(rebargroup.NumberingSeries);
			this.OnPlaneOffsets = rebargroup.OnPlaneOffsets;
			this.StartPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(rebargroup.StartPointOffsetType);
			this.StartPointOffsetValue = rebargroup.StartPointOffsetValue;
			this.EndPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(rebargroup.EndPointOffsetType);
			this.EndPointOffsetValue = rebargroup.EndPointOffsetValue;
			this.RadiusValues = rebargroup.RadiusValues;
			this.InputPointDeformingState = Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(rebargroup.InputPointDeformingState);
			this.ModificationTime = rebargroup.ModificationTime;
			this.IsUpToDate = rebargroup.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(rebargroup.Identifier);

        }


        public dynamic GetTSObject() => rebargroup;

		public System.Boolean Insert()
			 => rebargroup.Insert();

		public System.Boolean Select()
			 => rebargroup.Select();

		public System.Boolean Modify()
			 => rebargroup.Modify();

		public System.Boolean Delete()
			 => rebargroup.Delete();


		public System.Collections.ArrayList GetRebarGeometries(System.Boolean withHooks)
			 => rebargroup.GetRebarGeometries(withHooks);

		public System.Collections.ArrayList GetRebarGeometriesWithoutClashes(System.Boolean withHooks)
			 => rebargroup.GetRebarGeometriesWithoutClashes(withHooks);

		public System.Boolean IsGeometryValid()
			 => rebargroup.IsGeometryValid();

		public System.Int32 GetNumberOfRebars()
			 => rebargroup.GetNumberOfRebars();

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebar(System.Int32 index, System.Boolean withHooks)
			 => new Dynamic.Tekla.Structures.Model.RebarGeometry(rebargroup.GetSingleRebar(index, withHooks));

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebarWithoutClash(System.Int32 index, System.Boolean withHooks)
			 => new Dynamic.Tekla.Structures.Model.RebarGeometry(rebargroup.GetSingleRebarWithoutClash(index, withHooks));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(rebargroup.GetSolid());

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => new Dynamic.Tekla.Structures.Model.PourObject(rebargroup.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => new Dynamic.Tekla.Structures.Model.PourUnit(rebargroup.GetFatherPourUnit());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(rebargroup.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(rebargroup.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(rebargroup.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => rebargroup.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => rebargroup.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => rebargroup.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => rebargroup.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => rebargroup.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => rebargroup.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => rebargroup.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => rebargroup.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => rebargroup.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => rebargroup.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => rebargroup.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => rebargroup.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => rebargroup.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => rebargroup.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => rebargroup.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => rebargroup.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => rebargroup.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => rebargroup.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => rebargroup.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(rebargroup.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => rebargroup.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => rebargroup.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => rebargroup.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => rebargroup.CompareTo(obj);




    public enum RebarGroupStirrupTypeEnum
    {
			STIRRUP_TYPE_POLYGONAL,
			STIRRUP_TYPE_SPIRAL,
			STIRRUP_TYPE_TAPERED_CURVED        
    }

    public static class RebarGroupStirrupTypeEnum_
    {
        public static dynamic GetTSObject(RebarGroupStirrupTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarGroupStirrupTypeEnum");

            switch (dynEnum)
            {
				case RebarGroupStirrupTypeEnum.STIRRUP_TYPE_POLYGONAL:
					return System.Enum.Parse(tsType, "STIRRUP_TYPE_POLYGONAL");
				case RebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL:
					return System.Enum.Parse(tsType, "STIRRUP_TYPE_SPIRAL");
				case RebarGroupStirrupTypeEnum.STIRRUP_TYPE_TAPERED_CURVED:
					return System.Enum.Parse(tsType, "STIRRUP_TYPE_TAPERED_CURVED");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarGroupStirrupTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("STIRRUP_TYPE_POLYGONAL", System.StringComparison.InvariantCulture))
				return RebarGroupStirrupTypeEnum.STIRRUP_TYPE_POLYGONAL;
			else if (tsEnumValue.Equals("STIRRUP_TYPE_SPIRAL", System.StringComparison.InvariantCulture))
				return RebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL;
			else if (tsEnumValue.Equals("STIRRUP_TYPE_TAPERED_CURVED", System.StringComparison.InvariantCulture))
				return RebarGroupStirrupTypeEnum.STIRRUP_TYPE_TAPERED_CURVED;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
