//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class Task  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.Int32 Completeness
		{
			get => teklaObject.Completeness;
			set { teklaObject.Completeness = value; }
		}

		public System.Boolean Critical
		{
			get => teklaObject.Critical;
			set { teklaObject.Critical = value; }
		}

		public System.Boolean Local
		{
			get => teklaObject.Local;
			set { teklaObject.Local = value; }
		}

		public Dynamic.Tekla.Structures.Model.HierarchicObject Scenario
		{
			get => Dynamic.Tekla.Structures.Model.HierarchicObject_.FromTSObject(teklaObject.Scenario);
			set { teklaObject.Scenario = Dynamic.Tekla.Structures.Model.HierarchicObject_.GetTSObject(value); }
		}

		public System.String Description
		{
			get => teklaObject.Description;
			set { teklaObject.Description = value; }
		}

		public System.String Url
		{
			get => teklaObject.Url;
			set { teklaObject.Url = value; }
		}

		public System.DateTime PlannedStartDate
		{
			get => teklaObject.PlannedStartDate;
			set { teklaObject.PlannedStartDate = value; }
		}

		public System.DateTime PlannedEndDate
		{
			get => teklaObject.PlannedEndDate;
			set { teklaObject.PlannedEndDate = value; }
		}

		public System.Double PlannedWorkAmount
		{
			get => teklaObject.PlannedWorkAmount;
			set { teklaObject.PlannedWorkAmount = value; }
		}

		public System.DateTime ActualStartDate
		{
			get => teklaObject.ActualStartDate;
			set { teklaObject.ActualStartDate = value; }
		}

		public System.DateTime ActualEndDate
		{
			get => teklaObject.ActualEndDate;
			set { teklaObject.ActualEndDate = value; }
		}

		public System.Double ActualWorkAmount
		{
			get => teklaObject.ActualWorkAmount;
			set { teklaObject.ActualWorkAmount = value; }
		}

		public System.DateTime ModificationTime
		{
			get => teklaObject.ModificationTime;
			set { teklaObject.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => teklaObject.IsUpToDate;
			set { teklaObject.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.Identifier);
			set { teklaObject.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public Task()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Task");
		}
		public Task(Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Task", args);
		}

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Select()
			 => teklaObject.Select();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public System.Boolean AddObjectsToTask(System.Collections.ArrayList ModelObjects)
			 => teklaObject.AddObjectsToTask(ModelObjects);

		public System.Boolean RemoveObjectsFromTask(System.Collections.ArrayList ModelObjects)
			 => teklaObject.RemoveObjectsFromTask(ModelObjects);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetFathers()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetFathers());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDependencies()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetDependencies());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAllTasksOfSelectedObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetAllTasksOfSelectedObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(teklaObject.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => teklaObject.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => teklaObject.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => teklaObject.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => teklaObject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => teklaObject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => teklaObject.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => teklaObject.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => teklaObject.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => teklaObject.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => teklaObject.CompareTo(obj);





    }

    internal static class Task_
    {
        public static dynamic GetTSObject(Task dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Task FromTSObject(dynamic tsObject)
        {
            return new Task() { teklaObject = tsObject };
        }
    }


}
    
