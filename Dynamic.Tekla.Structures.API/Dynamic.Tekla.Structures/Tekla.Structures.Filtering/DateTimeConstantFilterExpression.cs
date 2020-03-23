/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public  class DateTimeConstantFilterExpression  : Dynamic.Tekla.Structures.Filtering.DataFilterExpression
    {

        

        

		public DateTimeConstantFilterExpression() {}
		public DateTimeConstantFilterExpression(System.DateTime Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.DateTimeConstantFilterExpression", args);
		}
		public DateTimeConstantFilterExpression(System.Collections.Generic.IEnumerable<System.DateTime> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.DateTimeConstantFilterExpression", args);
		}
		public DateTimeConstantFilterExpression(System.DateTime Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.DateTimeConstantFilterExpression", args);
		}
		public DateTimeConstantFilterExpression(System.Collections.Generic.IEnumerable<System.DateTime> Values, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Values;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.DateTimeConstantFilterExpression", args);
		}





    }

    internal static class DateTimeConstantFilterExpression_
    {
        public static dynamic GetTSObject(DateTimeConstantFilterExpression dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DateTimeConstantFilterExpression FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Filtering.DateTimeConstantFilterExpression)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DateTimeConstantFilterExpressionArray_
    {
        public static dynamic GetTSObject(DateTimeConstantFilterExpression[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DateTimeConstantFilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DateTimeConstantFilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<DateTimeConstantFilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DateTimeConstantFilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
