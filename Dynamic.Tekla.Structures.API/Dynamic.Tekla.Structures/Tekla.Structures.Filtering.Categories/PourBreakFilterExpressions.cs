//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering.Categories
{

    public  class PourBreakFilterExpressions 
    {

        

        internal dynamic teklaObject;

		public PourBreakFilterExpressions() {}




    public  class CustomBoolean  : Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression
    {

        

        internal dynamic teklaObject;

		public CustomBoolean() {}
		public CustomBoolean(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PourBreakFilterExpressions.CustomBoolean", args);
		}





    }

    internal static class CustomBoolean_
    {
        public static dynamic GetTSObject(CustomBoolean dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CustomBoolean FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PourBreakFilterExpressions.CustomBoolean)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class CustomDateTime  : Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression
    {

        

        internal dynamic teklaObject;

		public CustomDateTime() {}
		public CustomDateTime(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PourBreakFilterExpressions.CustomDateTime", args);
		}





    }

    internal static class CustomDateTime_
    {
        public static dynamic GetTSObject(CustomDateTime dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CustomDateTime FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PourBreakFilterExpressions.CustomDateTime)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class CustomNumber  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        internal dynamic teklaObject;

		public CustomNumber() {}
		public CustomNumber(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PourBreakFilterExpressions.CustomNumber", args);
		}





    }

    internal static class CustomNumber_
    {
        public static dynamic GetTSObject(CustomNumber dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CustomNumber FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PourBreakFilterExpressions.CustomNumber)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class CustomString  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        internal dynamic teklaObject;

		public CustomString() {}
		public CustomString(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PourBreakFilterExpressions.CustomString", args);
		}





    }

    internal static class CustomString_
    {
        public static dynamic GetTSObject(CustomString dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CustomString FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PourBreakFilterExpressions.CustomString)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class PourBreakFilterExpressions_
    {
        public static dynamic GetTSObject(PourBreakFilterExpressions dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PourBreakFilterExpressions FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PourBreakFilterExpressions)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
