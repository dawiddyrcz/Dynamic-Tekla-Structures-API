/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Contour 
    {

		public System.Collections.ArrayList ContourPoints
		{
			get => teklaObject.ContourPoints;
			set { teklaObject.ContourPoints = value; }
		}

        

        internal dynamic teklaObject;

		public Contour()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Contour");
		}

		public void AddContourPoint(Dynamic.Tekla.Structures.Model.ContourPoint Point)
		{
			teklaObject.AddContourPoint(Dynamic.Tekla.Structures.Model.ContourPoint_.GetTSObject(Point));
		}





    }

    internal static class Contour_
    {
        public static dynamic GetTSObject(Contour dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Contour FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Contour)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
