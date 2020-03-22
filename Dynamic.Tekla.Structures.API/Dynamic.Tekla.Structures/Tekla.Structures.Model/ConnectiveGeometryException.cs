/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ConnectiveGeometryException 
    {

		public Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus OperationStatus
		{
			get => Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus_.FromTSObject(teklaObject.OperationStatus);
			set { teklaObject.OperationStatus = Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public ConnectiveGeometryException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometryException");
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
            return dynObject.teklaObject;
        }

        public static ConnectiveGeometryException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ConnectiveGeometryException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
