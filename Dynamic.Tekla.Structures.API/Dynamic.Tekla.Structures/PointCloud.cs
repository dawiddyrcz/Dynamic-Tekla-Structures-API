//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class PointCloud 
    {

		public System.Guid Guid
		{
			get => pointcloud.Guid;
			set { pointcloud.Guid = value; }
		}

		public System.String OriginalPath
		{
			get => pointcloud.OriginalPath;
			set { pointcloud.OriginalPath = value; }
		}

		public System.String Url
		{
			get => pointcloud.Url;
			set { pointcloud.Url = value; }
		}

		public System.String Name
		{
			get => pointcloud.Name;
			set { pointcloud.Name = value; }
		}

		public System.Guid LocationBy
		{
			get => pointcloud.LocationBy;
			set { pointcloud.LocationBy = value; }
		}

		public System.Boolean UseAutoCreatedBasePoint
		{
			get => pointcloud.UseAutoCreatedBasePoint;
			set { pointcloud.UseAutoCreatedBasePoint = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB BoundingBox
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.AABB(pointcloud.BoundingBox.GetTSObject());
			set { pointcloud.BoundingBox = value.GetTSObject(); }
		}

		public System.Double Scale
		{
			get => pointcloud.Scale;
			set { pointcloud.Scale = value; }
		}

        

        dynamic pointcloud;
        
        public PointCloud()
        {
            this.pointcloud =  new Tekla.Structures.Model.PointCloud();
        }

        public PointCloud(dynamic tsObject)
        {
            this.pointcloud = tsObject;
			this.Guid = pointcloud.Guid;
			this.OriginalPath = pointcloud.OriginalPath;
			this.Url = pointcloud.Url;
			this.Name = pointcloud.Name;
			this.LocationBy = pointcloud.LocationBy;
			this.UseAutoCreatedBasePoint = pointcloud.UseAutoCreatedBasePoint;
			this.BoundingBox = new Dynamic.Tekla.Structures.Geometry3d.AABB(pointcloud.BoundingBox);
			this.Scale = pointcloud.Scale;

        }


        public dynamic GetTSObject() => pointcloud;

		public System.Boolean Attach()
			 => pointcloud.Attach();

		public System.Boolean AttachComplete()
			 => pointcloud.AttachComplete();

		public System.Boolean Detach()
			 => pointcloud.Detach();

		public System.Boolean Select()
			 => pointcloud.Select();

		public System.Boolean SetVisibility(System.Collections.Generic.ListTekla.Structures.Model.UI.View, Tekla.Structures.Model, Version=2019.1.0.0, Culture=neutral, PublicKeyToken=2f04dbe497b71114<Dynamic.Tekla.Structures.Model.UI.View> views, System.Boolean visible)
			 => pointcloud.SetVisibility(views, visible);

		public System.Collections.Generic.ListTekla.Structures.Model.UI.View, Tekla.Structures.Model, Version=2019.1.0.0, Culture=neutral, PublicKeyToken=2f04dbe497b71114<Dynamic.Tekla.Structures.Model.UI.View> GetVisibleInViews()
			 => pointcloud.GetVisibleInViews();

		public System.Collections.Generic.ListTekla.Structures.Model.PointCloud, Tekla.Structures.Model, Version=2019.1.0.0, Culture=neutral, PublicKeyToken=2f04dbe497b71114<Dynamic.Tekla.Structures.Model.PointCloud> GetPointClouds()
			 => pointcloud.GetPointClouds();

		public System.Boolean Equals(System.Object obj)
			 => pointcloud.Equals(obj);

		public System.Int32 GetHashCode()
			 => pointcloud.GetHashCode();

		public System.Type GetType()
			 => pointcloud.GetType();

		public System.String ToString()
			 => pointcloud.ToString();





    }

}
    
