/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class Face 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Vector Normal
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Normal);

		}

		public Dynamic.Tekla.Structures.Identifier OriginPartId
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.OriginPartId);

		}

        

        internal dynamic teklaObject;

		public Face() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Face(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Solid.LoopEnumerator GetLoopEnumerator()
		{
			return Dynamic.Tekla.Structures.Solid.LoopEnumerator_.FromTSObject(teklaObject.GetLoopEnumerator());
		}





    }

    internal static class Face_
    {
        public static dynamic GetTSObject(Face dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Face FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Solid.Face)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FaceArray_
    {
        public static dynamic GetTSObject(Face[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Face_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Face[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Face>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Face_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
