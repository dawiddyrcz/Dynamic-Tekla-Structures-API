//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarSplice 
    {

		public Dynamic.Tekla.Structures.Model.Reinforcement RebarGroup1
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement_.FromTSObject(rebarsplice.RebarGroup1);
			set { rebarsplice.RebarGroup1 = Dynamic.Tekla.Structures.Model.Reinforcement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Reinforcement RebarGroup2
		{
			get => Dynamic.Tekla.Structures.Model.Reinforcement_.FromTSObject(rebarsplice.RebarGroup2);
			set { rebarsplice.RebarGroup2 = Dynamic.Tekla.Structures.Model.Reinforcement_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceTypeEnum Type
		{
			get => Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceTypeEnum_.FromTSObject(rebarsplice.Type);
			set { rebarsplice.Type = Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceTypeEnum_.GetTSObject(value); }
		}

		public System.Double LapLength
		{
			get => rebarsplice.LapLength;
			set { rebarsplice.LapLength = value; }
		}

		public System.Double Offset
		{
			get => rebarsplice.Offset;
			set { rebarsplice.Offset = value; }
		}

		public System.Double Clearance
		{
			get => rebarsplice.Clearance;
			set { rebarsplice.Clearance = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceBarPositionsEnum BarPositions
		{
			get => Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceBarPositionsEnum_.FromTSObject(rebarsplice.BarPositions);
			set { rebarsplice.BarPositions = Dynamic.Tekla.Structures.Model.RebarSplice.RebarSpliceBarPositionsEnum_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => rebarsplice.ModificationTime;
			set { rebarsplice.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => rebarsplice.IsUpToDate;
			set { rebarsplice.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(rebarsplice.Identifier);
			set { rebarsplice.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic rebarsplice;
        
        public RebarSplice()
        {
            this.rebarsplice =  TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplice");
        }

        internal RebarSplice(dynamic tsObject)
        {
            this.rebarsplice = tsObject;
        }

		public System.Boolean Insert()
			 => rebarsplice.Insert();

		public System.Boolean Select()
			 => rebarsplice.Select();

		public System.Boolean Modify()
			 => rebarsplice.Modify();

		public System.Boolean Delete()
			 => rebarsplice.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(rebarsplice.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(rebarsplice.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(rebarsplice.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => rebarsplice.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => rebarsplice.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => rebarsplice.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => rebarsplice.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => rebarsplice.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => rebarsplice.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => rebarsplice.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => rebarsplice.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => rebarsplice.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => rebarsplice.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => rebarsplice.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => rebarsplice.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => rebarsplice.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => rebarsplice.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => rebarsplice.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => rebarsplice.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => rebarsplice.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => rebarsplice.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => rebarsplice.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(rebarsplice.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => rebarsplice.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => rebarsplice.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => rebarsplice.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => rebarsplice.CompareTo(obj);




    public enum RebarSpliceTypeEnum
    {
			SPLICE_TYPE_LAP_RIGHT,
			SPLICE_TYPE_LAP_LEFT,
			SPLICE_TYPE_LAP_BOTH,
			SPLICE_TYPE_MUFF,
			SPLICE_TYPE_WELD        
    }

    internal static class RebarSpliceTypeEnum_
    {
        public static dynamic GetTSObject(RebarSpliceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpliceTypeEnum");

            switch (dynEnum)
            {
				case RebarSpliceTypeEnum.SPLICE_TYPE_LAP_RIGHT:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_LAP_RIGHT");
				case RebarSpliceTypeEnum.SPLICE_TYPE_LAP_LEFT:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_LAP_LEFT");
				case RebarSpliceTypeEnum.SPLICE_TYPE_LAP_BOTH:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_LAP_BOTH");
				case RebarSpliceTypeEnum.SPLICE_TYPE_MUFF:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_MUFF");
				case RebarSpliceTypeEnum.SPLICE_TYPE_WELD:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_WELD");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarSpliceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPLICE_TYPE_LAP_RIGHT", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_LAP_RIGHT;
			else if (tsEnumValue.Equals("SPLICE_TYPE_LAP_LEFT", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_LAP_LEFT;
			else if (tsEnumValue.Equals("SPLICE_TYPE_LAP_BOTH", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_LAP_BOTH;
			else if (tsEnumValue.Equals("SPLICE_TYPE_MUFF", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_MUFF;
			else if (tsEnumValue.Equals("SPLICE_TYPE_WELD", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_WELD;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarSpliceBarPositionsEnum
    {
			SPLICE_BAR_ON_TOP,
			SPLICE_BAR_PARALLEL        
    }

    internal static class RebarSpliceBarPositionsEnum_
    {
        public static dynamic GetTSObject(RebarSpliceBarPositionsEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpliceBarPositionsEnum");

            switch (dynEnum)
            {
				case RebarSpliceBarPositionsEnum.SPLICE_BAR_ON_TOP:
					return System.Enum.Parse(tsType, "SPLICE_BAR_ON_TOP");
				case RebarSpliceBarPositionsEnum.SPLICE_BAR_PARALLEL:
					return System.Enum.Parse(tsType, "SPLICE_BAR_PARALLEL");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarSpliceBarPositionsEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPLICE_BAR_ON_TOP", System.StringComparison.InvariantCulture))
				return RebarSpliceBarPositionsEnum.SPLICE_BAR_ON_TOP;
			else if (tsEnumValue.Equals("SPLICE_BAR_PARALLEL", System.StringComparison.InvariantCulture))
				return RebarSpliceBarPositionsEnum.SPLICE_BAR_PARALLEL;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarSplice_
    {
        public static dynamic GetTSObject(RebarSplice dynObject)
        {
            return dynObject.rebarsplice;
        }

        public static RebarSplice FromTSObject(dynamic tsObject)
        {
            return new RebarSplice(tsObject);
        }
    }


}
    
