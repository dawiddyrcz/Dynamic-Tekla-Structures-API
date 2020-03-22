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

        

        

		public NumericConstantFilterExpression() {}
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
            return dynObject.teklaObject;
        }

        public static NumericConstantFilterExpression FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Filtering.NumericConstantFilterExpression)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
