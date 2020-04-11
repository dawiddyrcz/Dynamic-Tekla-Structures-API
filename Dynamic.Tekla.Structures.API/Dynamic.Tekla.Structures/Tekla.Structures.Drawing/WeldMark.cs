/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class WeldMark  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Identifier ModelIdentifier
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.ModelIdentifier);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelIdentifier", ex); }
			}
			set
			{
				try {
				teklaObject.ModelIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelIdentifier", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes Attributes
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes", ex); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes_.GetTSObject(value);
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

        

        

		internal WeldMark() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public WeldMark(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
        	var result = teklaObject.MoveObjectRelative(MoveVector);

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





    public  class SeamVisibilityAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Boolean ShowPrefix
		{
			get
			{
				try {
					return teklaObject.ShowPrefix;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowPrefix", ex); }
			}
			set
			{
				try {
					teklaObject.ShowPrefix = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowPrefix", ex); }
			}
		}

		public System.Boolean ShowSize
		{
			get
			{
				try {
					return teklaObject.ShowSize;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowSize", ex); }
			}
			set
			{
				try {
					teklaObject.ShowSize = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowSize", ex); }
			}
		}

		public System.Boolean ShowType
		{
			get
			{
				try {
					return teklaObject.ShowType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowType", ex); }
			}
			set
			{
				try {
					teklaObject.ShowType = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowType", ex); }
			}
		}

		public System.Boolean ShowAngle
		{
			get
			{
				try {
					return teklaObject.ShowAngle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowAngle", ex); }
			}
			set
			{
				try {
					teklaObject.ShowAngle = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowAngle", ex); }
			}
		}

		public System.Boolean ShowContour
		{
			get
			{
				try {
					return teklaObject.ShowContour;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowContour", ex); }
			}
			set
			{
				try {
					teklaObject.ShowContour = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowContour", ex); }
			}
		}

		public System.Boolean ShowFinish
		{
			get
			{
				try {
					return teklaObject.ShowFinish;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowFinish", ex); }
			}
			set
			{
				try {
					teklaObject.ShowFinish = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowFinish", ex); }
			}
		}

		public System.Boolean ShowLength
		{
			get
			{
				try {
					return teklaObject.ShowLength;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowLength", ex); }
			}
			set
			{
				try {
					teklaObject.ShowLength = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowLength", ex); }
			}
		}

		public System.Boolean ShowPitch
		{
			get
			{
				try {
					return teklaObject.ShowPitch;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowPitch", ex); }
			}
			set
			{
				try {
					teklaObject.ShowPitch = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowPitch", ex); }
			}
		}

		public System.Boolean ShowEffectiveThroat
		{
			get
			{
				try {
					return teklaObject.ShowEffectiveThroat;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowEffectiveThroat", ex); }
			}
			set
			{
				try {
					teklaObject.ShowEffectiveThroat = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowEffectiveThroat", ex); }
			}
		}

		public System.Boolean ShowRootOpening
		{
			get
			{
				try {
					return teklaObject.ShowRootOpening;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowRootOpening", ex); }
			}
			set
			{
				try {
					teklaObject.ShowRootOpening = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowRootOpening", ex); }
			}
		}

        

        

		public SeamVisibilityAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SeamVisibilityAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SeamVisibilityAttributes(System.Boolean showPrefix, System.Boolean showSize, System.Boolean showType, System.Boolean showAngle, System.Boolean showContour, System.Boolean showFinish, System.Boolean showLength, System.Boolean showPitch, System.Boolean showEffectiveThroat, System.Boolean showRootOpening)
		{
			var args = new object[10];
			args[0] = showPrefix;
			args[1] = showSize;
			args[2] = showType;
			args[3] = showAngle;
			args[4] = showContour;
			args[5] = showFinish;
			args[6] = showLength;
			args[7] = showPitch;
			args[8] = showEffectiveThroat;
			args[9] = showRootOpening;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes", args);
		}





    }

    internal static class SeamVisibilityAttributes_
    {
        public static dynamic GetTSObject(SeamVisibilityAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SeamVisibilityAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SeamVisibilityAttributesArray_
    {
        public static dynamic GetTSObject(SeamVisibilityAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SeamVisibilityAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SeamVisibilityAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SeamVisibilityAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SeamVisibilityAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class WeldMarkAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.Boolean ShowWeldNumber
		{
			get
			{
				try {
					return teklaObject.ShowWeldNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowWeldNumber", ex); }
			}
			set
			{
				try {
					teklaObject.ShowWeldNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowWeldNumber", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes SeamAbove
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes_.FromTSObject(teklaObject.SeamAbove);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SeamAbove", ex); }
			}
			set
			{
				try {
				teklaObject.SeamAbove = Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SeamAbove", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes SeamBelow
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes_.FromTSObject(teklaObject.SeamBelow);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SeamBelow", ex); }
			}
			set
			{
				try {
				teklaObject.SeamBelow = Dynamic.Tekla.Structures.Drawing.WeldMark.SeamVisibilityAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SeamBelow", ex); }
			}
		}

		public System.Boolean ShowReferenceText
		{
			get
			{
				try {
					return teklaObject.ShowReferenceText;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowReferenceText", ex); }
			}
			set
			{
				try {
					teklaObject.ShowReferenceText = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowReferenceText", ex); }
			}
		}

		public System.Boolean ShowEdgeAround
		{
			get
			{
				try {
					return teklaObject.ShowEdgeAround;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowEdgeAround", ex); }
			}
			set
			{
				try {
					teklaObject.ShowEdgeAround = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowEdgeAround", ex); }
			}
		}

		public System.Boolean ShowWorkshopSite
		{
			get
			{
				try {
					return teklaObject.ShowWorkshopSite;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowWorkshopSite", ex); }
			}
			set
			{
				try {
					teklaObject.ShowWorkshopSite = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShowWorkshopSite", ex); }
			}
		}

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

        

        

		public WeldMarkAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public WeldMarkAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public WeldMarkAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes", args);
		}





    }

    internal static class WeldMarkAttributes_
    {
        public static dynamic GetTSObject(WeldMarkAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static WeldMarkAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.WeldMark.WeldMarkAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class WeldMarkAttributesArray_
    {
        public static dynamic GetTSObject(WeldMarkAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(WeldMarkAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static WeldMarkAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<WeldMarkAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(WeldMarkAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class WeldMark_
    {
        public static dynamic GetTSObject(WeldMark dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static WeldMark FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.WeldMark)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class WeldMarkArray_
    {
        public static dynamic GetTSObject(WeldMark[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(WeldMark_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static WeldMark[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<WeldMark>();
            foreach(var tsItem in tsArray)
            {
                list.Add(WeldMark_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
