/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering.Categories
{

    public  class PartFilterExpressions 
    {

        

        internal dynamic teklaObject;

		public PartFilterExpressions() {}




    public  class CustomBoolean  : Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression
    {

        

        

		public CustomBoolean() {}
		public CustomBoolean(System.String UserAttribute)
		{
			var args = new object[1];
			args[0] = UserAttribute;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.CustomBoolean", args);
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.CustomBoolean)System.Activator.CreateInstance(type);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.CustomDateTime", args);
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.CustomDateTime)System.Activator.CreateInstance(type);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.CustomNumber", args);
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.CustomNumber)System.Activator.CreateInstance(type);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.CustomString", args);
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.CustomString)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Class  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Class()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.Class");
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.Class)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Finish  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Finish()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.Finish");
		}





    }

    internal static class Finish_
    {
        public static dynamic GetTSObject(Finish dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Finish FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.Finish)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Lot  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Lot()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.Lot");
		}





    }

    internal static class Lot_
    {
        public static dynamic GetTSObject(Lot dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Lot FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.Lot)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Material  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Material()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.Material");
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.Material)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Name  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Name()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.Name");
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.Name)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class NumberingSeries  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public NumberingSeries()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.NumberingSeries");
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.NumberingSeries)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Phase  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Phase()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.Phase");
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.Phase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class PositionNumber  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public PositionNumber()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.PositionNumber");
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.PositionNumber)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Prefix  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Prefix()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.Prefix");
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.Prefix)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class PrimaryPart  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public PrimaryPart()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.PrimaryPart");
		}





    }

    internal static class PrimaryPart_
    {
        public static dynamic GetTSObject(PrimaryPart dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PrimaryPart FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.PrimaryPart)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class Profile  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Profile()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.Profile");
		}





    }

    internal static class Profile_
    {
        public static dynamic GetTSObject(Profile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Profile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.Profile)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class StartNumber  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public StartNumber()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.StartNumber");
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
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.StartNumber)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public  class PourPhase  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public PourPhase()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.PartFilterExpressions.PourPhase");
		}





    }

    internal static class PourPhase_
    {
        public static dynamic GetTSObject(PourPhase dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PourPhase FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions.PourPhase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class PartFilterExpressions_
    {
        public static dynamic GetTSObject(PartFilterExpressions dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PartFilterExpressions FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.Categories.PartFilterExpressions)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
