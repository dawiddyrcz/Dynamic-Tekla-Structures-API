/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class BentPlateGeometrySolver 
    {

        

        internal dynamic teklaObject;

		public BentPlateGeometrySolver()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlateGeometrySolver");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public BentPlateGeometrySolver(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.Contour polygon_,
	Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape_
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var polygon = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon_);
	var bendShape = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape_);
    try
    {
        	var result = teklaObject.AddLeg(geometry, polygon, bendShape);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.Contour polygon_
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var polygon = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon_);
    try
    {
        	var result = teklaObject.AddLeg(geometry, polygon);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.Contour polygon_,
	System.Double radius
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var polygon = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon_);
	
    try
    {
        	var result = teklaObject.AddLeg(geometry, polygon, radius);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.Contour polygon_,
	System.Double largestRadius,
	System.Double halfAperture
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var polygon = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon_);
	
	
    try
    {
        	var result = teklaObject.AddLeg(geometry, polygon, largestRadius, halfAperture);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1_,
	Dynamic.Tekla.Structures.Model.Contour polygon_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2_,
	Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape_
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var segment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1_);
	var polygon = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon_);
	var segment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2_);
	var bendShape = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape_);
    try
    {
        	var result = teklaObject.AddLeg(geometry, segment1, polygon, segment2, bendShape);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1_,
	Dynamic.Tekla.Structures.Model.Contour polygon_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2_
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var segment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1_);
	var polygon = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon_);
	var segment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2_);
    try
    {
        	var result = teklaObject.AddLeg(geometry, segment1, polygon, segment2);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1_,
	Dynamic.Tekla.Structures.Model.Contour polygon_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2_,
	System.Double radius
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var segment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1_);
	var polygon = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon_);
	var segment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2_);
	
    try
    {
        	var result = teklaObject.AddLeg(geometry, segment1, polygon, segment2, radius);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry AddLeg(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment segment1_,
	Dynamic.Tekla.Structures.Model.Contour polygon_,
	Dynamic.Tekla.Structures.Geometry3d.LineSegment segment2_,
	System.Double largestRadius,
	System.Double halfAperture
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var segment1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment1_);
	var polygon = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(polygon_);
	var segment2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment2_);
	
	
    try
    {
        	var result = teklaObject.AddLeg(geometry, segment1, polygon, segment2, largestRadius, halfAperture);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLeg), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry RemoveLeg(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.GeometrySection legSection_
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var legSection = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(legSection_);
    try
    {
        	var result = teklaObject.RemoveLeg(geometry, legSection);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveLeg), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyBendSurface(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.GeometrySection bendSection_,
	Dynamic.Tekla.Structures.Model.BendSurface surface_
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var bendSection = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(bendSection_);
	var surface = Dynamic.Tekla.Structures.Model.BendSurface_.GetTSObject(surface_);
    try
    {
        	var result = teklaObject.ModifyBendSurface(geometry, bendSection, surface);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyBendSurface), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyCylindricalSurface(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.GeometrySection cylindricalSection_,
	Dynamic.Tekla.Structures.Model.CylindricalSurface surface_
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var cylindricalSection = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(cylindricalSection_);
	var surface = Dynamic.Tekla.Structures.Model.CylindricalSurface_.GetTSObject(surface_);
    try
    {
        	var result = teklaObject.ModifyCylindricalSurface(geometry, cylindricalSection, surface);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyCylindricalSurface), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyRadius(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.GeometrySection cylindricalSection_,
	System.Double radius
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var cylindricalSection = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(cylindricalSection_);
	
    try
    {
        	var result = teklaObject.ModifyRadius(geometry, cylindricalSection, radius);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyRadius), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyConicalRadiuses(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.GeometrySection conicalSection_,
	System.Double radius1,
	System.Double radius2
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var conicalSection = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(conicalSection_);
	
	
    try
    {
        	var result = teklaObject.ModifyConicalRadiuses(geometry, conicalSection, radius1, radius2);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyConicalRadiuses), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ScaleConeSection(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.GeometrySection conicalSection_,
	System.Double scale
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var conicalSection = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(conicalSection_);
	
    try
    {
        	var result = teklaObject.ScaleConeSection(geometry, conicalSection, scale);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ScaleConeSection), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry ModifyPolygon(
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_,
	Dynamic.Tekla.Structures.Model.GeometrySection polygonSection_,
	Dynamic.Tekla.Structures.Model.Contour points_
	)
{
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
	var polygonSection = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(polygonSection_);
	var points = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(points_);
    try
    {
        	var result = teklaObject.ModifyPolygon(geometry, polygonSection, points);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ModifyPolygon), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry SetMainSection(
	Dynamic.Tekla.Structures.Model.GeometrySection newMainSection_,
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_
	)
{
	var newMainSection = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(newMainSection_);
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
    try
    {
        	var result = teklaObject.SetMainSection(newMainSection, geometry);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetMainSection), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ConnectiveGeometry SetBendAngle(
	System.Double angle,
	Dynamic.Tekla.Structures.Model.GeometrySection sectionToSetAngle_,
	Dynamic.Tekla.Structures.Model.GeometrySection sectionToMove_,
	Dynamic.Tekla.Structures.Model.ConnectiveGeometry geometry_
	)
{
	
	var sectionToSetAngle = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(sectionToSetAngle_);
	var sectionToMove = Dynamic.Tekla.Structures.Model.GeometrySection_.GetTSObject(sectionToMove_);
	var geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(geometry_);
    try
    {
        	var result = teklaObject.SetBendAngle(angle, sectionToSetAngle, sectionToMove, geometry);

        	var _result = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetBendAngle), ex);
    }
}





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
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlateGeometrySolver.OperationStatus").GetType();

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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BentPlateGeometrySolver_
    {
        public static dynamic GetTSObject(BentPlateGeometrySolver dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static BentPlateGeometrySolver FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.BentPlateGeometrySolver)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BentPlateGeometrySolverArray_
    {
        public static dynamic GetTSObject(BentPlateGeometrySolver[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(BentPlateGeometrySolver_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static BentPlateGeometrySolver[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<BentPlateGeometrySolver>();
            foreach(var tsItem in tsArray)
            {
                list.Add(BentPlateGeometrySolver_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
