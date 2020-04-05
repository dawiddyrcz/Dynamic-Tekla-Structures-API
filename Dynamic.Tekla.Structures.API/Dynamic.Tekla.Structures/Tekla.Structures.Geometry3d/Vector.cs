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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Vector(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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

		public static System.Double Dot(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2);
			var result = (System.Double) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Vector", "Dot", parameters);
			return result;
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Cross(Dynamic.Tekla.Structures.Geometry3d.Vector Vector)
		{
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Cross(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector)));
		}

		public static Dynamic.Tekla.Structures.Geometry3d.Vector Cross(Dynamic.Tekla.Structures.Geometry3d.Vector Vector1, Dynamic.Tekla.Structures.Geometry3d.Vector Vector2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Vector2);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.Vector", "Cross", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(result);
		}


		public static Dynamic.Tekla.Structures.Geometry3d.Vector operator *(Dynamic.Tekla.Structures.Geometry3d.Vector o1, System.Double o2)
		{
			if (o1 is null) throw new System.ArgumentNullException("o1");
			var o1Tek = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(o1);
			var o2Tek = o2;
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(o1Tek * o2Tek);
		}
		public static Dynamic.Tekla.Structures.Geometry3d.Vector operator *(System.Double o1, Dynamic.Tekla.Structures.Geometry3d.Vector o2)
		{
			if (o2 is null) throw new System.ArgumentNullException("o2");
			var o1Tek = o1;
			var o2Tek = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(o2);
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(o1Tek * o2Tek);
		}



    }

    internal static class Vector_
    {
        public static dynamic GetTSObject(Vector dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Vector FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Vector)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class VectorArray_
    {
        public static dynamic GetTSObject(Vector[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Vector_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Vector[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Vector>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Vector_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
