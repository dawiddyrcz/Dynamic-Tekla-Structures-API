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

		public System.Boolean DrawText(Dynamic.Tekla.Structures.Geometry3d.Point Location, System.String Text, Dynamic.Tekla.Structures.Model.UI.Color Color)
		{
			return teklaObject.DrawText(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Location), Text, Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));
		}

		public System.Boolean DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Model.UI.Color Color)
		{
			return teklaObject.DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));
		}

		public System.Boolean DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2, Dynamic.Tekla.Structures.Model.UI.Color Color)
		{
			return teklaObject.DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));
		}

		public System.Boolean DrawMeshSurface(Dynamic.Tekla.Structures.Model.UI.Mesh Mesh, Dynamic.Tekla.Structures.Model.UI.Color Color)
		{
			return teklaObject.DrawMeshSurface(Dynamic.Tekla.Structures.Model.UI.Mesh_.GetTSObject(Mesh), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));
		}

		public System.Boolean DrawMeshLines(Dynamic.Tekla.Structures.Model.UI.Mesh Mesh, Dynamic.Tekla.Structures.Model.UI.Color Color)
		{
			return teklaObject.DrawMeshLines(Dynamic.Tekla.Structures.Model.UI.Mesh_.GetTSObject(Mesh), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));
		}

		public System.Int32 DrawPolyLine(Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine GraphicPolyLine)
		{
			return teklaObject.DrawPolyLine(Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine_.GetTSObject(GraphicPolyLine));
		}

		public void RemoveTemporaryGraphicsObject(System.Int32 GraphicObjectID)
		{
			teklaObject.RemoveTemporaryGraphicsObject(GraphicObjectID);
		}

		public void RemoveTemporaryGraphicsObjects(System.Collections.IEnumerable GraphicObjectIDs)
		{
			teklaObject.RemoveTemporaryGraphicsObjects(GraphicObjectIDs);
		}





    }

    internal static class GraphicsDrawer_
    {
        public static dynamic GetTSObject(GraphicsDrawer dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GraphicsDrawer FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.UI.GraphicsDrawer)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
