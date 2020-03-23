/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public  class BooleanConstantFilterExpression  : Dynamic.Tekla.Structures.Filtering.DataFilterExpression
    {

        

        

		public BooleanConstantFilterExpression() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BooleanConstantFilterExpression(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public BooleanConstantFilterExpression(System.Boolean Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.BooleanConstantFilterExpression", args);
		}
		public BooleanConstantFilterExpression(System.Boolean Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.BooleanConstantFilterExpression", args);
		}





    }

    internal static class BooleanConstantFilterExpression_
    {
        public static dynamic GetTSObject(BooleanConstantFilterExpression dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static BooleanConstantFilterExpression FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.BooleanConstantFilterExpression)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BooleanConstantFilterExpressionArray_
    {
        public static dynamic GetTSObject(BooleanConstantFilterExpression[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BooleanConstantFilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BooleanConstantFilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<BooleanConstantFilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BooleanConstantFilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
