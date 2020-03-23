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

		public static Dynamic.Tekla.Structures.Geometry3d.AABB op_Addition(Dynamic.Tekla.Structures.Geometry3d.AABB AABB1, Dynamic.Tekla.Structures.Geometry3d.AABB AABB2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(AABB1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(AABB2);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.AABB", "op_Addition", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.AABB op_Addition(Dynamic.Tekla.Structures.Geometry3d.AABB AABB, Dynamic.Tekla.Structures.Geometry3d.Point Point)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(AABB);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.AABB", "op_Addition", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.AABB op_Addition(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.AABB AABB)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(AABB);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.AABB", "op_Addition", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(result);
		}





    }

    internal static class AABB_
    {
        public static dynamic GetTSObject(AABB dynObject)
        {
            return dynObject.teklaObject;
        }

        public static AABB FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.AABB)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
