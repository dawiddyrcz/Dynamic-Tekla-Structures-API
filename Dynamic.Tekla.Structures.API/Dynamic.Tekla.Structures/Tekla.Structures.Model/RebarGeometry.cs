/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarGeometry 
    {

		public Dynamic.Tekla.Structures.Geometry3d.PolyLine Shape
		{
			get => Dynamic.Tekla.Structures.Geometry3d.PolyLine_.FromTSObject(teklaObject.Shape);
			set { teklaObject.Shape = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(value); }
		}

		public System.Double Diameter
		{
			get => teklaObject.Diameter;
			set { teklaObject.Diameter = value; }
		}

		public System.Collections.ArrayList BendingRadiuses
		{
			get => teklaObject.BendingRadiuses;
			set { teklaObject.BendingRadiuses = value; }
		}

        

        internal dynamic teklaObject;

		public RebarGeometry() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarGeometry(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class RebarGeometry_
    {
        public static dynamic GetTSObject(RebarGeometry dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarGeometry FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarGeometry)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarGeometryArray_
    {
        public static dynamic GetTSObject(RebarGeometry[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarGeometry_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarGeometry[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<RebarGeometry>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarGeometry_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
