/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class IResizeable 
    {

        

        internal dynamic teklaObject;


		public System.Boolean Resize(Dynamic.Tekla.Structures.Drawing.Size size)
		{
			try {
			var result = teklaObject.Resize(Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(size));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Resize()"); }
		}





    }

    internal static class IResizeable_
    {
        public static dynamic GetTSObject(IResizeable dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IResizeable FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.IResizeable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IResizeableArray_
    {
        public static dynamic GetTSObject(IResizeable[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IResizeable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IResizeable[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IResizeable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IResizeable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
