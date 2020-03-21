//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class StringConstantFilterExpression 
    {

        

        internal dynamic stringconstantfilterexpression;
        
        public StringConstantFilterExpression()
        {
            this.stringconstantfilterexpression =  TSActivator.CreateInstance("Tekla.Structures.Filtering.StringConstantFilterExpression");
        }

        internal StringConstantFilterExpression(dynamic tsObject)
        {
            this.stringconstantfilterexpression = tsObject;
        }
		public StringConstantFilterExpression(System.String Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.stringconstantfilterexpression = TSActivator.CreateInstance("Tekla.Structures.Filtering.StringConstantFilterExpression", args);
		}
		public StringConstantFilterExpression(System.Collections.Generic.IEnumerable<System.String> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.stringconstantfilterexpression = TSActivator.CreateInstance("Tekla.Structures.Filtering.StringConstantFilterExpression", args);
		}





    }

    internal static class StringConstantFilterExpression_
    {
        public static dynamic GetTSObject(StringConstantFilterExpression dynObject)
        {
            return dynObject.stringconstantfilterexpression;
        }

        public static StringConstantFilterExpression FromTSObject(dynamic tsObject)
        {
            return new StringConstantFilterExpression(tsObject);
        }
    }


}
    
