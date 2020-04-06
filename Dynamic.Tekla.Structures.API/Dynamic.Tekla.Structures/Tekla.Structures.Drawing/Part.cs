/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Part  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {

		public Dynamic.Tekla.Structures.Drawing.Part.PartAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Part.PartAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Part.PartAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
		}

        

        

		internal Part() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Part(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum Representation
    {
			Outline,
			Symbol,
			WorkshopForm,
			Exact,
			BoundingBox,
			BaseBox,
			SolidWithPartialProfile        
    }

    internal static class Representation_
    {
        public static dynamic GetTSObject(Representation dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.Part.Representation").GetType();

            switch (dynEnum)
            {
				case Representation.Outline:
					return System.Enum.Parse(tsType, "Outline");
				case Representation.Symbol:
					return System.Enum.Parse(tsType, "Symbol");
				case Representation.WorkshopForm:
					return System.Enum.Parse(tsType, "WorkshopForm");
				case Representation.Exact:
					return System.Enum.Parse(tsType, "Exact");
				case Representation.BoundingBox:
					return System.Enum.Parse(tsType, "BoundingBox");
				case Representation.BaseBox:
					return System.Enum.Parse(tsType, "BaseBox");
				case Representation.SolidWithPartialProfile:
					return System.Enum.Parse(tsType, "SolidWithPartialProfile");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Representation FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Outline", System.StringComparison.InvariantCulture))
				return Representation.Outline;
			else if (tsEnumValue.Equals("Symbol", System.StringComparison.InvariantCulture))
				return Representation.Symbol;
			else if (tsEnumValue.Equals("WorkshopForm", System.StringComparison.InvariantCulture))
				return Representation.WorkshopForm;
			else if (tsEnumValue.Equals("Exact", System.StringComparison.InvariantCulture))
				return Representation.Exact;
			else if (tsEnumValue.Equals("BoundingBox", System.StringComparison.InvariantCulture))
				return Representation.BoundingBox;
			else if (tsEnumValue.Equals("BaseBox", System.StringComparison.InvariantCulture))
				return Representation.BaseBox;
			else if (tsEnumValue.Equals("SolidWithPartialProfile", System.StringComparison.InvariantCulture))
				return Representation.SolidWithPartialProfile;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class PartAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.Part.Representation Representation
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Part.Representation_.FromTSObject(teklaObject.Representation);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Representation", ex); }
			}
			set
			{
				try {
				teklaObject.Representation = Dynamic.Tekla.Structures.Drawing.Part.Representation_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Representation", ex); }
			}
		}

		public System.Double PartialProfileLength
		{
			get
			{
				try {
					return teklaObject.PartialProfileLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartialProfileLength", ex); }
			}
			set
			{
				try {
					teklaObject.PartialProfileLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartialProfileLength", ex); }
			}
		}

		public System.Double PartialProfileOffset
		{
			get
			{
				try {
					return teklaObject.PartialProfileOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartialProfileOffset", ex); }
			}
			set
			{
				try {
					teklaObject.PartialProfileOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartialProfileOffset", ex); }
			}
		}

		public System.Double SymbolOffset
		{
			get
			{
				try {
					return teklaObject.SymbolOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SymbolOffset", ex); }
			}
			set
			{
				try {
					teklaObject.SymbolOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SymbolOffset", ex); }
			}
		}

		public System.Boolean DrawHiddenLines
		{
			get
			{
				try {
					return teklaObject.DrawHiddenLines;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawHiddenLines", ex); }
			}
			set
			{
				try {
					teklaObject.DrawHiddenLines = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawHiddenLines", ex); }
			}
		}

		public System.Boolean DrawOwnHiddenLines
		{
			get
			{
				try {
					return teklaObject.DrawOwnHiddenLines;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawOwnHiddenLines", ex); }
			}
			set
			{
				try {
					teklaObject.DrawOwnHiddenLines = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawOwnHiddenLines", ex); }
			}
		}

		public System.Boolean DrawCenterLine
		{
			get
			{
				try {
					return teklaObject.DrawCenterLine;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawCenterLine", ex); }
			}
			set
			{
				try {
					teklaObject.DrawCenterLine = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawCenterLine", ex); }
			}
		}

		public System.Boolean DrawReferenceLine
		{
			get
			{
				try {
					return teklaObject.DrawReferenceLine;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawReferenceLine", ex); }
			}
			set
			{
				try {
					teklaObject.DrawReferenceLine = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawReferenceLine", ex); }
			}
		}

		public System.Boolean DrawOrientationMark
		{
			get
			{
				try {
					return teklaObject.DrawOrientationMark;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawOrientationMark", ex); }
			}
			set
			{
				try {
					teklaObject.DrawOrientationMark = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawOrientationMark", ex); }
			}
		}

		public System.Boolean DrawConnectingSideMarks
		{
			get
			{
				try {
					return teklaObject.DrawConnectingSideMarks;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawConnectingSideMarks", ex); }
			}
			set
			{
				try {
					teklaObject.DrawConnectingSideMarks = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawConnectingSideMarks", ex); }
			}
		}

		public System.Boolean DrawPopMarks
		{
			get
			{
				try {
					return teklaObject.DrawPopMarks;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawPopMarks", ex); }
			}
			set
			{
				try {
					teklaObject.DrawPopMarks = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawPopMarks", ex); }
			}
		}

		public System.Boolean DrawChamfers
		{
			get
			{
				try {
					return teklaObject.DrawChamfers;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawChamfers", ex); }
			}
			set
			{
				try {
					teklaObject.DrawChamfers = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawChamfers", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes VisibleLines
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.VisibleLines);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("VisibleLines", ex); }
			}
			set
			{
				try {
				teklaObject.VisibleLines = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("VisibleLines", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes HiddenLines
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.HiddenLines);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HiddenLines", ex); }
			}
			set
			{
				try {
				teklaObject.HiddenLines = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("HiddenLines", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes ReferenceLine
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.ReferenceLine);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ReferenceLine", ex); }
			}
			set
			{
				try {
				teklaObject.ReferenceLine = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ReferenceLine", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes FaceHatch
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.FromTSObject(teklaObject.FaceHatch);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FaceHatch", ex); }
			}
			set
			{
				try {
				teklaObject.FaceHatch = Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FaceHatch", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes SectionFaceHatch
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.FromTSObject(teklaObject.SectionFaceHatch);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SectionFaceHatch", ex); }
			}
			set
			{
				try {
				teklaObject.SectionFaceHatch = Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SectionFaceHatch", ex); }
			}
		}

		public System.String CustomPresentation
		{
			get
			{
				try {
					return teklaObject.CustomPresentation;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CustomPresentation", ex); }
			}
			set
			{
				try {
					teklaObject.CustomPresentation = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CustomPresentation", ex); }
			}
		}

        

        

		public PartAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Part.PartAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PartAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PartAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Part.PartAttributes", args);
		}





    }

    internal static class PartAttributes_
    {
        public static dynamic GetTSObject(PartAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PartAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Part.PartAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PartAttributesArray_
    {
        public static dynamic GetTSObject(PartAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PartAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PartAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PartAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PartAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Part_
    {
        public static dynamic GetTSObject(Part dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Part FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Part)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PartArray_
    {
        public static dynamic GetTSObject(Part[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Part_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Part[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Part>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Part_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
