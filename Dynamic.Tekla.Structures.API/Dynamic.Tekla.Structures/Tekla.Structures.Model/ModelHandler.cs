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

		public System.Boolean CreateNewSingleUserModel(System.String ModelName, System.String ModelFolder, System.String Template)
		{
			return teklaObject.CreateNewSingleUserModel(ModelName, ModelFolder, Template);
		}

		public System.Boolean CreateNewMultiUserModel(System.String ModelName, System.String ModelFolder, System.String ServerName)
		{
			return teklaObject.CreateNewMultiUserModel(ModelName, ModelFolder, ServerName);
		}

		public System.Boolean Save(System.String Comment, System.String User)
		{
			return teklaObject.Save(Comment, User);
		}

		public System.Boolean Open(System.String ModelFolder, System.Boolean OpenAutoSaved)
		{
			return teklaObject.Open(ModelFolder, OpenAutoSaved);
		}

		public void Close()
		{
			teklaObject.Close();
		}

		public System.Boolean IsModelSaved()
		{
			return teklaObject.IsModelSaved();
		}

		public System.Boolean IsModelAutoSaved(System.String ModelFolder)
		{
			return teklaObject.IsModelAutoSaved(ModelFolder);
		}





    }

    internal static class ModelHandler_
    {
        public static dynamic GetTSObject(ModelHandler dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ModelHandler FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.ModelHandler)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ModelHandlerArray_
    {
        public static dynamic GetTSObject(ModelHandler[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ModelHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ModelHandler[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ModelHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ModelHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
