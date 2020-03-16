//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class LogicalWeld 
    {

		public Dynamic.Tekla.Structures.Model.ModelObject MainObject
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(logicalweld.MainObject.GetTSObject());
			set { logicalweld.MainObject = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject SecondaryObject
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(logicalweld.SecondaryObject.GetTSObject());
			set { logicalweld.SecondaryObject = value.GetTSObject(); }
		}

		public System.Double SizeAbove
		{
			get => logicalweld.SizeAbove;
			set { logicalweld.SizeAbove = value; }
		}

		public System.Double AdditionalSizeAbove
		{
			get => logicalweld.AdditionalSizeAbove;
			set { logicalweld.AdditionalSizeAbove = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum TypeAbove
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(logicalweld.TypeAbove);
			set { logicalweld.TypeAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(value); }
		}

		public System.Double AngleAbove
		{
			get => logicalweld.AngleAbove;
			set { logicalweld.AngleAbove = value; }
		}

		public System.Double LengthAbove
		{
			get => logicalweld.LengthAbove;
			set { logicalweld.LengthAbove = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum ContourAbove
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(logicalweld.ContourAbove);
			set { logicalweld.ContourAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum FinishAbove
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(logicalweld.FinishAbove);
			set { logicalweld.FinishAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(value); }
		}

		public System.Double PitchAbove
		{
			get => logicalweld.PitchAbove;
			set { logicalweld.PitchAbove = value; }
		}

		public System.Double SizeBelow
		{
			get => logicalweld.SizeBelow;
			set { logicalweld.SizeBelow = value; }
		}

		public System.Double AdditionalSizeBelow
		{
			get => logicalweld.AdditionalSizeBelow;
			set { logicalweld.AdditionalSizeBelow = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum TypeBelow
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(logicalweld.TypeBelow);
			set { logicalweld.TypeBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(value); }
		}

		public System.Double AngleBelow
		{
			get => logicalweld.AngleBelow;
			set { logicalweld.AngleBelow = value; }
		}

		public System.Double LengthBelow
		{
			get => logicalweld.LengthBelow;
			set { logicalweld.LengthBelow = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum ContourBelow
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(logicalweld.ContourBelow);
			set { logicalweld.ContourBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum FinishBelow
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(logicalweld.FinishBelow);
			set { logicalweld.FinishBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(value); }
		}

		public System.Double PitchBelow
		{
			get => logicalweld.PitchBelow;
			set { logicalweld.PitchBelow = value; }
		}

		public System.Boolean ShopWeld
		{
			get => logicalweld.ShopWeld;
			set { logicalweld.ShopWeld = value; }
		}

		public System.Boolean AroundWeld
		{
			get => logicalweld.AroundWeld;
			set { logicalweld.AroundWeld = value; }
		}

		public System.Boolean StitchWeld
		{
			get => logicalweld.StitchWeld;
			set { logicalweld.StitchWeld = value; }
		}

		public System.Double RootOpeningAbove
		{
			get => logicalweld.RootOpeningAbove;
			set { logicalweld.RootOpeningAbove = value; }
		}

		public System.Double RootFaceAbove
		{
			get => logicalweld.RootFaceAbove;
			set { logicalweld.RootFaceAbove = value; }
		}

		public System.Double EffectiveThroatAbove
		{
			get => logicalweld.EffectiveThroatAbove;
			set { logicalweld.EffectiveThroatAbove = value; }
		}

		public System.Int32 IncrementAmountAbove
		{
			get => logicalweld.IncrementAmountAbove;
			set { logicalweld.IncrementAmountAbove = value; }
		}

		public System.Double RootOpeningBelow
		{
			get => logicalweld.RootOpeningBelow;
			set { logicalweld.RootOpeningBelow = value; }
		}

		public System.Double RootFaceBelow
		{
			get => logicalweld.RootFaceBelow;
			set { logicalweld.RootFaceBelow = value; }
		}

		public System.Double EffectiveThroatBelow
		{
			get => logicalweld.EffectiveThroatBelow;
			set { logicalweld.EffectiveThroatBelow = value; }
		}

		public System.Int32 IncrementAmountBelow
		{
			get => logicalweld.IncrementAmountBelow;
			set { logicalweld.IncrementAmountBelow = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum ElectrodeClassification
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum_.FromTSObject(logicalweld.ElectrodeClassification);
			set { logicalweld.ElectrodeClassification = Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum_.FromTSObject(value); }
		}

		public System.Double ElectrodeStrength
		{
			get => logicalweld.ElectrodeStrength;
			set { logicalweld.ElectrodeStrength = value; }
		}

		public System.Double ElectrodeCoefficient
		{
			get => logicalweld.ElectrodeCoefficient;
			set { logicalweld.ElectrodeCoefficient = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum ProcessType
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum_.FromTSObject(logicalweld.ProcessType);
			set { logicalweld.ProcessType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum NDTInspection
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum_.FromTSObject(logicalweld.NDTInspection);
			set { logicalweld.NDTInspection = Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum_.FromTSObject(value); }
		}

		public System.Boolean ConnectAssemblies
		{
			get => logicalweld.ConnectAssemblies;
			set { logicalweld.ConnectAssemblies = value; }
		}

		public System.String ReferenceText
		{
			get => logicalweld.ReferenceText;
			set { logicalweld.ReferenceText = value; }
		}

		public System.String PrefixAboveLine
		{
			get => logicalweld.PrefixAboveLine;
			set { logicalweld.PrefixAboveLine = value; }
		}

		public System.String PrefixBelowLine
		{
			get => logicalweld.PrefixBelowLine;
			set { logicalweld.PrefixBelowLine = value; }
		}

		public System.String Standard
		{
			get => logicalweld.Standard;
			set { logicalweld.Standard = value; }
		}

		public System.Int32 WeldNumber
		{
			get => logicalweld.WeldNumber;
			set { logicalweld.WeldNumber = value; }
		}

		public System.String WeldNumberPrefix
		{
			get => logicalweld.WeldNumberPrefix;
			set { logicalweld.WeldNumberPrefix = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum IntermittentType
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum_.FromTSObject(logicalweld.IntermittentType);
			set { logicalweld.IntermittentType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum Placement
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum_.FromTSObject(logicalweld.Placement);
			set { logicalweld.Placement = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum Preparation
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum_.FromTSObject(logicalweld.Preparation);
			set { logicalweld.Preparation = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum_.FromTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => logicalweld.ModificationTime;
			set { logicalweld.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => logicalweld.IsUpToDate;
			set { logicalweld.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(logicalweld.Identifier.GetTSObject());
			set { logicalweld.Identifier = value.GetTSObject(); }
		}

        

        dynamic logicalweld;
        
        public LogicalWeld()
        {
            this.logicalweld =  new Tekla.Structures.Model.LogicalWeld();
        }

        public LogicalWeld(dynamic tsObject)
        {
            this.logicalweld = tsObject;
			this.MainObject = new Dynamic.Tekla.Structures.Model.ModelObject(logicalweld.MainObject);
			this.SecondaryObject = new Dynamic.Tekla.Structures.Model.ModelObject(logicalweld.SecondaryObject);
			this.SizeAbove = logicalweld.SizeAbove;
			this.AdditionalSizeAbove = logicalweld.AdditionalSizeAbove;
			this.TypeAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(logicalweld.TypeAbove);
			this.AngleAbove = logicalweld.AngleAbove;
			this.LengthAbove = logicalweld.LengthAbove;
			this.ContourAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(logicalweld.ContourAbove);
			this.FinishAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(logicalweld.FinishAbove);
			this.PitchAbove = logicalweld.PitchAbove;
			this.SizeBelow = logicalweld.SizeBelow;
			this.AdditionalSizeBelow = logicalweld.AdditionalSizeBelow;
			this.TypeBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(logicalweld.TypeBelow);
			this.AngleBelow = logicalweld.AngleBelow;
			this.LengthBelow = logicalweld.LengthBelow;
			this.ContourBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(logicalweld.ContourBelow);
			this.FinishBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(logicalweld.FinishBelow);
			this.PitchBelow = logicalweld.PitchBelow;
			this.ShopWeld = logicalweld.ShopWeld;
			this.AroundWeld = logicalweld.AroundWeld;
			this.StitchWeld = logicalweld.StitchWeld;
			this.RootOpeningAbove = logicalweld.RootOpeningAbove;
			this.RootFaceAbove = logicalweld.RootFaceAbove;
			this.EffectiveThroatAbove = logicalweld.EffectiveThroatAbove;
			this.IncrementAmountAbove = logicalweld.IncrementAmountAbove;
			this.RootOpeningBelow = logicalweld.RootOpeningBelow;
			this.RootFaceBelow = logicalweld.RootFaceBelow;
			this.EffectiveThroatBelow = logicalweld.EffectiveThroatBelow;
			this.IncrementAmountBelow = logicalweld.IncrementAmountBelow;
			this.ElectrodeClassification = Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum_.FromTSObject(logicalweld.ElectrodeClassification);
			this.ElectrodeStrength = logicalweld.ElectrodeStrength;
			this.ElectrodeCoefficient = logicalweld.ElectrodeCoefficient;
			this.ProcessType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum_.FromTSObject(logicalweld.ProcessType);
			this.NDTInspection = Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum_.FromTSObject(logicalweld.NDTInspection);
			this.ConnectAssemblies = logicalweld.ConnectAssemblies;
			this.ReferenceText = logicalweld.ReferenceText;
			this.PrefixAboveLine = logicalweld.PrefixAboveLine;
			this.PrefixBelowLine = logicalweld.PrefixBelowLine;
			this.Standard = logicalweld.Standard;
			this.WeldNumber = logicalweld.WeldNumber;
			this.WeldNumberPrefix = logicalweld.WeldNumberPrefix;
			this.IntermittentType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum_.FromTSObject(logicalweld.IntermittentType);
			this.Placement = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum_.FromTSObject(logicalweld.Placement);
			this.Preparation = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum_.FromTSObject(logicalweld.Preparation);
			this.ModificationTime = logicalweld.ModificationTime;
			this.IsUpToDate = logicalweld.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(logicalweld.Identifier);

        }


        public dynamic GetTSObject() => logicalweld;

		public System.Boolean AddWeld(Dynamic.Tekla.Structures.Model.BaseWeld Weld)
			 => logicalweld.AddWeld(Weld.GetTSObject());

		public Dynamic.Tekla.Structures.Model.BaseWeld GetMainWeld()
			 => new Dynamic.Tekla.Structures.Model.BaseWeld(logicalweld.GetMainWeld());

		public System.Boolean SetMainWeld(Dynamic.Tekla.Structures.Model.BaseWeld Weld)
			 => logicalweld.SetMainWeld(Weld.GetTSObject());

		public System.Boolean RemoveWeld(Dynamic.Tekla.Structures.Model.BaseWeld Weld)
			 => logicalweld.RemoveWeld(Weld.GetTSObject());

		public System.Boolean Explode()
			 => logicalweld.Explode();

		public System.Boolean Insert()
			 => logicalweld.Insert();

		public System.Boolean Select()
			 => logicalweld.Select();

		public System.Boolean Select(Dynamic.Tekla.Structures.Model.BaseWeld ChildWeld)
			 => logicalweld.Select(ChildWeld.GetTSObject());

		public System.Boolean Modify()
			 => logicalweld.Modify();

		public System.Boolean Delete()
			 => logicalweld.Delete();

		public System.Collections.ArrayList GetWeldGeometries()
			 => logicalweld.GetWeldGeometries();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(logicalweld.GetSolid());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(logicalweld.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(logicalweld.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(logicalweld.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => logicalweld.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => logicalweld.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => logicalweld.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => logicalweld.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => logicalweld.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => logicalweld.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => logicalweld.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => logicalweld.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => logicalweld.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => logicalweld.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => logicalweld.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => logicalweld.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => logicalweld.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => logicalweld.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => logicalweld.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => logicalweld.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => logicalweld.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => logicalweld.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => logicalweld.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(logicalweld.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => logicalweld.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => logicalweld.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => logicalweld.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => logicalweld.CompareTo(obj);





    }

}
    
