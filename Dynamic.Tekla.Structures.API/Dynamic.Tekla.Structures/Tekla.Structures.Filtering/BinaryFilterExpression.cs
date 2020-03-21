//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public  class BinaryFilterExpression  : Dynamic.Tekla.Structures.Filtering.FilterExpression
    {

		public System.Boolean IsEnable
		{
			get => teklaObject.IsEnable;
			set { teklaObject.IsEnable = value; }
		}

        

        internal dynamic teklaObject;

		public BinaryFilterExpression() {}
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
            return dynObject.teklaObject;
        }

        public static BinaryFilterExpression FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.BinaryFilterExpression)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
