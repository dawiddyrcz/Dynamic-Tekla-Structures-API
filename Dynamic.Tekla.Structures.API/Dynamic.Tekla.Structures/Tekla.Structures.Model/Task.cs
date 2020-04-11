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
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

		public System.Int32 Completeness
		{
			get
			{
				try {
					return teklaObject.Completeness;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Completeness", ex); }
			}
			set
			{
				try {
					teklaObject.Completeness = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Completeness", ex); }
			}
		}

		public System.Boolean Critical
		{
			get
			{
				try {
					return teklaObject.Critical;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Critical", ex); }
			}
			set
			{
				try {
					teklaObject.Critical = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Critical", ex); }
			}
		}

		public System.Boolean Local
		{
			get
			{
				try {
					return teklaObject.Local;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Local", ex); }
			}
			set
			{
				try {
					teklaObject.Local = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Local", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.HierarchicObject Scenario
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.HierarchicObject_.FromTSObject(teklaObject.Scenario);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scenario", ex); }
			}
			set
			{
				try {
				teklaObject.Scenario = Dynamic.Tekla.Structures.Model.HierarchicObject_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scenario", ex); }
			}
		}

		public System.String Description
		{
			get
			{
				try {
					return teklaObject.Description;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Description", ex); }
			}
			set
			{
				try {
					teklaObject.Description = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Description", ex); }
			}
		}

		public System.String Url
		{
			get
			{
				try {
					return teklaObject.Url;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Url", ex); }
			}
			set
			{
				try {
					teklaObject.Url = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Url", ex); }
			}
		}

		public System.DateTime PlannedStartDate
		{
			get
			{
				try {
					return teklaObject.PlannedStartDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlannedStartDate", ex); }
			}
			set
			{
				try {
					teklaObject.PlannedStartDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlannedStartDate", ex); }
			}
		}

		public System.DateTime PlannedEndDate
		{
			get
			{
				try {
					return teklaObject.PlannedEndDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlannedEndDate", ex); }
			}
			set
			{
				try {
					teklaObject.PlannedEndDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlannedEndDate", ex); }
			}
		}

		public System.Double PlannedWorkAmount
		{
			get
			{
				try {
					return teklaObject.PlannedWorkAmount;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlannedWorkAmount", ex); }
			}
			set
			{
				try {
					teklaObject.PlannedWorkAmount = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PlannedWorkAmount", ex); }
			}
		}

		public System.DateTime ActualStartDate
		{
			get
			{
				try {
					return teklaObject.ActualStartDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualStartDate", ex); }
			}
			set
			{
				try {
					teklaObject.ActualStartDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualStartDate", ex); }
			}
		}

		public System.DateTime ActualEndDate
		{
			get
			{
				try {
					return teklaObject.ActualEndDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualEndDate", ex); }
			}
			set
			{
				try {
					teklaObject.ActualEndDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualEndDate", ex); }
			}
		}

		public System.Double ActualWorkAmount
		{
			get
			{
				try {
					return teklaObject.ActualWorkAmount;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualWorkAmount", ex); }
			}
			set
			{
				try {
					teklaObject.ActualWorkAmount = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActualWorkAmount", ex); }
			}
		}

        

        

		public Task()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Task");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Task(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Task(Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Task", args);
		}


public System.Boolean AddObjectsToTask(
	System.Collections.ArrayList ModelObjects_
	)
{
	var ModelObjects = ArrayListConverter.ToTSObjects(ModelObjects_);
    try
    {
        	var result = (System.Boolean) teklaObject.AddObjectsToTask(ModelObjects);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddObjectsToTask), ex);
    }
}



public System.Boolean RemoveObjectsFromTask(
	System.Collections.ArrayList ModelObjects_
	)
{
	var ModelObjects = ArrayListConverter.ToTSObjects(ModelObjects_);
    try
    {
        	var result = (System.Boolean) teklaObject.RemoveObjectsFromTask(ModelObjects);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveObjectsFromTask), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetFathers()
{

    try
    {
        	var result = teklaObject.GetFathers();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFathers), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDependencies()
{

    try
    {
        	var result = teklaObject.GetDependencies();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDependencies), ex);
    }
}



public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAllTasksOfSelectedObjects()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Task", "GetAllTasksOfSelectedObjects");
	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
}






    }

    internal static class Task_
    {
        public static dynamic GetTSObject(Task dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Task FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Task)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TaskArray_
    {
        public static dynamic GetTSObject(Task[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Task_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Task[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Task>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Task_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
