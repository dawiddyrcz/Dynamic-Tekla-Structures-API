//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public  class InvalidFilterExpressionException 
    {

		public Dynamic.Tekla.Structures.Filtering.Expression Expression
		{
			get => Dynamic.Tekla.Structures.Filtering.Expression_.FromTSObject(teklaObject.Expression);
			set { teklaObject.Expression = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType InvalidFilterExpressionExceptionReasonsType
		{
			get => Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.FromTSObject(teklaObject.InvalidFilterExpressionExceptionReasonsType);
			set { teklaObject.InvalidFilterExpressionExceptionReasonsType = Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Filtering.Expression LeftExpression
		{
			get => Dynamic.Tekla.Structures.Filtering.Expression_.FromTSObject(teklaObject.LeftExpression);
			set { teklaObject.LeftExpression = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Filtering.Expression RightExpression
		{
			get => Dynamic.Tekla.Structures.Filtering.Expression_.FromTSObject(teklaObject.RightExpression);
			set { teklaObject.RightExpression = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Filtering.OperatorType OperatorType
		{
			get => Dynamic.Tekla.Structures.Filtering.OperatorType_.FromTSObject(teklaObject.OperatorType);
			set { teklaObject.OperatorType = Dynamic.Tekla.Structures.Filtering.OperatorType_.GetTSObject(value); }
		}

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

		internal InvalidFilterExpressionException() {}
		public InvalidFilterExpressionException(Dynamic.Tekla.Structures.Filtering.Expression Expression, Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType InvalidFilterExpressionExceptionReasonsType)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(Expression);
			args[1] = Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.GetTSObject(InvalidFilterExpressionExceptionReasonsType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.InvalidFilterExpressionException", args);
		}
		public InvalidFilterExpressionException(Dynamic.Tekla.Structures.Filtering.Expression LeftExpression, Dynamic.Tekla.Structures.Filtering.OperatorType OperatorType, Dynamic.Tekla.Structures.Filtering.Expression RightExpression, Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType InvalidFilterExpressionExceptionReasonsType)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(LeftExpression);
			args[1] = Dynamic.Tekla.Structures.Filtering.OperatorType_.GetTSObject(OperatorType);
			args[2] = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(RightExpression);
			args[3] = Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.GetTSObject(InvalidFilterExpressionExceptionReasonsType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.InvalidFilterExpressionException", args);
		}
		public InvalidFilterExpressionException(Dynamic.Tekla.Structures.Filtering.Expression Expression, Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType InvalidFilterExpressionExceptionReasonsType, System.Int32 MaximumExpressionNumber)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(Expression);
			args[1] = Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.GetTSObject(InvalidFilterExpressionExceptionReasonsType);
			args[2] = MaximumExpressionNumber;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.InvalidFilterExpressionException", args);
		}

		public System.Exception GetBaseException()
			 => teklaObject.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => teklaObject.GetObjectData(info, context);





    }

    internal static class InvalidFilterExpressionException_
    {
        public static dynamic GetTSObject(InvalidFilterExpressionException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InvalidFilterExpressionException FromTSObject(dynamic tsObject)
        {
            return new InvalidFilterExpressionException() { teklaObject = tsObject };
        }
    }


}
    
