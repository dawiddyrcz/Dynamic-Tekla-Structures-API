/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class View 
    {

		public System.String CurrentRepresentation
		{
			get
			{
				try {
					return teklaObject.CurrentRepresentation;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CurrentRepresentation", ex); }
			}
			set
			{
				try {
					teklaObject.CurrentRepresentation = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CurrentRepresentation", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.Identifier);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Identifier", ex); }
			}
			set
			{
				try {
				teklaObject.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Identifier", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.ViewCoordinateSystem);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewCoordinateSystem", ex); }
			}
			set
			{
				try {
				teklaObject.ViewCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewCoordinateSystem", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.DisplayCoordinateSystem);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DisplayCoordinateSystem", ex); }
			}
			set
			{
				try {
				teklaObject.DisplayCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DisplayCoordinateSystem", ex); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB WorkArea
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(teklaObject.WorkArea);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WorkArea", ex); }
			}
			set
			{
				try {
				teklaObject.WorkArea = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WorkArea", ex); }
			}
		}

		public System.Double ViewDepthUp
		{
			get
			{
				try {
					return teklaObject.ViewDepthUp;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewDepthUp", ex); }
			}
			set
			{
				try {
					teklaObject.ViewDepthUp = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewDepthUp", ex); }
			}
		}

		public System.Double ViewDepthDown
		{
			get
			{
				try {
					return teklaObject.ViewDepthDown;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewDepthDown", ex); }
			}
			set
			{
				try {
					teklaObject.ViewDepthDown = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewDepthDown", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType ViewProjection
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType_.FromTSObject(teklaObject.ViewProjection);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewProjection", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType DisplayType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType_.FromTSObject(teklaObject.DisplayType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DisplayType", ex); }
			}
			set
			{
				try {
				teklaObject.DisplayType = Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DisplayType", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType ViewRendering
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType_.FromTSObject(teklaObject.ViewRendering);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewRendering", ex); }
			}
		}

		public System.String ViewFilter
		{
			get
			{
				try {
					return teklaObject.ViewFilter;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewFilter", ex); }
			}
			set
			{
				try {
					teklaObject.ViewFilter = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewFilter", ex); }
			}
		}

		public System.Boolean SharedView
		{
			get
			{
				try {
					return teklaObject.SharedView;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SharedView", ex); }
			}
			set
			{
				try {
					teklaObject.SharedView = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SharedView", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings VisibilitySettings
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings_.FromTSObject(teklaObject.VisibilitySettings);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("VisibilitySettings", ex); }
			}
			set
			{
				try {
				teklaObject.VisibilitySettings = Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("VisibilitySettings", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public View()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.View");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public View(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean Insert()
{

    try
    {
        	var result = (System.Boolean) teklaObject.Insert();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
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



public System.Boolean Delete()
{

    try
    {
        	var result = (System.Boolean) teklaObject.Delete();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Delete), ex);
    }
}



public System.Boolean IsPerspectiveViewProjection()
{

    try
    {
        	var result = (System.Boolean) teklaObject.IsPerspectiveViewProjection();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsPerspectiveViewProjection), ex);
    }
}



public System.Boolean IsVisible()
{

    try
    {
        	var result = (System.Boolean) teklaObject.IsVisible();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsVisible), ex);
    }
}



public Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection GetClipPlanes()
{

    try
    {
        	var result = teklaObject.GetClipPlanes();

        	var _result = Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetClipPlanes), ex);
    }
}





    public enum ViewProjectionType
    {
			ORTHOGONAL_PROJECTION,
			PERSPECTIVE_PROJECTION        
    }

    internal static class ViewProjectionType_
    {
        public static dynamic GetTSObject(ViewProjectionType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.View.ViewProjectionType").GetType();

            switch (dynEnum)
            {
				case ViewProjectionType.ORTHOGONAL_PROJECTION:
					return System.Enum.Parse(tsType, "ORTHOGONAL_PROJECTION");
				case ViewProjectionType.PERSPECTIVE_PROJECTION:
					return System.Enum.Parse(tsType, "PERSPECTIVE_PROJECTION");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ViewProjectionType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ORTHOGONAL_PROJECTION", System.StringComparison.InvariantCulture))
				return ViewProjectionType.ORTHOGONAL_PROJECTION;
			else if (tsEnumValue.Equals("PERSPECTIVE_PROJECTION", System.StringComparison.InvariantCulture))
				return ViewProjectionType.PERSPECTIVE_PROJECTION;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum DisplayOrientationType
    {
			DISPLAY_VIEW_PLANE,
			DISPLAY_3D        
    }

    internal static class DisplayOrientationType_
    {
        public static dynamic GetTSObject(DisplayOrientationType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.View.DisplayOrientationType").GetType();

            switch (dynEnum)
            {
				case DisplayOrientationType.DISPLAY_VIEW_PLANE:
					return System.Enum.Parse(tsType, "DISPLAY_VIEW_PLANE");
				case DisplayOrientationType.DISPLAY_3D:
					return System.Enum.Parse(tsType, "DISPLAY_3D");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DisplayOrientationType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("DISPLAY_VIEW_PLANE", System.StringComparison.InvariantCulture))
				return DisplayOrientationType.DISPLAY_VIEW_PLANE;
			else if (tsEnumValue.Equals("DISPLAY_3D", System.StringComparison.InvariantCulture))
				return DisplayOrientationType.DISPLAY_3D;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ViewRenderingType
    {
			WIREFRAME_VIEW,
			RENDERED_VIEW        
    }

    internal static class ViewRenderingType_
    {
        public static dynamic GetTSObject(ViewRenderingType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.View.ViewRenderingType").GetType();

            switch (dynEnum)
            {
				case ViewRenderingType.WIREFRAME_VIEW:
					return System.Enum.Parse(tsType, "WIREFRAME_VIEW");
				case ViewRenderingType.RENDERED_VIEW:
					return System.Enum.Parse(tsType, "RENDERED_VIEW");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ViewRenderingType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("WIREFRAME_VIEW", System.StringComparison.InvariantCulture))
				return ViewRenderingType.WIREFRAME_VIEW;
			else if (tsEnumValue.Equals("RENDERED_VIEW", System.StringComparison.InvariantCulture))
				return ViewRenderingType.RENDERED_VIEW;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class View_
    {
        public static dynamic GetTSObject(View dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static View FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.View)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewArray_
    {
        public static dynamic GetTSObject(View[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(View_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static View[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<View>();
            foreach(var tsItem in tsArray)
            {
                list.Add(View_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
