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
			set { teklaObject.Normal = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Identifier OriginPartId
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.OriginPartId);
			set { teklaObject.OriginPartId = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public Face() {}

		public Dynamic.Tekla.Structures.Solid.LoopEnumerator GetLoopEnumerator()
		{
			return Dynamic.Tekla.Structures.Solid.LoopEnumerator_.FromTSObject(teklaObject.GetLoopEnumerator());
		}





    }

    internal static class Face_
    {
        public static dynamic GetTSObject(Face dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Face FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Solid.Face)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FaceArray_
    {
        public static dynamic GetTSObject(Face[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Face_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Face[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Face>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Face_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
