/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ControlPolycurve  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.ControlObjectColorEnum Color
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ControlObjectColorEnum_.FromTSObject(teklaObject.Color);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
			set
			{
				try {
				teklaObject.Color = Dynamic.Tekla.Structures.Model.ControlObjectColorEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.ControlObjectLineType LineType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(teklaObject.LineType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType", ex); }
			}
			set
			{
				try {
				teklaObject.LineType = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Polycurve Geometry
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Polycurve_.FromTSObject(teklaObject.Geometry);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Geometry", ex); }
			}
			set
			{
				try {
				teklaObject.Geometry = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Geometry", ex); }
			}
		}

        

        

		public ControlPolycurve()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPolycurve");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ControlPolycurve(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ControlPolycurve(Dynamic.Tekla.Structures.Geometry3d.Polycurve geometry)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.GetTSObject(geometry);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPolycurve", args);
		}





    }

    internal static class ControlPolycurve_
    {
        public static dynamic GetTSObject(ControlPolycurve dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ControlPolycurve FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ControlPolycurve)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ControlPolycurveArray_
    {
        public static dynamic GetTSObject(ControlPolycurve[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ControlPolycurve_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ControlPolycurve[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ControlPolycurve>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ControlPolycurve_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
