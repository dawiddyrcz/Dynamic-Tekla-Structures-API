/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.Operations
{

    public abstract class Operation 
    {

        

        internal dynamic teklaObject;



public static System.Boolean IsNumberingUpToDate(
	Dynamic.Tekla.Structures.Model.ModelObject InputModelObject_
	)
{
	var InputModelObject = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(InputModelObject_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsNumberingUpToDate", InputModelObject);
	return result;
}



public static System.Boolean IsNumberingUpToDateAll()
{
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsNumberingUpToDateAll");
	return result;
}



public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> GetSimilarNumberedObjects(
	Dynamic.Tekla.Structures.Model.ModelObject ObjectToCompare_
	)
{
	var ObjectToCompare = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ObjectToCompare_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "GetSimilarNumberedObjects", ObjectToCompare);
	var _result = ListConverter.FromTSObjects(result);
	return _result;
}



public static System.Boolean CreateReportFromSelected(
	System.String TemplateName,
	System.String FileName,
	System.String Title1,
	System.String Title2,
	System.String Title3
	)
{
	
	
	
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateReportFromSelected", TemplateName, FileName, Title1, Title2, Title3);
	return result;
}



public static System.Boolean DisplayReport(
	System.String FileName
	)
{
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "DisplayReport", FileName);
	return result;
}



public static System.Boolean CreateReportFromAll(
	System.String TemplateName,
	System.String FileName,
	System.String Title1,
	System.String Title2,
	System.String Title3
	)
{
	
	
	
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateReportFromAll", TemplateName, FileName, Title1, Title2, Title3);
	return result;
}



public static System.Boolean CreateNCFilesFromSelected(
	System.String NCFileSettings,
	System.String DestinationFolder
	)
{
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromSelected", NCFileSettings, DestinationFolder);
	return result;
}



public static System.Boolean CreateNCFilesFromSelected(
	System.String NCFileSettings,
	System.String DestinationFolder,
	System.Boolean CreatePopMarks,
	System.String PopMarkSettingsFileName,
	System.Boolean CreateContourMarking,
	System.String ContourMarkingSettingsFileName
	)
{
	
	
	
	
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromSelected", NCFileSettings, DestinationFolder, CreatePopMarks, PopMarkSettingsFileName, CreateContourMarking, ContourMarkingSettingsFileName);
	return result;
}



public static System.Boolean CreateNCFilesFromAll(
	System.String NCFileSettings,
	System.String DestinationFolder
	)
{
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromAll", NCFileSettings, DestinationFolder);
	return result;
}



public static System.Boolean CreateNCFilesFromAll(
	System.String NCFileSettings,
	System.String DestinationFolder,
	System.Boolean CreatePopMarks,
	System.String PopMarkSettingsFileName,
	System.Boolean CreateContourMarking,
	System.String ContourMarkingSettingsFileName
	)
{
	
	
	
	
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromAll", NCFileSettings, DestinationFolder, CreatePopMarks, PopMarkSettingsFileName, CreateContourMarking, ContourMarkingSettingsFileName);
	return result;
}



public static System.Boolean CreateNCFilesByPartId(
	System.String NCFileSettings,
	System.String DestinationFolder,
	Dynamic.Tekla.Structures.Identifier PartID_,
	ref System.String DstvOutput,
	System.Boolean CreatePopMarks,
	System.String PopMarkSettingsFileName,
	System.Boolean CreateContourMarking,
	System.String ContourMarkingSettingsFileName
	)
{
	
	
	var PartID = Dynamic.Tekla.Structures.Identifier_.GetTSObject(PartID_);
	
	
	
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesByPartId", NCFileSettings, DestinationFolder, PartID, ref DstvOutput, CreatePopMarks, PopMarkSettingsFileName, CreateContourMarking, ContourMarkingSettingsFileName);
	
	return result;
}



public static System.Boolean CreateMISFileFromSelected(
	Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum MISType_,
	System.String FileName
	)
{
	var MISType = Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum_.GetTSObject(MISType_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateMISFileFromSelected", MISType, FileName);
	return result;
}



public static System.Boolean CreateMISFileFromAll(
	Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum MISType_,
	System.String FileName
	)
{
	var MISType = Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum_.GetTSObject(MISType_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateMISFileFromAll", MISType, FileName);
	return result;
}



public static System.Boolean RunMacro(
	System.String FileName
	)
{
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "RunMacro", FileName);
	return result;
}



public static System.Boolean IsMacroRunning()
{
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsMacroRunning");
	return result;
}



public static System.Boolean Open(
	System.String ModelFolder
	)
{
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Open", ModelFolder);
	return result;
}



public static System.Boolean Open(
	System.String ModelFolder,
	System.Boolean OpenAutoSaved
	)
{
	
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Open", ModelFolder, OpenAutoSaved);
	return result;
}



public static System.Boolean IsModelAutoSaved(
	System.String ModelFolder
	)
{
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsModelAutoSaved", ModelFolder);
	return result;
}



public static System.Boolean SaveAsWebModel(
	System.String Filename
	)
{
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "SaveAsWebModel", Filename);
	return result;
}



public static System.Boolean SaveSelectedAsWebModel(
	System.String Filename
	)
{
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "SaveSelectedAsWebModel", Filename);
	return result;
}



public static System.Boolean MoveObject(
	Dynamic.Tekla.Structures.Model.ModelObject Object_,
	Dynamic.Tekla.Structures.Geometry3d.Vector TranslationVector_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object_);
	var TranslationVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(TranslationVector_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "MoveObject", Object, TranslationVector);
	return result;
}



public static System.Boolean MoveObject(
	Dynamic.Tekla.Structures.Model.ModelObject Object_,
	Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem StartCoordinateSystem_,
	Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem EndCoordinateSystem_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object_);
	var StartCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(StartCoordinateSystem_);
	var EndCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(EndCoordinateSystem_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "MoveObject", Object, StartCoordinateSystem, EndCoordinateSystem);
	return result;
}



public static Dynamic.Tekla.Structures.Model.ModelObject CopyObject(
	Dynamic.Tekla.Structures.Model.ModelObject Object_,
	Dynamic.Tekla.Structures.Geometry3d.Vector CopyVector_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object_);
	var CopyVector = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(CopyVector_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CopyObject", Object, CopyVector);
	var _result = Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.ModelObject CopyObject(
	Dynamic.Tekla.Structures.Model.ModelObject Object_,
	Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem StartCoordinateSystem_,
	Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem EndCoordinateSystem_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object_);
	var StartCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(StartCoordinateSystem_);
	var EndCoordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(EndCoordinateSystem_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CopyObject", Object, StartCoordinateSystem, EndCoordinateSystem);
	var _result = Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.Beam Combine(
	Dynamic.Tekla.Structures.Model.Beam ObjectToCombineTo_,
	Dynamic.Tekla.Structures.Model.Beam ObjectToBeCombined_
	)
{
	var ObjectToCombineTo = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(ObjectToCombineTo_);
	var ObjectToBeCombined = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(ObjectToBeCombined_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Combine", ObjectToCombineTo, ObjectToBeCombined);
	var _result = Dynamic.Tekla.Structures.Model.Beam_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.SingleRebar Combine(
	Dynamic.Tekla.Structures.Model.SingleRebar ObjectToCombineTo_,
	Dynamic.Tekla.Structures.Model.SingleRebar ObjectToBeCombined_
	)
{
	var ObjectToCombineTo = Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(ObjectToCombineTo_);
	var ObjectToBeCombined = Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(ObjectToBeCombined_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Combine", ObjectToCombineTo, ObjectToBeCombined);
	var _result = Dynamic.Tekla.Structures.Model.SingleRebar_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.RebarGroup Combine(
	Dynamic.Tekla.Structures.Model.RebarGroup ObjectToCombineTo_,
	Dynamic.Tekla.Structures.Model.RebarGroup ObjectToBeCombined_
	)
{
	var ObjectToCombineTo = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(ObjectToCombineTo_);
	var ObjectToBeCombined = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(ObjectToBeCombined_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Combine", ObjectToCombineTo, ObjectToBeCombined);
	var _result = Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.Beam Split(
	Dynamic.Tekla.Structures.Model.Beam Object_,
	Dynamic.Tekla.Structures.Geometry3d.Point SplitPoint_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(Object_);
	var SplitPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(SplitPoint_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitPoint);
	var _result = Dynamic.Tekla.Structures.Model.Beam_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.SingleRebar Split(
	Dynamic.Tekla.Structures.Model.SingleRebar Object_,
	Dynamic.Tekla.Structures.Geometry3d.Line SplitLine_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(Object_);
	var SplitLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitLine);
	var _result = Dynamic.Tekla.Structures.Model.SingleRebar_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.CurvedRebarGroup Split(
	Dynamic.Tekla.Structures.Model.CurvedRebarGroup Object_,
	Dynamic.Tekla.Structures.Geometry3d.Line SplitLine_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.CurvedRebarGroup_.GetTSObject(Object_);
	var SplitLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitLine);
	var _result = Dynamic.Tekla.Structures.Model.CurvedRebarGroup_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.CircleRebarGroup Split(
	Dynamic.Tekla.Structures.Model.CircleRebarGroup Object_,
	Dynamic.Tekla.Structures.Geometry3d.Line SplitLine_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.CircleRebarGroup_.GetTSObject(Object_);
	var SplitLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitLine);
	var _result = Dynamic.Tekla.Structures.Model.CircleRebarGroup_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.RebarGroup Split(
	Dynamic.Tekla.Structures.Model.RebarGroup Object_,
	Dynamic.Tekla.Structures.Geometry3d.Line SplitLine_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(Object_);
	var SplitLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitLine);
	var _result = Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.ContourPlate Split(
	Dynamic.Tekla.Structures.Model.ContourPlate Object_,
	Dynamic.Tekla.Structures.Model.Polygon SplitPolygon_
	)
{
	var Object = Dynamic.Tekla.Structures.Model.ContourPlate_.GetTSObject(Object_);
	var SplitPolygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(SplitPolygon_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", Object, SplitPolygon);
	var _result = Dynamic.Tekla.Structures.Model.ContourPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Ungrouping(
	Dynamic.Tekla.Structures.Model.RebarGroup Reinforcement_
	)
{
	var Reinforcement = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(Reinforcement_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Ungrouping", Reinforcement);
	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Ungrouping(
	Dynamic.Tekla.Structures.Model.RebarMesh Reinforcement_
	)
{
	var Reinforcement = Dynamic.Tekla.Structures.Model.RebarMesh_.GetTSObject(Reinforcement_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Ungrouping", Reinforcement);
	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.RebarGroup Group(
	System.Collections.IEnumerable RebarList
	)
{
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Group", RebarList);
	var _result = Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(result);
	return _result;
}



public static void ShowOnlySelected(
	Dynamic.Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum UnselectedMode_
	)
{
	var UnselectedMode = Dynamic.Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum_.GetTSObject(UnselectedMode_);
	MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ShowOnlySelected", UnselectedMode);

}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(
	Dynamic.Tekla.Structures.Model.Part part1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape_
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var bendShape = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByParts", part1, part2, bendShape);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(
	Dynamic.Tekla.Structures.Model.Part part1_,
	Dynamic.Tekla.Structures.Model.Part part2_
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByParts", part1, part2);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(
	Dynamic.Tekla.Structures.Model.Part part1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	System.Double radius
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByParts", part1, part2, radius);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByPartsAndAperture(
	Dynamic.Tekla.Structures.Model.Part part1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	System.Double largestRadius,
	System.Double halfAperture
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByPartsAndAperture", part1, part2, largestRadius, halfAperture);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByPartsAndTwoRadiuses(
	Dynamic.Tekla.Structures.Model.Part part1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	System.Double firstRadius,
	System.Double secondRadius
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByPartsAndTwoRadiuses", part1, part2, firstRadius, secondRadius);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
	Dynamic.Tekla.Structures.Model.Part part1_,
	System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2_,
	Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape_
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var face1 = ListConverter.ToTSObjects(face1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var face2 = ListConverter.ToTSObjects(face2_);
	var bendShape = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2, bendShape);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
	Dynamic.Tekla.Structures.Model.Part part1_,
	System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2_
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var face1 = ListConverter.ToTSObjects(face1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var face2 = ListConverter.ToTSObjects(face2_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
	Dynamic.Tekla.Structures.Model.Part part1_,
	Dynamic.Tekla.Structures.Solid.Face face1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	Dynamic.Tekla.Structures.Solid.Face face2_,
	Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape_
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var face1 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var face2 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2_);
	var bendShape = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2, bendShape);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
	Dynamic.Tekla.Structures.Model.Part part1_,
	Dynamic.Tekla.Structures.Solid.Face face1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	Dynamic.Tekla.Structures.Solid.Face face2_
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var face1 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var face2 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
	Dynamic.Tekla.Structures.Model.Part part1_,
	System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2_,
	System.Double radius
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var face1 = ListConverter.ToTSObjects(face1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var face2 = ListConverter.ToTSObjects(face2_);
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2, radius);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(
	Dynamic.Tekla.Structures.Model.Part part1_,
	Dynamic.Tekla.Structures.Solid.Face face1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	Dynamic.Tekla.Structures.Solid.Face face2_,
	System.Double radius
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var face1 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var face2 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2_);
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", part1, face1, part2, face2, radius);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByFaces(
	Dynamic.Tekla.Structures.Model.Part part1_,
	System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2_,
	System.Double largestRadius,
	System.Double halfAperture
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var face1 = ListConverter.ToTSObjects(face1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var face2 = ListConverter.ToTSObjects(face2_);
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByFaces", part1, face1, part2, face2, largestRadius, halfAperture);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByFaces(
	Dynamic.Tekla.Structures.Model.Part part1_,
	Dynamic.Tekla.Structures.Solid.Face face1_,
	Dynamic.Tekla.Structures.Model.Part part2_,
	Dynamic.Tekla.Structures.Solid.Face face2_,
	System.Double largestRadius,
	System.Double halfAperture
	)
{
	var part1 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1_);
	var face1 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1_);
	var part2 = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2_);
	var face2 = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2_);
	
	
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByFaces", part1, face1, part2, face2, largestRadius, halfAperture);
	var _result = Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
	return _result;
}



public static System.Boolean ExplodeBentPlate(
	Dynamic.Tekla.Structures.Model.BentPlate bentPlate_
	)
{
	var bentPlate = Dynamic.Tekla.Structures.Model.BentPlate_.GetTSObject(bentPlate_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ExplodeBentPlate", bentPlate);
	return result;
}



public static System.Boolean AddToPourUnit(
	Dynamic.Tekla.Structures.Model.PourUnit inputPourUnit_,
	System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> objectsToBeAdded_
	)
{
	var inputPourUnit = Dynamic.Tekla.Structures.Model.PourUnit_.GetTSObject(inputPourUnit_);
	var objectsToBeAdded = ListConverter.ToTSObjects(objectsToBeAdded_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "AddToPourUnit", inputPourUnit, objectsToBeAdded);
	return result;
}



public static System.Boolean RemoveFromPourUnit(
	System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> objectsToBeRemoved_
	)
{
	var objectsToBeRemoved = ListConverter.ToTSObjects(objectsToBeRemoved_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "RemoveFromPourUnit", objectsToBeRemoved);
	return result;
}



public static System.Boolean CalculatePourUnits()
{
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CalculatePourUnits");
	return result;
}



public static System.Boolean DisplayPrompt(
	System.String Message
	)
{
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "DisplayPrompt", Message);
	return result;
}



public static System.Boolean ObjectMatchesToFilter(
	Dynamic.Tekla.Structures.Model.ModelObject ModelObject_,
	System.String FilterName
	)
{
	var ModelObject = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ModelObject_);
	
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ObjectMatchesToFilter", ModelObject, FilterName);
	return result;
}



public static System.Boolean ObjectMatchesToFilter(
	Dynamic.Tekla.Structures.Model.ModelObject ModelObject_,
	Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression_
	)
{
	var ModelObject = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ModelObject_);
	var FilterExpression = Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(FilterExpression_);
	var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ObjectMatchesToFilter", ModelObject, FilterExpression);
	return result;
}





    public enum MISExportTypeEnum
    {
			DSTV,
			KISS,
			EJE,
			EPC,
			STEEL2000        
    }

    internal static class MISExportTypeEnum_
    {
        public static dynamic GetTSObject(MISExportTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum").GetType();

            switch (dynEnum)
            {
				case MISExportTypeEnum.DSTV:
					return System.Enum.Parse(tsType, "DSTV");
				case MISExportTypeEnum.KISS:
					return System.Enum.Parse(tsType, "KISS");
				case MISExportTypeEnum.EJE:
					return System.Enum.Parse(tsType, "EJE");
				case MISExportTypeEnum.EPC:
					return System.Enum.Parse(tsType, "EPC");
				case MISExportTypeEnum.STEEL2000:
					return System.Enum.Parse(tsType, "STEEL2000");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static MISExportTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("DSTV", System.StringComparison.InvariantCulture))
				return MISExportTypeEnum.DSTV;
			else if (tsEnumValue.Equals("KISS", System.StringComparison.InvariantCulture))
				return MISExportTypeEnum.KISS;
			else if (tsEnumValue.Equals("EJE", System.StringComparison.InvariantCulture))
				return MISExportTypeEnum.EJE;
			else if (tsEnumValue.Equals("EPC", System.StringComparison.InvariantCulture))
				return MISExportTypeEnum.EPC;
			else if (tsEnumValue.Equals("STEEL2000", System.StringComparison.InvariantCulture))
				return MISExportTypeEnum.STEEL2000;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum UnselectedModeEnum
    {
			Hidden,
			Transparent,
			AsSticks        
    }

    internal static class UnselectedModeEnum_
    {
        public static dynamic GetTSObject(UnselectedModeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum").GetType();

            switch (dynEnum)
            {
				case UnselectedModeEnum.Hidden:
					return System.Enum.Parse(tsType, "Hidden");
				case UnselectedModeEnum.Transparent:
					return System.Enum.Parse(tsType, "Transparent");
				case UnselectedModeEnum.AsSticks:
					return System.Enum.Parse(tsType, "AsSticks");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static UnselectedModeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Hidden", System.StringComparison.InvariantCulture))
				return UnselectedModeEnum.Hidden;
			else if (tsEnumValue.Equals("Transparent", System.StringComparison.InvariantCulture))
				return UnselectedModeEnum.Transparent;
			else if (tsEnumValue.Equals("AsSticks", System.StringComparison.InvariantCulture))
				return UnselectedModeEnum.AsSticks;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public  class ProgressBar 
    {

        

        internal dynamic teklaObject;

		public ProgressBar()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Operations.Operation.ProgressBar");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ProgressBar(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public System.Boolean Display(
	System.Int32 SleepTime,
	System.String Title,
	System.String Message,
	System.String CancelButtonLabel,
	System.String ProgressLabel
	)
{
	
	
	
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.Display(SleepTime, Title, Message, CancelButtonLabel, ProgressLabel);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Display), ex);
    }
}



public void Close()
{

    try
    {
        	teklaObject.Close();

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Close), ex);
    }
}



public void SetProgress(
	System.String ProgressLabel,
	System.Int32 Progress
	)
{
	
	
    try
    {
        	teklaObject.SetProgress(ProgressLabel, Progress);

        
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetProgress), ex);
    }
}



public System.Boolean Canceled()
{

    try
    {
        	var result = (System.Boolean) teklaObject.Canceled();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Canceled), ex);
    }
}






    }

    internal static class ProgressBar_
    {
        public static dynamic GetTSObject(ProgressBar dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ProgressBar FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Operations.Operation.ProgressBar)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ProgressBarArray_
    {
        public static dynamic GetTSObject(ProgressBar[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ProgressBar_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ProgressBar[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ProgressBar>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ProgressBar_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Operation_
    {
        public static dynamic GetTSObject(Operation dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Operation FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Operations.Operation)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class OperationArray_
    {
        public static dynamic GetTSObject(Operation[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Operation_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Operation[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Operation>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Operation_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
