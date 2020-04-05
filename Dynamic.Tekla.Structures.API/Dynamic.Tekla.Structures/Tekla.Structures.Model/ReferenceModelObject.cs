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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReferenceModelObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReferenceModelObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ReferenceModelObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelObjectArray_
    {
        public static dynamic GetTSObject(ReferenceModelObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModelObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModelObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReferenceModelObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModelObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
