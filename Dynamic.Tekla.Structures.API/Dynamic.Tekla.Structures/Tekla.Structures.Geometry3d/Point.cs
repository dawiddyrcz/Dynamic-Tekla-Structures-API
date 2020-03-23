/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class Point 
    {

		public System.Double X
		{
			get => teklaObject.X;
			set { teklaObject.X = value; }
		}

		public System.Double Y
		{
			get => teklaObject.Y;
			set { teklaObject.Y = value; }
		}

		public System.Double Z
		{
			get => teklaObject.Z;
			set { teklaObject.Z = value; }
		}

        

        internal dynamic teklaObject;

		public Point()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Point");
		}
		public Point(System.Double X, System.Double Y, System.Double Z)
		{
			var args = new object[3];
			args[0] = X;
			args[1] = Y;
			args[2] = Z;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Point", args);
		}
		public Point(System.Double X, System.Double Y)
		{
			var args = new object[2];
			args[0] = X;
			args[1] = Y;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Point", args);
		}
		public Point(Dynamic.Tekla.Structures.Geometry3d.Point Point)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Point", args);
		}

		public void Zero()
		{
			teklaObject.Zero();
		}

		public void Translate(System.Double X, System.Double Y, System.Double Z)
		{
			teklaObject.Translate(X, Y, Z);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Point op_Addition(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p2);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Point", "op_Addition", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Point op_Subtraction(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p2);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Point", "op_Subtraction", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}

		public static System.Boolean op_Equality(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p2);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Point", "op_Equality", parameters);
			return result;
		}

		public static System.Boolean op_Inequality(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p2);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Point", "op_Inequality", parameters);
			return result;
		}

		public static System.Boolean AreEqual(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Point", "AreEqual", parameters);
			return result;
		}

		public System.Int32 CompareTo(System.Object obj)
		{
			return teklaObject.CompareTo(obj);
		}





    }

    internal static class Point_
    {
        public static dynamic GetTSObject(Point dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Point FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Point)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PointArray_
    {
        public static dynamic GetTSObject(Point[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Point_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Point[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Point>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Point_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
