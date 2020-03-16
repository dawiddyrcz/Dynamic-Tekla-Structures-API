//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class TaskWorktype 
    {

		public System.String Name
		{
			get => taskworktype.Name;
			set { taskworktype.Name = value; }
		}

		public System.Nullable<System.DateTime> ModificationTime
		{
			get => taskworktype.ModificationTime;
			set { taskworktype.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => taskworktype.IsUpToDate;
			set { taskworktype.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(taskworktype.Identifier.GetTSObject());
			set { taskworktype.Identifier = value.GetTSObject(); }
		}

        

        dynamic taskworktype;
        
        public TaskWorktype()
        {
            this.taskworktype =  new Tekla.Structures.Model.TaskWorktype();
        }

        public TaskWorktype(dynamic tsObject)
        {
            this.taskworktype = tsObject;
			this.Name = taskworktype.Name;
			this.ModificationTime = taskworktype.ModificationTime;
			this.IsUpToDate = taskworktype.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(taskworktype.Identifier);

        }


        public dynamic GetTSObject() => taskworktype;

		public System.Boolean Insert()
			 => taskworktype.Insert();

		public System.Boolean Select()
			 => taskworktype.Select();

		public System.Boolean Modify()
			 => taskworktype.Modify();

		public System.Boolean Delete()
			 => taskworktype.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(taskworktype.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(taskworktype.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(taskworktype.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => taskworktype.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => taskworktype.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => taskworktype.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => taskworktype.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => taskworktype.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => taskworktype.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => taskworktype.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => taskworktype.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => taskworktype.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => taskworktype.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => taskworktype.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => taskworktype.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => taskworktype.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => taskworktype.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => taskworktype.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => taskworktype.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => taskworktype.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => taskworktype.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => taskworktype.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(taskworktype.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => taskworktype.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => taskworktype.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => taskworktype.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => taskworktype.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => taskworktype.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => taskworktype.Equals(obj);

		public System.Int32 GetHashCode()
			 => taskworktype.GetHashCode();

		public System.Type GetType()
			 => taskworktype.GetType();

		public System.String ToString()
			 => taskworktype.ToString();





    }

}
    
