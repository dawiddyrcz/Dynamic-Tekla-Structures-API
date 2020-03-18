//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public sealed class Filter 
    {

		public Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression
		{
			get => Dynamic.Tekla.Structures.Filtering.FilterExpression_.FromTSObject(filter.FilterExpression);
			set { filter.FilterExpression = Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(value); }
		}

        

        internal dynamic filter;
        
        public Filter()
        {
            this.filter =  TSActivator.CreateInstance("Tekla.Structures.Filtering.Filter");
        }

        internal Filter(dynamic tsObject)
        {
            this.filter = tsObject;
        }

		public System.String CreateFile(Dynamic.Tekla.Structures.Filtering.FilterExpressionFileType FilterExpressionFileType, System.String FullFileName)
			 => filter.CreateFile(Dynamic.Tekla.Structures.Filtering.FilterExpressionFileType_.GetTSObject(FilterExpressionFileType), FullFileName);





    }

    internal static class Filter_
    {
        public static dynamic GetTSObject(Filter dynObject)
        {
            return dynObject.filter;
        }

        public static Filter FromTSObject(dynamic tsObject)
        {
            return new Filter(tsObject);
        }
    }


}
    
