/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Model
{

    public  class ControlArc  : Dynamic.Tekla.Structures.Model.ModelObject
    {


        public Dynamic.Tekla.Structures.Model.ControlObjectColorEnum Color
        {
            get
            {
                try
                {
                var value = teklaObject.Color;
                var value_ = Dynamic.Tekla.Structures.Model.ControlObjectColorEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.ControlObjectColorEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Model.ControlObjectColorEnum_.GetTSObject(value);
                teklaObject.Color = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Model.ControlObjectLineType LineType
        {
            get
            {
                try
                {
                var value = teklaObject.LineType;
                var value_ = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.ControlObjectLineType) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LineType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.GetTSObject(value);
                teklaObject.LineType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LineType), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.Arc Geometry
        {
            get
            {
                try
                {
                var value = teklaObject.Geometry;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Arc_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Arc) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Geometry), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(value);
                teklaObject.Geometry = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Geometry), ex); 
                }
            }
        }
        

        

		public ControlArc()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlArc");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ControlArc(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ControlArc(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, Dynamic.Tekla.Structures.Geometry3d.Point pointOnArc)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(pointOnArc);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlArc", args);
		}





    }

    internal static class ControlArc_
    {
        public static dynamic GetTSObject(ControlArc dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ControlArc FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ControlArc)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ControlArcArray_
    {
        public static dynamic GetTSObject(ControlArc[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ControlArc_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ControlArc[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ControlArc>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ControlArc_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
