/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class View  : Dynamic.Tekla.Structures.Drawing.ViewBase
    {

		public Dynamic.Tekla.Structures.Drawing.View.ViewAttributes Attributes
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.FromTSObject(teklaObject.Attributes);
			}
			set
			{
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB RestrictionBox
		{
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(teklaObject.RestrictionBox);
			}
			set
			{
				teklaObject.RestrictionBox = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value);
			}
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem
		{
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.ViewCoordinateSystem);
			}
			set
			{
				teklaObject.ViewCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem
		{
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.DisplayCoordinateSystem);
			}
			set
			{
				teklaObject.DisplayCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.View.ViewTypes ViewType
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewTypes_.FromTSObject(teklaObject.ViewType);
			}
			set
			{
				teklaObject.ViewType = Dynamic.Tekla.Structures.Drawing.View.ViewTypes_.GetTSObject(value);
			}
		}

        

        

		internal View() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public View(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public View(Dynamic.Tekla.Structures.Drawing.ContainerView View, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.AABB RestrictionBox)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ContainerView_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(ViewCoordinateSystem);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(DisplayCoordinateSystem);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(RestrictionBox);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View", args);
		}
		public View(Dynamic.Tekla.Structures.Drawing.ContainerView View, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem, System.Collections.ArrayList PartList)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Drawing.ContainerView_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(ViewCoordinateSystem);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(DisplayCoordinateSystem);
			args[3] = PartList;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View", args);
		}
		public View(Dynamic.Tekla.Structures.Drawing.ContainerView View, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.AABB RestrictionBox, System.String Attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ContainerView_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(ViewCoordinateSystem);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(DisplayCoordinateSystem);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(RestrictionBox);
			args[4] = Attributes;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View", args);
		}
		public View(Dynamic.Tekla.Structures.Drawing.ContainerView View, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem, System.Collections.ArrayList PartList, System.String Attributes)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ContainerView_.GetTSObject(View);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(ViewCoordinateSystem);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(DisplayCoordinateSystem);
			args[3] = PartList;
			args[4] = Attributes;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View", args);
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetModelObjects()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetModelObjects());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetModelObjects()"); }
		}

		public static System.Boolean CreateSectionView(Dynamic.Tekla.Structures.Drawing.View view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, Dynamic.Tekla.Structures.Geometry3d.Point viewInsertionPoint, System.Double depthUp, System.Double depthDown, Dynamic.Tekla.Structures.Drawing.View.ViewAttributes viewAttributes, Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes sectionMarkAttributes, out Dynamic.Tekla.Structures.Drawing.View sectionView, out Dynamic.Tekla.Structures.Drawing.SectionMark sectionMark)
		{
			var parameters = new object[10];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			parameters[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			parameters[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(viewInsertionPoint);
			parameters[4] = depthUp;
			parameters[5] = depthDown;
			parameters[6] = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(viewAttributes);
			parameters[7] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes_.GetTSObject(sectionMarkAttributes);
			sectionView = new Dynamic.Tekla.Structures.Drawing.View();
			parameters[8] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(sectionView);
			sectionMark = new Dynamic.Tekla.Structures.Drawing.SectionMark();
			parameters[9] = Dynamic.Tekla.Structures.Drawing.SectionMark_.GetTSObject(sectionMark);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.View", "CreateSectionView", parameters);
			sectionView = Dynamic.Tekla.Structures.Drawing.View_.FromTSObject(parameters[8]);
			sectionMark = Dynamic.Tekla.Structures.Drawing.SectionMark_.FromTSObject(parameters[9]);
			return result;
		}

		public static System.Boolean CreateCurvedSectionView(Dynamic.Tekla.Structures.Drawing.View view, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point middlePoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, Dynamic.Tekla.Structures.Geometry3d.Point viewInsertionPoint, System.Double depthUp, System.Double depthDown, Dynamic.Tekla.Structures.Drawing.View.ViewAttributes viewAttributes, Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes sectionMarkAttributes, out Dynamic.Tekla.Structures.Drawing.View curvedSectionView, out Dynamic.Tekla.Structures.Drawing.CurvedSectionMark sectionMark)
		{
			var parameters = new object[11];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			parameters[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(middlePoint);
			parameters[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			parameters[4] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(viewInsertionPoint);
			parameters[5] = depthUp;
			parameters[6] = depthDown;
			parameters[7] = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(viewAttributes);
			parameters[8] = Dynamic.Tekla.Structures.Drawing.SectionMarkBase.SectionMarkAttributes_.GetTSObject(sectionMarkAttributes);
			curvedSectionView = new Dynamic.Tekla.Structures.Drawing.View();
			parameters[9] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(curvedSectionView);
			sectionMark = new Dynamic.Tekla.Structures.Drawing.CurvedSectionMark();
			parameters[10] = Dynamic.Tekla.Structures.Drawing.CurvedSectionMark_.GetTSObject(sectionMark);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.View", "CreateCurvedSectionView", parameters);
			curvedSectionView = Dynamic.Tekla.Structures.Drawing.View_.FromTSObject(parameters[9]);
			sectionMark = Dynamic.Tekla.Structures.Drawing.CurvedSectionMark_.FromTSObject(parameters[10]);
			return result;
		}

		public static System.Boolean CreateDetailView(Dynamic.Tekla.Structures.Drawing.View view, Dynamic.Tekla.Structures.Geometry3d.Point centerPoint, Dynamic.Tekla.Structures.Geometry3d.Point boundaryPoint, Dynamic.Tekla.Structures.Geometry3d.Point labelPoint, Dynamic.Tekla.Structures.Geometry3d.Point viewInsertionPoint, Dynamic.Tekla.Structures.Drawing.View.ViewAttributes viewAttributes, Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes detailMarkAttributes, out Dynamic.Tekla.Structures.Drawing.View detailView, out Dynamic.Tekla.Structures.Drawing.DetailMark detailMark)
		{
			var parameters = new object[9];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(centerPoint);
			parameters[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(boundaryPoint);
			parameters[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(labelPoint);
			parameters[4] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(viewInsertionPoint);
			parameters[5] = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(viewAttributes);
			parameters[6] = Dynamic.Tekla.Structures.Drawing.DetailMark.DetailMarkAttributes_.GetTSObject(detailMarkAttributes);
			detailView = new Dynamic.Tekla.Structures.Drawing.View();
			parameters[7] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(detailView);
			detailMark = new Dynamic.Tekla.Structures.Drawing.DetailMark();
			parameters[8] = Dynamic.Tekla.Structures.Drawing.DetailMark_.GetTSObject(detailMark);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.View", "CreateDetailView", parameters);
			detailView = Dynamic.Tekla.Structures.Drawing.View_.FromTSObject(parameters[7]);
			detailMark = Dynamic.Tekla.Structures.Drawing.DetailMark_.FromTSObject(parameters[8]);
			return result;
		}

		public static System.Boolean CreateFrontView(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Geometry3d.Point viewInsertionPoint, Dynamic.Tekla.Structures.Drawing.View.ViewAttributes viewAttributes, out Dynamic.Tekla.Structures.Drawing.View view)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(viewInsertionPoint);
			parameters[2] = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(viewAttributes);
			view = new Dynamic.Tekla.Structures.Drawing.View();
			parameters[3] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.View", "CreateFrontView", parameters);
			view = Dynamic.Tekla.Structures.Drawing.View_.FromTSObject(parameters[3]);
			return result;
		}

		public static System.Boolean CreateTopView(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Geometry3d.Point viewInsertionPoint, Dynamic.Tekla.Structures.Drawing.View.ViewAttributes viewAttributes, out Dynamic.Tekla.Structures.Drawing.View view)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(viewInsertionPoint);
			parameters[2] = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(viewAttributes);
			view = new Dynamic.Tekla.Structures.Drawing.View();
			parameters[3] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.View", "CreateTopView", parameters);
			view = Dynamic.Tekla.Structures.Drawing.View_.FromTSObject(parameters[3]);
			return result;
		}

		public static System.Boolean CreateBackView(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Geometry3d.Point viewInsertionPoint, Dynamic.Tekla.Structures.Drawing.View.ViewAttributes viewAttributes, out Dynamic.Tekla.Structures.Drawing.View view)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(viewInsertionPoint);
			parameters[2] = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(viewAttributes);
			view = new Dynamic.Tekla.Structures.Drawing.View();
			parameters[3] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.View", "CreateBackView", parameters);
			view = Dynamic.Tekla.Structures.Drawing.View_.FromTSObject(parameters[3]);
			return result;
		}

		public static System.Boolean CreateBottomView(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Geometry3d.Point viewInsertionPoint, Dynamic.Tekla.Structures.Drawing.View.ViewAttributes viewAttributes, out Dynamic.Tekla.Structures.Drawing.View view)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(viewInsertionPoint);
			parameters[2] = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(viewAttributes);
			view = new Dynamic.Tekla.Structures.Drawing.View();
			parameters[3] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.View", "CreateBottomView", parameters);
			view = Dynamic.Tekla.Structures.Drawing.View_.FromTSObject(parameters[3]);
			return result;
		}

		public static System.Boolean Create3dView(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Geometry3d.Point viewInsertionPoint, Dynamic.Tekla.Structures.Drawing.View.ViewAttributes viewAttributes, out Dynamic.Tekla.Structures.Drawing.View view)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(viewInsertionPoint);
			parameters[2] = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(viewAttributes);
			view = new Dynamic.Tekla.Structures.Drawing.View();
			parameters[3] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.View", "Create3dView", parameters);
			view = Dynamic.Tekla.Structures.Drawing.View_.FromTSObject(parameters[3]);
			return result;
		}

		public static System.Boolean Create3dView(Dynamic.Tekla.Structures.Drawing.Drawing drawing, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem viewPlane, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem displayPlane, Dynamic.Tekla.Structures.Geometry3d.AABB viewExtrema, Dynamic.Tekla.Structures.Geometry3d.Point viewInsertionPoint, Dynamic.Tekla.Structures.Drawing.View.ViewAttributes viewAttributes, out Dynamic.Tekla.Structures.Drawing.View view)
		{
			var parameters = new object[7];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.Drawing_.GetTSObject(drawing);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(viewPlane);
			parameters[2] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(displayPlane);
			parameters[3] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(viewExtrema);
			parameters[4] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(viewInsertionPoint);
			parameters[5] = Dynamic.Tekla.Structures.Drawing.View.ViewAttributes_.GetTSObject(viewAttributes);
			view = new Dynamic.Tekla.Structures.Drawing.View();
			parameters[6] = Dynamic.Tekla.Structures.Drawing.View_.GetTSObject(view);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.View", "Create3dView", parameters);
			view = Dynamic.Tekla.Structures.Drawing.View_.FromTSObject(parameters[6]);
			return result;
		}

		public System.Boolean RotateViewOnAxisX(System.Double rotationAngle)
		{
			try {
			return teklaObject.RotateViewOnAxisX(rotationAngle);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RotateViewOnAxisX()"); }
		}

		public System.Boolean RotateViewOnAxisY(System.Double rotationAngle)
		{
			try {
			return teklaObject.RotateViewOnAxisY(rotationAngle);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RotateViewOnAxisY()"); }
		}

		public System.Boolean RotateViewOnAxisZ(System.Double rotationAngle)
		{
			try {
			return teklaObject.RotateViewOnAxisZ(rotationAngle);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RotateViewOnAxisZ()"); }
		}

		public System.Boolean RotateViewOnDrawingPlane(System.Double rotationAngle)
		{
			try {
			return teklaObject.RotateViewOnDrawingPlane(rotationAngle);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RotateViewOnDrawingPlane()"); }
		}




    public enum ViewTypes
    {
			UnknownViewType,
			FrontView,
			TopView,
			BackView,
			BottomView,
			EndView,
			SectionView,
			ModelView,
			DetailView,
			_3DView        
    }

    internal static class ViewTypes_
    {
        public static dynamic GetTSObject(ViewTypes dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewTypes").GetType();

            switch (dynEnum)
            {
				case ViewTypes.UnknownViewType:
					return System.Enum.Parse(tsType, "UnknownViewType");
				case ViewTypes.FrontView:
					return System.Enum.Parse(tsType, "FrontView");
				case ViewTypes.TopView:
					return System.Enum.Parse(tsType, "TopView");
				case ViewTypes.BackView:
					return System.Enum.Parse(tsType, "BackView");
				case ViewTypes.BottomView:
					return System.Enum.Parse(tsType, "BottomView");
				case ViewTypes.EndView:
					return System.Enum.Parse(tsType, "EndView");
				case ViewTypes.SectionView:
					return System.Enum.Parse(tsType, "SectionView");
				case ViewTypes.ModelView:
					return System.Enum.Parse(tsType, "ModelView");
				case ViewTypes.DetailView:
					return System.Enum.Parse(tsType, "DetailView");
				case ViewTypes._3DView:
					return System.Enum.Parse(tsType, "_3DView");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ViewTypes FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UnknownViewType", System.StringComparison.InvariantCulture))
				return ViewTypes.UnknownViewType;
			else if (tsEnumValue.Equals("FrontView", System.StringComparison.InvariantCulture))
				return ViewTypes.FrontView;
			else if (tsEnumValue.Equals("TopView", System.StringComparison.InvariantCulture))
				return ViewTypes.TopView;
			else if (tsEnumValue.Equals("BackView", System.StringComparison.InvariantCulture))
				return ViewTypes.BackView;
			else if (tsEnumValue.Equals("BottomView", System.StringComparison.InvariantCulture))
				return ViewTypes.BottomView;
			else if (tsEnumValue.Equals("EndView", System.StringComparison.InvariantCulture))
				return ViewTypes.EndView;
			else if (tsEnumValue.Equals("SectionView", System.StringComparison.InvariantCulture))
				return ViewTypes.SectionView;
			else if (tsEnumValue.Equals("ModelView", System.StringComparison.InvariantCulture))
				return ViewTypes.ModelView;
			else if (tsEnumValue.Equals("DetailView", System.StringComparison.InvariantCulture))
				return ViewTypes.DetailView;
			else if (tsEnumValue.Equals("_3DView", System.StringComparison.InvariantCulture))
				return ViewTypes._3DView;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ViewCommands
    {
			DOT_GR_INVALID_VIEW_COMMAND,
			DOT_GR_CREATE_DETAIL_VIEW_COMMAND,
			DOT_GR_CREATE_SECTION_VIEW_COMMAND,
			DOT_GR_CREATE_CURVED_SECTION_VIEW_COMMAND,
			DOT_GR_CREATE_FRONT_VIEW_COMMAND,
			DOT_GR_CREATE_TOP_VIEW_COMMAND,
			DOT_GR_CREATE_BACK_VIEW_COMMAND,
			DOT_GR_CREATE_BOTTOM_VIEW_COMMAND,
			DOT_GR_CREATE_3D_VIEW_COMMAND,
			DOT_GR_CREATE_3D_VIEW_WITH_PLANES_COMMAND,
			DOT_GR_ROTATE_VIEW,
			DOT_GR_ADD_OBJECTS_TO_VIEW        
    }

    internal static class ViewCommands_
    {
        public static dynamic GetTSObject(ViewCommands dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewCommands").GetType();

            switch (dynEnum)
            {
				case ViewCommands.DOT_GR_INVALID_VIEW_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_INVALID_VIEW_COMMAND");
				case ViewCommands.DOT_GR_CREATE_DETAIL_VIEW_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_CREATE_DETAIL_VIEW_COMMAND");
				case ViewCommands.DOT_GR_CREATE_SECTION_VIEW_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_CREATE_SECTION_VIEW_COMMAND");
				case ViewCommands.DOT_GR_CREATE_CURVED_SECTION_VIEW_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_CREATE_CURVED_SECTION_VIEW_COMMAND");
				case ViewCommands.DOT_GR_CREATE_FRONT_VIEW_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_CREATE_FRONT_VIEW_COMMAND");
				case ViewCommands.DOT_GR_CREATE_TOP_VIEW_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_CREATE_TOP_VIEW_COMMAND");
				case ViewCommands.DOT_GR_CREATE_BACK_VIEW_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_CREATE_BACK_VIEW_COMMAND");
				case ViewCommands.DOT_GR_CREATE_BOTTOM_VIEW_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_CREATE_BOTTOM_VIEW_COMMAND");
				case ViewCommands.DOT_GR_CREATE_3D_VIEW_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_CREATE_3D_VIEW_COMMAND");
				case ViewCommands.DOT_GR_CREATE_3D_VIEW_WITH_PLANES_COMMAND:
					return System.Enum.Parse(tsType, "DOT_GR_CREATE_3D_VIEW_WITH_PLANES_COMMAND");
				case ViewCommands.DOT_GR_ROTATE_VIEW:
					return System.Enum.Parse(tsType, "DOT_GR_ROTATE_VIEW");
				case ViewCommands.DOT_GR_ADD_OBJECTS_TO_VIEW:
					return System.Enum.Parse(tsType, "DOT_GR_ADD_OBJECTS_TO_VIEW");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ViewCommands FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("DOT_GR_INVALID_VIEW_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_INVALID_VIEW_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_CREATE_DETAIL_VIEW_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_CREATE_DETAIL_VIEW_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_CREATE_SECTION_VIEW_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_CREATE_SECTION_VIEW_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_CREATE_CURVED_SECTION_VIEW_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_CREATE_CURVED_SECTION_VIEW_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_CREATE_FRONT_VIEW_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_CREATE_FRONT_VIEW_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_CREATE_TOP_VIEW_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_CREATE_TOP_VIEW_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_CREATE_BACK_VIEW_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_CREATE_BACK_VIEW_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_CREATE_BOTTOM_VIEW_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_CREATE_BOTTOM_VIEW_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_CREATE_3D_VIEW_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_CREATE_3D_VIEW_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_CREATE_3D_VIEW_WITH_PLANES_COMMAND", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_CREATE_3D_VIEW_WITH_PLANES_COMMAND;
			else if (tsEnumValue.Equals("DOT_GR_ROTATE_VIEW", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_ROTATE_VIEW;
			else if (tsEnumValue.Equals("DOT_GR_ADD_OBJECTS_TO_VIEW", System.StringComparison.InvariantCulture))
				return ViewCommands.DOT_GR_ADD_OBJECTS_TO_VIEW;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum VerticalLabelPosition
    {
			Top,
			Bottom        
    }

    internal static class VerticalLabelPosition_
    {
        public static dynamic GetTSObject(VerticalLabelPosition dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.VerticalLabelPosition").GetType();

            switch (dynEnum)
            {
				case VerticalLabelPosition.Top:
					return System.Enum.Parse(tsType, "Top");
				case VerticalLabelPosition.Bottom:
					return System.Enum.Parse(tsType, "Bottom");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static VerticalLabelPosition FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Top", System.StringComparison.InvariantCulture))
				return VerticalLabelPosition.Top;
			else if (tsEnumValue.Equals("Bottom", System.StringComparison.InvariantCulture))
				return VerticalLabelPosition.Bottom;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum HorizontalLabelPosition
    {
			CenteredByViewFrame,
			CenteredByViewRestrictionBox,
			LeftAlignedByViewFrame,
			RightAlignedByViewFrame,
			LeftAlignByViewRestrictionBox,
			RightAlignByViewRestrictionBox        
    }

    internal static class HorizontalLabelPosition_
    {
        public static dynamic GetTSObject(HorizontalLabelPosition dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.HorizontalLabelPosition").GetType();

            switch (dynEnum)
            {
				case HorizontalLabelPosition.CenteredByViewFrame:
					return System.Enum.Parse(tsType, "CenteredByViewFrame");
				case HorizontalLabelPosition.CenteredByViewRestrictionBox:
					return System.Enum.Parse(tsType, "CenteredByViewRestrictionBox");
				case HorizontalLabelPosition.LeftAlignedByViewFrame:
					return System.Enum.Parse(tsType, "LeftAlignedByViewFrame");
				case HorizontalLabelPosition.RightAlignedByViewFrame:
					return System.Enum.Parse(tsType, "RightAlignedByViewFrame");
				case HorizontalLabelPosition.LeftAlignByViewRestrictionBox:
					return System.Enum.Parse(tsType, "LeftAlignByViewRestrictionBox");
				case HorizontalLabelPosition.RightAlignByViewRestrictionBox:
					return System.Enum.Parse(tsType, "RightAlignByViewRestrictionBox");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static HorizontalLabelPosition FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CenteredByViewFrame", System.StringComparison.InvariantCulture))
				return HorizontalLabelPosition.CenteredByViewFrame;
			else if (tsEnumValue.Equals("CenteredByViewRestrictionBox", System.StringComparison.InvariantCulture))
				return HorizontalLabelPosition.CenteredByViewRestrictionBox;
			else if (tsEnumValue.Equals("LeftAlignedByViewFrame", System.StringComparison.InvariantCulture))
				return HorizontalLabelPosition.LeftAlignedByViewFrame;
			else if (tsEnumValue.Equals("RightAlignedByViewFrame", System.StringComparison.InvariantCulture))
				return HorizontalLabelPosition.RightAlignedByViewFrame;
			else if (tsEnumValue.Equals("LeftAlignByViewRestrictionBox", System.StringComparison.InvariantCulture))
				return HorizontalLabelPosition.LeftAlignByViewRestrictionBox;
			else if (tsEnumValue.Equals("RightAlignByViewRestrictionBox", System.StringComparison.InvariantCulture))
				return HorizontalLabelPosition.RightAlignByViewRestrictionBox;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum LabelLineLengthType
    {
			Minimal,
			Custom        
    }

    internal static class LabelLineLengthType_
    {
        public static dynamic GetTSObject(LabelLineLengthType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.LabelLineLengthType").GetType();

            switch (dynEnum)
            {
				case LabelLineLengthType.Minimal:
					return System.Enum.Parse(tsType, "Minimal");
				case LabelLineLengthType.Custom:
					return System.Enum.Parse(tsType, "Custom");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LabelLineLengthType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Minimal", System.StringComparison.InvariantCulture))
				return LabelLineLengthType.Minimal;
			else if (tsEnumValue.Equals("Custom", System.StringComparison.InvariantCulture))
				return LabelLineLengthType.Custom;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ShorteningCutPartType
    {
			BothDirections,
			X_Direction,
			Y_Direction        
    }

    internal static class ShorteningCutPartType_
    {
        public static dynamic GetTSObject(ShorteningCutPartType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ShorteningCutPartType").GetType();

            switch (dynEnum)
            {
				case ShorteningCutPartType.BothDirections:
					return System.Enum.Parse(tsType, "BothDirections");
				case ShorteningCutPartType.X_Direction:
					return System.Enum.Parse(tsType, "X_Direction");
				case ShorteningCutPartType.Y_Direction:
					return System.Enum.Parse(tsType, "Y_Direction");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ShorteningCutPartType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BothDirections", System.StringComparison.InvariantCulture))
				return ShorteningCutPartType.BothDirections;
			else if (tsEnumValue.Equals("X_Direction", System.StringComparison.InvariantCulture))
				return ShorteningCutPartType.X_Direction;
			else if (tsEnumValue.Equals("Y_Direction", System.StringComparison.InvariantCulture))
				return ShorteningCutPartType.Y_Direction;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class ViewAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public System.Double PartialProfileLength
		{
			get => teklaObject.PartialProfileLength;
			set { teklaObject.PartialProfileLength = value; }
		}

		public System.Double PartialProfileOffset
		{
			get => teklaObject.PartialProfileOffset;
			set { teklaObject.PartialProfileOffset = value; }
		}

		public System.Boolean ReflectedView
		{
			get => teklaObject.ReflectedView;
			set { teklaObject.ReflectedView = value; }
		}

		public System.Boolean UnfoldedView
		{
			get => teklaObject.UnfoldedView;
			set { teklaObject.UnfoldedView = value; }
		}

		public System.Boolean UndeformedView
		{
			get => teklaObject.UndeformedView;
			set { teklaObject.UndeformedView = value; }
		}

		public System.Double ViewExtensionForNeighbourParts
		{
			get => teklaObject.ViewExtensionForNeighbourParts;
			set { teklaObject.ViewExtensionForNeighbourParts = value; }
		}

		public System.Boolean FixedViewPlacing
		{
			get => teklaObject.FixedViewPlacing;
			set { teklaObject.FixedViewPlacing = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.View.ViewShorteningAttributes Shortening
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewShorteningAttributes_.FromTSObject(teklaObject.Shortening);
			}
			set
			{
				teklaObject.Shortening = Dynamic.Tekla.Structures.Drawing.View.ViewShorteningAttributes_.GetTSObject(value);
			}
		}

		public System.Boolean ShowPartOpeningsOrRecessSymbol
		{
			get => teklaObject.ShowPartOpeningsOrRecessSymbol;
			set { teklaObject.ShowPartOpeningsOrRecessSymbol = value; }
		}

		public System.Double Scale
		{
			get => teklaObject.Scale;
			set { teklaObject.Scale = value; }
		}

		public System.Boolean ViewPlaneDatumPointForElevations
		{
			get => teklaObject.ViewPlaneDatumPointForElevations;
			set { teklaObject.ViewPlaneDatumPointForElevations = value; }
		}

		public System.String LocationBy
		{
			get => teklaObject.LocationBy;
			set { teklaObject.LocationBy = value; }
		}

		public System.Double DatumLevel
		{
			get => teklaObject.DatumLevel;
			set { teklaObject.DatumLevel = value; }
		}

		public System.Boolean PourView
		{
			get => teklaObject.PourView;
			set { teklaObject.PourView = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors MarkSymbolColor
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.MarkSymbolColor);
			}
			set
			{
				teklaObject.MarkSymbolColor = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.View.ViewMarkSymbolAttributes MarkSymbolAttributes
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewMarkSymbolAttributes_.FromTSObject(teklaObject.MarkSymbolAttributes);
			}
			set
			{
				teklaObject.MarkSymbolAttributes = Dynamic.Tekla.Structures.Drawing.View.ViewMarkSymbolAttributes_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.View.VerticalLabelPosition LabelPositionVertical
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.VerticalLabelPosition_.FromTSObject(teklaObject.LabelPositionVertical);
			}
			set
			{
				teklaObject.LabelPositionVertical = Dynamic.Tekla.Structures.Drawing.View.VerticalLabelPosition_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.View.HorizontalLabelPosition LabelPositionHorizontal
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.HorizontalLabelPosition_.FromTSObject(teklaObject.LabelPositionHorizontal);
			}
			set
			{
				teklaObject.LabelPositionHorizontal = Dynamic.Tekla.Structures.Drawing.View.HorizontalLabelPosition_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagsAttributes TagsAttributes
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagsAttributes_.FromTSObject(teklaObject.TagsAttributes);
			}
			set
			{
				teklaObject.TagsAttributes = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagsAttributes_.GetTSObject(value);
			}
		}

		public static System.String LocationByModelOrigin
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.View.ViewAttributes","LocationByModelOrigin");

		}

		public static System.String LocationByProjectBasePoint
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.View.ViewAttributes","LocationByProjectBasePoint");

		}

        

        

		public ViewAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ViewAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ViewAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewAttributes", args);
		}





    }

    internal static class ViewAttributes_
    {
        public static dynamic GetTSObject(ViewAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.View.ViewAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewAttributesArray_
    {
        public static dynamic GetTSObject(ViewAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ViewShorteningAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public System.Boolean CutParts
		{
			get => teklaObject.CutParts;
			set { teklaObject.CutParts = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.View.ShorteningCutPartType CutPartType
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ShorteningCutPartType_.FromTSObject(teklaObject.CutPartType);
			}
			set
			{
				teklaObject.CutPartType = Dynamic.Tekla.Structures.Drawing.View.ShorteningCutPartType_.GetTSObject(value);
			}
		}

		public System.Boolean CutSkewParts
		{
			get => teklaObject.CutSkewParts;
			set { teklaObject.CutSkewParts = value; }
		}

		public System.Double MinimumLength
		{
			get => teklaObject.MinimumLength;
			set { teklaObject.MinimumLength = value; }
		}

		public System.Double Offset
		{
			get => teklaObject.Offset;
			set { teklaObject.Offset = value; }
		}

        

        

		public ViewShorteningAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewShorteningAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ViewShorteningAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ViewShorteningAttributes(System.Boolean CutParts, System.Boolean CutSkewParts, System.Double MinimumLength, System.Double Offset, Dynamic.Tekla.Structures.Drawing.View.ShorteningCutPartType CutPartType)
		{
			var args = new object[5];
			args[0] = CutParts;
			args[1] = CutSkewParts;
			args[2] = MinimumLength;
			args[3] = Offset;
			args[4] = Dynamic.Tekla.Structures.Drawing.View.ShorteningCutPartType_.GetTSObject(CutPartType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewShorteningAttributes", args);
		}





    }

    internal static class ViewShorteningAttributes_
    {
        public static dynamic GetTSObject(ViewShorteningAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewShorteningAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.View.ViewShorteningAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewShorteningAttributesArray_
    {
        public static dynamic GetTSObject(ViewShorteningAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewShorteningAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewShorteningAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewShorteningAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewShorteningAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ViewMarkSymbolAttributes  : Dynamic.Tekla.Structures.Drawing.ViewMarkBasicSymbolAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.View.LabelLineLengthType LineLengthType
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.LabelLineLengthType_.FromTSObject(teklaObject.LineLengthType);
			}
			set
			{
				teklaObject.LineLengthType = Dynamic.Tekla.Structures.Drawing.View.LabelLineLengthType_.GetTSObject(value);
			}
		}

		public System.Double LineLength
		{
			get => teklaObject.LineLength;
			set { teklaObject.LineLength = value; }
		}

        

        

		public ViewMarkSymbolAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewMarkSymbolAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ViewMarkSymbolAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ViewMarkSymbolAttributes(System.Double size, Dynamic.Tekla.Structures.Drawing.MarkSymbolShape shape, Dynamic.Tekla.Structures.Drawing.View.LabelLineLengthType lineLengthType, System.Double lineLength)
		{
			var args = new object[4];
			args[0] = size;
			args[1] = Dynamic.Tekla.Structures.Drawing.MarkSymbolShape_.GetTSObject(shape);
			args[2] = Dynamic.Tekla.Structures.Drawing.View.LabelLineLengthType_.GetTSObject(lineLengthType);
			args[3] = lineLength;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewMarkSymbolAttributes", args);
		}





    }

    internal static class ViewMarkSymbolAttributes_
    {
        public static dynamic GetTSObject(ViewMarkSymbolAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewMarkSymbolAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.View.ViewMarkSymbolAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewMarkSymbolAttributesArray_
    {
        public static dynamic GetTSObject(ViewMarkSymbolAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewMarkSymbolAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewMarkSymbolAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewMarkSymbolAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewMarkSymbolAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ViewMarkTagAttributes  : Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes
    {

		public Dynamic.Tekla.Structures.Drawing.TextAlignment TagAlignment
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.TextAlignment_.FromTSObject(teklaObject.TagAlignment);
			}
			set
			{
				teklaObject.TagAlignment = Dynamic.Tekla.Structures.Drawing.TextAlignment_.GetTSObject(value);
			}
		}

        

        

		public ViewMarkTagAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewMarkTagAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ViewMarkTagAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ViewMarkTagAttributes(Dynamic.Tekla.Structures.Geometry3d.Vector offset, Dynamic.Tekla.Structures.Drawing.TagLocation location, Dynamic.Tekla.Structures.Drawing.TextAlignment alignment, Dynamic.Tekla.Structures.Drawing.ContainerElement tagContent)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(offset);
			args[1] = Dynamic.Tekla.Structures.Drawing.TagLocation_.GetTSObject(location);
			args[2] = Dynamic.Tekla.Structures.Drawing.TextAlignment_.GetTSObject(alignment);
			args[3] = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(tagContent);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewMarkTagAttributes", args);
		}





    }

    internal static class ViewMarkTagAttributes_
    {
        public static dynamic GetTSObject(ViewMarkTagAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewMarkTagAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewMarkTagAttributesArray_
    {
        public static dynamic GetTSObject(ViewMarkTagAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewMarkTagAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewMarkTagAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewMarkTagAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewMarkTagAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ViewMarkTagsAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes TagA1
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.FromTSObject(teklaObject.TagA1);
			}
			set
			{
				teklaObject.TagA1 = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes TagA2
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.FromTSObject(teklaObject.TagA2);
			}
			set
			{
				teklaObject.TagA2 = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes TagA3
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.FromTSObject(teklaObject.TagA3);
			}
			set
			{
				teklaObject.TagA3 = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes TagA4
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.FromTSObject(teklaObject.TagA4);
			}
			set
			{
				teklaObject.TagA4 = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes TagA5
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.FromTSObject(teklaObject.TagA5);
			}
			set
			{
				teklaObject.TagA5 = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(value);
			}
		}

        

        

		public ViewMarkTagsAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewMarkTagsAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ViewMarkTagsAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ViewMarkTagsAttributes(Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes tagA1, Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes tagA2, Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes tagA3, Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes tagA4, Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes tagA5)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(tagA1);
			args[1] = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(tagA2);
			args[2] = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(tagA3);
			args[3] = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(tagA4);
			args[4] = Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagAttributes_.GetTSObject(tagA5);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.View.ViewMarkTagsAttributes", args);
		}





    }

    internal static class ViewMarkTagsAttributes_
    {
        public static dynamic GetTSObject(ViewMarkTagsAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewMarkTagsAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.View.ViewMarkTagsAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewMarkTagsAttributesArray_
    {
        public static dynamic GetTSObject(ViewMarkTagsAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewMarkTagsAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewMarkTagsAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewMarkTagsAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewMarkTagsAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
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

            var dynObject = (Dynamic.Tekla.Structures.Drawing.View)System.Activator.CreateInstance(type, parameters);
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
    
