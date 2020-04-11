/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class OBB 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Center
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Center);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Center", ex); }
			}
			set
			{
				try {
				teklaObject.Center = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Center", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Axis0
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Axis0);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Axis0", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Axis1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Axis1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Axis1", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Axis2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Axis2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Axis2", ex); }
			}
		}

		public System.Double Extent0
		{
			get
			{
				try {
					return teklaObject.Extent0;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extent0", ex); }
			}
			set
			{
				try {
					teklaObject.Extent0 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extent0", ex); }
			}
		}

		public System.Double Extent1
		{
			get
			{
				try {
					return teklaObject.Extent1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extent1", ex); }
			}
			set
			{
				try {
					teklaObject.Extent1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extent1", ex); }
			}
		}

		public System.Double Extent2
		{
			get
			{
				try {
					return teklaObject.Extent2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extent2", ex); }
			}
			set
			{
				try {
					teklaObject.Extent2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extent2", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public OBB()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.OBB");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public OBB(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public OBB(Dynamic.Tekla.Structures.Geometry3d.Point center, Dynamic.Tekla.Structures.Geometry3d.Vector axis0, Dynamic.Tekla.Structures.Geometry3d.Vector axis1, Dynamic.Tekla.Structures.Geometry3d.Vector axis2, System.Double extent0, System.Double extent1, System.Double extent2)
		{
			var args = new object[7];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(center);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(axis0);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(axis1);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(axis2);
			args[4] = extent0;
			args[5] = extent1;
			args[6] = extent2;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.OBB", args);
		}
		public OBB(Dynamic.Tekla.Structures.Geometry3d.Point center, Dynamic.Tekla.Structures.Geometry3d.Vector[] axis, System.Double[] extent)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(center);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(axis);
			args[2] = extent;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.OBB", args);
		}
		public OBB(Dynamic.Tekla.Structures.Geometry3d.OBB obb)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.OBB_.GetTSObject(obb);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.OBB", args);
		}


public void SetAxis(
	Dynamic.Tekla.Structures.Geometry3d.Vector axis0_,
	Dynamic.Tekla.Structures.Geometry3d.Vector axis1_,
	Dynamic.Tekla.Structures.Geometry3d.Vector axis2_
	)
{
	var axis0 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(axis0_);
	var axis1 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(axis1_);
	var axis2 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(axis2_);
    try
    {
        	teklaObject.SetAxis(axis0, axis1, axis2);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAxis), ex);
    }
}



public void SetAxis(
	Dynamic.Tekla.Structures.Geometry3d.Vector[] axis_
	)
{
	var axis = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(axis_);
    try
    {
        	teklaObject.SetAxis(axis);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAxis), ex);
    }
}



public void SetExtent(
	System.Double extent0,
	System.Double extent1,
	System.Double extent2
	)
{
	
	
	
    try
    {
        	teklaObject.SetExtent(extent0, extent1, extent2);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetExtent), ex);
    }
}



public void SetExtent(
	System.Double[] extent
	)
{
	
    try
    {
        	teklaObject.SetExtent(extent);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetExtent), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.Point[] ComputeVertices()
{

    try
    {
        	var result = teklaObject.ComputeVertices();

        	var _result = Dynamic.Tekla.Structures.Geometry3d.PointArray_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ComputeVertices), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.Point ClosestPointTo(
	Dynamic.Tekla.Structures.Geometry3d.Point point_
	)
{
	var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
    try
    {
        	var result = teklaObject.ClosestPointTo(point);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ClosestPointTo), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.Point ClosestPointTo(
	Dynamic.Tekla.Structures.Geometry3d.Line line_
	)
{
	var line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line_);
    try
    {
        	var result = teklaObject.ClosestPointTo(line);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ClosestPointTo), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.Point ClosestPointTo(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment_
	)
{
	var lineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment_);
    try
    {
        	var result = teklaObject.ClosestPointTo(lineSegment);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ClosestPointTo), ex);
    }
}



public System.Double DistanceTo(
	Dynamic.Tekla.Structures.Geometry3d.Point point_
	)
{
	var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
    try
    {
        	var result = teklaObject.DistanceTo(point);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DistanceTo), ex);
    }
}



public System.Double DistanceTo(
	Dynamic.Tekla.Structures.Geometry3d.Line line_
	)
{
	var line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line_);
    try
    {
        	var result = teklaObject.DistanceTo(line);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DistanceTo), ex);
    }
}



public System.Double DistanceTo(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment_
	)
{
	var lineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment_);
    try
    {
        	var result = teklaObject.DistanceTo(lineSegment);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DistanceTo), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.Point[] IntersectionPointsWith(
	Dynamic.Tekla.Structures.Geometry3d.Line line_
	)
{
	var line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line_);
    try
    {
        	var result = teklaObject.IntersectionPointsWith(line);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.PointArray_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IntersectionPointsWith), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.Point[] IntersectionPointsWith(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment_
	)
{
	var lineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment_);
    try
    {
        	var result = teklaObject.IntersectionPointsWith(lineSegment);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.PointArray_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IntersectionPointsWith), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.LineSegment IntersectionWith(
	Dynamic.Tekla.Structures.Geometry3d.Line line_
	)
{
	var line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line_);
    try
    {
        	var result = teklaObject.IntersectionWith(line);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IntersectionWith), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.LineSegment IntersectionWith(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment_
	)
{
	var lineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment_);
    try
    {
        	var result = teklaObject.IntersectionWith(lineSegment);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IntersectionWith), ex);
    }
}



public System.Boolean Intersects(
	Dynamic.Tekla.Structures.Geometry3d.OBB obb_
	)
{
	var obb = Dynamic.Tekla.Structures.Geometry3d.OBB_.GetTSObject(obb_);
    try
    {
        	var result = teklaObject.Intersects(obb);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersects), ex);
    }
}



public System.Boolean Intersects(
	Dynamic.Tekla.Structures.Geometry3d.Line line_
	)
{
	var line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line_);
    try
    {
        	var result = teklaObject.Intersects(line);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersects), ex);
    }
}



public System.Boolean Intersects(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment_
	)
{
	var lineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment_);
    try
    {
        	var result = teklaObject.Intersects(lineSegment);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersects), ex);
    }
}



public System.Boolean Intersects(
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane geometricPlane_
	)
{
	var geometricPlane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(geometricPlane_);
    try
    {
        	var result = teklaObject.Intersects(geometricPlane);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersects), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.LineSegment ShortestSegmentTo(
	Dynamic.Tekla.Structures.Geometry3d.Line line_
	)
{
	var line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line_);
    try
    {
        	var result = teklaObject.ShortestSegmentTo(line);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ShortestSegmentTo), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.LineSegment ShortestSegmentTo(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment_
	)
{
	var lineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment_);
    try
    {
        	var result = teklaObject.ShortestSegmentTo(lineSegment);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ShortestSegmentTo), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.LineSegment ShortestSegmentTo(
	Dynamic.Tekla.Structures.Geometry3d.Point point_
	)
{
	var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
    try
    {
        	var result = teklaObject.ShortestSegmentTo(point);

        	var _result = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ShortestSegmentTo), ex);
    }
}






    }

    internal static class OBB_
    {
        public static dynamic GetTSObject(OBB dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static OBB FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.OBB)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class OBBArray_
    {
        public static dynamic GetTSObject(OBB[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(OBB_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static OBB[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<OBB>();
            foreach(var tsItem in tsArray)
            {
                list.Add(OBB_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
