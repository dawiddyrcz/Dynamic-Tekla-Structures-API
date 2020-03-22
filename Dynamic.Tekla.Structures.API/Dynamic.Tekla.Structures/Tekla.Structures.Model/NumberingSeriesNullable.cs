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

		public System.Int32 StartNumber
		{
			get => teklaObject.StartNumber;
			set { teklaObject.StartNumber = value; }
		}

        

        internal dynamic teklaObject;

		public NumberingSeriesNullable()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeriesNullable");
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
            var dynObject = (Tekla.Structures.Model.NumberingSeriesNullable)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
