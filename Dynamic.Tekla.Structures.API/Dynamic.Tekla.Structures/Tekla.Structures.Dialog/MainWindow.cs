/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Dialog
{

    public  class MainWindow 
    {

		public System.IntPtr Handle
		{
			get
			{
				try {
					return teklaObject.Handle;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Handle"); }
			}

		}

		public static Dynamic.Tekla.Structures.Dialog.MainWindow Frame
		{
			get => Dynamic.Tekla.Structures.Dialog.MainWindow_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Dialog.MainWindow","Frame"));

		}

        

        internal dynamic teklaObject;

		internal MainWindow() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public MainWindow(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public void AddExternalWindow(System.String Name, System.IntPtr Handle)
		{
			try {
			teklaObject.AddExternalWindow(Name, Handle);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AddExternalWindow()"); }
		}

		public void RemoveExternalWindow(System.String Name, System.IntPtr Handle)
		{
			try {
			teklaObject.RemoveExternalWindow(Name, Handle);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveExternalWindow()"); }
		}





    }

    internal static class MainWindow_
    {
        public static dynamic GetTSObject(MainWindow dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static MainWindow FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Dialog.MainWindow)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MainWindowArray_
    {
        public static dynamic GetTSObject(MainWindow[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MainWindow_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MainWindow[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<MainWindow>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MainWindow_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
