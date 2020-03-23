/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class FacesTooNearEachOtherException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public FacesTooNearEachOtherException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.FacesTooNearEachOtherException");
		}





    }

    internal static class FacesTooNearEachOtherException_
    {
        public static dynamic GetTSObject(FacesTooNearEachOtherException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FacesTooNearEachOtherException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.FacesTooNearEachOtherException)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FacesTooNearEachOtherExceptionArray_
    {
        public static dynamic GetTSObject(FacesTooNearEachOtherException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FacesTooNearEachOtherException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FacesTooNearEachOtherException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<FacesTooNearEachOtherException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FacesTooNearEachOtherException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
