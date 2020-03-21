//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class BooleanConstantFilterExpression 
    {

        

        internal dynamic booleanconstantfilterexpression;
        
        public BooleanConstantFilterExpression()
        {
            this.booleanconstantfilterexpression =  TSActivator.CreateInstance("Tekla.Structures.Filtering.BooleanConstantFilterExpression");
        }

        internal BooleanConstantFilterExpression(dynamic tsObject)
        {
            this.booleanconstantfilterexpression = tsObject;
        }
		public BooleanConstantFilterExpression(System.Boolean Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.booleanconstantfilterexpression = TSActivator.CreateInstance("Tekla.Structures.Filtering.BooleanConstantFilterExpression", args);
		}
		public BooleanConstantFilterExpression(System.Boolean Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.booleanconstantfilterexpression = TSActivator.CreateInstance("Tekla.Structures.Filtering.BooleanConstantFilterExpression", args);
		}





    }

    internal static class BooleanConstantFilterExpression_
    {
        public static dynamic GetTSObject(BooleanConstantFilterExpression dynObject)
        {
            return dynObject.booleanconstantfilterexpression;
        }

        public static BooleanConstantFilterExpression FromTSObject(dynamic tsObject)
        {
            return new BooleanConstantFilterExpression(tsObject);
        }
    }


}
    
