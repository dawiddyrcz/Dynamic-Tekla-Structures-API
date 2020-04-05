/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BaseWeld  : Dynamic.Tekla.Structures.Model.ModelObject
    {

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

        

        


		public System.Collections.ArrayList GetWeldGeometries()
		{
			try {
			return teklaObject.GetWeldGeometries();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetWeldGeometries()"); }
		}

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
		{
			try {
			return Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSolid()"); }
		}




    public enum WeldTypeEnum
    {
			WELD_TYPE_NONE,
			WELD_TYPE_EDGE_FLANGE,
			WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT,
			WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT,
			WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT,
			WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE,
			WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE,
			WELD_TYPE_U_GROOVE_SINGLE_U_BUTT,
			WELD_TYPE_J_GROOVE_J_BUTT,
			WELD_TYPE_BEVEL_BACKING,
			WELD_TYPE_FILLET,
			WELD_TYPE_PLUG,
			WELD_TYPE_SPOT,
			WELD_TYPE_SEAM,
			WELD_TYPE_SLOT,
			WELD_TYPE_FLARE_BEVEL_GROOVE,
			WELD_TYPE_FLARE_V_GROOVE,
			WELD_TYPE_CORNER_FLANGE,
			WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET,
			WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET,
			WELD_TYPE_MELT_THROUGH,
			STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT,
			STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT,
			WELD_TYPE_EDGE,
			WELD_TYPE_ISO_SURFACING,
			WELD_TYPE_FOLD,
			WELD_TYPE_INCLINED        
    }

    internal static class WeldTypeEnum_
    {
        public static dynamic GetTSObject(WeldTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldTypeEnum").GetType();

            switch (dynEnum)
            {
				case WeldTypeEnum.WELD_TYPE_NONE:
					return System.Enum.Parse(tsType, "WELD_TYPE_NONE");
				case WeldTypeEnum.WELD_TYPE_EDGE_FLANGE:
					return System.Enum.Parse(tsType, "WELD_TYPE_EDGE_FLANGE");
				case WeldTypeEnum.WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT:
					return System.Enum.Parse(tsType, "WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT");
				case WeldTypeEnum.WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT:
					return System.Enum.Parse(tsType, "WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT");
				case WeldTypeEnum.WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT:
					return System.Enum.Parse(tsType, "WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT");
				case WeldTypeEnum.WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE:
					return System.Enum.Parse(tsType, "WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE");
				case WeldTypeEnum.WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE:
					return System.Enum.Parse(tsType, "WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE");
				case WeldTypeEnum.WELD_TYPE_U_GROOVE_SINGLE_U_BUTT:
					return System.Enum.Parse(tsType, "WELD_TYPE_U_GROOVE_SINGLE_U_BUTT");
				case WeldTypeEnum.WELD_TYPE_J_GROOVE_J_BUTT:
					return System.Enum.Parse(tsType, "WELD_TYPE_J_GROOVE_J_BUTT");
				case WeldTypeEnum.WELD_TYPE_BEVEL_BACKING:
					return System.Enum.Parse(tsType, "WELD_TYPE_BEVEL_BACKING");
				case WeldTypeEnum.WELD_TYPE_FILLET:
					return System.Enum.Parse(tsType, "WELD_TYPE_FILLET");
				case WeldTypeEnum.WELD_TYPE_PLUG:
					return System.Enum.Parse(tsType, "WELD_TYPE_PLUG");
				case WeldTypeEnum.WELD_TYPE_SPOT:
					return System.Enum.Parse(tsType, "WELD_TYPE_SPOT");
				case WeldTypeEnum.WELD_TYPE_SEAM:
					return System.Enum.Parse(tsType, "WELD_TYPE_SEAM");
				case WeldTypeEnum.WELD_TYPE_SLOT:
					return System.Enum.Parse(tsType, "WELD_TYPE_SLOT");
				case WeldTypeEnum.WELD_TYPE_FLARE_BEVEL_GROOVE:
					return System.Enum.Parse(tsType, "WELD_TYPE_FLARE_BEVEL_GROOVE");
				case WeldTypeEnum.WELD_TYPE_FLARE_V_GROOVE:
					return System.Enum.Parse(tsType, "WELD_TYPE_FLARE_V_GROOVE");
				case WeldTypeEnum.WELD_TYPE_CORNER_FLANGE:
					return System.Enum.Parse(tsType, "WELD_TYPE_CORNER_FLANGE");
				case WeldTypeEnum.WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET:
					return System.Enum.Parse(tsType, "WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET");
				case WeldTypeEnum.WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET:
					return System.Enum.Parse(tsType, "WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET");
				case WeldTypeEnum.WELD_TYPE_MELT_THROUGH:
					return System.Enum.Parse(tsType, "WELD_TYPE_MELT_THROUGH");
				case WeldTypeEnum.STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT:
					return System.Enum.Parse(tsType, "STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT");
				case WeldTypeEnum.STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT:
					return System.Enum.Parse(tsType, "STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT");
				case WeldTypeEnum.WELD_TYPE_EDGE:
					return System.Enum.Parse(tsType, "WELD_TYPE_EDGE");
				case WeldTypeEnum.WELD_TYPE_ISO_SURFACING:
					return System.Enum.Parse(tsType, "WELD_TYPE_ISO_SURFACING");
				case WeldTypeEnum.WELD_TYPE_FOLD:
					return System.Enum.Parse(tsType, "WELD_TYPE_FOLD");
				case WeldTypeEnum.WELD_TYPE_INCLINED:
					return System.Enum.Parse(tsType, "WELD_TYPE_INCLINED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WELD_TYPE_NONE", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_NONE;
			else if (tsEnumValue.Equals("WELD_TYPE_EDGE_FLANGE", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_EDGE_FLANGE;
			else if (tsEnumValue.Equals("WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_SQUARE_GROOVE_SQUARE_BUTT;
			else if (tsEnumValue.Equals("WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_BEVEL_GROOVE_SINGLE_V_BUTT;
			else if (tsEnumValue.Equals("WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_BEVEL_GROOVE_SINGLE_BEVEL_BUTT;
			else if (tsEnumValue.Equals("WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_SINGLE_V_BUTT_WITH_BROAD_ROOT_FACE;
			else if (tsEnumValue.Equals("WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_SINGLE_BEVEL_BUTT_WITH_BROAD_ROOT_FACE;
			else if (tsEnumValue.Equals("WELD_TYPE_U_GROOVE_SINGLE_U_BUTT", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_U_GROOVE_SINGLE_U_BUTT;
			else if (tsEnumValue.Equals("WELD_TYPE_J_GROOVE_J_BUTT", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_J_GROOVE_J_BUTT;
			else if (tsEnumValue.Equals("WELD_TYPE_BEVEL_BACKING", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_BEVEL_BACKING;
			else if (tsEnumValue.Equals("WELD_TYPE_FILLET", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_FILLET;
			else if (tsEnumValue.Equals("WELD_TYPE_PLUG", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_PLUG;
			else if (tsEnumValue.Equals("WELD_TYPE_SPOT", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_SPOT;
			else if (tsEnumValue.Equals("WELD_TYPE_SEAM", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_SEAM;
			else if (tsEnumValue.Equals("WELD_TYPE_SLOT", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_SLOT;
			else if (tsEnumValue.Equals("WELD_TYPE_FLARE_BEVEL_GROOVE", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_FLARE_BEVEL_GROOVE;
			else if (tsEnumValue.Equals("WELD_TYPE_FLARE_V_GROOVE", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_FLARE_V_GROOVE;
			else if (tsEnumValue.Equals("WELD_TYPE_CORNER_FLANGE", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_CORNER_FLANGE;
			else if (tsEnumValue.Equals("WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_PARTIAL_PENETRATION_SINGLE_BEVEL_BUTT_PLUS_FILLET;
			else if (tsEnumValue.Equals("WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_PARTIAL_PENETRATION_SQUARE_GROOVE_PLUS_FILLET;
			else if (tsEnumValue.Equals("WELD_TYPE_MELT_THROUGH", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_MELT_THROUGH;
			else if (tsEnumValue.Equals("STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.STEEP_FLANKED_BEVEL_GROOVE_SINGLE_V_BUTT;
			else if (tsEnumValue.Equals("STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.STEEP_FLANKED_BEVEL_GROOVE_SINGLE_BEVEL_BUTT;
			else if (tsEnumValue.Equals("WELD_TYPE_EDGE", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_EDGE;
			else if (tsEnumValue.Equals("WELD_TYPE_ISO_SURFACING", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_ISO_SURFACING;
			else if (tsEnumValue.Equals("WELD_TYPE_FOLD", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_FOLD;
			else if (tsEnumValue.Equals("WELD_TYPE_INCLINED", System.StringComparison.InvariantCulture))
				return WeldTypeEnum.WELD_TYPE_INCLINED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum WeldContourEnum
    {
			WELD_CONTOUR_NONE,
			WELD_CONTOUR_FLUSH,
			WELD_CONTOUR_CONVEX,
			WELD_CONTOUR_CONCAVE        
    }

    internal static class WeldContourEnum_
    {
        public static dynamic GetTSObject(WeldContourEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldContourEnum").GetType();

            switch (dynEnum)
            {
				case WeldContourEnum.WELD_CONTOUR_NONE:
					return System.Enum.Parse(tsType, "WELD_CONTOUR_NONE");
				case WeldContourEnum.WELD_CONTOUR_FLUSH:
					return System.Enum.Parse(tsType, "WELD_CONTOUR_FLUSH");
				case WeldContourEnum.WELD_CONTOUR_CONVEX:
					return System.Enum.Parse(tsType, "WELD_CONTOUR_CONVEX");
				case WeldContourEnum.WELD_CONTOUR_CONCAVE:
					return System.Enum.Parse(tsType, "WELD_CONTOUR_CONCAVE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldContourEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WELD_CONTOUR_NONE", System.StringComparison.InvariantCulture))
				return WeldContourEnum.WELD_CONTOUR_NONE;
			else if (tsEnumValue.Equals("WELD_CONTOUR_FLUSH", System.StringComparison.InvariantCulture))
				return WeldContourEnum.WELD_CONTOUR_FLUSH;
			else if (tsEnumValue.Equals("WELD_CONTOUR_CONVEX", System.StringComparison.InvariantCulture))
				return WeldContourEnum.WELD_CONTOUR_CONVEX;
			else if (tsEnumValue.Equals("WELD_CONTOUR_CONCAVE", System.StringComparison.InvariantCulture))
				return WeldContourEnum.WELD_CONTOUR_CONCAVE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum WeldFinishEnum
    {
			WELD_FINISH_NONE,
			WELD_FINISH_GRIND,
			WELD_FINISH_MACHINE,
			WELD_FINISH_CHIP,
			WELD_FINISH_FINISHED_WELD,
			WELS_FINISH_SMOOTH_TRANSITION        
    }

    internal static class WeldFinishEnum_
    {
        public static dynamic GetTSObject(WeldFinishEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldFinishEnum").GetType();

            switch (dynEnum)
            {
				case WeldFinishEnum.WELD_FINISH_NONE:
					return System.Enum.Parse(tsType, "WELD_FINISH_NONE");
				case WeldFinishEnum.WELD_FINISH_GRIND:
					return System.Enum.Parse(tsType, "WELD_FINISH_GRIND");
				case WeldFinishEnum.WELD_FINISH_MACHINE:
					return System.Enum.Parse(tsType, "WELD_FINISH_MACHINE");
				case WeldFinishEnum.WELD_FINISH_CHIP:
					return System.Enum.Parse(tsType, "WELD_FINISH_CHIP");
				case WeldFinishEnum.WELD_FINISH_FINISHED_WELD:
					return System.Enum.Parse(tsType, "WELD_FINISH_FINISHED_WELD");
				case WeldFinishEnum.WELS_FINISH_SMOOTH_TRANSITION:
					return System.Enum.Parse(tsType, "WELS_FINISH_SMOOTH_TRANSITION");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldFinishEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WELD_FINISH_NONE", System.StringComparison.InvariantCulture))
				return WeldFinishEnum.WELD_FINISH_NONE;
			else if (tsEnumValue.Equals("WELD_FINISH_GRIND", System.StringComparison.InvariantCulture))
				return WeldFinishEnum.WELD_FINISH_GRIND;
			else if (tsEnumValue.Equals("WELD_FINISH_MACHINE", System.StringComparison.InvariantCulture))
				return WeldFinishEnum.WELD_FINISH_MACHINE;
			else if (tsEnumValue.Equals("WELD_FINISH_CHIP", System.StringComparison.InvariantCulture))
				return WeldFinishEnum.WELD_FINISH_CHIP;
			else if (tsEnumValue.Equals("WELD_FINISH_FINISHED_WELD", System.StringComparison.InvariantCulture))
				return WeldFinishEnum.WELD_FINISH_FINISHED_WELD;
			else if (tsEnumValue.Equals("WELS_FINISH_SMOOTH_TRANSITION", System.StringComparison.InvariantCulture))
				return WeldFinishEnum.WELS_FINISH_SMOOTH_TRANSITION;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum WeldElectrodeClassificationEnum
    {
			WELD_ELECTRODE_CLASSIFICATION_NONE,
			WELD_ELECTRODE_CLASSIFICATION_35,
			WELD_ELECTRODE_CLASSIFICATION_42,
			WELD_ELECTRODE_CLASSIFICATION_50,
			WELD_ELECTRODE_CLASSIFICATION_E60XX,
			WELD_ELECTRODE_CLASSIFICATION_E70XX,
			WELD_ELECTRODE_CLASSIFICATION_E80XX,
			WELD_ELECTRODE_CLASSIFICATION_E90XX        
    }

    internal static class WeldElectrodeClassificationEnum_
    {
        public static dynamic GetTSObject(WeldElectrodeClassificationEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldElectrodeClassificationEnum").GetType();

            switch (dynEnum)
            {
				case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_NONE:
					return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_NONE");
				case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_35:
					return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_35");
				case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_42:
					return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_42");
				case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_50:
					return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_50");
				case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E60XX:
					return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_E60XX");
				case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E70XX:
					return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_E70XX");
				case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E80XX:
					return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_E80XX");
				case WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E90XX:
					return System.Enum.Parse(tsType, "WELD_ELECTRODE_CLASSIFICATION_E90XX");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldElectrodeClassificationEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_NONE", System.StringComparison.InvariantCulture))
				return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_NONE;
			else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_35", System.StringComparison.InvariantCulture))
				return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_35;
			else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_42", System.StringComparison.InvariantCulture))
				return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_42;
			else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_50", System.StringComparison.InvariantCulture))
				return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_50;
			else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_E60XX", System.StringComparison.InvariantCulture))
				return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E60XX;
			else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_E70XX", System.StringComparison.InvariantCulture))
				return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E70XX;
			else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_E80XX", System.StringComparison.InvariantCulture))
				return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E80XX;
			else if (tsEnumValue.Equals("WELD_ELECTRODE_CLASSIFICATION_E90XX", System.StringComparison.InvariantCulture))
				return WeldElectrodeClassificationEnum.WELD_ELECTRODE_CLASSIFICATION_E90XX;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum WeldProcessTypeEnum
    {
			WELD_PROCESS_NONE,
			WELD_PROCESS_SMAW,
			WELD_PROCESS_SAW,
			WELD_PROCESS_GMAW,
			WELD_PROCESS_FCAW,
			WELD_PROCESS_ESW,
			WELD_PROCESS_EGW        
    }

    internal static class WeldProcessTypeEnum_
    {
        public static dynamic GetTSObject(WeldProcessTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldProcessTypeEnum").GetType();

            switch (dynEnum)
            {
				case WeldProcessTypeEnum.WELD_PROCESS_NONE:
					return System.Enum.Parse(tsType, "WELD_PROCESS_NONE");
				case WeldProcessTypeEnum.WELD_PROCESS_SMAW:
					return System.Enum.Parse(tsType, "WELD_PROCESS_SMAW");
				case WeldProcessTypeEnum.WELD_PROCESS_SAW:
					return System.Enum.Parse(tsType, "WELD_PROCESS_SAW");
				case WeldProcessTypeEnum.WELD_PROCESS_GMAW:
					return System.Enum.Parse(tsType, "WELD_PROCESS_GMAW");
				case WeldProcessTypeEnum.WELD_PROCESS_FCAW:
					return System.Enum.Parse(tsType, "WELD_PROCESS_FCAW");
				case WeldProcessTypeEnum.WELD_PROCESS_ESW:
					return System.Enum.Parse(tsType, "WELD_PROCESS_ESW");
				case WeldProcessTypeEnum.WELD_PROCESS_EGW:
					return System.Enum.Parse(tsType, "WELD_PROCESS_EGW");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldProcessTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WELD_PROCESS_NONE", System.StringComparison.InvariantCulture))
				return WeldProcessTypeEnum.WELD_PROCESS_NONE;
			else if (tsEnumValue.Equals("WELD_PROCESS_SMAW", System.StringComparison.InvariantCulture))
				return WeldProcessTypeEnum.WELD_PROCESS_SMAW;
			else if (tsEnumValue.Equals("WELD_PROCESS_SAW", System.StringComparison.InvariantCulture))
				return WeldProcessTypeEnum.WELD_PROCESS_SAW;
			else if (tsEnumValue.Equals("WELD_PROCESS_GMAW", System.StringComparison.InvariantCulture))
				return WeldProcessTypeEnum.WELD_PROCESS_GMAW;
			else if (tsEnumValue.Equals("WELD_PROCESS_FCAW", System.StringComparison.InvariantCulture))
				return WeldProcessTypeEnum.WELD_PROCESS_FCAW;
			else if (tsEnumValue.Equals("WELD_PROCESS_ESW", System.StringComparison.InvariantCulture))
				return WeldProcessTypeEnum.WELD_PROCESS_ESW;
			else if (tsEnumValue.Equals("WELD_PROCESS_EGW", System.StringComparison.InvariantCulture))
				return WeldProcessTypeEnum.WELD_PROCESS_EGW;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum WeldNDTInspectionEnum
    {
			WELD_NDT_INSPECTION_NONE,
			WELD_NDT_INSPECTION_A,
			WELD_NDT_INSPECTION_B,
			WELD_NDT_INSPECTION_C,
			WELD_NDT_INSPECTION_D,
			WELD_NDT_INSPECTION_E        
    }

    internal static class WeldNDTInspectionEnum_
    {
        public static dynamic GetTSObject(WeldNDTInspectionEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldNDTInspectionEnum").GetType();

            switch (dynEnum)
            {
				case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_NONE:
					return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_NONE");
				case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_A:
					return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_A");
				case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_B:
					return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_B");
				case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_C:
					return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_C");
				case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_D:
					return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_D");
				case WeldNDTInspectionEnum.WELD_NDT_INSPECTION_E:
					return System.Enum.Parse(tsType, "WELD_NDT_INSPECTION_E");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldNDTInspectionEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WELD_NDT_INSPECTION_NONE", System.StringComparison.InvariantCulture))
				return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_NONE;
			else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_A", System.StringComparison.InvariantCulture))
				return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_A;
			else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_B", System.StringComparison.InvariantCulture))
				return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_B;
			else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_C", System.StringComparison.InvariantCulture))
				return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_C;
			else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_D", System.StringComparison.InvariantCulture))
				return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_D;
			else if (tsEnumValue.Equals("WELD_NDT_INSPECTION_E", System.StringComparison.InvariantCulture))
				return WeldNDTInspectionEnum.WELD_NDT_INSPECTION_E;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum WeldIntermittentTypeEnum
    {
			CONTINUOUS,
			CHAIN_INTERMITTENT,
			STAGGERED_INTERMITTENT        
    }

    internal static class WeldIntermittentTypeEnum_
    {
        public static dynamic GetTSObject(WeldIntermittentTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldIntermittentTypeEnum").GetType();

            switch (dynEnum)
            {
				case WeldIntermittentTypeEnum.CONTINUOUS:
					return System.Enum.Parse(tsType, "CONTINUOUS");
				case WeldIntermittentTypeEnum.CHAIN_INTERMITTENT:
					return System.Enum.Parse(tsType, "CHAIN_INTERMITTENT");
				case WeldIntermittentTypeEnum.STAGGERED_INTERMITTENT:
					return System.Enum.Parse(tsType, "STAGGERED_INTERMITTENT");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldIntermittentTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CONTINUOUS", System.StringComparison.InvariantCulture))
				return WeldIntermittentTypeEnum.CONTINUOUS;
			else if (tsEnumValue.Equals("CHAIN_INTERMITTENT", System.StringComparison.InvariantCulture))
				return WeldIntermittentTypeEnum.CHAIN_INTERMITTENT;
			else if (tsEnumValue.Equals("STAGGERED_INTERMITTENT", System.StringComparison.InvariantCulture))
				return WeldIntermittentTypeEnum.STAGGERED_INTERMITTENT;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum WeldPlacementTypeEnum
    {
			PLACEMENT_AUTO,
			PLACEMENT_MAIN,
			PLACEMENT_SECONDARY        
    }

    internal static class WeldPlacementTypeEnum_
    {
        public static dynamic GetTSObject(WeldPlacementTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldPlacementTypeEnum").GetType();

            switch (dynEnum)
            {
				case WeldPlacementTypeEnum.PLACEMENT_AUTO:
					return System.Enum.Parse(tsType, "PLACEMENT_AUTO");
				case WeldPlacementTypeEnum.PLACEMENT_MAIN:
					return System.Enum.Parse(tsType, "PLACEMENT_MAIN");
				case WeldPlacementTypeEnum.PLACEMENT_SECONDARY:
					return System.Enum.Parse(tsType, "PLACEMENT_SECONDARY");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldPlacementTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PLACEMENT_AUTO", System.StringComparison.InvariantCulture))
				return WeldPlacementTypeEnum.PLACEMENT_AUTO;
			else if (tsEnumValue.Equals("PLACEMENT_MAIN", System.StringComparison.InvariantCulture))
				return WeldPlacementTypeEnum.PLACEMENT_MAIN;
			else if (tsEnumValue.Equals("PLACEMENT_SECONDARY", System.StringComparison.InvariantCulture))
				return WeldPlacementTypeEnum.PLACEMENT_SECONDARY;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum WeldPreparationTypeEnum
    {
			PREPARATION_NONE,
			PREPARATION_AUTO,
			PREPARATION_MAIN,
			PREPARATION_SECONDARY        
    }

    internal static class WeldPreparationTypeEnum_
    {
        public static dynamic GetTSObject(WeldPreparationTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseWeld.WeldPreparationTypeEnum").GetType();

            switch (dynEnum)
            {
				case WeldPreparationTypeEnum.PREPARATION_NONE:
					return System.Enum.Parse(tsType, "PREPARATION_NONE");
				case WeldPreparationTypeEnum.PREPARATION_AUTO:
					return System.Enum.Parse(tsType, "PREPARATION_AUTO");
				case WeldPreparationTypeEnum.PREPARATION_MAIN:
					return System.Enum.Parse(tsType, "PREPARATION_MAIN");
				case WeldPreparationTypeEnum.PREPARATION_SECONDARY:
					return System.Enum.Parse(tsType, "PREPARATION_SECONDARY");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static WeldPreparationTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PREPARATION_NONE", System.StringComparison.InvariantCulture))
				return WeldPreparationTypeEnum.PREPARATION_NONE;
			else if (tsEnumValue.Equals("PREPARATION_AUTO", System.StringComparison.InvariantCulture))
				return WeldPreparationTypeEnum.PREPARATION_AUTO;
			else if (tsEnumValue.Equals("PREPARATION_MAIN", System.StringComparison.InvariantCulture))
				return WeldPreparationTypeEnum.PREPARATION_MAIN;
			else if (tsEnumValue.Equals("PREPARATION_SECONDARY", System.StringComparison.InvariantCulture))
				return WeldPreparationTypeEnum.PREPARATION_SECONDARY;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BaseWeld_
    {
        public static dynamic GetTSObject(BaseWeld dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BaseWeld FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BaseWeld)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BaseWeldArray_
    {
        public static dynamic GetTSObject(BaseWeld[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BaseWeld_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BaseWeld[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BaseWeld>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BaseWeld_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
