/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ModelHandler 
    {

        

        internal dynamic teklaObject;

		public ModelHandler()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ModelHandler");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ModelHandler(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean CreateNewSingleUserModel(System.String ModelName, System.String ModelFolder, System.String Template)
		{
			try {
			return teklaObject.CreateNewSingleUserModel(ModelName, ModelFolder, Template);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CreateNewSingleUserModel()"); }
		}

		public System.Boolean CreateNewMultiUserModel(System.String ModelName, System.String ModelFolder, System.String ServerName)
		{
			try {
			return teklaObject.CreateNewMultiUserModel(ModelName, ModelFolder, ServerName);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CreateNewMultiUserModel()"); }
		}

		public System.Boolean Save(System.String Comment, System.String User)
		{
			try {
			return teklaObject.Save(Comment, User);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Save()"); }
		}

		public System.Boolean Open(System.String ModelFolder, System.Boolean OpenAutoSaved)
		{
			try {
			return teklaObject.Open(ModelFolder, OpenAutoSaved);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Open()"); }
		}

		public void Close()
		{
			try {
			teklaObject.Close();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Close()"); }
		}

		public System.Boolean IsModelSaved()
		{
			try {
			return teklaObject.IsModelSaved();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsModelSaved()"); }
		}

		public System.Boolean IsModelAutoSaved(System.String ModelFolder)
		{
			try {
			return teklaObject.IsModelAutoSaved(ModelFolder);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsModelAutoSaved()"); }
		}





    }

    internal static class ModelHandler_
    {
        public static dynamic GetTSObject(ModelHandler dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ModelHandler FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ModelHandler)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelHandlerArray_
    {
        public static dynamic GetTSObject(ModelHandler[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelHandler[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ModelHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
