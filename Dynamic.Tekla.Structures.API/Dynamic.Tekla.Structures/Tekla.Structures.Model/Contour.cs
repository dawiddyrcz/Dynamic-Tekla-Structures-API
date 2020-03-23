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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Contour(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Contour FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Contour)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ContourArray_
    {
        public static dynamic GetTSObject(Contour[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Contour_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Contour[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Contour>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Contour_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
