/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public  class BinaryFilterExpression  : Dynamic.Tekla.Structures.Filtering.FilterExpression
    {

        

        

		internal BinaryFilterExpression() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BinaryFilterExpression(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public BinaryFilterExpression(Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression Left, Dynamic.Tekla.Structures.Filtering.BooleanOperatorType Oper, Dynamic.Tekla.Structures.Filtering.BooleanConstantFilterExpression Right)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression_.GetTSObject(Left);
			args[1] = Dynamic.Tekla.Structures.Filtering.BooleanOperatorType_.GetTSObject(Oper);
			args[2] = Dynamic.Tekla.Structures.Filtering.BooleanConstantFilterExpression_.GetTSObject(Right);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpression", args);
		}
		public BinaryFilterExpression(Dynamic.Tekla.Structures.Filtering.StringFilterExpression Left, Dynamic.Tekla.Structures.Filtering.StringOperatorType Oper, Dynamic.Tekla.Structures.Filtering.StringConstantFilterExpression Right)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Filtering.StringFilterExpression_.GetTSObject(Left);
			args[1] = Dynamic.Tekla.Structures.Filtering.StringOperatorType_.GetTSObject(Oper);
			args[2] = Dynamic.Tekla.Structures.Filtering.StringConstantFilterExpression_.GetTSObject(Right);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpression", args);
		}
		public BinaryFilterExpression(Dynamic.Tekla.Structures.Filtering.NumericFilterExpression Left, Dynamic.Tekla.Structures.Filtering.NumericOperatorType Oper, Dynamic.Tekla.Structures.Filtering.NumericConstantFilterExpression Right)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Filtering.NumericFilterExpression_.GetTSObject(Left);
			args[1] = Dynamic.Tekla.Structures.Filtering.NumericOperatorType_.GetTSObject(Oper);
			args[2] = Dynamic.Tekla.Structures.Filtering.NumericConstantFilterExpression_.GetTSObject(Right);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpression", args);
		}
		public BinaryFilterExpression(Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression Left, Dynamic.Tekla.Structures.Filtering.DateTimeOperatorType Oper, Dynamic.Tekla.Structures.Filtering.DateTimeConstantFilterExpression Right)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression_.GetTSObject(Left);
			args[1] = Dynamic.Tekla.Structures.Filtering.DateTimeOperatorType_.GetTSObject(Oper);
			args[2] = Dynamic.Tekla.Structures.Filtering.DateTimeConstantFilterExpression_.GetTSObject(Right);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpression", args);
		}





    }

    internal static class BinaryFilterExpression_
    {
        public static dynamic GetTSObject(BinaryFilterExpression dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static BinaryFilterExpression FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.BinaryFilterExpression)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BinaryFilterExpressionArray_
    {
        public static dynamic GetTSObject(BinaryFilterExpression[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BinaryFilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BinaryFilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<BinaryFilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BinaryFilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
