//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class GraphicsDrawer 
    {

        

        dynamic graphicsdrawer;
        
        public GraphicsDrawer()
        {
            this.graphicsdrawer =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicsDrawer");
        }

        public GraphicsDrawer(dynamic tsObject)
        {
            this.graphicsdrawer = tsObject;

        }


        public dynamic GetTSObject() => graphicsdrawer;

		public System.Boolean DrawText(Dynamic.Tekla.Structures.Geometry3d.Point Location, System.String Text, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawText(Location.GetTSObject(), Text, Color.GetTSObject());

		public System.Boolean DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.LineSegment LineSegment, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawLineSegment(LineSegment.GetTSObject(), Color.GetTSObject());

		public System.Boolean DrawLineSegment(Dynamic.Tekla.Structures.Geometry3d.Point Point1, Dynamic.Tekla.Structures.Geometry3d.Point Point2, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawLineSegment(Point1.GetTSObject(), Point2.GetTSObject(), Color.GetTSObject());

		public System.Boolean DrawMeshSurface(Dynamic.Tekla.Structures.Model.UI.Mesh Mesh, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawMeshSurface(Mesh.GetTSObject(), Color.GetTSObject());

		public System.Boolean DrawMeshLines(Dynamic.Tekla.Structures.Model.UI.Mesh Mesh, Dynamic.Tekla.Structures.Model.UI.Color Color)
			 => graphicsdrawer.DrawMeshLines(Mesh.GetTSObject(), Color.GetTSObject());

		public System.Int32 DrawPolyLine(Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine GraphicPolyLine)
			 => graphicsdrawer.DrawPolyLine(GraphicPolyLine.GetTSObject());

		public void RemoveTemporaryGraphicsObject(System.Int32 GraphicObjectID)
			 => graphicsdrawer.RemoveTemporaryGraphicsObject(GraphicObjectID);

		public void RemoveTemporaryGraphicsObjects(System.Collections.IEnumerable GraphicObjectIDs)
			 => graphicsdrawer.RemoveTemporaryGraphicsObjects(GraphicObjectIDs);





    }

}
    
