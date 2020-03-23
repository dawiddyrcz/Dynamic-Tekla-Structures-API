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
            var dynObject = (Dynamic.Tekla.Structures.Model.RebarGeometry)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
