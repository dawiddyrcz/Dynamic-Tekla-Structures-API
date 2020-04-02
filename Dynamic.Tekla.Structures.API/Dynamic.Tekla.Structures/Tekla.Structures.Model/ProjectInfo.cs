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
			get => teklaObject.Description;
			set { teklaObject.Description = value; }
		}

		public System.String StartDate
		{
			get => teklaObject.StartDate;
			set { teklaObject.StartDate = value; }
		}

		public System.String EndDate
		{
			get => teklaObject.EndDate;
			set { teklaObject.EndDate = value; }
		}

		public System.String Object
		{
			get => teklaObject.Object;
			set { teklaObject.Object = value; }
		}

		public System.String Designer
		{
			get => teklaObject.Designer;
			set { teklaObject.Designer = value; }
		}

		public System.String Location
		{
			get => teklaObject.Location;
			set { teklaObject.Location = value; }
		}

		public System.String Address
		{
			get => teklaObject.Address;
			set { teklaObject.Address = value; }
		}

		public System.String PostalBox
		{
			get => teklaObject.PostalBox;
			set { teklaObject.PostalBox = value; }
		}

		public System.String Town
		{
			get => teklaObject.Town;
			set { teklaObject.Town = value; }
		}

		public System.String Region
		{
			get => teklaObject.Region;
			set { teklaObject.Region = value; }
		}

		public System.String PostalCode
		{
			get => teklaObject.PostalCode;
			set { teklaObject.PostalCode = value; }
		}

		public System.String Country
		{
			get => teklaObject.Country;
			set { teklaObject.Country = value; }
		}

		public System.String Builder
		{
			get => teklaObject.Builder;
			set { teklaObject.Builder = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String ProjectNumber
		{
			get => teklaObject.ProjectNumber;
			set { teklaObject.ProjectNumber = value; }
		}

		public System.IO.DirectoryInfo ModelSharingLocalPath
		{
			get => teklaObject.ModelSharingLocalPath;
			set { teklaObject.ModelSharingLocalPath = value; }
		}

		public System.Uri ModelSharingServerPath
		{
			get => teklaObject.ModelSharingServerPath;
			set { teklaObject.ModelSharingServerPath = value; }
		}

		public System.String Info1
		{
			get => teklaObject.Info1;
			set { teklaObject.Info1 = value; }
		}

		public System.String Info2
		{
			get => teklaObject.Info2;
			set { teklaObject.Info2 = value; }
		}

		public System.String GUID
		{
			get => teklaObject.GUID;
			set { teklaObject.GUID = value; }
		}

        

        internal dynamic teklaObject;

		public ProjectInfo()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ProjectInfo");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ProjectInfo(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
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

		public System.Boolean SetUserProperty(System.String Name, System.String Value)
		{
			return teklaObject.SetUserProperty(Name, Value);
		}

		public System.Boolean SetUserProperty(System.String Name, System.Double Value)
		{
			return teklaObject.SetUserProperty(Name, Value);
		}

		public System.Boolean SetUserProperty(System.String Name, System.Int32 Value)
		{
			return teklaObject.SetUserProperty(Name, Value);
		}

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable Values)
		{
			return teklaObject.GetIntegerUserProperties(ref Values);
		}

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable Values)
		{
			return teklaObject.GetDoubleUserProperties(ref Values);
		}

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable Values)
		{
			return teklaObject.GetStringUserProperties(ref Values);
		}

		public System.Boolean GetDynamicStringProperty(System.String Name, ref System.String Value)
		{
			return teklaObject.GetDynamicStringProperty(Name, ref Value);
		}

		public System.Boolean SetDynamicStringProperty(System.String Name, System.String Value)
		{
			return teklaObject.SetDynamicStringProperty(Name, Value);
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ProjectInfo FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
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
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ProjectInfo_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ProjectInfo[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ProjectInfo>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ProjectInfo_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
