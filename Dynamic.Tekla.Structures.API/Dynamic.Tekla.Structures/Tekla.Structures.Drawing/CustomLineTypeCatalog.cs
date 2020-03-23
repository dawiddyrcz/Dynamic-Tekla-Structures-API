/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class CustomLineTypeCatalog 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.CustomLineType Get(System.Int32 CustomLineTypeId)
		{
			var parameters = new object[1];
			parameters[0] = CustomLineTypeId;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.CustomLineTypeCatalog", "Get", parameters);
			return Dynamic.Tekla.Structures.Drawing.CustomLineType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.CustomLineType Get(System.String Name)
		{
			var parameters = new object[1];
			parameters[0] = Name;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.CustomLineTypeCatalog", "Get", parameters);
			return Dynamic.Tekla.Structures.Drawing.CustomLineType_.FromTSObject(result);
		}

		public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Drawing.CustomLineType> Get()
		{
			var parameters = new object[0];
			var result = (System.Collections.Generic.List<Dynamic.Tekla.Structures.Drawing.CustomLineType>) TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.CustomLineTypeCatalog", "Get", parameters);
			return result;
		}





    }

    internal static class CustomLineTypeCatalog_
    {
        public static dynamic GetTSObject(CustomLineTypeCatalog dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static CustomLineTypeCatalog FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CustomLineTypeCatalog)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CustomLineTypeCatalogArray_
    {
        public static dynamic GetTSObject(CustomLineTypeCatalog[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CustomLineTypeCatalog_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CustomLineTypeCatalog[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<CustomLineTypeCatalog>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CustomLineTypeCatalog_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
