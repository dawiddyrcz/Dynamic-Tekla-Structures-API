/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
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

        

        internal dynamic teklaObject;

		public InvalidFilterExpressionException() {}
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





    }

    internal static class InvalidFilterExpressionException_
    {
        public static dynamic GetTSObject(InvalidFilterExpressionException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InvalidFilterExpressionException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.InvalidFilterExpressionException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
