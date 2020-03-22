/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class Intersection 
    {

        

        internal dynamic teklaObject;


		public Dynamic.Tekla.Structures.Geometry3d.LineSegment LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line line1, Dynamic.Tekla.Structures.Geometry3d.Line line2)
		{
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.LineToLine(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line1), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line2)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line line, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.LineToPlane(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.LineSegmentToPlane(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Line PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane1, Dynamic.Tekla.Structures.Geometry3d.GeometricPlane plane2)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(teklaObject.PlaneToPlane(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane1), Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(plane2)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment LineToObb(Dynamic.Tekla.Structures.Geometry3d.Line line, Dynamic.Tekla.Structures.Geometry3d.OBB obb)
		{
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.LineToObb(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line), Dynamic.Tekla.Structures.Geometry3d.OBB_.GetTSObject(obb)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegmentToObb(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment, Dynamic.Tekla.Structures.Geometry3d.OBB obb)
		{
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.LineSegmentToObb(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment), Dynamic.Tekla.Structures.Geometry3d.OBB_.GetTSObject(obb)));
		}





    }

    internal static class Intersection_
    {
        public static dynamic GetTSObject(Intersection dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Intersection FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.Intersection)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
