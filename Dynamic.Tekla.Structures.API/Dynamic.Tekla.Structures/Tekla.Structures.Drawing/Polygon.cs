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
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(teklaObject.Points);
			}
			set
			{
				teklaObject.Points = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value);
			}
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
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.Polygon.PolygonAttributes_.FromTSObject(teklaObject.Attributes);
			}
			set
			{
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Polygon.PolygonAttributes_.GetTSObject(value);
			}
		}

        

        

		internal Polygon() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Polygon(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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




    public  class PolygonAttributes  : Dynamic.Tekla.Structures.Drawing.ClosedGraphicObject.ClosedGraphicObjectAttributes
    {

        

        

		public PolygonAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polygon.PolygonAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PolygonAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PolygonAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polygon.PolygonAttributes", args);
		}





    }

    internal static class PolygonAttributes_
    {
        public static dynamic GetTSObject(PolygonAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PolygonAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Polygon.PolygonAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolygonAttributesArray_
    {
        public static dynamic GetTSObject(PolygonAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolygonAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolygonAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PolygonAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolygonAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Polygon_
    {
        public static dynamic GetTSObject(Polygon dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Polygon FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Polygon)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolygonArray_
    {
        public static dynamic GetTSObject(Polygon[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Polygon_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Polygon[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Polygon>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Polygon_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
