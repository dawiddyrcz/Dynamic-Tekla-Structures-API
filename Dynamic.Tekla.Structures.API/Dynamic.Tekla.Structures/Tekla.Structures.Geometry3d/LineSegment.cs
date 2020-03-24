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
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point1);
			set { teklaObject.Point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point2);
			set { teklaObject.Point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);

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
			return teklaObject.Length();
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector GetDirectionVector()
		{
			return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.GetDirectionVector());
		}





    }

    internal static class LineSegment_
    {
        public static dynamic GetTSObject(LineSegment dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static LineSegment FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LineSegment_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LineSegment[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<LineSegment>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LineSegment_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
