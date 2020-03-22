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
			set { teklaObject.Position = Dynamic.Tekla.Structures.Model.Welding.WeldSeamPositionEnum_.GetTSObject(value); }
		}

		public System.Collections.ArrayList Polygons
		{
			get => teklaObject.Polygons;
			set { teklaObject.Polygons = value; }
		}

        

        internal dynamic teklaObject;

		public WeldGeometry() {}





    }

    internal static class WeldGeometry_
    {
        public static dynamic GetTSObject(WeldGeometry dynObject)
        {
            return dynObject.teklaObject;
        }

        public static WeldGeometry FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Welding.WeldGeometry)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
