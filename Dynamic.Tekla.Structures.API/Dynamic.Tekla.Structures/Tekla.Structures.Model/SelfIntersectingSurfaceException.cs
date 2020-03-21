//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class SelfIntersectingSurfaceException  : Dynamic.Tekla.Structures.Model.LoftedPlateOperationException
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

        

        internal dynamic teklaObject;

		public SelfIntersectingSurfaceException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SelfIntersectingSurfaceException");
		}

		public System.Exception GetBaseException()
			 => teklaObject.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => teklaObject.GetObjectData(info, context);





    }

    internal static class SelfIntersectingSurfaceException_
    {
        public static dynamic GetTSObject(SelfIntersectingSurfaceException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SelfIntersectingSurfaceException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.SelfIntersectingSurfaceException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
