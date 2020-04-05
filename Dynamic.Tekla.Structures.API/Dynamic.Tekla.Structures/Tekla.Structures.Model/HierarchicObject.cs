/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class HierarchicObject  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public Dynamic.Tekla.Structures.Model.HierarchicDefinition Definition
		{
			get => Dynamic.Tekla.Structures.Model.HierarchicDefinition_.FromTSObject(teklaObject.Definition);
			set { teklaObject.Definition = Dynamic.Tekla.Structures.Model.HierarchicDefinition_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.HierarchicObject Father
		{
			get => Dynamic.Tekla.Structures.Model.HierarchicObject_.FromTSObject(teklaObject.Father);
			set { teklaObject.Father = Dynamic.Tekla.Structures.Model.HierarchicObject_.GetTSObject(value); }
		}

		public System.Collections.ArrayList HierarchicChildren
		{
			get => teklaObject.HierarchicChildren;
			set { teklaObject.HierarchicChildren = value; }
		}

        

        

		public HierarchicObject()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicObject");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public HierarchicObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public HierarchicObject(Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicObject", args);
		}

		public System.Boolean AddObjects(System.Collections.ArrayList Objects)
		{
			return teklaObject.AddObjects(Objects);
		}

		public System.Boolean RemoveObjects(System.Collections.ArrayList Objects)
		{
			return teklaObject.RemoveObjects(Objects);
		}





    }

    internal static class HierarchicObject_
    {
        public static dynamic GetTSObject(HierarchicObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static HierarchicObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.HierarchicObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class HierarchicObjectArray_
    {
        public static dynamic GetTSObject(HierarchicObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(HierarchicObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static HierarchicObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<HierarchicObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(HierarchicObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
