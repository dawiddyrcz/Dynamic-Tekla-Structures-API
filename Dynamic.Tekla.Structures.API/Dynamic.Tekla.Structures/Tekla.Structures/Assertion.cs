/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class Assertion 
    {

		public System.String Message
		{
			get => teklaObject.Message;
			set { teklaObject.Message = value; }
		}

		public System.String DetailedMessage
		{
			get => teklaObject.DetailedMessage;
			set { teklaObject.DetailedMessage = value; }
		}

		public System.String MethodName
		{
			get => teklaObject.MethodName;
			set { teklaObject.MethodName = value; }
		}

        

        internal dynamic teklaObject;

		public Assertion() {}
		public Assertion(System.String message, System.String detailedMessage, System.String methodName)
		{
			var args = new object[3];
			args[0] = message;
			args[1] = detailedMessage;
			args[2] = methodName;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Assertion", args);
		}





    }

    internal static class Assertion_
    {
        public static dynamic GetTSObject(Assertion dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Assertion FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Assertion)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
