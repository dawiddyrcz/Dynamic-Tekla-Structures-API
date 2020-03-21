//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class BoltXYList  : Dynamic.Tekla.Structures.Model.BoltGroup
    {

		public System.Double BoltSize
		{
			get => teklaObject.BoltSize;
			set { teklaObject.BoltSize = value; }
		}

		public System.String BoltStandard
		{
			get => teklaObject.BoltStandard;
			set { teklaObject.BoltStandard = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum BoltType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(teklaObject.BoltType);
			set { teklaObject.BoltType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum ThreadInMaterial
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(teklaObject.ThreadInMaterial);
			set { teklaObject.ThreadInMaterial = Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.GetTSObject(value); }
		}

		public System.Double Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

		public System.Double CutLength
		{
			get => teklaObject.CutLength;
			set { teklaObject.CutLength = value; }
		}

		public System.Double ExtraLength
		{
			get => teklaObject.ExtraLength;
			set { teklaObject.ExtraLength = value; }
		}

		public System.Double Tolerance
		{
			get => teklaObject.Tolerance;
			set { teklaObject.Tolerance = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum HoleType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(teklaObject.HoleType);
			set { teklaObject.HoleType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.GetTSObject(value); }
		}

		public System.Double SlottedHoleX
		{
			get => teklaObject.SlottedHoleX;
			set { teklaObject.SlottedHoleX = value; }
		}

		public System.Double SlottedHoleY
		{
			get => teklaObject.SlottedHoleY;
			set { teklaObject.SlottedHoleY = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum RotateSlots
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(teklaObject.RotateSlots);
			set { teklaObject.RotateSlots = Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => Dynamic.Tekla.Structures.Model.Position_.FromTSObject(teklaObject.Position);
			set { teklaObject.Position = Dynamic.Tekla.Structures.Model.Position_.GetTSObject(value); }
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

		public System.Boolean Washer1
		{
			get => teklaObject.Washer1;
			set { teklaObject.Washer1 = value; }
		}

		public System.Boolean Washer2
		{
			get => teklaObject.Washer2;
			set { teklaObject.Washer2 = value; }
		}

		public System.Boolean Washer3
		{
			get => teklaObject.Washer3;
			set { teklaObject.Washer3 = value; }
		}

		public System.Boolean Nut1
		{
			get => teklaObject.Nut1;
			set { teklaObject.Nut1 = value; }
		}

		public System.Boolean Nut2
		{
			get => teklaObject.Nut2;
			set { teklaObject.Nut2 = value; }
		}

		public System.Boolean Bolt
		{
			get => teklaObject.Bolt;
			set { teklaObject.Bolt = value; }
		}

		public System.Boolean Hole1
		{
			get => teklaObject.Hole1;
			set { teklaObject.Hole1 = value; }
		}

		public System.Boolean Hole2
		{
			get => teklaObject.Hole2;
			set { teklaObject.Hole2 = value; }
		}

		public System.Boolean Hole3
		{
			get => teklaObject.Hole3;
			set { teklaObject.Hole3 = value; }
		}

		public System.Boolean Hole4
		{
			get => teklaObject.Hole4;
			set { teklaObject.Hole4 = value; }
		}

		public System.Boolean Hole5
		{
			get => teklaObject.Hole5;
			set { teklaObject.Hole5 = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBoltTo
		{
			get => Dynamic.Tekla.Structures.Model.Part_.FromTSObject(teklaObject.PartToBoltTo);
			set { teklaObject.PartToBoltTo = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBeBolted
		{
			get => Dynamic.Tekla.Structures.Model.Part_.FromTSObject(teklaObject.PartToBeBolted);
			set { teklaObject.PartToBeBolted = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(value); }
		}

		public System.Collections.ArrayList OtherPartsToBolt
		{
			get => teklaObject.OtherPartsToBolt;
			set { teklaObject.OtherPartsToBolt = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstPosition
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.FirstPosition);
			set { teklaObject.FirstPosition = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondPosition
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.SecondPosition);
			set { teklaObject.SecondPosition = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Boolean ConnectAssemblies
		{
			get => teklaObject.ConnectAssemblies;
			set { teklaObject.ConnectAssemblies = value; }
		}

		public System.Collections.ArrayList BoltPositions
		{
			get => teklaObject.BoltPositions;
			set { teklaObject.BoltPositions = value; }
		}

		public System.DateTime ModificationTime
		{
			get => teklaObject.ModificationTime;
			set { teklaObject.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => teklaObject.IsUpToDate;
			set { teklaObject.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(teklaObject.Identifier);
			set { teklaObject.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public BoltXYList()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltXYList");
		}

		public System.Boolean AddBoltDistX(System.Double DistX)
			 => teklaObject.AddBoltDistX(DistX);

		public System.Boolean AddBoltDistY(System.Double DistY)
			 => teklaObject.AddBoltDistY(DistY);

		public System.Int32 GetBoltDistXCount()
			 => teklaObject.GetBoltDistXCount();

		public System.Int32 GetBoltDistYCount()
			 => teklaObject.GetBoltDistYCount();

		public System.Double GetBoltDistX(System.Int32 Index)
			 => teklaObject.GetBoltDistX(Index);

		public System.Double GetBoltDistY(System.Int32 Index)
			 => teklaObject.GetBoltDistY(Index);

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Select()
			 => teklaObject.Select();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public System.Boolean AddOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
			 => teklaObject.AddOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(M));

		public System.Boolean RemoveOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
			 => teklaObject.RemoveOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part_.GetTSObject(M));

		public System.Collections.ArrayList GetOtherPartsToBolt()
			 => teklaObject.GetOtherPartsToBolt();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(System.Boolean withHighAccuracy)
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(teklaObject.GetSolid(withHighAccuracy));

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => Dynamic.Tekla.Structures.Model.PourObject_.FromTSObject(teklaObject.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(teklaObject.GetFatherPourUnit());

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





    }

    internal static class BoltXYList_
    {
        public static dynamic GetTSObject(BoltXYList dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BoltXYList FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.BoltXYList)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
