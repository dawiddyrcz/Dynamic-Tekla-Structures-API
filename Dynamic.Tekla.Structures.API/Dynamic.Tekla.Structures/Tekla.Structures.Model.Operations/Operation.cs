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


		public static System.Boolean IsNumberingUpToDate(Dynamic.Tekla.Structures.Model.ModelObject InputModelObject)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(InputModelObject);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsNumberingUpToDate", parameters);
			return result;
		}

		public static System.Boolean IsNumberingUpToDateAll()
		{
			var parameters = new object[0];
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsNumberingUpToDateAll", parameters);
			return result;
		}

		public static System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> GetSimilarNumberedObjects(Dynamic.Tekla.Structures.Model.ModelObject ObjectToCompare)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ObjectToCompare);
			var result = (System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject>) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "GetSimilarNumberedObjects", parameters);
			return result;
		}

		public static System.Boolean CreateReportFromSelected(System.String TemplateName, System.String FileName, System.String Title1, System.String Title2, System.String Title3)
		{
			var parameters = new object[5];
			parameters[0] = TemplateName;
			parameters[1] = FileName;
			parameters[2] = Title1;
			parameters[3] = Title2;
			parameters[4] = Title3;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateReportFromSelected", parameters);
			return result;
		}

		public static System.Boolean DisplayReport(System.String FileName)
		{
			var parameters = new object[1];
			parameters[0] = FileName;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "DisplayReport", parameters);
			return result;
		}

		public static System.Boolean CreateReportFromAll(System.String TemplateName, System.String FileName, System.String Title1, System.String Title2, System.String Title3)
		{
			var parameters = new object[5];
			parameters[0] = TemplateName;
			parameters[1] = FileName;
			parameters[2] = Title1;
			parameters[3] = Title2;
			parameters[4] = Title3;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateReportFromAll", parameters);
			return result;
		}

		public static System.Boolean CreateNCFilesFromSelected(System.String NCFileSettings, System.String DestinationFolder)
		{
			var parameters = new object[2];
			parameters[0] = NCFileSettings;
			parameters[1] = DestinationFolder;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromSelected", parameters);
			return result;
		}

		public static System.Boolean CreateNCFilesFromSelected(System.String NCFileSettings, System.String DestinationFolder, System.Boolean CreatePopMarks, System.String PopMarkSettingsFileName, System.Boolean CreateContourMarking, System.String ContourMarkingSettingsFileName)
		{
			var parameters = new object[6];
			parameters[0] = NCFileSettings;
			parameters[1] = DestinationFolder;
			parameters[2] = CreatePopMarks;
			parameters[3] = PopMarkSettingsFileName;
			parameters[4] = CreateContourMarking;
			parameters[5] = ContourMarkingSettingsFileName;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromSelected", parameters);
			return result;
		}

		public static System.Boolean CreateNCFilesFromAll(System.String NCFileSettings, System.String DestinationFolder)
		{
			var parameters = new object[2];
			parameters[0] = NCFileSettings;
			parameters[1] = DestinationFolder;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromAll", parameters);
			return result;
		}

		public static System.Boolean CreateNCFilesFromAll(System.String NCFileSettings, System.String DestinationFolder, System.Boolean CreatePopMarks, System.String PopMarkSettingsFileName, System.Boolean CreateContourMarking, System.String ContourMarkingSettingsFileName)
		{
			var parameters = new object[6];
			parameters[0] = NCFileSettings;
			parameters[1] = DestinationFolder;
			parameters[2] = CreatePopMarks;
			parameters[3] = PopMarkSettingsFileName;
			parameters[4] = CreateContourMarking;
			parameters[5] = ContourMarkingSettingsFileName;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesFromAll", parameters);
			return result;
		}

		public static System.Boolean CreateNCFilesByPartId(System.String NCFileSettings, System.String DestinationFolder, Dynamic.Tekla.Structures.Identifier PartID, out System.String DstvOutput, System.Boolean CreatePopMarks, System.String PopMarkSettingsFileName, System.Boolean CreateContourMarking, System.String ContourMarkingSettingsFileName)
		{
			var parameters = new object[8];
			parameters[0] = NCFileSettings;
			parameters[1] = DestinationFolder;
			parameters[2] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(PartID);
			DstvOutput = string.Empty;
			parameters[3] = DstvOutput;
			parameters[4] = CreatePopMarks;
			parameters[5] = PopMarkSettingsFileName;
			parameters[6] = CreateContourMarking;
			parameters[7] = ContourMarkingSettingsFileName;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateNCFilesByPartId", parameters);
			DstvOutput = (System.String) parameters[3];
			return result;
		}

		public static System.Boolean CreateMISFileFromSelected(Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum MISType, System.String FileName)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum_.GetTSObject(MISType);
			parameters[1] = FileName;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateMISFileFromSelected", parameters);
			return result;
		}

		public static System.Boolean CreateMISFileFromAll(Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum MISType, System.String FileName)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum_.GetTSObject(MISType);
			parameters[1] = FileName;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateMISFileFromAll", parameters);
			return result;
		}

		public static System.Boolean RunMacro(System.String FileName)
		{
			var parameters = new object[1];
			parameters[0] = FileName;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "RunMacro", parameters);
			return result;
		}

		public static System.Boolean IsMacroRunning()
		{
			var parameters = new object[0];
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsMacroRunning", parameters);
			return result;
		}

		public static System.Boolean Open(System.String ModelFolder)
		{
			var parameters = new object[1];
			parameters[0] = ModelFolder;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Open", parameters);
			return result;
		}

		public static System.Boolean Open(System.String ModelFolder, System.Boolean OpenAutoSaved)
		{
			var parameters = new object[2];
			parameters[0] = ModelFolder;
			parameters[1] = OpenAutoSaved;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Open", parameters);
			return result;
		}

		public static System.Boolean IsModelAutoSaved(System.String ModelFolder)
		{
			var parameters = new object[1];
			parameters[0] = ModelFolder;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "IsModelAutoSaved", parameters);
			return result;
		}

		public static System.Boolean SaveAsWebModel(System.String Filename)
		{
			var parameters = new object[1];
			parameters[0] = Filename;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "SaveAsWebModel", parameters);
			return result;
		}

		public static System.Boolean SaveSelectedAsWebModel(System.String Filename)
		{
			var parameters = new object[1];
			parameters[0] = Filename;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "SaveSelectedAsWebModel", parameters);
			return result;
		}

		public static System.Boolean MoveObject(Dynamic.Tekla.Structures.Model.ModelObject Object, Dynamic.Tekla.Structures.Geometry3d.Vector TranslationVector)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(TranslationVector);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "MoveObject", parameters);
			return result;
		}

		public static System.Boolean MoveObject(Dynamic.Tekla.Structures.Model.ModelObject Object, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem StartCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem EndCoordinateSystem)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(StartCoordinateSystem);
			parameters[2] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(EndCoordinateSystem);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "MoveObject", parameters);
			return result;
		}

		public static Dynamic.Tekla.Structures.Model.ModelObject CopyObject(Dynamic.Tekla.Structures.Model.ModelObject Object, Dynamic.Tekla.Structures.Geometry3d.Vector CopyVector)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(CopyVector);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CopyObject", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.ModelObject CopyObject(Dynamic.Tekla.Structures.Model.ModelObject Object, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem StartCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem EndCoordinateSystem)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(StartCoordinateSystem);
			parameters[2] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(EndCoordinateSystem);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CopyObject", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.Beam Combine(Dynamic.Tekla.Structures.Model.Beam ObjectToCombineTo, Dynamic.Tekla.Structures.Model.Beam ObjectToBeCombined)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(ObjectToCombineTo);
			parameters[1] = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(ObjectToBeCombined);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Combine", parameters);
			return Dynamic.Tekla.Structures.Model.Beam_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.SingleRebar Combine(Dynamic.Tekla.Structures.Model.SingleRebar ObjectToCombineTo, Dynamic.Tekla.Structures.Model.SingleRebar ObjectToBeCombined)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(ObjectToCombineTo);
			parameters[1] = Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(ObjectToBeCombined);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Combine", parameters);
			return Dynamic.Tekla.Structures.Model.SingleRebar_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.RebarGroup Combine(Dynamic.Tekla.Structures.Model.RebarGroup ObjectToCombineTo, Dynamic.Tekla.Structures.Model.RebarGroup ObjectToBeCombined)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(ObjectToCombineTo);
			parameters[1] = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(ObjectToBeCombined);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Combine", parameters);
			return Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.Beam Split(Dynamic.Tekla.Structures.Model.Beam Object, Dynamic.Tekla.Structures.Geometry3d.Point SplitPoint)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(SplitPoint);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", parameters);
			return Dynamic.Tekla.Structures.Model.Beam_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.SingleRebar Split(Dynamic.Tekla.Structures.Model.SingleRebar Object, Dynamic.Tekla.Structures.Geometry3d.Line SplitLine)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", parameters);
			return Dynamic.Tekla.Structures.Model.SingleRebar_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.CurvedRebarGroup Split(Dynamic.Tekla.Structures.Model.CurvedRebarGroup Object, Dynamic.Tekla.Structures.Geometry3d.Line SplitLine)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.CurvedRebarGroup_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", parameters);
			return Dynamic.Tekla.Structures.Model.CurvedRebarGroup_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.CircleRebarGroup Split(Dynamic.Tekla.Structures.Model.CircleRebarGroup Object, Dynamic.Tekla.Structures.Geometry3d.Line SplitLine)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.CircleRebarGroup_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", parameters);
			return Dynamic.Tekla.Structures.Model.CircleRebarGroup_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.RebarGroup Split(Dynamic.Tekla.Structures.Model.RebarGroup Object, Dynamic.Tekla.Structures.Geometry3d.Line SplitLine)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", parameters);
			return Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.ContourPlate Split(Dynamic.Tekla.Structures.Model.ContourPlate Object, Dynamic.Tekla.Structures.Model.Polygon SplitPolygon)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.ContourPlate_.GetTSObject(Object);
			parameters[1] = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(SplitPolygon);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Split", parameters);
			return Dynamic.Tekla.Structures.Model.ContourPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Ungrouping(Dynamic.Tekla.Structures.Model.RebarGroup Reinforcement)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(Reinforcement);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Ungrouping", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Ungrouping(Dynamic.Tekla.Structures.Model.RebarMesh Reinforcement)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.RebarMesh_.GetTSObject(Reinforcement);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Ungrouping", parameters);
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.RebarGroup Group(System.Collections.IEnumerable RebarList)
		{
			var parameters = new object[1];
			parameters[0] = RebarList;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "Group", parameters);
			return Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(result);
		}

		public static void ShowOnlySelected(Dynamic.Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum UnselectedMode)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum_.GetTSObject(UnselectedMode);
			TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ShowOnlySelected", parameters);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[2] = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByParts", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByParts", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2, System.Double radius)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[2] = radius;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByParts", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByPartsAndAperture(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2, System.Double largestRadius, System.Double halfAperture)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[2] = largestRadius;
			parameters[3] = halfAperture;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByPartsAndAperture", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByPartsAndTwoRadiuses(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2, System.Double firstRadius, System.Double secondRadius)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[2] = firstRadius;
			parameters[3] = secondRadius;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByPartsAndTwoRadiuses", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1, Dynamic.Tekla.Structures.Model.Part part2, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2, Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape)
		{
			var parameters = new object[5];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = face1;
			parameters[2] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[3] = face2;
			parameters[4] = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1, Dynamic.Tekla.Structures.Model.Part part2, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = face1;
			parameters[2] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[3] = face2;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Solid.Face face1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Solid.Face face2, Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape)
		{
			var parameters = new object[5];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1);
			parameters[2] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[3] = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2);
			parameters[4] = Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Solid.Face face1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Solid.Face face2)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1);
			parameters[2] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[3] = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1, Dynamic.Tekla.Structures.Model.Part part2, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2, System.Double radius)
		{
			var parameters = new object[5];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = face1;
			parameters[2] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[3] = face2;
			parameters[4] = radius;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Solid.Face face1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Solid.Face face2, System.Double radius)
		{
			var parameters = new object[5];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1);
			parameters[2] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[3] = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2);
			parameters[4] = radius;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateBentPlateByFaces", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1, Dynamic.Tekla.Structures.Model.Part part2, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2, System.Double largestRadius, System.Double halfAperture)
		{
			var parameters = new object[6];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = face1;
			parameters[2] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[3] = face2;
			parameters[4] = largestRadius;
			parameters[5] = halfAperture;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByFaces", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Solid.Face face1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Solid.Face face2, System.Double largestRadius, System.Double halfAperture)
		{
			var parameters = new object[6];
			parameters[0] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1);
			parameters[1] = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1);
			parameters[2] = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2);
			parameters[3] = Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2);
			parameters[4] = largestRadius;
			parameters[5] = halfAperture;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CreateConicalBentPlateByFaces", parameters);
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(result);
		}

		public static System.Boolean ExplodeBentPlate(Dynamic.Tekla.Structures.Model.BentPlate bentPlate)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.BentPlate_.GetTSObject(bentPlate);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ExplodeBentPlate", parameters);
			return result;
		}

		public static System.Boolean AddToPourUnit(Dynamic.Tekla.Structures.Model.PourUnit inputPourUnit, System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> objectsToBeAdded)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.PourUnit_.GetTSObject(inputPourUnit);
			parameters[1] = objectsToBeAdded;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "AddToPourUnit", parameters);
			return result;
		}

		public static System.Boolean RemoveFromPourUnit(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> objectsToBeRemoved)
		{
			var parameters = new object[1];
			parameters[0] = objectsToBeRemoved;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "RemoveFromPourUnit", parameters);
			return result;
		}

		public static System.Boolean CalculatePourUnits()
		{
			var parameters = new object[0];
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "CalculatePourUnits", parameters);
			return result;
		}

		public static System.Boolean DisplayPrompt(System.String Message)
		{
			var parameters = new object[1];
			parameters[0] = Message;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "DisplayPrompt", parameters);
			return result;
		}

		public static System.Boolean ObjectMatchesToFilter(Dynamic.Tekla.Structures.Model.ModelObject ModelObject, System.String FilterName)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ModelObject);
			parameters[1] = FilterName;
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ObjectMatchesToFilter", parameters);
			return result;
		}

		public static System.Boolean ObjectMatchesToFilter(Dynamic.Tekla.Structures.Model.ModelObject ModelObject, Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ModelObject);
			parameters[1] = Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(FilterExpression);
			var result = (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Operations.Operation", "ObjectMatchesToFilter", parameters);
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
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
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
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

		public System.Boolean Display(System.Int32 SleepTime, System.String Title, System.String Message, System.String CancelButtonLabel, System.String ProgressLabel)
		{
			return teklaObject.Display(SleepTime, Title, Message, CancelButtonLabel, ProgressLabel);
		}

		public void Close()
		{
			teklaObject.Close();
		}

		public void SetProgress(System.String ProgressLabel, System.Int32 Progress)
		{
			teklaObject.SetProgress(ProgressLabel, Progress);
		}

		public System.Boolean Canceled()
		{
			return teklaObject.Canceled();
		}





    }

    internal static class ProgressBar_
    {
        public static dynamic GetTSObject(ProgressBar dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ProgressBar FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ProgressBar_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ProgressBar[] FromTSObject(dynamic[] tsArray)
        {
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
            return dynObject.teklaObject;
        }

        public static Operation FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Operation_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Operation[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Operation>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Operation_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
