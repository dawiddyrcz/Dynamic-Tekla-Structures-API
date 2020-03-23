/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class InvalidTypeException  : Dynamic.Tekla.Structures.Drawing.TeklaStructuresDrawingsApplicationException
    {

        

        

		public InvalidTypeException() {}
		public InvalidTypeException(System.String Message)
		{
			var args = new object[1];
			args[0] = Message;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.InvalidTypeException", args);
		}





    }

    internal static class InvalidTypeException_
    {
        public static dynamic GetTSObject(InvalidTypeException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InvalidTypeException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.InvalidTypeException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InvalidTypeExceptionArray_
    {
        public static dynamic GetTSObject(InvalidTypeException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InvalidTypeException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InvalidTypeException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<InvalidTypeException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InvalidTypeException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
