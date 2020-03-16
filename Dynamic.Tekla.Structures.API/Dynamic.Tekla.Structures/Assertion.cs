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

        

        dynamic assertion;
        
        public Assertion()
        {
            this.assertion =  new Tekla.Structures.Assertion();
        }

        public Assertion(dynamic tsObject)
        {
            this.assertion = tsObject;
			this.Message = assertion.Message;
			this.DetailedMessage = assertion.DetailedMessage;
			this.MethodName = assertion.MethodName;

        }


        public dynamic GetTSObject() => assertion;





    }

}
    
