//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ControlPoint 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Point
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(controlpoint.Point);
			set { controlpoint.Point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => controlpoint.ModificationTime;
			set { controlpoint.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => controlpoint.IsUpToDate;
			set { controlpoint.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(controlpoint.Identifier);
			set { controlpoint.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic controlpoint;
        
        public ControlPoint()
        {
            this.controlpoint =  TSActivator.CreateInstance("Tekla.Structures.Model.ControlPoint");
        }

        internal ControlPoint(dynamic tsObject)
        {
            this.controlpoint = tsObject;
        }

		public System.Boolean Insert()
			 => controlpoint.Insert();

		public System.Boolean Select()
			 => controlpoint.Select();

		public System.Boolean Modify()
			 => controlpoint.Modify();

		public System.Boolean Delete()
			 => controlpoint.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(controlpoint.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(controlpoint.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(controlpoint.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => controlpoint.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => controlpoint.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => controlpoint.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => controlpoint.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => controlpoint.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => controlpoint.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => controlpoint.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => controlpoint.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => controlpoint.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => controlpoint.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => controlpoint.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => controlpoint.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => controlpoint.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => controlpoint.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => controlpoint.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => controlpoint.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => controlpoint.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => controlpoint.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => controlpoint.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(controlpoint.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => controlpoint.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => controlpoint.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => controlpoint.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => controlpoint.CompareTo(obj);





    }

    internal static class ControlPoint_
    {
        public static dynamic GetTSObject(ControlPoint dynObject)
        {
            return dynObject.controlpoint;
        }

        public static ControlPoint FromTSObject(dynamic tsObject)
        {
            return new ControlPoint(tsObject);
        }
    }


}
    
