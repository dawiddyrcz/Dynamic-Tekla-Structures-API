/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public  class Filter 
    {

		public Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Filtering.FilterExpression_.FromTSObject(teklaObject.FilterExpression);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FilterExpression", ex); }
			}
			set
			{
				try {
				teklaObject.FilterExpression = Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FilterExpression", ex); }
			}
		}

        

        internal dynamic teklaObject;

		internal Filter() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Filter(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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


public System.String CreateFile(
	Dynamic.Tekla.Structures.Filtering.FilterExpressionFileType FilterExpressionFileType_,
	System.String FullFileName
	)
{
	var FilterExpressionFileType = Dynamic.Tekla.Structures.Filtering.FilterExpressionFileType_.GetTSObject(FilterExpressionFileType_);
	
    try
    {
        	var result = (System.String) teklaObject.CreateFile(FilterExpressionFileType, FullFileName);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateFile), ex);
    }
}






    }

    internal static class Filter_
    {
        public static dynamic GetTSObject(Filter dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Filter FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Filter)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FilterArray_
    {
        public static dynamic GetTSObject(Filter[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Filter_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Filter[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Filter>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Filter_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
