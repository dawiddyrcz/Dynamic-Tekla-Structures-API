/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Arc  : Dynamic.Tekla.Structures.Drawing.OpenGraphicObject
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

		public System.Double Radius
		{
			get => teklaObject.Radius;
			set { teklaObject.Radius = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.Arc.ArcAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.Arc.ArcAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Arc.ArcAttributes_.GetTSObject(value); }
		}

        

        

		internal Arc() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Arc(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Arc(Dynamic.Tekla.Structures.Drawing.ViewBase inView, Dynamic.Tekla.Structures.Geometry3d.Point inPoint1, Dynamic.Tekla.Structures.Geometry3d.Point inPoint2, System.Double inRadius, Dynamic.Tekla.Structures.Drawing.Arc.ArcAttributes inAttributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(inView);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(inPoint1);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(inPoint2);
			args[3] = inRadius;
			args[4] = Dynamic.Tekla.Structures.Drawing.Arc.ArcAttributes_.GetTSObject(inAttributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Arc", args);
		}
		public Arc(Dynamic.Tekla.Structures.Drawing.ViewBase inView, Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint, Dynamic.Tekla.Structures.Geometry3d.Point CenterPoint, Dynamic.Tekla.Structures.Drawing.Arc.ArcAttributes inAttributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(inView);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(CenterPoint);
			args[4] = Dynamic.Tekla.Structures.Drawing.Arc.ArcAttributes_.GetTSObject(inAttributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Arc", args);
		}
		public Arc(Dynamic.Tekla.Structures.Drawing.ViewBase inView, Dynamic.Tekla.Structures.Geometry3d.Point inPoint1, Dynamic.Tekla.Structures.Geometry3d.Point inPoint2, System.Double inRadius)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(inView);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(inPoint1);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(inPoint2);
			args[3] = inRadius;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Arc", args);
		}
		public Arc(Dynamic.Tekla.Structures.Drawing.ViewBase inView, Dynamic.Tekla.Structures.Geometry3d.Point inPoint1, Dynamic.Tekla.Structures.Geometry3d.Point inPoint2, Dynamic.Tekla.Structures.Geometry3d.Point inPoint3)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(inView);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(inPoint1);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(inPoint2);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(inPoint3);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Arc", args);
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




    public  class ArcAttributes  : Dynamic.Tekla.Structures.Drawing.OpenGraphicObject.OpenGraphicObjectAttributes
    {

        

        

		public ArcAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Arc.ArcAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ArcAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ArcAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Arc.ArcAttributes", args);
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

    internal static class ArcAttributes_
    {
        public static dynamic GetTSObject(ArcAttributes dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ArcAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Arc.ArcAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ArcAttributesArray_
    {
        public static dynamic GetTSObject(ArcAttributes[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ArcAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ArcAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ArcAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ArcAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Arc_
    {
        public static dynamic GetTSObject(Arc dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Arc FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Arc)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ArcArray_
    {
        public static dynamic GetTSObject(Arc[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Arc_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Arc[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Arc>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Arc_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
