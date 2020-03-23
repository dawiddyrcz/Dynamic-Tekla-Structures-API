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
			return teklaObject.Resize(Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(size));
		}





    }

    internal static class IResizeable_
    {
        public static dynamic GetTSObject(IResizeable dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IResizeable FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.IResizeable)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IResizeableArray_
    {
        public static dynamic GetTSObject(IResizeable[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IResizeable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IResizeable[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IResizeable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IResizeable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
