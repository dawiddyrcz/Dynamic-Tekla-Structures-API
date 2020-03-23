/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class IAxisAlignedBoundingBox 
    {

        

        internal dynamic teklaObject;


		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
		}





    }

    internal static class IAxisAlignedBoundingBox_
    {
        public static dynamic GetTSObject(IAxisAlignedBoundingBox dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IAxisAlignedBoundingBox FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.IAxisAlignedBoundingBox)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IAxisAlignedBoundingBoxArray_
    {
        public static dynamic GetTSObject(IAxisAlignedBoundingBox[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IAxisAlignedBoundingBox_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IAxisAlignedBoundingBox[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IAxisAlignedBoundingBox>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IAxisAlignedBoundingBox_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
