//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class FilterExpression 
    {

		public System.Boolean IsEnable
		{
			get => filterexpression.IsEnable;
			set { filterexpression.IsEnable = value; }
		}

        

        dynamic filterexpression;
        
        public FilterExpression()
        {
            this.filterexpression =  new Tekla.Structures.Filtering.FilterExpression();
        }

        public FilterExpression(dynamic tsObject)
        {
            this.filterexpression = tsObject;
			this.IsEnable = filterexpression.IsEnable;

        }


        public dynamic GetTSObject() => filterexpression;





    }

}
    
