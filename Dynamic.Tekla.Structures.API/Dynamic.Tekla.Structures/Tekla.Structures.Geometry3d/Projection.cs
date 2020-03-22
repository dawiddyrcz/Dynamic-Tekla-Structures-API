/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class Projection 
    {

        

        internal dynamic teklaObject;


		public Dynamic.Tekla.Structures.Geometry3d.Point PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.Line Line)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.PointToLine(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.PointToPlane(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Line LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line Line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(teklaObject.LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(Line), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane Plane)
		{
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(Plane)));
		}





    }

    internal static class Projection_
    {
        public static dynamic GetTSObject(Projection dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Projection FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.Projection)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
