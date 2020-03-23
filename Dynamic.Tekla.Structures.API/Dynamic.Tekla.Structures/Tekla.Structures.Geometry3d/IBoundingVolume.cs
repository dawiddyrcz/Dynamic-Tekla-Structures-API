/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public abstract class IBoundingVolume 
    {

        

        internal dynamic teklaObject;






    }

    internal static class IBoundingVolume_
    {
        public static dynamic GetTSObject(IBoundingVolume dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static IBoundingVolume FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.IBoundingVolume)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IBoundingVolumeArray_
    {
        public static dynamic GetTSObject(IBoundingVolume[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IBoundingVolume_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IBoundingVolume[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<IBoundingVolume>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IBoundingVolume_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
