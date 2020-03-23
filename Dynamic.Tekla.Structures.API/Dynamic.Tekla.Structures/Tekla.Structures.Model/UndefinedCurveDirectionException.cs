/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class UndefinedCurveDirectionException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public UndefinedCurveDirectionException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UndefinedCurveDirectionException");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public UndefinedCurveDirectionException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class UndefinedCurveDirectionException_
    {
        public static dynamic GetTSObject(UndefinedCurveDirectionException dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static UndefinedCurveDirectionException FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UndefinedCurveDirectionException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UndefinedCurveDirectionExceptionArray_
    {
        public static dynamic GetTSObject(UndefinedCurveDirectionException[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(UndefinedCurveDirectionException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static UndefinedCurveDirectionException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<UndefinedCurveDirectionException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(UndefinedCurveDirectionException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
