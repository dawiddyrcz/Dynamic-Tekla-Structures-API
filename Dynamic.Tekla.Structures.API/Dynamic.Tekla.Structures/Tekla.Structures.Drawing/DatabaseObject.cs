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
			var result = teklaObject.Insert();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()", ex); }
		}

		public System.Boolean Select()
		{
			try {
			var result = teklaObject.Select();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()", ex); }
		}

		public System.Boolean Modify()
		{
			try {
			var result = teklaObject.Modify();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()", ex); }
		}

		public System.Boolean Delete()
		{
			try {
			var result = teklaObject.Delete();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Delete()", ex); }
		}

		public System.Boolean IsSameDatabaseObject(Dynamic.Tekla.Structures.Drawing.DatabaseObject Object)
		{
			try {
			var result = teklaObject.IsSameDatabaseObject(Dynamic.Tekla.Structures.Drawing.DatabaseObject_.GetTSObject(Object));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsSameDatabaseObject()", ex); }
		}

		public System.Boolean SetUserProperty(System.String Name, System.String Value)
		{
			try {
			var result = teklaObject.SetUserProperty(Name, Value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()", ex); }
		}

		public System.Boolean SetUserProperty(System.String Name, System.Int32 Value)
		{
			try {
			var result = teklaObject.SetUserProperty(Name, Value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()", ex); }
		}

		public System.Boolean SetUserProperty(System.String Name, System.Double Value)
		{
			try {
			var result = teklaObject.SetUserProperty(Name, Value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()", ex); }
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.String Value)
		{
			try {
			var result = teklaObject.GetUserProperty(Name, ref Value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserProperty()", ex); }
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Int32 Value)
		{
			try {
			var result = teklaObject.GetUserProperty(Name, ref Value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserProperty()", ex); }
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Double Value)
		{
			try {
			var result = teklaObject.GetUserProperty(Name, ref Value);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserProperty()", ex); }
		}

		public System.Boolean GetStringUserProperties(System.Collections.Generic.List<System.String> names, out System.Collections.Generic.Dictionary<System.String, System.String> values)
		{
			try {
			var result = teklaObject.GetStringUserProperties(names, out values);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetStringUserProperties()", ex); }
		}

		public System.Boolean GetDoubleUserProperties(System.Collections.Generic.List<System.String> names, out System.Collections.Generic.Dictionary<System.String, System.Double> values)
		{
			try {
			var result = teklaObject.GetDoubleUserProperties(names, out values);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDoubleUserProperties()", ex); }
		}

		public System.Boolean GetIntegerUserProperties(System.Collections.Generic.List<System.String> names, out System.Collections.Generic.Dictionary<System.String, System.Int32> values)
		{
			try {
			var result = teklaObject.GetIntegerUserProperties(names, out values);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetIntegerUserProperties()", ex); }
		}

		public System.Boolean GetStringUserProperties(out System.Collections.Generic.Dictionary<System.String, System.String> values)
		{
			try {
			var result = teklaObject.GetStringUserProperties(out values);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetStringUserProperties()", ex); }
		}

		public System.Boolean GetDoubleUserProperties(out System.Collections.Generic.Dictionary<System.String, System.Double> values)
		{
			try {
			var result = teklaObject.GetDoubleUserProperties(out values);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDoubleUserProperties()", ex); }
		}

		public System.Boolean GetIntegerUserProperties(out System.Collections.Generic.Dictionary<System.String, System.Int32> values)
		{
			try {
			var result = teklaObject.GetIntegerUserProperties(out values);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetIntegerUserProperties()", ex); }
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
    
