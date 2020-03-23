/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BendSurface 
    {

		public System.Boolean InwardCurved
		{
			get => teklaObject.InwardCurved;
			set { teklaObject.InwardCurved = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Line IntersectionLine
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(teklaObject.IntersectionLine);
			set { teklaObject.IntersectionLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.EndFaceNormal1);
			set { teklaObject.EndFaceNormal1 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.EndFaceNormal2);
			set { teklaObject.EndFaceNormal2 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Line CenterLine
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(teklaObject.CenterLine);
			set { teklaObject.CenterLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxis
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.RotationAxis);
			set { teklaObject.RotationAxis = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary1
		{
			get => teklaObject.LateralBoundary1;
			set { teklaObject.LateralBoundary1 = value; }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary2
		{
			get => teklaObject.LateralBoundary2;
			set { teklaObject.LateralBoundary2 = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.SideBoundary1);
			set { teklaObject.SideBoundary1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.SideBoundary2);
			set { teklaObject.SideBoundary2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;






    }

    internal static class BendSurface_
    {
        public static dynamic GetTSObject(BendSurface dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BendSurface FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.BendSurface)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BendSurfaceArray_
    {
        public static dynamic GetTSObject(BendSurface[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BendSurface_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BendSurface[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<BendSurface>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BendSurface_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
