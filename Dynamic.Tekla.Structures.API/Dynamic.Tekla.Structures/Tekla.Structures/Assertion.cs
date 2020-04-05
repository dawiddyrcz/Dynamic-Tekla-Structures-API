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
			get
			{
				try {
					return teklaObject.Message;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Message"); }
			}
			set
			{
				try {
					teklaObject.Message = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Message"); }
			}
		}

		public System.String DetailedMessage
		{
			get
			{
				try {
					return teklaObject.DetailedMessage;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DetailedMessage"); }
			}
			set
			{
				try {
					teklaObject.DetailedMessage = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DetailedMessage"); }
			}
		}

		public System.String MethodName
		{
			get
			{
				try {
					return teklaObject.MethodName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MethodName"); }
			}
			set
			{
				try {
					teklaObject.MethodName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MethodName"); }
			}
		}

        

        internal dynamic teklaObject;

		internal Assertion() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Assertion(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Assertion FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Assertion)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class AssertionArray_
    {
        public static dynamic GetTSObject(Assertion[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Assertion_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Assertion[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Assertion>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Assertion_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
