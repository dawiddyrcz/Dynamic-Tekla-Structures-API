/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
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
			try {
			var result = teklaObject.GetConnectionStatus();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetConnectionStatus()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator GetProfileItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator_.FromTSObject(teklaObject.GetProfileItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetProfileItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator GetLibraryProfileItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator_.FromTSObject(teklaObject.GetLibraryProfileItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetLibraryProfileItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator GetParametricProfileItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator_.FromTSObject(teklaObject.GetParametricProfileItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetParametricProfileItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.RebarItemEnumerator GetRebarItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.RebarItemEnumerator_.FromTSObject(teklaObject.GetRebarItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetRebarItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.MeshItemEnumerator GetMeshItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.MeshItemEnumerator_.FromTSObject(teklaObject.GetMeshItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetMeshItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.BoltItemEnumerator GetBoltItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.BoltItemEnumerator_.FromTSObject(teklaObject.GetBoltItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetBoltItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.ShapeItemEnumerator GetShapeItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.ShapeItemEnumerator_.FromTSObject(teklaObject.GetShapeItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetShapeItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.MaterialItemEnumerator GetMaterialItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.MaterialItemEnumerator_.FromTSObject(teklaObject.GetMaterialItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetMaterialItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.MaterialMarketSizesItemEnumerator GetMaterialMarketSizes()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.MaterialMarketSizesItemEnumerator_.FromTSObject(teklaObject.GetMaterialMarketSizes());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetMaterialMarketSizes()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.PrinterItemEnumerator GetPrinterItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.PrinterItemEnumerator_.FromTSObject(teklaObject.GetPrinterItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPrinterItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.ComponentItemEnumerator GetComponentItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.ComponentItemEnumerator_.FromTSObject(teklaObject.GetComponentItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetComponentItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator GetUserPropertyItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator_.FromTSObject(teklaObject.GetUserPropertyItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserPropertyItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator GetUserPropertyItems(Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum objectType)
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator_.FromTSObject(teklaObject.GetUserPropertyItems(Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum_.GetTSObject(objectType)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserPropertyItems()"); }
		}

		public Dynamic.Tekla.Structures.Catalogs.DrawingItemEnumerator GetDrawingItems()
		{
			try {
			return Dynamic.Tekla.Structures.Catalogs.DrawingItemEnumerator_.FromTSObject(teklaObject.GetDrawingItems());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetDrawingItems()"); }
		}

		public System.Boolean SaveProfileDatabase()
		{
			try {
			var result = teklaObject.SaveProfileDatabase();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SaveProfileDatabase()"); }
		}

		public System.Boolean ImportLibraryProfileItems(System.String path)
		{
			try {
			var result = teklaObject.ImportLibraryProfileItems(path);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ImportLibraryProfileItems()"); }
		}

		public System.Boolean ImportParametricProfileItems(System.String path)
		{
			try {
			var result = teklaObject.ImportParametricProfileItems(path);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ImportParametricProfileItems()"); }
		}

		public System.Boolean ImportMaterialItems(System.String path)
		{
			try {
			var result = teklaObject.ImportMaterialItems(path);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ImportMaterialItems()"); }
		}

		public System.Boolean ImportCustomComponentItems(System.String path)
		{
			try {
			var result = teklaObject.ImportCustomComponentItems(path);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ImportCustomComponentItems()"); }
		}

		public System.Boolean ImportRebarItems(System.String path)
		{
			try {
			var result = teklaObject.ImportRebarItems(path);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ImportRebarItems()"); }
		}

		public System.Boolean ImportMeshItems(System.String path)
		{
			try {
			var result = teklaObject.ImportMeshItems(path);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ImportMeshItems()"); }
		}

		public System.Boolean ImportBoltItems(System.String path)
		{
			try {
			var result = teklaObject.ImportBoltItems(path);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ImportBoltItems()"); }
		}

		public System.Boolean ImportDrawingItems(System.String path)
		{
			try {
			var result = teklaObject.ImportDrawingItems(path);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ImportDrawingItems()"); }
		}

		public System.Boolean ImportShapeItems(System.String path)
		{
			try {
			var result = teklaObject.ImportShapeItems(path);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("ImportShapeItems()"); }
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
    
