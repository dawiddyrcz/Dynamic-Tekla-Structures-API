/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class DatabaseObject 
    {

        

        internal dynamic teklaObject;


		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean IsSameDatabaseObject(Dynamic.Tekla.Structures.Drawing.DatabaseObject Object)
		{
			return teklaObject.IsSameDatabaseObject(Dynamic.Tekla.Structures.Drawing.DatabaseObject_.GetTSObject(Object));
		}

		public System.Boolean SetUserProperty(System.String Name, System.String Value)
		{
			return teklaObject.SetUserProperty(Name, Value);
		}

		public System.Boolean SetUserProperty(System.String Name, System.Int32 Value)
		{
			return teklaObject.SetUserProperty(Name, Value);
		}

		public System.Boolean SetUserProperty(System.String Name, System.Double Value)
		{
			return teklaObject.SetUserProperty(Name, Value);
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.String Value)
		{
			return teklaObject.GetUserProperty(Name, ref Value);
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Int32 Value)
		{
			return teklaObject.GetUserProperty(Name, ref Value);
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Double Value)
		{
			return teklaObject.GetUserProperty(Name, ref Value);
		}

		public System.Boolean GetStringUserProperties(System.Collections.Generic.List<System.String> names, out System.Collections.Generic.Dictionary<System.String, System.String> values)
		{
			return teklaObject.GetStringUserProperties(names, out values);
		}

		public System.Boolean GetDoubleUserProperties(System.Collections.Generic.List<System.String> names, out System.Collections.Generic.Dictionary<System.String, System.Double> values)
		{
			return teklaObject.GetDoubleUserProperties(names, out values);
		}

		public System.Boolean GetIntegerUserProperties(System.Collections.Generic.List<System.String> names, out System.Collections.Generic.Dictionary<System.String, System.Int32> values)
		{
			return teklaObject.GetIntegerUserProperties(names, out values);
		}

		public System.Boolean GetStringUserProperties(out System.Collections.Generic.Dictionary<System.String, System.String> values)
		{
			return teklaObject.GetStringUserProperties(out values);
		}

		public System.Boolean GetDoubleUserProperties(out System.Collections.Generic.Dictionary<System.String, System.Double> values)
		{
			return teklaObject.GetDoubleUserProperties(out values);
		}

		public System.Boolean GetIntegerUserProperties(out System.Collections.Generic.Dictionary<System.String, System.Int32> values)
		{
			return teklaObject.GetIntegerUserProperties(out values);
		}





    }

    internal static class DatabaseObject_
    {
        public static dynamic GetTSObject(DatabaseObject dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DatabaseObject FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.DatabaseObject)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
