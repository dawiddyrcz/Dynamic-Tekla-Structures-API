//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class SpiralBeam 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(spiralbeam.StartPoint);
			set { spiralbeam.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisBasePoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(spiralbeam.RotationAxisBasePoint);
			set { spiralbeam.RotationAxisBasePoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisUpPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(spiralbeam.RotationAxisUpPoint);
			set { spiralbeam.RotationAxisUpPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Double TotalRise
		{
			get => spiralbeam.TotalRise;
			set { spiralbeam.TotalRise = value; }
		}

		public System.Double RotationAngle
		{
			get => spiralbeam.RotationAngle;
			set { spiralbeam.RotationAngle = value; }
		}

		public System.Double TwistAngleStart
		{
			get => spiralbeam.TwistAngleStart;
			set { spiralbeam.TwistAngleStart = value; }
		}

		public System.Double TwistAngleEnd
		{
			get => spiralbeam.TwistAngleEnd;
			set { spiralbeam.TwistAngleEnd = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationCenterPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(spiralbeam.RotationCenterPoint);
			set { spiralbeam.RotationCenterPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxisDirection
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(spiralbeam.RotationAxisDirection);
			set { spiralbeam.RotationAxisDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(spiralbeam.EndPoint);
			set { spiralbeam.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Profile Profile
		{
			get => Dynamic.Tekla.Structures.Model.Profile_.FromTSObject(spiralbeam.Profile);
			set { spiralbeam.Profile = Dynamic.Tekla.Structures.Model.Profile_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get => Dynamic.Tekla.Structures.Model.Material_.FromTSObject(spiralbeam.Material);
			set { spiralbeam.Material = Dynamic.Tekla.Structures.Model.Material_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get => Dynamic.Tekla.Structures.Model.DeformingData_.FromTSObject(spiralbeam.DeformingData);
			set { spiralbeam.DeformingData = Dynamic.Tekla.Structures.Model.DeformingData_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(spiralbeam.PartNumber);
			set { spiralbeam.PartNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(spiralbeam.AssemblyNumber);
			set { spiralbeam.AssemblyNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public System.String Name
		{
			get => spiralbeam.Name;
			set { spiralbeam.Name = value; }
		}

		public System.String Class
		{
			get => spiralbeam.Class;
			set { spiralbeam.Class = value; }
		}

		public System.String Finish
		{
			get => spiralbeam.Finish;
			set { spiralbeam.Finish = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum CastUnitType
		{
			get => Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(spiralbeam.CastUnitType);
			set { spiralbeam.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.GetTSObject(value); }
		}

		public System.Int32 PourPhase
		{
			get => spiralbeam.PourPhase;
			set { spiralbeam.PourPhase = value; }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => Dynamic.Tekla.Structures.Model.Position_.FromTSObject(spiralbeam.Position);
			set { spiralbeam.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => spiralbeam.ModificationTime;
			set { spiralbeam.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => spiralbeam.IsUpToDate;
			set { spiralbeam.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(spiralbeam.Identifier);
			set { spiralbeam.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic spiralbeam;
        
        public SpiralBeam()
        {
            this.spiralbeam =  TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam");
        }

        internal SpiralBeam(dynamic tsObject)
        {
            this.spiralbeam = tsObject;
        }

		public System.Boolean Insert()
			 => spiralbeam.Insert();

		public System.Boolean Select()
			 => spiralbeam.Select();

		public System.Boolean Delete()
			 => spiralbeam.Delete();

		public System.Boolean Modify()
			 => spiralbeam.Modify();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(spiralbeam.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType)
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(spiralbeam.GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum_.GetTSObject(solidCreationType)));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(spiralbeam.GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates_.GetTSObject(formingStates)));

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(spiralbeam.GetAssembly());

		public System.String GetPartMark()
			 => spiralbeam.GetPartMark();

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
			 => spiralbeam.GetCenterLine(withCutsFittings);

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
			 => spiralbeam.GetReferenceLine(withCutsFittings);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetComponents());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetBooleans());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetBolts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetWelds());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetReinforcements());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetSurfaceTreatments());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetPours());

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
			 => spiralbeam.CompareTo(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(partToCompare));

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(spiralbeam.GetDSTVCoordinateSystem());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(spiralbeam.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(spiralbeam.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => spiralbeam.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => spiralbeam.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => spiralbeam.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => spiralbeam.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => spiralbeam.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => spiralbeam.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => spiralbeam.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => spiralbeam.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => spiralbeam.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => spiralbeam.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => spiralbeam.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => spiralbeam.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => spiralbeam.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => spiralbeam.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => spiralbeam.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => spiralbeam.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => spiralbeam.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => spiralbeam.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => spiralbeam.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(spiralbeam.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => spiralbeam.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => spiralbeam.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => spiralbeam.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => spiralbeam.CompareTo(obj);




    public enum ErrorStatus
    {
			DataMissing,
			DefinitionPointsTooClose,
			DefinitionPointsCannotBeAligned,
			ZeroTotalRiseWithMore360Degrees        
    }

    internal static class ErrorStatus_
    {
        public static dynamic GetTSObject(ErrorStatus dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ErrorStatus");

            switch (dynEnum)
            {
				case ErrorStatus.DataMissing:
					return System.Enum.Parse(tsType, "DataMissing");
				case ErrorStatus.DefinitionPointsTooClose:
					return System.Enum.Parse(tsType, "DefinitionPointsTooClose");
				case ErrorStatus.DefinitionPointsCannotBeAligned:
					return System.Enum.Parse(tsType, "DefinitionPointsCannotBeAligned");
				case ErrorStatus.ZeroTotalRiseWithMore360Degrees:
					return System.Enum.Parse(tsType, "ZeroTotalRiseWithMore360Degrees");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ErrorStatus FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("DataMissing", System.StringComparison.InvariantCulture))
				return ErrorStatus.DataMissing;
			else if (tsEnumValue.Equals("DefinitionPointsTooClose", System.StringComparison.InvariantCulture))
				return ErrorStatus.DefinitionPointsTooClose;
			else if (tsEnumValue.Equals("DefinitionPointsCannotBeAligned", System.StringComparison.InvariantCulture))
				return ErrorStatus.DefinitionPointsCannotBeAligned;
			else if (tsEnumValue.Equals("ZeroTotalRiseWithMore360Degrees", System.StringComparison.InvariantCulture))
				return ErrorStatus.ZeroTotalRiseWithMore360Degrees;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class SpiralBeam_
    {
        public static dynamic GetTSObject(SpiralBeam dynObject)
        {
            return dynObject.spiralbeam;
        }

        public static SpiralBeam FromTSObject(dynamic tsObject)
        {
            return new SpiralBeam(tsObject);
        }
    }


}
    