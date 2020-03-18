//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ControlPolycurve 
    {

		public Dynamic.Tekla.Structures.Model.ControlObjectColorEnum Color
		{
			get => Dynamic.Tekla.Structures.Model.ControlObjectColorEnum_.FromTSObject(controlpolycurve.Color);
			set { controlpolycurve.Color = Dynamic.Tekla.Structures.Model.ControlObjectColorEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ControlObjectLineType LineType
		{
			get => Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(controlpolycurve.LineType);
			set { controlpolycurve.LineType = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Polycurve Geometry
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Polycurve_.FromTSObject(controlpolycurve.Geometry);
			set { controlpolycurve.Geometry = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => controlpolycurve.ModificationTime;
			set { controlpolycurve.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => controlpolycurve.IsUpToDate;
			set { controlpolycurve.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(controlpolycurve.Identifier);
			set { controlpolycurve.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic controlpolycurve;
        
        public ControlPolycurve()
        {
            this.controlpolycurve =  TSActivator.CreateInstance("Tekla.Structures.Model.ControlPolycurve");
        }

        internal ControlPolycurve(dynamic tsObject)
        {
            this.controlpolycurve = tsObject;
        }

		public System.Boolean Delete()
			 => controlpolycurve.Delete();

		public System.Boolean Insert()
			 => controlpolycurve.Insert();

		public System.Boolean Modify()
			 => controlpolycurve.Modify();

		public System.Boolean Select()
			 => controlpolycurve.Select();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(controlpolycurve.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(controlpolycurve.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(controlpolycurve.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => controlpolycurve.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => controlpolycurve.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => controlpolycurve.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => controlpolycurve.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => controlpolycurve.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => controlpolycurve.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => controlpolycurve.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => controlpolycurve.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => controlpolycurve.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => controlpolycurve.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => controlpolycurve.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => controlpolycurve.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => controlpolycurve.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => controlpolycurve.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => controlpolycurve.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => controlpolycurve.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => controlpolycurve.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => controlpolycurve.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => controlpolycurve.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(controlpolycurve.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => controlpolycurve.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => controlpolycurve.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => controlpolycurve.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => controlpolycurve.CompareTo(obj);





    }

    internal static class ControlPolycurve_
    {
        public static dynamic GetTSObject(ControlPolycurve dynObject)
        {
            return dynObject.controlpolycurve;
        }

        public static ControlPolycurve FromTSObject(dynamic tsObject)
        {
            return new ControlPolycurve(tsObject);
        }
    }


}
    