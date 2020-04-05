/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Dialog
{

    public  class Localization  : System.MarshalByRefObject
    {

		public static System.String DefaultLocalizationFile
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Dialog.Localization","DefaultLocalizationFile");

		}

		public static System.String DefaultLocalizationPath
		{
			get => (System.String) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Dialog.Localization","DefaultLocalizationPath");

		}

		public System.String Language
		{
			get => teklaObject.Language;
			set { teklaObject.Language = value; }
		}

        

        internal dynamic teklaObject;

		public Localization()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Dialog.Localization");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Localization(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Localization(System.String fileName, System.String language)
		{
			var args = new object[2];
			args[0] = fileName;
			args[1] = language;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Dialog.Localization", args);
		}

		public void LoadFile(System.String fileName)
		{
			teklaObject.LoadFile(fileName);
		}

		public void LoadAidFile(System.String fileName)
		{
			teklaObject.LoadAidFile(fileName);
		}

		public void LoadAilFile(System.String fileName)
		{
			teklaObject.LoadAilFile(fileName);
		}

		public void LoadXMLFile(System.String fileName)
		{
			teklaObject.LoadXMLFile(fileName);
		}

		public void RegisterLocalizationCallback(Dynamic.Tekla.Structures.Dialog.Localization.LocalizationCallback cb,  params System.Type[] types)
		{
			teklaObject.RegisterLocalizationCallback(Dynamic.Tekla.Structures.Dialog.Localization.LocalizationCallback_.GetTSObject(cb), types);
		}

		public void LocalizeToolTip(System.Windows.Forms.Control control, System.Windows.Forms.ToolTip toolTip)
		{
			teklaObject.LocalizeToolTip(control, toolTip);
		}

		public void Localize(System.Windows.Forms.MenuItem menuItem)
		{
			teklaObject.Localize(menuItem);
		}

		public void Localize(System.Windows.Forms.Control control)
		{
			teklaObject.Localize(control);
		}

		public void Localize(System.Configuration.ApplicationSettingsBase applicationSettings)
		{
			teklaObject.Localize(applicationSettings);
		}

		public System.String GetText(System.String name)
		{
			return teklaObject.GetText(name);
		}




    public  class LocalizationCallback 
    {

        

        internal dynamic teklaObject;

		internal LocalizationCallback() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LocalizationCallback(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public LocalizationCallback(System.Object @object, System.IntPtr method)
		{
			var args = new object[2];
			args[0] = @object;
			args[1] = method;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Dialog.Localization.LocalizationCallback", args);
		}

		public void Invoke(Dynamic.Tekla.Structures.Dialog.Localization localization, System.Object obj)
		{
			teklaObject.Invoke(Dynamic.Tekla.Structures.Dialog.Localization_.GetTSObject(localization), obj);
		}

		public void EndInvoke(System.IAsyncResult resultt)
		{
			teklaObject.EndInvoke(resultt);
		}





    }

    internal static class LocalizationCallback_
    {
        public static dynamic GetTSObject(LocalizationCallback dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LocalizationCallback FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Dialog.Localization.LocalizationCallback)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LocalizationCallbackArray_
    {
        public static dynamic GetTSObject(LocalizationCallback[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LocalizationCallback_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LocalizationCallback[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LocalizationCallback>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LocalizationCallback_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class Util 
    {

        

        internal dynamic teklaObject;

		public Util()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Dialog.Localization.Util");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Util(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public static void LocalizeListControl(Dynamic.Tekla.Structures.Dialog.Localization localization, System.Object obj)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Dialog.Localization_.GetTSObject(localization);
			parameters[1] = obj;
			TSActivator.InvokeStaticMethod("Tekla.Structures.Dialog.Localization.Util", "LocalizeListControl", parameters);
		}

		public static void LocalizeDataGridView(Dynamic.Tekla.Structures.Dialog.Localization localization, System.Object obj)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Dialog.Localization_.GetTSObject(localization);
			parameters[1] = obj;
			TSActivator.InvokeStaticMethod("Tekla.Structures.Dialog.Localization.Util", "LocalizeDataGridView", parameters);
		}

		public static void LocalizeToolStrip(Dynamic.Tekla.Structures.Dialog.Localization localization, System.Object obj)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Dialog.Localization_.GetTSObject(localization);
			parameters[1] = obj;
			TSActivator.InvokeStaticMethod("Tekla.Structures.Dialog.Localization.Util", "LocalizeToolStrip", parameters);
		}

		public static void LocalizeImageListComboBox(Dynamic.Tekla.Structures.Dialog.Localization localization, System.Object obj)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Dialog.Localization_.GetTSObject(localization);
			parameters[1] = obj;
			TSActivator.InvokeStaticMethod("Tekla.Structures.Dialog.Localization.Util", "LocalizeImageListComboBox", parameters);
		}




    public  class PropertyLocalizer 
    {

        

        internal dynamic teklaObject;

		internal PropertyLocalizer() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PropertyLocalizer(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public PropertyLocalizer(System.String propertyName)
		{
			var args = new object[1];
			args[0] = propertyName;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Dialog.Localization.Util.PropertyLocalizer", args);
		}

		public void Localize(Dynamic.Tekla.Structures.Dialog.Localization localization, System.Object obj)
		{
			teklaObject.Localize(Dynamic.Tekla.Structures.Dialog.Localization_.GetTSObject(localization), obj);
		}





    }

    internal static class PropertyLocalizer_
    {
        public static dynamic GetTSObject(PropertyLocalizer dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PropertyLocalizer FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Dialog.Localization.Util.PropertyLocalizer)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PropertyLocalizerArray_
    {
        public static dynamic GetTSObject(PropertyLocalizer[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PropertyLocalizer_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PropertyLocalizer[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PropertyLocalizer>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PropertyLocalizer_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Util_
    {
        public static dynamic GetTSObject(Util dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Util FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Dialog.Localization.Util)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UtilArray_
    {
        public static dynamic GetTSObject(Util[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Util_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Util[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Util>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Util_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Localization_
    {
        public static dynamic GetTSObject(Localization dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Localization FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Dialog.Localization)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LocalizationArray_
    {
        public static dynamic GetTSObject(Localization[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Localization_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Localization[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Localization>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Localization_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
