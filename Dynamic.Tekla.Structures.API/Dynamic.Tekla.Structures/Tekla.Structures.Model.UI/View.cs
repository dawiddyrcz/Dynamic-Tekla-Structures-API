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
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CurrentRepresentation"); }
			}
			set
			{
				try {
					teklaObject.CurrentRepresentation = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CurrentRepresentation"); }
			}
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.Identifier);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Identifier"); }
			}
			set
			{
				try {
				teklaObject.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Identifier"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.ViewCoordinateSystem);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewCoordinateSystem"); }
			}
			set
			{
				try {
				teklaObject.ViewCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewCoordinateSystem"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.DisplayCoordinateSystem);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DisplayCoordinateSystem"); }
			}
			set
			{
				try {
				teklaObject.DisplayCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DisplayCoordinateSystem"); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB WorkArea
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(teklaObject.WorkArea);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WorkArea"); }
			}
			set
			{
				try {
				teklaObject.WorkArea = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WorkArea"); }
			}
		}

		public System.Double ViewDepthUp
		{
			get
			{
				try {
					return teklaObject.ViewDepthUp;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewDepthUp"); }
			}
			set
			{
				try {
					teklaObject.ViewDepthUp = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewDepthUp"); }
			}
		}

		public System.Double ViewDepthDown
		{
			get
			{
				try {
					return teklaObject.ViewDepthDown;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewDepthDown"); }
			}
			set
			{
				try {
					teklaObject.ViewDepthDown = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewDepthDown"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType ViewProjection
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType_.FromTSObject(teklaObject.ViewProjection);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewProjection"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType DisplayType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType_.FromTSObject(teklaObject.DisplayType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DisplayType"); }
			}
			set
			{
				try {
				teklaObject.DisplayType = Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DisplayType"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType ViewRendering
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType_.FromTSObject(teklaObject.ViewRendering);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewRendering"); }
			}
		}

		public System.String ViewFilter
		{
			get
			{
				try {
					return teklaObject.ViewFilter;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewFilter"); }
			}
			set
			{
				try {
					teklaObject.ViewFilter = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ViewFilter"); }
			}
		}

		public System.Boolean SharedView
		{
			get
			{
				try {
					return teklaObject.SharedView;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SharedView"); }
			}
			set
			{
				try {
					teklaObject.SharedView = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SharedView"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings VisibilitySettings
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings_.FromTSObject(teklaObject.VisibilitySettings);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("VisibilitySettings"); }
			}
			set
			{
				try {
				teklaObject.VisibilitySettings = Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("VisibilitySettings"); }
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
			try {
			var result = teklaObject.Insert();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()"); }
		}

		public System.Boolean Modify()
		{
			try {
			var result = teklaObject.Modify();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()"); }
		}

		public System.Boolean Select()
		{
			try {
			var result = teklaObject.Select();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Delete()
		{
			try {
			var result = teklaObject.Delete();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Delete()"); }
		}

		public System.Boolean IsPerspectiveViewProjection()
		{
			try {
			var result = teklaObject.IsPerspectiveViewProjection();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsPerspectiveViewProjection()"); }
		}

		public System.Boolean IsVisible()
		{
			try {
			var result = teklaObject.IsVisible();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsVisible()"); }
		}

		public Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection GetClipPlanes()
		{
			try {
			return Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection_.FromTSObject(teklaObject.GetClipPlanes());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetClipPlanes()"); }
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
    
