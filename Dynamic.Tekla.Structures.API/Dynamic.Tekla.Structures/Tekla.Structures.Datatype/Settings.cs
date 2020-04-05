/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public  class Settings 
    {

        

        internal dynamic teklaObject;

		public Settings()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Datatype.Settings");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Settings(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public static System.Object GetValue(System.String name)
		{
			var parameters = new object[1];
			parameters[0] = name;
			var result = (System.Object) TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Settings", "GetValue", parameters);
			return result;
		}

		public static System.Boolean TryGetValue(System.String name, out System.Object obj)
		{
			var parameters = new object[2];
			parameters[0] = name;
			obj = new System.Object();
			parameters[1] = obj;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Settings", "TryGetValue", parameters);
			obj = (System.Object) parameters[1];
			return result;
		}

		public static System.Boolean TryGetValue<T>(System.String name, out T obj)
		{
			var parameters = new object[2];
			parameters[0] = name;
			obj = default(T);
			parameters[1] = obj;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Settings", "TryGetValue", parameters);
			obj = (T) parameters[1];
			return result;
		}

		public static void SetValue(System.String name, System.Object value)
		{
			var parameters = new object[2];
			parameters[0] = name;
			parameters[1] = value;
			TSActivator.InvokeStaticMethod("Tekla.Structures.Datatype.Settings", "SetValue", parameters);
		}





    }

    internal static class Settings_
    {
        public static dynamic GetTSObject(Settings dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Settings FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Datatype.Settings)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SettingsArray_
    {
        public static dynamic GetTSObject(Settings[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Settings_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Settings[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Settings>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Settings_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
