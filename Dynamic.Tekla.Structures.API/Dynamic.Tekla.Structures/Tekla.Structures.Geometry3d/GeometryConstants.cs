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

		public static System.Double DISTANCE_EPSILON
		{
			get => (System.Double) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Geometry3d.GeometryConstants","DISTANCE_EPSILON");

		}

		public static System.Double ANGULAR_EPSILON
		{
			get => (System.Double) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Geometry3d.GeometryConstants","ANGULAR_EPSILON");

		}

		public static System.Double SCALAR_EPSILON
		{
			get => (System.Double) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Geometry3d.GeometryConstants","SCALAR_EPSILON");

		}

        

        internal dynamic teklaObject;

		public GeometryConstants()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometryConstants");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GeometryConstants(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class GeometryConstants_
    {
        public static dynamic GetTSObject(GeometryConstants dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static GeometryConstants FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.GeometryConstants)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GeometryConstantsArray_
    {
        public static dynamic GetTSObject(GeometryConstants[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GeometryConstants_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GeometryConstants[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<GeometryConstants>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GeometryConstants_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
