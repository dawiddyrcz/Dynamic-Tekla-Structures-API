/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Polygon 
    {

		public System.Collections.ArrayList Points
		{
			get => teklaObject.Points;
			set { teklaObject.Points = value; }
		}

        

        internal dynamic teklaObject;

		public Polygon()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Polygon");
		}





    }

    internal static class Polygon_
    {
        public static dynamic GetTSObject(Polygon dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Polygon FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Polygon)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
