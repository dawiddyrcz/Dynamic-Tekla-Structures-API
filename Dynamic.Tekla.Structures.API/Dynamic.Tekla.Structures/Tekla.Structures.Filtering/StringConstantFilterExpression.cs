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
    
