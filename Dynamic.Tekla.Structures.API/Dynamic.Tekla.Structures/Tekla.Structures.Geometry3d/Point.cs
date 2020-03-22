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

		public Dynamic.Tekla.Structures.Geometry3d.Point op_Addition(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.op_Addition(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p2)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point op_Subtraction(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.op_Subtraction(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p2)));
		}

		public System.Boolean op_Equality(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
		{
			return teklaObject.op_Equality(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p2));
		}

		public System.Boolean op_Inequality(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
		{
			return teklaObject.op_Inequality(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p2));
		}

		public System.Boolean AreEqual(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2)
		{
			return teklaObject.AreEqual(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2));
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
            var dynObject = (Tekla.Structures.Geometry3d.Point)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
