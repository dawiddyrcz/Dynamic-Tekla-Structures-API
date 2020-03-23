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
		public Component(Dynamic.Tekla.Structures.Model.ComponentInput I)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.ComponentInput_.GetTSObject(I);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Component", args);
		}

		public System.Boolean SetComponentInput(Dynamic.Tekla.Structures.Model.ComponentInput I)
		{
			return teklaObject.SetComponentInput(Dynamic.Tekla.Structures.Model.ComponentInput_.GetTSObject(I));
		}

		public Dynamic.Tekla.Structures.Model.ComponentInput GetComponentInput()
		{
			return Dynamic.Tekla.Structures.Model.ComponentInput_.FromTSObject(teklaObject.GetComponentInput());
		}

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
		{
			return Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(teklaObject.GetAssembly());
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

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetComponents());
		}





    }

    internal static class Component_
    {
        public static dynamic GetTSObject(Component dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Component FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Component)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ComponentArray_
    {
        public static dynamic GetTSObject(Component[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Component_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Component[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Component>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Component_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
