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

    public abstract class Distance 
    {

        

        internal dynamic teklaObject;



        public static System.Double PointToPoint(
			Dynamic.Tekla.Structures.Geometry3d.Point Point1_,
			Dynamic.Tekla.Structures.Geometry3d.Point Point2_)
        {
            var Point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1_);
var Point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2_);
            var result = (System.Double) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Distance", "PointToPoint", Point1, Point2);
            return result;
        }



        public static System.Double PointToLine(
			Dynamic.Tekla.Structures.Geometry3d.Point Point_,
			Dynamic.Tekla.Structures.Geometry3d.Line Line_)
        {
            var Point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point_);
var Line = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line_);
            var result = (System.Double) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Distance", "PointToLine", Point, Line);
            return result;
        }



        public static System.Double PointToLineSegment(
			Dynamic.Tekla.Structures.Geometry3d.Point Point_,
			Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment_)
        {
            var Point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point_);
var LineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment_);
            var result = (System.Double) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Distance", "PointToLineSegment", Point, LineSegment);
            return result;
        }



        public static System.Double PointToPlane(
			Dynamic.Tekla.Structures.Geometry3d.Point Point_,
			Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane_)
        {
            var Point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point_);
var Plane = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane_);
            var result = (System.Double) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Distance", "PointToPlane", Point, Plane);
            return result;
        }






    }

    internal static class Distance_
    {
        public static dynamic GetTSObject(Distance dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Distance FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Distance)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DistanceArray_
    {
        public static dynamic GetTSObject(Distance[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Distance_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Distance[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Distance>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Distance_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
