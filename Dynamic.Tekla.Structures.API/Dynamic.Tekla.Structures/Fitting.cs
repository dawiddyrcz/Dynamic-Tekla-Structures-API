//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Fitting 
    {

		public Dynamic.Tekla.Structures.Model.Plane Plane
		{
			get => new Dynamic.Tekla.Structures.Model.Plane(fitting.Plane.GetTSObject());
			set { fitting.Plane = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(fitting.Father.GetTSObject());
			set { fitting.Father = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => fitting.ModificationTime;
			set { fitting.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => fitting.IsUpToDate;
			set { fitting.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(fitting.Identifier.GetTSObject());
			set { fitting.Identifier = value.GetTSObject(); }
		}

        

        dynamic fitting;
        
        public Fitting()
        {
            this.fitting =  new Tekla.Structures.Model.Fitting();
        }

        public Fitting(dynamic tsObject)
        {
            this.fitting = tsObject;
			this.Plane = new Dynamic.Tekla.Structures.Model.Plane(fitting.Plane);
			this.Father = new Dynamic.Tekla.Structures.Model.ModelObject(fitting.Father);
			this.ModificationTime = fitting.ModificationTime;
			this.IsUpToDate = fitting.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(fitting.Identifier);

        }


        public dynamic GetTSObject() => fitting;

		public System.Boolean Insert()
			 => fitting.Insert();

		public System.Boolean Select()
			 => fitting.Select();

		public System.Boolean Modify()
			 => fitting.Modify();

		public System.Boolean Delete()
			 => fitting.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(fitting.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(fitting.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(fitting.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => fitting.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => fitting.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => fitting.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => fitting.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => fitting.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => fitting.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => fitting.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => fitting.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => fitting.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => fitting.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => fitting.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => fitting.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => fitting.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => fitting.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => fitting.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => fitting.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => fitting.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => fitting.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => fitting.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(fitting.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => fitting.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => fitting.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => fitting.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => fitting.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => fitting.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => fitting.Equals(obj);

		public System.Int32 GetHashCode()
			 => fitting.GetHashCode();

		public System.Type GetType()
			 => fitting.GetType();

		public System.String ToString()
			 => fitting.ToString();





    }

}
    
