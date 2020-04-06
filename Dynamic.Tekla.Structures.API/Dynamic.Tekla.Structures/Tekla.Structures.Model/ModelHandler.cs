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
			var result = teklaObject.CreateNewSingleUserModel(ModelName, ModelFolder, Template);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CreateNewSingleUserModel()", ex); }
		}

		public System.Boolean CreateNewMultiUserModel(System.String ModelName, System.String ModelFolder, System.String ServerName)
		{
			try {
			var result = teklaObject.CreateNewMultiUserModel(ModelName, ModelFolder, ServerName);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CreateNewMultiUserModel()", ex); }
		}

		public System.Boolean Save(System.String Comment, System.String User)
		{
			try {
			var result = teklaObject.Save(Comment, User);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Save()", ex); }
		}

		public System.Boolean Open(System.String ModelFolder, System.Boolean OpenAutoSaved)
		{
			try {
			var result = teklaObject.Open(ModelFolder, OpenAutoSaved);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Open()", ex); }
		}

		public void Close()
		{
			try {
			teklaObject.Close();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Close()", ex); }
		}

		public System.Boolean IsModelSaved()
		{
			try {
			var result = teklaObject.IsModelSaved();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsModelSaved()", ex); }
		}

		public System.Boolean IsModelAutoSaved(System.String ModelFolder)
		{
			try {
			var result = teklaObject.IsModelAutoSaved(ModelFolder);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsModelAutoSaved()", ex); }
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
    
