/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Filtering
{

    public  class DateTimeConstantFilterExpression  : Dynamic.Tekla.Structures.Filtering.DataFilterExpression
    {

        

        

		internal DateTimeConstantFilterExpression() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DateTimeConstantFilterExpression(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DateTimeConstantFilterExpression FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.DateTimeConstantFilterExpression)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DateTimeConstantFilterExpressionArray_
    {
        public static dynamic GetTSObject(DateTimeConstantFilterExpression[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DateTimeConstantFilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DateTimeConstantFilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DateTimeConstantFilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DateTimeConstantFilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
