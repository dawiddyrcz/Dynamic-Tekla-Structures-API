/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ConnectiveGeometryException  : System.Exception
    {

		public Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus OperationStatus
		{
			get => Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus_.FromTSObject(teklaObject.OperationStatus);

		}

        

        internal dynamic teklaObject;

		public ConnectiveGeometryException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometryException");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ConnectiveGeometryException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ConnectiveGeometryException(Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus status, System.String errorMessage)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus_.GetTSObject(status);
			args[1] = errorMessage;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometryException", args);
		}





    }

    internal static class ConnectiveGeometryException_
    {
        public static dynamic GetTSObject(ConnectiveGeometryException dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ConnectiveGeometryException FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ConnectiveGeometryException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ConnectiveGeometryExceptionArray_
    {
        public static dynamic GetTSObject(ConnectiveGeometryException[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ConnectiveGeometryException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ConnectiveGeometryException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ConnectiveGeometryException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ConnectiveGeometryException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
