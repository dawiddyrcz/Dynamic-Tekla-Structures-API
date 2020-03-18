//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public sealed class Assertion 
    {

		public System.String Message
		{
			get => assertion.Message;
			set { assertion.Message = value; }
		}

		public System.String DetailedMessage
		{
			get => assertion.DetailedMessage;
			set { assertion.DetailedMessage = value; }
		}

		public System.String MethodName
		{
			get => assertion.MethodName;
			set { assertion.MethodName = value; }
		}

        

        internal dynamic assertion;
        
        public Assertion()
        {
            this.assertion =  TSActivator.CreateInstance("Tekla.Structures.Assertion");
        }

        internal Assertion(dynamic tsObject)
        {
            this.assertion = tsObject;
        }





    }

    internal static class Assertion_
    {
        public static dynamic GetTSObject(Assertion dynObject)
        {
            return dynObject.assertion;
        }

        public static Assertion FromTSObject(dynamic tsObject)
        {
            return new Assertion(tsObject);
        }
    }


}
    