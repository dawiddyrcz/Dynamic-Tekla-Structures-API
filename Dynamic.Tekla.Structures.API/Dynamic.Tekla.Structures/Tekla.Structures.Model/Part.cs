//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Part 
    {

		public Dynamic.Tekla.Structures.Model.Profile Profile
		{
			get => new Dynamic.Tekla.Structures.Model.Profile(part.Profile);
			set { part.Profile = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Material Material
		{
			get => new Dynamic.Tekla.Structures.Model.Material(part.Material);
			set { part.Material = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.DeformingData DeformingData
		{
			get => new Dynamic.Tekla.Structures.Model.DeformingData(part.DeformingData);
			set { part.DeformingData = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries PartNumber
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(part.PartNumber);
			set { part.PartNumber = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries AssemblyNumber
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(part.AssemblyNumber);
			set { part.AssemblyNumber = value.GetTSObject(); }
		}

		public System.String Name
		{
			get => part.Name;
			set { part.Name = value; }
		}

		public System.String Class
		{
			get => part.Class;
			set { part.Class = value; }
		}

		public System.String Finish
		{
			get => part.Finish;
			set { part.Finish = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum CastUnitType
		{
			get => Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(part.CastUnitType);
			set { part.CastUnitType = Dynamic.Tekla.Structures.Model.Part.CastUnitTypeEnum_.FromTSObject(value); }
		}

		public System.Int32 PourPhase
		{
			get => part.PourPhase;
			set { part.PourPhase = value; }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => new Dynamic.Tekla.Structures.Model.Position(part.Position);
			set { part.Position = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => part.ModificationTime;
			set { part.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => part.IsUpToDate;
			set { part.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(part.Identifier);
			set { part.Identifier = value.GetTSObject(); }
		}

        

        dynamic part;
        
        private Part()
        {
            this.part =  TSActivator.CreateInstance("Tekla.Structures.Model.Part");
        }

        public Part(dynamic tsObject)
        {
            this.part = tsObject;
        }

        internal dynamic GetTSObject() => part;

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(part.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Model.Solid.SolidCreationTypeEnum solidCreationType)
			 => new Dynamic.Tekla.Structures.Model.Solid(part.GetSolid(solidCreationType.GetTSObject()));

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(Dynamic.Tekla.Structures.Forming.FormingStates formingStates)
			 => new Dynamic.Tekla.Structures.Model.Solid(part.GetSolid(formingStates.GetTSObject()));

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => new Dynamic.Tekla.Structures.Model.Assembly(part.GetAssembly());

		public System.String GetPartMark()
			 => part.GetPartMark();

		public System.Collections.ArrayList GetCenterLine(System.Boolean withCutsFittings)
			 => part.GetCenterLine(withCutsFittings);

		public System.Collections.ArrayList GetReferenceLine(System.Boolean withCutsFittings)
			 => part.GetReferenceLine(withCutsFittings);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetComponents());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBooleans()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetBooleans());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetBolts()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetBolts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetWelds()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetWelds());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetReinforcements());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceTreatments()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetSurfaceTreatments());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetPours()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetPours());

		public System.Boolean CompareTo(Dynamic.Tekla.Structures.Model.Part partToCompare)
			 => part.CompareTo(partToCompare.GetTSObject());

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetDSTVCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(part.GetDSTVCoordinateSystem());

		public System.Boolean Insert()
			 => part.Insert();

		public System.Boolean Select()
			 => part.Select();

		public System.Boolean Modify()
			 => part.Modify();

		public System.Boolean Delete()
			 => part.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(part.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(part.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => part.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => part.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => part.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => part.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => part.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => part.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => part.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => part.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => part.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => part.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => part.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => part.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => part.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => part.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => part.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => part.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => part.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => part.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => part.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(part.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => part.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => part.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => part.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => part.CompareTo(obj);




    public struct CastUnitTypeEnum
    {
       
    }

    internal static class CastUnitTypeEnum_
    {
        public static dynamic GetTSObject(CastUnitTypeEnum dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.CastUnitTypeEnum");

            return tsType;
        }
    
        public static CastUnitTypeEnum FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new CastUnitTypeEnum();
 
            return dynStruct;
        }
    }



    }

}
    
