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

        

        internal dynamic polyline;
        
        public PolyLine()
        {
            this.polyline =  TSActivator.CreateInstance("Tekla.Structures.Geometry3d.PolyLine");
        }

        internal PolyLine(dynamic tsObject)
        {
            this.polyline = tsObject;
        }

		public System.Double Length()
			 => polyline.Length();

		public System.Boolean op_Equality(Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine1, Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine2)
			 => polyline.op_Equality(Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(PolyLine1), Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(PolyLine2));

		public System.Boolean op_Inequality(Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine1, Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine2)
			 => polyline.op_Inequality(Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(PolyLine1), Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(PolyLine2));





    }

    internal static class PolyLine_
    {
        public static dynamic GetTSObject(PolyLine dynObject)
        {
            return dynObject.polyline;
        }

        public static PolyLine FromTSObject(dynamic tsObject)
        {
            return new PolyLine(tsObject);
        }
    }


}
    