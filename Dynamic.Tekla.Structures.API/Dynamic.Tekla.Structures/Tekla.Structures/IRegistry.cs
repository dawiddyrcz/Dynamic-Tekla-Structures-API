/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public abstract class IRegistry 
    {

		public Microsoft.Win32.RegistryKey CurrentVersion
		{
			get
			{
				try {
					return teklaObject.CurrentVersion;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CurrentVersion", ex); }
			}

		}

		public Microsoft.Win32.RegistryKey Root
		{
			get
			{
				try {
					return teklaObject.Root;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Root", ex); }
			}

		}

        

        internal dynamic teklaObject;


		public Microsoft.Win32.RegistryKey GetVersion(System.String version)
		{
			try {
			var result = teklaObject.GetVersion(version);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetVersion()", ex); }
		}

		public System.Drawing.Rectangle LoadDialogBounds(System.String dialogName)
		{
			try {
			var result = teklaObject.LoadDialogBounds(dialogName);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LoadDialogBounds()", ex); }
		}

		public System.Drawing.Rectangle LoadDialogBounds(System.String dialogName, System.String version)
		{
			try {
			var result = teklaObject.LoadDialogBounds(dialogName, version);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LoadDialogBounds()", ex); }
		}

		public void SaveDialogBounds(System.String dialogName, System.Drawing.Rectangle bounds)
		{
			try {
			teklaObject.SaveDialogBounds(dialogName, bounds);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SaveDialogBounds()", ex); }
		}

		public void SaveDialogBounds(System.String dialogName, System.String version, System.Drawing.Rectangle bounds)
		{
			try {
			teklaObject.SaveDialogBounds(dialogName, version, bounds);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SaveDialogBounds()", ex); }
		}





    }

    internal static class IRegistry_
    {
        public static dynamic GetTSObject(IRegistry dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IRegistry FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.IRegistry)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IRegistryArray_
    {
        public static dynamic GetTSObject(IRegistry[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IRegistry_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IRegistry[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IRegistry>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IRegistry_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
