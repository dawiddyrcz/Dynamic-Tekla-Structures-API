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



public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetModifiedObjects(
	Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp_
	)
{
	var ModStamp = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetModifiedObjects", ModStamp);
	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetModifiedObjectsWithType(
	Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp_,
	Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum Enum_
	)
{
	var ModStamp = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp_);
	var Enum = Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum_.GetTSObject(Enum_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetModifiedObjectsWithType", ModStamp, Enum);
	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDeletedObjects(
	Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp_
	)
{
	var ModStamp = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetDeletedObjects", ModStamp);
	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetDeletedObjectsWithType(
	Dynamic.Tekla.Structures.Model.History.ModificationStamp ModStamp_,
	Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum Enum_
	)
{
	var ModStamp = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(ModStamp_);
	var Enum = Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum_.GetTSObject(Enum_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetDeletedObjectsWithType", ModStamp, Enum);
	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.History.ModificationStamp GetCurrentModificationStamp()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetCurrentModificationStamp");
	var _result = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetNotSharedObjects()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetNotSharedObjects");
	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.History.ModificationInfo GetLocalChanges()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetLocalChanges");
	var _result = Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.History.ModificationInfo TakeModifications(
	System.String Name,
	Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp_
	)
{
	
	var PrevStamp = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "TakeModifications", Name, PrevStamp);
	var _result = Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.History.ModificationInfo TakeModifications(
	System.String Name,
	System.Collections.Generic.IEnumerable<Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum> ObjectTypes_,
	Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp_
	)
{
	
	var ObjectTypes = IEnumerableConverter.ToTSObjects<System.Collections.Generic.IEnumerable<Tekla.Structures.Model.ModelObject.ModelObjectEnum>>(ObjectTypes_);
	var PrevStamp = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "TakeModifications", Name, ObjectTypes, PrevStamp);
	var _result = Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
	return _result;
}



public static void UpdateModificationStampToLatest(
	System.String modificationStampKey
	)
{
	
	MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "UpdateModificationStampToLatest", modificationStampKey);

}



public static Dynamic.Tekla.Structures.Model.History.ModificationInfo GetModifications(
	System.String Name,
	Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp_
	)
{
	
	var PrevStamp = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetModifications", Name, PrevStamp);
	var _result = Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.History.ModificationInfo GetModifications(
	System.String Name,
	System.Collections.Generic.IEnumerable<Dynamic.Tekla.Structures.Model.ModelObject.ModelObjectEnum> ObjectTypes_,
	Dynamic.Tekla.Structures.Model.History.ModificationStamp PrevStamp_
	)
{
	
	var ObjectTypes = IEnumerableConverter.ToTSObjects<System.Collections.Generic.IEnumerable<Tekla.Structures.Model.ModelObject.ModelObjectEnum>>(ObjectTypes_);
	var PrevStamp = Dynamic.Tekla.Structures.Model.History.ModificationStamp_.GetTSObject(PrevStamp_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.History.ModelHistory", "GetModifications", Name, ObjectTypes, PrevStamp);
	var _result = Dynamic.Tekla.Structures.Model.History.ModificationInfo_.FromTSObject(result);
	return _result;
}






    }

    internal static class ModelHistory_
    {
        public static dynamic GetTSObject(ModelHistory dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelHistory FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelHistory_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelHistory[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelHistory>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelHistory_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
