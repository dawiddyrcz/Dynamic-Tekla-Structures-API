/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CannotSetAttributeForPluginDueToIncorrectTypeException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public CannotSetAttributeForPluginDueToIncorrectTypeException() {}
		public CannotSetAttributeForPluginDueToIncorrectTypeException(System.Type ExpectedType, System.Type GivenType)
		{
			var args = new object[2];
			args[0] = ExpectedType;
			args[1] = GivenType;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CannotSetAttributeForPluginDueToIncorrectTypeException", args);
		}





    }

    internal static class CannotSetAttributeForPluginDueToIncorrectTypeException_
    {
        public static dynamic GetTSObject(CannotSetAttributeForPluginDueToIncorrectTypeException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CannotSetAttributeForPluginDueToIncorrectTypeException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.CannotSetAttributeForPluginDueToIncorrectTypeException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
