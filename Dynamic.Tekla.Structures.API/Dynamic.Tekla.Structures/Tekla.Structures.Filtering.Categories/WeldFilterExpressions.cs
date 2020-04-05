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

		internal WeldFilterExpressions() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public WeldFilterExpressions(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public  class CustomBoolean  : Dynamic.Tekla.Structures.Filtering.BooleanFilterExpression
    {

        

        

		internal CustomBoolean() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomBoolean(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CustomBoolean FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomBoolean)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomBooleanArray_
    {
        public static dynamic GetTSObject(CustomBoolean[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomBoolean_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomBoolean[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
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

        

        

		internal CustomDateTime() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomDateTime(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CustomDateTime FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomDateTime)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomDateTimeArray_
    {
        public static dynamic GetTSObject(CustomDateTime[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomDateTime_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomDateTime[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
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

        

        

		internal CustomNumber() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomNumber(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CustomNumber FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomNumber)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomNumberArray_
    {
        public static dynamic GetTSObject(CustomNumber[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomNumber_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomNumber[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
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

        

        

		internal CustomString() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CustomString(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CustomString FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.CustomString)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomStringArray_
    {
        public static dynamic GetTSObject(CustomString[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomString_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomString[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CustomString>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomString_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Phase  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public Phase()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.Phase");
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Phase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.Phase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PhaseArray_
    {
        public static dynamic GetTSObject(Phase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Phase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Phase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Phase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Phase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class PositionNumber  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public PositionNumber()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.PositionNumber");
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PositionNumber FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.PositionNumber)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PositionNumberArray_
    {
        public static dynamic GetTSObject(PositionNumber[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PositionNumber_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PositionNumber[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PositionNumber>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PositionNumber_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class ReferenceText  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public ReferenceText()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.ReferenceText");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReferenceText(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class ReferenceText_
    {
        public static dynamic GetTSObject(ReferenceText dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReferenceText FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.ReferenceText)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceTextArray_
    {
        public static dynamic GetTSObject(ReferenceText[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceText_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceText[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReferenceText>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceText_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class SizeAboveLine  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public SizeAboveLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.SizeAboveLine");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SizeAboveLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class SizeAboveLine_
    {
        public static dynamic GetTSObject(SizeAboveLine dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SizeAboveLine FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.SizeAboveLine)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SizeAboveLineArray_
    {
        public static dynamic GetTSObject(SizeAboveLine[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SizeAboveLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SizeAboveLine[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SizeAboveLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SizeAboveLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class SizeBelowLine  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public SizeBelowLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.SizeBelowLine");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SizeBelowLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class SizeBelowLine_
    {
        public static dynamic GetTSObject(SizeBelowLine dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SizeBelowLine FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.SizeBelowLine)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SizeBelowLineArray_
    {
        public static dynamic GetTSObject(SizeBelowLine[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SizeBelowLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SizeBelowLine[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SizeBelowLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SizeBelowLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class TypeAboveLine  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public TypeAboveLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.TypeAboveLine");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TypeAboveLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class TypeAboveLine_
    {
        public static dynamic GetTSObject(TypeAboveLine dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TypeAboveLine FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.TypeAboveLine)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TypeAboveLineArray_
    {
        public static dynamic GetTSObject(TypeAboveLine[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TypeAboveLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TypeAboveLine[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TypeAboveLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TypeAboveLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class TypeBelowLine  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public TypeBelowLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.TypeBelowLine");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public TypeBelowLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class TypeBelowLine_
    {
        public static dynamic GetTSObject(TypeBelowLine dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TypeBelowLine FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.TypeBelowLine)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TypeBelowLineArray_
    {
        public static dynamic GetTSObject(TypeBelowLine[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TypeBelowLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TypeBelowLine[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TypeBelowLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TypeBelowLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class WeldingSite  : Dynamic.Tekla.Structures.Filtering.NumericFilterExpression
    {

        

        

		public WeldingSite()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.WeldFilterExpressions.WeldingSite");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public WeldingSite(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class WeldingSite_
    {
        public static dynamic GetTSObject(WeldingSite dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static WeldingSite FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions.WeldingSite)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class WeldingSiteArray_
    {
        public static dynamic GetTSObject(WeldingSite[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(WeldingSite_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static WeldingSite[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<WeldingSite>();
            foreach(var tsItem in tsArray)
            {
                list.Add(WeldingSite_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class WeldFilterExpressions_
    {
        public static dynamic GetTSObject(WeldFilterExpressions dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static WeldFilterExpressions FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.WeldFilterExpressions)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class WeldFilterExpressionsArray_
    {
        public static dynamic GetTSObject(WeldFilterExpressions[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(WeldFilterExpressions_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static WeldFilterExpressions[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<WeldFilterExpressions>();
            foreach(var tsItem in tsArray)
            {
                list.Add(WeldFilterExpressions_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
