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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public WorkPlaneHandler(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.WorkPlaneHandler)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class WorkPlaneHandlerArray_
    {
        public static dynamic GetTSObject(WorkPlaneHandler[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(WorkPlaneHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static WorkPlaneHandler[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<WorkPlaneHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(WorkPlaneHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
