//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class BinaryFilterExpressionItem 
    {

        

        dynamic binaryfilterexpressionitem;
        
        public BinaryFilterExpressionItem()
        {
            this.binaryfilterexpressionitem =  new Tekla.Structures.Filtering.BinaryFilterExpressionItem();
        }

        public BinaryFilterExpressionItem(dynamic tsObject)
        {
            this.binaryfilterexpressionitem = tsObject;

        }


        public dynamic GetTSObject() => binaryfilterexpressionitem;

		public System.String ToString()
			 => binaryfilterexpressionitem.ToString();

		public System.Boolean Equals(System.Object obj)
			 => binaryfilterexpressionitem.Equals(obj);

		public System.Int32 GetHashCode()
			 => binaryfilterexpressionitem.GetHashCode();

		public System.Type GetType()
			 => binaryfilterexpressionitem.GetType();





    }

}
    
