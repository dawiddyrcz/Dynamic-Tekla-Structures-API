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
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Location", ex); }
			}
			set
			{
				try {
				teklaObject.Location = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Location", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector DirectionVector
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.DirectionVector);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DirectionVector", ex); }
			}
			set
			{
				try {
				teklaObject.DirectionVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DirectionVector", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.UpVector);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpVector", ex); }
			}
			set
			{
				try {
				teklaObject.UpVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpVector", ex); }
			}
		}

		public System.Double FieldOfView
		{
			get
			{
				try {
					return teklaObject.FieldOfView;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FieldOfView", ex); }
			}
			set
			{
				try {
					teklaObject.FieldOfView = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FieldOfView", ex); }
			}
		}

		public System.Double ZoomFactor
		{
			get
			{
				try {
					return teklaObject.ZoomFactor;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ZoomFactor", ex); }
			}
			set
			{
				try {
					teklaObject.ZoomFactor = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ZoomFactor", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.View View
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(teklaObject.View);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("View", ex); }
			}
			set
			{
				try {
				teklaObject.View = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("View", ex); }
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

    try
    {
        	var result = (System.Boolean) teklaObject.Select();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Modify()
{

    try
    {
        	var result = (System.Boolean) teklaObject.Modify();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
    }
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
    
