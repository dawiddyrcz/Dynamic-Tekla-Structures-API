/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ViewVisibilitySettings 
    {

		public System.Boolean PointsVisible
		{
			get
			{
				try {
					return teklaObject.PointsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PointsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.PointsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PointsVisible", ex); }
			}
		}

		public System.Boolean PartsVisible
		{
			get
			{
				try {
					return teklaObject.PartsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.PartsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartsVisible", ex); }
			}
		}

		public System.Boolean BoltsVisible
		{
			get
			{
				try {
					return teklaObject.BoltsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.BoltsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltsVisible", ex); }
			}
		}

		public System.Boolean BoltHolesVisible
		{
			get
			{
				try {
					return teklaObject.BoltHolesVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltHolesVisible", ex); }
			}
			set
			{
				try {
					teklaObject.BoltHolesVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltHolesVisible", ex); }
			}
		}

		public System.Boolean WeldsVisible
		{
			get
			{
				try {
					return teklaObject.WeldsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WeldsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.WeldsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WeldsVisible", ex); }
			}
		}

		public System.Boolean ConstructionPlanesVisible
		{
			get
			{
				try {
					return teklaObject.ConstructionPlanesVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConstructionPlanesVisible", ex); }
			}
			set
			{
				try {
					teklaObject.ConstructionPlanesVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConstructionPlanesVisible", ex); }
			}
		}

		public System.Boolean RebarsVisible
		{
			get
			{
				try {
					return teklaObject.RebarsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.RebarsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarsVisible", ex); }
			}
		}

		public System.Boolean SurfaceTreatmentsVisible
		{
			get
			{
				try {
					return teklaObject.SurfaceTreatmentsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SurfaceTreatmentsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.SurfaceTreatmentsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SurfaceTreatmentsVisible", ex); }
			}
		}

		public System.Boolean PoursVisible
		{
			get
			{
				try {
					return teklaObject.PoursVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PoursVisible", ex); }
			}
			set
			{
				try {
					teklaObject.PoursVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PoursVisible", ex); }
			}
		}

		public System.Boolean PourBreaksVisible
		{
			get
			{
				try {
					return teklaObject.PourBreaksVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourBreaksVisible", ex); }
			}
			set
			{
				try {
					teklaObject.PourBreaksVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PourBreaksVisible", ex); }
			}
		}

		public System.Boolean LoadsVisible
		{
			get
			{
				try {
					return teklaObject.LoadsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.LoadsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LoadsVisible", ex); }
			}
		}

		public System.Boolean CutsVisible
		{
			get
			{
				try {
					return teklaObject.CutsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.CutsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutsVisible", ex); }
			}
		}

		public System.Boolean FittingsVisible
		{
			get
			{
				try {
					return teklaObject.FittingsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FittingsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.FittingsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FittingsVisible", ex); }
			}
		}

		public System.Boolean ComponentsVisible
		{
			get
			{
				try {
					return teklaObject.ComponentsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ComponentsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.ComponentsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ComponentsVisible", ex); }
			}
		}

		public System.Boolean GridsVisible
		{
			get
			{
				try {
					return teklaObject.GridsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GridsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.GridsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GridsVisible", ex); }
			}
		}

		public System.Boolean ConstructionLinesVisible
		{
			get
			{
				try {
					return teklaObject.ConstructionLinesVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConstructionLinesVisible", ex); }
			}
			set
			{
				try {
					teklaObject.ConstructionLinesVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConstructionLinesVisible", ex); }
			}
		}

		public System.Boolean ReferenceObjectsVisible
		{
			get
			{
				try {
					return teklaObject.ReferenceObjectsVisible;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ReferenceObjectsVisible", ex); }
			}
			set
			{
				try {
					teklaObject.ReferenceObjectsVisible = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ReferenceObjectsVisible", ex); }
			}
		}

		public System.Boolean PointsVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.PointsVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PointsVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.PointsVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PointsVisibleInComponents", ex); }
			}
		}

		public System.Boolean PartsVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.PartsVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartsVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.PartsVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PartsVisibleInComponents", ex); }
			}
		}

		public System.Boolean BoltsVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.BoltsVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltsVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.BoltsVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltsVisibleInComponents", ex); }
			}
		}

		public System.Boolean BoltHolesVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.BoltHolesVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltHolesVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.BoltHolesVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoltHolesVisibleInComponents", ex); }
			}
		}

		public System.Boolean WeldsVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.WeldsVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WeldsVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.WeldsVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("WeldsVisibleInComponents", ex); }
			}
		}

		public System.Boolean ConstructionPlanesVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.ConstructionPlanesVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConstructionPlanesVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.ConstructionPlanesVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ConstructionPlanesVisibleInComponents", ex); }
			}
		}

		public System.Boolean RebarsVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.RebarsVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarsVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.RebarsVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RebarsVisibleInComponents", ex); }
			}
		}

		public System.Boolean CutsVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.CutsVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutsVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.CutsVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutsVisibleInComponents", ex); }
			}
		}

		public System.Boolean FittingsVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.FittingsVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FittingsVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.FittingsVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FittingsVisibleInComponents", ex); }
			}
		}

		public System.Boolean ComponentsVisibleInComponents
		{
			get
			{
				try {
					return teklaObject.ComponentsVisibleInComponents;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ComponentsVisibleInComponents", ex); }
			}
			set
			{
				try {
					teklaObject.ComponentsVisibleInComponents = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ComponentsVisibleInComponents", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public ViewVisibilitySettings()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewVisibilitySettings");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ViewVisibilitySettings(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class ViewVisibilitySettings_
    {
        public static dynamic GetTSObject(ViewVisibilitySettings dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewVisibilitySettings FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewVisibilitySettingsArray_
    {
        public static dynamic GetTSObject(ViewVisibilitySettings[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewVisibilitySettings_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewVisibilitySettings[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewVisibilitySettings>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewVisibilitySettings_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
