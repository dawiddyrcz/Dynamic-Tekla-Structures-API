/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class GeometrySection 
    {

		public System.Int32 Index
		{
			get => teklaObject.Index;

		}

		public Dynamic.Tekla.Structures.Model.IGeometryNode GeometryNode
		{
			get => Dynamic.Tekla.Structures.Model.IGeometryNode_.FromTSObject(teklaObject.GeometryNode);

		}

        

        internal dynamic teklaObject;

		internal GeometrySection() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GeometrySection(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class GeometrySection_
    {
        public static dynamic GetTSObject(GeometrySection dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static GeometrySection FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.GeometrySection)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GeometrySectionArray_
    {
        public static dynamic GetTSObject(GeometrySection[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GeometrySection_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GeometrySection[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<GeometrySection>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GeometrySection_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
