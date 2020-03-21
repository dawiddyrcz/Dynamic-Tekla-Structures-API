//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class InvalidFilterExpressionException 
    {

		public Dynamic.Tekla.Structures.Filtering.Expression Expression
		{
			get => Dynamic.Tekla.Structures.Filtering.Expression_.FromTSObject(invalidfilterexpressionexception.Expression);
			set { invalidfilterexpressionexception.Expression = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType InvalidFilterExpressionExceptionReasonsType
		{
			get => Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.FromTSObject(invalidfilterexpressionexception.InvalidFilterExpressionExceptionReasonsType);
			set { invalidfilterexpressionexception.InvalidFilterExpressionExceptionReasonsType = Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Filtering.Expression LeftExpression
		{
			get => Dynamic.Tekla.Structures.Filtering.Expression_.FromTSObject(invalidfilterexpressionexception.LeftExpression);
			set { invalidfilterexpressionexception.LeftExpression = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Filtering.Expression RightExpression
		{
			get => Dynamic.Tekla.Structures.Filtering.Expression_.FromTSObject(invalidfilterexpressionexception.RightExpression);
			set { invalidfilterexpressionexception.RightExpression = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Filtering.OperatorType OperatorType
		{
			get => Dynamic.Tekla.Structures.Filtering.OperatorType_.FromTSObject(invalidfilterexpressionexception.OperatorType);
			set { invalidfilterexpressionexception.OperatorType = Dynamic.Tekla.Structures.Filtering.OperatorType_.GetTSObject(value); }
		}

		public System.String Message
		{
			get => invalidfilterexpressionexception.Message;
			set { invalidfilterexpressionexception.Message = value; }
		}

		public System.Collections.IDictionary Data
		{
			get => invalidfilterexpressionexception.Data;
			set { invalidfilterexpressionexception.Data = value; }
		}

		public System.Exception InnerException
		{
			get => invalidfilterexpressionexception.InnerException;
			set { invalidfilterexpressionexception.InnerException = value; }
		}

		public System.Reflection.MethodBase TargetSite
		{
			get => invalidfilterexpressionexception.TargetSite;
			set { invalidfilterexpressionexception.TargetSite = value; }
		}

		public System.String StackTrace
		{
			get => invalidfilterexpressionexception.StackTrace;
			set { invalidfilterexpressionexception.StackTrace = value; }
		}

		public System.String HelpLink
		{
			get => invalidfilterexpressionexception.HelpLink;
			set { invalidfilterexpressionexception.HelpLink = value; }
		}

		public System.String Source
		{
			get => invalidfilterexpressionexception.Source;
			set { invalidfilterexpressionexception.Source = value; }
		}

		public System.Int32 HResult
		{
			get => invalidfilterexpressionexception.HResult;
			set { invalidfilterexpressionexception.HResult = value; }
		}

        

        internal dynamic invalidfilterexpressionexception;
        
        public InvalidFilterExpressionException()
        {
            this.invalidfilterexpressionexception =  TSActivator.CreateInstance("Tekla.Structures.Filtering.InvalidFilterExpressionException");
        }

        internal InvalidFilterExpressionException(dynamic tsObject)
        {
            this.invalidfilterexpressionexception = tsObject;
        }
		public InvalidFilterExpressionException(Dynamic.Tekla.Structures.Filtering.Expression Expression, Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType InvalidFilterExpressionExceptionReasonsType)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(Expression);
			args[1] = Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.GetTSObject(InvalidFilterExpressionExceptionReasonsType);
			this.invalidfilterexpressionexception = TSActivator.CreateInstance("Tekla.Structures.Filtering.InvalidFilterExpressionException", args);
		}
		public InvalidFilterExpressionException(Dynamic.Tekla.Structures.Filtering.Expression LeftExpression, Dynamic.Tekla.Structures.Filtering.OperatorType OperatorType, Dynamic.Tekla.Structures.Filtering.Expression RightExpression, Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType InvalidFilterExpressionExceptionReasonsType)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(LeftExpression);
			args[1] = Dynamic.Tekla.Structures.Filtering.OperatorType_.GetTSObject(OperatorType);
			args[2] = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(RightExpression);
			args[3] = Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.GetTSObject(InvalidFilterExpressionExceptionReasonsType);
			this.invalidfilterexpressionexception = TSActivator.CreateInstance("Tekla.Structures.Filtering.InvalidFilterExpressionException", args);
		}
		public InvalidFilterExpressionException(Dynamic.Tekla.Structures.Filtering.Expression Expression, Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType InvalidFilterExpressionExceptionReasonsType, System.Int32 MaximumExpressionNumber)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Filtering.Expression_.GetTSObject(Expression);
			args[1] = Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.GetTSObject(InvalidFilterExpressionExceptionReasonsType);
			args[2] = MaximumExpressionNumber;
			this.invalidfilterexpressionexception = TSActivator.CreateInstance("Tekla.Structures.Filtering.InvalidFilterExpressionException", args);
		}

		public System.Exception GetBaseException()
			 => invalidfilterexpressionexception.GetBaseException();

		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			 => invalidfilterexpressionexception.GetObjectData(info, context);





    }

    internal static class InvalidFilterExpressionException_
    {
        public static dynamic GetTSObject(InvalidFilterExpressionException dynObject)
        {
            return dynObject.invalidfilterexpressionexception;
        }

        public static InvalidFilterExpressionException FromTSObject(dynamic tsObject)
        {
            return new InvalidFilterExpressionException(tsObject);
        }
    }


}
    
