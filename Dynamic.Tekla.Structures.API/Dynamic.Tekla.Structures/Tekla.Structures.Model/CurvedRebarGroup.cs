//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class CurvedRebarGroup 
    {

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(curvedrebargroup.Polygon);
			set { curvedrebargroup.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value); }
		}

		public System.String Size
		{
			get => curvedrebargroup.Size;
			set { curvedrebargroup.Size = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData StartHook
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(curvedrebargroup.StartHook);
			set { curvedrebargroup.StartHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData EndHook
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(curvedrebargroup.EndHook);
			set { curvedrebargroup.EndHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value); }
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
			set { curvedrebargroup.ExcludeType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum SpacingType
		{
			get => Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(curvedrebargroup.SpacingType);
			set { curvedrebargroup.SpacingType = Dynamic.Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum_.GetTSObject(value); }
		}

		public System.Collections.ArrayList Spacings
		{
			get => curvedrebargroup.Spacings;
			set { curvedrebargroup.Spacings = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(curvedrebargroup.StartPoint);
			set { curvedrebargroup.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(curvedrebargroup.EndPoint);
			set { curvedrebargroup.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(curvedrebargroup.Father);
			set { curvedrebargroup.Father = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value); }
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
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(curvedrebargroup.NumberingSeries);
			set { curvedrebargroup.NumberingSeries = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public System.Collections.ArrayList OnPlaneOffsets
		{
			get => curvedrebargroup.OnPlaneOffsets;
			set { curvedrebargroup.OnPlaneOffsets = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum StartPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(curvedrebargroup.StartPointOffsetType);
			set { curvedrebargroup.StartPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.GetTSObject(value); }
		}

		public System.Double StartPointOffsetValue
		{
			get => curvedrebargroup.StartPointOffsetValue;
			set { curvedrebargroup.StartPointOffsetValue = value; }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum EndPointOffsetType
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.FromTSObject(curvedrebargroup.EndPointOffsetType);
			set { curvedrebargroup.EndPointOffsetType = Dynamic.Tekla.Structures.Model.Reinforcement.RebarOffsetTypeEnum_.GetTSObject(value); }
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
			set { curvedrebargroup.InputPointDeformingState = Dynamic.Tekla.Structures.Forming.DeformingType_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
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
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(curvedrebargroup.Identifier);
			set { curvedrebargroup.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic curvedrebargroup;
        
        public CurvedRebarGroup()
        {
            this.curvedrebargroup =  TSActivator.CreateInstance("Tekla.Structures.Model.CurvedRebarGroup");
        }

        internal CurvedRebarGroup(dynamic tsObject)
        {
            this.curvedrebargroup = tsObject;
        }

		public System.Boolean Insert()
			 => curvedrebargroup.Insert();

		public System.Boolean Select()
			 => curvedrebargroup.Select();

		public System.Boolean Modify()
			 => curvedrebargroup.Modify();

		public System.Boolean Delete()
			 => curvedrebargroup.Delete();

		public System.Collections.ArrayList GetRebarGeometries(Dynamic.Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum options)
			 => curvedrebargroup.GetRebarGeometries(Dynamic.Tekla.Structures.Model.Reinforcement.RebarGeometryOptionEnum_.GetTSObject(options));

		public System.Collections.ArrayList GetRebarGeometries(System.Boolean withHooks)
			 => curvedrebargroup.GetRebarGeometries(withHooks);

		public System.Collections.ArrayList GetRebarGeometriesWithoutClashes(System.Boolean withHooks)
			 => curvedrebargroup.GetRebarGeometriesWithoutClashes(withHooks);

		public System.Boolean IsGeometryValid()
			 => curvedrebargroup.IsGeometryValid();

		public System.Int32 GetNumberOfRebars()
			 => curvedrebargroup.GetNumberOfRebars();

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebar(System.Int32 index, System.Boolean withHooks)
			 => Dynamic.Tekla.Structures.Model.RebarGeometry_.FromTSObject(curvedrebargroup.GetSingleRebar(index, withHooks));

		public Dynamic.Tekla.Structures.Model.RebarGeometry GetSingleRebarWithoutClash(System.Int32 index, System.Boolean withHooks)
			 => Dynamic.Tekla.Structures.Model.RebarGeometry_.FromTSObject(curvedrebargroup.GetSingleRebarWithoutClash(index, withHooks));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(curvedrebargroup.GetSolid());

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => Dynamic.Tekla.Structures.Model.PourObject_.FromTSObject(curvedrebargroup.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(curvedrebargroup.GetFatherPourUnit());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(curvedrebargroup.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(curvedrebargroup.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(curvedrebargroup.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => curvedrebargroup.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => curvedrebargroup.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => curvedrebargroup.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => curvedrebargroup.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => curvedrebargroup.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => curvedrebargroup.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => curvedrebargroup.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => curvedrebargroup.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => curvedrebargroup.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => curvedrebargroup.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => curvedrebargroup.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => curvedrebargroup.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => curvedrebargroup.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => curvedrebargroup.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => curvedrebargroup.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => curvedrebargroup.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => curvedrebargroup.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => curvedrebargroup.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => curvedrebargroup.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(curvedrebargroup.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => curvedrebargroup.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => curvedrebargroup.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => curvedrebargroup.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => curvedrebargroup.CompareTo(obj);





    }

    internal static class CurvedRebarGroup_
    {
        public static dynamic GetTSObject(CurvedRebarGroup dynObject)
        {
            return dynObject.curvedrebargroup;
        }

        public static CurvedRebarGroup FromTSObject(dynamic tsObject)
        {
            return new CurvedRebarGroup(tsObject);
        }
    }


}
    