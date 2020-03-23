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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public InvalidPluginPickerInputException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.InvalidPluginPickerInputException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InvalidPluginPickerInputExceptionArray_
    {
        public static dynamic GetTSObject(InvalidPluginPickerInputException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InvalidPluginPickerInputException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InvalidPluginPickerInputException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<InvalidPluginPickerInputException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InvalidPluginPickerInputException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
