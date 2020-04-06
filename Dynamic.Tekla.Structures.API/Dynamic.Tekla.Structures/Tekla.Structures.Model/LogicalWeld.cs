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

        

        

		internal LogicalWeld() {}
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
			try {
			var result = teklaObject.AddWeld(Dynamic.Tekla.Structures.Model.BaseWeld_.GetTSObject(Weld));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AddWeld()"); }
		}

		public Dynamic.Tekla.Structures.Model.BaseWeld GetMainWeld()
		{
			try {
			return Dynamic.Tekla.Structures.Model.BaseWeld_.FromTSObject(teklaObject.GetMainWeld());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetMainWeld()"); }
		}

		public System.Boolean SetMainWeld(Dynamic.Tekla.Structures.Model.BaseWeld Weld)
		{
			try {
			var result = teklaObject.SetMainWeld(Dynamic.Tekla.Structures.Model.BaseWeld_.GetTSObject(Weld));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetMainWeld()"); }
		}

		public System.Boolean RemoveWeld(Dynamic.Tekla.Structures.Model.BaseWeld Weld)
		{
			try {
			var result = teklaObject.RemoveWeld(Dynamic.Tekla.Structures.Model.BaseWeld_.GetTSObject(Weld));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveWeld()"); }
		}

		public System.Boolean Explode()
		{
			try {
			var result = teklaObject.Explode();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Explode()"); }
		}

		public System.Boolean Select(Dynamic.Tekla.Structures.Model.BaseWeld ChildWeld)
		{
			try {
			var result = teklaObject.Select(Dynamic.Tekla.Structures.Model.BaseWeld_.GetTSObject(ChildWeld));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}





    }

    internal static class LogicalWeld_
    {
        public static dynamic GetTSObject(LogicalWeld dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LogicalWeld FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LogicalWeld_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LogicalWeld[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LogicalWeld>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LogicalWeld_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
