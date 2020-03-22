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
            var dynObject = (Tekla.Structures.Model.SelfIntersectingSurfaceException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
