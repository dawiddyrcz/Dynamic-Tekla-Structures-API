//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class SpiralBeamDataException 
    {

		public System.String Message
		{
			get => spiralbeamdataexception.Message;
			set { spiralbeamdataexception.Message = value; }
		}

		public System.Collections.IDictionary Data
		{
			get => spiralbeamdataexception.Data;
			set { spiralbeamdataexception.Data = value; }
		}

		public System.Exception InnerException
		{
			get => spiralbeamdataexception.InnerException;
			set { spiralbeamdataexception.InnerException = value; }
		}

		public System.Reflection.MethodBase TargetSite
		{
			get => spiralbeamdataexception.TargetSite;
			set { spiralbeamdataexception.TargetSite = value; }
		}

		public System.String StackTrace
		{
			get => spiralbeamdataexception.StackTrace;
			set { spiralbeamdataexception.StackTrace = value; }
		}

		public System.String HelpLink
		{
			get => spiralbeamdataexception.HelpLink;
			set { spiralbeamdataexception.HelpLink = value; }
		}

		public System.String Source
		{
			get => spiralbeamdataexception.Source;
			set { spiralbeamdataexception.Source = value; }
		}

		public System.Int32 HResult
		{
			get => spiralbeamdataexception.HResult;
			set { spiralbeamdataexception.HResult = value; }
		}

        

        dynamic spiralbeamdataexception;
        
        public SpiralBeamDataException()
        {
            this.spiralbeamdataexception =  new Tekla.Structures.Model.SpiralBeamDataException();
        }

        public SpiralBeamDataException(dynamic tsObject)
        {
            this.spiralbeamdataexception = tsObject;
			this.Message = spiralbeamdataexception.Message;
			this.Data = spiralbeamdataexception.Data;
			this.InnerException = spiralbeamdataexception.InnerException;
			this.TargetSite = spiralbeamdataexception.TargetSite;
			this.StackTrace = spiralbeamdataexception.StackTrace;
			this.HelpLink = spiralbeamdataexception.HelpLink;
			this.Source = spiralbeamdataexception.Source;
			this.HResult = spiralbeamdataexception.HResult;

        }


        public dynamic GetTSObject() => spiralbeamdataexception;

		public System.Exception GetBaseException()
			 => spiralbeamdataexception.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => spiralbeamdataexception.GetObjectData(info, context);





    }

}
    
