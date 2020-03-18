//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Beam 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(beam.StartPoint);
			set { beam.StartPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(beam.EndPoint);
			set { beam.EndPoint = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Offset StartPointOffset
		{
			get => new Dynamic.Tekla.Structures.Model.Offset(beam.StartPointOffset);
			set { beam.StartPointOffset = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Offset EndPointOffset
		{
			get => new Dynamic.Tekla.Structures.Model.Offset(beam.EndPointOffset);
			set { beam.EndPointOffset = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Beam.BeamTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.Beam.BeamTypeEnum_.FromTSObject(beam.Type);
			set { beam.Type = Dynamic.Tekla.Structures.Model.Beam.BeamTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Profile Profile
		{
			get => new Dynamic.Tekla.Structures.Model.Profile(beam.Profile);
			set { beam.Profile = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get => new Dynamic.Tekla.Structures.Model.Material(beam.Material);
			set { beam.Material = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get => new Dynamic.Tekla.Structures.Model.DeformingData(beam.DeformingData);
			set { beam.DeformingData = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(beam.PartNumber);
			set { beam.PartNumber = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(beam.AssemblyNumber);
			set { beam.AssemblyNumber = value.GetTSObject(); }
		}

		public System.String Name
		{
			get => beam.Name;
			set { beam.Name = value; }
		}

		public System.String Class
		{
			get => beam.Class;
			set { beam.Class = value; }
		}

		public System.String Finish
		{
			get => beam.Finish;
			set { beam.Finish = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum CastUnitType
		{
			get => Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(beam.CastUnitType);
			set { beam.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(value); }
		}

		public System.Int32 PourPhase
		{
			get => beam.PourPhase;
			set { beam.PourPhase = value; }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => new Dynamic.Tekla.Structures.Model.Position(beam.Position);
			set { beam.Position = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => beam.ModificationTime;
			set { beam.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => beam.IsUpToDate;
			set { beam.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(beam.Identifier);
			set { beam.Identifier = value.GetTSObject(); }
		}

        

        dynamic beam;
        
        public Beam()
        {
            this.beam =  TSActivator.CreateInstance("Tekla.Structures.Model.Beam");
        }

        public Beam(dynamic tsObject)
        {
            this.beam = tsObject;
        }

        internal dynamic GetTSObject() => beam;

		public System.Boolean Insert()
			 => beam.Insert();

		public System.Boolean Select()
			 => beam.Select();

		public System.Boolean Modify()
			 => beam.Modify();

		public System.Boolean Delete()
			 => beam.Delete();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(beam.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType)
			 => new Dynamic.Tekla.Structures.Model.Solid(beam.GetSolid(solidCreationType.GetTSObject()));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
			 => new Dynamic.Tekla.Structures.Model.Solid(beam.GetSolid(formingStates.GetTSObject()));

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => new Dynamic.Tekla.Structures.Model.Assembly(beam.GetAssembly());

		public System.String GetPartMark()
			 => beam.GetPartMark();

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
			 => beam.GetCenterLine(withCutsFittings);

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
			 => beam.GetReferenceLine(withCutsFittings);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetComponents());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetBooleans());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetBolts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetWelds());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetReinforcements());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetSurfaceTreatments());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetPours());

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
			 => beam.CompareTo(partToCompare.GetTSObject());

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(beam.GetDSTVCoordinateSystem());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(beam.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(beam.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => beam.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => beam.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => beam.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => beam.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => beam.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => beam.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => beam.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => beam.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => beam.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => beam.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => beam.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => beam.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => beam.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => beam.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => beam.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => beam.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => beam.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => beam.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => beam.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(beam.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => beam.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => beam.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => beam.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => beam.CompareTo(obj);




    public struct BeamTypeEnum
    {
       
    }

    internal static class BeamTypeEnum_
    {
        public static dynamic GetTSObject(BeamTypeEnum dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BeamTypeEnum");

            return tsType;
        }
    
        public static BeamTypeEnum FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new BeamTypeEnum();
 
            return dynStruct;
        }
    }



    }

}
    
