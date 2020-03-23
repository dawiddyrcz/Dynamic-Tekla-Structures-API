/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering.Categories
{

    public  class TaskFilterExpressions 
    {

        

        internal dynamic teklaObject;

		public TaskFilterExpressions() {}




    public  class CustomBoolean  : Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression
    {

        

        

		public CustomBoolean() {}
		public CustomBoolean(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.CustomBoolean", args);
		}





    }

    internal static class CustomBoolean_
    {
        public static dynamic GetTSObject(CustomBoolean dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CustomBoolean FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.CustomBoolean)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomBooleanArray_
    {
        public static dynamic GetTSObject(CustomBoolean[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomBoolean_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomBoolean[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CustomBoolean>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomBoolean_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class CustomDateTime  : Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression
    {

        

        

		public CustomDateTime() {}
		public CustomDateTime(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.CustomDateTime", args);
		}





    }

    internal static class CustomDateTime_
    {
        public static dynamic GetTSObject(CustomDateTime dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CustomDateTime FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.CustomDateTime)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomDateTimeArray_
    {
        public static dynamic GetTSObject(CustomDateTime[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomDateTime_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomDateTime[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CustomDateTime>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomDateTime_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class CustomNumber  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public CustomNumber() {}
		public CustomNumber(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.CustomNumber", args);
		}





    }

    internal static class CustomNumber_
    {
        public static dynamic GetTSObject(CustomNumber dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CustomNumber FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.CustomNumber)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomNumberArray_
    {
        public static dynamic GetTSObject(CustomNumber[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomNumber_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomNumber[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CustomNumber>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomNumber_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class CustomString  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public CustomString() {}
		public CustomString(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.CustomString", args);
		}





    }

    internal static class CustomString_
    {
        public static dynamic GetTSObject(CustomString dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CustomString FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.CustomString)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomStringArray_
    {
        public static dynamic GetTSObject(CustomString[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomString_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomString[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CustomString>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomString_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ActualEndDate  : Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression
    {

        

        

		public ActualEndDate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.ActualEndDate");
		}





    }

    internal static class ActualEndDate_
    {
        public static dynamic GetTSObject(ActualEndDate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ActualEndDate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.ActualEndDate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ActualEndDateArray_
    {
        public static dynamic GetTSObject(ActualEndDate[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ActualEndDate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ActualEndDate[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ActualEndDate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ActualEndDate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ActualStartDate  : Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression
    {

        

        

		public ActualStartDate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.ActualStartDate");
		}





    }

    internal static class ActualStartDate_
    {
        public static dynamic GetTSObject(ActualStartDate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ActualStartDate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.ActualStartDate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ActualStartDateArray_
    {
        public static dynamic GetTSObject(ActualStartDate[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ActualStartDate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ActualStartDate[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ActualStartDate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ActualStartDate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Completeness  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Completeness()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.Completeness");
		}





    }

    internal static class Completeness_
    {
        public static dynamic GetTSObject(Completeness dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Completeness FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.Completeness)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CompletenessArray_
    {
        public static dynamic GetTSObject(Completeness[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Completeness_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Completeness[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Completeness>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Completeness_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Critical  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Critical()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.Critical");
		}





    }

    internal static class Critical_
    {
        public static dynamic GetTSObject(Critical dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Critical FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.Critical)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CriticalArray_
    {
        public static dynamic GetTSObject(Critical[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Critical_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Critical[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Critical>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Critical_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Local  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Local()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.Local");
		}





    }

    internal static class Local_
    {
        public static dynamic GetTSObject(Local dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Local FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.Local)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LocalArray_
    {
        public static dynamic GetTSObject(Local[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Local_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Local[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Local>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Local_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Name  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Name()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.Name");
		}





    }

    internal static class Name_
    {
        public static dynamic GetTSObject(Name dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Name FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.Name)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NameArray_
    {
        public static dynamic GetTSObject(Name[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Name_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Name[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Name>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Name_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class PlannedEndDate  : Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression
    {

        

        

		public PlannedEndDate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.PlannedEndDate");
		}





    }

    internal static class PlannedEndDate_
    {
        public static dynamic GetTSObject(PlannedEndDate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlannedEndDate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.PlannedEndDate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlannedEndDateArray_
    {
        public static dynamic GetTSObject(PlannedEndDate[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlannedEndDate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlannedEndDate[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PlannedEndDate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlannedEndDate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class PlannedStartDate  : Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression
    {

        

        

		public PlannedStartDate()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.TaskFilterExpressions.PlannedStartDate");
		}





    }

    internal static class PlannedStartDate_
    {
        public static dynamic GetTSObject(PlannedStartDate dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlannedStartDate FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions.PlannedStartDate)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlannedStartDateArray_
    {
        public static dynamic GetTSObject(PlannedStartDate[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlannedStartDate_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlannedStartDate[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PlannedStartDate>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlannedStartDate_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class TaskFilterExpressions_
    {
        public static dynamic GetTSObject(TaskFilterExpressions dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TaskFilterExpressions FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.TaskFilterExpressions)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TaskFilterExpressionsArray_
    {
        public static dynamic GetTSObject(TaskFilterExpressions[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TaskFilterExpressions_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TaskFilterExpressions[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<TaskFilterExpressions>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TaskFilterExpressions_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
