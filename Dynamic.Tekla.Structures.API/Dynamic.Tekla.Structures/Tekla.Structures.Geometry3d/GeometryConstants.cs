/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class GeometryConstants 
    {

        

        internal dynamic teklaObject;

		public GeometryConstants()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometryConstants");
		}





    }

    internal static class GeometryConstants_
    {
        public static dynamic GetTSObject(GeometryConstants dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GeometryConstants FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.GeometryConstants)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GeometryConstantsArray_
    {
        public static dynamic GetTSObject(GeometryConstants[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GeometryConstants_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GeometryConstants[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<GeometryConstants>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GeometryConstants_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
