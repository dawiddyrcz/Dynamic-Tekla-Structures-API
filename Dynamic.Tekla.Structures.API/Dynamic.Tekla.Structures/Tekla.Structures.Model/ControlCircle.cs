//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ControlCircle 
    {

		public System.Double Extension
		{
			get => controlcircle.Extension;
			set { controlcircle.Extension = value; }
		}

		public Dynamic.Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum Color
		{
			get => Dynamic.Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum_.FromTSObject(controlcircle.Color);
			set { controlcircle.Color = Dynamic.Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ControlObjectLineType LineType
		{
			get => Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(controlcircle.LineType);
			set { controlcircle.LineType = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(controlcircle.Point1);
			set { controlcircle.Point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(controlcircle.Point2);
			set { controlcircle.Point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point3
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(controlcircle.Point3);
			set { controlcircle.Point3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => controlcircle.ModificationTime;
			set { controlcircle.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => controlcircle.IsUpToDate;
			set { controlcircle.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(controlcircle.Identifier);
			set { controlcircle.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic controlcircle;
        
        public ControlCircle()
        {
            this.controlcircle =  TSActivator.CreateInstance("Tekla.Structures.Model.ControlCircle");
        }

        internal ControlCircle(dynamic tsObject)
        {
            this.controlcircle = tsObject;
        }

		public System.Boolean Insert()
			 => controlcircle.Insert();

		public System.Boolean Select()
			 => controlcircle.Select();

		public System.Boolean Modify()
			 => controlcircle.Modify();

		public System.Boolean Delete()
			 => controlcircle.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(controlcircle.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(controlcircle.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(controlcircle.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => controlcircle.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => controlcircle.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => controlcircle.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => controlcircle.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => controlcircle.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => controlcircle.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => controlcircle.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => controlcircle.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => controlcircle.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => controlcircle.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => controlcircle.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => controlcircle.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => controlcircle.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => controlcircle.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => controlcircle.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => controlcircle.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => controlcircle.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => controlcircle.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => controlcircle.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(controlcircle.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => controlcircle.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => controlcircle.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => controlcircle.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => controlcircle.CompareTo(obj);




    public enum ControlCircleColorEnum
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

    internal static class ControlCircleColorEnum_
    {
        public static dynamic GetTSObject(ControlCircleColorEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum").GetType();

            switch (dynEnum)
            {
				case ControlCircleColorEnum.BLACK:
					return System.Enum.Parse(tsType, "BLACK");
				case ControlCircleColorEnum.WHITE:
					return System.Enum.Parse(tsType, "WHITE");
				case ControlCircleColorEnum.RED:
					return System.Enum.Parse(tsType, "RED");
				case ControlCircleColorEnum.GREEN:
					return System.Enum.Parse(tsType, "GREEN");
				case ControlCircleColorEnum.BLUE:
					return System.Enum.Parse(tsType, "BLUE");
				case ControlCircleColorEnum.CYAN:
					return System.Enum.Parse(tsType, "CYAN");
				case ControlCircleColorEnum.YELLOW:
					return System.Enum.Parse(tsType, "YELLOW");
				case ControlCircleColorEnum.MAGENTA:
					return System.Enum.Parse(tsType, "MAGENTA");
				case ControlCircleColorEnum.YELLOW_RED:
					return System.Enum.Parse(tsType, "YELLOW_RED");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ControlCircleColorEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("BLACK", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.BLACK;
			else if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.WHITE;
			else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.RED;
			else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.GREEN;
			else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.BLUE;
			else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.CYAN;
			else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.YELLOW;
			else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.MAGENTA;
			else if (tsEnumValue.Equals("YELLOW_RED", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.YELLOW_RED;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ControlCircle_
    {
        public static dynamic GetTSObject(ControlCircle dynObject)
        {
            return dynObject.controlcircle;
        }

        public static ControlCircle FromTSObject(dynamic tsObject)
        {
            return new ControlCircle(tsObject);
        }
    }


}
    
