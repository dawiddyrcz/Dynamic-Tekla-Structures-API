/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Solid
{

    public  class Edge 
    {


        public Dynamic.Tekla.Structures.Solid.Edge.EdgeTypeEnum Type
        {
            get
            {
                try
                {
                var value = teklaObject.Type;
                var value_ = Dynamic.Tekla.Structures.Solid.Edge.EdgeTypeEnum_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Solid.Edge.EdgeTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
            
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
        {
            get
            {
                try
                {
                var value = teklaObject.StartPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex); 
                }
            }
            
        }

        public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
        {
            get
            {
                try
                {
                var value = teklaObject.EndPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;

		internal Edge() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Edge(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


        public System.Object Clone()
        {
            
            try
            {
                var result = (System.Object) teklaObject.Clone();
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Clone), ex);
            }
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Edge_
    {
        public static dynamic GetTSObject(Edge dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Edge FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Solid.Edge)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EdgeArray_
    {
        public static dynamic GetTSObject(Edge[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Edge_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Edge[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Edge>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Edge_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
