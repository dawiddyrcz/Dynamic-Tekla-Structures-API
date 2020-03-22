/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Solid
{

    public  class Edge 
    {

		public Dynamic.Tekla.Structures.Solid.Edge.EdgeTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Solid.Edge.EdgeTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Solid.Edge.EdgeTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public Edge() {}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}




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
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Solid.Edge.EdgeTypeEnum").GetType();

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
            return dynObject.teklaObject;
        }

        public static Edge FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Solid.Edge)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
