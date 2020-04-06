/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PointCloud 
    {

		public System.Guid Guid
		{
			get
			{
				try {
					return teklaObject.Guid;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Guid", ex); }
			}
			set
			{
				try {
					teklaObject.Guid = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Guid", ex); }
			}
		}

		public System.String OriginalPath
		{
			get
			{
				try {
					return teklaObject.OriginalPath;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OriginalPath", ex); }
			}
			set
			{
				try {
					teklaObject.OriginalPath = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OriginalPath", ex); }
			}
		}

		public System.String Url
		{
			get
			{
				try {
					return teklaObject.Url;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Url", ex); }
			}
			set
			{
				try {
					teklaObject.Url = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Url", ex); }
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

		public System.Guid LocationBy
		{
			get
			{
				try {
					return teklaObject.LocationBy;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LocationBy", ex); }
			}
			set
			{
				try {
					teklaObject.LocationBy = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LocationBy", ex); }
			}
		}

		public System.Boolean UseAutoCreatedBasePoint
		{
			get
			{
				try {
					return teklaObject.UseAutoCreatedBasePoint;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UseAutoCreatedBasePoint", ex); }
			}
			set
			{
				try {
					teklaObject.UseAutoCreatedBasePoint = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UseAutoCreatedBasePoint", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB BoundingBox
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(teklaObject.BoundingBox);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingBox", ex); }
			}
			set
			{
				try {
				teklaObject.BoundingBox = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BoundingBox", ex); }
			}
		}

		public System.Double Scale
		{
			get
			{
				try {
					return teklaObject.Scale;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scale", ex); }
			}
			set
			{
				try {
					teklaObject.Scale = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scale", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public PointCloud()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PointCloud");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PointCloud(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean Attach()
		{
			try {
			var result = teklaObject.Attach();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Attach()", ex); }
		}

		public System.Boolean AttachComplete()
		{
			try {
			var result = teklaObject.AttachComplete();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("AttachComplete()", ex); }
		}

		public System.Boolean Detach()
		{
			try {
			var result = teklaObject.Detach();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Detach()", ex); }
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

		public System.Boolean SetVisibility(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.UI.View> views, System.Boolean visible)
		{
			try {
			var result = teklaObject.SetVisibility(views, visible);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetVisibility()", ex); }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.UI.View> GetVisibleInViews()
		{
			try {
			var result = teklaObject.GetVisibleInViews();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetVisibleInViews()", ex); }
		}

		public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.PointCloud> GetPointClouds()
		{
			var parameters = new object[0];
			var result = (System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.PointCloud>) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.PointCloud", "GetPointClouds", parameters);
			return result;
		}





    }

    internal static class PointCloud_
    {
        public static dynamic GetTSObject(PointCloud dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PointCloud FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.PointCloud)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PointCloudArray_
    {
        public static dynamic GetTSObject(PointCloud[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PointCloud_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PointCloud[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PointCloud>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PointCloud_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
