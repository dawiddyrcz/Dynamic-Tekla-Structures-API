/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Model 
    {

        

        internal dynamic teklaObject;

		public Model()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Model");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Model(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean GetConnectionStatus()
{

    try
    {
        	var result = teklaObject.GetConnectionStatus();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetConnectionStatus), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelInfo GetInfo()
{

    try
    {
        	var result = teklaObject.GetInfo();

        	var _result = Dynamic.Tekla.Structures.Model.ModelInfo_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetInfo), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ProjectInfo GetProjectInfo()
{

    try
    {
        	var result = teklaObject.GetProjectInfo();

        	var _result = Dynamic.Tekla.Structures.Model.ProjectInfo_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetProjectInfo), ex);
    }
}



public Dynamic.Tekla.Structures.Model.PhaseCollection GetPhases()
{

    try
    {
        	var result = teklaObject.GetPhases();

        	var _result = Dynamic.Tekla.Structures.Model.PhaseCollection_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPhases), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObjectSelector GetModelObjectSelector()
{

    try
    {
        	var result = teklaObject.GetModelObjectSelector();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectSelector_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetModelObjectSelector), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ModelObject SelectModelObject(
	Dynamic.Tekla.Structures.Identifier ID_
	)
{
	var ID = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID_);
    try
    {
        	var result = teklaObject.SelectModelObject(ID);

        	var _result = Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SelectModelObject), ex);
    }
}



public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> FetchModelObjects(
	System.Collections.Generic.List<System.String> Guids,
	System.Boolean SelectInstances
	)
{
	
	
    try
    {
        	var result = teklaObject.FetchModelObjects(Guids, SelectInstances);

        	var _result = IEnumerableConverter.FromTSObjects<System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject>>(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(FetchModelObjects), ex);
    }
}



public Dynamic.Tekla.Structures.Identifier GetIdentifierByGUID(
	System.String guid
	)
{
	
    try
    {
        	var result = teklaObject.GetIdentifierByGUID(guid);

        	var _result = Dynamic.Tekla.Structures.Identifier_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetIdentifierByGUID), ex);
    }
}



public System.String GetGUIDByIdentifier(
	Dynamic.Tekla.Structures.Identifier identifier_
	)
{
	var identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(identifier_);
    try
    {
        	var result = teklaObject.GetGUIDByIdentifier(identifier);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetGUIDByIdentifier), ex);
    }
}



public System.Boolean CommitChanges()
{

    try
    {
        	var result = teklaObject.CommitChanges();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CommitChanges), ex);
    }
}



public System.Boolean CommitChanges(
	System.String Message
	)
{
	
    try
    {
        	var result = teklaObject.CommitChanges(Message);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CommitChanges), ex);
    }
}



public Dynamic.Tekla.Structures.Model.WorkPlaneHandler GetWorkPlaneHandler()
{

    try
    {
        	var result = teklaObject.GetWorkPlaneHandler();

        	var _result = Dynamic.Tekla.Structures.Model.WorkPlaneHandler_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetWorkPlaneHandler), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ClashCheckHandler GetClashCheckHandler()
{

    try
    {
        	var result = teklaObject.GetClashCheckHandler();

        	var _result = Dynamic.Tekla.Structures.Model.ClashCheckHandler_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetClashCheckHandler), ex);
    }
}






    }

    internal static class Model_
    {
        public static dynamic GetTSObject(Model dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Model FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Model)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelArray_
    {
        public static dynamic GetTSObject(Model[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Model_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Model[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Model>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Model_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
