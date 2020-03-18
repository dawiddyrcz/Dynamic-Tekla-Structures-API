//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class UnknownLoftedPlateErrorException 
    {

		public System.String Message
		{
			get => unknownloftedplateerrorexception.Message;
			set { unknownloftedplateerrorexception.Message = value; }
		}

		public System.Collections.IDictionary Data
		{
			get => unknownloftedplateerrorexception.Data;
			set { unknownloftedplateerrorexception.Data = value; }
		}

		public System.Exception InnerException
		{
			get => unknownloftedplateerrorexception.InnerException;
			set { unknownloftedplateerrorexception.InnerException = value; }
		}

		public System.Reflection.MethodBase TargetSite
		{
			get => unknownloftedplateerrorexception.TargetSite;
			set { unknownloftedplateerrorexception.TargetSite = value; }
		}

		public System.String StackTrace
		{
			get => unknownloftedplateerrorexception.StackTrace;
			set { unknownloftedplateerrorexception.StackTrace = value; }
		}

		public System.String HelpLink
		{
			get => unknownloftedplateerrorexception.HelpLink;
			set { unknownloftedplateerrorexception.HelpLink = value; }
		}

		public System.String Source
		{
			get => unknownloftedplateerrorexception.Source;
			set { unknownloftedplateerrorexception.Source = value; }
		}

		public System.Int32 HResult
		{
			get => unknownloftedplateerrorexception.HResult;
			set { unknownloftedplateerrorexception.HResult = value; }
		}

        

        internal dynamic unknownloftedplateerrorexception;
        
        public UnknownLoftedPlateErrorException()
        {
            this.unknownloftedplateerrorexception =  TSActivator.CreateInstance("Tekla.Structures.Model.UnknownLoftedPlateErrorException");
        }

        internal UnknownLoftedPlateErrorException(dynamic tsObject)
        {
            this.unknownloftedplateerrorexception = tsObject;
        }

		public System.Exception GetBaseException()
			 => unknownloftedplateerrorexception.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => unknownloftedplateerrorexception.GetObjectData(info, context);





    }

    internal static class UnknownLoftedPlateErrorException_
    {
        public static dynamic GetTSObject(UnknownLoftedPlateErrorException dynObject)
        {
            return dynObject.unknownloftedplateerrorexception;
        }

        public static UnknownLoftedPlateErrorException FromTSObject(dynamic tsObject)
        {
            return new UnknownLoftedPlateErrorException(tsObject);
        }
    }


}
    
