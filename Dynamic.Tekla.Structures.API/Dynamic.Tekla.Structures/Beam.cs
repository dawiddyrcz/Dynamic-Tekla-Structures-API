//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Beam 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint {get; set; }
		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint {get; set; }
		public Dynamic.Tekla.Structures.Model.Offset StartPointOffset {get; set; }
		public Dynamic.Tekla.Structures.Model.Offset EndPointOffset {get; set; }
		public Dynamic.Tekla.Structures.Model.BeamTypeEnum Type {get; set; }
		public Dynamic.Tekla.Structures.Model.Profile Profile {get; set; }
		public Dynamic.Tekla.Structures.Model.Material Material {get; set; }
		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData {get; set; }
		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber {get; set; }
		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber {get; set; }
		public System.String Name {get; set; }
		public System.String Class {get; set; }
		public System.String Finish {get; set; }
		public Dynamic.Tekla.Structures.Model.CastUnitTypeEnum CastUnitType {get; set; }
		public System.Int32 PourPhase {get; set; }
		public Dynamic.Tekla.Structures.Model.Position Position {get; set; }
		public System.Nullable<System.DateTime> ModificationTime {get; set; }
		public System.Boolean IsUpToDate {get; set; }
		public Dynamic.Tekla.Structures.Identifier Identifier {get; set; }
        

        dynamic beam;
        
        public Beam()
        {
            this.beam =  new Tekla.Structures.Model.Beam();
        }

        public Beam(dynamic tsObject)
        {
            this.beam = tsObject;
			this.StartPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(beam.StartPoint);
			this.EndPoint = new Dynamic.Tekla.Structures.Geometry3d.Point(beam.EndPoint);
			this.StartPointOffset = new Dynamic.Tekla.Structures.Model.Offset(beam.StartPointOffset);
			this.EndPointOffset = new Dynamic.Tekla.Structures.Model.Offset(beam.EndPointOffset);
			this.Type = Dynamic.Tekla.Structures.Model.BeamTypeEnum_.FromTSObject(beam.Type);
			this.Profile = new Dynamic.Tekla.Structures.Model.Profile(beam.Profile);
			this.Material = new Dynamic.Tekla.Structures.Model.Material(beam.Material);
			this.DeformingData = new Dynamic.Tekla.Structures.Model.DeformingData(beam.DeformingData);
			this.PartNumber = new Dynamic.Tekla.Structures.Model.NumberingSeries(beam.PartNumber);
			this.AssemblyNumber = new Dynamic.Tekla.Structures.Model.NumberingSeries(beam.AssemblyNumber);
			this.Name = beam.Name;
			this.Class = beam.Class;
			this.Finish = beam.Finish;
			this.CastUnitType = Dynamic.Tekla.Structures.Model.CastUnitTypeEnum_.FromTSObject(beam.CastUnitType);
			this.PourPhase = beam.PourPhase;
			this.Position = new Dynamic.Tekla.Structures.Model.Position(beam.Position);
			this.ModificationTime = beam.ModificationTime;
			this.IsUpToDate = beam.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(beam.Identifier);

        }


        public dynamic GetTSObject() => beam;

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

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.SolidCreationTypeEnum solidCreationType)
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

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => beam.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => beam.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => beam.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => beam.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => beam.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => beam.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => beam.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => beam.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => beam.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => beam.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => beam.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => beam.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => beam.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => beam.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => beam.GetDynamicStringProperty(name, ref value);

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

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => beam.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => beam.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => beam.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => beam.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => beam.Equals(obj);

		public System.Int32 GetHashCode()
			 => beam.GetHashCode();

		public System.Type GetType()
			 => beam.GetType();

		public System.String ToString()
			 => beam.ToString();



    }

}
    
