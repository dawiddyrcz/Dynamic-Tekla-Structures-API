//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class LoftedPlate 
    {

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.ICurve> BaseCurves
		{
			get => loftedplate.BaseCurves;
			set { loftedplate.BaseCurves = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum FaceType
		{
			get => Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum_.FromTSObject(loftedplate.FaceType);
			set { loftedplate.FaceType = Dynamic.Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Profile Profile
		{
			get => Dynamic.Tekla.Structures.Model.Profile_.FromTSObject(loftedplate.Profile);
			set { loftedplate.Profile = Dynamic.Tekla.Structures.Model.Profile_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get => Dynamic.Tekla.Structures.Model.Material_.FromTSObject(loftedplate.Material);
			set { loftedplate.Material = Dynamic.Tekla.Structures.Model.Material_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get => Dynamic.Tekla.Structures.Model.DeformingData_.FromTSObject(loftedplate.DeformingData);
			set { loftedplate.DeformingData = Dynamic.Tekla.Structures.Model.DeformingData_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(loftedplate.PartNumber);
			set { loftedplate.PartNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(loftedplate.AssemblyNumber);
			set { loftedplate.AssemblyNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public System.String Name
		{
			get => loftedplate.Name;
			set { loftedplate.Name = value; }
		}

		public System.String Class
		{
			get => loftedplate.Class;
			set { loftedplate.Class = value; }
		}

		public System.String Finish
		{
			get => loftedplate.Finish;
			set { loftedplate.Finish = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum CastUnitType
		{
			get => Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(loftedplate.CastUnitType);
			set { loftedplate.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.GetTSObject(value); }
		}

		public System.Int32 PourPhase
		{
			get => loftedplate.PourPhase;
			set { loftedplate.PourPhase = value; }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => Dynamic.Tekla.Structures.Model.Position_.FromTSObject(loftedplate.Position);
			set { loftedplate.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => loftedplate.ModificationTime;
			set { loftedplate.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => loftedplate.IsUpToDate;
			set { loftedplate.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(loftedplate.Identifier);
			set { loftedplate.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic loftedplate;
        
        public LoftedPlate()
        {
            this.loftedplate =  TSActivator.CreateInstance("Tekla.Structures.Model.LoftedPlate");
        }

        internal LoftedPlate(dynamic tsObject)
        {
            this.loftedplate = tsObject;
        }

		public System.Boolean Insert()
			 => loftedplate.Insert();

		public System.Boolean Select()
			 => loftedplate.Select();

		public System.Boolean Delete()
			 => loftedplate.Delete();

		public System.Boolean Modify()
			 => loftedplate.Modify();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(loftedplate.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType)
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(loftedplate.GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum_.GetTSObject(solidCreationType)));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(loftedplate.GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates_.GetTSObject(formingStates)));

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(loftedplate.GetAssembly());

		public System.String GetPartMark()
			 => loftedplate.GetPartMark();

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
			 => loftedplate.GetCenterLine(withCutsFittings);

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
			 => loftedplate.GetReferenceLine(withCutsFittings);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetComponents());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetBooleans());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetBolts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetWelds());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetReinforcements());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetSurfaceTreatments());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetPours());

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
			 => loftedplate.CompareTo(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(partToCompare));

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(loftedplate.GetDSTVCoordinateSystem());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(loftedplate.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loftedplate.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => loftedplate.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => loftedplate.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => loftedplate.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => loftedplate.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => loftedplate.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loftedplate.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loftedplate.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loftedplate.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => loftedplate.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => loftedplate.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => loftedplate.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => loftedplate.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => loftedplate.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => loftedplate.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => loftedplate.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => loftedplate.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => loftedplate.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => loftedplate.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => loftedplate.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(loftedplate.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loftedplate.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loftedplate.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => loftedplate.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => loftedplate.CompareTo(obj);




    public enum LoftedPlateFaceTypeEnum
    {
			Perpendicular,
			BoundedByCurvePlanes        
    }

    internal static class LoftedPlateFaceTypeEnum_
    {
        public static dynamic GetTSObject(LoftedPlateFaceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoftedPlateFaceTypeEnum");

            switch (dynEnum)
            {
				case LoftedPlateFaceTypeEnum.Perpendicular:
					return System.Enum.Parse(tsType, "Perpendicular");
				case LoftedPlateFaceTypeEnum.BoundedByCurvePlanes:
					return System.Enum.Parse(tsType, "BoundedByCurvePlanes");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LoftedPlateFaceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Perpendicular", System.StringComparison.InvariantCulture))
				return LoftedPlateFaceTypeEnum.Perpendicular;
			else if (tsEnumValue.Equals("BoundedByCurvePlanes", System.StringComparison.InvariantCulture))
				return LoftedPlateFaceTypeEnum.BoundedByCurvePlanes;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LoftedPlate_
    {
        public static dynamic GetTSObject(LoftedPlate dynObject)
        {
            return dynObject.loftedplate;
        }

        public static LoftedPlate FromTSObject(dynamic tsObject)
        {
            return new LoftedPlate(tsObject);
        }
    }


}
    
