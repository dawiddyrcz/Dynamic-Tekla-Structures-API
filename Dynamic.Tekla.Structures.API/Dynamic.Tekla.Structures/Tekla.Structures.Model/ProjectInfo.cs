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
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Description"); }
			}
			set
			{
				try {
					teklaObject.Description = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Description"); }
			}
		}

		public System.String StartDate
		{
			get
			{
				try {
					return teklaObject.StartDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartDate"); }
			}
			set
			{
				try {
					teklaObject.StartDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartDate"); }
			}
		}

		public System.String EndDate
		{
			get
			{
				try {
					return teklaObject.EndDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndDate"); }
			}
			set
			{
				try {
					teklaObject.EndDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndDate"); }
			}
		}

		public System.String Object
		{
			get
			{
				try {
					return teklaObject.Object;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Object"); }
			}
			set
			{
				try {
					teklaObject.Object = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Object"); }
			}
		}

		public System.String Designer
		{
			get
			{
				try {
					return teklaObject.Designer;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Designer"); }
			}
			set
			{
				try {
					teklaObject.Designer = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Designer"); }
			}
		}

		public System.String Location
		{
			get
			{
				try {
					return teklaObject.Location;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Location"); }
			}
			set
			{
				try {
					teklaObject.Location = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Location"); }
			}
		}

		public System.String Address
		{
			get
			{
				try {
					return teklaObject.Address;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Address"); }
			}
			set
			{
				try {
					teklaObject.Address = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Address"); }
			}
		}

		public System.String PostalBox
		{
			get
			{
				try {
					return teklaObject.PostalBox;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PostalBox"); }
			}
			set
			{
				try {
					teklaObject.PostalBox = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PostalBox"); }
			}
		}

		public System.String Town
		{
			get
			{
				try {
					return teklaObject.Town;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Town"); }
			}
			set
			{
				try {
					teklaObject.Town = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Town"); }
			}
		}

		public System.String Region
		{
			get
			{
				try {
					return teklaObject.Region;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Region"); }
			}
			set
			{
				try {
					teklaObject.Region = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Region"); }
			}
		}

		public System.String PostalCode
		{
			get
			{
				try {
					return teklaObject.PostalCode;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PostalCode"); }
			}
			set
			{
				try {
					teklaObject.PostalCode = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PostalCode"); }
			}
		}

		public System.String Country
		{
			get
			{
				try {
					return teklaObject.Country;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Country"); }
			}
			set
			{
				try {
					teklaObject.Country = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Country"); }
			}
		}

		public System.String Builder
		{
			get
			{
				try {
					return teklaObject.Builder;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Builder"); }
			}
			set
			{
				try {
					teklaObject.Builder = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Builder"); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
		}

		public System.String ProjectNumber
		{
			get
			{
				try {
					return teklaObject.ProjectNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProjectNumber"); }
			}
			set
			{
				try {
					teklaObject.ProjectNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProjectNumber"); }
			}
		}

		public System.IO.DirectoryInfo ModelSharingLocalPath
		{
			get
			{
				try {
					return teklaObject.ModelSharingLocalPath;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelSharingLocalPath"); }
			}
			set
			{
				try {
					teklaObject.ModelSharingLocalPath = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelSharingLocalPath"); }
			}
		}

		public System.Uri ModelSharingServerPath
		{
			get
			{
				try {
					return teklaObject.ModelSharingServerPath;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelSharingServerPath"); }
			}
			set
			{
				try {
					teklaObject.ModelSharingServerPath = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelSharingServerPath"); }
			}
		}

		public System.String Info1
		{
			get
			{
				try {
					return teklaObject.Info1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Info1"); }
			}
			set
			{
				try {
					teklaObject.Info1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Info1"); }
			}
		}

		public System.String Info2
		{
			get
			{
				try {
					return teklaObject.Info2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Info2"); }
			}
			set
			{
				try {
					teklaObject.Info2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Info2"); }
			}
		}

		public System.String GUID
		{
			get
			{
				try {
					return teklaObject.GUID;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GUID"); }
			}
			set
			{
				try {
					teklaObject.GUID = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GUID"); }
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
			try {
			return teklaObject.Modify();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()"); }
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

		public System.Boolean SetUserProperty(System.String Name, System.String Value)
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

		public System.Boolean SetUserProperty(System.String Name, System.Int32 Value)
		{
			try {
			return teklaObject.SetUserProperty(Name, Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()"); }
		}

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable Values)
		{
			try {
			return teklaObject.GetIntegerUserProperties(ref Values);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetIntegerUserProperties()"); }
		}

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable Values)
		{
			try {
			return teklaObject.GetDoubleUserProperties(ref Values);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDoubleUserProperties()"); }
		}

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable Values)
		{
			try {
			return teklaObject.GetStringUserProperties(ref Values);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetStringUserProperties()"); }
		}

		public System.Boolean GetDynamicStringProperty(System.String Name, ref System.String Value)
		{
			try {
			return teklaObject.GetDynamicStringProperty(Name, ref Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDynamicStringProperty()"); }
		}

		public System.Boolean SetDynamicStringProperty(System.String Name, System.String Value)
		{
			try {
			return teklaObject.SetDynamicStringProperty(Name, Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetDynamicStringProperty()"); }
		}

		public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.BasePoint> GetBasePoints()
		{
			var parameters = new object[0];
			var result = (System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.BasePoint>) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetBasePoints", parameters);
			return result;
		}

		public static Dynamic.Tekla.Structures.Model.BasePoint GetBasePointByName(System.String name)
		{
			var parameters = new object[1];
			parameters[0] = name;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetBasePointByName", parameters);
			return Dynamic.Tekla.Structures.Model.BasePoint_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BasePoint GetBasePointByGuid(System.Guid guid)
		{
			var parameters = new object[1];
			parameters[0] = guid;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetBasePointByGuid", parameters);
			return Dynamic.Tekla.Structures.Model.BasePoint_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BasePoint GetCurrentCoordsysBasePoint()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetCurrentCoordsysBasePoint", parameters);
			return Dynamic.Tekla.Structures.Model.BasePoint_.FromTSObject(result);
		}

		public static System.Boolean SetCurrentCoordsysToBasePoint(Dynamic.Tekla.Structures.Model.BasePoint basePoint)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.BasePoint_.GetTSObject(basePoint);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "SetCurrentCoordsysToBasePoint", parameters);
			return result;
		}

		public static Dynamic.Tekla.Structures.Model.BasePoint GetProjectBasePoint()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetProjectBasePoint", parameters);
			return Dynamic.Tekla.Structures.Model.BasePoint_.FromTSObject(result);
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
    
