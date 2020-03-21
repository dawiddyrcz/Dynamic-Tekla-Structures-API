//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class Beam  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Offset StartPointOffset
		{
			get => Dynamic.Tekla.Structures.Model.Offset_.FromTSObject(teklaObject.StartPointOffset);
			set { teklaObject.StartPointOffset = Dynamic.Tekla.Structures.Model.Offset_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Offset EndPointOffset
		{
			get => Dynamic.Tekla.Structures.Model.Offset_.FromTSObject(teklaObject.EndPointOffset);
			set { teklaObject.EndPointOffset = Dynamic.Tekla.Structures.Model.Offset_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Beam.BeamTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.Beam.BeamTypeEnum_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Model.Beam.BeamTypeEnum_.GetTSObject(value); }
		}

        

        

		public Beam()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Beam");
		}
		public Beam(Dynamic.Tekla.Structures.Model.Beam.BeamTypeEnum beamType)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.Beam.BeamTypeEnum_.GetTSObject(beamType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Beam", args);
		}
		public Beam(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Beam", args);
		}

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Select()
			 => teklaObject.Select();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType)
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum_.GetTSObject(solidCreationType)));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates_.GetTSObject(formingStates)));

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(teklaObject.GetAssembly());

		public System.String GetPartMark()
			 => teklaObject.GetPartMark();

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
			 => teklaObject.GetCenterLine(withCutsFittings);

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
			 => teklaObject.GetReferenceLine(withCutsFittings);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetComponents());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetBooleans());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetBolts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetWelds());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetReinforcements());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetSurfaceTreatments());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetPours());

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
			 => teklaObject.CompareTo(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(partToCompare));

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.GetDSTVCoordinateSystem());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(teklaObject.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => teklaObject.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => teklaObject.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => teklaObject.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => teklaObject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => teklaObject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => teklaObject.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => teklaObject.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => teklaObject.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => teklaObject.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => teklaObject.CompareTo(obj);




    public enum BeamTypeEnum
    {
			BEAM,
			PANEL,
			STRIP_FOOTING,
			PAD_FOOTING,
			COLUMN        
    }

    internal static class BeamTypeEnum_
    {
        public static dynamic GetTSObject(BeamTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Beam.BeamTypeEnum").GetType();

            switch (dynEnum)
            {
				case BeamTypeEnum.BEAM:
					return System.Enum.Parse(tsType, "BEAM");
				case BeamTypeEnum.PANEL:
					return System.Enum.Parse(tsType, "PANEL");
				case BeamTypeEnum.STRIP_FOOTING:
					return System.Enum.Parse(tsType, "STRIP_FOOTING");
				case BeamTypeEnum.PAD_FOOTING:
					return System.Enum.Parse(tsType, "PAD_FOOTING");
				case BeamTypeEnum.COLUMN:
					return System.Enum.Parse(tsType, "COLUMN");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BeamTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BEAM", System.StringComparison.InvariantCulture))
				return BeamTypeEnum.BEAM;
			else if (tsEnumValue.Equals("PANEL", System.StringComparison.InvariantCulture))
				return BeamTypeEnum.PANEL;
			else if (tsEnumValue.Equals("STRIP_FOOTING", System.StringComparison.InvariantCulture))
				return BeamTypeEnum.STRIP_FOOTING;
			else if (tsEnumValue.Equals("PAD_FOOTING", System.StringComparison.InvariantCulture))
				return BeamTypeEnum.PAD_FOOTING;
			else if (tsEnumValue.Equals("COLUMN", System.StringComparison.InvariantCulture))
				return BeamTypeEnum.COLUMN;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Beam_
    {
        public static dynamic GetTSObject(Beam dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Beam FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Beam)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
