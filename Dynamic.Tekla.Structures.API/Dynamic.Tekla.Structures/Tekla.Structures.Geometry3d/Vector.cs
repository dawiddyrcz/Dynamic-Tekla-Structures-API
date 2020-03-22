/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
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
		{
			return teklaObject.Normalize();
		}

		public System.Double Normalize(System.Double NewLength)
		{
			return teklaObject.Normalize(NewLength);
		}

		public System.Double GetLength()
		{
			return teklaObject.GetLength();
		}

		public System.Double GetAngleBetween(Dynamic.Tekla.Structures.Geometry3d.Vector Vector)
		{
			return teklaObject.GetAngleBetween(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector GetNormal()
		{
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.GetNormal());
		}

		public System.Double Dot(Dynamic.Tekla.Structures.Geometry3d.Vector Vector)
		{
			return teklaObject.Dot(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector));
		}

		public System.Double Dot(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2)
		{
			return teklaObject.Dot(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Cross(Dynamic.Tekla.Structures.Geometry3d.Vector Vector)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Cross(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Cross(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Cross(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2)));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Vector Vector, System.Double Multiplier)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.op_Multiply(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector), Multiplier));
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector op_Multiply(System.Double Multiplier, Dynamic.Tekla.Structures.Geometry3d.Vector Vector)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.op_Multiply(Multiplier, Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector)));
		}





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
    
