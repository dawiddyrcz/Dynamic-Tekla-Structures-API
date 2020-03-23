/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CannotPerformOperationDrawingMustBeActiveException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public CannotPerformOperationDrawingMustBeActiveException() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CannotPerformOperationDrawingMustBeActiveException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public CannotPerformOperationDrawingMustBeActiveException(System.String Message)
		{
			var args = new object[1];
			args[0] = Message;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CannotPerformOperationDrawingMustBeActiveException", args);
		}





    }

    internal static class CannotPerformOperationDrawingMustBeActiveException_
    {
        public static dynamic GetTSObject(CannotPerformOperationDrawingMustBeActiveException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CannotPerformOperationDrawingMustBeActiveException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CannotPerformOperationDrawingMustBeActiveException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CannotPerformOperationDrawingMustBeActiveExceptionArray_
    {
        public static dynamic GetTSObject(CannotPerformOperationDrawingMustBeActiveException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CannotPerformOperationDrawingMustBeActiveException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CannotPerformOperationDrawingMustBeActiveException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CannotPerformOperationDrawingMustBeActiveException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CannotPerformOperationDrawingMustBeActiveException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
