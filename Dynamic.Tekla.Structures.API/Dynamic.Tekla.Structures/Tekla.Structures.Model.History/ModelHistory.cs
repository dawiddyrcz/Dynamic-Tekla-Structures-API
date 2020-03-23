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


		public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetModifiedObjects(Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetModifiedObjects", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetModifiedObjectsWithType(Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp, Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum Enum)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp);
			parameters[1] = Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum_.GetTSObject(Enum);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetModifiedObjectsWithType", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDeletedObjects(Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetDeletedObjects", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDeletedObjectsWithType(Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp, Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum Enum)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp);
			parameters[1] = Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum_.GetTSObject(Enum);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetDeletedObjectsWithType", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.History.ModificationStamp GetCurrentModificationStamp()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetCurrentModificationStamp", parameters);
			return Dynamic.Tekla.Structures.Model.History.ModificationStamp_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetNotSharedObjects()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetNotSharedObjects", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.History.ModificationInfo GetLocalChanges()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetLocalChanges", parameters);
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.History.ModificationInfo TakeModifications(System.String Name, Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp)
		{
			var parameters = new object[2];
			parameters[0] = Name;
			parameters[1] = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "TakeModifications", parameters);
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.History.ModificationInfo TakeModifications(System.String Name, System.Collections.Generic.IEnumerable<Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum> ObjectTypes, Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp)
		{
			var parameters = new object[3];
			parameters[0] = Name;
			parameters[1] = ObjectTypes;
			parameters[2] = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "TakeModifications", parameters);
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
		}

		public static void UpdateModificationStampToLatest(System.String modificationStampKey)
		{
			var parameters = new object[1];
			parameters[0] = modificationStampKey;
			TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "UpdateModificationStampToLatest", parameters);
		}

		public static Dynamic.Tekla.Structures.Model.History.ModificationInfo GetModifications(System.String Name, Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp)
		{
			var parameters = new object[2];
			parameters[0] = Name;
			parameters[1] = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetModifications", parameters);
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.History.ModificationInfo GetModifications(System.String Name, System.Collections.Generic.IEnumerable<Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum> ObjectTypes, Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp)
		{
			var parameters = new object[3];
			parameters[0] = Name;
			parameters[1] = ObjectTypes;
			parameters[2] = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetModifications", parameters);
			return Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
		}





    }

    internal static class ModelHistory_
    {
        public static dynamic GetTSObject(ModelHistory dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ModelHistory FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.History.ModelHistory)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelHistoryArray_
    {
        public static dynamic GetTSObject(ModelHistory[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelHistory_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelHistory[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ModelHistory>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelHistory_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
