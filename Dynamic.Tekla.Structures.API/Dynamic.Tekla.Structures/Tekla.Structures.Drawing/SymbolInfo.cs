/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class SymbolInfo 
    {

		public System.Int32 SymbolIndex
		{
			get => teklaObject.SymbolIndex;
			set { teklaObject.SymbolIndex = value; }
		}

		public System.String SymbolFile
		{
			get => teklaObject.SymbolFile;
			set { teklaObject.SymbolFile = value; }
		}

        

        internal dynamic teklaObject;

		public SymbolInfo()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SymbolInfo");
		}
		public SymbolInfo(System.String SymbolFile, System.Int32 SymbolIndex)
		{
			var args = new object[2];
			args[0] = SymbolFile;
			args[1] = SymbolIndex;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SymbolInfo", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class SymbolInfo_
    {
        public static dynamic GetTSObject(SymbolInfo dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SymbolInfo FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.SymbolInfo)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SymbolInfoArray_
    {
        public static dynamic GetTSObject(SymbolInfo[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SymbolInfo_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SymbolInfo[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<SymbolInfo>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SymbolInfo_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
