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
			get
			{
				try {
					return teklaObject.Prefix;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Prefix", ex); }
			}
			set
			{
				try {
					teklaObject.Prefix = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Prefix", ex); }
			}
		}

		public System.Int32 StartNumber
		{
			get
			{
				try {
					return teklaObject.StartNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartNumber", ex); }
			}
			set
			{
				try {
					teklaObject.StartNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartNumber", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public NumberingSeries()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeries");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public NumberingSeries(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static NumberingSeries FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.NumberingSeries)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NumberingSeriesArray_
    {
        public static dynamic GetTSObject(NumberingSeries[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NumberingSeries_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NumberingSeries[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<NumberingSeries>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NumberingSeries_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
