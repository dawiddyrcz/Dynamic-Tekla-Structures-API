//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class Vector  : Dynamic.Tekla.Structures.Geometry3d.Point
    {

        

        

		public Vector()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Vector");
		}
		public Vector(System.Double X, System.Double Y, System.Double Z)
		{
			var args = new object[3];
			args[0] = X;
			args[1] = Y;
			args[2] = Z;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Vector", args);
		}
		public Vector(Dynamic.Tekla.Structures.Geometry3d.Point Point)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Vector", args);
		}

		public System.Double Normalize()
			 => teklaObject.Normalize();

		public System.Double Normalize(System.Double NewLength)
			 => teklaObject.Normalize(NewLength);

		public System.Double GetLength()
			 => teklaObject.GetLength();

		public System.Double GetAngleBetween(Dynamic.Tekla.Structures.Geometry3d.Vector Vector)
			 => teklaObject.GetAngleBetween(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector));

		public Dynamic.Tekla.Structures.Geometry3d.Vector GetNormal()
			 => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.GetNormal());

		public System.Double Dot(Dynamic.Tekla.Structures.Geometry3d.Vector Vector)
			 => teklaObject.Dot(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector));

		public System.Double Dot(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2)
			 => teklaObject.Dot(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2));

		public Dynamic.Tekla.Structures.Geometry3d.Vector Cross(Dynamic.Tekla.Structures.Geometry3d.Vector Vector)
			 => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Cross(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector)));

		public Dynamic.Tekla.Structures.Geometry3d.Vector Cross(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2)
			 => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Cross(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2)));

		public Dynamic.Tekla.Structures.Geometry3d.Vector op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Vector Vector, System.Double Multiplier)
			 => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector), Multiplier));

		public Dynamic.Tekla.Structures.Geometry3d.Vector op_Multiply(System.Double Multiplier, Dynamic.Tekla.Structures.Geometry3d.Vector Vector)
			 => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.op_Multiply(Multiplier, Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector)));

		public void Zero()
			 => teklaObject.Zero();

		public void Translate(System.Double X, System.Double Y, System.Double Z)
			 => teklaObject.Translate(X, Y, Z);

		public System.Int32 CompareTo(System.Object obj)
			 => teklaObject.CompareTo(obj);





    }

    internal static class Vector_
    {
        public static dynamic GetTSObject(Vector dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Vector FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.Vector)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
