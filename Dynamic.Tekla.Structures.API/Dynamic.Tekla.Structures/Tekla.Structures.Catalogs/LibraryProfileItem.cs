/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class LibraryProfileItem  : Dynamic.Tekla.Structures.Catalogs.ProfileItem
    {

		public System.Collections.ArrayList aProfileItemAnalysisParameters
		{
			get
			{
				try {
					return teklaObject.aProfileItemAnalysisParameters;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("aProfileItemAnalysisParameters"); }
			}

		}

		public System.Collections.ArrayList aProfileItemUserParameters
		{
			get
			{
				try {
					return teklaObject.aProfileItemUserParameters;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("aProfileItemUserParameters"); }
			}

		}

		public System.String ProfileName
		{
			get
			{
				try {
					return teklaObject.ProfileName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProfileName"); }
			}
			set
			{
				try {
					teklaObject.ProfileName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProfileName"); }
			}
		}

        

        

		public LibraryProfileItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.LibraryProfileItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LibraryProfileItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean Select(System.String profileName)
		{
			try {
			return teklaObject.Select(profileName);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Delete()
		{
			try {
			return teklaObject.Delete();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Delete()"); }
		}

		public System.Boolean Modify()
		{
			try {
			return teklaObject.Modify();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()"); }
		}

		public System.Boolean Copy(System.String newName)
		{
			try {
			return teklaObject.Copy(newName);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Copy()"); }
		}





    }

    internal static class LibraryProfileItem_
    {
        public static dynamic GetTSObject(LibraryProfileItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LibraryProfileItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.LibraryProfileItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LibraryProfileItemArray_
    {
        public static dynamic GetTSObject(LibraryProfileItem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LibraryProfileItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LibraryProfileItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LibraryProfileItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LibraryProfileItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
