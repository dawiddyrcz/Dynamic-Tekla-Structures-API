/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ReferenceModelObject  : Dynamic.Tekla.Structures.Model.ModelObject
    {

        

        

		public ReferenceModelObject()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModelObject");
		}
		public ReferenceModelObject(System.Int32 ReferenceModelId, Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[2];
			args[0] = ReferenceModelId;
			args[1] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModelObject", args);
		}

		public Dynamic.Tekla.Structures.Model.ReferenceModel GetReferenceModel()
		{
			return Dynamic.Tekla.Structures.Model.ReferenceModel_.FromTSObject(teklaObject.GetReferenceModel());
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

		public Dynamic.Tekla.Structures.Model.ReferenceModelObject GetFather()
		{
			return Dynamic.Tekla.Structures.Model.ReferenceModelObject_.FromTSObject(teklaObject.GetFather());
		}





    }

    internal static class ReferenceModelObject_
    {
        public static dynamic GetTSObject(ReferenceModelObject dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReferenceModelObject FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ReferenceModelObject)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
