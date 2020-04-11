/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class GraphicsDrawer 
    {

        

        internal dynamic teklaObject;

		public GraphicsDrawer()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicsDrawer");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GraphicsDrawer(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean DrawText(
	Dynamic.Tekla.Structures.Geometry3d.Point Location_,
	System.String Text,
	Dynamic.Tekla.Structures.Model.UI.Color Color_
	)
{
	var Location = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Location_);
	
	var Color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color_);
    try
    {
        	var result = (System.Boolean) teklaObject.DrawText(Location, Text, Color);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DrawText), ex);
    }
}



public System.Boolean DrawLineSegment(
	Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment_,
	Dynamic.Tekla.Structures.Model.UI.Color Color_
	)
{
	var LineSegment = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment_);
	var Color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color_);
    try
    {
        	var result = (System.Boolean) teklaObject.DrawLineSegment(LineSegment, Color);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DrawLineSegment), ex);
    }
}



public System.Boolean DrawLineSegment(
	Dynamic.Tekla.Structures.Geometry3d.Point Point1_,
	Dynamic.Tekla.Structures.Geometry3d.Point Point2_,
	Dynamic.Tekla.Structures.Model.UI.Color Color_
	)
{
	var Point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1_);
	var Point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2_);
	var Color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color_);
    try
    {
        	var result = (System.Boolean) teklaObject.DrawLineSegment(Point1, Point2, Color);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DrawLineSegment), ex);
    }
}



public System.Boolean DrawMeshSurface(
	Dynamic.Tekla.Structures.Model.UI.Mesh Mesh_,
	Dynamic.Tekla.Structures.Model.UI.Color Color_
	)
{
	var Mesh = Dynamic.Tekla.Structures.Model.UI.Mesh_.GetTSObject(Mesh_);
	var Color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color_);
    try
    {
        	var result = (System.Boolean) teklaObject.DrawMeshSurface(Mesh, Color);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DrawMeshSurface), ex);
    }
}



public System.Boolean DrawMeshLines(
	Dynamic.Tekla.Structures.Model.UI.Mesh Mesh_,
	Dynamic.Tekla.Structures.Model.UI.Color Color_
	)
{
	var Mesh = Dynamic.Tekla.Structures.Model.UI.Mesh_.GetTSObject(Mesh_);
	var Color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color_);
    try
    {
        	var result = (System.Boolean) teklaObject.DrawMeshLines(Mesh, Color);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DrawMeshLines), ex);
    }
}



public System.Int32 DrawPolyLine(
	Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine GraphicPolyLine_
	)
{
	var GraphicPolyLine = Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine_.GetTSObject(GraphicPolyLine_);
    try
    {
        	var result = (System.Int32) teklaObject.DrawPolyLine(GraphicPolyLine);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DrawPolyLine), ex);
    }
}



public void RemoveTemporaryGraphicsObject(
	System.Int32 GraphicObjectID
	)
{
	
    try
    {
        	teklaObject.RemoveTemporaryGraphicsObject(GraphicObjectID);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveTemporaryGraphicsObject), ex);
    }
}



public void RemoveTemporaryGraphicsObjects(
	System.Collections.IEnumerable GraphicObjectIDs
	)
{
	
    try
    {
        	teklaObject.RemoveTemporaryGraphicsObjects(GraphicObjectIDs);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveTemporaryGraphicsObjects), ex);
    }
}






    }

    internal static class GraphicsDrawer_
    {
        public static dynamic GetTSObject(GraphicsDrawer dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GraphicsDrawer FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.UI.GraphicsDrawer)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GraphicsDrawerArray_
    {
        public static dynamic GetTSObject(GraphicsDrawer[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GraphicsDrawer_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GraphicsDrawer[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GraphicsDrawer>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GraphicsDrawer_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
