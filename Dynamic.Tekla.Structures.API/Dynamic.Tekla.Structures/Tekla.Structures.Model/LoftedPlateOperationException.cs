//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class LoftedPlateOperationException 
    {

		public System.String Message
		{
			get => loftedplateoperationexception.Message;
			set { loftedplateoperationexception.Message = value; }
		}

		public System.Collections.IDictionary Data
		{
			get => loftedplateoperationexception.Data;
			set { loftedplateoperationexception.Data = value; }
		}

		public System.Exception InnerException
		{
			get => loftedplateoperationexception.InnerException;
			set { loftedplateoperationexception.InnerException = value; }
		}

		public System.Reflection.MethodBase TargetSite
		{
			get => loftedplateoperationexception.TargetSite;
			set { loftedplateoperationexception.TargetSite = value; }
		}

		public System.String StackTrace
		{
			get => loftedplateoperationexception.StackTrace;
			set { loftedplateoperationexception.StackTrace = value; }
		}

		public System.String HelpLink
		{
			get => loftedplateoperationexception.HelpLink;
			set { loftedplateoperationexception.HelpLink = value; }
		}

		public System.String Source
		{
			get => loftedplateoperationexception.Source;
			set { loftedplateoperationexception.Source = value; }
		}

		public System.Int32 HResult
		{
			get => loftedplateoperationexception.HResult;
			set { loftedplateoperationexception.HResult = value; }
		}

        

        internal dynamic loftedplateoperationexception;
        
        private LoftedPlateOperationException()
        {
            this.loftedplateoperationexception =  TSActivator.CreateInstance("Tekla.Structures.Model.LoftedPlateOperationException");
        }

        internal LoftedPlateOperationException(dynamic tsObject)
        {
            this.loftedplateoperationexception = tsObject;
        }

		public System.Exception GetBaseException()
			 => loftedplateoperationexception.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => loftedplateoperationexception.GetObjectData(info, context);





    }

    internal static class LoftedPlateOperationException_
    {
        public static dynamic GetTSObject(LoftedPlateOperationException dynObject)
        {
            return dynObject.loftedplateoperationexception;
        }

        public static LoftedPlateOperationException FromTSObject(dynamic tsObject)
        {
            return new LoftedPlateOperationException(tsObject);
        }
    }


}
    