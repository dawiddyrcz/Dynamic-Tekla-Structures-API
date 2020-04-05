/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class SectionMarkBase  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point LeftPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.LeftPoint);
			set { teklaObject.LeftPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RightPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.RightPoint);
			set { teklaObject.RightPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes_.GetTSObject(value); }
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

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}




    public  class SectionMarkSymbol  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol.SymbolShapes Shape
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol.SymbolShapes_.FromTSObject(teklaObject.Shape);
			set { teklaObject.Shape = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol.SymbolShapes_.GetTSObject(value); }
		}

		public System.Double Size
		{
			get => teklaObject.Size;
			set { teklaObject.Size = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position);
			set { teklaObject.Position = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        

		public SectionMarkSymbol()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SectionMarkSymbol(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SectionMarkSymbol(Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol.SymbolShapes shape, System.Double size, Dynamic.Tekla.Structures.Geometry3d.Point position)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol.SymbolShapes_.GetTSObject(shape);
			args[1] = size;
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(position);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}




    public enum SymbolShapes
    {
			None,
			Custom,
			SymbolShape1,
			SymbolShape2,
			SymbolShape3,
			SymbolShape4,
			SymbolShape5,
			SymbolShape6,
			SymbolShape7,
			SymbolShape8        
    }

    internal static class SymbolShapes_
    {
        public static dynamic GetTSObject(SymbolShapes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol.SymbolShapes").GetType();

            switch (dynEnum)
            {
				case SymbolShapes.None:
					return System.Enum.Parse(tsType, "None");
				case SymbolShapes.Custom:
					return System.Enum.Parse(tsType, "Custom");
				case SymbolShapes.SymbolShape1:
					return System.Enum.Parse(tsType, "SymbolShape1");
				case SymbolShapes.SymbolShape2:
					return System.Enum.Parse(tsType, "SymbolShape2");
				case SymbolShapes.SymbolShape3:
					return System.Enum.Parse(tsType, "SymbolShape3");
				case SymbolShapes.SymbolShape4:
					return System.Enum.Parse(tsType, "SymbolShape4");
				case SymbolShapes.SymbolShape5:
					return System.Enum.Parse(tsType, "SymbolShape5");
				case SymbolShapes.SymbolShape6:
					return System.Enum.Parse(tsType, "SymbolShape6");
				case SymbolShapes.SymbolShape7:
					return System.Enum.Parse(tsType, "SymbolShape7");
				case SymbolShapes.SymbolShape8:
					return System.Enum.Parse(tsType, "SymbolShape8");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SymbolShapes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("None", System.StringComparison.InvariantCulture))
				return SymbolShapes.None;
			else if (tsEnumValue.Equals("Custom", System.StringComparison.InvariantCulture))
				return SymbolShapes.Custom;
			else if (tsEnumValue.Equals("SymbolShape1", System.StringComparison.InvariantCulture))
				return SymbolShapes.SymbolShape1;
			else if (tsEnumValue.Equals("SymbolShape2", System.StringComparison.InvariantCulture))
				return SymbolShapes.SymbolShape2;
			else if (tsEnumValue.Equals("SymbolShape3", System.StringComparison.InvariantCulture))
				return SymbolShapes.SymbolShape3;
			else if (tsEnumValue.Equals("SymbolShape4", System.StringComparison.InvariantCulture))
				return SymbolShapes.SymbolShape4;
			else if (tsEnumValue.Equals("SymbolShape5", System.StringComparison.InvariantCulture))
				return SymbolShapes.SymbolShape5;
			else if (tsEnumValue.Equals("SymbolShape6", System.StringComparison.InvariantCulture))
				return SymbolShapes.SymbolShape6;
			else if (tsEnumValue.Equals("SymbolShape7", System.StringComparison.InvariantCulture))
				return SymbolShapes.SymbolShape7;
			else if (tsEnumValue.Equals("SymbolShape8", System.StringComparison.InvariantCulture))
				return SymbolShapes.SymbolShape8;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class SectionMarkSymbol_
    {
        public static dynamic GetTSObject(SectionMarkSymbol dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SectionMarkSymbol FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SectionMarkSymbolArray_
    {
        public static dynamic GetTSObject(SectionMarkSymbol[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SectionMarkSymbol_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SectionMarkSymbol[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SectionMarkSymbol>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SectionMarkSymbol_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class SectionMarkAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.String MarkName
		{
			get => teklaObject.MarkName;
			set { teklaObject.MarkName = value; }
		}

		public System.Double LineLength
		{
			get => teklaObject.LineLength;
			set { teklaObject.LineLength = value; }
		}

		public System.Double LineWidth
		{
			get => teklaObject.LineWidth;
			set { teklaObject.LineWidth = value; }
		}

		public System.Double LineLengthOffset
		{
			get => teklaObject.LineLengthOffset;
			set { teklaObject.LineLengthOffset = value; }
		}

		public System.Double LineWidthOffsetLeft
		{
			get => teklaObject.LineWidthOffsetLeft;
			set { teklaObject.LineWidthOffsetLeft = value; }
		}

		public System.Double LineWidthOffsetRight
		{
			get => teklaObject.LineWidthOffsetRight;
			set { teklaObject.LineWidthOffsetRight = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors LineColor
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.LineColor);
			set { teklaObject.LineColor = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors SymbolColor
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.SymbolColor);
			set { teklaObject.SymbolColor = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol LeftSymbol
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol_.FromTSObject(teklaObject.LeftSymbol);
			set { teklaObject.LeftSymbol = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol RightSymbol
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol_.FromTSObject(teklaObject.RightSymbol);
			set { teklaObject.RightSymbol = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkSymbol_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagsAttributes TagsAttributes
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagsAttributes_.FromTSObject(teklaObject.TagsAttributes);
			set { teklaObject.TagsAttributes = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagsAttributes_.GetTSObject(value); }
		}

        

        

		public SectionMarkAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SectionMarkAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SectionMarkAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes", args);
		}

		public System.Boolean LoadAttributes(System.String attributeFile)
		{
			return teklaObject.LoadAttributes(attributeFile);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class SectionMarkAttributes_
    {
        public static dynamic GetTSObject(SectionMarkAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SectionMarkAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SectionMarkAttributesArray_
    {
        public static dynamic GetTSObject(SectionMarkAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SectionMarkAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SectionMarkAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SectionMarkAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SectionMarkAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class SectionMarkTagAttributes  : Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagShowOnSide ShowOnSide
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagShowOnSide_.FromTSObject(teklaObject.ShowOnSide);
			set { teklaObject.ShowOnSide = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagShowOnSide_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagTextRotation TagRotation
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagTextRotation_.FromTSObject(teklaObject.TagRotation);
			set { teklaObject.TagRotation = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagTextRotation_.GetTSObject(value); }
		}

        

        

		public SectionMarkTagAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SectionMarkTagAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SectionMarkTagAttributes(Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagShowOnSide showOnSide, Dynamic.Tekla.Structures.Drawing.TagLocation location, Dynamic.Tekla.Structures.Geometry3d.Vector offset, Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagTextRotation rotation, Dynamic.Tekla.Structures.Drawing.ContainerElement tagContent)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagShowOnSide_.GetTSObject(showOnSide);
			args[1] = Dynamic.Tekla.Structures.Drawing.TagLocation_.GetTSObject(location);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(offset);
			args[3] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagTextRotation_.GetTSObject(rotation);
			args[4] = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(tagContent);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}




    public enum TagTextRotation
    {
			AlwaysRotate,
			AlwaysHorizontal,
			DoNotRotateVertically,
			AlwaysOrthogonal        
    }

    internal static class TagTextRotation_
    {
        public static dynamic GetTSObject(TagTextRotation dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagTextRotation").GetType();

            switch (dynEnum)
            {
				case TagTextRotation.AlwaysRotate:
					return System.Enum.Parse(tsType, "AlwaysRotate");
				case TagTextRotation.AlwaysHorizontal:
					return System.Enum.Parse(tsType, "AlwaysHorizontal");
				case TagTextRotation.DoNotRotateVertically:
					return System.Enum.Parse(tsType, "DoNotRotateVertically");
				case TagTextRotation.AlwaysOrthogonal:
					return System.Enum.Parse(tsType, "AlwaysOrthogonal");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static TagTextRotation FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("AlwaysRotate", System.StringComparison.InvariantCulture))
				return TagTextRotation.AlwaysRotate;
			else if (tsEnumValue.Equals("AlwaysHorizontal", System.StringComparison.InvariantCulture))
				return TagTextRotation.AlwaysHorizontal;
			else if (tsEnumValue.Equals("DoNotRotateVertically", System.StringComparison.InvariantCulture))
				return TagTextRotation.DoNotRotateVertically;
			else if (tsEnumValue.Equals("AlwaysOrthogonal", System.StringComparison.InvariantCulture))
				return TagTextRotation.AlwaysOrthogonal;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum TagShowOnSide
    {
			ShowOnBothSides,
			ShowOnLeftSideOnly,
			ShowOnRightSideOnly        
    }

    internal static class TagShowOnSide_
    {
        public static dynamic GetTSObject(TagShowOnSide dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes.TagShowOnSide").GetType();

            switch (dynEnum)
            {
				case TagShowOnSide.ShowOnBothSides:
					return System.Enum.Parse(tsType, "ShowOnBothSides");
				case TagShowOnSide.ShowOnLeftSideOnly:
					return System.Enum.Parse(tsType, "ShowOnLeftSideOnly");
				case TagShowOnSide.ShowOnRightSideOnly:
					return System.Enum.Parse(tsType, "ShowOnRightSideOnly");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static TagShowOnSide FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ShowOnBothSides", System.StringComparison.InvariantCulture))
				return TagShowOnSide.ShowOnBothSides;
			else if (tsEnumValue.Equals("ShowOnLeftSideOnly", System.StringComparison.InvariantCulture))
				return TagShowOnSide.ShowOnLeftSideOnly;
			else if (tsEnumValue.Equals("ShowOnRightSideOnly", System.StringComparison.InvariantCulture))
				return TagShowOnSide.ShowOnRightSideOnly;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class SectionMarkTagAttributes_
    {
        public static dynamic GetTSObject(SectionMarkTagAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SectionMarkTagAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SectionMarkTagAttributesArray_
    {
        public static dynamic GetTSObject(SectionMarkTagAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SectionMarkTagAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SectionMarkTagAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SectionMarkTagAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SectionMarkTagAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class SectionMarkTagsAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes TagA1
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.FromTSObject(teklaObject.TagA1);
			set { teklaObject.TagA1 = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes TagA2
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.FromTSObject(teklaObject.TagA2);
			set { teklaObject.TagA2 = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes TagA3
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.FromTSObject(teklaObject.TagA3);
			set { teklaObject.TagA3 = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes TagA4
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.FromTSObject(teklaObject.TagA4);
			set { teklaObject.TagA4 = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes TagA5
		{
			get => Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.FromTSObject(teklaObject.TagA5);
			set { teklaObject.TagA5 = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(value); }
		}

        

        

		public SectionMarkTagsAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagsAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SectionMarkTagsAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SectionMarkTagsAttributes(Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes tagA1, Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes tagA2, Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes tagA3, Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes tagA4, Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes tagA5)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(tagA1);
			args[1] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(tagA2);
			args[2] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(tagA3);
			args[3] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(tagA4);
			args[4] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagAttributes_.GetTSObject(tagA5);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagsAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class SectionMarkTagsAttributes_
    {
        public static dynamic GetTSObject(SectionMarkTagsAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SectionMarkTagsAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkTagsAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SectionMarkTagsAttributesArray_
    {
        public static dynamic GetTSObject(SectionMarkTagsAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SectionMarkTagsAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SectionMarkTagsAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SectionMarkTagsAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SectionMarkTagsAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class SectionMarkBase_
    {
        public static dynamic GetTSObject(SectionMarkBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SectionMarkBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.SectionMarkBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SectionMarkBaseArray_
    {
        public static dynamic GetTSObject(SectionMarkBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SectionMarkBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SectionMarkBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SectionMarkBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SectionMarkBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
