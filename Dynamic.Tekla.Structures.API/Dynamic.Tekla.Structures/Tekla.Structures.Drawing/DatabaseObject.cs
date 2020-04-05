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
			try {
			return teklaObject.Insert();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()"); }
		}

		public System.Boolean Select()
		{
			try {
			return teklaObject.Select();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Modify()
		{
			try {
			return teklaObject.Modify();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()"); }
		}

		public System.Boolean Delete()
		{
			try {
			return teklaObject.Delete();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Delete()"); }
		}

		public System.Boolean IsSameDatabaseObject(Dynamic.Tekla.Structures.Drawing.DatabaseObject Object)
		{
			try {
			return teklaObject.IsSameDatabaseObject(Dynamic.Tekla.Structures.Drawing.DatabaseObject_.GetTSObject(Object));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsSameDatabaseObject()"); }
		}

		public System.Boolean SetUserProperty(System.String Name, System.String Value)
		{
			try {
			return teklaObject.SetUserProperty(Name, Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()"); }
		}

		public System.Boolean SetUserProperty(System.String Name, System.Int32 Value)
		{
			try {
			return teklaObject.SetUserProperty(Name, Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()"); }
		}

		public System.Boolean SetUserProperty(System.String Name, System.Double Value)
		{
			try {
			return teklaObject.SetUserProperty(Name, Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()"); }
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.String Value)
		{
			try {
			return teklaObject.GetUserProperty(Name, ref Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserProperty()"); }
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Int32 Value)
		{
			try {
			return teklaObject.GetUserProperty(Name, ref Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserProperty()"); }
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Double Value)
		{
			try {
			return teklaObject.GetUserProperty(Name, ref Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserProperty()"); }
		}

		public System.Boolean GetStringUserProperties(System.Collections.Generic.List<System.String> names, out System.Collections.Generic.Dictionary<System.String, System.String> values)
		{
			try {
			return teklaObject.GetStringUserProperties(names, out values);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetStringUserProperties()"); }
		}

		public System.Boolean GetDoubleUserProperties(System.Collections.Generic.List<System.String> names, out System.Collections.Generic.Dictionary<System.String, System.Double> values)
		{
			try {
			return teklaObject.GetDoubleUserProperties(names, out values);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDoubleUserProperties()"); }
		}

		public System.Boolean GetIntegerUserProperties(System.Collections.Generic.List<System.String> names, out System.Collections.Generic.Dictionary<System.String, System.Int32> values)
		{
			try {
			return teklaObject.GetIntegerUserProperties(names, out values);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetIntegerUserProperties()"); }
		}

		public System.Boolean GetStringUserProperties(out System.Collections.Generic.Dictionary<System.String, System.String> values)
		{
			try {
			return teklaObject.GetStringUserProperties(out values);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetStringUserProperties()"); }
		}

		public System.Boolean GetDoubleUserProperties(out System.Collections.Generic.Dictionary<System.String, System.Double> values)
		{
			try {
			return teklaObject.GetDoubleUserProperties(out values);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDoubleUserProperties()"); }
		}

		public System.Boolean GetIntegerUserProperties(out System.Collections.Generic.Dictionary<System.String, System.Int32> values)
		{
			try {
			return teklaObject.GetIntegerUserProperties(out values);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetIntegerUserProperties()"); }
		}





    }

    internal static class DatabaseObject_
    {
        public static dynamic GetTSObject(DatabaseObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DatabaseObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DatabaseObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DatabaseObjectArray_
    {
        public static dynamic GetTSObject(DatabaseObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DatabaseObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DatabaseObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DatabaseObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DatabaseObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
