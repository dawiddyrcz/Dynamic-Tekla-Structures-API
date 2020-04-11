/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class LineSegment 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Point1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point1", ex); }
			}
			set
			{
				try {
				teklaObject.Point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point1", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point2", ex); }
			}
			set
			{
				try {
				teklaObject.Point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Point2", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public LineSegment()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.LineSegment");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LineSegment(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public LineSegment(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.LineSegment", args);
		}


public System.Double Length()
{

    try
    {
        	var result = (System.Double) teklaObject.Length();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Length), ex);
    }
}



public Dynamic.Tekla.Structures.Geometry3d.Vector GetDirectionVector()
{

    try
    {
        	var result = teklaObject.GetDirectionVector();

        	var _result = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDirectionVector), ex);
    }
}



		public static System.Boolean operator ==(Dynamic.Tekla.Structures.Geometry3d.LineSegment o1, Dynamic.Tekla.Structures.Geometry3d.LineSegment o2)
		{
			if(System.Object.ReferenceEquals(o1, null)) return System.Object.ReferenceEquals(o2, null);
			var o1Tek = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(o1);
			var o2Tek = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(o2);
			return o1Tek == o2Tek;
		}
		public static System.Boolean operator !=(Dynamic.Tekla.Structures.Geometry3d.LineSegment o1, Dynamic.Tekla.Structures.Geometry3d.LineSegment o2)
		{
			return !(o1 == o2);
		}



    }

    internal static class LineSegment_
    {
        public static dynamic GetTSObject(LineSegment dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LineSegment FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.LineSegment)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LineSegmentArray_
    {
        public static dynamic GetTSObject(LineSegment[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LineSegment_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LineSegment[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LineSegment>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LineSegment_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
