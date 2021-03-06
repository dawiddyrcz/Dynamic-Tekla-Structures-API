/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Polyline  : Dynamic.Tekla.Structures.Drawing.OpenGraphicObject
    {


        public Dynamic.Tekla.Structures.Drawing.PointList Points
        {
            get
            {
                try
                {
                var value = teklaObject.Points;
                var value_ = Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.PointList) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Points), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(value);
                teklaObject.Points = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Points), ex); 
                }
            }
        }

        public System.Collections.Generic.List<System.Double> Bulges
        {
            get
            {
                try
                {
                return teklaObject.Bulges;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Bulges), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Bulges = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Bulges), ex); 
                }
            }
        }

        public System.Double Bulge
        {
            get
            {
                try
                {
                return teklaObject.Bulge;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Bulge), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Bulge = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Bulge), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.Polyline.PolylineAttributes Attributes
        {
            get
            {
                try
                {
                var value = teklaObject.Attributes;
                var value_ = Dynamic.Tekla.Structures.Drawing.Polyline.PolylineAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.Polyline.PolylineAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.Polyline.PolylineAttributes_.GetTSObject(value);
                teklaObject.Attributes = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
        }
        

        

		internal Polyline() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Polyline(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Polyline(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Drawing.PointList pointList, Dynamic.Tekla.Structures.Drawing.Polyline.PolylineAttributes attributes)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pointList);
			args[2] = Dynamic.Tekla.Structures.Drawing.Polyline.PolylineAttributes_.GetTSObject(attributes);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polyline", args);
		}
		public Polyline(Dynamic.Tekla.Structures.Drawing.ViewBase view, Dynamic.Tekla.Structures.Drawing.PointList pointList)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(view);
			args[1] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pointList);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polyline", args);
		}




    public  class PolylineAttributes  : Dynamic.Tekla.Structures.Drawing.OpenGraphicObject.OpenGraphicObjectAttributes
    {

        

        

		public PolylineAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polyline.PolylineAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PolylineAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PolylineAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Polyline.PolylineAttributes", args);
		}





    }

    internal static class PolylineAttributes_
    {
        public static dynamic GetTSObject(PolylineAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PolylineAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Polyline.PolylineAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolylineAttributesArray_
    {
        public static dynamic GetTSObject(PolylineAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PolylineAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PolylineAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PolylineAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PolylineAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Polyline_
    {
        public static dynamic GetTSObject(Polyline dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Polyline FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Polyline)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolylineArray_
    {
        public static dynamic GetTSObject(Polyline[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Polyline_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Polyline[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Polyline>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Polyline_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
