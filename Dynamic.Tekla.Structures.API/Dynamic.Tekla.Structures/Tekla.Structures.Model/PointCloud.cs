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
			get => teklaObject.Guid;
			set { teklaObject.Guid = value; }
		}

		public System.String OriginalPath
		{
			get => teklaObject.OriginalPath;
			set { teklaObject.OriginalPath = value; }
		}

		public System.String Url
		{
			get => teklaObject.Url;
			set { teklaObject.Url = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.Guid LocationBy
		{
			get => teklaObject.LocationBy;
			set { teklaObject.LocationBy = value; }
		}

		public System.Boolean UseAutoCreatedBasePoint
		{
			get => teklaObject.UseAutoCreatedBasePoint;
			set { teklaObject.UseAutoCreatedBasePoint = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB BoundingBox
		{
			get => Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(teklaObject.BoundingBox);
			set { teklaObject.BoundingBox = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value); }
		}

		public System.Double Scale
		{
			get => teklaObject.Scale;
			set { teklaObject.Scale = value; }
		}

        

        internal dynamic teklaObject;

		public PointCloud()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PointCloud");
		}

		public System.Boolean Attach()
		{
			return teklaObject.Attach();
		}

		public System.Boolean AttachComplete()
		{
			return teklaObject.AttachComplete();
		}

		public System.Boolean Detach()
		{
			return teklaObject.Detach();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean SetVisibility(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.UI.View> views, System.Boolean visible)
		{
			return teklaObject.SetVisibility(views, visible);
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.UI.View> GetVisibleInViews()
		{
			return teklaObject.GetVisibleInViews();
		}

		public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.PointCloud> GetPointClouds()
		{
			var parameters = new object[0];
			var result = (System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.PointCloud>) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.PointCloud", "GetPointClouds", parameters);
			return result;		}





    }

    internal static class PointCloud_
    {
        public static dynamic GetTSObject(PointCloud dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PointCloud FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.PointCloud)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
