//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class PolyLine 
    {

		public System.Collections.ArrayList Points
		{
			get => polyline.Points;
			set { polyline.Points = value; }
		}

        

        dynamic polyline;
        
        public PolyLine()
        {
            this.polyline =  new Tekla.Structures.Geometry3d.PolyLine();
        }

        public PolyLine(dynamic tsObject)
        {
            this.polyline = tsObject;
			this.Points = polyline.Points;

        }


        public dynamic GetTSObject() => polyline;

		public System.Double Length()
			 => polyline.Length();

		public System.Boolean op_Equality(Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine1, Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine2)
			 => polyline.op_Equality(PolyLine1.GetTSObject(), PolyLine2.GetTSObject());

		public System.Boolean op_Inequality(Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine1, Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine2)
			 => polyline.op_Inequality(PolyLine1.GetTSObject(), PolyLine2.GetTSObject());





    }

}
    
