//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class DataFilterExpression 
    {

        

        internal dynamic datafilterexpression;
        
        private DataFilterExpression()
        {
            this.datafilterexpression =  TSActivator.CreateInstance("Tekla.Structures.Filtering.DataFilterExpression");
        }

        internal DataFilterExpression(dynamic tsObject)
        {
            this.datafilterexpression = tsObject;
        }





    }

    internal static class DataFilterExpression_
    {
        public static dynamic GetTSObject(DataFilterExpression dynObject)
        {
            return dynObject.datafilterexpression;
        }

        public static DataFilterExpression FromTSObject(dynamic tsObject)
        {
            return new DataFilterExpression(tsObject);
        }
    }


}
    