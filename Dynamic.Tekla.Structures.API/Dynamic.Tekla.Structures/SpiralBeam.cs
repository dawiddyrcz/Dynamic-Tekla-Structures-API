//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class SpiralBeam 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.StartPoint.GetTSObject());
			set { spiralbeam.StartPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisBasePoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.RotationAxisBasePoint.GetTSObject());
			set { spiralbeam.RotationAxisBasePoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisUpPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.RotationAxisUpPoint.GetTSObject());
			set { spiralbeam.RotationAxisUpPoint = value.GetTSObject(); }
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
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.RotationCenterPoint.GetTSObject());
			set { spiralbeam.RotationCenterPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxisDirection
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(spiralbeam.RotationAxisDirection.GetTSObject());
			set { spiralbeam.RotationAxisDirection = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.EndPoint.GetTSObject());
			set { spiralbeam.EndPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Profile Profile
		{
			get => new Dynamic.Tekla.Structures.Model.Profile(spiralbeam.Profile.GetTSObject());
			set { spiralbeam.Profile = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get => new Dynamic.Tekla.Structures.Model.Material(spiralbeam.Material.GetTSObject());
			set { spiralbeam.Material = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get => new Dynamic.Tekla.Structures.Model.DeformingData(spiralbeam.DeformingData.GetTSObject());
			set { spiralbeam.DeformingData = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(spiralbeam.PartNumber.GetTSObject());
			set { spiralbeam.PartNumber = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(spiralbeam.AssemblyNumber.GetTSObject());
			set { spiralbeam.AssemblyNumber = value.GetTSObject(); }
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
			set { spiralbeam.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(value); }
		}

		public System.Int32 PourPhase
		{
			get => spiralbeam.PourPhase;
			set { spiralbeam.PourPhase = value; }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => new Dynamic.Tekla.Structures.Model.Position(spiralbeam.Position.GetTSObject());
			set { spiralbeam.Position = value.GetTSObject(); }
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
			get => new Dynamic.Tekla.Structures.Identifier(spiralbeam.Identifier.GetTSObject());
			set { spiralbeam.Identifier = value.GetTSObject(); }
		}

        

        dynamic spiralbeam;
        
        public SpiralBeam()
        {
            this.spiralbeam =  new Tekla.Structures.Model.SpiralBeam();
        }

        public SpiralBeam(dynamic tsObject)
        {
            this.spiralbeam = tsObject;
			this.StartPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.StartPoint);
			this.RotationAxisBasePoint = new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.RotationAxisBasePoint);
			this.RotationAxisUpPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.RotationAxisUpPoint);
			this.TotalRise = spiralbeam.TotalRise;
			this.RotationAngle = spiralbeam.RotationAngle;
			this.TwistAngleStart = spiralbeam.TwistAngleStart;
			this.TwistAngleEnd = spiralbeam.TwistAngleEnd;
			this.RotationCenterPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.RotationCenterPoint);
			this.RotationAxisDirection = new Dynamic.Tekla.Structures.Geometry3d.Vector(spiralbeam.RotationAxisDirection);
			this.EndPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(spiralbeam.EndPoint);
			this.Profile = new Dynamic.Tekla.Structures.Model.Profile(spiralbeam.Profile);
			this.Material = new Dynamic.Tekla.Structures.Model.Material(spiralbeam.Material);
			this.DeformingData = new Dynamic.Tekla.Structures.Model.DeformingData(spiralbeam.DeformingData);
			this.PartNumber = new Dynamic.Tekla.Structures.Model.NumberingSeries(spiralbeam.PartNumber);
			this.AssemblyNumber = new Dynamic.Tekla.Structures.Model.NumberingSeries(spiralbeam.AssemblyNumber);
			this.Name = spiralbeam.Name;
			this.Class = spiralbeam.Class;
			this.Finish = spiralbeam.Finish;
			this.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(spiralbeam.CastUnitType);
			this.PourPhase = spiralbeam.PourPhase;
			this.Position = new Dynamic.Tekla.Structures.Model.Position(spiralbeam.Position);
			this.ModificationTime = spiralbeam.ModificationTime;
			this.IsUpToDate = spiralbeam.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(spiralbeam.Identifier);

        }


        public dynamic GetTSObject() => spiralbeam;

		public System.Boolean Insert()
			 => spiralbeam.Insert();

		public System.Boolean Select()
			 => spiralbeam.Select();

		public System.Boolean Delete()
			 => spiralbeam.Delete();

		public System.Boolean Modify()
			 => spiralbeam.Modify();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(spiralbeam.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType)
			 => new Dynamic.Tekla.Structures.Model.Solid(spiralbeam.GetSolid(solidCreationType.GetTSObject()));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
			 => new Dynamic.Tekla.Structures.Model.Solid(spiralbeam.GetSolid(formingStates.GetTSObject()));

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => new Dynamic.Tekla.Structures.Model.Assembly(spiralbeam.GetAssembly());

		public System.String GetPartMark()
			 => spiralbeam.GetPartMark();

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
			 => spiralbeam.GetCenterLine(withCutsFittings);

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
			 => spiralbeam.GetReferenceLine(withCutsFittings);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetComponents());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetBooleans());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetBolts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetWelds());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetReinforcements());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetSurfaceTreatments());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetPours());

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
			 => spiralbeam.CompareTo(partToCompare.GetTSObject());

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(spiralbeam.GetDSTVCoordinateSystem());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(spiralbeam.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(spiralbeam.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => spiralbeam.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => spiralbeam.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => spiralbeam.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => spiralbeam.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => spiralbeam.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => spiralbeam.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => spiralbeam.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => spiralbeam.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => spiralbeam.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => spiralbeam.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => spiralbeam.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => spiralbeam.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => spiralbeam.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => spiralbeam.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => spiralbeam.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => spiralbeam.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => spiralbeam.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => spiralbeam.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => spiralbeam.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(spiralbeam.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => spiralbeam.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => spiralbeam.GetPhase(ref phase.GetTSObject());

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

    public static class ErrorStatus_
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

}
    
