/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Polygon  : Dynamic.Tekla.Structures.Drawing.ClosedGraphicObject
    {

		public Dynamic.Tekla.Structures.Drawing.PointList Points
		{
			get => Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(teklaObject.Points);
			set { teklaObject.Points = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value); }
		}

		public System.Collections.Generic.List<System.Double> Bulges
		{
			get => teklaObject.Bulges;
			set { teklaObject.Bulges = value; }
		}

		public System.Double Bulge
		{
			get => teklaObject.Bulge;
			set { teklaObject.Bulge = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.Polygon.PolygonAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.Polygon.PolygonAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Polygon.PolygonAttributes_.GetTSObject(value); }
		}

        

        

		public Polygon() {}
		public Polygon(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Drawing.PointList pointList, Dynamic.Tekla.Structures.Drawing.Polygon.PolygonAttributes attributes)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pointList);
			args[2] = Dynamic.Tekla.Structures.Drawing.Polygon.PolygonAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polygon", args);
		}
		public Polygon(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Drawing.PointList pointList)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pointList);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polygon", args);
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




    public  class PolygonAttributes  : Dynamic.Tekla.Structures.Drawing.ClosedGraphicObject.ClosedGraphicObjectAttributes
    {

        

        

		public PolygonAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polygon.PolygonAttributes");
		}
		public PolygonAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polygon.PolygonAttributes", args);
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

    internal static class PolygonAttributes_
    {
        public static dynamic GetTSObject(PolygonAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PolygonAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Polygon.PolygonAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class Polygon_
    {
        public static dynamic GetTSObject(Polygon dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Polygon FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Polygon)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
