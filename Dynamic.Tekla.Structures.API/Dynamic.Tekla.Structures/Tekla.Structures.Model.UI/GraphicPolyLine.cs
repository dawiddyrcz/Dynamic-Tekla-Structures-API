/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class GraphicPolyLine 
    {

		public Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine
		{
			get => Dynamic.Tekla.Structures.Geometry3d.PolyLine_.FromTSObject(teklaObject.PolyLine);
			set { teklaObject.PolyLine = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.UI.Color Color
		{
			get => Dynamic.Tekla.Structures.Model.UI.Color_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(value); }
		}

		public System.Int32 Width
		{
			get => teklaObject.Width;
			set { teklaObject.Width = value; }
		}

		public Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType Type
		{
			get => Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public GraphicPolyLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicPolyLine");
		}
		public GraphicPolyLine(Dynamic.Tekla.Structures.Model.UI.Color color, System.Int32 width, Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType type)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color);
			args[1] = width;
			args[2] = Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType_.GetTSObject(type);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicPolyLine", args);
		}
		public GraphicPolyLine(Dynamic.Tekla.Structures.Geometry3d.PolyLine polyLine, Dynamic.Tekla.Structures.Model.UI.Color color, System.Int32 width, Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType type)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(polyLine);
			args[1] = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color);
			args[2] = width;
			args[3] = Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType_.GetTSObject(type);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicPolyLine", args);
		}




    public enum LineType
    {
			Solid,
			Dashed1,
			Dashed2,
			DashedAndDotted,
			Dotted        
    }

    internal static class LineType_
    {
        public static dynamic GetTSObject(LineType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicPolyLine.LineType").GetType();

            switch (dynEnum)
            {
				case LineType.Solid:
					return System.Enum.Parse(tsType, "Solid");
				case LineType.Dashed1:
					return System.Enum.Parse(tsType, "Dashed1");
				case LineType.Dashed2:
					return System.Enum.Parse(tsType, "Dashed2");
				case LineType.DashedAndDotted:
					return System.Enum.Parse(tsType, "DashedAndDotted");
				case LineType.Dotted:
					return System.Enum.Parse(tsType, "Dotted");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LineType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Solid", System.StringComparison.InvariantCulture))
				return LineType.Solid;
			else if (tsEnumValue.Equals("Dashed1", System.StringComparison.InvariantCulture))
				return LineType.Dashed1;
			else if (tsEnumValue.Equals("Dashed2", System.StringComparison.InvariantCulture))
				return LineType.Dashed2;
			else if (tsEnumValue.Equals("DashedAndDotted", System.StringComparison.InvariantCulture))
				return LineType.DashedAndDotted;
			else if (tsEnumValue.Equals("Dotted", System.StringComparison.InvariantCulture))
				return LineType.Dotted;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class GraphicPolyLine_
    {
        public static dynamic GetTSObject(GraphicPolyLine dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GraphicPolyLine FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GraphicPolyLineArray_
    {
        public static dynamic GetTSObject(GraphicPolyLine[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GraphicPolyLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GraphicPolyLine[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<GraphicPolyLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GraphicPolyLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
