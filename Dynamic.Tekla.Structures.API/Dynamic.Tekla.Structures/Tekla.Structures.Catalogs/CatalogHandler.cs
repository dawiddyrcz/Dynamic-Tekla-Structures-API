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

    public  class CatalogHandler 
    {

        

        internal dynamic teklaObject;

		public CatalogHandler()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.CatalogHandler");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CatalogHandler(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


        public System.Boolean GetConnectionStatus()
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.GetConnectionStatus();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetConnectionStatus), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator GetProfileItems()
        {
            
            try
            {
                var result = teklaObject.GetProfileItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetProfileItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator GetLibraryProfileItems()
        {
            
            try
            {
                var result = teklaObject.GetLibraryProfileItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetLibraryProfileItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator GetParametricProfileItems()
        {
            
            try
            {
                var result = teklaObject.GetParametricProfileItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetParametricProfileItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.RebarItemEnumerator GetRebarItems()
        {
            
            try
            {
                var result = teklaObject.GetRebarItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.RebarItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRebarItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.MeshItemEnumerator GetMeshItems()
        {
            
            try
            {
                var result = teklaObject.GetMeshItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.MeshItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetMeshItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.BoltItemEnumerator GetBoltItems()
        {
            
            try
            {
                var result = teklaObject.GetBoltItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.BoltItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBoltItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.ShapeItemEnumerator GetShapeItems()
        {
            
            try
            {
                var result = teklaObject.GetShapeItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.ShapeItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetShapeItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.MaterialItemEnumerator GetMaterialItems()
        {
            
            try
            {
                var result = teklaObject.GetMaterialItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.MaterialItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetMaterialItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.MaterialMarketSizesItemEnumerator GetMaterialMarketSizes()
        {
            
            try
            {
                var result = teklaObject.GetMaterialMarketSizes();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.MaterialMarketSizesItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetMaterialMarketSizes), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.PrinterItemEnumerator GetPrinterItems()
        {
            
            try
            {
                var result = teklaObject.GetPrinterItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.PrinterItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPrinterItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.ComponentItemEnumerator GetComponentItems()
        {
            
            try
            {
                var result = teklaObject.GetComponentItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.ComponentItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetComponentItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator GetUserPropertyItems()
        {
            
            try
            {
                var result = teklaObject.GetUserPropertyItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserPropertyItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator GetUserPropertyItems(
			Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum objectType_)
        {
            var objectType = Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum_.GetTSObject(objectType_);
            try
            {
                var result = teklaObject.GetUserPropertyItems(objectType);
            
                var _result = Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserPropertyItems), ex);
            }
        }



        public Dynamic.Tekla.Structures.Catalogs.DrawingItemEnumerator GetDrawingItems()
        {
            
            try
            {
                var result = teklaObject.GetDrawingItems();
            
                var _result = Dynamic.Tekla.Structures.Catalogs.DrawingItemEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDrawingItems), ex);
            }
        }



        public System.Boolean SaveProfileDatabase()
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.SaveProfileDatabase();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SaveProfileDatabase), ex);
            }
        }



        public System.Boolean ImportLibraryProfileItems(
			System.String path)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.ImportLibraryProfileItems(path);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ImportLibraryProfileItems), ex);
            }
        }



        public System.Boolean ImportParametricProfileItems(
			System.String path)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.ImportParametricProfileItems(path);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ImportParametricProfileItems), ex);
            }
        }



        public System.Boolean ImportMaterialItems(
			System.String path)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.ImportMaterialItems(path);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ImportMaterialItems), ex);
            }
        }



        public System.Boolean ImportCustomComponentItems(
			System.String path)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.ImportCustomComponentItems(path);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ImportCustomComponentItems), ex);
            }
        }



        public System.Boolean ImportRebarItems(
			System.String path)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.ImportRebarItems(path);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ImportRebarItems), ex);
            }
        }



        public System.Boolean ImportMeshItems(
			System.String path)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.ImportMeshItems(path);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ImportMeshItems), ex);
            }
        }



        public System.Boolean ImportBoltItems(
			System.String path)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.ImportBoltItems(path);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ImportBoltItems), ex);
            }
        }



        public System.Boolean ImportDrawingItems(
			System.String path)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.ImportDrawingItems(path);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ImportDrawingItems), ex);
            }
        }



        public System.Boolean ImportShapeItems(
			System.String path)
        {
            
            try
            {
                var result = (System.Boolean) teklaObject.ImportShapeItems(path);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ImportShapeItems), ex);
            }
        }






    }

    internal static class CatalogHandler_
    {
        public static dynamic GetTSObject(CatalogHandler dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CatalogHandler FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.CatalogHandler)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CatalogHandlerArray_
    {
        public static dynamic GetTSObject(CatalogHandler[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CatalogHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CatalogHandler[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CatalogHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CatalogHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
