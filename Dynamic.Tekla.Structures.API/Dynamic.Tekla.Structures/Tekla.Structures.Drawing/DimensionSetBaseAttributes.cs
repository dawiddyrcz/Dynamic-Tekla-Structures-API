/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class DimensionSetBaseAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes Arrowhead
		{
			get => Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.FromTSObject(teklaObject.Arrowhead);
			set { teklaObject.Arrowhead = Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

		public System.Boolean TransparentBackground
		{
			get => teklaObject.TransparentBackground;
			set { teklaObject.TransparentBackground = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionFormatAttributes Format
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionFormatAttributes_.FromTSObject(teklaObject.Format);
			set { teklaObject.Format = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionFormatAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionPlacingAttributes Placing
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionPlacingAttributes_.FromTSObject(teklaObject.Placing);
			set { teklaObject.Placing = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionPlacingAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextAttributes Text
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextAttributes_.FromTSObject(teklaObject.Text);
			set { teklaObject.Text = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextAttributes_.GetTSObject(value); }
		}

        

        





    public enum DimensionValuePrecisions
    {
			Whole,
			OnePerTwo,
			OnePerThree,
			OnePerFour,
			OnePerEight,
			OnePerTen,
			OnePerSixteen,
			OnePerThirtytwo,
			OnePerHundred,
			OnePerThousand        
    }

    internal static class DimensionValuePrecisions_
    {
        public static dynamic GetTSObject(DimensionValuePrecisions dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValuePrecisions").GetType();

            switch (dynEnum)
            {
				case DimensionValuePrecisions.Whole:
					return System.Enum.Parse(tsType, "Whole");
				case DimensionValuePrecisions.OnePerTwo:
					return System.Enum.Parse(tsType, "OnePerTwo");
				case DimensionValuePrecisions.OnePerThree:
					return System.Enum.Parse(tsType, "OnePerThree");
				case DimensionValuePrecisions.OnePerFour:
					return System.Enum.Parse(tsType, "OnePerFour");
				case DimensionValuePrecisions.OnePerEight:
					return System.Enum.Parse(tsType, "OnePerEight");
				case DimensionValuePrecisions.OnePerTen:
					return System.Enum.Parse(tsType, "OnePerTen");
				case DimensionValuePrecisions.OnePerSixteen:
					return System.Enum.Parse(tsType, "OnePerSixteen");
				case DimensionValuePrecisions.OnePerThirtytwo:
					return System.Enum.Parse(tsType, "OnePerThirtytwo");
				case DimensionValuePrecisions.OnePerHundred:
					return System.Enum.Parse(tsType, "OnePerHundred");
				case DimensionValuePrecisions.OnePerThousand:
					return System.Enum.Parse(tsType, "OnePerThousand");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DimensionValuePrecisions FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Whole", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.Whole;
			else if (tsEnumValue.Equals("OnePerTwo", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.OnePerTwo;
			else if (tsEnumValue.Equals("OnePerThree", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.OnePerThree;
			else if (tsEnumValue.Equals("OnePerFour", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.OnePerFour;
			else if (tsEnumValue.Equals("OnePerEight", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.OnePerEight;
			else if (tsEnumValue.Equals("OnePerTen", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.OnePerTen;
			else if (tsEnumValue.Equals("OnePerSixteen", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.OnePerSixteen;
			else if (tsEnumValue.Equals("OnePerThirtytwo", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.OnePerThirtytwo;
			else if (tsEnumValue.Equals("OnePerHundred", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.OnePerHundred;
			else if (tsEnumValue.Equals("OnePerThousand", System.StringComparison.InvariantCulture))
				return DimensionValuePrecisions.OnePerThousand;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum DimensionValueFormats
    {
			NoDecimals,
			OneOptionalDecimal,
			OneDecimal,
			TwoOptionalDecimals,
			TwoDecimals,
			ThreeOptionalDecimals,
			ThreeDecimals,
			RationalPart,
			SuperscriptEnding        
    }

    internal static class DimensionValueFormats_
    {
        public static dynamic GetTSObject(DimensionValueFormats dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueFormats").GetType();

            switch (dynEnum)
            {
				case DimensionValueFormats.NoDecimals:
					return System.Enum.Parse(tsType, "NoDecimals");
				case DimensionValueFormats.OneOptionalDecimal:
					return System.Enum.Parse(tsType, "OneOptionalDecimal");
				case DimensionValueFormats.OneDecimal:
					return System.Enum.Parse(tsType, "OneDecimal");
				case DimensionValueFormats.TwoOptionalDecimals:
					return System.Enum.Parse(tsType, "TwoOptionalDecimals");
				case DimensionValueFormats.TwoDecimals:
					return System.Enum.Parse(tsType, "TwoDecimals");
				case DimensionValueFormats.ThreeOptionalDecimals:
					return System.Enum.Parse(tsType, "ThreeOptionalDecimals");
				case DimensionValueFormats.ThreeDecimals:
					return System.Enum.Parse(tsType, "ThreeDecimals");
				case DimensionValueFormats.RationalPart:
					return System.Enum.Parse(tsType, "RationalPart");
				case DimensionValueFormats.SuperscriptEnding:
					return System.Enum.Parse(tsType, "SuperscriptEnding");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DimensionValueFormats FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NoDecimals", System.StringComparison.InvariantCulture))
				return DimensionValueFormats.NoDecimals;
			else if (tsEnumValue.Equals("OneOptionalDecimal", System.StringComparison.InvariantCulture))
				return DimensionValueFormats.OneOptionalDecimal;
			else if (tsEnumValue.Equals("OneDecimal", System.StringComparison.InvariantCulture))
				return DimensionValueFormats.OneDecimal;
			else if (tsEnumValue.Equals("TwoOptionalDecimals", System.StringComparison.InvariantCulture))
				return DimensionValueFormats.TwoOptionalDecimals;
			else if (tsEnumValue.Equals("TwoDecimals", System.StringComparison.InvariantCulture))
				return DimensionValueFormats.TwoDecimals;
			else if (tsEnumValue.Equals("ThreeOptionalDecimals", System.StringComparison.InvariantCulture))
				return DimensionValueFormats.ThreeOptionalDecimals;
			else if (tsEnumValue.Equals("ThreeDecimals", System.StringComparison.InvariantCulture))
				return DimensionValueFormats.ThreeDecimals;
			else if (tsEnumValue.Equals("RationalPart", System.StringComparison.InvariantCulture))
				return DimensionValueFormats.RationalPart;
			else if (tsEnumValue.Equals("SuperscriptEnding", System.StringComparison.InvariantCulture))
				return DimensionValueFormats.SuperscriptEnding;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum DimensionValueUnits
    {
			Automatic,
			Millimeter,
			Centimeter,
			Meter,
			Inch        
    }

    internal static class DimensionValueUnits_
    {
        public static dynamic GetTSObject(DimensionValueUnits dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueUnits").GetType();

            switch (dynEnum)
            {
				case DimensionValueUnits.Automatic:
					return System.Enum.Parse(tsType, "Automatic");
				case DimensionValueUnits.Millimeter:
					return System.Enum.Parse(tsType, "Millimeter");
				case DimensionValueUnits.Centimeter:
					return System.Enum.Parse(tsType, "Centimeter");
				case DimensionValueUnits.Meter:
					return System.Enum.Parse(tsType, "Meter");
				case DimensionValueUnits.Inch:
					return System.Enum.Parse(tsType, "Inch");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DimensionValueUnits FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Automatic", System.StringComparison.InvariantCulture))
				return DimensionValueUnits.Automatic;
			else if (tsEnumValue.Equals("Millimeter", System.StringComparison.InvariantCulture))
				return DimensionValueUnits.Millimeter;
			else if (tsEnumValue.Equals("Centimeter", System.StringComparison.InvariantCulture))
				return DimensionValueUnits.Centimeter;
			else if (tsEnumValue.Equals("Meter", System.StringComparison.InvariantCulture))
				return DimensionValueUnits.Meter;
			else if (tsEnumValue.Equals("Inch", System.StringComparison.InvariantCulture))
				return DimensionValueUnits.Inch;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum Placings
    {
			Free,
			Fixed        
    }

    internal static class Placings_
    {
        public static dynamic GetTSObject(Placings dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.Placings").GetType();

            switch (dynEnum)
            {
				case Placings.Free:
					return System.Enum.Parse(tsType, "Free");
				case Placings.Fixed:
					return System.Enum.Parse(tsType, "Fixed");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Placings FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Free", System.StringComparison.InvariantCulture))
				return Placings.Free;
			else if (tsEnumValue.Equals("Fixed", System.StringComparison.InvariantCulture))
				return Placings.Fixed;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum FrameTypes
    {
			None,
			Rectangle,
			Underline,
			RoundedRectangle,
			SharpenedRectangle        
    }

    internal static class FrameTypes_
    {
        public static dynamic GetTSObject(FrameTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.FrameTypes").GetType();

            switch (dynEnum)
            {
				case FrameTypes.None:
					return System.Enum.Parse(tsType, "None");
				case FrameTypes.Rectangle:
					return System.Enum.Parse(tsType, "Rectangle");
				case FrameTypes.Underline:
					return System.Enum.Parse(tsType, "Underline");
				case FrameTypes.RoundedRectangle:
					return System.Enum.Parse(tsType, "RoundedRectangle");
				case FrameTypes.SharpenedRectangle:
					return System.Enum.Parse(tsType, "SharpenedRectangle");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static FrameTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("None", System.StringComparison.InvariantCulture))
				return FrameTypes.None;
			else if (tsEnumValue.Equals("Rectangle", System.StringComparison.InvariantCulture))
				return FrameTypes.Rectangle;
			else if (tsEnumValue.Equals("Underline", System.StringComparison.InvariantCulture))
				return FrameTypes.Underline;
			else if (tsEnumValue.Equals("RoundedRectangle", System.StringComparison.InvariantCulture))
				return FrameTypes.RoundedRectangle;
			else if (tsEnumValue.Equals("SharpenedRectangle", System.StringComparison.InvariantCulture))
				return FrameTypes.SharpenedRectangle;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum DimensionTextPlacings
    {
			AboveDimensionLine,
			OnDimensionLine        
    }

    internal static class DimensionTextPlacings_
    {
        public static dynamic GetTSObject(DimensionTextPlacings dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextPlacings").GetType();

            switch (dynEnum)
            {
				case DimensionTextPlacings.AboveDimensionLine:
					return System.Enum.Parse(tsType, "AboveDimensionLine");
				case DimensionTextPlacings.OnDimensionLine:
					return System.Enum.Parse(tsType, "OnDimensionLine");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DimensionTextPlacings FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("AboveDimensionLine", System.StringComparison.InvariantCulture))
				return DimensionTextPlacings.AboveDimensionLine;
			else if (tsEnumValue.Equals("OnDimensionLine", System.StringComparison.InvariantCulture))
				return DimensionTextPlacings.OnDimensionLine;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum CombineFormats
    {
			Off,
			NumberOfItemsTimesLength,
			NumberOfItemsTimesLengthEqualsResult        
    }

    internal static class CombineFormats_
    {
        public static dynamic GetTSObject(CombineFormats dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombineFormats").GetType();

            switch (dynEnum)
            {
				case CombineFormats.Off:
					return System.Enum.Parse(tsType, "Off");
				case CombineFormats.NumberOfItemsTimesLength:
					return System.Enum.Parse(tsType, "NumberOfItemsTimesLength");
				case CombineFormats.NumberOfItemsTimesLengthEqualsResult:
					return System.Enum.Parse(tsType, "NumberOfItemsTimesLengthEqualsResult");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CombineFormats FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Off", System.StringComparison.InvariantCulture))
				return CombineFormats.Off;
			else if (tsEnumValue.Equals("NumberOfItemsTimesLength", System.StringComparison.InvariantCulture))
				return CombineFormats.NumberOfItemsTimesLength;
			else if (tsEnumValue.Equals("NumberOfItemsTimesLengthEqualsResult", System.StringComparison.InvariantCulture))
				return CombineFormats.NumberOfItemsTimesLengthEqualsResult;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum DimensionTypes
    {
			Relative,
			Absolute,
			RelativeAndAbsolute,
			USAbsolute,
			Elevation,
			USAbsolute2,
			AbsoluteWithShortRelatives,
			AbsoluteWithAllRelativesAbove        
    }

    internal static class DimensionTypes_
    {
        public static dynamic GetTSObject(DimensionTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTypes").GetType();

            switch (dynEnum)
            {
				case DimensionTypes.Relative:
					return System.Enum.Parse(tsType, "Relative");
				case DimensionTypes.Absolute:
					return System.Enum.Parse(tsType, "Absolute");
				case DimensionTypes.RelativeAndAbsolute:
					return System.Enum.Parse(tsType, "RelativeAndAbsolute");
				case DimensionTypes.USAbsolute:
					return System.Enum.Parse(tsType, "USAbsolute");
				case DimensionTypes.Elevation:
					return System.Enum.Parse(tsType, "Elevation");
				case DimensionTypes.USAbsolute2:
					return System.Enum.Parse(tsType, "USAbsolute2");
				case DimensionTypes.AbsoluteWithShortRelatives:
					return System.Enum.Parse(tsType, "AbsoluteWithShortRelatives");
				case DimensionTypes.AbsoluteWithAllRelativesAbove:
					return System.Enum.Parse(tsType, "AbsoluteWithAllRelativesAbove");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DimensionTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Relative", System.StringComparison.InvariantCulture))
				return DimensionTypes.Relative;
			else if (tsEnumValue.Equals("Absolute", System.StringComparison.InvariantCulture))
				return DimensionTypes.Absolute;
			else if (tsEnumValue.Equals("RelativeAndAbsolute", System.StringComparison.InvariantCulture))
				return DimensionTypes.RelativeAndAbsolute;
			else if (tsEnumValue.Equals("USAbsolute", System.StringComparison.InvariantCulture))
				return DimensionTypes.USAbsolute;
			else if (tsEnumValue.Equals("Elevation", System.StringComparison.InvariantCulture))
				return DimensionTypes.Elevation;
			else if (tsEnumValue.Equals("USAbsolute2", System.StringComparison.InvariantCulture))
				return DimensionTypes.USAbsolute2;
			else if (tsEnumValue.Equals("AbsoluteWithShortRelatives", System.StringComparison.InvariantCulture))
				return DimensionTypes.AbsoluteWithShortRelatives;
			else if (tsEnumValue.Equals("AbsoluteWithAllRelativesAbove", System.StringComparison.InvariantCulture))
				return DimensionTypes.AbsoluteWithAllRelativesAbove;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ExtensionLineTypes
    {
			No,
			Yes,
			NotOnGridlines        
    }

    internal static class ExtensionLineTypes_
    {
        public static dynamic GetTSObject(ExtensionLineTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExtensionLineTypes").GetType();

            switch (dynEnum)
            {
				case ExtensionLineTypes.No:
					return System.Enum.Parse(tsType, "No");
				case ExtensionLineTypes.Yes:
					return System.Enum.Parse(tsType, "Yes");
				case ExtensionLineTypes.NotOnGridlines:
					return System.Enum.Parse(tsType, "NotOnGridlines");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ExtensionLineTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("No", System.StringComparison.InvariantCulture))
				return ExtensionLineTypes.No;
			else if (tsEnumValue.Equals("Yes", System.StringComparison.InvariantCulture))
				return ExtensionLineTypes.Yes;
			else if (tsEnumValue.Equals("NotOnGridlines", System.StringComparison.InvariantCulture))
				return ExtensionLineTypes.NotOnGridlines;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ShortDimensionTypes
    {
			Inside,
			Outside        
    }

    internal static class ShortDimensionTypes_
    {
        public static dynamic GetTSObject(ShortDimensionTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.ShortDimensionTypes").GetType();

            switch (dynEnum)
            {
				case ShortDimensionTypes.Inside:
					return System.Enum.Parse(tsType, "Inside");
				case ShortDimensionTypes.Outside:
					return System.Enum.Parse(tsType, "Outside");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ShortDimensionTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Inside", System.StringComparison.InvariantCulture))
				return ShortDimensionTypes.Inside;
			else if (tsEnumValue.Equals("Outside", System.StringComparison.InvariantCulture))
				return ShortDimensionTypes.Outside;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum CurvedDimensionTypes
    {
			Distance,
			Angle        
    }

    internal static class CurvedDimensionTypes_
    {
        public static dynamic GetTSObject(CurvedDimensionTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.CurvedDimensionTypes").GetType();

            switch (dynEnum)
            {
				case CurvedDimensionTypes.Distance:
					return System.Enum.Parse(tsType, "Distance");
				case CurvedDimensionTypes.Angle:
					return System.Enum.Parse(tsType, "Angle");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static CurvedDimensionTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Distance", System.StringComparison.InvariantCulture))
				return CurvedDimensionTypes.Distance;
			else if (tsEnumValue.Equals("Angle", System.StringComparison.InvariantCulture))
				return CurvedDimensionTypes.Angle;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ExaggerationDirections
    {
			LeftDown,
			RightUp,
			Both        
    }

    internal static class ExaggerationDirections_
    {
        public static dynamic GetTSObject(ExaggerationDirections dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationDirections").GetType();

            switch (dynEnum)
            {
				case ExaggerationDirections.LeftDown:
					return System.Enum.Parse(tsType, "LeftDown");
				case ExaggerationDirections.RightUp:
					return System.Enum.Parse(tsType, "RightUp");
				case ExaggerationDirections.Both:
					return System.Enum.Parse(tsType, "Both");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ExaggerationDirections FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LeftDown", System.StringComparison.InvariantCulture))
				return ExaggerationDirections.LeftDown;
			else if (tsEnumValue.Equals("RightUp", System.StringComparison.InvariantCulture))
				return ExaggerationDirections.RightUp;
			else if (tsEnumValue.Equals("Both", System.StringComparison.InvariantCulture))
				return ExaggerationDirections.Both;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ExaggerationOrigins
    {
			NearDimensionLine,
			NearMeasuredObject        
    }

    internal static class ExaggerationOrigins_
    {
        public static dynamic GetTSObject(ExaggerationOrigins dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationOrigins").GetType();

            switch (dynEnum)
            {
				case ExaggerationOrigins.NearDimensionLine:
					return System.Enum.Parse(tsType, "NearDimensionLine");
				case ExaggerationOrigins.NearMeasuredObject:
					return System.Enum.Parse(tsType, "NearMeasuredObject");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ExaggerationOrigins FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NearDimensionLine", System.StringComparison.InvariantCulture))
				return ExaggerationOrigins.NearDimensionLine;
			else if (tsEnumValue.Equals("NearMeasuredObject", System.StringComparison.InvariantCulture))
				return ExaggerationOrigins.NearMeasuredObject;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class DimensionFormatAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValuePrecisions Precision
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValuePrecisions_.FromTSObject(teklaObject.Precision);
			set { teklaObject.Precision = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValuePrecisions_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueFormats Format
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueFormats_.FromTSObject(teklaObject.Format);
			set { teklaObject.Format = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueFormats_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueUnits Unit
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueUnits_.FromTSObject(teklaObject.Unit);
			set { teklaObject.Unit = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueUnits_.GetTSObject(value); }
		}

		public System.Boolean UseDigitGrouping
		{
			get => teklaObject.UseDigitGrouping;
			set { teklaObject.UseDigitGrouping = value; }
		}

        

        

		public DimensionFormatAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionFormatAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DimensionFormatAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DimensionFormatAttributes(Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValuePrecisions precision, Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueFormats format, Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueUnits unit)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValuePrecisions_.GetTSObject(precision);
			args[1] = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueFormats_.GetTSObject(format);
			args[2] = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionValueUnits_.GetTSObject(unit);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionFormatAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class DimensionFormatAttributes_
    {
        public static dynamic GetTSObject(DimensionFormatAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DimensionFormatAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionFormatAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DimensionFormatAttributesArray_
    {
        public static dynamic GetTSObject(DimensionFormatAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DimensionFormatAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DimensionFormatAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DimensionFormatAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DimensionFormatAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class DimensionPlacingAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.Placings Placing
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.Placings_.FromTSObject(teklaObject.Placing);
			set { teklaObject.Placing = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.Placings_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingDirectionAttributes Direction
		{
			get => Dynamic.Tekla.Structures.Drawing.PlacingDirectionAttributes_.FromTSObject(teklaObject.Direction);
			set { teklaObject.Direction = Dynamic.Tekla.Structures.Drawing.PlacingDirectionAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes Distance
		{
			get => Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes_.FromTSObject(teklaObject.Distance);
			set { teklaObject.Distance = Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes_.GetTSObject(value); }
		}

        

        

		public DimensionPlacingAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionPlacingAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DimensionPlacingAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DimensionPlacingAttributes(Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.Placings placing, Dynamic.Tekla.Structures.Drawing.PlacingDirectionAttributes direction, Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes distance)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.Placings_.GetTSObject(placing);
			args[1] = Dynamic.Tekla.Structures.Drawing.PlacingDirectionAttributes_.GetTSObject(direction);
			args[2] = Dynamic.Tekla.Structures.Drawing.PlacingDistanceAttributes_.GetTSObject(distance);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionPlacingAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class DimensionPlacingAttributes_
    {
        public static dynamic GetTSObject(DimensionPlacingAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DimensionPlacingAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionPlacingAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DimensionPlacingAttributesArray_
    {
        public static dynamic GetTSObject(DimensionPlacingAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DimensionPlacingAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DimensionPlacingAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DimensionPlacingAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DimensionPlacingAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class DimensionTextAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get => Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
			set { teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.FrameTypes Frame
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.FrameTypes_.FromTSObject(teklaObject.Frame);
			set { teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.FrameTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextPlacings TextPlacing
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextPlacings_.FromTSObject(teklaObject.TextPlacing);
			set { teklaObject.TextPlacing = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextPlacings_.GetTSObject(value); }
		}

        

        

		public DimensionTextAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DimensionTextAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DimensionTextAttributes(Dynamic.Tekla.Structures.Drawing.FontAttributes font, Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.FrameTypes frame, Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextPlacings textPlacing)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(font);
			args[1] = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.FrameTypes_.GetTSObject(frame);
			args[2] = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextPlacings_.GetTSObject(textPlacing);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class DimensionTextAttributes_
    {
        public static dynamic GetTSObject(DimensionTextAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DimensionTextAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionTextAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DimensionTextAttributesArray_
    {
        public static dynamic GetTSObject(DimensionTextAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DimensionTextAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DimensionTextAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DimensionTextAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DimensionTextAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class CombinedDimensionAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Int32 MinimumNumberToCombine
		{
			get => teklaObject.MinimumNumberToCombine;
			set { teklaObject.MinimumNumberToCombine = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombineFormats Format
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombineFormats_.FromTSObject(teklaObject.Format);
			set { teklaObject.Format = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombineFormats_.GetTSObject(value); }
		}

        

        

		public CombinedDimensionAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CombinedDimensionAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CombinedDimensionAttributes(System.Int32 minimumNumberToCombine, Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombineFormats format)
		{
			var args = new object[2];
			args[0] = minimumNumberToCombine;
			args[1] = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombineFormats_.GetTSObject(format);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class CombinedDimensionAttributes_
    {
        public static dynamic GetTSObject(CombinedDimensionAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CombinedDimensionAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.CombinedDimensionAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CombinedDimensionAttributesArray_
    {
        public static dynamic GetTSObject(CombinedDimensionAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CombinedDimensionAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CombinedDimensionAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CombinedDimensionAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CombinedDimensionAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class DimensionExaggerationAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Boolean ExaggerationEnabled
		{
			get => teklaObject.ExaggerationEnabled;
			set { teklaObject.ExaggerationEnabled = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationDirections ExaggerationDirection
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationDirections_.FromTSObject(teklaObject.ExaggerationDirection);
			set { teklaObject.ExaggerationDirection = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationDirections_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationOrigins ExaggerationOrigin
		{
			get => Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationOrigins_.FromTSObject(teklaObject.ExaggerationOrigin);
			set { teklaObject.ExaggerationOrigin = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationOrigins_.GetTSObject(value); }
		}

		public System.Double ExaggerationWidth
		{
			get => teklaObject.ExaggerationWidth;
			set { teklaObject.ExaggerationWidth = value; }
		}

		public System.Double ExaggerationPosition
		{
			get => teklaObject.ExaggerationPosition;
			set { teklaObject.ExaggerationPosition = value; }
		}

		public System.Double ExaggerationHeight
		{
			get => teklaObject.ExaggerationHeight;
			set { teklaObject.ExaggerationHeight = value; }
		}

        

        

		public DimensionExaggerationAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DimensionExaggerationAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DimensionExaggerationAttributes(System.Boolean ExaggerationEnabled, Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationDirections ExaggerationDirection, Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationOrigins ExaggerationOrigin, System.Double ExaggerationWidth, System.Double ExaggerationPosition, System.Double ExaggerationHeight)
		{
			var args = new object[6];
			args[0] = ExaggerationEnabled;
			args[1] = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationDirections_.GetTSObject(ExaggerationDirection);
			args[2] = Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.ExaggerationOrigins_.GetTSObject(ExaggerationOrigin);
			args[3] = ExaggerationWidth;
			args[4] = ExaggerationPosition;
			args[5] = ExaggerationHeight;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class DimensionExaggerationAttributes_
    {
        public static dynamic GetTSObject(DimensionExaggerationAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DimensionExaggerationAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes.DimensionExaggerationAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DimensionExaggerationAttributesArray_
    {
        public static dynamic GetTSObject(DimensionExaggerationAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DimensionExaggerationAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DimensionExaggerationAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DimensionExaggerationAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DimensionExaggerationAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class DimensionSetBaseAttributes_
    {
        public static dynamic GetTSObject(DimensionSetBaseAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DimensionSetBaseAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DimensionSetBaseAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DimensionSetBaseAttributesArray_
    {
        public static dynamic GetTSObject(DimensionSetBaseAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DimensionSetBaseAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DimensionSetBaseAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DimensionSetBaseAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DimensionSetBaseAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
