//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class BoltArray 
    {

		public System.Double BoltSize
		{
			get => boltarray.BoltSize;
			set { boltarray.BoltSize = value; }
		}

		public System.String BoltStandard
		{
			get => boltarray.BoltStandard;
			set { boltarray.BoltStandard = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum BoltType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(boltarray.BoltType);
			set { boltarray.BoltType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum ThreadInMaterial
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(boltarray.ThreadInMaterial);
			set { boltarray.ThreadInMaterial = Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(value); }
		}

		public System.Double Length
		{
			get => boltarray.Length;
			set { boltarray.Length = value; }
		}

		public System.Double CutLength
		{
			get => boltarray.CutLength;
			set { boltarray.CutLength = value; }
		}

		public System.Double ExtraLength
		{
			get => boltarray.ExtraLength;
			set { boltarray.ExtraLength = value; }
		}

		public System.Double Tolerance
		{
			get => boltarray.Tolerance;
			set { boltarray.Tolerance = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum HoleType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(boltarray.HoleType);
			set { boltarray.HoleType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(value); }
		}

		public System.Double SlottedHoleX
		{
			get => boltarray.SlottedHoleX;
			set { boltarray.SlottedHoleX = value; }
		}

		public System.Double SlottedHoleY
		{
			get => boltarray.SlottedHoleY;
			set { boltarray.SlottedHoleY = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum RotateSlots
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(boltarray.RotateSlots);
			set { boltarray.RotateSlots = Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => new Dynamic.Tekla.Structures.Model.Position(boltarray.Position);
			set { boltarray.Position = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Offset StartPointOffset
		{
			get => new Dynamic.Tekla.Structures.Model.Offset(boltarray.StartPointOffset);
			set { boltarray.StartPointOffset = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Offset EndPointOffset
		{
			get => new Dynamic.Tekla.Structures.Model.Offset(boltarray.EndPointOffset);
			set { boltarray.EndPointOffset = value.GetTSObject(); }
		}

		public System.Boolean Washer1
		{
			get => boltarray.Washer1;
			set { boltarray.Washer1 = value; }
		}

		public System.Boolean Washer2
		{
			get => boltarray.Washer2;
			set { boltarray.Washer2 = value; }
		}

		public System.Boolean Washer3
		{
			get => boltarray.Washer3;
			set { boltarray.Washer3 = value; }
		}

		public System.Boolean Nut1
		{
			get => boltarray.Nut1;
			set { boltarray.Nut1 = value; }
		}

		public System.Boolean Nut2
		{
			get => boltarray.Nut2;
			set { boltarray.Nut2 = value; }
		}

		public System.Boolean Bolt
		{
			get => boltarray.Bolt;
			set { boltarray.Bolt = value; }
		}

		public System.Boolean Hole1
		{
			get => boltarray.Hole1;
			set { boltarray.Hole1 = value; }
		}

		public System.Boolean Hole2
		{
			get => boltarray.Hole2;
			set { boltarray.Hole2 = value; }
		}

		public System.Boolean Hole3
		{
			get => boltarray.Hole3;
			set { boltarray.Hole3 = value; }
		}

		public System.Boolean Hole4
		{
			get => boltarray.Hole4;
			set { boltarray.Hole4 = value; }
		}

		public System.Boolean Hole5
		{
			get => boltarray.Hole5;
			set { boltarray.Hole5 = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBoltTo
		{
			get => new Dynamic.Tekla.Structures.Model.Part(boltarray.PartToBoltTo);
			set { boltarray.PartToBoltTo = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBeBolted
		{
			get => new Dynamic.Tekla.Structures.Model.Part(boltarray.PartToBeBolted);
			set { boltarray.PartToBeBolted = value.GetTSObject(); }
		}

		public System.Collections.ArrayList OtherPartsToBolt
		{
			get => boltarray.OtherPartsToBolt;
			set { boltarray.OtherPartsToBolt = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstPosition
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(boltarray.FirstPosition);
			set { boltarray.FirstPosition = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondPosition
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(boltarray.SecondPosition);
			set { boltarray.SecondPosition = value.GetTSObject(); }
		}

		public System.Boolean ConnectAssemblies
		{
			get => boltarray.ConnectAssemblies;
			set { boltarray.ConnectAssemblies = value; }
		}

		public System.Collections.ArrayList BoltPositions
		{
			get => boltarray.BoltPositions;
			set { boltarray.BoltPositions = value; }
		}

		public System.DateTime ModificationTime
		{
			get => boltarray.ModificationTime;
			set { boltarray.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => boltarray.IsUpToDate;
			set { boltarray.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(boltarray.Identifier);
			set { boltarray.Identifier = value.GetTSObject(); }
		}

        

        dynamic boltarray;
        
        public BoltArray()
        {
            this.boltarray =  TSActivator.CreateInstance("Tekla.Structures.Model.BoltArray");
        }

        public BoltArray(dynamic tsObject)
        {
            this.boltarray = tsObject;
        }

        internal dynamic GetTSObject() => boltarray;

		public System.Boolean AddBoltDistX(System.Double DistX)
			 => boltarray.AddBoltDistX(DistX);

		public System.Boolean AddBoltDistY(System.Double DistY)
			 => boltarray.AddBoltDistY(DistY);

		public System.Boolean RemoveBoltDistX(System.Int32 Index)
			 => boltarray.RemoveBoltDistX(Index);

		public System.Boolean RemoveBoltDistY(System.Int32 Index)
			 => boltarray.RemoveBoltDistY(Index);

		public System.Int32 GetBoltDistXCount()
			 => boltarray.GetBoltDistXCount();

		public System.Int32 GetBoltDistYCount()
			 => boltarray.GetBoltDistYCount();

		public System.Double GetBoltDistX(System.Int32 Index)
			 => boltarray.GetBoltDistX(Index);

		public System.Double GetBoltDistY(System.Int32 Index)
			 => boltarray.GetBoltDistY(Index);

		public System.Boolean SetBoltDistX(System.Int32 Index, System.Double DistX)
			 => boltarray.SetBoltDistX(Index, DistX);

		public System.Boolean SetBoltDistY(System.Int32 Index, System.Double DistY)
			 => boltarray.SetBoltDistY(Index, DistY);

		public System.Boolean Insert()
			 => boltarray.Insert();

		public System.Boolean Select()
			 => boltarray.Select();

		public System.Boolean Modify()
			 => boltarray.Modify();

		public System.Boolean Delete()
			 => boltarray.Delete();

		public System.Boolean AddOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
			 => boltarray.AddOtherPartToBolt(M.GetTSObject());

		public System.Boolean RemoveOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
			 => boltarray.RemoveOtherPartToBolt(M.GetTSObject());

		public System.Collections.ArrayList GetOtherPartsToBolt()
			 => boltarray.GetOtherPartsToBolt();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(boltarray.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(System.Boolean withHighAccuracy)
			 => new Dynamic.Tekla.Structures.Model.Solid(boltarray.GetSolid(withHighAccuracy));

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => new Dynamic.Tekla.Structures.Model.PourObject(boltarray.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => new Dynamic.Tekla.Structures.Model.PourUnit(boltarray.GetFatherPourUnit());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(boltarray.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(boltarray.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(boltarray.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => boltarray.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => boltarray.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => boltarray.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => boltarray.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => boltarray.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => boltarray.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => boltarray.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => boltarray.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => boltarray.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => boltarray.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => boltarray.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => boltarray.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => boltarray.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => boltarray.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => boltarray.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => boltarray.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => boltarray.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => boltarray.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => boltarray.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(boltarray.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => boltarray.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => boltarray.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => boltarray.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => boltarray.CompareTo(obj);





    }

}
    
