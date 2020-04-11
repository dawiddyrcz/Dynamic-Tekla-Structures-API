/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class MarkBase  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
		}

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

		public System.Boolean IsAssociativeNote
		{
			get
			{
				try {
					return teklaObject.IsAssociativeNote;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsAssociativeNote", ex); }
			}
			set
			{
				try {
					teklaObject.IsAssociativeNote = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsAssociativeNote", ex); }
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





    public abstract class MarkBaseAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

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

		public System.Double RotationAngle
		{
			get
			{
				try {
					return teklaObject.RotationAngle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAngle", ex); }
			}
			set
			{
				try {
					teklaObject.RotationAngle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RotationAngle", ex); }
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

		public Dynamic.Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes.TextAlignOptions TextAlignment
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes.TextAlignOptions_.FromTSObject(teklaObject.TextAlignment);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TextAlignment", ex); }
			}
			set
			{
				try {
				teklaObject.TextAlignment = Dynamic.Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes.TextAlignOptions_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TextAlignment", ex); }
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

        

        





    public enum TextAlignOptions
    {
			Left,
			Center,
			Right        
    }

    internal static class TextAlignOptions_
    {
        public static dynamic GetTSObject(TextAlignOptions dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes.TextAlignOptions").GetType();

            switch (dynEnum)
            {
				case TextAlignOptions.Left:
					return System.Enum.Parse(tsType, "Left");
				case TextAlignOptions.Center:
					return System.Enum.Parse(tsType, "Center");
				case TextAlignOptions.Right:
					return System.Enum.Parse(tsType, "Right");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static TextAlignOptions FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Left", System.StringComparison.InvariantCulture))
				return TextAlignOptions.Left;
			else if (tsEnumValue.Equals("Center", System.StringComparison.InvariantCulture))
				return TextAlignOptions.Center;
			else if (tsEnumValue.Equals("Right", System.StringComparison.InvariantCulture))
				return TextAlignOptions.Right;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class MarkBaseAttributes_
    {
        public static dynamic GetTSObject(MarkBaseAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MarkBaseAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.MarkBase.MarkBaseAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MarkBaseAttributesArray_
    {
        public static dynamic GetTSObject(MarkBaseAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MarkBaseAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MarkBaseAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MarkBaseAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MarkBaseAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class MarkBase_
    {
        public static dynamic GetTSObject(MarkBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MarkBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.MarkBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MarkBaseArray_
    {
        public static dynamic GetTSObject(MarkBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MarkBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MarkBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MarkBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MarkBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
