//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class BentPlate 
    {

		public Dynamic.Tekla.Structures.Model.ConnectiveGeometry Geometry
		{
			get => Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.FromTSObject(bentplate.Geometry);
			set { bentplate.Geometry = Dynamic.Tekla.Structures.Model.ConnectiveGeometry_.GetTSObject(value); }
		}

		public System.Double Thickness
		{
			get => bentplate.Thickness;
			set { bentplate.Thickness = value; }
		}

		public Dynamic.Tekla.Structures.Model.Profile Profile
		{
			get => Dynamic.Tekla.Structures.Model.Profile_.FromTSObject(bentplate.Profile);
			set { bentplate.Profile = Dynamic.Tekla.Structures.Model.Profile_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get => Dynamic.Tekla.Structures.Model.Material_.FromTSObject(bentplate.Material);
			set { bentplate.Material = Dynamic.Tekla.Structures.Model.Material_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get => Dynamic.Tekla.Structures.Model.DeformingData_.FromTSObject(bentplate.DeformingData);
			set { bentplate.DeformingData = Dynamic.Tekla.Structures.Model.DeformingData_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(bentplate.PartNumber);
			set { bentplate.PartNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => Dynamic.Tekla.Structures.Model.NumberingSeries_.FromTSObject(bentplate.AssemblyNumber);
			set { bentplate.AssemblyNumber = Dynamic.Tekla.Structures.Model.NumberingSeries_.GetTSObject(value); }
		}

		public System.String Name
		{
			get => bentplate.Name;
			set { bentplate.Name = value; }
		}

		public System.String Class
		{
			get => bentplate.Class;
			set { bentplate.Class = value; }
		}

		public System.String Finish
		{
			get => bentplate.Finish;
			set { bentplate.Finish = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum CastUnitType
		{
			get => Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(bentplate.CastUnitType);
			set { bentplate.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.GetTSObject(value); }
		}

		public System.Int32 PourPhase
		{
			get => bentplate.PourPhase;
			set { bentplate.PourPhase = value; }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => Dynamic.Tekla.Structures.Model.Position_.FromTSObject(bentplate.Position);
			set { bentplate.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => bentplate.ModificationTime;
			set { bentplate.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => bentplate.IsUpToDate;
			set { bentplate.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(bentplate.Identifier);
			set { bentplate.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic bentplate;
        
        public BentPlate()
        {
            this.bentplate =  TSActivator.CreateInstance("Tekla.Structures.Model.BentPlate");
        }

        internal BentPlate(dynamic tsObject)
        {
            this.bentplate = tsObject;
        }

		public System.Boolean Insert()
			 => bentplate.Insert();

		public System.Boolean Select()
			 => bentplate.Select();

		public System.Boolean Delete()
			 => bentplate.Delete();

		public System.Boolean Modify()
			 => bentplate.Modify();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(bentplate.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType)
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(bentplate.GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum_.GetTSObject(solidCreationType)));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(bentplate.GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates_.GetTSObject(formingStates)));

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(bentplate.GetAssembly());

		public System.String GetPartMark()
			 => bentplate.GetPartMark();

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
			 => bentplate.GetCenterLine(withCutsFittings);

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
			 => bentplate.GetReferenceLine(withCutsFittings);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetComponents());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetBooleans());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetBolts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetWelds());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetReinforcements());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetSurfaceTreatments());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetPours());

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
			 => bentplate.CompareTo(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(partToCompare));

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(bentplate.GetDSTVCoordinateSystem());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(bentplate.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(bentplate.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => bentplate.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => bentplate.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => bentplate.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => bentplate.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => bentplate.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => bentplate.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => bentplate.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => bentplate.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => bentplate.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => bentplate.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => bentplate.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => bentplate.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => bentplate.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => bentplate.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => bentplate.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => bentplate.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => bentplate.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => bentplate.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => bentplate.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(bentplate.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => bentplate.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => bentplate.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => bentplate.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => bentplate.CompareTo(obj);




    public enum BendShape
    {
			Cylindrical,
			Conical        
    }

    internal static class BendShape_
    {
        public static dynamic GetTSObject(BendShape dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BendShape");

            switch (dynEnum)
            {
				case BendShape.Cylindrical:
					return System.Enum.Parse(tsType, "Cylindrical");
				case BendShape.Conical:
					return System.Enum.Parse(tsType, "Conical");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BendShape FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("Cylindrical", System.StringComparison.InvariantCulture))
				return BendShape.Cylindrical;
			else if (tsEnumValue.Equals("Conical", System.StringComparison.InvariantCulture))
				return BendShape.Conical;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class BentPlate_
    {
        public static dynamic GetTSObject(BentPlate dynObject)
        {
            return dynObject.bentplate;
        }

        public static BentPlate FromTSObject(dynamic tsObject)
        {
            return new BentPlate(tsObject);
        }
    }


}
    