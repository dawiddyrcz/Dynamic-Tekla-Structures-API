/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering.Categories
{

    public  class ObjectTypesFilterExpressions 
    {

        

        internal dynamic teklaObject;

		public ObjectTypesFilterExpressions() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ObjectTypesFilterExpressions(dynamic tsObject, System.DateTime nonConflictParameter)
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CustomBoolean", args);
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

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CustomBoolean)System.Activator.CreateInstance(type, parameters);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CustomDateTime", args);
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

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CustomDateTime)System.Activator.CreateInstance(type, parameters);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CustomNumber", args);
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

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CustomNumber)System.Activator.CreateInstance(type, parameters);
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
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CustomString", args);
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

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CustomString)System.Activator.CreateInstance(type, parameters);
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



    public  class CategoryName  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public CategoryName()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CategoryName");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CategoryName(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class CategoryName_
    {
        public static dynamic GetTSObject(CategoryName dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CategoryName FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.CategoryName)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CategoryNameArray_
    {
        public static dynamic GetTSObject(CategoryName[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CategoryName_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CategoryName[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CategoryName>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CategoryName_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class EntityName  : Dynamic.Tekla.Structures.Filtering.StringFilterExpression
    {

        

        

		public EntityName()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.EntityName");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public EntityName(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class EntityName_
    {
        public static dynamic GetTSObject(EntityName dynObject)
        {
            return dynObject.teklaObject;
        }

        public static EntityName FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions.EntityName)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EntityNameArray_
    {
        public static dynamic GetTSObject(EntityName[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EntityName_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EntityName[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<EntityName>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EntityName_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class ObjectTypesFilterExpressions_
    {
        public static dynamic GetTSObject(ObjectTypesFilterExpressions dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ObjectTypesFilterExpressions FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.Categories.ObjectTypesFilterExpressions)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ObjectTypesFilterExpressionsArray_
    {
        public static dynamic GetTSObject(ObjectTypesFilterExpressions[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ObjectTypesFilterExpressions_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ObjectTypesFilterExpressions[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ObjectTypesFilterExpressions>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ObjectTypesFilterExpressions_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
