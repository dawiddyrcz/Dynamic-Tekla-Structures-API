/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public  class NumericFilterExpression  : Dynamic.Tekla.Structures.Filtering.DataFilterExpression
    {

        

        

		public NumericFilterExpression() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NumericFilterExpression(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class NumericFilterExpression_
    {
        public static dynamic GetTSObject(NumericFilterExpression dynObject)
        {
            return dynObject.teklaObject;
        }

        public static NumericFilterExpression FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.NumericFilterExpression)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NumericFilterExpressionArray_
    {
        public static dynamic GetTSObject(NumericFilterExpression[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NumericFilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NumericFilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<NumericFilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NumericFilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
