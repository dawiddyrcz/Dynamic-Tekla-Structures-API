/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class DetailMark  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point CenterPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.CenterPoint);
			set { teklaObject.CenterPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point BoundaryPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.BoundaryPoint);
			set { teklaObject.BoundaryPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point LabelPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.LabelPoint);
			set { teklaObject.LabelPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes_.GetTSObject(value); }
		}

        

        

		public DetailMark() {}
		public DetailMark(Dynamic.Tekla.Structures.Drawing.View view, Dynamic.Tekla.Structures.Geometry3d.Point centerPoint, Dynamic.Tekla.Structures.Geometry3d.Point boundaryPoint, Dynamic.Tekla.Structures.Geometry3d.Point labelPoint)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(centerPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(boundaryPoint);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(labelPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMark", args);
		}
		public DetailMark(Dynamic.Tekla.Structures.Drawing.View view, Dynamic.Tekla.Structures.Geometry3d.Point centerPoint, Dynamic.Tekla.Structures.Geometry3d.Point boundaryPoint, Dynamic.Tekla.Structures.Geometry3d.Point labelPoint, Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes detailMarkAttributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(centerPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(boundaryPoint);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(labelPoint);
			args[4] = Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes_.GetTSObject(detailMarkAttributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMark", args);
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




    public  class DetailMarkAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.String MarkName
		{
			get => teklaObject.MarkName;
			set { teklaObject.MarkName = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes BoundingLine
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.BoundingLine);
			set { teklaObject.BoundingLine = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes.DetailBoundaryShape BoundaryShape
		{
			get => Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes.DetailBoundaryShape_.FromTSObject(teklaObject.BoundaryShape);
			set { teklaObject.BoundaryShape = Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes.DetailBoundaryShape_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors MarkSymbolColor
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.MarkSymbolColor);
			set { teklaObject.MarkSymbolColor = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DetailMarkSymbolAttributes MarkSymbolAttributes
		{
			get => Dynamic.Tekla.Structures.Drawing.DetailMarkSymbolAttributes_.FromTSObject(teklaObject.MarkSymbolAttributes);
			set { teklaObject.MarkSymbolAttributes = Dynamic.Tekla.Structures.Drawing.DetailMarkSymbolAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DetailMarkTagsAttributes TagsAttributes
		{
			get => Dynamic.Tekla.Structures.Drawing.DetailMarkTagsAttributes_.FromTSObject(teklaObject.TagsAttributes);
			set { teklaObject.TagsAttributes = Dynamic.Tekla.Structures.Drawing.DetailMarkTagsAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypes BoundaryLineType
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(teklaObject.BoundaryLineType);
			set { teklaObject.BoundaryLineType = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors BoundaryLineColor
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.BoundaryLineColor);
			set { teklaObject.BoundaryLineColor = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

        

        

		public DetailMarkAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes");
		}
		public DetailMarkAttributes(System.String attributesFile)
		{
			var args = new object[1];
			args[0] = attributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes", args);
		}

		public System.Boolean LoadAttributes(System.String attributeFile)
		{
			return teklaObject.LoadAttributes(attributeFile);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}




    public enum DetailBoundaryShape
    {
			None,
			Circular,
			Rectangular        
    }

    internal static class DetailBoundaryShape_
    {
        public static dynamic GetTSObject(DetailBoundaryShape dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes.DetailBoundaryShape").GetType();

            switch (dynEnum)
            {
				case DetailBoundaryShape.None:
					return System.Enum.Parse(tsType, "None");
				case DetailBoundaryShape.Circular:
					return System.Enum.Parse(tsType, "Circular");
				case DetailBoundaryShape.Rectangular:
					return System.Enum.Parse(tsType, "Rectangular");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DetailBoundaryShape FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("None", System.StringComparison.InvariantCulture))
				return DetailBoundaryShape.None;
			else if (tsEnumValue.Equals("Circular", System.StringComparison.InvariantCulture))
				return DetailBoundaryShape.Circular;
			else if (tsEnumValue.Equals("Rectangular", System.StringComparison.InvariantCulture))
				return DetailBoundaryShape.Rectangular;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class DetailMarkAttributes_
    {
        public static dynamic GetTSObject(DetailMarkAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DetailMarkAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class DetailMark_
    {
        public static dynamic GetTSObject(DetailMark dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DetailMark FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.DetailMark)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    