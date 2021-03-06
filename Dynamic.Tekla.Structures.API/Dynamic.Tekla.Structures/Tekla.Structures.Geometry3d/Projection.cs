/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class Projection 
    {

        

        internal dynamic teklaObject;



        public static Dynamic.Tekla.Structures.Geometry3d.Point PointToLine(
			Dynamic.Tekla.Structures.Geometry3d.Point Point_,
			Dynamic.Tekla.Structures.Geometry3d.Line Line_)
        {
            var Point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point_);
var Line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Projection", "PointToLine", Point, Line);
            var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Geometry3d.Point PointToPlane(
			Dynamic.Tekla.Structures.Geometry3d.Point Point_,
			Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_)
        {
            var Point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point_);
var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Projection", "PointToPlane", Point, Plane);
            var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Geometry3d.Line LineToPlane(
			Dynamic.Tekla.Structures.Geometry3d.Line Line_,
			Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_)
        {
            var Line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line_);
var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Projection", "LineToPlane", Line, Plane);
            var _result = Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(result);
				return _result;
        }



        public static Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegmentToPlane(
			Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment_,
			Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_)
        {
            var LineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment_);
var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Projection", "LineSegmentToPlane", LineSegment, Plane);
            var _result = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(result);
				return _result;
        }






    }

    internal static class Projection_
    {
        public static dynamic GetTSObject(Projection dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Projection FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Projection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ProjectionArray_
    {
        public static dynamic GetTSObject(Projection[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Projection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Projection[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Projection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Projection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
