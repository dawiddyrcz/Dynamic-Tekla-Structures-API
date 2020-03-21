//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering
{

    public  class Filter 
    {

		public Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression
		{
			get => Dynamic.Tekla.Structures.Filtering.FilterExpression_.FromTSObject(teklaObject.FilterExpression);
			set { teklaObject.FilterExpression = Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public Filter() {}
		public Filter(Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(FilterExpression);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Filter", args);
		}
		public Filter(System.String FullFileName, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = FullFileName;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Filter", args);
		}

		public System.String CreateFile(Dynamic.Tekla.Structures.Filtering.FilterExpressionFileType FilterExpressionFileType, System.String FullFileName)
		{
			return teklaObject.CreateFile(Dynamic.Tekla.Structures.Filtering.FilterExpressionFileType_.GetTSObject(FilterExpressionFileType), FullFileName);
		}





    }

    internal static class Filter_
    {
        public static dynamic GetTSObject(Filter dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Filter FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Filter)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
