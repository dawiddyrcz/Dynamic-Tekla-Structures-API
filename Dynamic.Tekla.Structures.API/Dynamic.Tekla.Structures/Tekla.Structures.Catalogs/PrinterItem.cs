/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Catalogs
{

    public  class PrinterItem 
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String Device
		{
			get => teklaObject.Device;
			set { teklaObject.Device = value; }
		}

		public System.String Extension
		{
			get => teklaObject.Extension;
			set { teklaObject.Extension = value; }
		}

		public System.Double PrintAreaWidth
		{
			get => teklaObject.PrintAreaWidth;
			set { teklaObject.PrintAreaWidth = value; }
		}

		public System.Double PrintAreaHeigth
		{
			get => teklaObject.PrintAreaHeigth;
			set { teklaObject.PrintAreaHeigth = value; }
		}

        

        internal dynamic teklaObject;

		public PrinterItem()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Catalogs.PrinterItem");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public PrinterItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class PrinterItem_
    {
        public static dynamic GetTSObject(PrinterItem dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static PrinterItem FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Catalogs.PrinterItem)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PrinterItemArray_
    {
        public static dynamic GetTSObject(PrinterItem[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PrinterItem_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PrinterItem[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<PrinterItem>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PrinterItem_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
