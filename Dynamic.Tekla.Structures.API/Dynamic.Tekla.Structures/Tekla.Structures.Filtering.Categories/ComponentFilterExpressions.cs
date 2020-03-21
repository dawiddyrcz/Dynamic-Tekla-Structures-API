//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Filtering.Categories
{

    public  class ComponentFilterExpressions 
    {

        

        internal dynamic teklaObject;

		internal ComponentFilterExpressions() {}




    public  class CustomBoolean  : Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression
    {

        

        internal dynamic teklaObject;

		internal CustomBoolean() {}
		public CustomBoolean(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ComponentFilterExpressions.CustomBoolean", args);
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
            return new CustomBoolean() { teklaObject = tsObject };
        }
    }



    public  class CustomDateTime  : Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression
    {

        

        internal dynamic teklaObject;

		internal CustomDateTime() {}
		public CustomDateTime(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ComponentFilterExpressions.CustomDateTime", args);
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
            return new CustomDateTime() { teklaObject = tsObject };
        }
    }



    public  class CustomNumber  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        internal dynamic teklaObject;

		internal CustomNumber() {}
		public CustomNumber(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ComponentFilterExpressions.CustomNumber", args);
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
            return new CustomNumber() { teklaObject = tsObject };
        }
    }



    public  class CustomString  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        internal dynamic teklaObject;

		internal CustomString() {}
		public CustomString(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ComponentFilterExpressions.CustomString", args);
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
            return new CustomString() { teklaObject = tsObject };
        }
    }



    public  class ConnectionCode  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        internal dynamic teklaObject;

		public ConnectionCode()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ComponentFilterExpressions.ConnectionCode");
		}





    }

    internal static class ConnectionCode_
    {
        public static dynamic GetTSObject(ConnectionCode dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ConnectionCode FromTSObject(dynamic tsObject)
        {
            return new ConnectionCode() { teklaObject = tsObject };
        }
    }



    public  class Name  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        internal dynamic teklaObject;

		public Name()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ComponentFilterExpressions.Name");
		}





    }

    internal static class Name_
    {
        public static dynamic GetTSObject(Name dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Name FromTSObject(dynamic tsObject)
        {
            return new Name() { teklaObject = tsObject };
        }
    }



    public  class Phase  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        internal dynamic teklaObject;

		public Phase()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ComponentFilterExpressions.Phase");
		}





    }

    internal static class Phase_
    {
        public static dynamic GetTSObject(Phase dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Phase FromTSObject(dynamic tsObject)
        {
            return new Phase() { teklaObject = tsObject };
        }
    }



    public  class RunningNumber  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        internal dynamic teklaObject;

		public RunningNumber()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ComponentFilterExpressions.RunningNumber");
		}





    }

    internal static class RunningNumber_
    {
        public static dynamic GetTSObject(RunningNumber dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RunningNumber FromTSObject(dynamic tsObject)
        {
            return new RunningNumber() { teklaObject = tsObject };
        }
    }




    }

    internal static class ComponentFilterExpressions_
    {
        public static dynamic GetTSObject(ComponentFilterExpressions dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ComponentFilterExpressions FromTSObject(dynamic tsObject)
        {
            return new ComponentFilterExpressions() { teklaObject = tsObject };
        }
    }


}
    
