//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class BooleanFilterExpression 
    {

        

        internal dynamic booleanfilterexpression;
        
        public BooleanFilterExpression()
        {
            this.booleanfilterexpression =  TSActivator.CreateInstance("Tekla.Structures.Filtering.BooleanFilterExpression");
        }

        internal BooleanFilterExpression(dynamic tsObject)
        {
            this.booleanfilterexpression = tsObject;
        }





    }

    internal static class BooleanFilterExpression_
    {
        public static dynamic GetTSObject(BooleanFilterExpression dynObject)
        {
            return dynObject.booleanfilterexpression;
        }

        public static BooleanFilterExpression FromTSObject(dynamic tsObject)
        {
            return new BooleanFilterExpression(tsObject);
        }
    }


}
    
