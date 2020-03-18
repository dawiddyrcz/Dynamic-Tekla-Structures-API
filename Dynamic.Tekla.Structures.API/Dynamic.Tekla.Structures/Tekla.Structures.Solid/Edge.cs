//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Solid
{

    public sealed class Edge 
    {

		public Dynamic.Tekla.Structures.Solid.Edge.EdgeTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Solid.Edge.EdgeTypeEnum_.FromTSObject(edge.Type);
			set { edge.Type = Dynamic.Tekla.Structures.Solid.Edge.EdgeTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(edge.StartPoint);
			set { edge.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(edge.EndPoint);
			set { edge.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        internal dynamic edge;
        
        public Edge()
        {
            this.edge =  TSActivator.CreateInstance("Tekla.Structures.Solid.Edge");
        }

        internal Edge(dynamic tsObject)
        {
            this.edge = tsObject;
        }

		public System.Object Clone()
			 => edge.Clone();




    public enum EdgeTypeEnum
    {
			EDGE_TYPE_NORMAL,
			EDGE_TYPE_CURVED_SURFACE,
			EDGE_TYPE_HIDDEN        
    }

    internal static class EdgeTypeEnum_
    {
        public static dynamic GetTSObject(EdgeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Solid.EdgeTypeEnum");

            switch (dynEnum)
            {
				case EdgeTypeEnum.EDGE_TYPE_NORMAL:
					return System.Enum.Parse(tsType, "EDGE_TYPE_NORMAL");
				case EdgeTypeEnum.EDGE_TYPE_CURVED_SURFACE:
					return System.Enum.Parse(tsType, "EDGE_TYPE_CURVED_SURFACE");
				case EdgeTypeEnum.EDGE_TYPE_HIDDEN:
					return System.Enum.Parse(tsType, "EDGE_TYPE_HIDDEN");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static EdgeTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EDGE_TYPE_NORMAL", System.StringComparison.InvariantCulture))
				return EdgeTypeEnum.EDGE_TYPE_NORMAL;
			else if (tsEnumValue.Equals("EDGE_TYPE_CURVED_SURFACE", System.StringComparison.InvariantCulture))
				return EdgeTypeEnum.EDGE_TYPE_CURVED_SURFACE;
			else if (tsEnumValue.Equals("EDGE_TYPE_HIDDEN", System.StringComparison.InvariantCulture))
				return EdgeTypeEnum.EDGE_TYPE_HIDDEN;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Edge_
    {
        public static dynamic GetTSObject(Edge dynObject)
        {
            return dynObject.edge;
        }

        public static Edge FromTSObject(dynamic tsObject)
        {
            return new Edge(tsObject);
        }
    }


}
    
