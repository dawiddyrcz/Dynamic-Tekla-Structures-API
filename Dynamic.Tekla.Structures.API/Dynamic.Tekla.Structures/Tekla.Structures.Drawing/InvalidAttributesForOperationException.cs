/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class InvalidAttributesForOperationException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public InvalidAttributesForOperationException() {}
		public InvalidAttributesForOperationException(System.String Message)
		{
			var args = new object[1];
			args[0] = Message;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.InvalidAttributesForOperationException", args);
		}





    }

    internal static class InvalidAttributesForOperationException_
    {
        public static dynamic GetTSObject(InvalidAttributesForOperationException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InvalidAttributesForOperationException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.InvalidAttributesForOperationException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InvalidAttributesForOperationExceptionArray_
    {
        public static dynamic GetTSObject(InvalidAttributesForOperationException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InvalidAttributesForOperationException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InvalidAttributesForOperationException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<InvalidAttributesForOperationException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InvalidAttributesForOperationException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
