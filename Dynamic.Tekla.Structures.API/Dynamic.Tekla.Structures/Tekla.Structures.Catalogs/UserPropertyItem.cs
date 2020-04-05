/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class UserPropertyItem 
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public Dynamic.Tekla.Structures.PropertyTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.PropertyTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.PropertyTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyFieldTypeEnum FieldType
		{
			get => Dynamic.Tekla.Structures.Catalogs.UserPropertyFieldTypeEnum_.FromTSObject(teklaObject.FieldType);
			set { teklaObject.FieldType = Dynamic.Tekla.Structures.Catalogs.UserPropertyFieldTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyLevelEnum Level
		{
			get => Dynamic.Tekla.Structures.Catalogs.UserPropertyLevelEnum_.FromTSObject(teklaObject.Level);
			set { teklaObject.Level = Dynamic.Tekla.Structures.Catalogs.UserPropertyLevelEnum_.GetTSObject(value); }
		}

		public System.Boolean AffectsNumbering
		{
			get => teklaObject.AffectsNumbering;
			set { teklaObject.AffectsNumbering = value; }
		}

		public System.Boolean Unique
		{
			get => teklaObject.Unique;
			set { teklaObject.Unique = value; }
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyVisibilityEnum Visibility
		{
			get => Dynamic.Tekla.Structures.Catalogs.UserPropertyVisibilityEnum_.FromTSObject(teklaObject.Visibility);
			set { teklaObject.Visibility = Dynamic.Tekla.Structures.Catalogs.UserPropertyVisibilityEnum_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public UserPropertyItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.UserPropertyItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public UserPropertyItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean GetDefaultValue(ref System.Int32 DefaultValue)
		{
			try {
			return teklaObject.GetDefaultValue(ref DefaultValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDefaultValue()"); }
		}

		public System.Boolean SetDefaultValue(System.Int32 DefaultValue)
		{
			try {
			return teklaObject.SetDefaultValue(DefaultValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetDefaultValue()"); }
		}

		public System.Boolean GetDefaultValue(ref System.Double DefaultValue)
		{
			try {
			return teklaObject.GetDefaultValue(ref DefaultValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDefaultValue()"); }
		}

		public System.Boolean SetDefaultValue(System.Double DefaultValue)
		{
			try {
			return teklaObject.SetDefaultValue(DefaultValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetDefaultValue()"); }
		}

		public System.Boolean GetDefaultValue(ref System.String DefaultValue)
		{
			try {
			return teklaObject.GetDefaultValue(ref DefaultValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDefaultValue()"); }
		}

		public System.Boolean SetDefaultValue(System.String DefaultValue)
		{
			try {
			return teklaObject.SetDefaultValue(DefaultValue);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetDefaultValue()"); }
		}

		public System.Boolean GetOptions(ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32, System.String>> IntOptions)
		{
			try {
			return teklaObject.GetOptions(ref IntOptions);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetOptions()"); }
		}

		public System.Boolean GetOptions(ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32, System.String>> IntOptions, System.Boolean translatedLabels)
		{
			try {
			return teklaObject.GetOptions(ref IntOptions, translatedLabels);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetOptions()"); }
		}

		public System.Boolean SetOptions(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32, System.String>> IntOptions)
		{
			try {
			return teklaObject.SetOptions(IntOptions);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetOptions()"); }
		}

		public System.Boolean GetOptions(ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Double, System.String>> DoubleOptions)
		{
			try {
			return teklaObject.GetOptions(ref DoubleOptions);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetOptions()"); }
		}

		public System.Boolean GetOptions(ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Double, System.String>> DoubleOptions, System.Boolean translatedLabels)
		{
			try {
			return teklaObject.GetOptions(ref DoubleOptions, translatedLabels);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetOptions()"); }
		}

		public System.Boolean SetOptions(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Double, System.String>> DoubleOptions)
		{
			try {
			return teklaObject.SetOptions(DoubleOptions);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetOptions()"); }
		}

		public System.Boolean GetOptions(ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> StringOptions)
		{
			try {
			return teklaObject.GetOptions(ref StringOptions);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetOptions()"); }
		}

		public System.Boolean GetOptions(ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> StringOptions, System.Boolean translatedLabels)
		{
			try {
			return teklaObject.GetOptions(ref StringOptions, translatedLabels);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetOptions()"); }
		}

		public System.Boolean SetOptions(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> StringOptions)
		{
			try {
			return teklaObject.SetOptions(StringOptions);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetOptions()"); }
		}

		public void SetLabel(System.String label)
		{
			try {
			teklaObject.SetLabel(label);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetLabel()"); }
		}

		public System.String GetLabel()
		{
			try {
			return teklaObject.GetLabel();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetLabel()"); }
		}

		public System.String GetLabel(System.Boolean translated)
		{
			try {
			return teklaObject.GetLabel(translated);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetLabel()"); }
		}

		public System.Boolean Insert()
		{
			try {
			return teklaObject.Insert();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()"); }
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

		public System.Boolean Select()
		{
			try {
			return teklaObject.Select();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean GetObjectTypes(ref System.Collections.Generic.List<Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum> objectTypes)
		{
			try {
			return teklaObject.GetObjectTypes(ref objectTypes);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetObjectTypes()"); }
		}

		public System.Boolean AddToObjectType(Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum objectType)
		{
			try {
			return teklaObject.AddToObjectType(Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum_.GetTSObject(objectType));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AddToObjectType()"); }
		}

		public System.Boolean RemoveFromObjectType(Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum objectType)
		{
			try {
			return teklaObject.RemoveFromObjectType(Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum_.GetTSObject(objectType));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RemoveFromObjectType()"); }
		}





    }

    internal static class UserPropertyItem_
    {
        public static dynamic GetTSObject(UserPropertyItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static UserPropertyItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.UserPropertyItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UserPropertyItemArray_
    {
        public static dynamic GetTSObject(UserPropertyItem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(UserPropertyItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static UserPropertyItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<UserPropertyItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(UserPropertyItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
