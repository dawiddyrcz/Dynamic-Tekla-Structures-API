/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
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
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean AddObjectsToTask(System.Collections.ArrayList ModelObjects)
		{
			return teklaObject.AddObjectsToTask(ModelObjects);
		}

		public System.Boolean RemoveObjectsFromTask(System.Collections.ArrayList ModelObjects)
		{
			return teklaObject.RemoveObjectsFromTask(ModelObjects);
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetFathers()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetFathers());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDependencies()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetDependencies());
		}

		public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAllTasksOfSelectedObjects()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Task", "GetAllTasksOfSelectedObjects", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
		}





    }

    internal static class Task_
    {
        public static dynamic GetTSObject(Task dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Task FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Task)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TaskArray_
    {
        public static dynamic GetTSObject(Task[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Task_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Task[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Task>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Task_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
