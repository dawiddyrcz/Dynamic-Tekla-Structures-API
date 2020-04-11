/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class ComponentItem 
    {

		public System.String UIName
		{
			get
			{
				try {
					return teklaObject.UIName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UIName", ex); }
			}
			set
			{
				try {
					teklaObject.UIName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UIName", ex); }
			}
		}

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

		public Dynamic.Tekla.Structures.Catalogs.ComponentItem.ComponentTypeEnum Type
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.ComponentItem.ComponentTypeEnum_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type", ex); }
			}
			set
			{
				try {
				teklaObject.Type = Dynamic.Tekla.Structures.Catalogs.ComponentItem.ComponentTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type", ex); }
			}
		}

		public System.Int32 Number
		{
			get
			{
				try {
					return teklaObject.Number;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Number", ex); }
			}
			set
			{
				try {
					teklaObject.Number = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Number", ex); }
			}
		}

		public System.String AttributeFileExtension
		{
			get
			{
				try {
					return teklaObject.AttributeFileExtension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AttributeFileExtension", ex); }
			}

		}

        

        internal dynamic teklaObject;

		public ComponentItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.ComponentItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ComponentItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean Select(
	System.String name,
	System.Int32 number
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(name, number);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Select(
	System.String name,
	System.Int32 number,
	Dynamic.Tekla.Structures.Catalogs.ComponentItem.ComponentTypeEnum type_
	)
{
	
	
	var type = Dynamic.Tekla.Structures.Catalogs.ComponentItem.ComponentTypeEnum_.GetTSObject(type_);
    try
    {
        	var result = (System.Boolean) teklaObject.Select(name, number, type);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
    }
}



public System.Boolean Export(
	ref System.String filename
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.Export(ref filename);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Export), ex);
    }
}



public System.Boolean GetVersion(
	ref System.Int32 version
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetVersion(ref version);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetVersion), ex);
    }
}





    public enum ComponentTypeEnum
    {
			UNKNOWN,
			CONNECTION,
			COMPONENT,
			SEAM,
			DETAIL,
			DRAWING_PLUGIN,
			CUSTOM_PART        
    }

    internal static class ComponentTypeEnum_
    {
        public static dynamic GetTSObject(ComponentTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Catalogs.ComponentItem.ComponentTypeEnum").GetType();

            switch (dynEnum)
            {
				case ComponentTypeEnum.UNKNOWN:
					return System.Enum.Parse(tsType, "UNKNOWN");
				case ComponentTypeEnum.CONNECTION:
					return System.Enum.Parse(tsType, "CONNECTION");
				case ComponentTypeEnum.COMPONENT:
					return System.Enum.Parse(tsType, "COMPONENT");
				case ComponentTypeEnum.SEAM:
					return System.Enum.Parse(tsType, "SEAM");
				case ComponentTypeEnum.DETAIL:
					return System.Enum.Parse(tsType, "DETAIL");
				case ComponentTypeEnum.DRAWING_PLUGIN:
					return System.Enum.Parse(tsType, "DRAWING_PLUGIN");
				case ComponentTypeEnum.CUSTOM_PART:
					return System.Enum.Parse(tsType, "CUSTOM_PART");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ComponentTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UNKNOWN", System.StringComparison.InvariantCulture))
				return ComponentTypeEnum.UNKNOWN;
			else if (tsEnumValue.Equals("CONNECTION", System.StringComparison.InvariantCulture))
				return ComponentTypeEnum.CONNECTION;
			else if (tsEnumValue.Equals("COMPONENT", System.StringComparison.InvariantCulture))
				return ComponentTypeEnum.COMPONENT;
			else if (tsEnumValue.Equals("SEAM", System.StringComparison.InvariantCulture))
				return ComponentTypeEnum.SEAM;
			else if (tsEnumValue.Equals("DETAIL", System.StringComparison.InvariantCulture))
				return ComponentTypeEnum.DETAIL;
			else if (tsEnumValue.Equals("DRAWING_PLUGIN", System.StringComparison.InvariantCulture))
				return ComponentTypeEnum.DRAWING_PLUGIN;
			else if (tsEnumValue.Equals("CUSTOM_PART", System.StringComparison.InvariantCulture))
				return ComponentTypeEnum.CUSTOM_PART;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ComponentItem_
    {
        public static dynamic GetTSObject(ComponentItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ComponentItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.ComponentItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ComponentItemArray_
    {
        public static dynamic GetTSObject(ComponentItem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ComponentItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ComponentItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ComponentItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ComponentItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
