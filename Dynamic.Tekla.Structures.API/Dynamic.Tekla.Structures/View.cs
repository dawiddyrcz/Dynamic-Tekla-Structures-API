//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class View 
    {

		public System.String CurrentRepresentation
		{
			get => view.CurrentRepresentation;
			set { view.CurrentRepresentation = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(view.Identifier.GetTSObject());
			set { view.Identifier = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(view.ViewCoordinateSystem.GetTSObject());
			set { view.ViewCoordinateSystem = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(view.DisplayCoordinateSystem.GetTSObject());
			set { view.DisplayCoordinateSystem = value.GetTSObject(); }
		}

		public System.String Name
		{
			get => view.Name;
			set { view.Name = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB WorkArea
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.AABB(view.WorkArea.GetTSObject());
			set { view.WorkArea = value.GetTSObject(); }
		}

		public System.Double ViewDepthUp
		{
			get => view.ViewDepthUp;
			set { view.ViewDepthUp = value; }
		}

		public System.Double ViewDepthDown
		{
			get => view.ViewDepthDown;
			set { view.ViewDepthDown = value; }
		}

		public Dynamic.Tekla.Structures.Model.UI.ViewProjectionType ViewProjection
		{
			get => Dynamic.Tekla.Structures.Model.UI.ViewProjectionType_.FromTSObject(view.ViewProjection);
			set { view.ViewProjection = Dynamic.Tekla.Structures.Model.UI.ViewProjectionType_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.UI.DisplayOrientationType DisplayType
		{
			get => Dynamic.Tekla.Structures.Model.UI.DisplayOrientationType_.FromTSObject(view.DisplayType);
			set { view.DisplayType = Dynamic.Tekla.Structures.Model.UI.DisplayOrientationType_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.UI.ViewRenderingType ViewRendering
		{
			get => Dynamic.Tekla.Structures.Model.UI.ViewRenderingType_.FromTSObject(view.ViewRendering);
			set { view.ViewRendering = Dynamic.Tekla.Structures.Model.UI.ViewRenderingType_.FromTSObject(value); }
		}

		public System.String ViewFilter
		{
			get => view.ViewFilter;
			set { view.ViewFilter = value; }
		}

		public System.Boolean SharedView
		{
			get => view.SharedView;
			set { view.SharedView = value; }
		}

		public Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings VisibilitySettings
		{
			get => new Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings(view.VisibilitySettings.GetTSObject());
			set { view.VisibilitySettings = value.GetTSObject(); }
		}

        

        dynamic view;
        
        public View()
        {
            this.view =  new Tekla.Structures.Model.UI.View();
        }

        public View(dynamic tsObject)
        {
            this.view = tsObject;
			this.CurrentRepresentation = view.CurrentRepresentation;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(view.Identifier);
			this.ViewCoordinateSystem = new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(view.ViewCoordinateSystem);
			this.DisplayCoordinateSystem = new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(view.DisplayCoordinateSystem);
			this.Name = view.Name;
			this.WorkArea = new Dynamic.Tekla.Structures.Geometry3d.AABB(view.WorkArea);
			this.ViewDepthUp = view.ViewDepthUp;
			this.ViewDepthDown = view.ViewDepthDown;
			this.ViewProjection = Dynamic.Tekla.Structures.Model.UI.ViewProjectionType_.FromTSObject(view.ViewProjection);
			this.DisplayType = Dynamic.Tekla.Structures.Model.UI.DisplayOrientationType_.FromTSObject(view.DisplayType);
			this.ViewRendering = Dynamic.Tekla.Structures.Model.UI.ViewRenderingType_.FromTSObject(view.ViewRendering);
			this.ViewFilter = view.ViewFilter;
			this.SharedView = view.SharedView;
			this.VisibilitySettings = new Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings(view.VisibilitySettings);

        }


        public dynamic GetTSObject() => view;

		public System.Boolean Insert()
			 => view.Insert();

		public System.Boolean Modify()
			 => view.Modify();

		public System.Boolean Select()
			 => view.Select();

		public System.Boolean Delete()
			 => view.Delete();

		public System.Boolean IsPerspectiveViewProjection()
			 => view.IsPerspectiveViewProjection();

		public System.Boolean IsVisible()
			 => view.IsVisible();

		public Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection GetClipPlanes()
			 => new Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection(view.GetClipPlanes());

		public System.Boolean Equals(System.Object obj)
			 => view.Equals(obj);

		public System.Int32 GetHashCode()
			 => view.GetHashCode();

		public System.Type GetType()
			 => view.GetType();

		public System.String ToString()
			 => view.ToString();




    public enum ViewProjectionType
    {
			ORTHOGONAL_PROJECTION,
			PERSPECTIVE_PROJECTION        
    }

    public static class ViewProjectionType_
    {
        public static dynamic GetTSObject(ViewProjectionType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewProjectionType");

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

    public static class DisplayOrientationType_
    {
        public static dynamic GetTSObject(DisplayOrientationType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.DisplayOrientationType");

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

    public static class ViewRenderingType_
    {
        public static dynamic GetTSObject(ViewRenderingType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewRenderingType");

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

}
    
