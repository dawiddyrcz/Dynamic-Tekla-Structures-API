/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class NumberingSeriesNullable 
    {

		public System.String Prefix
		{
			get => teklaObject.Prefix;
			set { teklaObject.Prefix = value; }
		}

		public System.Nullable<System.Int32> StartNumber
		{
			get => teklaObject.StartNumber;
			set { teklaObject.StartNumber = value; }
		}

        

        internal dynamic teklaObject;

		public NumberingSeriesNullable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeriesNullable");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NumberingSeriesNullable(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public NumberingSeriesNullable(System.String prefix, System.Int32 number)
		{
			var args = new object[2];
			args[0] = prefix;
			args[1] = number;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeriesNullable", args);
		}





    }

    internal static class NumberingSeriesNullable_
    {
        public static dynamic GetTSObject(NumberingSeriesNullable dynObject)
        {
            return dynObject.teklaObject;
        }

        public static NumberingSeriesNullable FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.NumberingSeriesNullable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NumberingSeriesNullableArray_
    {
        public static dynamic GetTSObject(NumberingSeriesNullable[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NumberingSeriesNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NumberingSeriesNullable[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<NumberingSeriesNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NumberingSeriesNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
