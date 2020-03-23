/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LogicalWeld  : Dynamic.Tekla.Structures.Model.BaseWeld
    {

        

        

		public LogicalWeld() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LogicalWeld(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public LogicalWeld(Dynamic.Tekla.Structures.Model.BaseWeld MainWeld)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.BaseWeld_.GetTSObject(MainWeld);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LogicalWeld", args);
		}

		public System.Boolean AddWeld(Dynamic.Tekla.Structures.Model.BaseWeld Weld)
		{
			return teklaObject.AddWeld(Dynamic.Tekla.Structures.Model.BaseWeld_.GetTSObject(Weld));
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld GetMainWeld()
		{
			return Dynamic.Tekla.Structures.Model.BaseWeld_.FromTSObject(teklaObject.GetMainWeld());
		}

		public System.Boolean SetMainWeld(Dynamic.Tekla.Structures.Model.BaseWeld Weld)
		{
			return teklaObject.SetMainWeld(Dynamic.Tekla.Structures.Model.BaseWeld_.GetTSObject(Weld));
		}

		public System.Boolean RemoveWeld(Dynamic.Tekla.Structures.Model.BaseWeld Weld)
		{
			return teklaObject.RemoveWeld(Dynamic.Tekla.Structures.Model.BaseWeld_.GetTSObject(Weld));
		}

		public System.Boolean Explode()
		{
			return teklaObject.Explode();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Select(Dynamic.Tekla.Structures.Model.BaseWeld ChildWeld)
		{
			return teklaObject.Select(Dynamic.Tekla.Structures.Model.BaseWeld_.GetTSObject(ChildWeld));
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}





    }

    internal static class LogicalWeld_
    {
        public static dynamic GetTSObject(LogicalWeld dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LogicalWeld FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.LogicalWeld)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LogicalWeldArray_
    {
        public static dynamic GetTSObject(LogicalWeld[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LogicalWeld_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LogicalWeld[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<LogicalWeld>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LogicalWeld_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
