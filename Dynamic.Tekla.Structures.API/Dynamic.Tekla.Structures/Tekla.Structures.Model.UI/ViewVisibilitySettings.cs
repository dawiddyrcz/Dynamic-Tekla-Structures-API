//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class ViewVisibilitySettings 
    {

		public System.Boolean PointsVisible
		{
			get => viewvisibilitysettings.PointsVisible;
			set { viewvisibilitysettings.PointsVisible = value; }
		}

		public System.Boolean PartsVisible
		{
			get => viewvisibilitysettings.PartsVisible;
			set { viewvisibilitysettings.PartsVisible = value; }
		}

		public System.Boolean BoltsVisible
		{
			get => viewvisibilitysettings.BoltsVisible;
			set { viewvisibilitysettings.BoltsVisible = value; }
		}

		public System.Boolean BoltHolesVisible
		{
			get => viewvisibilitysettings.BoltHolesVisible;
			set { viewvisibilitysettings.BoltHolesVisible = value; }
		}

		public System.Boolean WeldsVisible
		{
			get => viewvisibilitysettings.WeldsVisible;
			set { viewvisibilitysettings.WeldsVisible = value; }
		}

		public System.Boolean ConstructionPlanesVisible
		{
			get => viewvisibilitysettings.ConstructionPlanesVisible;
			set { viewvisibilitysettings.ConstructionPlanesVisible = value; }
		}

		public System.Boolean RebarsVisible
		{
			get => viewvisibilitysettings.RebarsVisible;
			set { viewvisibilitysettings.RebarsVisible = value; }
		}

		public System.Boolean SurfaceTreatmentsVisible
		{
			get => viewvisibilitysettings.SurfaceTreatmentsVisible;
			set { viewvisibilitysettings.SurfaceTreatmentsVisible = value; }
		}

		public System.Boolean PoursVisible
		{
			get => viewvisibilitysettings.PoursVisible;
			set { viewvisibilitysettings.PoursVisible = value; }
		}

		public System.Boolean PourBreaksVisible
		{
			get => viewvisibilitysettings.PourBreaksVisible;
			set { viewvisibilitysettings.PourBreaksVisible = value; }
		}

		public System.Boolean LoadsVisible
		{
			get => viewvisibilitysettings.LoadsVisible;
			set { viewvisibilitysettings.LoadsVisible = value; }
		}

		public System.Boolean CutsVisible
		{
			get => viewvisibilitysettings.CutsVisible;
			set { viewvisibilitysettings.CutsVisible = value; }
		}

		public System.Boolean FittingsVisible
		{
			get => viewvisibilitysettings.FittingsVisible;
			set { viewvisibilitysettings.FittingsVisible = value; }
		}

		public System.Boolean ComponentsVisible
		{
			get => viewvisibilitysettings.ComponentsVisible;
			set { viewvisibilitysettings.ComponentsVisible = value; }
		}

		public System.Boolean GridsVisible
		{
			get => viewvisibilitysettings.GridsVisible;
			set { viewvisibilitysettings.GridsVisible = value; }
		}

		public System.Boolean ConstructionLinesVisible
		{
			get => viewvisibilitysettings.ConstructionLinesVisible;
			set { viewvisibilitysettings.ConstructionLinesVisible = value; }
		}

		public System.Boolean ReferenceObjectsVisible
		{
			get => viewvisibilitysettings.ReferenceObjectsVisible;
			set { viewvisibilitysettings.ReferenceObjectsVisible = value; }
		}

		public System.Boolean PointsVisibleInComponents
		{
			get => viewvisibilitysettings.PointsVisibleInComponents;
			set { viewvisibilitysettings.PointsVisibleInComponents = value; }
		}

		public System.Boolean PartsVisibleInComponents
		{
			get => viewvisibilitysettings.PartsVisibleInComponents;
			set { viewvisibilitysettings.PartsVisibleInComponents = value; }
		}

		public System.Boolean BoltsVisibleInComponents
		{
			get => viewvisibilitysettings.BoltsVisibleInComponents;
			set { viewvisibilitysettings.BoltsVisibleInComponents = value; }
		}

		public System.Boolean BoltHolesVisibleInComponents
		{
			get => viewvisibilitysettings.BoltHolesVisibleInComponents;
			set { viewvisibilitysettings.BoltHolesVisibleInComponents = value; }
		}

		public System.Boolean WeldsVisibleInComponents
		{
			get => viewvisibilitysettings.WeldsVisibleInComponents;
			set { viewvisibilitysettings.WeldsVisibleInComponents = value; }
		}

		public System.Boolean ConstructionPlanesVisibleInComponents
		{
			get => viewvisibilitysettings.ConstructionPlanesVisibleInComponents;
			set { viewvisibilitysettings.ConstructionPlanesVisibleInComponents = value; }
		}

		public System.Boolean RebarsVisibleInComponents
		{
			get => viewvisibilitysettings.RebarsVisibleInComponents;
			set { viewvisibilitysettings.RebarsVisibleInComponents = value; }
		}

		public System.Boolean CutsVisibleInComponents
		{
			get => viewvisibilitysettings.CutsVisibleInComponents;
			set { viewvisibilitysettings.CutsVisibleInComponents = value; }
		}

		public System.Boolean FittingsVisibleInComponents
		{
			get => viewvisibilitysettings.FittingsVisibleInComponents;
			set { viewvisibilitysettings.FittingsVisibleInComponents = value; }
		}

		public System.Boolean ComponentsVisibleInComponents
		{
			get => viewvisibilitysettings.ComponentsVisibleInComponents;
			set { viewvisibilitysettings.ComponentsVisibleInComponents = value; }
		}

        

        internal dynamic viewvisibilitysettings;
        
        public ViewVisibilitySettings()
        {
            this.viewvisibilitysettings =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewVisibilitySettings");
        }

        internal ViewVisibilitySettings(dynamic tsObject)
        {
            this.viewvisibilitysettings = tsObject;
        }





    }

    internal static class ViewVisibilitySettings_
    {
        public static dynamic GetTSObject(ViewVisibilitySettings dynObject)
        {
            return dynObject.viewvisibilitysettings;
        }

        public static ViewVisibilitySettings FromTSObject(dynamic tsObject)
        {
            return new ViewVisibilitySettings(tsObject);
        }
    }


}
    
