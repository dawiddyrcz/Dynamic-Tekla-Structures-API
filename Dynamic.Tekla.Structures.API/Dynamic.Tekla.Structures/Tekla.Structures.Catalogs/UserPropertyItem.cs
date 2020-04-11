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
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

		public Dynamic.Tekla.Structures.PropertyTypeEnum Type
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.PropertyTypeEnum_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type", ex); }
			}
			set
			{
				try {
				teklaObject.Type = Dynamic.Tekla.Structures.PropertyTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyFieldTypeEnum FieldType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.UserPropertyFieldTypeEnum_.FromTSObject(teklaObject.FieldType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FieldType", ex); }
			}
			set
			{
				try {
				teklaObject.FieldType = Dynamic.Tekla.Structures.Catalogs.UserPropertyFieldTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FieldType", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyLevelEnum Level
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.UserPropertyLevelEnum_.FromTSObject(teklaObject.Level);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Level", ex); }
			}
			set
			{
				try {
				teklaObject.Level = Dynamic.Tekla.Structures.Catalogs.UserPropertyLevelEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Level", ex); }
			}
		}

		public System.Boolean AffectsNumbering
		{
			get
			{
				try {
					return teklaObject.AffectsNumbering;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AffectsNumbering", ex); }
			}
			set
			{
				try {
					teklaObject.AffectsNumbering = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AffectsNumbering", ex); }
			}
		}

		public System.Boolean Unique
		{
			get
			{
				try {
					return teklaObject.Unique;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Unique", ex); }
			}
			set
			{
				try {
					teklaObject.Unique = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Unique", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyVisibilityEnum Visibility
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.UserPropertyVisibilityEnum_.FromTSObject(teklaObject.Visibility);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Visibility", ex); }
			}
			set
			{
				try {
				teklaObject.Visibility = Dynamic.Tekla.Structures.Catalogs.UserPropertyVisibilityEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Visibility", ex); }
			}
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


public System.Boolean GetDefaultValue(
	ref System.Int32 DefaultValue
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetDefaultValue(ref DefaultValue);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDefaultValue), ex);
    }
}



public System.Boolean SetDefaultValue(
	System.Int32 DefaultValue
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetDefaultValue(DefaultValue);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetDefaultValue), ex);
    }
}



public System.Boolean GetDefaultValue(
	ref System.Double DefaultValue
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetDefaultValue(ref DefaultValue);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDefaultValue), ex);
    }
}



public System.Boolean SetDefaultValue(
	System.Double DefaultValue
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetDefaultValue(DefaultValue);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetDefaultValue), ex);
    }
}



public System.Boolean GetDefaultValue(
	ref System.String DefaultValue
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetDefaultValue(ref DefaultValue);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDefaultValue), ex);
    }
}



public System.Boolean SetDefaultValue(
	System.String DefaultValue
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetDefaultValue(DefaultValue);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetDefaultValue), ex);
    }
}



public System.Boolean GetOptions(
	ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32, System.String>> IntOptions
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetOptions(ref IntOptions);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetOptions), ex);
    }
}



public System.Boolean GetOptions(
	ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32, System.String>> IntOptions,
	System.Boolean translatedLabels
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetOptions(ref IntOptions, translatedLabels);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetOptions), ex);
    }
}



public System.Boolean SetOptions(
	System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32, System.String>> IntOptions
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetOptions(IntOptions);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetOptions), ex);
    }
}



public System.Boolean GetOptions(
	ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Double, System.String>> DoubleOptions
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetOptions(ref DoubleOptions);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetOptions), ex);
    }
}



public System.Boolean GetOptions(
	ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Double, System.String>> DoubleOptions,
	System.Boolean translatedLabels
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetOptions(ref DoubleOptions, translatedLabels);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetOptions), ex);
    }
}



public System.Boolean SetOptions(
	System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Double, System.String>> DoubleOptions
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetOptions(DoubleOptions);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetOptions), ex);
    }
}



public System.Boolean GetOptions(
	ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> StringOptions
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetOptions(ref StringOptions);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetOptions), ex);
    }
}



public System.Boolean GetOptions(
	ref System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> StringOptions,
	System.Boolean translatedLabels
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetOptions(ref StringOptions, translatedLabels);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetOptions), ex);
    }
}



public System.Boolean SetOptions(
	System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>> StringOptions
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetOptions(StringOptions);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetOptions), ex);
    }
}



public void SetLabel(
	System.String label
	)
{
	
    try
    {
        	teklaObject.SetLabel(label);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetLabel), ex);
    }
}



public System.String GetLabel()
{

    try
    {
        	var result = (System.String) teklaObject.GetLabel();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetLabel), ex);
    }
}



public System.String GetLabel(
	System.Boolean translated
	)
{
	
    try
    {
        	var result = (System.String) teklaObject.GetLabel(translated);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetLabel), ex);
    }
}



public System.Boolean Insert()
{

    try
    {
        	var result = (System.Boolean) teklaObject.Insert();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
    }
}



public System.Boolean Modify()
{

    try
    {
        	var result = (System.Boolean) teklaObject.Modify();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
    }
}



public System.Boolean Delete()
{

    try
    {
        	var result = (System.Boolean) teklaObject.Delete();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Delete), ex);
    }
}



public System.Boolean Select()
{

    try
    {
        	var result = (System.Boolean) teklaObject.Select();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean GetObjectTypes(
	ref System.Collections.Generic.List<Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum> objectTypes_
	)
{
	var objectTypes = ListConverter.ToTSObjects(objectTypes_);
    try
    {
        	var result = (System.Boolean) teklaObject.GetObjectTypes(ref objectTypes);
	objectTypes_ = ListConverter.FromTSObjects<System.Collections.Generic.List<Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum>>(objectTypes);
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjectTypes), ex);
    }
}



public System.Boolean AddToObjectType(
	Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum objectType_
	)
{
	var objectType = Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum_.GetTSObject(objectType_);
    try
    {
        	var result = (System.Boolean) teklaObject.AddToObjectType(objectType);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddToObjectType), ex);
    }
}



public System.Boolean RemoveFromObjectType(
	Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum objectType_
	)
{
	var objectType = Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum_.GetTSObject(objectType_);
    try
    {
        	var result = (System.Boolean) teklaObject.RemoveFromObjectType(objectType);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveFromObjectType), ex);
    }
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
    
