/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CannotGetAttributeForPluginDueToIncorrectTypeException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public CannotGetAttributeForPluginDueToIncorrectTypeException() {}
		public CannotGetAttributeForPluginDueToIncorrectTypeException(System.Type ExpectedType, System.Type GivenType)
		{
			var args = new object[2];
			args[0] = ExpectedType;
			args[1] = GivenType;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CannotGetAttributeForPluginDueToIncorrectTypeException", args);
		}





    }

    internal static class CannotGetAttributeForPluginDueToIncorrectTypeException_
    {
        public static dynamic GetTSObject(CannotGetAttributeForPluginDueToIncorrectTypeException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CannotGetAttributeForPluginDueToIncorrectTypeException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CannotGetAttributeForPluginDueToIncorrectTypeException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CannotGetAttributeForPluginDueToIncorrectTypeExceptionArray_
    {
        public static dynamic GetTSObject(CannotGetAttributeForPluginDueToIncorrectTypeException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CannotGetAttributeForPluginDueToIncorrectTypeException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CannotGetAttributeForPluginDueToIncorrectTypeException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CannotGetAttributeForPluginDueToIncorrectTypeException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CannotGetAttributeForPluginDueToIncorrectTypeException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
