/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public  class InvalidFilterExpressionException  : System.Exception
    {

		public Dynamic.Tekla.Structures.Filtering.Expression Expression
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Filtering.Expression_.FromTSObject(teklaObject.Expression);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Expression", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType InvalidFilterExpressionExceptionReasonsType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionExceptionReasonsType_.FromTSObject(teklaObject.InvalidFilterExpressionExceptionReasonsType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("InvalidFilterExpressionExceptionReasonsType", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Filtering.Expression LeftExpression
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Filtering.Expression_.FromTSObject(teklaObject.LeftExpression);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftExpression", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Filtering.Expression RightExpression
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Filtering.Expression_.FromTSObject(teklaObject.RightExpression);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightExpression", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Filtering.OperatorType OperatorType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Filtering.OperatorType_.FromTSObject(teklaObject.OperatorType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OperatorType", ex); }
			}
		}

        

        internal dynamic teklaObject;

		internal InvalidFilterExpressionException() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public InvalidFilterExpressionException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static InvalidFilterExpressionException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.InvalidFilterExpressionException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InvalidFilterExpressionExceptionArray_
    {
        public static dynamic GetTSObject(InvalidFilterExpressionException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InvalidFilterExpressionException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InvalidFilterExpressionException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<InvalidFilterExpressionException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InvalidFilterExpressionException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
