/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class FacePerpendicularToIntersectionLineException  : Dynamic.Tekla.Structures.Model.ConnectiveGeometryException
    {

        

        

		public FacePerpendicularToIntersectionLineException()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.FacePerpendicularToIntersectionLineException");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public FacePerpendicularToIntersectionLineException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class FacePerpendicularToIntersectionLineException_
    {
        public static dynamic GetTSObject(FacePerpendicularToIntersectionLineException dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FacePerpendicularToIntersectionLineException FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.FacePerpendicularToIntersectionLineException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FacePerpendicularToIntersectionLineExceptionArray_
    {
        public static dynamic GetTSObject(FacePerpendicularToIntersectionLineException[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(FacePerpendicularToIntersectionLineException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static FacePerpendicularToIntersectionLineException[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<FacePerpendicularToIntersectionLineException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(FacePerpendicularToIntersectionLineException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
