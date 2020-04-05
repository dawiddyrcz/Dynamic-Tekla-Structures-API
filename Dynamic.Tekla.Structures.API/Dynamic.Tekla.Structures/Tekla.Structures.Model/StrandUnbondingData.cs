/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class StrandUnbondingData 
    {

		public System.Int32 StrandIndex
		{
			get
			{
				try {
					return teklaObject.StrandIndex;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StrandIndex"); }
			}
			set
			{
				try {
					teklaObject.StrandIndex = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StrandIndex"); }
			}
		}

		public System.Double FromStart
		{
			get
			{
				try {
					return teklaObject.FromStart;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FromStart"); }
			}
			set
			{
				try {
					teklaObject.FromStart = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FromStart"); }
			}
		}

		public System.Double MiddleToStart
		{
			get
			{
				try {
					return teklaObject.MiddleToStart;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MiddleToStart"); }
			}
			set
			{
				try {
					teklaObject.MiddleToStart = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MiddleToStart"); }
			}
		}

		public System.Double MiddleToEnd
		{
			get
			{
				try {
					return teklaObject.MiddleToEnd;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MiddleToEnd"); }
			}
			set
			{
				try {
					teklaObject.MiddleToEnd = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MiddleToEnd"); }
			}
		}

		public System.Double FromEnd
		{
			get
			{
				try {
					return teklaObject.FromEnd;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FromEnd"); }
			}
			set
			{
				try {
					teklaObject.FromEnd = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FromEnd"); }
			}
		}

        

        internal dynamic teklaObject;

		public StrandUnbondingData()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.StrandUnbondingData");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public StrandUnbondingData(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class StrandUnbondingData_
    {
        public static dynamic GetTSObject(StrandUnbondingData dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static StrandUnbondingData FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.StrandUnbondingData)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StrandUnbondingDataArray_
    {
        public static dynamic GetTSObject(StrandUnbondingData[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StrandUnbondingData_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StrandUnbondingData[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<StrandUnbondingData>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StrandUnbondingData_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
