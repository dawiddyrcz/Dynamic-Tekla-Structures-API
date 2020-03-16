//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Task 
    {

		public System.String Name
		{
			get => task.Name;
			set { task.Name = value; }
		}

		public System.Int32 Completeness
		{
			get => task.Completeness;
			set { task.Completeness = value; }
		}

		public System.Boolean Critical
		{
			get => task.Critical;
			set { task.Critical = value; }
		}

		public System.Boolean Local
		{
			get => task.Local;
			set { task.Local = value; }
		}

		public Dynamic.Tekla.Structures.Model.HierarchicObject Scenario
		{
			get => new Dynamic.Tekla.Structures.Model.HierarchicObject(task.Scenario.GetTSObject());
			set { task.Scenario = value.GetTSObject(); }
		}

		public System.String Description
		{
			get => task.Description;
			set { task.Description = value; }
		}

		public System.String Url
		{
			get => task.Url;
			set { task.Url = value; }
		}

		public System.DateTime PlannedStartDate
		{
			get => task.PlannedStartDate;
			set { task.PlannedStartDate = value; }
		}

		public System.DateTime PlannedEndDate
		{
			get => task.PlannedEndDate;
			set { task.PlannedEndDate = value; }
		}

		public System.Double PlannedWorkAmount
		{
			get => task.PlannedWorkAmount;
			set { task.PlannedWorkAmount = value; }
		}

		public System.DateTime ActualStartDate
		{
			get => task.ActualStartDate;
			set { task.ActualStartDate = value; }
		}

		public System.DateTime ActualEndDate
		{
			get => task.ActualEndDate;
			set { task.ActualEndDate = value; }
		}

		public System.Double ActualWorkAmount
		{
			get => task.ActualWorkAmount;
			set { task.ActualWorkAmount = value; }
		}

		public System.NullableSystem.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089<System.DateTime> ModificationTime
		{
			get => task.ModificationTime;
			set { task.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => task.IsUpToDate;
			set { task.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(task.Identifier.GetTSObject());
			set { task.Identifier = value.GetTSObject(); }
		}

        

        dynamic task;
        
        public Task()
        {
            this.task =  new Tekla.Structures.Model.Task();
        }

        public Task(dynamic tsObject)
        {
            this.task = tsObject;
			this.Name = task.Name;
			this.Completeness = task.Completeness;
			this.Critical = task.Critical;
			this.Local = task.Local;
			this.Scenario = new Dynamic.Tekla.Structures.Model.HierarchicObject(task.Scenario);
			this.Description = task.Description;
			this.Url = task.Url;
			this.PlannedStartDate = task.PlannedStartDate;
			this.PlannedEndDate = task.PlannedEndDate;
			this.PlannedWorkAmount = task.PlannedWorkAmount;
			this.ActualStartDate = task.ActualStartDate;
			this.ActualEndDate = task.ActualEndDate;
			this.ActualWorkAmount = task.ActualWorkAmount;
			this.ModificationTime = task.ModificationTime;
			this.IsUpToDate = task.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(task.Identifier);

        }


        public dynamic GetTSObject() => task;

		public System.Boolean Insert()
			 => task.Insert();

		public System.Boolean Select()
			 => task.Select();

		public System.Boolean Modify()
			 => task.Modify();

		public System.Boolean Delete()
			 => task.Delete();

		public System.Boolean AddObjectsToTask(System.Collections.ArrayList ModelObjects)
			 => task.AddObjectsToTask(ModelObjects);

		public System.Boolean RemoveObjectsFromTask(System.Collections.ArrayList ModelObjects)
			 => task.RemoveObjectsFromTask(ModelObjects);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetFathers()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(task.GetFathers());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDependencies()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(task.GetDependencies());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAllTasksOfSelectedObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(task.GetAllTasksOfSelectedObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(task.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(task.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(task.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => task.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => task.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => task.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => task.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => task.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => task.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => task.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => task.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => task.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => task.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => task.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => task.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => task.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => task.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => task.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => task.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => task.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => task.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => task.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(task.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => task.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => task.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => task.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => task.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => task.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => task.Equals(obj);

		public System.Int32 GetHashCode()
			 => task.GetHashCode();

		public System.Type GetType()
			 => task.GetType();

		public System.String ToString()
			 => task.ToString();





    }

}
    
