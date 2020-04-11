/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class Parallel 
    {

        

        internal dynamic teklaObject;



public static System.Boolean VectorToVector(
	Dynamic.Tekla.Structures.Geometry3d.Vector Vector1_,
	Dynamic.Tekla.Structures.Geometry3d.Vector Vector2_
	)
{
	var Vector1 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1_);
	var Vector2 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "VectorToVector", Vector1, Vector2);
	return result;
}



public static System.Boolean VectorToVector(
	Dynamic.Tekla.Structures.Geometry3d.Vector Vector1_,
	Dynamic.Tekla.Structures.Geometry3d.Vector Vector2_,
	System.Double Tolerance
	)
{
	var Vector1 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1_);
	var Vector2 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "VectorToVector", Vector1, Vector2, Tolerance);
	return result;
}



public static System.Boolean LineToLine(
	Dynamic.Tekla.Structures.Geometry3d.Line Line1_,
	Dynamic.Tekla.Structures.Geometry3d.Line Line2_
	)
{
	var Line1 = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line1_);
	var Line2 = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line2_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineToLine", Line1, Line2);
	return result;
}



public static System.Boolean LineToLine(
	Dynamic.Tekla.Structures.Geometry3d.Line Line1_,
	Dynamic.Tekla.Structures.Geometry3d.Line Line2_,
	System.Double Tolerance
	)
{
	var Line1 = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line1_);
	var Line2 = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line2_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineToLine", Line1, Line2, Tolerance);
	return result;
}



public static System.Boolean LineSegmentToLineSegment(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment1_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment2_
	)
{
	var LineSegment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment1_);
	var LineSegment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment2_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineSegmentToLineSegment", LineSegment1, LineSegment2);
	return result;
}



public static System.Boolean LineSegmentToLineSegment(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment1_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment2_,
	System.Double Tolerance
	)
{
	var LineSegment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment1_);
	var LineSegment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment2_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineSegmentToLineSegment", LineSegment1, LineSegment2, Tolerance);
	return result;
}



public static System.Boolean PlaneToPlane(
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane1_,
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane2_
	)
{
	var Plane1 = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane1_);
	var Plane2 = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane2_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "PlaneToPlane", Plane1, Plane2);
	return result;
}



public static System.Boolean PlaneToPlane(
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane1_,
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane2_,
	System.Double Tolerance
	)
{
	var Plane1 = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane1_);
	var Plane2 = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane2_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "PlaneToPlane", Plane1, Plane2, Tolerance);
	return result;
}



public static System.Boolean VectorToPlane(
	Dynamic.Tekla.Structures.Geometry3d.Vector Vector_,
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_
	)
{
	var Vector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector_);
	var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "VectorToPlane", Vector, Plane);
	return result;
}



public static System.Boolean VectorToPlane(
	Dynamic.Tekla.Structures.Geometry3d.Vector Vector_,
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_,
	System.Double Tolerance
	)
{
	var Vector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector_);
	var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "VectorToPlane", Vector, Plane, Tolerance);
	return result;
}



public static System.Boolean LineToPlane(
	Dynamic.Tekla.Structures.Geometry3d.Line Line_,
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_
	)
{
	var Line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line_);
	var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineToPlane", Line, Plane);
	return result;
}



public static System.Boolean LineToPlane(
	Dynamic.Tekla.Structures.Geometry3d.Line Line_,
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_,
	System.Double Tolerance
	)
{
	var Line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line_);
	var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineToPlane", Line, Plane, Tolerance);
	return result;
}



public static System.Boolean LineSegmentToPlane(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment_,
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_
	)
{
	var LineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment_);
	var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineSegmentToPlane", LineSegment, Plane);
	return result;
}



public static System.Boolean LineSegmentToPlane(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment_,
	Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_,
	System.Double Tolerance
	)
{
	var LineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment_);
	var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Parallel", "LineSegmentToPlane", LineSegment, Plane, Tolerance);
	return result;
}






    }

    internal static class Parallel_
    {
        public static dynamic GetTSObject(Parallel dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Parallel FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Parallel)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ParallelArray_
    {
        public static dynamic GetTSObject(Parallel[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Parallel_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Parallel[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Parallel>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Parallel_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
