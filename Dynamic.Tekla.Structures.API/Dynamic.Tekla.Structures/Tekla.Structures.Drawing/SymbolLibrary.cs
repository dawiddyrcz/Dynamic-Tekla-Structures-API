/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class SymbolLibrary 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.StringList GetSymbolLibraries()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.SymbolLibrary", "GetSymbolLibraries", parameters);
			return Dynamic.Tekla.Structures.Drawing.StringList_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.StringList GetSymbolLibraries(System.Boolean forceRefresh)
		{
			var parameters = new object[1];
			parameters[0] = forceRefresh;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.SymbolLibrary", "GetSymbolLibraries", parameters);
			return Dynamic.Tekla.Structures.Drawing.StringList_.FromTSObject(result);
		}





    }

    internal static class SymbolLibrary_
    {
        public static dynamic GetTSObject(SymbolLibrary dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SymbolLibrary FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.SymbolLibrary)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SymbolLibraryArray_
    {
        public static dynamic GetTSObject(SymbolLibrary[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SymbolLibrary_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SymbolLibrary[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<SymbolLibrary>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SymbolLibrary_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
