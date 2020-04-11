/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ProjectInfo 
    {

		public System.String Description
		{
			get
			{
				try {
					return teklaObject.Description;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Description", ex); }
			}
			set
			{
				try {
					teklaObject.Description = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Description", ex); }
			}
		}

		public System.String StartDate
		{
			get
			{
				try {
					return teklaObject.StartDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartDate", ex); }
			}
			set
			{
				try {
					teklaObject.StartDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartDate", ex); }
			}
		}

		public System.String EndDate
		{
			get
			{
				try {
					return teklaObject.EndDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndDate", ex); }
			}
			set
			{
				try {
					teklaObject.EndDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndDate", ex); }
			}
		}

		public System.String Object
		{
			get
			{
				try {
					return teklaObject.Object;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Object", ex); }
			}
			set
			{
				try {
					teklaObject.Object = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Object", ex); }
			}
		}

		public System.String Designer
		{
			get
			{
				try {
					return teklaObject.Designer;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Designer", ex); }
			}
			set
			{
				try {
					teklaObject.Designer = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Designer", ex); }
			}
		}

		public System.String Location
		{
			get
			{
				try {
					return teklaObject.Location;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Location", ex); }
			}
			set
			{
				try {
					teklaObject.Location = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Location", ex); }
			}
		}

		public System.String Address
		{
			get
			{
				try {
					return teklaObject.Address;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Address", ex); }
			}
			set
			{
				try {
					teklaObject.Address = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Address", ex); }
			}
		}

		public System.String PostalBox
		{
			get
			{
				try {
					return teklaObject.PostalBox;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PostalBox", ex); }
			}
			set
			{
				try {
					teklaObject.PostalBox = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PostalBox", ex); }
			}
		}

		public System.String Town
		{
			get
			{
				try {
					return teklaObject.Town;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Town", ex); }
			}
			set
			{
				try {
					teklaObject.Town = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Town", ex); }
			}
		}

		public System.String Region
		{
			get
			{
				try {
					return teklaObject.Region;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Region", ex); }
			}
			set
			{
				try {
					teklaObject.Region = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Region", ex); }
			}
		}

		public System.String PostalCode
		{
			get
			{
				try {
					return teklaObject.PostalCode;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PostalCode", ex); }
			}
			set
			{
				try {
					teklaObject.PostalCode = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PostalCode", ex); }
			}
		}

		public System.String Country
		{
			get
			{
				try {
					return teklaObject.Country;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Country", ex); }
			}
			set
			{
				try {
					teklaObject.Country = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Country", ex); }
			}
		}

		public System.String Builder
		{
			get
			{
				try {
					return teklaObject.Builder;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Builder", ex); }
			}
			set
			{
				try {
					teklaObject.Builder = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Builder", ex); }
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

		public System.String ProjectNumber
		{
			get
			{
				try {
					return teklaObject.ProjectNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProjectNumber", ex); }
			}
			set
			{
				try {
					teklaObject.ProjectNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProjectNumber", ex); }
			}
		}

		public System.IO.DirectoryInfo ModelSharingLocalPath
		{
			get
			{
				try {
					return teklaObject.ModelSharingLocalPath;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelSharingLocalPath", ex); }
			}
			set
			{
				try {
					teklaObject.ModelSharingLocalPath = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelSharingLocalPath", ex); }
			}
		}

		public System.Uri ModelSharingServerPath
		{
			get
			{
				try {
					return teklaObject.ModelSharingServerPath;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelSharingServerPath", ex); }
			}
			set
			{
				try {
					teklaObject.ModelSharingServerPath = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelSharingServerPath", ex); }
			}
		}

		public System.String Info1
		{
			get
			{
				try {
					return teklaObject.Info1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Info1", ex); }
			}
			set
			{
				try {
					teklaObject.Info1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Info1", ex); }
			}
		}

		public System.String Info2
		{
			get
			{
				try {
					return teklaObject.Info2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Info2", ex); }
			}
			set
			{
				try {
					teklaObject.Info2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Info2", ex); }
			}
		}

		public System.String GUID
		{
			get
			{
				try {
					return teklaObject.GUID;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GUID", ex); }
			}
			set
			{
				try {
					teklaObject.GUID = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GUID", ex); }
			}
		}

        

        internal dynamic teklaObject;

		internal ProjectInfo() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ProjectInfo(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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



public System.Boolean GetUserProperty(
	System.String Name,
	ref System.String Value
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetUserProperty(Name, ref Value);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
    }
}



public System.Boolean GetUserProperty(
	System.String Name,
	ref System.Int32 Value
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetUserProperty(Name, ref Value);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
    }
}



public System.Boolean GetUserProperty(
	System.String Name,
	ref System.Double Value
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetUserProperty(Name, ref Value);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
    }
}



public System.Boolean SetUserProperty(
	System.String Name,
	System.String Value
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetUserProperty(Name, Value);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
    }
}



public System.Boolean SetUserProperty(
	System.String Name,
	System.Double Value
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetUserProperty(Name, Value);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
    }
}



public System.Boolean SetUserProperty(
	System.String Name,
	System.Int32 Value
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetUserProperty(Name, Value);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
    }
}



public System.Boolean GetIntegerUserProperties(
	ref System.Collections.Hashtable Values
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetIntegerUserProperties(ref Values);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetIntegerUserProperties), ex);
    }
}



public System.Boolean GetDoubleUserProperties(
	ref System.Collections.Hashtable Values
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetDoubleUserProperties(ref Values);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDoubleUserProperties), ex);
    }
}



public System.Boolean GetStringUserProperties(
	ref System.Collections.Hashtable Values
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetStringUserProperties(ref Values);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetStringUserProperties), ex);
    }
}



public System.Boolean GetDynamicStringProperty(
	System.String Name,
	ref System.String Value
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.GetDynamicStringProperty(Name, ref Value);
	
        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDynamicStringProperty), ex);
    }
}



public System.Boolean SetDynamicStringProperty(
	System.String Name,
	System.String Value
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetDynamicStringProperty(Name, Value);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetDynamicStringProperty), ex);
    }
}



public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.BasePoint> GetBasePoints()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetBasePoints");
	var _result = ListConverter.FromTSObjects(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BasePoint GetBasePointByName(
	System.String name
	)
{
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetBasePointByName", name);
	var _result = Dynamic.Tekla.Structures.Model.BasePoint_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BasePoint GetBasePointByGuid(
	System.Guid guid_
	)
{
	var guid = ObjectConverter.ToTSObject(guid_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetBasePointByGuid", guid);
	var _result = Dynamic.Tekla.Structures.Model.BasePoint_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BasePoint GetCurrentCoordsysBasePoint()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetCurrentCoordsysBasePoint");
	var _result = Dynamic.Tekla.Structures.Model.BasePoint_.FromTSObject(result);
	return _result;
}



public static System.Boolean SetCurrentCoordsysToBasePoint(
	Dynamic.Tekla.Structures.Model.BasePoint basePoint_
	)
{
	var basePoint = Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "SetCurrentCoordsysToBasePoint", basePoint);
	return result;
}



public static Dynamic.Tekla.Structures.Model.BasePoint GetProjectBasePoint()
{
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetProjectBasePoint");
	var _result = Dynamic.Tekla.Structures.Model.BasePoint_.FromTSObject(result);
	return _result;
}






    }

    internal static class ProjectInfo_
    {
        public static dynamic GetTSObject(ProjectInfo dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ProjectInfo FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ProjectInfo)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ProjectInfoArray_
    {
        public static dynamic GetTSObject(ProjectInfo[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ProjectInfo_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ProjectInfo[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ProjectInfo>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ProjectInfo_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
