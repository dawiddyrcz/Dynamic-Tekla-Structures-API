/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public  class StringConstantFilterExpression  : Dynamic.Tekla.Structures.Filtering.DataFilterExpression
    {

        

        

		public StringConstantFilterExpression() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StringConstantFilterExpression(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public StringConstantFilterExpression(System.String Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.StringConstantFilterExpression", args);
		}
		public StringConstantFilterExpression(System.Collections.Generic.IEnumerable<System.String> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.StringConstantFilterExpression", args);
		}





    }

    internal static class StringConstantFilterExpression_
    {
        public static dynamic GetTSObject(StringConstantFilterExpression dynObject)
        {
            return dynObject.teklaObject;
        }

        public static StringConstantFilterExpression FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.StringConstantFilterExpression)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StringConstantFilterExpressionArray_
    {
        public static dynamic GetTSObject(StringConstantFilterExpression[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StringConstantFilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StringConstantFilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<StringConstantFilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StringConstantFilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
