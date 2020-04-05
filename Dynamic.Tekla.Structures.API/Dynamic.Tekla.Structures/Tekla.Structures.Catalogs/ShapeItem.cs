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
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String Guid
		{
			get => teklaObject.Guid;
			set { teklaObject.Guid = value; }
		}

		public System.String GeometryGuid
		{
			get => teklaObject.GeometryGuid;
			set { teklaObject.GeometryGuid = value; }
		}

		public System.String GeometryHash
		{
			get => teklaObject.GeometryHash;
			set { teklaObject.GeometryHash = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.AABB Extrema
		{
			get => Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(teklaObject.Extrema);
			set { teklaObject.Extrema = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value); }
		}

		public System.Boolean IsSolid
		{
			get => teklaObject.IsSolid;
			set { teklaObject.IsSolid = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep ShapeFacetedBrep
		{
			get => Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(teklaObject.ShapeFacetedBrep);
			set { teklaObject.ShapeFacetedBrep = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis UpAxis
		{
			get => Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis_.FromTSObject(teklaObject.UpAxis);
			set { teklaObject.UpAxis = Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis_.GetTSObject(value); }
		}

		public System.String Fingerprint
		{
			get => teklaObject.Fingerprint;
			set { teklaObject.Fingerprint = value; }
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
			return teklaObject.Select(name);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Select()
		{
			try {
			return teklaObject.Select();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Delete()
		{
			try {
			return teklaObject.Delete();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Delete()"); }
		}

		public System.Boolean Insert()
		{
			try {
			return teklaObject.Insert();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()"); }
		}

		public System.Boolean InsertUsingNormals()
		{
			try {
			return teklaObject.InsertUsingNormals();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("InsertUsingNormals()"); }
		}

		public System.Boolean Export(ref System.String filename)
		{
			try {
			return teklaObject.Export(ref filename);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Export()"); }
		}

		public System.Boolean Modify()
		{
			try {
			return teklaObject.Modify();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()"); }
		}

		public System.Boolean CleanAndModify(ref System.Boolean isSolid)
		{
			try {
			return teklaObject.CleanAndModify(ref isSolid);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CleanAndModify()"); }
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
    
