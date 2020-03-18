//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class GraphicsDrawer 
    {

        

        internal dynamic graphicsdrawer;
        
        public GraphicsDrawer()
        {
            this.graphicsdrawer =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicsDrawer");
        }

        internal GraphicsDrawer(dynamic tsObject)
        {
            this.graphicsdrawer = tsObject;
        }

		public System.Boolean DrawText(Dynamic.Tekla.Structures.Geometry3d.Point Location, System.String Text, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawText(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Location), Text, Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));

		public System.Boolean DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(LineSegment), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));

		public System.Boolean DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point2), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));

		public System.Boolean DrawMeshSurface(Dynamic.Tekla.Structures.Model.UI.Mesh Mesh, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawMeshSurface(Dynamic.Tekla.Structures.Model.UI.Mesh_.GetTSObject(Mesh), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));

		public System.Boolean DrawMeshLines(Dynamic.Tekla.Structures.Model.UI.Mesh Mesh, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawMeshLines(Dynamic.Tekla.Structures.Model.UI.Mesh_.GetTSObject(Mesh), Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(Color));

		public System.Int32 DrawPolyLine(Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine GraphicPolyLine)
			 => graphicsdrawer.DrawPolyLine(Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine_.GetTSObject(GraphicPolyLine));

		public void RemoveTemporaryGraphicsObject(System.Int32 GraphicObjectID)
			 => graphicsdrawer.RemoveTemporaryGraphicsObject(GraphicObjectID);

		public void RemoveTemporaryGraphicsObjects(System.Collections.IEnumerable GraphicObjectIDs)
			 => graphicsdrawer.RemoveTemporaryGraphicsObjects(GraphicObjectIDs);





    }

    internal static class GraphicsDrawer_
    {
        public static dynamic GetTSObject(GraphicsDrawer dynObject)
        {
            return dynObject.graphicsdrawer;
        }

        public static GraphicsDrawer FromTSObject(dynamic tsObject)
        {
            return new GraphicsDrawer(tsObject);
        }
    }


}
    