/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class Distance 
    {

        

        internal dynamic teklaObject;


		public static System.Double PointToPoint(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2);
			var result = (System.Double) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Distance", "PointToPoint", parameters);
			return result;
		}

		public static System.Double PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.Line Line)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line);
			var result = (System.Double) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Distance", "PointToLine", parameters);
			return result;
		}

		public static System.Double PointToLineSegment(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment);
			var result = (System.Double) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Distance", "PointToLineSegment", parameters);
			return result;
		}

		public static System.Double PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane);
			var result = (System.Double) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Distance", "PointToPlane", parameters);
			return result;
		}





    }

    internal static class Distance_
    {
        public static dynamic GetTSObject(Distance dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Distance FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Distance_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Distance[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Distance>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Distance_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
