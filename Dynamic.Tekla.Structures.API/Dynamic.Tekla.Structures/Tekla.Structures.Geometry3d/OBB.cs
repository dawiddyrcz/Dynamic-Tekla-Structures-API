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
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Center);
			set { teklaObject.Center = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Axis0
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Axis0);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Axis1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Axis1);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Axis2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Axis2);

		}

		public System.Double Extent0
		{
			get => teklaObject.Extent0;
			set { teklaObject.Extent0 = value; }
		}

		public System.Double Extent1
		{
			get => teklaObject.Extent1;
			set { teklaObject.Extent1 = value; }
		}

		public System.Double Extent2
		{
			get => teklaObject.Extent2;
			set { teklaObject.Extent2 = value; }
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

		public void SetAxis(Dynamic.Tekla.Structures.Geometry3d.Vector axis0, Dynamic.Tekla.Structures.Geometry3d.Vector axis1, Dynamic.Tekla.Structures.Geometry3d.Vector axis2)
		{
			teklaObject.SetAxis(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(axis0), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(axis1), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(axis2));
		}

		public void SetAxis(Dynamic.Tekla.Structures.Geometry3d.Vector[] axis)
		{
			teklaObject.SetAxis(Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(axis));
		}

		public void SetExtent(System.Double extent0, System.Double extent1, System.Double extent2)
		{
			teklaObject.SetExtent(extent0, extent1, extent2);
		}

		public void SetExtent(System.Double[] extent)
		{
			teklaObject.SetExtent(extent);
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point[] ComputeVertices()
		{
			return Dynamic.Tekla.Structures.Geometry3d.PointArray_.FromTSObject(teklaObject.ComputeVertices());
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ClosestPointTo(Dynamic.Tekla.Structures.Geometry3d.Point point)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ClosestPointTo(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ClosestPointTo(Dynamic.Tekla.Structures.Geometry3d.Line line)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ClosestPointTo(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ClosestPointTo(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ClosestPointTo(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment)));
		}

		public System.Double DistanceTo(Dynamic.Tekla.Structures.Geometry3d.Point point)
		{
			return teklaObject.DistanceTo(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point));
		}

		public System.Double DistanceTo(Dynamic.Tekla.Structures.Geometry3d.Line line)
		{
			return teklaObject.DistanceTo(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line));
		}

		public System.Double DistanceTo(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment)
		{
			return teklaObject.DistanceTo(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point[] IntersectionPointsWith(Dynamic.Tekla.Structures.Geometry3d.Line line)
		{
			return Dynamic.Tekla.Structures.Geometry3d.PointArray_.FromTSObject(teklaObject.IntersectionPointsWith(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point[] IntersectionPointsWith(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment)
		{
			return Dynamic.Tekla.Structures.Geometry3d.PointArray_.FromTSObject(teklaObject.IntersectionPointsWith(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment IntersectionWith(Dynamic.Tekla.Structures.Geometry3d.Line line)
		{
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.IntersectionWith(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment IntersectionWith(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment)
		{
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.IntersectionWith(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment)));
		}

		public System.Boolean Intersects(Dynamic.Tekla.Structures.Geometry3d.OBB obb)
		{
			return teklaObject.Intersects(Dynamic.Tekla.Structures.Geometry3d.OBB_.GetTSObject(obb));
		}

		public System.Boolean Intersects(Dynamic.Tekla.Structures.Geometry3d.Line line)
		{
			return teklaObject.Intersects(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line));
		}

		public System.Boolean Intersects(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment)
		{
			return teklaObject.Intersects(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment));
		}

		public System.Boolean Intersects(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane geometricPlane)
		{
			return teklaObject.Intersects(Dynamic.Tekla.Structures.Geometry3d.GeometricPlane_.GetTSObject(geometricPlane));
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment ShortestSegmentTo(Dynamic.Tekla.Structures.Geometry3d.Line line)
		{
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.ShortestSegmentTo(Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(line)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment ShortestSegmentTo(Dynamic.Tekla.Structures.Geometry3d.LineSegment lineSegment)
		{
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.ShortestSegmentTo(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(lineSegment)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment ShortestSegmentTo(Dynamic.Tekla.Structures.Geometry3d.Point point)
		{
			return Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.ShortestSegmentTo(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point)));
		}





    }

    internal static class OBB_
    {
        public static dynamic GetTSObject(OBB dynObject)
        {
            return dynObject.teklaObject;
        }

        public static OBB FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(OBB_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static OBB[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<OBB>();
            foreach(var tsItem in tsArray)
            {
                list.Add(OBB_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
