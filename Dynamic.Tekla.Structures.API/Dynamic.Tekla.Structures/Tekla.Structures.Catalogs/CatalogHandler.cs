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
			return teklaObject.GetConnectionStatus();
		}

		public Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator GetProfileItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator_.FromTSObject(teklaObject.GetProfileItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator GetLibraryProfileItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator_.FromTSObject(teklaObject.GetLibraryProfileItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator GetParametricProfileItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.ProfileItemEnumerator_.FromTSObject(teklaObject.GetParametricProfileItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.RebarItemEnumerator GetRebarItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.RebarItemEnumerator_.FromTSObject(teklaObject.GetRebarItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.MeshItemEnumerator GetMeshItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.MeshItemEnumerator_.FromTSObject(teklaObject.GetMeshItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.BoltItemEnumerator GetBoltItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.BoltItemEnumerator_.FromTSObject(teklaObject.GetBoltItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.ShapeItemEnumerator GetShapeItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.ShapeItemEnumerator_.FromTSObject(teklaObject.GetShapeItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.MaterialItemEnumerator GetMaterialItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.MaterialItemEnumerator_.FromTSObject(teklaObject.GetMaterialItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.MaterialMarketSizesItemEnumerator GetMaterialMarketSizes()
		{
			return Dynamic.Tekla.Structures.Catalogs.MaterialMarketSizesItemEnumerator_.FromTSObject(teklaObject.GetMaterialMarketSizes());
		}

		public Dynamic.Tekla.Structures.Catalogs.PrinterItemEnumerator GetPrinterItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.PrinterItemEnumerator_.FromTSObject(teklaObject.GetPrinterItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.ComponentItemEnumerator GetComponentItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.ComponentItemEnumerator_.FromTSObject(teklaObject.GetComponentItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator GetUserPropertyItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator_.FromTSObject(teklaObject.GetUserPropertyItems());
		}

		public Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator GetUserPropertyItems(Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum objectType)
		{
			return Dynamic.Tekla.Structures.Catalogs.UserPropertyItemEnumerator_.FromTSObject(teklaObject.GetUserPropertyItems(Dynamic.Tekla.Structures.Catalogs.CatalogObjectTypeEnum_.GetTSObject(objectType)));
		}

		public Dynamic.Tekla.Structures.Catalogs.DrawingItemEnumerator GetDrawingItems()
		{
			return Dynamic.Tekla.Structures.Catalogs.DrawingItemEnumerator_.FromTSObject(teklaObject.GetDrawingItems());
		}

		public System.Boolean SaveProfileDatabase()
		{
			return teklaObject.SaveProfileDatabase();
		}

		public System.Boolean ImportLibraryProfileItems(System.String path)
		{
			return teklaObject.ImportLibraryProfileItems(path);
		}

		public System.Boolean ImportParametricProfileItems(System.String path)
		{
			return teklaObject.ImportParametricProfileItems(path);
		}

		public System.Boolean ImportMaterialItems(System.String path)
		{
			return teklaObject.ImportMaterialItems(path);
		}

		public System.Boolean ImportCustomComponentItems(System.String path)
		{
			return teklaObject.ImportCustomComponentItems(path);
		}

		public System.Boolean ImportRebarItems(System.String path)
		{
			return teklaObject.ImportRebarItems(path);
		}

		public System.Boolean ImportMeshItems(System.String path)
		{
			return teklaObject.ImportMeshItems(path);
		}

		public System.Boolean ImportBoltItems(System.String path)
		{
			return teklaObject.ImportBoltItems(path);
		}

		public System.Boolean ImportDrawingItems(System.String path)
		{
			return teklaObject.ImportDrawingItems(path);
		}

		public System.Boolean ImportShapeItems(System.String path)
		{
			return teklaObject.ImportShapeItems(path);
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
    
