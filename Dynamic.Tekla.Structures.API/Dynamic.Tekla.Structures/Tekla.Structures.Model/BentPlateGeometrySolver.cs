//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class BentPlateGeometrySolver 
    {

        

        internal dynamic bentplategeometrysolver;
        
        public BentPlateGeometrySolver()
        {
            this.bentplategeometrysolver =  TSActivator.CreateInstance("Tekla.Structures.Model.BentPlateGeometrySolver");
        }

        internal BentPlateGeometrySolver(dynamic tsObject)
        {
            this.bentplategeometrysolver = tsObject;
        }

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.Contour polygon, Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon), Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape)));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.Contour polygon)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon)));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.Contour polygon, System.Double radius)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon), radius));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.Contour polygon, System.Double largestRadius, System.Double halfAperture)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon), largestRadius, halfAperture));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1, Dynamic.Tekla.Structures.Model.Contour polygon, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2, Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1), Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2), Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape)));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1, Dynamic.Tekla.Structures.Model.Contour polygon, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1), Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2)));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1, Dynamic.Tekla.Structures.Model.Contour polygon, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2, System.Double radius)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1), Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2), radius));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1, Dynamic.Tekla.Structures.Model.Contour polygon, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2, System.Double largestRadius, System.Double halfAperture)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.AddLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1), Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon), Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2), largestRadius, halfAperture));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry RemoveLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.GeometrySection legSection)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.RemoveLeg(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(legSection)));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyBendSurface(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.GeometrySection bendSection, Dynamic.Tekla.Structures.Model.BendSurface surface)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.ModifyBendSurface(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(bendSection), Dynamic.Tekla.Structures.Model.BendSurface_.GetTSObject(surface)));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyCylindricalSurface(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.GeometrySection cylindricalSection, Dynamic.Tekla.Structures.Model.CylindricalSurface surface)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.ModifyCylindricalSurface(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(cylindricalSection), Dynamic.Tekla.Structures.Model.CylindricalSurface_.GetTSObject(surface)));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyRadius(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.GeometrySection cylindricalSection, System.Double radius)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.ModifyRadius(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(cylindricalSection), radius));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyConicalRadiuses(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.GeometrySection conicalSection, System.Double radius1, System.Double radius2)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.ModifyConicalRadiuses(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(conicalSection), radius1, radius2));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ScaleConeSection(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.GeometrySection conicalSection, System.Double scale)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.ScaleConeSection(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(conicalSection), scale));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyPolygon(Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry, Dynamic.Tekla.Structures.Model.GeometrySection polygonSection, Dynamic.Tekla.Structures.Model.Contour points)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.ModifyPolygon(Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry), Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(polygonSection), Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(points)));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry SetMainSection(Dynamic.Tekla.Structures.Model.GeometrySection newMainSection, Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.SetMainSection(Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(newMainSection), Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry)));

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry SetBendAngle(System.Double angle, Dynamic.Tekla.Structures.Model.GeometrySection sectionToSetAngle, Dynamic.Tekla.Structures.Model.GeometrySection sectionToMove, Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry)
			 => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplategeometrysolver.SetBendAngle(angle, Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(sectionToSetAngle), Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(sectionToMove), Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry)));




    public enum OperationStatus
    {
			Success,
			Failure,
			FacePerpendicularToIntersectionLine,
			PlateIntersectsWithIntersectionLine,
			ExtensionIntersectsWithPlate,
			FacesTooNearEachOther,
			FacesAtAnObtuseAngle,
			UndefinedCurveDirection,
			UnsupportedChamfer,
			InvalidRadius,
			InvalidFacePoints        
    }

    internal static class OperationStatus_
    {
        public static dynamic GetTSObject(OperationStatus dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.OperationStatus");

            switch (dynEnum)
            {
				case OperationStatus.Success:
					return System.Enum.Parse(tsType, "Success");
				case OperationStatus.Failure:
					return System.Enum.Parse(tsType, "Failure");
				case OperationStatus.FacePerpendicularToIntersectionLine:
					return System.Enum.Parse(tsType, "FacePerpendicularToIntersectionLine");
				case OperationStatus.PlateIntersectsWithIntersectionLine:
					return System.Enum.Parse(tsType, "PlateIntersectsWithIntersectionLine");
				case OperationStatus.ExtensionIntersectsWithPlate:
					return System.Enum.Parse(tsType, "ExtensionIntersectsWithPlate");
				case OperationStatus.FacesTooNearEachOther:
					return System.Enum.Parse(tsType, "FacesTooNearEachOther");
				case OperationStatus.FacesAtAnObtuseAngle:
					return System.Enum.Parse(tsType, "FacesAtAnObtuseAngle");
				case OperationStatus.UndefinedCurveDirection:
					return System.Enum.Parse(tsType, "UndefinedCurveDirection");
				case OperationStatus.UnsupportedChamfer:
					return System.Enum.Parse(tsType, "UnsupportedChamfer");
				case OperationStatus.InvalidRadius:
					return System.Enum.Parse(tsType, "InvalidRadius");
				case OperationStatus.InvalidFacePoints:
					return System.Enum.Parse(tsType, "InvalidFacePoints");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static OperationStatus FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Success", System.StringComparison.InvariantCulture))
				return OperationStatus.Success;
			else if (tsEnumValue.Equals("Failure", System.StringComparison.InvariantCulture))
				return OperationStatus.Failure;
			else if (tsEnumValue.Equals("FacePerpendicularToIntersectionLine", System.StringComparison.InvariantCulture))
				return OperationStatus.FacePerpendicularToIntersectionLine;
			else if (tsEnumValue.Equals("PlateIntersectsWithIntersectionLine", System.StringComparison.InvariantCulture))
				return OperationStatus.PlateIntersectsWithIntersectionLine;
			else if (tsEnumValue.Equals("ExtensionIntersectsWithPlate", System.StringComparison.InvariantCulture))
				return OperationStatus.ExtensionIntersectsWithPlate;
			else if (tsEnumValue.Equals("FacesTooNearEachOther", System.StringComparison.InvariantCulture))
				return OperationStatus.FacesTooNearEachOther;
			else if (tsEnumValue.Equals("FacesAtAnObtuseAngle", System.StringComparison.InvariantCulture))
				return OperationStatus.FacesAtAnObtuseAngle;
			else if (tsEnumValue.Equals("UndefinedCurveDirection", System.StringComparison.InvariantCulture))
				return OperationStatus.UndefinedCurveDirection;
			else if (tsEnumValue.Equals("UnsupportedChamfer", System.StringComparison.InvariantCulture))
				return OperationStatus.UnsupportedChamfer;
			else if (tsEnumValue.Equals("InvalidRadius", System.StringComparison.InvariantCulture))
				return OperationStatus.InvalidRadius;
			else if (tsEnumValue.Equals("InvalidFacePoints", System.StringComparison.InvariantCulture))
				return OperationStatus.InvalidFacePoints;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BentPlateGeometrySolver_
    {
        public static dynamic GetTSObject(BentPlateGeometrySolver dynObject)
        {
            return dynObject.bentplategeometrysolver;
        }

        public static BentPlateGeometrySolver FromTSObject(dynamic tsObject)
        {
            return new BentPlateGeometrySolver(tsObject);
        }
    }


}
    