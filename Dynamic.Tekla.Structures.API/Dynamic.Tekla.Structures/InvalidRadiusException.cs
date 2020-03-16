//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class InvalidRadiusException 
    {

		public System.String Message
		{
			get => invalidradiusexception.Message;
			set { invalidradiusexception.Message = value; }
		}

		public System.Collections.IDictionary Data
		{
			get => invalidradiusexception.Data;
			set { invalidradiusexception.Data = value; }
		}

		public System.Exception InnerException
		{
			get => invalidradiusexception.InnerException;
			set { invalidradiusexception.InnerException = value; }
		}

		public System.Reflection.MethodBase TargetSite
		{
			get => invalidradiusexception.TargetSite;
			set { invalidradiusexception.TargetSite = value; }
		}

		public System.String StackTrace
		{
			get => invalidradiusexception.StackTrace;
			set { invalidradiusexception.StackTrace = value; }
		}

		public System.String HelpLink
		{
			get => invalidradiusexception.HelpLink;
			set { invalidradiusexception.HelpLink = value; }
		}

		public System.String Source
		{
			get => invalidradiusexception.Source;
			set { invalidradiusexception.Source = value; }
		}

		public System.Int32 HResult
		{
			get => invalidradiusexception.HResult;
			set { invalidradiusexception.HResult = value; }
		}

        

        dynamic invalidradiusexception;
        
        public InvalidRadiusException()
        {
            this.invalidradiusexception =  new Tekla.Structures.Model.InvalidRadiusException();
        }

        public InvalidRadiusException(dynamic tsObject)
        {
            this.invalidradiusexception = tsObject;
			this.Message = invalidradiusexception.Message;
			this.Data = invalidradiusexception.Data;
			this.InnerException = invalidradiusexception.InnerException;
			this.TargetSite = invalidradiusexception.TargetSite;
			this.StackTrace = invalidradiusexception.StackTrace;
			this.HelpLink = invalidradiusexception.HelpLink;
			this.Source = invalidradiusexception.Source;
			this.HResult = invalidradiusexception.HResult;

        }


        public dynamic GetTSObject() => invalidradiusexception;

		public System.Exception GetBaseException()
			 => invalidradiusexception.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => invalidradiusexception.GetObjectData(info, context);





    }

}
    
