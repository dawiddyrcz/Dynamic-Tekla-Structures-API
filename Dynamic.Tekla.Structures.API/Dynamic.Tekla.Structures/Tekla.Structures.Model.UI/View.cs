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
			get => teklaObject.CurrentRepresentation;
			set { teklaObject.CurrentRepresentation = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.Identifier);
			set { teklaObject.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem
		{
			get => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.ViewCoordinateSystem);
			set { teklaObject.ViewCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem
		{
			get => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.DisplayCoordinateSystem);
			set { teklaObject.DisplayCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value); }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB WorkArea
		{
			get => Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(teklaObject.WorkArea);
			set { teklaObject.WorkArea = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value); }
		}

		public System.Double ViewDepthUp
		{
			get => teklaObject.ViewDepthUp;
			set { teklaObject.ViewDepthUp = value; }
		}

		public System.Double ViewDepthDown
		{
			get => teklaObject.ViewDepthDown;
			set { teklaObject.ViewDepthDown = value; }
		}

		public Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType ViewProjection
		{
			get => Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType_.FromTSObject(teklaObject.ViewProjection);
			set { teklaObject.ViewProjection = Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType DisplayType
		{
			get => Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType_.FromTSObject(teklaObject.DisplayType);
			set { teklaObject.DisplayType = Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType ViewRendering
		{
			get => Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType_.FromTSObject(teklaObject.ViewRendering);
			set { teklaObject.ViewRendering = Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType_.GetTSObject(value); }
		}

		public System.String ViewFilter
		{
			get => teklaObject.ViewFilter;
			set { teklaObject.ViewFilter = value; }
		}

		public System.Boolean SharedView
		{
			get => teklaObject.SharedView;
			set { teklaObject.SharedView = value; }
		}

		public Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings VisibilitySettings
		{
			get => Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings_.FromTSObject(teklaObject.VisibilitySettings);
			set { teklaObject.VisibilitySettings = Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings_.GetTSObject(value); }
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
			return teklaObject.Insert();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean IsPerspectiveViewProjection()
		{
			return teklaObject.IsPerspectiveViewProjection();
		}

		public System.Boolean IsVisible()
		{
			return teklaObject.IsVisible();
		}

		public Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection GetClipPlanes()
		{
			return Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection_.FromTSObject(teklaObject.GetClipPlanes());
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class View_
    {
        public static dynamic GetTSObject(View dynObject)
        {
            return dynObject.teklaObject;
        }

        public static View FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(View_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static View[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<View>();
            foreach(var tsItem in tsArray)
            {
                list.Add(View_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
