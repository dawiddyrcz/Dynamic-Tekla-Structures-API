/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Welding
{

    public  class WeldGeometry 
    {

		public Dynamic.Tekla.Structures.Model.Welding.WeldSeamPositionEnum Position
		{
			get => Dynamic.Tekla.Structures.Model.Welding.WeldSeamPositionEnum_.FromTSObject(teklaObject.Position);

		}

		public System.Collections.ArrayList Polygons
		{
			get => teklaObject.Polygons;

		}

        

        internal dynamic teklaObject;

		public WeldGeometry() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public WeldGeometry(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class WeldGeometry_
    {
        public static dynamic GetTSObject(WeldGeometry dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static WeldGeometry FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Welding.WeldGeometry)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class WeldGeometryArray_
    {
        public static dynamic GetTSObject(WeldGeometry[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(WeldGeometry_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static WeldGeometry[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<WeldGeometry>();
            foreach(var tsItem in tsArray)
            {
                list.Add(WeldGeometry_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
