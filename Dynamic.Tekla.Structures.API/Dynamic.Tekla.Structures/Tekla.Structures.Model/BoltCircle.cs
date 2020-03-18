//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class BoltCircle 
    {

		public System.Double NumberOfBolts
		{
			get => boltcircle.NumberOfBolts;
			set { boltcircle.NumberOfBolts = value; }
		}

		public System.Double Diameter
		{
			get => boltcircle.Diameter;
			set { boltcircle.Diameter = value; }
		}

		public System.Double BoltSize
		{
			get => boltcircle.BoltSize;
			set { boltcircle.BoltSize = value; }
		}

		public System.String BoltStandard
		{
			get => boltcircle.BoltStandard;
			set { boltcircle.BoltStandard = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum BoltType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(boltcircle.BoltType);
			set { boltcircle.BoltType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum ThreadInMaterial
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(boltcircle.ThreadInMaterial);
			set { boltcircle.ThreadInMaterial = Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(value); }
		}

		public System.Double Length
		{
			get => boltcircle.Length;
			set { boltcircle.Length = value; }
		}

		public System.Double CutLength
		{
			get => boltcircle.CutLength;
			set { boltcircle.CutLength = value; }
		}

		public System.Double ExtraLength
		{
			get => boltcircle.ExtraLength;
			set { boltcircle.ExtraLength = value; }
		}

		public System.Double Tolerance
		{
			get => boltcircle.Tolerance;
			set { boltcircle.Tolerance = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum HoleType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(boltcircle.HoleType);
			set { boltcircle.HoleType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(value); }
		}

		public System.Double SlottedHoleX
		{
			get => boltcircle.SlottedHoleX;
			set { boltcircle.SlottedHoleX = value; }
		}

		public System.Double SlottedHoleY
		{
			get => boltcircle.SlottedHoleY;
			set { boltcircle.SlottedHoleY = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum RotateSlots
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(boltcircle.RotateSlots);
			set { boltcircle.RotateSlots = Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => new Dynamic.Tekla.Structures.Model.Position(boltcircle.Position);
			set { boltcircle.Position = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Offset StartPointOffset
		{
			get => new Dynamic.Tekla.Structures.Model.Offset(boltcircle.StartPointOffset);
			set { boltcircle.StartPointOffset = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Offset EndPointOffset
		{
			get => new Dynamic.Tekla.Structures.Model.Offset(boltcircle.EndPointOffset);
			set { boltcircle.EndPointOffset = value.GetTSObject(); }
		}

		public System.Boolean Washer1
		{
			get => boltcircle.Washer1;
			set { boltcircle.Washer1 = value; }
		}

		public System.Boolean Washer2
		{
			get => boltcircle.Washer2;
			set { boltcircle.Washer2 = value; }
		}

		public System.Boolean Washer3
		{
			get => boltcircle.Washer3;
			set { boltcircle.Washer3 = value; }
		}

		public System.Boolean Nut1
		{
			get => boltcircle.Nut1;
			set { boltcircle.Nut1 = value; }
		}

		public System.Boolean Nut2
		{
			get => boltcircle.Nut2;
			set { boltcircle.Nut2 = value; }
		}

		public System.Boolean Bolt
		{
			get => boltcircle.Bolt;
			set { boltcircle.Bolt = value; }
		}

		public System.Boolean Hole1
		{
			get => boltcircle.Hole1;
			set { boltcircle.Hole1 = value; }
		}

		public System.Boolean Hole2
		{
			get => boltcircle.Hole2;
			set { boltcircle.Hole2 = value; }
		}

		public System.Boolean Hole3
		{
			get => boltcircle.Hole3;
			set { boltcircle.Hole3 = value; }
		}

		public System.Boolean Hole4
		{
			get => boltcircle.Hole4;
			set { boltcircle.Hole4 = value; }
		}

		public System.Boolean Hole5
		{
			get => boltcircle.Hole5;
			set { boltcircle.Hole5 = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBoltTo
		{
			get => new Dynamic.Tekla.Structures.Model.Part(boltcircle.PartToBoltTo);
			set { boltcircle.PartToBoltTo = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBeBolted
		{
			get => new Dynamic.Tekla.Structures.Model.Part(boltcircle.PartToBeBolted);
			set { boltcircle.PartToBeBolted = value.GetTSObject(); }
		}

		public System.Collections.ArrayList OtherPartsToBolt
		{
			get => boltcircle.OtherPartsToBolt;
			set { boltcircle.OtherPartsToBolt = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstPosition
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(boltcircle.FirstPosition);
			set { boltcircle.FirstPosition = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondPosition
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(boltcircle.SecondPosition);
			set { boltcircle.SecondPosition = value.GetTSObject(); }
		}

		public System.Boolean ConnectAssemblies
		{
			get => boltcircle.ConnectAssemblies;
			set { boltcircle.ConnectAssemblies = value; }
		}

		public System.Collections.ArrayList BoltPositions
		{
			get => boltcircle.BoltPositions;
			set { boltcircle.BoltPositions = value; }
		}

		public System.DateTime ModificationTime
		{
			get => boltcircle.ModificationTime;
			set { boltcircle.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => boltcircle.IsUpToDate;
			set { boltcircle.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(boltcircle.Identifier);
			set { boltcircle.Identifier = value.GetTSObject(); }
		}

        

        dynamic boltcircle;
        
        public BoltCircle()
        {
            this.boltcircle =  TSActivator.CreateInstance("Tekla.Structures.Model.BoltCircle");
        }

        public BoltCircle(dynamic tsObject)
        {
            this.boltcircle = tsObject;
        }

        internal dynamic GetTSObject() => boltcircle;

		public System.Boolean Insert()
			 => boltcircle.Insert();

		public System.Boolean Select()
			 => boltcircle.Select();

		public System.Boolean Modify()
			 => boltcircle.Modify();

		public System.Boolean Delete()
			 => boltcircle.Delete();

		public System.Boolean AddOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
			 => boltcircle.AddOtherPartToBolt(M.GetTSObject());

		public System.Boolean RemoveOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
			 => boltcircle.RemoveOtherPartToBolt(M.GetTSObject());

		public System.Collections.ArrayList GetOtherPartsToBolt()
			 => boltcircle.GetOtherPartsToBolt();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(boltcircle.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(System.Boolean withHighAccuracy)
			 => new Dynamic.Tekla.Structures.Model.Solid(boltcircle.GetSolid(withHighAccuracy));

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => new Dynamic.Tekla.Structures.Model.PourObject(boltcircle.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => new Dynamic.Tekla.Structures.Model.PourUnit(boltcircle.GetFatherPourUnit());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(boltcircle.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(boltcircle.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(boltcircle.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => boltcircle.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => boltcircle.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => boltcircle.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => boltcircle.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => boltcircle.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => boltcircle.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => boltcircle.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => boltcircle.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => boltcircle.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => boltcircle.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => boltcircle.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => boltcircle.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => boltcircle.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => boltcircle.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => boltcircle.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => boltcircle.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => boltcircle.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => boltcircle.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => boltcircle.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(boltcircle.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => boltcircle.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => boltcircle.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => boltcircle.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => boltcircle.CompareTo(obj);





    }

}
    
