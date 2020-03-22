/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.History
{

    public abstract class ModelHistory 
    {

        

        internal dynamic teklaObject;


		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetModifiedObjects(Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetModifiedObjects(Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetModifiedObjectsWithType(Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp, Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum Enum)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetModifiedObjectsWithType(Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp), Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum_.GetTSObject(Enum)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDeletedObjects(Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetDeletedObjects(Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDeletedObjectsWithType(Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp, Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum Enum)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetDeletedObjectsWithType(Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp), Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum_.GetTSObject(Enum)));
		}

		public Dynamic.Tekla.Structures.Model.History.ModificationStamp GetCurrentModificationStamp()
		{
			return Dynamic.Tekla.Structures.Model.History.ModificationStamp_.FromTSObject(teklaObject.GetCurrentModificationStamp());
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetNotSharedObjects()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetNotSharedObjects());
		}

		public Dynamic.Tekla.Structures.Model.History.ModificationInfo GetLocalChanges()
		{
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(teklaObject.GetLocalChanges());
		}

		public Dynamic.Tekla.Structures.Model.History.ModificationInfo TakeModifications(System.String Name, Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp)
		{
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(teklaObject.TakeModifications(Name, Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp)));
		}

		public Dynamic.Tekla.Structures.Model.History.ModificationInfo TakeModifications(System.String Name, System.Collections.Generic.IEnumerable<Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum> ObjectTypes, Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp)
		{
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(teklaObject.TakeModifications(Name, ObjectTypes, Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp)));
		}

		public void UpdateModificationStampToLatest(System.String modificationStampKey)
		{
			teklaObject.UpdateModificationStampToLatest(modificationStampKey);
		}

		public Dynamic.Tekla.Structures.Model.History.ModificationInfo GetModifications(System.String Name, Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp)
		{
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(teklaObject.GetModifications(Name, Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp)));
		}

		public Dynamic.Tekla.Structures.Model.History.ModificationInfo GetModifications(System.String Name, System.Collections.Generic.IEnumerable<Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum> ObjectTypes, Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp)
		{
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(teklaObject.GetModifications(Name, ObjectTypes, Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp)));
		}





    }

    internal static class ModelHistory_
    {
        public static dynamic GetTSObject(ModelHistory dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ModelHistory FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.History.ModelHistory)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
