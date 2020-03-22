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


		public System.Boolean IsNumberingUpToDate(Dynamic.Tekla.Structures.Model.ModelObject InputModelObject)
		{
			return teklaObject.IsNumberingUpToDate(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(InputModelObject));
		}

		public System.Boolean IsNumberingUpToDateAll()
		{
			return teklaObject.IsNumberingUpToDateAll();
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> GetSimilarNumberedObjects(Dynamic.Tekla.Structures.Model.ModelObject ObjectToCompare)
		{
			return teklaObject.GetSimilarNumberedObjects(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ObjectToCompare));
		}

		public System.Boolean CreateReportFromSelected(System.String TemplateName, System.String FileName, System.String Title1, System.String Title2, System.String Title3)
		{
			return teklaObject.CreateReportFromSelected(TemplateName, FileName, Title1, Title2, Title3);
		}

		public System.Boolean DisplayReport(System.String FileName)
		{
			return teklaObject.DisplayReport(FileName);
		}

		public System.Boolean CreateReportFromAll(System.String TemplateName, System.String FileName, System.String Title1, System.String Title2, System.String Title3)
		{
			return teklaObject.CreateReportFromAll(TemplateName, FileName, Title1, Title2, Title3);
		}

		public System.Boolean CreateNCFilesFromSelected(System.String NCFileSettings, System.String DestinationFolder)
		{
			return teklaObject.CreateNCFilesFromSelected(NCFileSettings, DestinationFolder);
		}

		public System.Boolean CreateNCFilesFromSelected(System.String NCFileSettings, System.String DestinationFolder, System.Boolean CreatePopMarks, System.String PopMarkSettingsFileName, System.Boolean CreateContourMarking, System.String ContourMarkingSettingsFileName)
		{
			return teklaObject.CreateNCFilesFromSelected(NCFileSettings, DestinationFolder, CreatePopMarks, PopMarkSettingsFileName, CreateContourMarking, ContourMarkingSettingsFileName);
		}

		public System.Boolean CreateNCFilesFromAll(System.String NCFileSettings, System.String DestinationFolder)
		{
			return teklaObject.CreateNCFilesFromAll(NCFileSettings, DestinationFolder);
		}

		public System.Boolean CreateNCFilesFromAll(System.String NCFileSettings, System.String DestinationFolder, System.Boolean CreatePopMarks, System.String PopMarkSettingsFileName, System.Boolean CreateContourMarking, System.String ContourMarkingSettingsFileName)
		{
			return teklaObject.CreateNCFilesFromAll(NCFileSettings, DestinationFolder, CreatePopMarks, PopMarkSettingsFileName, CreateContourMarking, ContourMarkingSettingsFileName);
		}

		public System.Boolean CreateNCFilesByPartId(System.String NCFileSettings, System.String DestinationFolder, Dynamic.Tekla.Structures.Identifier PartID, out System.String DstvOutput, System.Boolean CreatePopMarks, System.String PopMarkSettingsFileName, System.Boolean CreateContourMarking, System.String ContourMarkingSettingsFileName)
		{
			return teklaObject.CreateNCFilesByPartId(NCFileSettings, DestinationFolder, Dynamic.Tekla.Structures.Identifier_.GetTSObject(PartID), out DstvOutput, CreatePopMarks, PopMarkSettingsFileName, CreateContourMarking, ContourMarkingSettingsFileName);
		}

		public System.Boolean CreateMISFileFromSelected(Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum MISType, System.String FileName)
		{
			return teklaObject.CreateMISFileFromSelected(Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum_.GetTSObject(MISType), FileName);
		}

		public System.Boolean CreateMISFileFromAll(Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum MISType, System.String FileName)
		{
			return teklaObject.CreateMISFileFromAll(Dynamic.Tekla.Structures.Model.Operations.Operation.MISExportTypeEnum_.GetTSObject(MISType), FileName);
		}

		public System.Boolean RunMacro(System.String FileName)
		{
			return teklaObject.RunMacro(FileName);
		}

		public System.Boolean IsMacroRunning()
		{
			return teklaObject.IsMacroRunning();
		}

		public System.Boolean Open(System.String ModelFolder)
		{
			return teklaObject.Open(ModelFolder);
		}

		public System.Boolean Open(System.String ModelFolder, System.Boolean OpenAutoSaved)
		{
			return teklaObject.Open(ModelFolder, OpenAutoSaved);
		}

		public System.Boolean IsModelAutoSaved(System.String ModelFolder)
		{
			return teklaObject.IsModelAutoSaved(ModelFolder);
		}

		public System.Boolean SaveAsWebModel(System.String Filename)
		{
			return teklaObject.SaveAsWebModel(Filename);
		}

		public System.Boolean SaveSelectedAsWebModel(System.String Filename)
		{
			return teklaObject.SaveSelectedAsWebModel(Filename);
		}

		public System.Boolean MoveObject(Dynamic.Tekla.Structures.Model.ModelObject Object, Dynamic.Tekla.Structures.Geometry3d.Vector TranslationVector)
		{
			return teklaObject.MoveObject(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(TranslationVector));
		}

		public System.Boolean MoveObject(Dynamic.Tekla.Structures.Model.ModelObject Object, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem StartCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem EndCoordinateSystem)
		{
			return teklaObject.MoveObject(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object), Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(StartCoordinateSystem), Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(EndCoordinateSystem));
		}

		public Dynamic.Tekla.Structures.Model.ModelObject CopyObject(Dynamic.Tekla.Structures.Model.ModelObject Object, Dynamic.Tekla.Structures.Geometry3d.Vector CopyVector)
		{
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.CopyObject(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object), Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(CopyVector)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObject CopyObject(Dynamic.Tekla.Structures.Model.ModelObject Object, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem StartCoordinateSystem, Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem EndCoordinateSystem)
		{
			return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.CopyObject(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(Object), Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(StartCoordinateSystem), Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(EndCoordinateSystem)));
		}

		public Dynamic.Tekla.Structures.Model.Beam Combine(Dynamic.Tekla.Structures.Model.Beam ObjectToCombineTo, Dynamic.Tekla.Structures.Model.Beam ObjectToBeCombined)
		{
			return Dynamic.Tekla.Structures.Model.Beam_.FromTSObject(teklaObject.Combine(Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(ObjectToCombineTo), Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(ObjectToBeCombined)));
		}

		public Dynamic.Tekla.Structures.Model.SingleRebar Combine(Dynamic.Tekla.Structures.Model.SingleRebar ObjectToCombineTo, Dynamic.Tekla.Structures.Model.SingleRebar ObjectToBeCombined)
		{
			return Dynamic.Tekla.Structures.Model.SingleRebar_.FromTSObject(teklaObject.Combine(Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(ObjectToCombineTo), Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(ObjectToBeCombined)));
		}

		public Dynamic.Tekla.Structures.Model.RebarGroup Combine(Dynamic.Tekla.Structures.Model.RebarGroup ObjectToCombineTo, Dynamic.Tekla.Structures.Model.RebarGroup ObjectToBeCombined)
		{
			return Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(teklaObject.Combine(Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(ObjectToCombineTo), Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(ObjectToBeCombined)));
		}

		public Dynamic.Tekla.Structures.Model.Beam Split(Dynamic.Tekla.Structures.Model.Beam Object, Dynamic.Tekla.Structures.Geometry3d.Point SplitPoint)
		{
			return Dynamic.Tekla.Structures.Model.Beam_.FromTSObject(teklaObject.Split(Dynamic.Tekla.Structures.Model.Beam_.GetTSObject(Object), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(SplitPoint)));
		}

		public Dynamic.Tekla.Structures.Model.SingleRebar Split(Dynamic.Tekla.Structures.Model.SingleRebar Object, Dynamic.Tekla.Structures.Geometry3d.Line SplitLine)
		{
			return Dynamic.Tekla.Structures.Model.SingleRebar_.FromTSObject(teklaObject.Split(Dynamic.Tekla.Structures.Model.SingleRebar_.GetTSObject(Object), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine)));
		}

		public Dynamic.Tekla.Structures.Model.CurvedRebarGroup Split(Dynamic.Tekla.Structures.Model.CurvedRebarGroup Object, Dynamic.Tekla.Structures.Geometry3d.Line SplitLine)
		{
			return Dynamic.Tekla.Structures.Model.CurvedRebarGroup_.FromTSObject(teklaObject.Split(Dynamic.Tekla.Structures.Model.CurvedRebarGroup_.GetTSObject(Object), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine)));
		}

		public Dynamic.Tekla.Structures.Model.CircleRebarGroup Split(Dynamic.Tekla.Structures.Model.CircleRebarGroup Object, Dynamic.Tekla.Structures.Geometry3d.Line SplitLine)
		{
			return Dynamic.Tekla.Structures.Model.CircleRebarGroup_.FromTSObject(teklaObject.Split(Dynamic.Tekla.Structures.Model.CircleRebarGroup_.GetTSObject(Object), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine)));
		}

		public Dynamic.Tekla.Structures.Model.RebarGroup Split(Dynamic.Tekla.Structures.Model.RebarGroup Object, Dynamic.Tekla.Structures.Geometry3d.Line SplitLine)
		{
			return Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(teklaObject.Split(Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(Object), Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(SplitLine)));
		}

		public Dynamic.Tekla.Structures.Model.ContourPlate Split(Dynamic.Tekla.Structures.Model.ContourPlate Object, Dynamic.Tekla.Structures.Model.Polygon SplitPolygon)
		{
			return Dynamic.Tekla.Structures.Model.ContourPlate_.FromTSObject(teklaObject.Split(Dynamic.Tekla.Structures.Model.ContourPlate_.GetTSObject(Object), Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(SplitPolygon)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Ungrouping(Dynamic.Tekla.Structures.Model.RebarGroup Reinforcement)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.Ungrouping(Dynamic.Tekla.Structures.Model.RebarGroup_.GetTSObject(Reinforcement)));
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator Ungrouping(Dynamic.Tekla.Structures.Model.RebarMesh Reinforcement)
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.Ungrouping(Dynamic.Tekla.Structures.Model.RebarMesh_.GetTSObject(Reinforcement)));
		}

		public Dynamic.Tekla.Structures.Model.RebarGroup Group(System.Collections.IEnumerable RebarList)
		{
			return Dynamic.Tekla.Structures.Model.RebarGroup_.FromTSObject(teklaObject.Group(RebarList));
		}

		public void ShowOnlySelected(Dynamic.Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum UnselectedMode)
		{
			teklaObject.ShowOnlySelected(Dynamic.Tekla.Structures.Model.Operations.Operation.UnselectedModeEnum_.GetTSObject(UnselectedMode));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateBentPlateByParts(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape)));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateBentPlateByParts(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2)));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByParts(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2, System.Double radius)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateBentPlateByParts(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), radius));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByPartsAndAperture(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2, System.Double largestRadius, System.Double halfAperture)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateConicalBentPlateByPartsAndAperture(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), largestRadius, halfAperture));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByPartsAndTwoRadiuses(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Model.Part part2, System.Double firstRadius, System.Double secondRadius)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateConicalBentPlateByPartsAndTwoRadiuses(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), firstRadius, secondRadius));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1, Dynamic.Tekla.Structures.Model.Part part2, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2, Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), face1, Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), face2, Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape)));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1, Dynamic.Tekla.Structures.Model.Part part2, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), face1, Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), face2));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Solid.Face face1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Solid.Face face2, Dynamic.Tekla.Structures.Model.BentPlate.BendShape bendShape)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1), Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2), Dynamic.Tekla.Structures.Model.BentPlate.BendShape_.GetTSObject(bendShape)));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Solid.Face face1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Solid.Face face2)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1), Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2)));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1, Dynamic.Tekla.Structures.Model.Part part2, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2, System.Double radius)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), face1, Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), face2, radius));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Solid.Face face1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Solid.Face face2, System.Double radius)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1), Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2), radius));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face1, Dynamic.Tekla.Structures.Model.Part part2, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Point> face2, System.Double largestRadius, System.Double halfAperture)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateConicalBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), face1, Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), face2, largestRadius, halfAperture));
		}

		public Dynamic.Tekla.Structures.Model.BentPlate CreateConicalBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part part1, Dynamic.Tekla.Structures.Solid.Face face1, Dynamic.Tekla.Structures.Model.Part part2, Dynamic.Tekla.Structures.Solid.Face face2, System.Double largestRadius, System.Double halfAperture)
		{
			return Dynamic.Tekla.Structures.Model.BentPlate_.FromTSObject(teklaObject.CreateConicalBentPlateByFaces(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part1), Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face1), Dynamic.Tekla.Structures.Model.Part_.GetTSObject(part2), Dynamic.Tekla.Structures.Solid.Face_.GetTSObject(face2), largestRadius, halfAperture));
		}

		public System.Boolean ExplodeBentPlate(Dynamic.Tekla.Structures.Model.BentPlate bentPlate)
		{
			return teklaObject.ExplodeBentPlate(Dynamic.Tekla.Structures.Model.BentPlate_.GetTSObject(bentPlate));
		}

		public System.Boolean AddToPourUnit(Dynamic.Tekla.Structures.Model.PourUnit inputPourUnit, System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> objectsToBeAdded)
		{
			return teklaObject.AddToPourUnit(Dynamic.Tekla.Structures.Model.PourUnit_.GetTSObject(inputPourUnit), objectsToBeAdded);
		}

		public System.Boolean RemoveFromPourUnit(System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> objectsToBeRemoved)
		{
			return teklaObject.RemoveFromPourUnit(objectsToBeRemoved);
		}

		public System.Boolean CalculatePourUnits()
		{
			return teklaObject.CalculatePourUnits();
		}

		public System.Boolean DisplayPrompt(System.String Message)
		{
			return teklaObject.DisplayPrompt(Message);
		}

		public System.Boolean ObjectMatchesToFilter(Dynamic.Tekla.Structures.Model.ModelObject ModelObject, System.String FilterName)
		{
			return teklaObject.ObjectMatchesToFilter(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ModelObject), FilterName);
		}

		public System.Boolean ObjectMatchesToFilter(Dynamic.Tekla.Structures.Model.ModelObject ModelObject, Dynamic.Tekla.Structures.Filtering.FilterExpression FilterExpression)
		{
			return teklaObject.ObjectMatchesToFilter(Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(ModelObject), Dynamic.Tekla.Structures.Filtering.FilterExpression_.GetTSObject(FilterExpression));
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
            var dynObject = (Tekla.Structures.Model.Operations.Operation.ProgressBar)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
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
            var dynObject = (Tekla.Structures.Model.Operations.Operation)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
