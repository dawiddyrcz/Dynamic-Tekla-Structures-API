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
			get => teklaObject.CloningTemplateModelFolders;

		}

		public System.Collections.Generic.IEnumerable<System.String> CompanyFolders
		{
			get => teklaObject.CompanyFolders;

		}

		public System.Globalization.CultureInfo CultureInfo
		{
			get => teklaObject.CultureInfo;

		}

		public System.Collections.Generic.IEnumerable<System.String> DrawingMacros
		{
			get => teklaObject.DrawingMacros;

		}

		public System.String Language
		{
			get => teklaObject.Language;

		}

		public Dynamic.Tekla.Structures.Dialog.Localization Localization
		{
			get => Dynamic.Tekla.Structures.Dialog.Localization_.FromTSObject(teklaObject.Localization);

		}

		public System.String MacrosFolder
		{
			get => teklaObject.MacrosFolder;

		}

		public System.Collections.Generic.IEnumerable<System.String> ModelMacros
		{
			get => teklaObject.ModelMacros;

		}

		public System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<System.String, System.String>> OptionTypeUDAIndexAndValue
		{
			get => teklaObject.OptionTypeUDAIndexAndValue;

		}

		public System.Collections.Generic.IEnumerable<System.String> ProjectFolders
		{
			get => teklaObject.ProjectFolders;

		}

		public System.String SearchPath
		{
			get => teklaObject.SearchPath;

		}

		public System.Collections.Generic.IEnumerable<System.String> SystemFolders
		{
			get => teklaObject.SystemFolders;

		}

		public System.Boolean UseUSImperialUnitsInInput
		{
			get => teklaObject.UseUSImperialUnitsInInput;

		}

		public System.Collections.Generic.IEnumerable<System.String> UserDefinedAttributes
		{
			get => teklaObject.UserDefinedAttributes;

		}

		public System.Collections.Generic.IEnumerable<System.String> UserDefinedAttributesOptionType
		{
			get => teklaObject.UserDefinedAttributesOptionType;

		}

		public System.String Item
		{
			get => teklaObject.Item;

		}

        

        internal dynamic teklaObject;


		public void LoadLocalizationFile(System.String fileName)
		{
			teklaObject.LoadLocalizationFile(fileName);
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
    
