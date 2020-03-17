//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Solid 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point MinimumPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(solid.MinimumPoint.GetTSObject());
			set { solid.MinimumPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point MaximumPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(solid.MaximumPoint.GetTSObject());
			set { solid.MaximumPoint = value.GetTSObject(); }
		}

        

        dynamic solid;
        
        public Solid()
        {
            this.solid =  TSActivator.CreateInstance("Tekla.Structures.Model.Solid");
        }

        public Solid(dynamic tsObject)
        {
            this.solid = tsObject;
			this.MinimumPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(solid.MinimumPoint);
			this.MaximumPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(solid.MaximumPoint);

        }


        public dynamic GetTSObject() => solid;

		public System.Collections.ArrayList Intersect(Dynamic.Tekla.Structures.Geometry3d.LineSegment line)
			 => solid.Intersect(line.GetTSObject());

		public System.Collections.ArrayList Intersect(Dynamic.Tekla.Structures.Geometry3d.Point point1, Dynamic.Tekla.Structures.Geometry3d.Point point2)
			 => solid.Intersect(point1.GetTSObject(), point2.GetTSObject());

		public System.Collections.ArrayList Intersect(Dynamic.Tekla.Structures.Geometry3d.Point point1, Dynamic.Tekla.Structures.Geometry3d.Point point2, Dynamic.Tekla.Structures.Geometry3d.Point point3)
			 => solid.Intersect(point1.GetTSObject(), point2.GetTSObject(), point3.GetTSObject());

		public Dynamic.Tekla.Structures.Solid.FaceEnumerator GetFaceEnumerator()
			 => new Dynamic.Tekla.Structures.Solid.FaceEnumerator(solid.GetFaceEnumerator());

		public Dynamic.Tekla.Structures.Solid.EdgeEnumerator GetEdgeEnumerator()
			 => new Dynamic.Tekla.Structures.Solid.EdgeEnumerator(solid.GetEdgeEnumerator());

		public Dynamic.Tekla.Structures.Solid.ShellEnumerator GetCutPart(Dynamic.Tekla.Structures.Model.Solid CuttingPart)
			 => new Dynamic.Tekla.Structures.Solid.ShellEnumerator(solid.GetCutPart(CuttingPart.GetTSObject()));




    public enum SolidCreationTypeEnum
    {
			RAW,
			FITTED,
			NORMAL,
			HIGH_ACCURACY,
			PLANECUTTED,
			NORMAL_WITHOUT_EDGECHAMFERS,
			NORMAL_WITHOUT_WELDPREPS        
    }

    public static class SolidCreationTypeEnum_
    {
        public static dynamic GetTSObject(SolidCreationTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.SolidCreationTypeEnum");

            switch (dynEnum)
            {
				case SolidCreationTypeEnum.RAW:
					return System.Enum.Parse(tsType, "RAW");
				case SolidCreationTypeEnum.FITTED:
					return System.Enum.Parse(tsType, "FITTED");
				case SolidCreationTypeEnum.NORMAL:
					return System.Enum.Parse(tsType, "NORMAL");
				case SolidCreationTypeEnum.HIGH_ACCURACY:
					return System.Enum.Parse(tsType, "HIGH_ACCURACY");
				case SolidCreationTypeEnum.PLANECUTTED:
					return System.Enum.Parse(tsType, "PLANECUTTED");
				case SolidCreationTypeEnum.NORMAL_WITHOUT_EDGECHAMFERS:
					return System.Enum.Parse(tsType, "NORMAL_WITHOUT_EDGECHAMFERS");
				case SolidCreationTypeEnum.NORMAL_WITHOUT_WELDPREPS:
					return System.Enum.Parse(tsType, "NORMAL_WITHOUT_WELDPREPS");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SolidCreationTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("RAW", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.RAW;
			else if (tsEnumValue.Equals("FITTED", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.FITTED;
			else if (tsEnumValue.Equals("NORMAL", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.NORMAL;
			else if (tsEnumValue.Equals("HIGH_ACCURACY", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.HIGH_ACCURACY;
			else if (tsEnumValue.Equals("PLANECUTTED", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.PLANECUTTED;
			else if (tsEnumValue.Equals("NORMAL_WITHOUT_EDGECHAMFERS", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.NORMAL_WITHOUT_EDGECHAMFERS;
			else if (tsEnumValue.Equals("NORMAL_WITHOUT_WELDPREPS", System.StringComparison.InvariantCulture))
				return SolidCreationTypeEnum.NORMAL_WITHOUT_WELDPREPS;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
