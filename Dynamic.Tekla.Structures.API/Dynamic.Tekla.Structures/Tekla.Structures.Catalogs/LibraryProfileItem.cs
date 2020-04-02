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
			get => teklaObject.aProfileItemAnalysisParameters;

		}

		public System.Collections.ArrayList aProfileItemUserParameters
		{
			get => teklaObject.aProfileItemUserParameters;

		}

		public System.String ProfileName
		{
			get => teklaObject.ProfileName;
			set { teklaObject.ProfileName = value; }
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
			return teklaObject.Select(profileName);
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Copy(System.String newName)
		{
			return teklaObject.Copy(newName);
		}





    }

    internal static class LibraryProfileItem_
    {
        public static dynamic GetTSObject(LibraryProfileItem dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static LibraryProfileItem FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LibraryProfileItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LibraryProfileItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<LibraryProfileItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LibraryProfileItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
