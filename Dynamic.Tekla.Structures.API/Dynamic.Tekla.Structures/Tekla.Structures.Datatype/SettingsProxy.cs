/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Datatype
{

    public  class SettingsProxy 
    {

        

        internal dynamic teklaObject;

		public SettingsProxy()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Datatype.SettingsProxy");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SettingsProxy(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Object GetValue(System.String name)
		{
			return teklaObject.GetValue(name);
		}

		public System.Boolean TryGetValue(System.String name, out System.Object obj)
		{
			return teklaObject.TryGetValue(name, out obj);
		}

		public void SetValue(System.String name, System.Object value)
		{
			teklaObject.SetValue(name, value);
		}





    }

    internal static class SettingsProxy_
    {
        public static dynamic GetTSObject(SettingsProxy dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static SettingsProxy FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Datatype.SettingsProxy)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SettingsProxyArray_
    {
        public static dynamic GetTSObject(SettingsProxy[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SettingsProxy_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SettingsProxy[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<SettingsProxy>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SettingsProxy_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    