/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class ViewBase  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public System.Double Width
		{
			get
			{
				try {
					return teklaObject.Width;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width", ex); }
			}
			set
			{
				try {
					teklaObject.Width = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width", ex); }
			}
		}

		public System.Double Height
		{
			get
			{
				try {
					return teklaObject.Height;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Height", ex); }
			}
			set
			{
				try {
					teklaObject.Height = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Height", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector FrameOrigin
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.FrameOrigin);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FrameOrigin", ex); }
			}
			set
			{
				try {
				teklaObject.FrameOrigin = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FrameOrigin", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin", ex); }
			}
			set
			{
				try {
				teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ExtremaCenter
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ExtremaCenter);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtremaCenter", ex); }
			}
			set
			{
				try {
				teklaObject.ExtremaCenter = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtremaCenter", ex); }
			}
		}

		public System.Boolean IsSheet
		{
			get
			{
				try {
					return teklaObject.IsSheet;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsSheet", ex); }
			}
			set
			{
				try {
					teklaObject.IsSheet = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsSheet", ex); }
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



public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetAllObjects()
{

    try
    {
        	var result = teklaObject.GetAllObjects();

        	var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAllObjects), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetAllObjects(
	System.Type Type_
	)
{
	var Type = ObjectConverter.ToTSObject(Type_);
    try
    {
        	var result = teklaObject.GetAllObjects(Type);

        	var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAllObjects), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetModelObjects(
	Dynamic.Tekla.Structures.Identifier ModelIdentifier_
	)
{
	var ModelIdentifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ModelIdentifier_);
    try
    {
        	var result = teklaObject.GetModelObjects(ModelIdentifier);

        	var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetModelObjects), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.Drawing GetOriginalDrawing()
{

    try
    {
        	var result = teklaObject.GetOriginalDrawing();

        	var _result = Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetOriginalDrawing), ex);
    }
}






    }

    internal static class ViewBase_
    {
        public static dynamic GetTSObject(ViewBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ViewBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewBaseArray_
    {
        public static dynamic GetTSObject(ViewBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
