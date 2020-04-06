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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin", ex); }
			}
			set
			{
				try {
				teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Origin", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Direction
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Direction);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Direction", ex); }
			}
			set
			{
				try {
				teklaObject.Direction = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Direction", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public Line()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Line");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Line(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Line FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Line)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LineArray_
    {
        public static dynamic GetTSObject(Line[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Line_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Line[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Line>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Line_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
