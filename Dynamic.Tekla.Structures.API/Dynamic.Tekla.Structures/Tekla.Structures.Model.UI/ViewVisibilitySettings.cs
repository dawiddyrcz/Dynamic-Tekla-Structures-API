//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ViewVisibilitySettings 
    {

		public System.Boolean PointsVisible
		{
			get => teklaObject.PointsVisible;
			set { teklaObject.PointsVisible = value; }
		}

		public System.Boolean PartsVisible
		{
			get => teklaObject.PartsVisible;
			set { teklaObject.PartsVisible = value; }
		}

		public System.Boolean BoltsVisible
		{
			get => teklaObject.BoltsVisible;
			set { teklaObject.BoltsVisible = value; }
		}

		public System.Boolean BoltHolesVisible
		{
			get => teklaObject.BoltHolesVisible;
			set { teklaObject.BoltHolesVisible = value; }
		}

		public System.Boolean WeldsVisible
		{
			get => teklaObject.WeldsVisible;
			set { teklaObject.WeldsVisible = value; }
		}

		public System.Boolean ConstructionPlanesVisible
		{
			get => teklaObject.ConstructionPlanesVisible;
			set { teklaObject.ConstructionPlanesVisible = value; }
		}

		public System.Boolean RebarsVisible
		{
			get => teklaObject.RebarsVisible;
			set { teklaObject.RebarsVisible = value; }
		}

		public System.Boolean SurfaceTreatmentsVisible
		{
			get => teklaObject.SurfaceTreatmentsVisible;
			set { teklaObject.SurfaceTreatmentsVisible = value; }
		}

		public System.Boolean PoursVisible
		{
			get => teklaObject.PoursVisible;
			set { teklaObject.PoursVisible = value; }
		}

		public System.Boolean PourBreaksVisible
		{
			get => teklaObject.PourBreaksVisible;
			set { teklaObject.PourBreaksVisible = value; }
		}

		public System.Boolean LoadsVisible
		{
			get => teklaObject.LoadsVisible;
			set { teklaObject.LoadsVisible = value; }
		}

		public System.Boolean CutsVisible
		{
			get => teklaObject.CutsVisible;
			set { teklaObject.CutsVisible = value; }
		}

		public System.Boolean FittingsVisible
		{
			get => teklaObject.FittingsVisible;
			set { teklaObject.FittingsVisible = value; }
		}

		public System.Boolean ComponentsVisible
		{
			get => teklaObject.ComponentsVisible;
			set { teklaObject.ComponentsVisible = value; }
		}

		public System.Boolean GridsVisible
		{
			get => teklaObject.GridsVisible;
			set { teklaObject.GridsVisible = value; }
		}

		public System.Boolean ConstructionLinesVisible
		{
			get => teklaObject.ConstructionLinesVisible;
			set { teklaObject.ConstructionLinesVisible = value; }
		}

		public System.Boolean ReferenceObjectsVisible
		{
			get => teklaObject.ReferenceObjectsVisible;
			set { teklaObject.ReferenceObjectsVisible = value; }
		}

		public System.Boolean PointsVisibleInComponents
		{
			get => teklaObject.PointsVisibleInComponents;
			set { teklaObject.PointsVisibleInComponents = value; }
		}

		public System.Boolean PartsVisibleInComponents
		{
			get => teklaObject.PartsVisibleInComponents;
			set { teklaObject.PartsVisibleInComponents = value; }
		}

		public System.Boolean BoltsVisibleInComponents
		{
			get => teklaObject.BoltsVisibleInComponents;
			set { teklaObject.BoltsVisibleInComponents = value; }
		}

		public System.Boolean BoltHolesVisibleInComponents
		{
			get => teklaObject.BoltHolesVisibleInComponents;
			set { teklaObject.BoltHolesVisibleInComponents = value; }
		}

		public System.Boolean WeldsVisibleInComponents
		{
			get => teklaObject.WeldsVisibleInComponents;
			set { teklaObject.WeldsVisibleInComponents = value; }
		}

		public System.Boolean ConstructionPlanesVisibleInComponents
		{
			get => teklaObject.ConstructionPlanesVisibleInComponents;
			set { teklaObject.ConstructionPlanesVisibleInComponents = value; }
		}

		public System.Boolean RebarsVisibleInComponents
		{
			get => teklaObject.RebarsVisibleInComponents;
			set { teklaObject.RebarsVisibleInComponents = value; }
		}

		public System.Boolean CutsVisibleInComponents
		{
			get => teklaObject.CutsVisibleInComponents;
			set { teklaObject.CutsVisibleInComponents = value; }
		}

		public System.Boolean FittingsVisibleInComponents
		{
			get => teklaObject.FittingsVisibleInComponents;
			set { teklaObject.FittingsVisibleInComponents = value; }
		}

		public System.Boolean ComponentsVisibleInComponents
		{
			get => teklaObject.ComponentsVisibleInComponents;
			set { teklaObject.ComponentsVisibleInComponents = value; }
		}

        

        internal dynamic teklaObject;

		public ViewVisibilitySettings()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewVisibilitySettings");
		}





    }

    internal static class ViewVisibilitySettings_
    {
        public static dynamic GetTSObject(ViewVisibilitySettings dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ViewVisibilitySettings FromTSObject(dynamic tsObject)
        {
            return new ViewVisibilitySettings() { teklaObject = tsObject };
        }
    }


}
    
