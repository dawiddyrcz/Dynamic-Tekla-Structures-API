/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class ShapeItem 
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

		public System.String Guid
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

		public System.String GeometryGuid
		{
			get
			{
				try {
					return teklaObject.GeometryGuid;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GeometryGuid", ex); }
			}
			set
			{
				try {
					teklaObject.GeometryGuid = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GeometryGuid", ex); }
			}
		}

		public System.String GeometryHash
		{
			get
			{
				try {
					return teklaObject.GeometryHash;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GeometryHash", ex); }
			}
			set
			{
				try {
					teklaObject.GeometryHash = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("GeometryHash", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB Extrema
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(teklaObject.Extrema);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extrema", ex); }
			}
			set
			{
				try {
				teklaObject.Extrema = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Extrema", ex); }
			}
		}

		public System.Boolean IsSolid
		{
			get
			{
				try {
					return teklaObject.IsSolid;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsSolid", ex); }
			}
			set
			{
				try {
					teklaObject.IsSolid = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsSolid", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep ShapeFacetedBrep
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(teklaObject.ShapeFacetedBrep);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShapeFacetedBrep", ex); }
			}
			set
			{
				try {
				teklaObject.ShapeFacetedBrep = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ShapeFacetedBrep", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis UpAxis
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis_.FromTSObject(teklaObject.UpAxis);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpAxis", ex); }
			}
			set
			{
				try {
				teklaObject.UpAxis = Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpAxis", ex); }
			}
		}

		public System.String Fingerprint
		{
			get
			{
				try {
					return teklaObject.Fingerprint;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Fingerprint", ex); }
			}
			set
			{
				try {
					teklaObject.Fingerprint = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Fingerprint", ex); }
			}
		}

        

        internal dynamic teklaObject;

		public ShapeItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.ShapeItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ShapeItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean Select(System.String name)
		{
			try {
			var result = teklaObject.Select(name);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()", ex); }
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

		public System.Boolean Delete()
		{
			try {
			var result = teklaObject.Delete();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Delete()", ex); }
		}

		public System.Boolean Insert()
		{
			try {
			var result = teklaObject.Insert();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()", ex); }
		}

		public System.Boolean InsertUsingNormals()
		{
			try {
			var result = teklaObject.InsertUsingNormals();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("InsertUsingNormals()", ex); }
		}

		public System.Boolean Export(ref System.String filename)
		{
			try {
			var result = teklaObject.Export(ref filename);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Export()", ex); }
		}

		public System.Boolean Modify()
		{
			try {
			var result = teklaObject.Modify();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()", ex); }
		}

		public System.Boolean CleanAndModify(ref System.Boolean isSolid)
		{
			try {
			var result = teklaObject.CleanAndModify(ref isSolid);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CleanAndModify()", ex); }
		}





    }

    internal static class ShapeItem_
    {
        public static dynamic GetTSObject(ShapeItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ShapeItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.ShapeItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ShapeItemArray_
    {
        public static dynamic GetTSObject(ShapeItem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ShapeItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ShapeItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ShapeItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ShapeItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
