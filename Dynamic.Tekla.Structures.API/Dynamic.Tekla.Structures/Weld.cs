//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Weld 
    {

		public Dynamic.Tekla.Structures.Model.Weld.WeldPositionEnum Position
		{
			get => Dynamic.Tekla.Structures.Model.Weld.WeldPositionEnum_.FromTSObject(weld.Position);
			set { weld.Position = Dynamic.Tekla.Structures.Model.Weld.WeldPositionEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Direction
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(weld.Direction.GetTSObject());
			set { weld.Direction = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject MainObject
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(weld.MainObject.GetTSObject());
			set { weld.MainObject = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject SecondaryObject
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(weld.SecondaryObject.GetTSObject());
			set { weld.SecondaryObject = value.GetTSObject(); }
		}

		public System.Double SizeAbove
		{
			get => weld.SizeAbove;
			set { weld.SizeAbove = value; }
		}

		public System.Double AdditionalSizeAbove
		{
			get => weld.AdditionalSizeAbove;
			set { weld.AdditionalSizeAbove = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum TypeAbove
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(weld.TypeAbove);
			set { weld.TypeAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(value); }
		}

		public System.Double AngleAbove
		{
			get => weld.AngleAbove;
			set { weld.AngleAbove = value; }
		}

		public System.Double LengthAbove
		{
			get => weld.LengthAbove;
			set { weld.LengthAbove = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum ContourAbove
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(weld.ContourAbove);
			set { weld.ContourAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum FinishAbove
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(weld.FinishAbove);
			set { weld.FinishAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(value); }
		}

		public System.Double PitchAbove
		{
			get => weld.PitchAbove;
			set { weld.PitchAbove = value; }
		}

		public System.Double SizeBelow
		{
			get => weld.SizeBelow;
			set { weld.SizeBelow = value; }
		}

		public System.Double AdditionalSizeBelow
		{
			get => weld.AdditionalSizeBelow;
			set { weld.AdditionalSizeBelow = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum TypeBelow
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(weld.TypeBelow);
			set { weld.TypeBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(value); }
		}

		public System.Double AngleBelow
		{
			get => weld.AngleBelow;
			set { weld.AngleBelow = value; }
		}

		public System.Double LengthBelow
		{
			get => weld.LengthBelow;
			set { weld.LengthBelow = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum ContourBelow
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(weld.ContourBelow);
			set { weld.ContourBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum FinishBelow
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(weld.FinishBelow);
			set { weld.FinishBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(value); }
		}

		public System.Double PitchBelow
		{
			get => weld.PitchBelow;
			set { weld.PitchBelow = value; }
		}

		public System.Boolean ShopWeld
		{
			get => weld.ShopWeld;
			set { weld.ShopWeld = value; }
		}

		public System.Boolean AroundWeld
		{
			get => weld.AroundWeld;
			set { weld.AroundWeld = value; }
		}

		public System.Boolean StitchWeld
		{
			get => weld.StitchWeld;
			set { weld.StitchWeld = value; }
		}

		public System.Double RootOpeningAbove
		{
			get => weld.RootOpeningAbove;
			set { weld.RootOpeningAbove = value; }
		}

		public System.Double RootFaceAbove
		{
			get => weld.RootFaceAbove;
			set { weld.RootFaceAbove = value; }
		}

		public System.Double EffectiveThroatAbove
		{
			get => weld.EffectiveThroatAbove;
			set { weld.EffectiveThroatAbove = value; }
		}

		public System.Int32 IncrementAmountAbove
		{
			get => weld.IncrementAmountAbove;
			set { weld.IncrementAmountAbove = value; }
		}

		public System.Double RootOpeningBelow
		{
			get => weld.RootOpeningBelow;
			set { weld.RootOpeningBelow = value; }
		}

		public System.Double RootFaceBelow
		{
			get => weld.RootFaceBelow;
			set { weld.RootFaceBelow = value; }
		}

		public System.Double EffectiveThroatBelow
		{
			get => weld.EffectiveThroatBelow;
			set { weld.EffectiveThroatBelow = value; }
		}

		public System.Int32 IncrementAmountBelow
		{
			get => weld.IncrementAmountBelow;
			set { weld.IncrementAmountBelow = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum ElectrodeClassification
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum_.FromTSObject(weld.ElectrodeClassification);
			set { weld.ElectrodeClassification = Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum_.FromTSObject(value); }
		}

		public System.Double ElectrodeStrength
		{
			get => weld.ElectrodeStrength;
			set { weld.ElectrodeStrength = value; }
		}

		public System.Double ElectrodeCoefficient
		{
			get => weld.ElectrodeCoefficient;
			set { weld.ElectrodeCoefficient = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum ProcessType
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum_.FromTSObject(weld.ProcessType);
			set { weld.ProcessType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum NDTInspection
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum_.FromTSObject(weld.NDTInspection);
			set { weld.NDTInspection = Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum_.FromTSObject(value); }
		}

		public System.Boolean ConnectAssemblies
		{
			get => weld.ConnectAssemblies;
			set { weld.ConnectAssemblies = value; }
		}

		public System.String ReferenceText
		{
			get => weld.ReferenceText;
			set { weld.ReferenceText = value; }
		}

		public System.String PrefixAboveLine
		{
			get => weld.PrefixAboveLine;
			set { weld.PrefixAboveLine = value; }
		}

		public System.String PrefixBelowLine
		{
			get => weld.PrefixBelowLine;
			set { weld.PrefixBelowLine = value; }
		}

		public System.String Standard
		{
			get => weld.Standard;
			set { weld.Standard = value; }
		}

		public System.Int32 WeldNumber
		{
			get => weld.WeldNumber;
			set { weld.WeldNumber = value; }
		}

		public System.String WeldNumberPrefix
		{
			get => weld.WeldNumberPrefix;
			set { weld.WeldNumberPrefix = value; }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum IntermittentType
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum_.FromTSObject(weld.IntermittentType);
			set { weld.IntermittentType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum Placement
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum_.FromTSObject(weld.Placement);
			set { weld.Placement = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum Preparation
		{
			get => Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum_.FromTSObject(weld.Preparation);
			set { weld.Preparation = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum_.FromTSObject(value); }
		}

		public System.NullableSystem.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089<System.DateTime> ModificationTime
		{
			get => weld.ModificationTime;
			set { weld.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => weld.IsUpToDate;
			set { weld.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(weld.Identifier.GetTSObject());
			set { weld.Identifier = value.GetTSObject(); }
		}

        

        dynamic weld;
        
        public Weld()
        {
            this.weld =  new Tekla.Structures.Model.Weld();
        }

        public Weld(dynamic tsObject)
        {
            this.weld = tsObject;
			this.Position = Dynamic.Tekla.Structures.Model.Weld.WeldPositionEnum_.FromTSObject(weld.Position);
			this.Direction = new Dynamic.Tekla.Structures.Geometry3d.Vector(weld.Direction);
			this.MainObject = new Dynamic.Tekla.Structures.Model.ModelObject(weld.MainObject);
			this.SecondaryObject = new Dynamic.Tekla.Structures.Model.ModelObject(weld.SecondaryObject);
			this.SizeAbove = weld.SizeAbove;
			this.AdditionalSizeAbove = weld.AdditionalSizeAbove;
			this.TypeAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(weld.TypeAbove);
			this.AngleAbove = weld.AngleAbove;
			this.LengthAbove = weld.LengthAbove;
			this.ContourAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(weld.ContourAbove);
			this.FinishAbove = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(weld.FinishAbove);
			this.PitchAbove = weld.PitchAbove;
			this.SizeBelow = weld.SizeBelow;
			this.AdditionalSizeBelow = weld.AdditionalSizeBelow;
			this.TypeBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldTypeEnum_.FromTSObject(weld.TypeBelow);
			this.AngleBelow = weld.AngleBelow;
			this.LengthBelow = weld.LengthBelow;
			this.ContourBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldContourEnum_.FromTSObject(weld.ContourBelow);
			this.FinishBelow = Dynamic.Tekla.Structures.Model.BaseWeld.WeldFinishEnum_.FromTSObject(weld.FinishBelow);
			this.PitchBelow = weld.PitchBelow;
			this.ShopWeld = weld.ShopWeld;
			this.AroundWeld = weld.AroundWeld;
			this.StitchWeld = weld.StitchWeld;
			this.RootOpeningAbove = weld.RootOpeningAbove;
			this.RootFaceAbove = weld.RootFaceAbove;
			this.EffectiveThroatAbove = weld.EffectiveThroatAbove;
			this.IncrementAmountAbove = weld.IncrementAmountAbove;
			this.RootOpeningBelow = weld.RootOpeningBelow;
			this.RootFaceBelow = weld.RootFaceBelow;
			this.EffectiveThroatBelow = weld.EffectiveThroatBelow;
			this.IncrementAmountBelow = weld.IncrementAmountBelow;
			this.ElectrodeClassification = Dynamic.Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum_.FromTSObject(weld.ElectrodeClassification);
			this.ElectrodeStrength = weld.ElectrodeStrength;
			this.ElectrodeCoefficient = weld.ElectrodeCoefficient;
			this.ProcessType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum_.FromTSObject(weld.ProcessType);
			this.NDTInspection = Dynamic.Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum_.FromTSObject(weld.NDTInspection);
			this.ConnectAssemblies = weld.ConnectAssemblies;
			this.ReferenceText = weld.ReferenceText;
			this.PrefixAboveLine = weld.PrefixAboveLine;
			this.PrefixBelowLine = weld.PrefixBelowLine;
			this.Standard = weld.Standard;
			this.WeldNumber = weld.WeldNumber;
			this.WeldNumberPrefix = weld.WeldNumberPrefix;
			this.IntermittentType = Dynamic.Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum_.FromTSObject(weld.IntermittentType);
			this.Placement = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum_.FromTSObject(weld.Placement);
			this.Preparation = Dynamic.Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum_.FromTSObject(weld.Preparation);
			this.ModificationTime = weld.ModificationTime;
			this.IsUpToDate = weld.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(weld.Identifier);

        }


        public dynamic GetTSObject() => weld;

		public System.Boolean Insert()
			 => weld.Insert();

		public System.Boolean Select()
			 => weld.Select();

		public System.Boolean Modify()
			 => weld.Modify();

		public System.Boolean Delete()
			 => weld.Delete();

		public System.Boolean GetLogicalWeld(ref Dynamic.Tekla.Structures.Model.LogicalWeld LogicalWeld)
			 => weld.GetLogicalWeld(ref LogicalWeld.GetTSObject());

		public System.Collections.ArrayList GetWeldGeometries()
			 => weld.GetWeldGeometries();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(weld.GetSolid());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(weld.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(weld.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(weld.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => weld.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => weld.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => weld.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => weld.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => weld.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => weld.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => weld.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => weld.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => weld.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => weld.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => weld.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => weld.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => weld.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => weld.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => weld.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => weld.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => weld.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => weld.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => weld.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(weld.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => weld.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => weld.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => weld.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => weld.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => weld.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => weld.Equals(obj);

		public System.Int32 GetHashCode()
			 => weld.GetHashCode();

		public System.Type GetType()
			 => weld.GetType();

		public System.String ToString()
			 => weld.ToString();




    public enum WeldPositionEnum
    {
			WELD_POSITION_PLUS_X,
			WELD_POSITION_MINUS_X,
			WELD_POSITION_PLUS_Y,
			WELD_POSITION_MINUS_Y,
			WELD_POSITION_PLUS_Z,
			WELD_POSITION_MINUS_Z        
    }

    public static class WeldPositionEnum_
    {
        public static dynamic GetTSObject(WeldPositionEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.WeldPositionEnum");

            switch (dynEnum)
            {
				case WeldPositionEnum.WELD_POSITION_PLUS_X:
					return System.Enum.Parse(tsType, "WELD_POSITION_PLUS_X");
				case WeldPositionEnum.WELD_POSITION_MINUS_X:
					return System.Enum.Parse(tsType, "WELD_POSITION_MINUS_X");
				case WeldPositionEnum.WELD_POSITION_PLUS_Y:
					return System.Enum.Parse(tsType, "WELD_POSITION_PLUS_Y");
				case WeldPositionEnum.WELD_POSITION_MINUS_Y:
					return System.Enum.Parse(tsType, "WELD_POSITION_MINUS_Y");
				case WeldPositionEnum.WELD_POSITION_PLUS_Z:
					return System.Enum.Parse(tsType, "WELD_POSITION_PLUS_Z");
				case WeldPositionEnum.WELD_POSITION_MINUS_Z:
					return System.Enum.Parse(tsType, "WELD_POSITION_MINUS_Z");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldPositionEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WELD_POSITION_PLUS_X", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_PLUS_X;
			else if (tsEnumValue.Equals("WELD_POSITION_MINUS_X", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_MINUS_X;
			else if (tsEnumValue.Equals("WELD_POSITION_PLUS_Y", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_PLUS_Y;
			else if (tsEnumValue.Equals("WELD_POSITION_MINUS_Y", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_MINUS_Y;
			else if (tsEnumValue.Equals("WELD_POSITION_PLUS_Z", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_PLUS_Z;
			else if (tsEnumValue.Equals("WELD_POSITION_MINUS_Z", System.StringComparison.InvariantCulture))
				return WeldPositionEnum.WELD_POSITION_MINUS_Z;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
