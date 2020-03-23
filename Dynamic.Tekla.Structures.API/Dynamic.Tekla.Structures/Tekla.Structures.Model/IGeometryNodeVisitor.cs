/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class IGeometryNodeVisitor 
    {

        

        internal dynamic teklaObject;


		public void Visit(Dynamic.Tekla.Structures.Model.PolygonNode node)
		{
			teklaObject.Visit(Dynamic.Tekla.Structures.Model.PolygonNode_.GetTSObject(node));
		}

		public void Visit(Dynamic.Tekla.Structures.Model.CylindricalSurfaceNode node)
		{
			teklaObject.Visit(Dynamic.Tekla.Structures.Model.CylindricalSurfaceNode_.GetTSObject(node));
		}





    }

    internal static class IGeometryNodeVisitor_
    {
        public static dynamic GetTSObject(IGeometryNodeVisitor dynObject)
        {
            return dynObject.teklaObject;
        }

        public static IGeometryNodeVisitor FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IGeometryNodeVisitorArray_
    {
        public static dynamic GetTSObject(IGeometryNodeVisitor[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IGeometryNodeVisitor_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IGeometryNodeVisitor[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<IGeometryNodeVisitor>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IGeometryNodeVisitor_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
