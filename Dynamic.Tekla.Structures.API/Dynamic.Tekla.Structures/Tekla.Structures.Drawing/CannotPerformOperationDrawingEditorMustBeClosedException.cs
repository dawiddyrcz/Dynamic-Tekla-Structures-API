/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CannotPerformOperationDrawingEditorMustBeClosedException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public CannotPerformOperationDrawingEditorMustBeClosedException() {}
		public CannotPerformOperationDrawingEditorMustBeClosedException(System.String Message)
		{
			var args = new object[1];
			args[0] = Message;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CannotPerformOperationDrawingEditorMustBeClosedException", args);
		}





    }

    internal static class CannotPerformOperationDrawingEditorMustBeClosedException_
    {
        public static dynamic GetTSObject(CannotPerformOperationDrawingEditorMustBeClosedException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CannotPerformOperationDrawingEditorMustBeClosedException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CannotPerformOperationDrawingEditorMustBeClosedException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    