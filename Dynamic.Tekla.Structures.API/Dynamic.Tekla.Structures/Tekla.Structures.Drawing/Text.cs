/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Text  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.InsertionPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InsertionPoint", ex); }
			}
			set
			{
				try {
				teklaObject.InsertionPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InsertionPoint", ex); }
			}
		}

		public System.String TextString
		{
			get
			{
				try {
					return teklaObject.TextString;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TextString", ex); }
			}
			set
			{
				try {
					teklaObject.TextString = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TextString", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.Text.TextAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Text.TextAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Text.TextAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingBase Placing
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PlacingBase_.FromTSObject(teklaObject.Placing);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Placing", ex); }
			}
			set
			{
				try {
				teklaObject.Placing = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Placing", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.Hideable Hideable
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Hideable_.FromTSObject(teklaObject.Hideable);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hideable", ex); }
			}
			set
			{
				try {
				teklaObject.Hideable = Dynamic.Tekla.Structures.Drawing.Hideable_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Hideable", ex); }
			}
		}

        

        

		internal Text() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Text(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Text(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String text)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = text;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Text", args);
		}
		public Text(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String text, Dynamic.Tekla.Structures.Drawing.PlacingBase Placing)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = text;
			args[3] = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(Placing);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Text", args);
		}
		public Text(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String Text, Dynamic.Tekla.Structures.Drawing.Text.TextAttributes inAttributes)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = Text;
			args[3] = Dynamic.Tekla.Structures.Drawing.Text.TextAttributes_.GetTSObject(inAttributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Text", args);
		}
		public Text(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point insertionPoint, System.String Text, Dynamic.Tekla.Structures.Drawing.PlacingBase Placing, Dynamic.Tekla.Structures.Drawing.Text.TextAttributes inAttributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(insertionPoint);
			args[2] = Text;
			args[3] = Dynamic.Tekla.Structures.Drawing.PlacingBase_.GetTSObject(Placing);
			args[4] = Dynamic.Tekla.Structures.Drawing.Text.TextAttributes_.GetTSObject(inAttributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Text", args);
		}


public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
{

    try
    {
        	var result = teklaObject.GetAxisAlignedBoundingBox();

        	var _result = Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAxisAlignedBoundingBox), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
{

    try
    {
        	var result = teklaObject.GetObjectAlignedBoundingBox();

        	var _result = Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjectAlignedBoundingBox), ex);
    }
}



public System.Boolean MoveObjectRelative(
	Dynamic.Tekla.Structures.Geometry3d.Vector MoveVector_
	)
{
	var MoveVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(MoveVector_);
    try
    {
        	var result = (System.Boolean) teklaObject.MoveObjectRelative(MoveVector);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(MoveObjectRelative), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
{

    try
    {
        	var result = teklaObject.GetObjects();

        	var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects(
	System.Type[] TypeFilter_
	)
{
	var TypeFilter = TypeConverter.ToTSObjects(TypeFilter_);
    try
    {
        	var result = teklaObject.GetObjects(TypeFilter);

        	var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
    }
}





    public  class TextAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font", ex); }
			}
			set
			{
				try {
				teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.TextAlignment Alignment
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.TextAlignment_.FromTSObject(teklaObject.Alignment);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Alignment", ex); }
			}
			set
			{
				try {
				teklaObject.Alignment = Dynamic.Tekla.Structures.Drawing.TextAlignment_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Alignment", ex); }
			}
		}

		public System.Double Angle
		{
			get
			{
				try {
					return teklaObject.Angle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle", ex); }
			}
			set
			{
				try {
					teklaObject.Angle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Angle", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.Frame Frame
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Frame_.FromTSObject(teklaObject.Frame);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame", ex); }
			}
			set
			{
				try {
				teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.Frame_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes ArrowHead
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.FromTSObject(teklaObject.ArrowHead);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArrowHead", ex); }
			}
			set
			{
				try {
				teklaObject.ArrowHead = Dynamic.Tekla.Structures.Drawing.ArrowheadAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArrowHead", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase PreferredPlacing
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.FromTSObject(teklaObject.PreferredPlacing);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PreferredPlacing", ex); }
			}
			set
			{
				try {
				teklaObject.PreferredPlacing = Dynamic.Tekla.Structures.Drawing.PreferredPlacingTypeBase_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PreferredPlacing", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.PlacingAttributes PlacingAttributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.PlacingAttributes_.FromTSObject(teklaObject.PlacingAttributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlacingAttributes", ex); }
			}
			set
			{
				try {
				teklaObject.PlacingAttributes = Dynamic.Tekla.Structures.Drawing.PlacingAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlacingAttributes", ex); }
			}
		}

		public System.Boolean UseWordWrapping
		{
			get
			{
				try {
					return teklaObject.UseWordWrapping;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UseWordWrapping", ex); }
			}
			set
			{
				try {
					teklaObject.UseWordWrapping = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UseWordWrapping", ex); }
			}
		}

		public System.Double RulerWidth
		{
			get
			{
				try {
					return teklaObject.RulerWidth;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RulerWidth", ex); }
			}
			set
			{
				try {
					teklaObject.RulerWidth = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RulerWidth", ex); }
			}
		}

		public System.Boolean TransparentBackground
		{
			get
			{
				try {
					return teklaObject.TransparentBackground;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TransparentBackground", ex); }
			}
			set
			{
				try {
					teklaObject.TransparentBackground = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TransparentBackground", ex); }
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

        

        

		public TextAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Text.TextAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TextAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TextAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Text.TextAttributes", args);
		}





    }

    internal static class TextAttributes_
    {
        public static dynamic GetTSObject(TextAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TextAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Text.TextAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TextAttributesArray_
    {
        public static dynamic GetTSObject(TextAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TextAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TextAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TextAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TextAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Text_
    {
        public static dynamic GetTSObject(Text dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Text FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Text)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TextArray_
    {
        public static dynamic GetTSObject(Text[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Text_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Text[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Text>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Text_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
