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


		public System.Double PointToPoint(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2)
		{
			return teklaObject.PointToPoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2));
		}

		public System.Double PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.Line Line)
		{
			return teklaObject.PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line));
		}

		public System.Double PointToLineSegment(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment)
		{
			return teklaObject.PointToLineSegment(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment));
		}

		public System.Double PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			return teklaObject.PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane));
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
            var dynObject = (Tekla.Structures.Geometry3d.Distance)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
