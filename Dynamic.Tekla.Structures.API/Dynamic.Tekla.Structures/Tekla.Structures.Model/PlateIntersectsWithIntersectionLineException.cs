/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class PlateIntersectsWithIntersectionLineException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public PlateIntersectsWithIntersectionLineException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PlateIntersectsWithIntersectionLineException");
		}





    }

    internal static class PlateIntersectsWithIntersectionLineException_
    {
        public static dynamic GetTSObject(PlateIntersectsWithIntersectionLineException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PlateIntersectsWithIntersectionLineException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.PlateIntersectsWithIntersectionLineException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PlateIntersectsWithIntersectionLineExceptionArray_
    {
        public static dynamic GetTSObject(PlateIntersectsWithIntersectionLineException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(PlateIntersectsWithIntersectionLineException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static PlateIntersectsWithIntersectionLineException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<PlateIntersectsWithIntersectionLineException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(PlateIntersectsWithIntersectionLineException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
