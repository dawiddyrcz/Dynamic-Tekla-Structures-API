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
			try {
			return teklaObject.GetConnectionStatus();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetConnectionStatus()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelInfo GetInfo()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelInfo_.FromTSObject(teklaObject.GetInfo());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetInfo()"); }
		}

		public Dynamic.Tekla.Structures.Model.ProjectInfo GetProjectInfo()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ProjectInfo_.FromTSObject(teklaObject.GetProjectInfo());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetProjectInfo()"); }
		}

		public Dynamic.Tekla.Structures.Model.PhaseCollection GetPhases()
		{
			try {
			return Dynamic.Tekla.Structures.Model.PhaseCollection_.FromTSObject(teklaObject.GetPhases());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPhases()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectSelector GetModelObjectSelector()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectSelector_.FromTSObject(teklaObject.GetModelObjectSelector());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetModelObjectSelector()"); }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject SelectModelObject(Dynamic.Tekla.Structures.Identifier ID)
		{
			try {
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.SelectModelObject(Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SelectModelObject()"); }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> FetchModelObjects(System.Collections.Generic.List<System.String> Guids, System.Boolean SelectInstances)
		{
			try {
			return teklaObject.FetchModelObjects(Guids, SelectInstances);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("FetchModelObjects()"); }
		}

		public Dynamic.Tekla.Structures.Identifier GetIdentifierByGUID(System.String guid)
		{
			try {
			return Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.GetIdentifierByGUID(guid));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetIdentifierByGUID()"); }
		}

		public System.String GetGUIDByIdentifier(Dynamic.Tekla.Structures.Identifier identifier)
		{
			try {
			return teklaObject.GetGUIDByIdentifier(Dynamic.Tekla.Structures.Identifier_.GetTSObject(identifier));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetGUIDByIdentifier()"); }
		}

		public System.Boolean CommitChanges()
		{
			try {
			return teklaObject.CommitChanges();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CommitChanges()"); }
		}

		public System.Boolean CommitChanges(System.String Message)
		{
			try {
			return teklaObject.CommitChanges(Message);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CommitChanges()"); }
		}

		public Dynamic.Tekla.Structures.Model.WorkPlaneHandler GetWorkPlaneHandler()
		{
			try {
			return Dynamic.Tekla.Structures.Model.WorkPlaneHandler_.FromTSObject(teklaObject.GetWorkPlaneHandler());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetWorkPlaneHandler()"); }
		}

		public Dynamic.Tekla.Structures.Model.ClashCheckHandler GetClashCheckHandler()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ClashCheckHandler_.FromTSObject(teklaObject.GetClashCheckHandler());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetClashCheckHandler()"); }
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
    
