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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.CenterPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CenterPoint", ex); }
			}
			set
			{
				try {
				teklaObject.CenterPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CenterPoint", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point BoundaryPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.BoundaryPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundaryPoint", ex); }
			}
			set
			{
				try {
				teklaObject.BoundaryPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundaryPoint", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point LabelPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.LabelPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelPoint", ex); }
			}
			set
			{
				try {
				teklaObject.LabelPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelPoint", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
		}

        

        

		internal DetailMark() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DetailMark(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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




    public  class DetailMarkAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.String MarkName
		{
			get
			{
				try {
					return teklaObject.MarkName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MarkName", ex); }
			}
			set
			{
				try {
					teklaObject.MarkName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MarkName", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes BoundingLine
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.BoundingLine);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingLine", ex); }
			}
			set
			{
				try {
				teklaObject.BoundingLine = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingLine", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes.DetailBoundaryShape BoundaryShape
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes.DetailBoundaryShape_.FromTSObject(teklaObject.BoundaryShape);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundaryShape", ex); }
			}
			set
			{
				try {
				teklaObject.BoundaryShape = Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes.DetailBoundaryShape_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundaryShape", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors MarkSymbolColor
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.MarkSymbolColor);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MarkSymbolColor", ex); }
			}
			set
			{
				try {
				teklaObject.MarkSymbolColor = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MarkSymbolColor", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DetailMarkSymbolAttributes MarkSymbolAttributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DetailMarkSymbolAttributes_.FromTSObject(teklaObject.MarkSymbolAttributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MarkSymbolAttributes", ex); }
			}
			set
			{
				try {
				teklaObject.MarkSymbolAttributes = Dynamic.Tekla.Structures.Drawing.DetailMarkSymbolAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MarkSymbolAttributes", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DetailMarkTagsAttributes TagsAttributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DetailMarkTagsAttributes_.FromTSObject(teklaObject.TagsAttributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagsAttributes", ex); }
			}
			set
			{
				try {
				teklaObject.TagsAttributes = Dynamic.Tekla.Structures.Drawing.DetailMarkTagsAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagsAttributes", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypes BoundaryLineType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(teklaObject.BoundaryLineType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundaryLineType", ex); }
			}
			set
			{
				try {
				teklaObject.BoundaryLineType = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundaryLineType", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors BoundaryLineColor
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.BoundaryLineColor);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundaryLineColor", ex); }
			}
			set
			{
				try {
				teklaObject.BoundaryLineColor = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundaryLineColor", ex); }
			}
		}

        

        

		public DetailMarkAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DetailMarkAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DetailMarkAttributes(System.String attributesFile)
		{
			var args = new object[1];
			args[0] = attributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes", args);
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class DetailMarkAttributes_
    {
        public static dynamic GetTSObject(DetailMarkAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DetailMarkAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DetailMarkAttributesArray_
    {
        public static dynamic GetTSObject(DetailMarkAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DetailMarkAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DetailMarkAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DetailMarkAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DetailMarkAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class DetailMark_
    {
        public static dynamic GetTSObject(DetailMark dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DetailMark FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DetailMark)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DetailMarkArray_
    {
        public static dynamic GetTSObject(DetailMark[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DetailMark_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DetailMark[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DetailMark>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DetailMark_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
