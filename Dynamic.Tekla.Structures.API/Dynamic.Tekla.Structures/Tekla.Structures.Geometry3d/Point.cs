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
			get
			{
				try {
					return teklaObject.X;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("X", ex); }
			}
			set
			{
				try {
					teklaObject.X = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("X", ex); }
			}
		}

		public System.Double Y
		{
			get
			{
				try {
					return teklaObject.Y;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Y", ex); }
			}
			set
			{
				try {
					teklaObject.Y = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Y", ex); }
			}
		}

		public System.Double Z
		{
			get
			{
				try {
					return teklaObject.Z;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Z", ex); }
			}
			set
			{
				try {
					teklaObject.Z = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Z", ex); }
			}
		}

		public static System.Double EPSILON_SQUARED
		{
			get => (System.Double) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Geometry3d.Point","EPSILON_SQUARED");

		}

		public static System.Int32 HASH_SEED
		{
			get => (System.Int32) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Geometry3d.Point","HASH_SEED");

		}

        

        internal dynamic teklaObject;

		public Point()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Point");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Point(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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

    try
    {
        	teklaObject.Zero();

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Zero), ex);
    }
}



public void Translate(
	System.Double X,
	System.Double Y,
	System.Double Z
	)
{
	
	
	
    try
    {
        	teklaObject.Translate(X, Y, Z);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Translate), ex);
    }
}



public static System.Boolean AreEqual(
	Dynamic.Tekla.Structures.Geometry3d.Point Point1_,
	Dynamic.Tekla.Structures.Geometry3d.Point Point2_
	)
{
	var Point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1_);
	var Point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Point", "AreEqual", Point1, Point2);
	return result;
}



public System.Int32 CompareTo(
	System.Object obj
	)
{
	
    try
    {
        	var result = (System.Int32) teklaObject.CompareTo(obj);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CompareTo), ex);
    }
}



		public static Dynamic.Tekla.Structures.Geometry3d.Point operator +(Dynamic.Tekla.Structures.Geometry3d.Point o1, Dynamic.Tekla.Structures.Geometry3d.Point o2)
		{
			if (o1 is null) throw new System.ArgumentNullException("o1");
			if (o2 is null) throw new System.ArgumentNullException("o2");
			var o1Tek = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(o2);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(o1Tek + o2Tek);
		}
		public static Dynamic.Tekla.Structures.Geometry3d.Point operator -(Dynamic.Tekla.Structures.Geometry3d.Point o1, Dynamic.Tekla.Structures.Geometry3d.Point o2)
		{
			if (o1 is null) throw new System.ArgumentNullException("o1");
			if (o2 is null) throw new System.ArgumentNullException("o2");
			var o1Tek = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(o2);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(o1Tek - o2Tek);
		}
		public static System.Boolean operator ==(Dynamic.Tekla.Structures.Geometry3d.Point o1, Dynamic.Tekla.Structures.Geometry3d.Point o2)
		{
			if(System.Object.ReferenceEquals(o1, null)) return System.Object.ReferenceEquals(o2, null);
			var o1Tek = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(o2);
			return o1Tek == o2Tek;
		}
		public static System.Boolean operator !=(Dynamic.Tekla.Structures.Geometry3d.Point o1, Dynamic.Tekla.Structures.Geometry3d.Point o2)
		{
			return !(o1 == o2);
		}



    }

    internal static class Point_
    {
        public static dynamic GetTSObject(Point dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Point FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Point)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PointArray_
    {
        public static dynamic GetTSObject(Point[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Point_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Point[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Point>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Point_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
