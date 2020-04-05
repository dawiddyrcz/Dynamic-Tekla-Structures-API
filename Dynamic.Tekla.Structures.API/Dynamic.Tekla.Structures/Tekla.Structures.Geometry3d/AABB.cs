/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class AABB 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point MinPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.MinPoint);
			set { teklaObject.MinPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point MaxPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.MaxPoint);
			set { teklaObject.MaxPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public AABB()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.AABB");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public AABB(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public AABB(Dynamic.Tekla.Structures.Geometry3d.Point MinPoint, Dynamic.Tekla.Structures.Geometry3d.Point MaxPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(MinPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(MaxPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.AABB", args);
		}
		public AABB(Dynamic.Tekla.Structures.Geometry3d.AABB AABB)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(AABB);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.AABB", args);
		}

		public System.Boolean IsInside(Dynamic.Tekla.Structures.Geometry3d.Point Point)
		{
			return teklaObject.IsInside(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point));
		}

		public System.Boolean IsInside(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment)
		{
			return teklaObject.IsInside(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point GetCenterPoint()
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.GetCenterPoint());
		}

		public System.Boolean Collide(Dynamic.Tekla.Structures.Geometry3d.AABB Other)
		{
			return teklaObject.Collide(Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(Other));
		}


		public static Dynamic.Tekla.Structures.Geometry3d.AABB operator +(Dynamic.Tekla.Structures.Geometry3d.AABB o1, Dynamic.Tekla.Structures.Geometry3d.AABB o2)
		{
			var o1Tek = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(o2);
			return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(o1Tek + o2Tek);
		}
		public static Dynamic.Tekla.Structures.Geometry3d.AABB operator +(Dynamic.Tekla.Structures.Geometry3d.AABB o1, Dynamic.Tekla.Structures.Geometry3d.Point o2)
		{
			var o1Tek = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(o2);
			return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(o1Tek + o2Tek);
		}
		public static Dynamic.Tekla.Structures.Geometry3d.AABB operator +(Dynamic.Tekla.Structures.Geometry3d.Point o1, Dynamic.Tekla.Structures.Geometry3d.AABB o2)
		{
			var o1Tek = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(o2);
			return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(o1Tek + o2Tek);
		}



    }

    internal static class AABB_
    {
        public static dynamic GetTSObject(AABB dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static AABB FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.AABB)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AABBArray_
    {
        public static dynamic GetTSObject(AABB[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(AABB_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static AABB[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<AABB>();
            foreach(var tsItem in tsArray)
            {
                list.Add(AABB_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
