/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering.Categories
{

    public  class WeldFilterExpressions 
    {

        

        internal dynamic teklaObject;

		public WeldFilterExpressions() {}




    public  class CustomBoolean  : Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression
    {

        

        

		public CustomBoolean() {}
		public CustomBoolean(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomBoolean", args);
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomBoolean)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class CustomDateTime  : Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression
    {

        

        

		public CustomDateTime() {}
		public CustomDateTime(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomDateTime", args);
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomDateTime)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class CustomNumber  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public CustomNumber() {}
		public CustomNumber(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomNumber", args);
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomNumber)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class CustomString  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public CustomString() {}
		public CustomString(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomString", args);
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomString)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Phase  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Phase()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.Phase");
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
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.Phase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class PositionNumber  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public PositionNumber()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.PositionNumber");
		}





    }

    internal static class PositionNumber_
    {
        public static dynamic GetTSObject(PositionNumber dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PositionNumber FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.PositionNumber)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class ReferenceText  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public ReferenceText()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.ReferenceText");
		}





    }

    internal static class ReferenceText_
    {
        public static dynamic GetTSObject(ReferenceText dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReferenceText FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.ReferenceText)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class SizeAboveLine  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public SizeAboveLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.SizeAboveLine");
		}





    }

    internal static class SizeAboveLine_
    {
        public static dynamic GetTSObject(SizeAboveLine dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SizeAboveLine FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.SizeAboveLine)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class SizeBelowLine  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public SizeBelowLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.SizeBelowLine");
		}





    }

    internal static class SizeBelowLine_
    {
        public static dynamic GetTSObject(SizeBelowLine dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SizeBelowLine FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.SizeBelowLine)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class TypeAboveLine  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public TypeAboveLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.TypeAboveLine");
		}





    }

    internal static class TypeAboveLine_
    {
        public static dynamic GetTSObject(TypeAboveLine dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TypeAboveLine FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.TypeAboveLine)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class TypeBelowLine  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public TypeBelowLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.TypeBelowLine");
		}





    }

    internal static class TypeBelowLine_
    {
        public static dynamic GetTSObject(TypeBelowLine dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TypeBelowLine FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.TypeBelowLine)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class WeldingSite  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public WeldingSite()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.WeldingSite");
		}





    }

    internal static class WeldingSite_
    {
        public static dynamic GetTSObject(WeldingSite dynObject)
        {
            return dynObject.teklaObject;
        }

        public static WeldingSite FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.WeldingSite)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class WeldFilterExpressions_
    {
        public static dynamic GetTSObject(WeldFilterExpressions dynObject)
        {
            return dynObject.teklaObject;
        }

        public static WeldFilterExpressions FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
