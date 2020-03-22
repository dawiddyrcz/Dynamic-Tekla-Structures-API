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
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public LineSegment()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.LineSegment");
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

		public static System.Boolean op_Equality(Dynamic.Tekla.Structures.Geometry3d.LineSegment Segment1, Dynamic.Tekla.Structures.Geometry3d.LineSegment Segment2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(Segment1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(Segment2);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.LineSegment", "op_Equality", parameters);
		}

		public static System.Boolean op_Inequality(Dynamic.Tekla.Structures.Geometry3d.LineSegment Segment1, Dynamic.Tekla.Structures.Geometry3d.LineSegment Segment2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(Segment1);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(Segment2);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Geometry3d.LineSegment", "op_Inequality", parameters);
		}





    }

    internal static class LineSegment_
    {
        public static dynamic GetTSObject(LineSegment dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LineSegment FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.LineSegment)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
