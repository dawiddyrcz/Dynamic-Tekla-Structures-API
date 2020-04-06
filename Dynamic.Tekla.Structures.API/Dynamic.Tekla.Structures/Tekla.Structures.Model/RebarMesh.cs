/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarMesh  : Dynamic.Tekla.Structures.Model.Reinforcement
    {

		public Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshTypeEnum MeshType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshTypeEnum_.FromTSObject(teklaObject.MeshType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MeshType"); }
			}
			set
			{
				try {
				teklaObject.MeshType = Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshTypeEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("MeshType"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshSpacingMethodEnum LongitudinalSpacingMethod
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshSpacingMethodEnum_.FromTSObject(teklaObject.LongitudinalSpacingMethod);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LongitudinalSpacingMethod"); }
			}
			set
			{
				try {
				teklaObject.LongitudinalSpacingMethod = Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshSpacingMethodEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LongitudinalSpacingMethod"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.Polygon);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygon"); }
			}
			set
			{
				try {
				teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polygon"); }
			}
		}

		public System.Collections.ArrayList LongitudinalDistances
		{
			get
			{
				try {
					return TSActivator.ConvertArrayList(teklaObject.LongitudinalDistances);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LongitudinalDistances"); }
			}
			set
			{
				try {
					teklaObject.LongitudinalDistances = TSActivator.ConvertToTSArrayList(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LongitudinalDistances"); }
			}
		}

		public System.Collections.ArrayList CrossDistances
		{
			get
			{
				try {
					return TSActivator.ConvertArrayList(teklaObject.CrossDistances);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossDistances"); }
			}
			set
			{
				try {
					teklaObject.CrossDistances = TSActivator.ConvertToTSArrayList(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossDistances"); }
			}
		}

		public System.Double FromPlaneOffset
		{
			get
			{
				try {
					return teklaObject.FromPlaneOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FromPlaneOffset"); }
			}
			set
			{
				try {
					teklaObject.FromPlaneOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("FromPlaneOffset"); }
			}
		}

		public System.Double StartFromPlaneOffset
		{
			get
			{
				try {
					return teklaObject.StartFromPlaneOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartFromPlaneOffset"); }
			}
			set
			{
				try {
					teklaObject.StartFromPlaneOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartFromPlaneOffset"); }
			}
		}

		public System.Double EndFromPlaneOffset
		{
			get
			{
				try {
					return teklaObject.EndFromPlaneOffset;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndFromPlaneOffset"); }
			}
			set
			{
				try {
					teklaObject.EndFromPlaneOffset = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndFromPlaneOffset"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
			set
			{
				try {
				teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
			set
			{
				try {
				teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
		}

		public System.Double LeftOverhangLongitudinal
		{
			get
			{
				try {
					return teklaObject.LeftOverhangLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangLongitudinal"); }
			}
			set
			{
				try {
					teklaObject.LeftOverhangLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangLongitudinal"); }
			}
		}

		public System.Double LeftOverhangCross
		{
			get
			{
				try {
					return teklaObject.LeftOverhangCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangCross"); }
			}
			set
			{
				try {
					teklaObject.LeftOverhangCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LeftOverhangCross"); }
			}
		}

		public System.Double RightOverhangLongitudinal
		{
			get
			{
				try {
					return teklaObject.RightOverhangLongitudinal;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangLongitudinal"); }
			}
			set
			{
				try {
					teklaObject.RightOverhangLongitudinal = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangLongitudinal"); }
			}
		}

		public System.Double RightOverhangCross
		{
			get
			{
				try {
					return teklaObject.RightOverhangCross;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangCross"); }
			}
			set
			{
				try {
					teklaObject.RightOverhangCross = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RightOverhangCross"); }
			}
		}

		public System.String LongitudinalSize
		{
			get
			{
				try {
					return teklaObject.LongitudinalSize;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LongitudinalSize"); }
			}
			set
			{
				try {
					teklaObject.LongitudinalSize = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LongitudinalSize"); }
			}
		}

		public System.String CrossSize
		{
			get
			{
				try {
					return teklaObject.CrossSize;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossSize"); }
			}
			set
			{
				try {
					teklaObject.CrossSize = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossSize"); }
			}
		}

		public System.Double Width
		{
			get
			{
				try {
					return teklaObject.Width;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width"); }
			}
			set
			{
				try {
					teklaObject.Width = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Width"); }
			}
		}

		public System.Double Length
		{
			get
			{
				try {
					return teklaObject.Length;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Length"); }
			}
			set
			{
				try {
					teklaObject.Length = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Length"); }
			}
		}

		public System.Boolean CutByFatherPartCuts
		{
			get
			{
				try {
					return teklaObject.CutByFatherPartCuts;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutByFatherPartCuts"); }
			}
			set
			{
				try {
					teklaObject.CutByFatherPartCuts = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CutByFatherPartCuts"); }
			}
		}

		public System.String CatalogName
		{
			get
			{
				try {
					return teklaObject.CatalogName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CatalogName"); }
			}
			set
			{
				try {
					teklaObject.CatalogName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CatalogName"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshCrossBarLocationEnum CrossBarLocation
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshCrossBarLocationEnum_.FromTSObject(teklaObject.CrossBarLocation);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossBarLocation"); }
			}
			set
			{
				try {
				teklaObject.CrossBarLocation = Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshCrossBarLocationEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CrossBarLocation"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData StartHook
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.StartHook);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartHook"); }
			}
			set
			{
				try {
				teklaObject.StartHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartHook"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData EndHook
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.EndHook);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndHook"); }
			}
			set
			{
				try {
				teklaObject.EndHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndHook"); }
			}
		}

        

        

		public RebarMesh()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarMesh");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RebarMesh(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}




    public enum RebarMeshTypeEnum
    {
			UNKNOWN_MESH,
			RECTANGULAR_MESH,
			POLYGON_MESH,
			BENT_MESH        
    }

    internal static class RebarMeshTypeEnum_
    {
        public static dynamic GetTSObject(RebarMeshTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarMesh.RebarMeshTypeEnum").GetType();

            switch (dynEnum)
            {
				case RebarMeshTypeEnum.UNKNOWN_MESH:
					return System.Enum.Parse(tsType, "UNKNOWN_MESH");
				case RebarMeshTypeEnum.RECTANGULAR_MESH:
					return System.Enum.Parse(tsType, "RECTANGULAR_MESH");
				case RebarMeshTypeEnum.POLYGON_MESH:
					return System.Enum.Parse(tsType, "POLYGON_MESH");
				case RebarMeshTypeEnum.BENT_MESH:
					return System.Enum.Parse(tsType, "BENT_MESH");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarMeshTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UNKNOWN_MESH", System.StringComparison.InvariantCulture))
				return RebarMeshTypeEnum.UNKNOWN_MESH;
			else if (tsEnumValue.Equals("RECTANGULAR_MESH", System.StringComparison.InvariantCulture))
				return RebarMeshTypeEnum.RECTANGULAR_MESH;
			else if (tsEnumValue.Equals("POLYGON_MESH", System.StringComparison.InvariantCulture))
				return RebarMeshTypeEnum.POLYGON_MESH;
			else if (tsEnumValue.Equals("BENT_MESH", System.StringComparison.InvariantCulture))
				return RebarMeshTypeEnum.BENT_MESH;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarMeshSpacingMethodEnum
    {
			SPACING_TYPE_UNDEFINED,
			SPACING_TYPE_SAME_DISTANCE,
			SPACING_TYPE_MULTIPLE_VARYING_DISTANCES        
    }

    internal static class RebarMeshSpacingMethodEnum_
    {
        public static dynamic GetTSObject(RebarMeshSpacingMethodEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarMesh.RebarMeshSpacingMethodEnum").GetType();

            switch (dynEnum)
            {
				case RebarMeshSpacingMethodEnum.SPACING_TYPE_UNDEFINED:
					return System.Enum.Parse(tsType, "SPACING_TYPE_UNDEFINED");
				case RebarMeshSpacingMethodEnum.SPACING_TYPE_SAME_DISTANCE:
					return System.Enum.Parse(tsType, "SPACING_TYPE_SAME_DISTANCE");
				case RebarMeshSpacingMethodEnum.SPACING_TYPE_MULTIPLE_VARYING_DISTANCES:
					return System.Enum.Parse(tsType, "SPACING_TYPE_MULTIPLE_VARYING_DISTANCES");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarMeshSpacingMethodEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPACING_TYPE_UNDEFINED", System.StringComparison.InvariantCulture))
				return RebarMeshSpacingMethodEnum.SPACING_TYPE_UNDEFINED;
			else if (tsEnumValue.Equals("SPACING_TYPE_SAME_DISTANCE", System.StringComparison.InvariantCulture))
				return RebarMeshSpacingMethodEnum.SPACING_TYPE_SAME_DISTANCE;
			else if (tsEnumValue.Equals("SPACING_TYPE_MULTIPLE_VARYING_DISTANCES", System.StringComparison.InvariantCulture))
				return RebarMeshSpacingMethodEnum.SPACING_TYPE_MULTIPLE_VARYING_DISTANCES;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarMeshCrossBarLocationEnum
    {
			LOCATION_TYPE_ABOVE,
			LOCATION_TYPE_BELOW,
			LOCATION_TYPE_UNDEFINED        
    }

    internal static class RebarMeshCrossBarLocationEnum_
    {
        public static dynamic GetTSObject(RebarMeshCrossBarLocationEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarMesh.RebarMeshCrossBarLocationEnum").GetType();

            switch (dynEnum)
            {
				case RebarMeshCrossBarLocationEnum.LOCATION_TYPE_ABOVE:
					return System.Enum.Parse(tsType, "LOCATION_TYPE_ABOVE");
				case RebarMeshCrossBarLocationEnum.LOCATION_TYPE_BELOW:
					return System.Enum.Parse(tsType, "LOCATION_TYPE_BELOW");
				case RebarMeshCrossBarLocationEnum.LOCATION_TYPE_UNDEFINED:
					return System.Enum.Parse(tsType, "LOCATION_TYPE_UNDEFINED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarMeshCrossBarLocationEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOCATION_TYPE_ABOVE", System.StringComparison.InvariantCulture))
				return RebarMeshCrossBarLocationEnum.LOCATION_TYPE_ABOVE;
			else if (tsEnumValue.Equals("LOCATION_TYPE_BELOW", System.StringComparison.InvariantCulture))
				return RebarMeshCrossBarLocationEnum.LOCATION_TYPE_BELOW;
			else if (tsEnumValue.Equals("LOCATION_TYPE_UNDEFINED", System.StringComparison.InvariantCulture))
				return RebarMeshCrossBarLocationEnum.LOCATION_TYPE_UNDEFINED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarMesh_
    {
        public static dynamic GetTSObject(RebarMesh dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarMesh FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RebarMesh)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarMeshArray_
    {
        public static dynamic GetTSObject(RebarMesh[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarMesh_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarMesh[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarMesh>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarMesh_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
