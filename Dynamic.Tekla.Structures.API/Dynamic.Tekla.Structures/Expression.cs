//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class Expression 
    {

        

        dynamic expression;
        
        public Expression()
        {
            this.expression =  new Tekla.Structures.Filtering.Expression();
        }

        public Expression(dynamic tsObject)
        {
            this.expression = tsObject;

        }


        public dynamic GetTSObject() => expression;

		public System.String ToString()
			 => expression.ToString();

		public System.Boolean Equals(System.Object obj)
			 => expression.Equals(obj);

		public System.Int32 GetHashCode()
			 => expression.GetHashCode();

		public System.Type GetType()
			 => expression.GetType();





    }

}
    
