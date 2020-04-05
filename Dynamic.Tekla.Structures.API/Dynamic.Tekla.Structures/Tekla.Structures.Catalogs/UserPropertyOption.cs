/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class UserPropertyOption 
    {

		public System.Int32 IntValue
		{
			get
			{
				try {
					return teklaObject.IntValue;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IntValue"); }
			}
			set
			{
				try {
					teklaObject.IntValue = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IntValue"); }
			}
		}

		public System.Double DoubleValue
		{
			get
			{
				try {
					return teklaObject.DoubleValue;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DoubleValue"); }
			}
			set
			{
				try {
					teklaObject.DoubleValue = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DoubleValue"); }
			}
		}

		public System.String StringValue
		{
			get
			{
				try {
					return teklaObject.StringValue;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StringValue"); }
			}
			set
			{
				try {
					teklaObject.StringValue = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StringValue"); }
			}
		}

		public System.String OptionLabel
		{
			get
			{
				try {
					return teklaObject.OptionLabel;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OptionLabel"); }
			}
			set
			{
				try {
					teklaObject.OptionLabel = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OptionLabel"); }
			}
		}

		public System.String OptionLabelTranslated
		{
			get
			{
				try {
					return teklaObject.OptionLabelTranslated;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OptionLabelTranslated"); }
			}
			set
			{
				try {
					teklaObject.OptionLabelTranslated = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OptionLabelTranslated"); }
			}
		}

        

        internal dynamic teklaObject;

		public UserPropertyOption()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.UserPropertyOption");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public UserPropertyOption(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class UserPropertyOption_
    {
        public static dynamic GetTSObject(UserPropertyOption dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static UserPropertyOption FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.UserPropertyOption)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UserPropertyOptionArray_
    {
        public static dynamic GetTSObject(UserPropertyOption[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(UserPropertyOption_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static UserPropertyOption[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<UserPropertyOption>();
            foreach(var tsItem in tsArray)
            {
                list.Add(UserPropertyOption_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
