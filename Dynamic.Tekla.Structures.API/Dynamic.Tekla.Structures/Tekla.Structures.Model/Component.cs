/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Component  : Dynamic.Tekla.Structures.Model.BaseComponent
    {

        

        

		public Component()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Component");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Component(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Component(Dynamic.Tekla.Structures.Model.ComponentInput I)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.ComponentInput_.GetTSObject(I);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Component", args);
		}

		public System.Boolean SetComponentInput(Dynamic.Tekla.Structures.Model.ComponentInput I)
		{
			try {
			return teklaObject.SetComponentInput(Dynamic.Tekla.Structures.Model.ComponentInput_.GetTSObject(I));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetComponentInput()"); }
		}

		public Dynamic.Tekla.Structures.Model.ComponentInput GetComponentInput()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ComponentInput_.FromTSObject(teklaObject.GetComponentInput());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetComponentInput()"); }
		}

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
		{
			try {
			return Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(teklaObject.GetAssembly());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAssembly()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetComponents());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetComponents()"); }
		}





    }

    internal static class Component_
    {
        public static dynamic GetTSObject(Component dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Component FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Component)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ComponentArray_
    {
        public static dynamic GetTSObject(Component[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Component_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Component[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Component>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Component_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
