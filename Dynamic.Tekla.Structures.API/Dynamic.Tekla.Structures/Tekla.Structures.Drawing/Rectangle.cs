/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Rectangle  : Dynamic.Tekla.Structures.Drawing.ClosedGraphicObject
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

		public System.Double Width
		{
			get => teklaObject.Width;
			set { teklaObject.Width = value; }
		}

		public System.Double Height
		{
			get => teklaObject.Height;
			set { teklaObject.Height = value; }
		}

		public System.Double Angle
		{
			get => teklaObject.Angle;
			set { teklaObject.Angle = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.Rectangle.RectangleAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.Rectangle.RectangleAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Rectangle.RectangleAttributes_.GetTSObject(value); }
		}

        

        

		public Rectangle() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Rectangle(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Rectangle(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, Dynamic.Tekla.Structures.Drawing.Rectangle.RectangleAttributes attributes)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			args[3] = Dynamic.Tekla.Structures.Drawing.Rectangle.RectangleAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Rectangle", args);
		}
		public Rectangle(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Rectangle", args);
		}
		public Rectangle(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, System.Double width, System.Double height, Dynamic.Tekla.Structures.Drawing.Rectangle.RectangleAttributes attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = width;
			args[3] = height;
			args[4] = Dynamic.Tekla.Structures.Drawing.Rectangle.RectangleAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Rectangle", args);
		}
		public Rectangle(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, System.Double width, System.Double height)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = width;
			args[3] = height;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Rectangle", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}




    public  class RectangleAttributes  : Dynamic.Tekla.Structures.Drawing.ClosedGraphicObject.ClosedGraphicObjectAttributes
    {

		public System.Double Bulge
		{
			get => teklaObject.Bulge;
			set { teklaObject.Bulge = value; }
		}

        

        

		public RectangleAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Rectangle.RectangleAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RectangleAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public RectangleAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Rectangle.RectangleAttributes", args);
		}

		public System.Boolean LoadAttributes(System.String AttributeFile)
		{
			return teklaObject.LoadAttributes(AttributeFile);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class RectangleAttributes_
    {
        public static dynamic GetTSObject(RectangleAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RectangleAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Rectangle.RectangleAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RectangleAttributesArray_
    {
        public static dynamic GetTSObject(RectangleAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RectangleAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RectangleAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<RectangleAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RectangleAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Rectangle_
    {
        public static dynamic GetTSObject(Rectangle dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Rectangle FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Rectangle)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RectangleArray_
    {
        public static dynamic GetTSObject(Rectangle[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Rectangle_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Rectangle[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Rectangle>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Rectangle_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
