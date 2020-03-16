//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class CurvedRebarGroup 
    {

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => new Dynamic.Tekla.Structures.Model.Polygon(curvedrebargroup.Polygon.GetTSObject());
			set { curvedrebargroup.Polygon = value.GetTSObject(); }
		}

		public System.String Size
		{
			get => curvedrebargroup.Size;
			set { curvedrebargroup.Size = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData StartHook
		{
			get => new Dynamic.Tekla.Structures.Model.RebarHookData(curvedrebargroup.StartHook.GetTSObject());
			set { curvedrebargroup.StartHook = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData EndHook
		{
			get => new Dynamic.Tekla.Structures.Model.RebarHookData(curvedrebargroup.EndHook.GetTSObject());
			set { curvedrebargroup.EndHook = value.GetTSObject(); }
		}

		public System.Double FromPlaneOffset
		{
			get => curvedrebargroup.FromPlaneOffset;
			set { curvedrebargroup.FromPlaneOffset = value; }
		}

		public System.Double StartFromPlaneOffset
		{
			get => curvedrebargroup.StartFromPlaneOffset;
			set { curvedrebargroup.StartFromPlaneOffset = value; }
		}

		public System.Double EndFromPlaneOffset
		{
			get => curvedrebargroup.EndFromPlaneOffset;
			set { curvedrebargroup.EndFromPlaneOffset = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum ExcludeType
		{
			get => Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.FromTSObject(curvedrebargroup.ExcludeType);
			set { curvedrebargroup.ExcludeType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum SpacingType
		{
			get => Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(curvedrebargroup.SpacingType);
			set { curvedrebargroup.SpacingType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(value); }
		}

		public System.Collections.ArrayList Spacings
		{
			get => curvedrebargroup.Spacings;
			set { curvedrebargroup.Spacings = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(curvedrebargroup.StartPoint.GetTSObject());
			set { curvedrebargroup.StartPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(curvedrebargroup.EndPoint.GetTSObject());
			set { curvedrebargroup.EndPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(curvedrebargroup.Father.GetTSObject());
			set { curvedrebargroup.Father = value.GetTSObject(); }
		}

		public System.String Grade
		{
			get => curvedrebargroup.Grade;
			set { curvedrebargroup.Grade = value; }
		}

		public System.String Name
		{
			get => curvedrebargroup.Name;
			set { curvedrebargroup.Name = value; }
		}

		public System.Int32 Class
		{
			get => curvedrebargroup.Class;
			set { curvedrebargroup.Class = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries NumberingSeries
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(curvedrebargroup.NumberingSeries.GetTSObject());
			set { curvedrebargroup.NumberingSeries = value.GetTSObject(); }
		}

		public System.Collections.ArrayList OnPlaneOffsets
		{
			get => curvedrebargroup.OnPlaneOffsets;
			set { curvedrebargroup.OnPlaneOffsets = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum StartPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(curvedrebargroup.StartPointOffsetType);
			set { curvedrebargroup.StartPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(value); }
		}

		public System.Double StartPointOffsetValue
		{
			get => curvedrebargroup.StartPointOffsetValue;
			set { curvedrebargroup.StartPointOffsetValue = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum EndPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(curvedrebargroup.EndPointOffsetType);
			set { curvedrebargroup.EndPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(value); }
		}

		public System.Double EndPointOffsetValue
		{
			get => curvedrebargroup.EndPointOffsetValue;
			set { curvedrebargroup.EndPointOffsetValue = value; }
		}

		public System.Collections.ArrayList RadiusValues
		{
			get => curvedrebargroup.RadiusValues;
			set { curvedrebargroup.RadiusValues = value; }
		}

		public Dynamic.Tekla.Structures.Forming.DeformingType InputPointDeformingState
		{
			get => Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(curvedrebargroup.InputPointDeformingState);
			set { curvedrebargroup.InputPointDeformingState = Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(value); }
		}

		public System.NullableSystem.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089<System.DateTime> ModificationTime
		{
			get => curvedrebargroup.ModificationTime;
			set { curvedrebargroup.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => curvedrebargroup.IsUpToDate;
			set { curvedrebargroup.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(curvedrebargroup.Identifier.GetTSObject());
			set { curvedrebargroup.Identifier = value.GetTSObject(); }
		}

        

        dynamic curvedrebargroup;
        
        public CurvedRebarGroup()
        {
            this.curvedrebargroup =  new Tekla.Structures.Model.CurvedRebarGroup();
        }

        public CurvedRebarGroup(dynamic tsObject)
        {
            this.curvedrebargroup = tsObject;
			this.Polygon = new Dynamic.Tekla.Structures.Model.Polygon(curvedrebargroup.Polygon);
			this.Size = curvedrebargroup.Size;
			this.StartHook = new Dynamic.Tekla.Structures.Model.RebarHookData(curvedrebargroup.StartHook);
			this.EndHook = new Dynamic.Tekla.Structures.Model.RebarHookData(curvedrebargroup.EndHook);
			this.FromPlaneOffset = curvedrebargroup.FromPlaneOffset;
			this.StartFromPlaneOffset = curvedrebargroup.StartFromPlaneOffset;
			this.EndFromPlaneOffset = curvedrebargroup.EndFromPlaneOffset;
			this.ExcludeType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.FromTSObject(curvedrebargroup.ExcludeType);
			this.SpacingType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(curvedrebargroup.SpacingType);
			this.Spacings = curvedrebargroup.Spacings;
			this.StartPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(curvedrebargroup.StartPoint);
			this.EndPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(curvedrebargroup.EndPoint);
			this.Father = new Dynamic.Tekla.Structures.Model.ModelObject(curvedrebargroup.Father);
			this.Grade = curvedrebargroup.Grade;
			this.Name = curvedrebargroup.Name;
			this.Class = curvedrebargroup.Class;
			this.NumberingSeries = new Dynamic.Tekla.Structures.Model.NumberingSeries(curvedrebargroup.NumberingSeries);
			this.OnPlaneOffsets = curvedrebargroup.OnPlaneOffsets;
			this.StartPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(curvedrebargroup.StartPointOffsetType);
			this.StartPointOffsetValue = curvedrebargroup.StartPointOffsetValue;
			this.EndPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(curvedrebargroup.EndPointOffsetType);
			this.EndPointOffsetValue = curvedrebargroup.EndPointOffsetValue;
			this.RadiusValues = curvedrebargroup.RadiusValues;
			this.InputPointDeformingState = Dynamic.Tekla.Structures.Forming.DeformingType_.FromTSObject(curvedrebargroup.InputPointDeformingState);
			this.ModificationTime = curvedrebargroup.ModificationTime;
			this.IsUpToDate = curvedrebargroup.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(curvedrebargroup.Identifier);

        }


        public dynamic GetTSObject() => curvedrebargroup;

		public System.Boolean Insert()
			 => curvedrebargroup.Insert();

		public System.Boolean Select()
			 => curvedrebargroup.Select();

		public System.Boolean Modify()
			 => curvedrebargroup.Modify();

		public System.Boolean Delete()
			 => curvedrebargroup.Delete();

		public System.Collections.ArrayList GetRebarGeometries(Dynamic.Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum options)
			 => curvedrebargroup.GetRebarGeometries(options.GetTSObject());

		public System.Collections.ArrayList GetRebarGeometries(System.Boolean withHooks)
			 => curvedrebargroup.GetRebarGeometries(withHooks);

		public System.Collections.ArrayList GetRebarGeometriesWithoutClashes(System.Boolean withHooks)
			 => curvedrebargroup.GetRebarGeometriesWithoutClashes(withHooks);

		public System.Boolean IsGeometryValid()
			 => curvedrebargroup.IsGeometryValid();

		public System.Int32 GetNumberOfRebars()
			 => curvedrebargroup.GetNumberOfRebars();

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebar(System.Int32 index, System.Boolean withHooks)
			 => new Dynamic.Tekla.Structures.Model.RebarGeometry(curvedrebargroup.GetSingleRebar(index, withHooks));

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebarWithoutClash(System.Int32 index, System.Boolean withHooks)
			 => new Dynamic.Tekla.Structures.Model.RebarGeometry(curvedrebargroup.GetSingleRebarWithoutClash(index, withHooks));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(curvedrebargroup.GetSolid());

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => new Dynamic.Tekla.Structures.Model.PourObject(curvedrebargroup.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => new Dynamic.Tekla.Structures.Model.PourUnit(curvedrebargroup.GetFatherPourUnit());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(curvedrebargroup.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(curvedrebargroup.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(curvedrebargroup.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => curvedrebargroup.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => curvedrebargroup.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => curvedrebargroup.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => curvedrebargroup.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => curvedrebargroup.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => curvedrebargroup.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => curvedrebargroup.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => curvedrebargroup.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => curvedrebargroup.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => curvedrebargroup.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => curvedrebargroup.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => curvedrebargroup.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => curvedrebargroup.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => curvedrebargroup.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => curvedrebargroup.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => curvedrebargroup.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => curvedrebargroup.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => curvedrebargroup.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => curvedrebargroup.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(curvedrebargroup.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => curvedrebargroup.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => curvedrebargroup.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => curvedrebargroup.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => curvedrebargroup.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => curvedrebargroup.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => curvedrebargroup.Equals(obj);

		public System.Int32 GetHashCode()
			 => curvedrebargroup.GetHashCode();

		public System.Type GetType()
			 => curvedrebargroup.GetType();

		public System.String ToString()
			 => curvedrebargroup.ToString();





    }

}
    
