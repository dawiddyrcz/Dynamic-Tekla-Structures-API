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
			get => Dynamic.Tekla.Structures.Drawing.Part.PartAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Part.PartAttributes_.GetTSObject(value); }
		}

        

        

		public Part()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Part");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Part(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class PartAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.Part.Representation Representation
		{
			get => Dynamic.Tekla.Structures.Drawing.Part.Representation_.FromTSObject(teklaObject.Representation);
			set { teklaObject.Representation = Dynamic.Tekla.Structures.Drawing.Part.Representation_.GetTSObject(value); }
		}

		public System.Double PartialProfileLength
		{
			get => teklaObject.PartialProfileLength;
			set { teklaObject.PartialProfileLength = value; }
		}

		public System.Double PartialProfileOffset
		{
			get => teklaObject.PartialProfileOffset;
			set { teklaObject.PartialProfileOffset = value; }
		}

		public System.Double SymbolOffset
		{
			get => teklaObject.SymbolOffset;
			set { teklaObject.SymbolOffset = value; }
		}

		public System.Boolean DrawHiddenLines
		{
			get => teklaObject.DrawHiddenLines;
			set { teklaObject.DrawHiddenLines = value; }
		}

		public System.Boolean DrawOwnHiddenLines
		{
			get => teklaObject.DrawOwnHiddenLines;
			set { teklaObject.DrawOwnHiddenLines = value; }
		}

		public System.Boolean DrawCenterLine
		{
			get => teklaObject.DrawCenterLine;
			set { teklaObject.DrawCenterLine = value; }
		}

		public System.Boolean DrawReferenceLine
		{
			get => teklaObject.DrawReferenceLine;
			set { teklaObject.DrawReferenceLine = value; }
		}

		public System.Boolean DrawOrientationMark
		{
			get => teklaObject.DrawOrientationMark;
			set { teklaObject.DrawOrientationMark = value; }
		}

		public System.Boolean DrawConnectingSideMarks
		{
			get => teklaObject.DrawConnectingSideMarks;
			set { teklaObject.DrawConnectingSideMarks = value; }
		}

		public System.Boolean DrawPopMarks
		{
			get => teklaObject.DrawPopMarks;
			set { teklaObject.DrawPopMarks = value; }
		}

		public System.Boolean DrawChamfers
		{
			get => teklaObject.DrawChamfers;
			set { teklaObject.DrawChamfers = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes VisibleLines
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.VisibleLines);
			set { teklaObject.VisibleLines = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes HiddenLines
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.HiddenLines);
			set { teklaObject.HiddenLines = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes ReferenceLine
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.ReferenceLine);
			set { teklaObject.ReferenceLine = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes FaceHatch
		{
			get => Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.FromTSObject(teklaObject.FaceHatch);
			set { teklaObject.FaceHatch = Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes SectionFaceHatch
		{
			get => Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.FromTSObject(teklaObject.SectionFaceHatch);
			set { teklaObject.SectionFaceHatch = Dynamic.Tekla.Structures.Drawing.ModelObjectHatchAttributes_.GetTSObject(value); }
		}

		public System.String CustomPresentation
		{
			get => teklaObject.CustomPresentation;
			set { teklaObject.CustomPresentation = value; }
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

		public System.Boolean LoadAttributes(System.String AttributeFile)
		{
			return teklaObject.LoadAttributes(AttributeFile);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class PartAttributes_
    {
        public static dynamic GetTSObject(PartAttributes dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static PartAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PartAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PartAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Part FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Part_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Part[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Part>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Part_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
