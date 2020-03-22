/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class WorkPlaneHandler 
    {

        

        internal dynamic teklaObject;

		public WorkPlaneHandler() {}

		public Dynamic.Tekla.Structures.Model.TransformationPlane GetCurrentTransformationPlane()
		{
			return Dynamic.Tekla.Structures.Model.TransformationPlane_.FromTSObject(teklaObject.GetCurrentTransformationPlane());
		}

		public System.Boolean SetCurrentTransformationPlane(Dynamic.Tekla.Structures.Model.TransformationPlane TransformationPlane)
		{
			return teklaObject.SetCurrentTransformationPlane(Dynamic.Tekla.Structures.Model.TransformationPlane_.GetTSObject(TransformationPlane));
		}





    }

    internal static class WorkPlaneHandler_
    {
        public static dynamic GetTSObject(WorkPlaneHandler dynObject)
        {
            return dynObject.teklaObject;
        }

        public static WorkPlaneHandler FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.WorkPlaneHandler)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
