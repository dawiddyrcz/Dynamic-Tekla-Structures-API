//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class BinaryFilterExpressionItem 
    {

        

        internal dynamic binaryfilterexpressionitem;
        
        public BinaryFilterExpressionItem()
        {
            this.binaryfilterexpressionitem =  TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpressionItem");
        }

        internal BinaryFilterExpressionItem(dynamic tsObject)
        {
            this.binaryfilterexpressionitem = tsObject;
        }
		public BinaryFilterExpressionItem(Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(FilterExpression);
			this.binaryfilterexpressionitem = TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpressionItem", args);
		}
		public BinaryFilterExpressionItem(Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression, Dynamic.Tekla.Structures.Filtering.BinaryFilterOperatorType BinaryFilterItemOperatorType)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(FilterExpression);
			args[1] = Dynamic.Tekla.Structures.Filtering.BinaryFilterOperatorType_.GetTSObject(BinaryFilterItemOperatorType);
			this.binaryfilterexpressionitem = TSActivator.CreateInstance("Tekla.Structures.Filtering.BinaryFilterExpressionItem", args);
		}





    }

    internal static class BinaryFilterExpressionItem_
    {
        public static dynamic GetTSObject(BinaryFilterExpressionItem dynObject)
        {
            return dynObject.binaryfilterexpressionitem;
        }

        public static BinaryFilterExpressionItem FromTSObject(dynamic tsObject)
        {
            return new BinaryFilterExpressionItem(tsObject);
        }
    }


}
    
