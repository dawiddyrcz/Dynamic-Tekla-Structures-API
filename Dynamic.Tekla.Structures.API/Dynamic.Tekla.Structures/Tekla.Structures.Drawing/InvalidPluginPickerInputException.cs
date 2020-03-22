/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class InvalidPluginPickerInputException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public InvalidPluginPickerInputException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.InvalidPluginPickerInputException");
		}





    }

    internal static class InvalidPluginPickerInputException_
    {
        public static dynamic GetTSObject(InvalidPluginPickerInputException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InvalidPluginPickerInputException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.InvalidPluginPickerInputException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
