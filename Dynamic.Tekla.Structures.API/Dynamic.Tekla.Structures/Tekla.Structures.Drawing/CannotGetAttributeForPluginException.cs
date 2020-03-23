/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CannotGetAttributeForPluginException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public CannotGetAttributeForPluginException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CannotGetAttributeForPluginException");
		}
		public CannotGetAttributeForPluginException(System.String Description)
		{
			var args = new object[1];
			args[0] = Description;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CannotGetAttributeForPluginException", args);
		}





    }

    internal static class CannotGetAttributeForPluginException_
    {
        public static dynamic GetTSObject(CannotGetAttributeForPluginException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CannotGetAttributeForPluginException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CannotGetAttributeForPluginException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CannotGetAttributeForPluginExceptionArray_
    {
        public static dynamic GetTSObject(CannotGetAttributeForPluginException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CannotGetAttributeForPluginException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CannotGetAttributeForPluginException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CannotGetAttributeForPluginException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CannotGetAttributeForPluginException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
