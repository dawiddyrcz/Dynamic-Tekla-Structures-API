/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Line  : Dynamic.Tekla.Structures.Drawing.OpenGraphicObject
    {

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

		public System.Double Bulge
		{
			get => teklaObject.Bulge;
			set { teklaObject.Bulge = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.Line.LineAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.Line.LineAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Line.LineAttributes_.GetTSObject(value); }
		}

        

        

		internal Line() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Line(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Line(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, System.Double bulge, Dynamic.Tekla.Structures.Drawing.Line.LineAttributes attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			args[3] = bulge;
			args[4] = Dynamic.Tekla.Structures.Drawing.Line.LineAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Line", args);
		}
		public Line(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, Dynamic.Tekla.Structures.Drawing.Line.LineAttributes inAttributes)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.Line.LineAttributes_.GetTSObject(inAttributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Line", args);
		}
		public Line(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, System.Double bulge)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			args[3] = bulge;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Line", args);
		}
		public Line(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Line", args);
		}




    public  class LineAttributes  : Dynamic.Tekla.Structures.Drawing.OpenGraphicObject.OpenGraphicObjectAttributes
    {

        

        

		public LineAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Line.LineAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LineAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public LineAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Line.LineAttributes", args);
		}





    }

    internal static class LineAttributes_
    {
        public static dynamic GetTSObject(LineAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LineAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Line.LineAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LineAttributesArray_
    {
        public static dynamic GetTSObject(LineAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LineAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LineAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LineAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LineAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
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

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Line)System.Activator.CreateInstance(type, parameters);
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
    
