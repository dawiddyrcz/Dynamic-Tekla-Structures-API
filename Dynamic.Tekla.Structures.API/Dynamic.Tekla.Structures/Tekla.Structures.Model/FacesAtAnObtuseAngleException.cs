/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class FacesAtAnObtuseAngleException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public FacesAtAnObtuseAngleException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.FacesAtAnObtuseAngleException");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public FacesAtAnObtuseAngleException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class FacesAtAnObtuseAngleException_
    {
        public static dynamic GetTSObject(FacesAtAnObtuseAngleException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FacesAtAnObtuseAngleException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.FacesAtAnObtuseAngleException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FacesAtAnObtuseAngleExceptionArray_
    {
        public static dynamic GetTSObject(FacesAtAnObtuseAngleException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FacesAtAnObtuseAngleException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FacesAtAnObtuseAngleException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<FacesAtAnObtuseAngleException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FacesAtAnObtuseAngleException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
