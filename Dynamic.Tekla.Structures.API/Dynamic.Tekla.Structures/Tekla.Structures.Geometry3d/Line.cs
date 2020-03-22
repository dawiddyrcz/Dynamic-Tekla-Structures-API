/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class Line 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
			set { teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Direction
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Direction);
			set { teklaObject.Direction = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public Line()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Line");
		}
		public Line(Dynamic.Tekla.Structures.Geometry3d.Point p1, Dynamic.Tekla.Structures.Geometry3d.Point p2)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(p2);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Line", args);
		}
		public Line(Dynamic.Tekla.Structures.Geometry3d.Point Point, Dynamic.Tekla.Structures.Geometry3d.Vector Direction)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Direction);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Line", args);
		}
		public Line(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Line", args);
		}





    }

    internal static class Line_
    {
        public static dynamic GetTSObject(Line dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Line FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.Line)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
