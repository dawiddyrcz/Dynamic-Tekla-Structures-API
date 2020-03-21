//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarPropertyModifier  : Dynamic.Tekla.Structures.Model.BaseRebarModifier
    {

		public Dynamic.Tekla.Structures.Model.RebarPropertiesNullable RebarProperties
		{
			get => Dynamic.Tekla.Structures.Model.RebarPropertiesNullable_.FromTSObject(teklaObject.RebarProperties);
			set { teklaObject.RebarProperties = Dynamic.Tekla.Structures.Model.RebarPropertiesNullable_.GetTSObject(value); }
		}

		public Tekla.Structures.Model.RebarPropertyModifier.GroupingTypeEnum GroupingType
		{
			get => teklaObject.GroupingType;
			set { teklaObject.GroupingType = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarSet Father
		{
			get => Dynamic.Tekla.Structures.Model.RebarSet_.FromTSObject(teklaObject.Father);
			set { teklaObject.Father = Dynamic.Tekla.Structures.Model.RebarSet_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Contour Curve
		{
			get => Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Curve);
			set { teklaObject.Curve = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.BaseRebarModifier.BarsAffectedEnum BarsAffected
		{
			get => Dynamic.Tekla.Structures.Model.BaseRebarModifier.BarsAffectedEnum_.FromTSObject(teklaObject.BarsAffected);
			set { teklaObject.BarsAffected = Dynamic.Tekla.Structures.Model.BaseRebarModifier.BarsAffectedEnum_.GetTSObject(value); }
		}

		public System.Int32 FirstAffectedBar
		{
			get => teklaObject.FirstAffectedBar;
			set { teklaObject.FirstAffectedBar = value; }
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

		public RebarPropertyModifier()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarPropertyModifier");
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetAffectedBars()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetAffectedBars());

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public System.Boolean Select()
			 => teklaObject.Select();

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




    public enum GroupingTypeEnum
    {
			AUTOMATIC,
			MANUAL,
			NO_GROUPING        
    }

    internal static class GroupingTypeEnum_
    {
        public static dynamic GetTSObject(GroupingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarPropertyModifier.GroupingTypeEnum").GetType();

            switch (dynEnum)
            {
				case GroupingTypeEnum.AUTOMATIC:
					return System.Enum.Parse(tsType, "AUTOMATIC");
				case GroupingTypeEnum.MANUAL:
					return System.Enum.Parse(tsType, "MANUAL");
				case GroupingTypeEnum.NO_GROUPING:
					return System.Enum.Parse(tsType, "NO_GROUPING");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static GroupingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("AUTOMATIC", System.StringComparison.InvariantCulture))
				return GroupingTypeEnum.AUTOMATIC;
			else if (tsEnumValue.Equals("MANUAL", System.StringComparison.InvariantCulture))
				return GroupingTypeEnum.MANUAL;
			else if (tsEnumValue.Equals("NO_GROUPING", System.StringComparison.InvariantCulture))
				return GroupingTypeEnum.NO_GROUPING;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarPropertyModifier_
    {
        public static dynamic GetTSObject(RebarPropertyModifier dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarPropertyModifier FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.RebarPropertyModifier)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
