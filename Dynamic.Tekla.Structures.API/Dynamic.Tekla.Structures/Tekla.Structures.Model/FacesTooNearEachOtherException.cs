//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class FacesTooNearEachOtherException 
    {

		public System.String Message
		{
			get => facestooneareachotherexception.Message;
			set { facestooneareachotherexception.Message = value; }
		}

		public System.Collections.IDictionary Data
		{
			get => facestooneareachotherexception.Data;
			set { facestooneareachotherexception.Data = value; }
		}

		public System.Exception InnerException
		{
			get => facestooneareachotherexception.InnerException;
			set { facestooneareachotherexception.InnerException = value; }
		}

		public System.Reflection.MethodBase TargetSite
		{
			get => facestooneareachotherexception.TargetSite;
			set { facestooneareachotherexception.TargetSite = value; }
		}

		public System.String StackTrace
		{
			get => facestooneareachotherexception.StackTrace;
			set { facestooneareachotherexception.StackTrace = value; }
		}

		public System.String HelpLink
		{
			get => facestooneareachotherexception.HelpLink;
			set { facestooneareachotherexception.HelpLink = value; }
		}

		public System.String Source
		{
			get => facestooneareachotherexception.Source;
			set { facestooneareachotherexception.Source = value; }
		}

		public System.Int32 HResult
		{
			get => facestooneareachotherexception.HResult;
			set { facestooneareachotherexception.HResult = value; }
		}

        

        dynamic facestooneareachotherexception;
        
        public FacesTooNearEachOtherException()
        {
            this.facestooneareachotherexception =  TSActivator.CreateInstance("Tekla.Structures.Model.FacesTooNearEachOtherException");
        }

        public FacesTooNearEachOtherException(dynamic tsObject)
        {
            this.facestooneareachotherexception = tsObject;
        }

        internal dynamic GetTSObject() => facestooneareachotherexception;

		public System.Exception GetBaseException()
			 => facestooneareachotherexception.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => facestooneareachotherexception.GetObjectData(info, context);





    }

}
    
