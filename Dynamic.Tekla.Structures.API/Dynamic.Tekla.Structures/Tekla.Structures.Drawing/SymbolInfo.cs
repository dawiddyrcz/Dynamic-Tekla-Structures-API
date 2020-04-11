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
			get
			{
				try {
					return teklaObject.SymbolIndex;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SymbolIndex", ex); }
			}
			set
			{
				try {
					teklaObject.SymbolIndex = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SymbolIndex", ex); }
			}
		}

		public System.String SymbolFile
		{
			get
			{
				try {
					return teklaObject.SymbolFile;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SymbolFile", ex); }
			}
			set
			{
				try {
					teklaObject.SymbolFile = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SymbolFile", ex); }
			}
		}

		public static Dynamic.Tekla.Structures.Drawing.SymbolInfo Default
		{
			get => Dynamic.Tekla.Structures.Drawing.SymbolInfo_.FromTSObject(TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.SymbolInfo","Default"));
			set {  TSActivator.Set_StaticPropertyOrFieldValue("Tekla.Structures.Drawing.SymbolInfo","Default",Dynamic.Tekla.Structures.Drawing.SymbolInfo_.GetTSObject(value)); }
		}

        

        internal dynamic teklaObject;

		public SymbolInfo()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SymbolInfo");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SymbolInfo(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public SymbolInfo(System.String SymbolFile, System.Int32 SymbolIndex)
		{
			var args = new object[2];
			args[0] = SymbolFile;
			args[1] = SymbolIndex;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.SymbolInfo", args);
		}


public System.Boolean IsEqual(
	System.Object ObjectToCompare
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.IsEqual(ObjectToCompare);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsEqual), ex);
    }
}






    }

    internal static class SymbolInfo_
    {
        public static dynamic GetTSObject(SymbolInfo dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SymbolInfo FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.SymbolInfo)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SymbolInfoArray_
    {
        public static dynamic GetTSObject(SymbolInfo[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SymbolInfo_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SymbolInfo[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SymbolInfo>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SymbolInfo_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
