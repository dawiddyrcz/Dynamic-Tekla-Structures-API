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
			get => teklaObject.Lag;
			set { teklaObject.Lag = value; }
		}

		public System.Boolean Local
		{
			get => teklaObject.Local;
			set { teklaObject.Local = value; }
		}

		public Dynamic.Tekla.Structures.Model.Task Primary
		{
			get => Dynamic.Tekla.Structures.Model.Task_.FromTSObject(teklaObject.Primary);
			set { teklaObject.Primary = Dynamic.Tekla.Structures.Model.Task_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Task Secondary
		{
			get => Dynamic.Tekla.Structures.Model.Task_.FromTSObject(teklaObject.Secondary);
			set { teklaObject.Secondary = Dynamic.Tekla.Structures.Model.Task_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.TaskDependency.DependencyTypeEnum DependencyType
		{
			get => Dynamic.Tekla.Structures.Model.TaskDependency.DependencyTypeEnum_.FromTSObject(teklaObject.DependencyType);
			set { teklaObject.DependencyType = Dynamic.Tekla.Structures.Model.TaskDependency.DependencyTypeEnum_.GetTSObject(value); }
		}

        

        

		public TaskDependency()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TaskDependency");
		}
		public TaskDependency(Dynamic.Tekla.Structures.Model.Task primary, Dynamic.Tekla.Structures.Model.Task secondary)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.Task_.GetTSObject(primary);
			args[1] = Dynamic.Tekla.Structures.Model.Task_.GetTSObject(secondary);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TaskDependency", args);
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class TaskDependency_
    {
        public static dynamic GetTSObject(TaskDependency dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TaskDependency FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.TaskDependency)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
