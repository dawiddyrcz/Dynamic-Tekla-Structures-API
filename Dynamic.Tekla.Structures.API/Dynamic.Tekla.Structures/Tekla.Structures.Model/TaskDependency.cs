/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class TaskDependency  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.Int32 Lag
		{
			get
			{
				try {
					return teklaObject.Lag;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Lag", ex); }
			}
			set
			{
				try {
					teklaObject.Lag = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Lag", ex); }
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

		public Dynamic.Tekla.Structures.Model.Task Primary
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Task_.FromTSObject(teklaObject.Primary);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Primary", ex); }
			}
			set
			{
				try {
				teklaObject.Primary = Dynamic.Tekla.Structures.Model.Task_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Primary", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Task Secondary
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Task_.FromTSObject(teklaObject.Secondary);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Secondary", ex); }
			}
			set
			{
				try {
				teklaObject.Secondary = Dynamic.Tekla.Structures.Model.Task_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Secondary", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.TaskDependency.DependencyTypeEnum DependencyType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.TaskDependency.DependencyTypeEnum_.FromTSObject(teklaObject.DependencyType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DependencyType", ex); }
			}
			set
			{
				try {
				teklaObject.DependencyType = Dynamic.Tekla.Structures.Model.TaskDependency.DependencyTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DependencyType", ex); }
			}
		}

        

        

		public TaskDependency()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TaskDependency");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TaskDependency(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public TaskDependency(Dynamic.Tekla.Structures.Model.Task primary, Dynamic.Tekla.Structures.Model.Task secondary)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.Task_.GetTSObject(primary);
			args[1] = Dynamic.Tekla.Structures.Model.Task_.GetTSObject(secondary);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TaskDependency", args);
		}




    public enum DependencyTypeEnum
    {
			FINISH_TO_FINISH,
			FINISH_TO_START,
			START_TO_FINISH,
			START_TO_START        
    }

    internal static class DependencyTypeEnum_
    {
        public static dynamic GetTSObject(DependencyTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.TaskDependency.DependencyTypeEnum").GetType();

            switch (dynEnum)
            {
				case DependencyTypeEnum.FINISH_TO_FINISH:
					return System.Enum.Parse(tsType, "FINISH_TO_FINISH");
				case DependencyTypeEnum.FINISH_TO_START:
					return System.Enum.Parse(tsType, "FINISH_TO_START");
				case DependencyTypeEnum.START_TO_FINISH:
					return System.Enum.Parse(tsType, "START_TO_FINISH");
				case DependencyTypeEnum.START_TO_START:
					return System.Enum.Parse(tsType, "START_TO_START");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static DependencyTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("FINISH_TO_FINISH", System.StringComparison.InvariantCulture))
				return DependencyTypeEnum.FINISH_TO_FINISH;
			else if (tsEnumValue.Equals("FINISH_TO_START", System.StringComparison.InvariantCulture))
				return DependencyTypeEnum.FINISH_TO_START;
			else if (tsEnumValue.Equals("START_TO_FINISH", System.StringComparison.InvariantCulture))
				return DependencyTypeEnum.START_TO_FINISH;
			else if (tsEnumValue.Equals("START_TO_START", System.StringComparison.InvariantCulture))
				return DependencyTypeEnum.START_TO_START;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class TaskDependency_
    {
        public static dynamic GetTSObject(TaskDependency dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TaskDependency FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.TaskDependency)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TaskDependencyArray_
    {
        public static dynamic GetTSObject(TaskDependency[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TaskDependency_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TaskDependency[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TaskDependency>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TaskDependency_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
