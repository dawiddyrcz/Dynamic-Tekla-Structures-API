//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class InvalidFacePointsException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

		public System.String Message
		{
			get => teklaObject.Message;
			set { teklaObject.Message = value; }
		}

		public System.Collections.IDictionary Data
		{
			get => teklaObject.Data;
			set { teklaObject.Data = value; }
		}

		public System.Exception InnerException
		{
			get => teklaObject.InnerException;
			set { teklaObject.InnerException = value; }
		}

		public System.Reflection.MethodBase TargetSite
		{
			get => teklaObject.TargetSite;
			set { teklaObject.TargetSite = value; }
		}

		public System.String StackTrace
		{
			get => teklaObject.StackTrace;
			set { teklaObject.StackTrace = value; }
		}

		public System.String HelpLink
		{
			get => teklaObject.HelpLink;
			set { teklaObject.HelpLink = value; }
		}

		public System.String Source
		{
			get => teklaObject.Source;
			set { teklaObject.Source = value; }
		}

		public System.Int32 HResult
		{
			get => teklaObject.HResult;
			set { teklaObject.HResult = value; }
		}

		public Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus OperationStatus
		{
			get => Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus_.FromTSObject(teklaObject.OperationStatus);
			set { teklaObject.OperationStatus = Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public InvalidFacePointsException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.InvalidFacePointsException");
		}

		public System.Exception GetBaseException()
			 => teklaObject.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => teklaObject.GetObjectData(info, context);





    }

    internal static class InvalidFacePointsException_
    {
        public static dynamic GetTSObject(InvalidFacePointsException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InvalidFacePointsException FromTSObject(dynamic tsObject)
        {
            return new InvalidFacePointsException() { teklaObject = tsObject };
        }
    }


}
    
