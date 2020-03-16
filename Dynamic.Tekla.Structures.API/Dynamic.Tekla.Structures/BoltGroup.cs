//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class BoltGroup 
    {

		public System.Double BoltSize
		{
			get => boltgroup.BoltSize;
			set { boltgroup.BoltSize = value; }
		}

		public System.String BoltStandard
		{
			get => boltgroup.BoltStandard;
			set { boltgroup.BoltStandard = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum BoltType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(boltgroup.BoltType);
			set { boltgroup.BoltType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum ThreadInMaterial
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(boltgroup.ThreadInMaterial);
			set { boltgroup.ThreadInMaterial = Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(value); }
		}

		public System.Double Length
		{
			get => boltgroup.Length;
			set { boltgroup.Length = value; }
		}

		public System.Double CutLength
		{
			get => boltgroup.CutLength;
			set { boltgroup.CutLength = value; }
		}

		public System.Double ExtraLength
		{
			get => boltgroup.ExtraLength;
			set { boltgroup.ExtraLength = value; }
		}

		public System.Double Tolerance
		{
			get => boltgroup.Tolerance;
			set { boltgroup.Tolerance = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum HoleType
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(boltgroup.HoleType);
			set { boltgroup.HoleType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(value); }
		}

		public System.Double SlottedHoleX
		{
			get => boltgroup.SlottedHoleX;
			set { boltgroup.SlottedHoleX = value; }
		}

		public System.Double SlottedHoleY
		{
			get => boltgroup.SlottedHoleY;
			set { boltgroup.SlottedHoleY = value; }
		}

		public Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum RotateSlots
		{
			get => Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(boltgroup.RotateSlots);
			set { boltgroup.RotateSlots = Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => new Dynamic.Tekla.Structures.Model.Position(boltgroup.Position.GetTSObject());
			set { boltgroup.Position = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Offset StartPointOffset
		{
			get => new Dynamic.Tekla.Structures.Model.Offset(boltgroup.StartPointOffset.GetTSObject());
			set { boltgroup.StartPointOffset = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Offset EndPointOffset
		{
			get => new Dynamic.Tekla.Structures.Model.Offset(boltgroup.EndPointOffset.GetTSObject());
			set { boltgroup.EndPointOffset = value.GetTSObject(); }
		}

		public System.Boolean Washer1
		{
			get => boltgroup.Washer1;
			set { boltgroup.Washer1 = value; }
		}

		public System.Boolean Washer2
		{
			get => boltgroup.Washer2;
			set { boltgroup.Washer2 = value; }
		}

		public System.Boolean Washer3
		{
			get => boltgroup.Washer3;
			set { boltgroup.Washer3 = value; }
		}

		public System.Boolean Nut1
		{
			get => boltgroup.Nut1;
			set { boltgroup.Nut1 = value; }
		}

		public System.Boolean Nut2
		{
			get => boltgroup.Nut2;
			set { boltgroup.Nut2 = value; }
		}

		public System.Boolean Bolt
		{
			get => boltgroup.Bolt;
			set { boltgroup.Bolt = value; }
		}

		public System.Boolean Hole1
		{
			get => boltgroup.Hole1;
			set { boltgroup.Hole1 = value; }
		}

		public System.Boolean Hole2
		{
			get => boltgroup.Hole2;
			set { boltgroup.Hole2 = value; }
		}

		public System.Boolean Hole3
		{
			get => boltgroup.Hole3;
			set { boltgroup.Hole3 = value; }
		}

		public System.Boolean Hole4
		{
			get => boltgroup.Hole4;
			set { boltgroup.Hole4 = value; }
		}

		public System.Boolean Hole5
		{
			get => boltgroup.Hole5;
			set { boltgroup.Hole5 = value; }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBoltTo
		{
			get => new Dynamic.Tekla.Structures.Model.Part(boltgroup.PartToBoltTo.GetTSObject());
			set { boltgroup.PartToBoltTo = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Part PartToBeBolted
		{
			get => new Dynamic.Tekla.Structures.Model.Part(boltgroup.PartToBeBolted.GetTSObject());
			set { boltgroup.PartToBeBolted = value.GetTSObject(); }
		}

		public System.Collections.ArrayList OtherPartsToBolt
		{
			get => boltgroup.OtherPartsToBolt;
			set { boltgroup.OtherPartsToBolt = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point FirstPosition
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(boltgroup.FirstPosition.GetTSObject());
			set { boltgroup.FirstPosition = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point SecondPosition
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(boltgroup.SecondPosition.GetTSObject());
			set { boltgroup.SecondPosition = value.GetTSObject(); }
		}

		public System.Boolean ConnectAssemblies
		{
			get => boltgroup.ConnectAssemblies;
			set { boltgroup.ConnectAssemblies = value; }
		}

		public System.Collections.ArrayList BoltPositions
		{
			get => boltgroup.BoltPositions;
			set { boltgroup.BoltPositions = value; }
		}

		public System.NullableSystem.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089<System.DateTime> ModificationTime
		{
			get => boltgroup.ModificationTime;
			set { boltgroup.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => boltgroup.IsUpToDate;
			set { boltgroup.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(boltgroup.Identifier.GetTSObject());
			set { boltgroup.Identifier = value.GetTSObject(); }
		}

        

        dynamic boltgroup;
        
        public BoltGroup()
        {
            this.boltgroup =  new Tekla.Structures.Model.BoltGroup();
        }

        public BoltGroup(dynamic tsObject)
        {
            this.boltgroup = tsObject;
			this.BoltSize = boltgroup.BoltSize;
			this.BoltStandard = boltgroup.BoltStandard;
			this.BoltType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltTypeEnum_.FromTSObject(boltgroup.BoltType);
			this.ThreadInMaterial = Dynamic.Tekla.Structures.Model.BoltGroup.BoltThreadInMaterialEnum_.FromTSObject(boltgroup.ThreadInMaterial);
			this.Length = boltgroup.Length;
			this.CutLength = boltgroup.CutLength;
			this.ExtraLength = boltgroup.ExtraLength;
			this.Tolerance = boltgroup.Tolerance;
			this.HoleType = Dynamic.Tekla.Structures.Model.BoltGroup.BoltHoleTypeEnum_.FromTSObject(boltgroup.HoleType);
			this.SlottedHoleX = boltgroup.SlottedHoleX;
			this.SlottedHoleY = boltgroup.SlottedHoleY;
			this.RotateSlots = Dynamic.Tekla.Structures.Model.BoltGroup.BoltRotateSlotsEnum_.FromTSObject(boltgroup.RotateSlots);
			this.Position = new Dynamic.Tekla.Structures.Model.Position(boltgroup.Position);
			this.StartPointOffset = new Dynamic.Tekla.Structures.Model.Offset(boltgroup.StartPointOffset);
			this.EndPointOffset = new Dynamic.Tekla.Structures.Model.Offset(boltgroup.EndPointOffset);
			this.Washer1 = boltgroup.Washer1;
			this.Washer2 = boltgroup.Washer2;
			this.Washer3 = boltgroup.Washer3;
			this.Nut1 = boltgroup.Nut1;
			this.Nut2 = boltgroup.Nut2;
			this.Bolt = boltgroup.Bolt;
			this.Hole1 = boltgroup.Hole1;
			this.Hole2 = boltgroup.Hole2;
			this.Hole3 = boltgroup.Hole3;
			this.Hole4 = boltgroup.Hole4;
			this.Hole5 = boltgroup.Hole5;
			this.PartToBoltTo = new Dynamic.Tekla.Structures.Model.Part(boltgroup.PartToBoltTo);
			this.PartToBeBolted = new Dynamic.Tekla.Structures.Model.Part(boltgroup.PartToBeBolted);
			this.OtherPartsToBolt = boltgroup.OtherPartsToBolt;
			this.FirstPosition = new Dynamic.Tekla.Structures.Geometry3d.Point(boltgroup.FirstPosition);
			this.SecondPosition = new Dynamic.Tekla.Structures.Geometry3d.Point(boltgroup.SecondPosition);
			this.ConnectAssemblies = boltgroup.ConnectAssemblies;
			this.BoltPositions = boltgroup.BoltPositions;
			this.ModificationTime = boltgroup.ModificationTime;
			this.IsUpToDate = boltgroup.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(boltgroup.Identifier);

        }


        public dynamic GetTSObject() => boltgroup;

		public System.Boolean AddOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
			 => boltgroup.AddOtherPartToBolt(M.GetTSObject());

		public System.Boolean RemoveOtherPartToBolt(Dynamic.Tekla.Structures.Model.Part M)
			 => boltgroup.RemoveOtherPartToBolt(M.GetTSObject());

		public System.Collections.ArrayList GetOtherPartsToBolt()
			 => boltgroup.GetOtherPartsToBolt();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(boltgroup.GetSolid());

		public Dynamic.Tekla.Structures.Model.Solid GetSolid(System.Boolean withHighAccuracy)
			 => new Dynamic.Tekla.Structures.Model.Solid(boltgroup.GetSolid(withHighAccuracy));

		public Dynamic.Tekla.Structures.Model.PourObject GetFatherPour()
			 => new Dynamic.Tekla.Structures.Model.PourObject(boltgroup.GetFatherPour());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => new Dynamic.Tekla.Structures.Model.PourUnit(boltgroup.GetFatherPourUnit());

		public System.Boolean Insert()
			 => boltgroup.Insert();

		public System.Boolean Select()
			 => boltgroup.Select();

		public System.Boolean Modify()
			 => boltgroup.Modify();

		public System.Boolean Delete()
			 => boltgroup.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(boltgroup.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(boltgroup.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(boltgroup.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => boltgroup.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => boltgroup.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => boltgroup.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => boltgroup.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => boltgroup.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => boltgroup.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => boltgroup.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => boltgroup.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => boltgroup.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => boltgroup.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => boltgroup.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => boltgroup.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => boltgroup.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => boltgroup.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => boltgroup.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => boltgroup.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => boltgroup.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => boltgroup.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => boltgroup.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(boltgroup.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => boltgroup.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => boltgroup.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => boltgroup.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => boltgroup.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => boltgroup.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => boltgroup.Equals(obj);

		public System.Int32 GetHashCode()
			 => boltgroup.GetHashCode();

		public System.Type GetType()
			 => boltgroup.GetType();

		public System.String ToString()
			 => boltgroup.ToString();




    public enum BoltTypeEnum
    {
			BOLT_TYPE_SITE,
			BOLT_TYPE_WORKSHOP        
    }

    public static class BoltTypeEnum_
    {
        public static dynamic GetTSObject(BoltTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltTypeEnum");

            switch (dynEnum)
            {
				case BoltTypeEnum.BOLT_TYPE_SITE:
					return System.Enum.Parse(tsType, "BOLT_TYPE_SITE");
				case BoltTypeEnum.BOLT_TYPE_WORKSHOP:
					return System.Enum.Parse(tsType, "BOLT_TYPE_WORKSHOP");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BOLT_TYPE_SITE", System.StringComparison.InvariantCulture))
				return BoltTypeEnum.BOLT_TYPE_SITE;
			else if (tsEnumValue.Equals("BOLT_TYPE_WORKSHOP", System.StringComparison.InvariantCulture))
				return BoltTypeEnum.BOLT_TYPE_WORKSHOP;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum BoltThreadInMaterialEnum
    {
			THREAD_IN_MATERIAL_NO,
			THREAD_IN_MATERIAL_YES        
    }

    public static class BoltThreadInMaterialEnum_
    {
        public static dynamic GetTSObject(BoltThreadInMaterialEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltThreadInMaterialEnum");

            switch (dynEnum)
            {
				case BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO:
					return System.Enum.Parse(tsType, "THREAD_IN_MATERIAL_NO");
				case BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_YES:
					return System.Enum.Parse(tsType, "THREAD_IN_MATERIAL_YES");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltThreadInMaterialEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("THREAD_IN_MATERIAL_NO", System.StringComparison.InvariantCulture))
				return BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO;
			else if (tsEnumValue.Equals("THREAD_IN_MATERIAL_YES", System.StringComparison.InvariantCulture))
				return BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_YES;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum BoltHoleTypeEnum
    {
			HOLE_TYPE_OVERSIZED,
			HOLE_TYPE_SLOTTED,
			HOLE_TYPE_NO_HOLE        
    }

    public static class BoltHoleTypeEnum_
    {
        public static dynamic GetTSObject(BoltHoleTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltHoleTypeEnum");

            switch (dynEnum)
            {
				case BoltHoleTypeEnum.HOLE_TYPE_OVERSIZED:
					return System.Enum.Parse(tsType, "HOLE_TYPE_OVERSIZED");
				case BoltHoleTypeEnum.HOLE_TYPE_SLOTTED:
					return System.Enum.Parse(tsType, "HOLE_TYPE_SLOTTED");
				case BoltHoleTypeEnum.HOLE_TYPE_NO_HOLE:
					return System.Enum.Parse(tsType, "HOLE_TYPE_NO_HOLE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltHoleTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("HOLE_TYPE_OVERSIZED", System.StringComparison.InvariantCulture))
				return BoltHoleTypeEnum.HOLE_TYPE_OVERSIZED;
			else if (tsEnumValue.Equals("HOLE_TYPE_SLOTTED", System.StringComparison.InvariantCulture))
				return BoltHoleTypeEnum.HOLE_TYPE_SLOTTED;
			else if (tsEnumValue.Equals("HOLE_TYPE_NO_HOLE", System.StringComparison.InvariantCulture))
				return BoltHoleTypeEnum.HOLE_TYPE_NO_HOLE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum BoltRotateSlotsEnum
    {
			ROTATE_SLOTS_ODD,
			ROTATE_SLOTS_EVEN,
			ROTATE_SLOTS_PARALLEL        
    }

    public static class BoltRotateSlotsEnum_
    {
        public static dynamic GetTSObject(BoltRotateSlotsEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BoltRotateSlotsEnum");

            switch (dynEnum)
            {
				case BoltRotateSlotsEnum.ROTATE_SLOTS_ODD:
					return System.Enum.Parse(tsType, "ROTATE_SLOTS_ODD");
				case BoltRotateSlotsEnum.ROTATE_SLOTS_EVEN:
					return System.Enum.Parse(tsType, "ROTATE_SLOTS_EVEN");
				case BoltRotateSlotsEnum.ROTATE_SLOTS_PARALLEL:
					return System.Enum.Parse(tsType, "ROTATE_SLOTS_PARALLEL");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static BoltRotateSlotsEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ROTATE_SLOTS_ODD", System.StringComparison.InvariantCulture))
				return BoltRotateSlotsEnum.ROTATE_SLOTS_ODD;
			else if (tsEnumValue.Equals("ROTATE_SLOTS_EVEN", System.StringComparison.InvariantCulture))
				return BoltRotateSlotsEnum.ROTATE_SLOTS_EVEN;
			else if (tsEnumValue.Equals("ROTATE_SLOTS_PARALLEL", System.StringComparison.InvariantCulture))
				return BoltRotateSlotsEnum.ROTATE_SLOTS_PARALLEL;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
