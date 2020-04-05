/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Filtering
{

    public  class NumericConstantFilterExpression  : Dynamic.Tekla.Structures.Filtering.DataFilterExpression
    {

        

        

		internal NumericConstantFilterExpression() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NumericConstantFilterExpression(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public NumericConstantFilterExpression(Dynamic.Tekla.Structures.TeklaStructuresDatabaseTypeEnum ObjectType)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.TeklaStructuresDatabaseTypeEnum_.GetTSObject(ObjectType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<Dynamic.Tekla.Structures.TeklaStructuresDatabaseTypeEnum> ObjectTypes)
		{
			var args = new object[1];
			args[0] = ObjectTypes;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Int16 Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.Int16> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.UInt16 Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.UInt16> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Int32 Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.Int32> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.UInt32 Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.UInt32> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Int64 Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.Int64> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.UInt64 Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.UInt64> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Double Value)
		{
			var args = new object[1];
			args[0] = Value;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.Double> Values)
		{
			var args = new object[1];
			args[0] = Values;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Int16 Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.Int16> Values, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Values;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.UInt16 Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.UInt16> Values, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Values;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Int32 Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.Int32> Values, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Values;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.UInt32 Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.UInt32> Values, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Values;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Int64 Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.Int64> Values, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Values;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.UInt64 Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.UInt64> Values, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Values;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Double Value, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Value;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}
		public NumericConstantFilterExpression(System.Collections.Generic.IEnumerable<System.Double> Values, System.IFormatProvider Provider)
		{
			var args = new object[2];
			args[0] = Values;
			args[1] = Provider;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Filtering.NumericConstantFilterExpression", args);
		}





    }

    internal static class NumericConstantFilterExpression_
    {
        public static dynamic GetTSObject(NumericConstantFilterExpression dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static NumericConstantFilterExpression FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Filtering.NumericConstantFilterExpression)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NumericConstantFilterExpressionArray_
    {
        public static dynamic GetTSObject(NumericConstantFilterExpression[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NumericConstantFilterExpression_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NumericConstantFilterExpression[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<NumericConstantFilterExpression>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NumericConstantFilterExpression_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
