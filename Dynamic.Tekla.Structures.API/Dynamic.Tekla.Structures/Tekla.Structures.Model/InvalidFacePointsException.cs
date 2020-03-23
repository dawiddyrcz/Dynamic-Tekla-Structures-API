/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class InvalidFacePointsException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public InvalidFacePointsException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.InvalidFacePointsException");
		}





    }

    internal static class InvalidFacePointsException_
    {
        public static dynamic GetTSObject(InvalidFacePointsException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static InvalidFacePointsException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.InvalidFacePointsException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InvalidFacePointsExceptionArray_
    {
        public static dynamic GetTSObject(InvalidFacePointsException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InvalidFacePointsException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InvalidFacePointsException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<InvalidFacePointsException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InvalidFacePointsException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
