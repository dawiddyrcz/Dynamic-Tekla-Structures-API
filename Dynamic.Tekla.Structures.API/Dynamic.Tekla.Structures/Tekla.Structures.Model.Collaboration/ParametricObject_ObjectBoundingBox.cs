/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Collaboration
{

    public  class ParametricObject_ObjectBoundingBox  : Dynamic.Tekla.Structures.Model.Collaboration.ReferenceModelObjectAttribute
    {

		public Dynamic.Tekla.Structures.Geometry3d.Vector yDir
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.yDir);

		}

        

        

		internal ParametricObject_ObjectBoundingBox() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ParametricObject_ObjectBoundingBox(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class ParametricObject_ObjectBoundingBox_
    {
        public static dynamic GetTSObject(ParametricObject_ObjectBoundingBox dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ParametricObject_ObjectBoundingBox FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Collaboration.ParametricObject_ObjectBoundingBox)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ParametricObject_ObjectBoundingBoxArray_
    {
        public static dynamic GetTSObject(ParametricObject_ObjectBoundingBox[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ParametricObject_ObjectBoundingBox_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ParametricObject_ObjectBoundingBox[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ParametricObject_ObjectBoundingBox>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ParametricObject_ObjectBoundingBox_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
