/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class ParametricProfileItem  : Dynamic.Tekla.Structures.Catalogs.ProfileItem
    {

		public System.String ProfilePrefix
		{
			get
			{
				try {
					return teklaObject.ProfilePrefix;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProfilePrefix"); }
			}
			set
			{
				try {
					teklaObject.ProfilePrefix = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProfilePrefix"); }
			}
		}

        

        

		public ParametricProfileItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.ParametricProfileItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ParametricProfileItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public static System.String GetParametricProfilePrefix(System.Int32 Subtype)
		{
			var parameters = new object[1];
			parameters[0] = Subtype;
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.Catalogs.ParametricProfileItem", "GetParametricProfilePrefix", parameters);
			return result;
		}

		public System.String CreateProfileString()
		{
			try {
			return teklaObject.CreateProfileString();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CreateProfileString()"); }
		}

		public System.Boolean Select(System.String ProfileName)
		{
			try {
			return teklaObject.Select(ProfileName);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}





    }

    internal static class ParametricProfileItem_
    {
        public static dynamic GetTSObject(ParametricProfileItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ParametricProfileItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.ParametricProfileItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ParametricProfileItemArray_
    {
        public static dynamic GetTSObject(ParametricProfileItem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ParametricProfileItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ParametricProfileItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ParametricProfileItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ParametricProfileItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
