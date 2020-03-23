/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class NumberingSeries 
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

		public NumberingSeries()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeries");
		}
		public NumberingSeries(System.String Prefix, System.Int32 Number)
		{
			var args = new object[2];
			args[0] = Prefix;
			args[1] = Number;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeries", args);
		}





    }

    internal static class NumberingSeries_
    {
        public static dynamic GetTSObject(NumberingSeries dynObject)
        {
            return dynObject.teklaObject;
        }

        public static NumberingSeries FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.NumberingSeries)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
