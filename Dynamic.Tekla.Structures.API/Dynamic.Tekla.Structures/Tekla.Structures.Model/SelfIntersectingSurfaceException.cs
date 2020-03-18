//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class SelfIntersectingSurfaceException 
    {

		public System.String Message
		{
			get => selfintersectingsurfaceexception.Message;
			set { selfintersectingsurfaceexception.Message = value; }
		}

		public System.Collections.IDictionary Data
		{
			get => selfintersectingsurfaceexception.Data;
			set { selfintersectingsurfaceexception.Data = value; }
		}

		public System.Exception InnerException
		{
			get => selfintersectingsurfaceexception.InnerException;
			set { selfintersectingsurfaceexception.InnerException = value; }
		}

		public System.Reflection.MethodBase TargetSite
		{
			get => selfintersectingsurfaceexception.TargetSite;
			set { selfintersectingsurfaceexception.TargetSite = value; }
		}

		public System.String StackTrace
		{
			get => selfintersectingsurfaceexception.StackTrace;
			set { selfintersectingsurfaceexception.StackTrace = value; }
		}

		public System.String HelpLink
		{
			get => selfintersectingsurfaceexception.HelpLink;
			set { selfintersectingsurfaceexception.HelpLink = value; }
		}

		public System.String Source
		{
			get => selfintersectingsurfaceexception.Source;
			set { selfintersectingsurfaceexception.Source = value; }
		}

		public System.Int32 HResult
		{
			get => selfintersectingsurfaceexception.HResult;
			set { selfintersectingsurfaceexception.HResult = value; }
		}

        

        dynamic selfintersectingsurfaceexception;
        
        public SelfIntersectingSurfaceException()
        {
            this.selfintersectingsurfaceexception =  TSActivator.CreateInstance("Tekla.Structures.Model.SelfIntersectingSurfaceException");
        }

        public SelfIntersectingSurfaceException(dynamic tsObject)
        {
            this.selfintersectingsurfaceexception = tsObject;
        }

        internal dynamic GetTSObject() => selfintersectingsurfaceexception;

		public System.Exception GetBaseException()
			 => selfintersectingsurfaceexception.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => selfintersectingsurfaceexception.GetObjectData(info, context);





    }

}
    
