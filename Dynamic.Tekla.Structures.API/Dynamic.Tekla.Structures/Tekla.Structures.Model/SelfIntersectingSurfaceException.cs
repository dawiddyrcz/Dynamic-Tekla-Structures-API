/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class SelfIntersectingSurfaceException  : Dynamic.Tekla.Structures.Model.LoftedPlateOperationException
    {

        

        

		public SelfIntersectingSurfaceException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SelfIntersectingSurfaceException");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SelfIntersectingSurfaceException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class SelfIntersectingSurfaceException_
    {
        public static dynamic GetTSObject(SelfIntersectingSurfaceException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SelfIntersectingSurfaceException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.SelfIntersectingSurfaceException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SelfIntersectingSurfaceExceptionArray_
    {
        public static dynamic GetTSObject(SelfIntersectingSurfaceException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SelfIntersectingSurfaceException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SelfIntersectingSurfaceException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<SelfIntersectingSurfaceException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SelfIntersectingSurfaceException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
