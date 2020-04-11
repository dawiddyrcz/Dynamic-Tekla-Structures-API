/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class RectangleBoundingBox  : Dynamic.Tekla.Structures.Geometry3d.AABB
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point UpperLeft
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.UpperLeft);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpperLeft", ex); }
			}
			set
			{
				try {
				teklaObject.UpperLeft = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpperLeft", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point UpperRight
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.UpperRight);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpperRight", ex); }
			}
			set
			{
				try {
				teklaObject.UpperRight = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpperRight", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point LowerLeft
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.LowerLeft);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LowerLeft", ex); }
			}
			set
			{
				try {
				teklaObject.LowerLeft = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LowerLeft", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point LowerRight
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.LowerRight);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LowerRight", ex); }
			}
			set
			{
				try {
				teklaObject.LowerRight = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LowerRight", ex); }
			}
		}

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

		public System.Double AngleToAxis
		{
			get
			{
				try {
					return teklaObject.AngleToAxis;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngleToAxis", ex); }
			}
			set
			{
				try {
					teklaObject.AngleToAxis = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngleToAxis", ex); }
			}
		}

        

        

		internal RectangleBoundingBox() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RectangleBoundingBox(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public static Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox CreateRectangleBoundingBox(
	Dynamic.Tekla.Structures.Geometry3d.Point CenterPoint_,
	System.Double Width,
	System.Double Height,
	System.Double AngleToAxis
	)
{
	var CenterPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(CenterPoint_);
	
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.RectangleBoundingBox", "CreateRectangleBoundingBox", CenterPoint, Width, Height, AngleToAxis);
	var _result = Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(result);
	return _result;
}



public System.Boolean IsEqual(
	System.Object ObjectToCompare
	)
{
	
    try
    {
        	var result = teklaObject.IsEqual(ObjectToCompare);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsEqual), ex);
    }
}






    }

    internal static class RectangleBoundingBox_
    {
        public static dynamic GetTSObject(RectangleBoundingBox dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RectangleBoundingBox FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RectangleBoundingBoxArray_
    {
        public static dynamic GetTSObject(RectangleBoundingBox[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RectangleBoundingBox_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RectangleBoundingBox[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RectangleBoundingBox>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RectangleBoundingBox_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
