/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class ShapeItem 
    {


        public System.String Name
        {
            get
            {
                try
                {
                return teklaObject.Name;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Name = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
                }
            }
        }

        public System.String Guid
        {
            get
            {
                try
                {
                return teklaObject.Guid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Guid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guid), ex); 
                }
            }
        }

        public System.String GeometryGuid
        {
            get
            {
                try
                {
                return teklaObject.GeometryGuid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GeometryGuid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.GeometryGuid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GeometryGuid), ex); 
                }
            }
        }

        public System.String GeometryHash
        {
            get
            {
                try
                {
                return teklaObject.GeometryHash;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GeometryHash), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.GeometryHash = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GeometryHash), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.AABB Extrema
        {
            get
            {
                try
                {
                var value = teklaObject.Extrema;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.AABB) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extrema), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value);
                teklaObject.Extrema = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extrema), ex); 
                }
            }
        }

        public System.Boolean IsSolid
        {
            get
            {
                try
                {
                return teklaObject.IsSolid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsSolid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IsSolid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsSolid), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep ShapeFacetedBrep
        {
            get
            {
                try
                {
                var value = teklaObject.ShapeFacetedBrep;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.FacetedBrep) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ShapeFacetedBrep), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value);
                teklaObject.ShapeFacetedBrep = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ShapeFacetedBrep), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis UpAxis
        {
            get
            {
                try
                {
                var value = teklaObject.UpAxis;
                var value_ = Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpAxis), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Catalogs.ShapeUpAxis_.GetTSObject(value);
                teklaObject.UpAxis = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpAxis), ex); 
                }
            }
        }

        public System.String Fingerprint
        {
            get
            {
                try
                {
                return teklaObject.Fingerprint;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Fingerprint), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Fingerprint = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Fingerprint), ex); 
                }
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


        public System.Boolean Select(
			System.String name)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.Select(name);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
            }
        }



        public System.Boolean Select()
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.Select();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
            }
        }



        public System.Boolean Delete()
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.Delete();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Delete), ex);
            }
        }



        public System.Boolean Insert()
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.Insert();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
            }
        }



        public System.Boolean InsertUsingNormals()
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.InsertUsingNormals();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(InsertUsingNormals), ex);
            }
        }



        public System.Boolean Export(
			ref System.String filename)
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



        public System.Boolean CleanAndModify(
			ref System.Boolean isSolid)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.CleanAndModify(ref isSolid);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CleanAndModify), ex);
            }
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
    
