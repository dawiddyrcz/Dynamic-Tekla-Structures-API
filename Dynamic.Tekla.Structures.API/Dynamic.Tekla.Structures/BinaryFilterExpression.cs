//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class BinaryFilterExpression 
    {

		public System.Boolean IsEnable
		{
			get => binaryfilterexpression.IsEnable;
			set { binaryfilterexpression.IsEnable = value; }
		}

        

        dynamic binaryfilterexpression;
        
        public BinaryFilterExpression()
        {
            this.binaryfilterexpression =  new Tekla.Structures.Filtering.BinaryFilterExpression();
        }

        public BinaryFilterExpression(dynamic tsObject)
        {
            this.binaryfilterexpression = tsObject;
			this.IsEnable = binaryfilterexpression.IsEnable;

        }


        public dynamic GetTSObject() => binaryfilterexpression;





    }

}
    
