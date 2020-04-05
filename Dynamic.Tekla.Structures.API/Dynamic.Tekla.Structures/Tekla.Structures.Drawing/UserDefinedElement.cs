/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class UserDefinedElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
		}

		public System.String Value
		{
			get
			{
				try {
					return teklaObject.Value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value"); }
			}
			set
			{
				try {
					teklaObject.Value = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Value"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font"); }
			}
			set
			{
				try {
				teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.UnitAttributes Unit
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.UnitAttributes_.FromTSObject(teklaObject.Unit);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Unit"); }
			}
			set
			{
				try {
				teklaObject.Unit = Dynamic.Tekla.Structures.Drawing.UnitAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Unit"); }
			}
		}

        

        

		internal UserDefinedElement() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public UserDefinedElement(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public UserDefinedElement(System.String Name)
		{
			var args = new object[1];
			args[0] = Name;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UserDefinedElement", args);
		}
		public UserDefinedElement(System.String Name, Dynamic.Tekla.Structures.Drawing.FontAttributes Font)
		{
			var args = new object[2];
			args[0] = Name;
			args[1] = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(Font);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.UserDefinedElement", args);
		}





    }

    internal static class UserDefinedElement_
    {
        public static dynamic GetTSObject(UserDefinedElement dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static UserDefinedElement FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UserDefinedElement)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UserDefinedElementArray_
    {
        public static dynamic GetTSObject(UserDefinedElement[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(UserDefinedElement_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static UserDefinedElement[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<UserDefinedElement>();
            foreach(var tsItem in tsArray)
            {
                list.Add(UserDefinedElement_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
