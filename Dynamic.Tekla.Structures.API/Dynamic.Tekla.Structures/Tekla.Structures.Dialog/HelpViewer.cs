/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Dialog
{

    public abstract class HelpViewer 
    {

        

        internal dynamic teklaObject;


		public static System.Boolean DisplayHelpTopic(System.String helpTopic)
		{
			var parameters = new object[1];
			parameters[0] = helpTopic;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Dialog.HelpViewer", "DisplayHelpTopic", parameters);
			return result;
		}

		public static System.Boolean DisplayHelpTopicIndependent(System.String helpViewerFilePath, System.String helpTopic, System.String language)
		{
			var parameters = new object[3];
			parameters[0] = helpViewerFilePath;
			parameters[1] = helpTopic;
			parameters[2] = language;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Dialog.HelpViewer", "DisplayHelpTopicIndependent", parameters);
			return result;
		}





    }

    internal static class HelpViewer_
    {
        public static dynamic GetTSObject(HelpViewer dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static HelpViewer FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Dialog.HelpViewer)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class HelpViewerArray_
    {
        public static dynamic GetTSObject(HelpViewer[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(HelpViewer_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static HelpViewer[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<HelpViewer>();
            foreach(var tsItem in tsArray)
            {
                list.Add(HelpViewer_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
