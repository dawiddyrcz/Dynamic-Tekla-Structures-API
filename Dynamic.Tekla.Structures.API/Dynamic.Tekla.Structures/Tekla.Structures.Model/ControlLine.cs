//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class ControlLine  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment Line
		{
			get => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.Line);
			set { teklaObject.Line = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value); }
		}

		public System.Boolean IsMagnetic
		{
			get => teklaObject.IsMagnetic;
			set { teklaObject.IsMagnetic = value; }
		}

		public System.Double Extension
		{
			get => teklaObject.Extension;
			set { teklaObject.Extension = value; }
		}

		public Dynamic.Tekla.Structures.Model.ControlLine.ControlLineColorEnum Color
		{
			get => Dynamic.Tekla.Structures.Model.ControlLine.ControlLineColorEnum_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Model.ControlLine.ControlLineColorEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ControlObjectLineType LineType
		{
			get => Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(teklaObject.LineType);
			set { teklaObject.LineType = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.GetTSObject(value); }
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

		public ControlLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine");
		}
		public ControlLine(Dynamic.Tekla.Structures.Geometry3d.LineSegment Line, System.Boolean IsMagnetic)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(Line);
			args[1] = IsMagnetic;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine", args);
		}

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Select()
			 => teklaObject.Select();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

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




    public enum ControlLineColorEnum
    {
			BLACK,
			WHITE,
			RED,
			GREEN,
			BLUE,
			CYAN,
			YELLOW,
			MAGENTA,
			YELLOW_RED        
    }

    internal static class ControlLineColorEnum_
    {
        public static dynamic GetTSObject(ControlLineColorEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine.ControlLineColorEnum").GetType();

            switch (dynEnum)
            {
				case ControlLineColorEnum.BLACK:
					return System.Enum.Parse(tsType, "BLACK");
				case ControlLineColorEnum.WHITE:
					return System.Enum.Parse(tsType, "WHITE");
				case ControlLineColorEnum.RED:
					return System.Enum.Parse(tsType, "RED");
				case ControlLineColorEnum.GREEN:
					return System.Enum.Parse(tsType, "GREEN");
				case ControlLineColorEnum.BLUE:
					return System.Enum.Parse(tsType, "BLUE");
				case ControlLineColorEnum.CYAN:
					return System.Enum.Parse(tsType, "CYAN");
				case ControlLineColorEnum.YELLOW:
					return System.Enum.Parse(tsType, "YELLOW");
				case ControlLineColorEnum.MAGENTA:
					return System.Enum.Parse(tsType, "MAGENTA");
				case ControlLineColorEnum.YELLOW_RED:
					return System.Enum.Parse(tsType, "YELLOW_RED");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ControlLineColorEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BLACK", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.BLACK;
			else if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.WHITE;
			else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.RED;
			else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.GREEN;
			else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.BLUE;
			else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.CYAN;
			else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.YELLOW;
			else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.MAGENTA;
			else if (tsEnumValue.Equals("YELLOW_RED", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.YELLOW_RED;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ControlLine_
    {
        public static dynamic GetTSObject(ControlLine dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ControlLine FromTSObject(dynamic tsObject)
        {
            return new ControlLine() { teklaObject = tsObject };
        }
    }


}
    
