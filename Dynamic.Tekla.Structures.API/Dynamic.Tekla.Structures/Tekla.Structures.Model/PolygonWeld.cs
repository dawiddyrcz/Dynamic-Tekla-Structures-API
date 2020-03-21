//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class PolygonWeld  : Dynamic.Tekla.Structures.Model.BaseWeld
    {

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.Polygon);
			set { teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject MainObject
		{
			get => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.MainObject);
			set { teklaObject.MainObject = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject SecondaryObject
		{
			get => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.SecondaryObject);
			set { teklaObject.SecondaryObject = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value); }
		}

		public System.Double SizeAbove
		{
			get => teklaObject.SizeAbove;
			set { teklaObject.SizeAbove = value; }
		}

		public System.Double AdditionalSizeAbove
		{
			get => teklaObject.AdditionalSizeAbove;
			set { teklaObject.AdditionalSizeAbove = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum TypeAbove
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(teklaObject.TypeAbove);
			set { teklaObject.TypeAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.GetTSObject(value); }
		}

		public System.Double AngleAbove
		{
			get => teklaObject.AngleAbove;
			set { teklaObject.AngleAbove = value; }
		}

		public System.Double LengthAbove
		{
			get => teklaObject.LengthAbove;
			set { teklaObject.LengthAbove = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum ContourAbove
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(teklaObject.ContourAbove);
			set { teklaObject.ContourAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum FinishAbove
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(teklaObject.FinishAbove);
			set { teklaObject.FinishAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.GetTSObject(value); }
		}

		public System.Double PitchAbove
		{
			get => teklaObject.PitchAbove;
			set { teklaObject.PitchAbove = value; }
		}

		public System.Double SizeBelow
		{
			get => teklaObject.SizeBelow;
			set { teklaObject.SizeBelow = value; }
		}

		public System.Double AdditionalSizeBelow
		{
			get => teklaObject.AdditionalSizeBelow;
			set { teklaObject.AdditionalSizeBelow = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum TypeBelow
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(teklaObject.TypeBelow);
			set { teklaObject.TypeBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.GetTSObject(value); }
		}

		public System.Double AngleBelow
		{
			get => teklaObject.AngleBelow;
			set { teklaObject.AngleBelow = value; }
		}

		public System.Double LengthBelow
		{
			get => teklaObject.LengthBelow;
			set { teklaObject.LengthBelow = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum ContourBelow
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(teklaObject.ContourBelow);
			set { teklaObject.ContourBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum FinishBelow
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(teklaObject.FinishBelow);
			set { teklaObject.FinishBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.GetTSObject(value); }
		}

		public System.Double PitchBelow
		{
			get => teklaObject.PitchBelow;
			set { teklaObject.PitchBelow = value; }
		}

		public System.Boolean ShopWeld
		{
			get => teklaObject.ShopWeld;
			set { teklaObject.ShopWeld = value; }
		}

		public System.Boolean AroundWeld
		{
			get => teklaObject.AroundWeld;
			set { teklaObject.AroundWeld = value; }
		}

		public System.Boolean StitchWeld
		{
			get => teklaObject.StitchWeld;
			set { teklaObject.StitchWeld = value; }
		}

		public System.Double RootOpeningAbove
		{
			get => teklaObject.RootOpeningAbove;
			set { teklaObject.RootOpeningAbove = value; }
		}

		public System.Double RootFaceAbove
		{
			get => teklaObject.RootFaceAbove;
			set { teklaObject.RootFaceAbove = value; }
		}

		public System.Double EffectiveThroatAbove
		{
			get => teklaObject.EffectiveThroatAbove;
			set { teklaObject.EffectiveThroatAbove = value; }
		}

		public System.Int32 IncrementAmountAbove
		{
			get => teklaObject.IncrementAmountAbove;
			set { teklaObject.IncrementAmountAbove = value; }
		}

		public System.Double RootOpeningBelow
		{
			get => teklaObject.RootOpeningBelow;
			set { teklaObject.RootOpeningBelow = value; }
		}

		public System.Double RootFaceBelow
		{
			get => teklaObject.RootFaceBelow;
			set { teklaObject.RootFaceBelow = value; }
		}

		public System.Double EffectiveThroatBelow
		{
			get => teklaObject.EffectiveThroatBelow;
			set { teklaObject.EffectiveThroatBelow = value; }
		}

		public System.Int32 IncrementAmountBelow
		{
			get => teklaObject.IncrementAmountBelow;
			set { teklaObject.IncrementAmountBelow = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum ElectrodeClassification
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum_.FromTSObject(teklaObject.ElectrodeClassification);
			set { teklaObject.ElectrodeClassification = Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum_.GetTSObject(value); }
		}

		public System.Double ElectrodeStrength
		{
			get => teklaObject.ElectrodeStrength;
			set { teklaObject.ElectrodeStrength = value; }
		}

		public System.Double ElectrodeCoefficient
		{
			get => teklaObject.ElectrodeCoefficient;
			set { teklaObject.ElectrodeCoefficient = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum ProcessType
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum_.FromTSObject(teklaObject.ProcessType);
			set { teklaObject.ProcessType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum NDTInspection
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum_.FromTSObject(teklaObject.NDTInspection);
			set { teklaObject.NDTInspection = Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum_.GetTSObject(value); }
		}

		public System.Boolean ConnectAssemblies
		{
			get => teklaObject.ConnectAssemblies;
			set { teklaObject.ConnectAssemblies = value; }
		}

		public System.String ReferenceText
		{
			get => teklaObject.ReferenceText;
			set { teklaObject.ReferenceText = value; }
		}

		public System.String PrefixAboveLine
		{
			get => teklaObject.PrefixAboveLine;
			set { teklaObject.PrefixAboveLine = value; }
		}

		public System.String PrefixBelowLine
		{
			get => teklaObject.PrefixBelowLine;
			set { teklaObject.PrefixBelowLine = value; }
		}

		public System.String Standard
		{
			get => teklaObject.Standard;
			set { teklaObject.Standard = value; }
		}

		public System.Int32 WeldNumber
		{
			get => teklaObject.WeldNumber;
			set { teklaObject.WeldNumber = value; }
		}

		public System.String WeldNumberPrefix
		{
			get => teklaObject.WeldNumberPrefix;
			set { teklaObject.WeldNumberPrefix = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum IntermittentType
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum_.FromTSObject(teklaObject.IntermittentType);
			set { teklaObject.IntermittentType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum Placement
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum_.FromTSObject(teklaObject.Placement);
			set { teklaObject.Placement = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum Preparation
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum_.FromTSObject(teklaObject.Preparation);
			set { teklaObject.Preparation = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum_.GetTSObject(value); }
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

		public PolygonWeld()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolygonWeld");
		}

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Select()
			 => teklaObject.Select();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public System.Boolean GetLogicalWeld(Dynamic.Tekla.Structures.Model.LogicalWeld LogicalWeld)
			 => teklaObject.GetLogicalWeld(Dynamic.Tekla.Structures.Model.LogicalWeld_.GetTSObject(LogicalWeld));

		public System.Collections.ArrayList GetWeldGeometries()
			 => teklaObject.GetWeldGeometries();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());

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





    }

    internal static class PolygonWeld_
    {
        public static dynamic GetTSObject(PolygonWeld dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PolygonWeld FromTSObject(dynamic tsObject)
        {
            return new PolygonWeld() { teklaObject = tsObject };
        }
    }


}
    
