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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReinforcingBarFilterExpressions(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public  class CustomBoolean  : Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression
    {

        

        

		public CustomBoolean() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomBoolean(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomBoolean)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomBooleanArray_
    {
        public static dynamic GetTSObject(CustomBoolean[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomBoolean_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomBoolean[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CustomBoolean>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomBoolean_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class CustomDateTime  : Dynamic.Tekla.Structures.Filtering.DateTimeFilterExpression
    {

        

        

		public CustomDateTime() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomDateTime(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomDateTime)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomDateTimeArray_
    {
        public static dynamic GetTSObject(CustomDateTime[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomDateTime_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomDateTime[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CustomDateTime>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomDateTime_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class CustomNumber  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public CustomNumber() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomNumber(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomNumber)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomNumberArray_
    {
        public static dynamic GetTSObject(CustomNumber[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomNumber_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomNumber[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CustomNumber>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomNumber_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class CustomString  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public CustomString() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomString(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.CustomString)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomStringArray_
    {
        public static dynamic GetTSObject(CustomString[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomString_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomString[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CustomString>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomString_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Class  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Class()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Class");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Class(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Class)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ClassArray_
    {
        public static dynamic GetTSObject(Class[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Class_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Class[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Class>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Class_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Diameter  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Diameter()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Diameter");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Diameter(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Diameter)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DiameterArray_
    {
        public static dynamic GetTSObject(Diameter[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Diameter_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Diameter[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Diameter>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Diameter_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class JoinType  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public JoinType()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.JoinType");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public JoinType(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.JoinType)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class JoinTypeArray_
    {
        public static dynamic GetTSObject(JoinType[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(JoinType_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static JoinType[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<JoinType>();
            foreach(var tsItem in tsArray)
            {
                list.Add(JoinType_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Length  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Length()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Length");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Length(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Length)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LengthArray_
    {
        public static dynamic GetTSObject(Length[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Length_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Length[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Length>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Length_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Material  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Material()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Material");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Material(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Material)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MaterialArray_
    {
        public static dynamic GetTSObject(Material[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Material_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Material[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Material>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Material_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Name  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Name()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Name");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Name(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Name)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NameArray_
    {
        public static dynamic GetTSObject(Name[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Name_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Name[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Name>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Name_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class NumberingSeries  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public NumberingSeries()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.NumberingSeries");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NumberingSeries(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.NumberingSeries)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NumberingSeriesArray_
    {
        public static dynamic GetTSObject(NumberingSeries[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NumberingSeries_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NumberingSeries[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<NumberingSeries>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NumberingSeries_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Phase  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Phase()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Phase");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Phase(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Phase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PhaseArray_
    {
        public static dynamic GetTSObject(Phase[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Phase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Phase[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Phase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Phase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Position  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Position()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Position");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Position(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Position)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PositionArray_
    {
        public static dynamic GetTSObject(Position[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Position_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Position[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Position>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Position_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class PositionNumber  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public PositionNumber()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.PositionNumber");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PositionNumber(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.PositionNumber)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PositionNumberArray_
    {
        public static dynamic GetTSObject(PositionNumber[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PositionNumber_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PositionNumber[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PositionNumber>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PositionNumber_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Prefix  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Prefix()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Prefix");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Prefix(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Prefix)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PrefixArray_
    {
        public static dynamic GetTSObject(Prefix[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Prefix_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Prefix[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Prefix>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Prefix_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Shape  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Shape()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Shape");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Shape(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Shape)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ShapeArray_
    {
        public static dynamic GetTSObject(Shape[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Shape_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Shape[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Shape>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Shape_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Size  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public Size()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Size");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Size(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.Size)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SizeArray_
    {
        public static dynamic GetTSObject(Size[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Size_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Size[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Size>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Size_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class StartNumber  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public StartNumber()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.StartNumber");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StartNumber(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions.StartNumber)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StartNumberArray_
    {
        public static dynamic GetTSObject(StartNumber[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StartNumber_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StartNumber[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<StartNumber>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StartNumber_.FromTSObject(tsItem));
            }
            return list.ToArray();
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReinforcingBarFilterExpressionsArray_
    {
        public static dynamic GetTSObject(ReinforcingBarFilterExpressions[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReinforcingBarFilterExpressions_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReinforcingBarFilterExpressions[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReinforcingBarFilterExpressions>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReinforcingBarFilterExpressions_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
