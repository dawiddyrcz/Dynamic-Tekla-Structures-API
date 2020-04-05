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
			try {
			teklaObject.Visit(Dynamic.Tekla.Structures.Model.PolygonNode_.GetTSObject(node));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Visit()"); }
		}

		public void Visit(Dynamic.Tekla.Structures.Model.CylindricalSurfaceNode node)
		{
			try {
			teklaObject.Visit(Dynamic.Tekla.Structures.Model.CylindricalSurfaceNode_.GetTSObject(node));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Visit()"); }
		}





    }

    internal static class IGeometryNodeVisitor_
    {
        public static dynamic GetTSObject(IGeometryNodeVisitor dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static IGeometryNodeVisitor FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.IGeometryNodeVisitor)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class IGeometryNodeVisitorArray_
    {
        public static dynamic GetTSObject(IGeometryNodeVisitor[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(IGeometryNodeVisitor_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static IGeometryNodeVisitor[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<IGeometryNodeVisitor>();
            foreach(var tsItem in tsArray)
            {
                list.Add(IGeometryNodeVisitor_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
