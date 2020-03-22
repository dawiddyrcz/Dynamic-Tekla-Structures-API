/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class HierarchicDefinition  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String CustomType
		{
			get => teklaObject.CustomType;
			set { teklaObject.CustomType = value; }
		}

		public Dynamic.Tekla.Structures.Model.HierarchicDefinitionTypeEnum HierarchyType
		{
			get => Dynamic.Tekla.Structures.Model.HierarchicDefinitionTypeEnum_.FromTSObject(teklaObject.HierarchyType);
			set { teklaObject.HierarchyType = Dynamic.Tekla.Structures.Model.HierarchicDefinitionTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.HierarchicDefinition Father
		{
			get => Dynamic.Tekla.Structures.Model.HierarchicDefinition_.FromTSObject(teklaObject.Father);
			set { teklaObject.Father = Dynamic.Tekla.Structures.Model.HierarchicDefinition_.GetTSObject(value); }
		}

		public System.String HierarchyIdentifier
		{
			get => teklaObject.HierarchyIdentifier;
			set { teklaObject.HierarchyIdentifier = value; }
		}

		public System.Boolean Drawable
		{
			get => teklaObject.Drawable;
			set { teklaObject.Drawable = value; }
		}

		public System.Collections.ArrayList HierarchicChildren
		{
			get => teklaObject.HierarchicChildren;
			set { teklaObject.HierarchicChildren = value; }
		}

        

        

		public HierarchicDefinition()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicDefinition");
		}
		public HierarchicDefinition(Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicDefinition", args);
		}

		public System.Boolean AddObjects(System.Collections.ArrayList Objects)
		{
			return teklaObject.AddObjects(Objects);
		}

		public System.Boolean RemoveObjects(System.Collections.ArrayList Objects)
		{
			return teklaObject.RemoveObjects(Objects);
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





    }

    internal static class HierarchicDefinition_
    {
        public static dynamic GetTSObject(HierarchicDefinition dynObject)
        {
            return dynObject.teklaObject;
        }

        public static HierarchicDefinition FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.HierarchicDefinition)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
