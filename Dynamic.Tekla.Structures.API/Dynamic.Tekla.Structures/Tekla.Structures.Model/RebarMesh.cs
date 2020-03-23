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
			get => Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshTypeEnum_.FromTSObject(teklaObject.MeshType);
			set { teklaObject.MeshType = Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshSpacingMethodEnum LongitudinalSpacingMethod
		{
			get => Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshSpacingMethodEnum_.FromTSObject(teklaObject.LongitudinalSpacingMethod);
			set { teklaObject.LongitudinalSpacingMethod = Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshSpacingMethodEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.Polygon);
			set { teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value); }
		}

		public System.Collections.ArrayList LongitudinalDistances
		{
			get => teklaObject.LongitudinalDistances;
			set { teklaObject.LongitudinalDistances = value; }
		}

		public System.Collections.ArrayList CrossDistances
		{
			get => teklaObject.CrossDistances;
			set { teklaObject.CrossDistances = value; }
		}

		public System.Double FromPlaneOffset
		{
			get => teklaObject.FromPlaneOffset;
			set { teklaObject.FromPlaneOffset = value; }
		}

		public System.Double StartFromPlaneOffset
		{
			get => teklaObject.StartFromPlaneOffset;
			set { teklaObject.StartFromPlaneOffset = value; }
		}

		public System.Double EndFromPlaneOffset
		{
			get => teklaObject.EndFromPlaneOffset;
			set { teklaObject.EndFromPlaneOffset = value; }
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

		public System.Double LeftOverhangLongitudinal
		{
			get => teklaObject.LeftOverhangLongitudinal;
			set { teklaObject.LeftOverhangLongitudinal = value; }
		}

		public System.Double LeftOverhangCross
		{
			get => teklaObject.LeftOverhangCross;
			set { teklaObject.LeftOverhangCross = value; }
		}

		public System.Double RightOverhangLongitudinal
		{
			get => teklaObject.RightOverhangLongitudinal;
			set { teklaObject.RightOverhangLongitudinal = value; }
		}

		public System.Double RightOverhangCross
		{
			get => teklaObject.RightOverhangCross;
			set { teklaObject.RightOverhangCross = value; }
		}

		public System.String LongitudinalSize
		{
			get => teklaObject.LongitudinalSize;
			set { teklaObject.LongitudinalSize = value; }
		}

		public System.String CrossSize
		{
			get => teklaObject.CrossSize;
			set { teklaObject.CrossSize = value; }
		}

		public System.Double Width
		{
			get => teklaObject.Width;
			set { teklaObject.Width = value; }
		}

		public System.Double Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

		public System.Boolean CutByFatherPartCuts
		{
			get => teklaObject.CutByFatherPartCuts;
			set { teklaObject.CutByFatherPartCuts = value; }
		}

		public System.String CatalogName
		{
			get => teklaObject.CatalogName;
			set { teklaObject.CatalogName = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshCrossBarLocationEnum CrossBarLocation
		{
			get => Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshCrossBarLocationEnum_.FromTSObject(teklaObject.CrossBarLocation);
			set { teklaObject.CrossBarLocation = Dynamic.Tekla.Structures.Model.RebarMesh.RebarMeshCrossBarLocationEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData StartHook
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.StartHook);
			set { teklaObject.StartHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData EndHook
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.EndHook);
			set { teklaObject.EndHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value); }
		}

        

        

		public RebarMesh()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarMesh");
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarMesh_
    {
        public static dynamic GetTSObject(RebarMesh dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarMesh FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.RebarMesh)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarMeshArray_
    {
        public static dynamic GetTSObject(RebarMesh[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarMesh_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarMesh[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<RebarMesh>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarMesh_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
