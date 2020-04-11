/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class DrawingItem 
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

		public System.Collections.Generic.List<System.IO.FileInfo> Files
		{
			get
			{
				try {
					return teklaObject.Files;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Files", ex); }
			}
			set
			{
				try {
					teklaObject.Files = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Files", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Catalogs.AttributeConfiguration.DrawingTypes Type
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.AttributeConfiguration.DrawingTypes_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type", ex); }
			}
			set
			{
				try {
				teklaObject.Type = Dynamic.Tekla.Structures.Catalogs.AttributeConfiguration.DrawingTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public DrawingItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.DrawingItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean Select(
	System.String Name
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.Select(Name);

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






    }

    internal static class DrawingItem_
    {
        public static dynamic GetTSObject(DrawingItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.DrawingItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingItemArray_
    {
        public static dynamic GetTSObject(DrawingItem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DrawingItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
