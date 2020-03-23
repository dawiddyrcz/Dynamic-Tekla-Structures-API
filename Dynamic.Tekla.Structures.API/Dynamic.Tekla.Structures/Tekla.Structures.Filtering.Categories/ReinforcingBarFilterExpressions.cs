/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering.Categories
{

    public  class ReinforcingBarFilterExpressions 
    {

        

        internal dynamic teklaObject;

		public ReinforcingBarFilterExpressions() {}




    public  class CustomBoolean  : Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression
    {

        

        

		public CustomBoolean() {}
		public CustomBoolean(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomBoolean", args);
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomBoolean)System.Activator.CreateInstance(type);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomDateTime", args);
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomDateTime)System.Activator.CreateInstance(type);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomNumber", args);
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomNumber)System.Activator.CreateInstance(type);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomString", args);
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomString)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Class  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Class()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Class");
		}





    }

    internal static class Class_
    {
        public static dynamic GetTSObject(Class dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Class FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Class)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Diameter  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Diameter()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Diameter");
		}





    }

    internal static class Diameter_
    {
        public static dynamic GetTSObject(Diameter dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Diameter FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Diameter)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class JoinType  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public JoinType()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.JoinType");
		}





    }

    internal static class JoinType_
    {
        public static dynamic GetTSObject(JoinType dynObject)
        {
            return dynObject.teklaObject;
        }

        public static JoinType FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.JoinType)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Length  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Length()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Length");
		}





    }

    internal static class Length_
    {
        public static dynamic GetTSObject(Length dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Length FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Length)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Material  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Material()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Material");
		}





    }

    internal static class Material_
    {
        public static dynamic GetTSObject(Material dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Material FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Material)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Name  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Name()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Name");
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
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Name)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class NumberingSeries  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public NumberingSeries()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.NumberingSeries");
		}





    }

    internal static class NumberingSeries_
    {
        public static dynamic GetTSObject(NumberingSeries dynObject)
        {
            return dynObject.teklaObject;
        }

        public static NumberingSeries FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.NumberingSeries)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Phase  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Phase()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Phase");
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Phase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Position  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Position()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Position");
		}





    }

    internal static class Position_
    {
        public static dynamic GetTSObject(Position dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Position FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Position)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class PositionNumber  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public PositionNumber()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.PositionNumber");
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
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.PositionNumber)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Prefix  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Prefix()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Prefix");
		}





    }

    internal static class Prefix_
    {
        public static dynamic GetTSObject(Prefix dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Prefix FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Prefix)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Shape  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Shape()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Shape");
		}





    }

    internal static class Shape_
    {
        public static dynamic GetTSObject(Shape dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Shape FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Shape)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Size  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Size()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Size");
		}





    }

    internal static class Size_
    {
        public static dynamic GetTSObject(Size dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Size FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Size)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class StartNumber  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public StartNumber()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.StartNumber");
		}





    }

    internal static class StartNumber_
    {
        public static dynamic GetTSObject(StartNumber dynObject)
        {
            return dynObject.teklaObject;
        }

        public static StartNumber FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.StartNumber)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class ReinforcingBarFilterExpressions_
    {
        public static dynamic GetTSObject(ReinforcingBarFilterExpressions dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcingBarFilterExpressions FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
