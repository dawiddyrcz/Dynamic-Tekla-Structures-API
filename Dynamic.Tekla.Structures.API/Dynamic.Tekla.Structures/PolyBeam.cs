//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class PolyBeam 
    {

		public Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum_.FromTSObject(polybeam.Type);
			set { polybeam.Type = Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Contour Contour
		{
			get => new Dynamic.Tekla.Structures.Model.Contour(polybeam.Contour.GetTSObject());
			set { polybeam.Contour = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Profile Profile
		{
			get => new Dynamic.Tekla.Structures.Model.Profile(polybeam.Profile.GetTSObject());
			set { polybeam.Profile = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get => new Dynamic.Tekla.Structures.Model.Material(polybeam.Material.GetTSObject());
			set { polybeam.Material = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get => new Dynamic.Tekla.Structures.Model.DeformingData(polybeam.DeformingData.GetTSObject());
			set { polybeam.DeformingData = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(polybeam.PartNumber.GetTSObject());
			set { polybeam.PartNumber = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(polybeam.AssemblyNumber.GetTSObject());
			set { polybeam.AssemblyNumber = value.GetTSObject(); }
		}

		public System.String Name
		{
			get => polybeam.Name;
			set { polybeam.Name = value; }
		}

		public System.String Class
		{
			get => polybeam.Class;
			set { polybeam.Class = value; }
		}

		public System.String Finish
		{
			get => polybeam.Finish;
			set { polybeam.Finish = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum CastUnitType
		{
			get => Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(polybeam.CastUnitType);
			set { polybeam.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(value); }
		}

		public System.Int32 PourPhase
		{
			get => polybeam.PourPhase;
			set { polybeam.PourPhase = value; }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => new Dynamic.Tekla.Structures.Model.Position(polybeam.Position.GetTSObject());
			set { polybeam.Position = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => polybeam.ModificationTime;
			set { polybeam.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => polybeam.IsUpToDate;
			set { polybeam.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(polybeam.Identifier.GetTSObject());
			set { polybeam.Identifier = value.GetTSObject(); }
		}

        

        dynamic polybeam;
        
        public PolyBeam()
        {
            this.polybeam =  TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeam");
        }

        public PolyBeam(dynamic tsObject)
        {
            this.polybeam = tsObject;
			this.Type = Dynamic.Tekla.Structures.Model.PolyBeam.PolyBeamTypeEnum_.FromTSObject(polybeam.Type);
			this.Contour = new Dynamic.Tekla.Structures.Model.Contour(polybeam.Contour);
			this.Profile = new Dynamic.Tekla.Structures.Model.Profile(polybeam.Profile);
			this.Material = new Dynamic.Tekla.Structures.Model.Material(polybeam.Material);
			this.DeformingData = new Dynamic.Tekla.Structures.Model.DeformingData(polybeam.DeformingData);
			this.PartNumber = new Dynamic.Tekla.Structures.Model.NumberingSeries(polybeam.PartNumber);
			this.AssemblyNumber = new Dynamic.Tekla.Structures.Model.NumberingSeries(polybeam.AssemblyNumber);
			this.Name = polybeam.Name;
			this.Class = polybeam.Class;
			this.Finish = polybeam.Finish;
			this.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(polybeam.CastUnitType);
			this.PourPhase = polybeam.PourPhase;
			this.Position = new Dynamic.Tekla.Structures.Model.Position(polybeam.Position);
			this.ModificationTime = polybeam.ModificationTime;
			this.IsUpToDate = polybeam.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(polybeam.Identifier);

        }


        public dynamic GetTSObject() => polybeam;

		public System.Boolean AddContourPoint(Dynamic.Tekla.Structures.Model.ContourPoint contourPoint)
			 => polybeam.AddContourPoint(contourPoint.GetTSObject());

		public System.Boolean Insert()
			 => polybeam.Insert();

		public System.Boolean Select()
			 => polybeam.Select();

		public System.Boolean Modify()
			 => polybeam.Modify();

		public System.Boolean Delete()
			 => polybeam.Delete();

		public System.Collections.ArrayList GetPolybeamCoordinateSystems()
			 => polybeam.GetPolybeamCoordinateSystems();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(polybeam.GetSolid());


		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
			 => new Dynamic.Tekla.Structures.Model.Solid(polybeam.GetSolid(formingStates.GetTSObject()));

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => new Dynamic.Tekla.Structures.Model.Assembly(polybeam.GetAssembly());

		public System.String GetPartMark()
			 => polybeam.GetPartMark();

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
			 => polybeam.GetCenterLine(withCutsFittings);

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
			 => polybeam.GetReferenceLine(withCutsFittings);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetComponents());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetBooleans());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetBolts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetWelds());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetReinforcements());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetSurfaceTreatments());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetPours());

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
			 => polybeam.CompareTo(partToCompare.GetTSObject());

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(polybeam.GetDSTVCoordinateSystem());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(polybeam.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(polybeam.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => polybeam.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => polybeam.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => polybeam.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => polybeam.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => polybeam.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => polybeam.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => polybeam.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => polybeam.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => polybeam.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => polybeam.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => polybeam.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => polybeam.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => polybeam.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => polybeam.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => polybeam.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => polybeam.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => polybeam.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => polybeam.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => polybeam.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(polybeam.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => polybeam.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => polybeam.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => polybeam.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => polybeam.CompareTo(obj);




    public enum PolyBeamTypeEnum
    {
			BEAM,
			PANEL,
			STRIP_FOOTING,
			COLUMN        
    }

    public static class PolyBeamTypeEnum_
    {
        public static dynamic GetTSObject(PolyBeamTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.PolyBeamTypeEnum");

            switch (dynEnum)
            {
				case PolyBeamTypeEnum.BEAM:
					return System.Enum.Parse(tsType, "BEAM");
				case PolyBeamTypeEnum.PANEL:
					return System.Enum.Parse(tsType, "PANEL");
				case PolyBeamTypeEnum.STRIP_FOOTING:
					return System.Enum.Parse(tsType, "STRIP_FOOTING");
				case PolyBeamTypeEnum.COLUMN:
					return System.Enum.Parse(tsType, "COLUMN");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PolyBeamTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BEAM", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.BEAM;
			else if (tsEnumValue.Equals("PANEL", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.PANEL;
			else if (tsEnumValue.Equals("STRIP_FOOTING", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.STRIP_FOOTING;
			else if (tsEnumValue.Equals("COLUMN", System.StringComparison.InvariantCulture))
				return PolyBeamTypeEnum.COLUMN;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
