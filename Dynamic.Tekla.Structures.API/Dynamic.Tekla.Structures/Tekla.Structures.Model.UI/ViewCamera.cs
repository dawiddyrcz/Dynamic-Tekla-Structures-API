/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ViewCamera 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Location
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Location);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Location"); }
			}
			set
			{
				try {
				teklaObject.Location = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Location"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector DirectionVector
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.DirectionVector);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DirectionVector"); }
			}
			set
			{
				try {
				teklaObject.DirectionVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DirectionVector"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpVector);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpVector"); }
			}
			set
			{
				try {
				teklaObject.UpVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpVector"); }
			}
		}

		public System.Double FieldOfView
		{
			get
			{
				try {
					return teklaObject.FieldOfView;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FieldOfView"); }
			}
			set
			{
				try {
					teklaObject.FieldOfView = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FieldOfView"); }
			}
		}

		public System.Double ZoomFactor
		{
			get
			{
				try {
					return teklaObject.ZoomFactor;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ZoomFactor"); }
			}
			set
			{
				try {
					teklaObject.ZoomFactor = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ZoomFactor"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.View View
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(teklaObject.View);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("View"); }
			}
			set
			{
				try {
				teklaObject.View = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("View"); }
			}
		}

        

        internal dynamic teklaObject;

		public ViewCamera()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewCamera");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ViewCamera(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean Select()
		{
			try {
			return teklaObject.Select();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Modify()
		{
			try {
			return teklaObject.Modify();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()"); }
		}





    }

    internal static class ViewCamera_
    {
        public static dynamic GetTSObject(ViewCamera dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewCamera FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.ViewCamera)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewCameraArray_
    {
        public static dynamic GetTSObject(ViewCamera[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewCamera_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewCamera[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewCamera>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewCamera_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
