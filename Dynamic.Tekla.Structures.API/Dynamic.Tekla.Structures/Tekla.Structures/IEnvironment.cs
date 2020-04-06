/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public abstract class IEnvironment 
    {

		public System.Collections.Generic.IEnumerable<System.String> CloningTemplateModelFolders
		{
			get
			{
				try {
					return teklaObject.CloningTemplateModelFolders;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CloningTemplateModelFolders", ex); }
			}

		}

		public System.Collections.Generic.IEnumerable<System.String> CompanyFolders
		{
			get
			{
				try {
					return teklaObject.CompanyFolders;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CompanyFolders", ex); }
			}

		}

		public System.Globalization.CultureInfo CultureInfo
		{
			get
			{
				try {
					return teklaObject.CultureInfo;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CultureInfo", ex); }
			}

		}

		public System.Collections.Generic.IEnumerable<System.String> DrawingMacros
		{
			get
			{
				try {
					return teklaObject.DrawingMacros;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawingMacros", ex); }
			}

		}

		public System.String Language
		{
			get
			{
				try {
					return teklaObject.Language;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Language", ex); }
			}

		}

		public Dynamic.Tekla.Structures.Dialog.Localization Localization
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Dialog.Localization_.FromTSObject(teklaObject.Localization);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Localization", ex); }
			}
		}

		public System.String MacrosFolder
		{
			get
			{
				try {
					return teklaObject.MacrosFolder;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MacrosFolder", ex); }
			}

		}

		public System.Collections.Generic.IEnumerable<System.String> ModelMacros
		{
			get
			{
				try {
					return teklaObject.ModelMacros;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelMacros", ex); }
			}

		}

		public System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<System.String, System.String>> OptionTypeUDAIndexAndValue
		{
			get
			{
				try {
					return teklaObject.OptionTypeUDAIndexAndValue;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OptionTypeUDAIndexAndValue", ex); }
			}

		}

		public System.Collections.Generic.IEnumerable<System.String> ProjectFolders
		{
			get
			{
				try {
					return teklaObject.ProjectFolders;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProjectFolders", ex); }
			}

		}

		public System.String SearchPath
		{
			get
			{
				try {
					return teklaObject.SearchPath;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SearchPath", ex); }
			}

		}

		public System.Collections.Generic.IEnumerable<System.String> SystemFolders
		{
			get
			{
				try {
					return teklaObject.SystemFolders;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SystemFolders", ex); }
			}

		}

		public System.Boolean UseUSImperialUnitsInInput
		{
			get
			{
				try {
					return teklaObject.UseUSImperialUnitsInInput;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UseUSImperialUnitsInInput", ex); }
			}

		}

		public System.Collections.Generic.IEnumerable<System.String> UserDefinedAttributes
		{
			get
			{
				try {
					return teklaObject.UserDefinedAttributes;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UserDefinedAttributes", ex); }
			}

		}

		public System.Collections.Generic.IEnumerable<System.String> UserDefinedAttributesOptionType
		{
			get
			{
				try {
					return teklaObject.UserDefinedAttributesOptionType;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UserDefinedAttributesOptionType", ex); }
			}

		}

		public System.String Item
		{
			get
			{
				try {
					return teklaObject.Item;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Item", ex); }
			}

		}

        

        internal dynamic teklaObject;


		public void LoadLocalizationFile(System.String fileName)
		{
			try {
			teklaObject.LoadLocalizationFile(fileName);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("LoadLocalizationFile()", ex); }
		}





    }

    internal static class IEnvironment_
    {
        public static dynamic GetTSObject(IEnvironment dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IEnvironment FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.IEnvironment)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IEnvironmentArray_
    {
        public static dynamic GetTSObject(IEnvironment[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IEnvironment_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IEnvironment[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IEnvironment>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IEnvironment_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
