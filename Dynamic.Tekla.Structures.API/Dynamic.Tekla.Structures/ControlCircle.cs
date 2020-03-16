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
			set { controlcircle.Color = Dynamic.Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.ControlObjectLineType LineType
		{
			get => Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(controlcircle.LineType);
			set { controlcircle.LineType = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point1
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(controlcircle.Point1.GetTSObject());
			set { controlcircle.Point1 = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point2
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(controlcircle.Point2.GetTSObject());
			set { controlcircle.Point2 = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Point3
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(controlcircle.Point3.GetTSObject());
			set { controlcircle.Point3 = value.GetTSObject(); }
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
			get => new Dynamic.Tekla.Structures.Identifier(controlcircle.Identifier.GetTSObject());
			set { controlcircle.Identifier = value.GetTSObject(); }
		}

        

        dynamic controlcircle;
        
        public ControlCircle()
        {
            this.controlcircle =  new Tekla.Structures.Model.ControlCircle();
        }

        public ControlCircle(dynamic tsObject)
        {
            this.controlcircle = tsObject;
			this.Extension = controlcircle.Extension;
			this.Color = Dynamic.Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum_.FromTSObject(controlcircle.Color);
			this.LineType = Dynamic.Tekla.Structures.Model.ControlObjectLineType_.FromTSObject(controlcircle.LineType);
			this.Point1 = new Dynamic.Tekla.Structures.Geometry3d.Point(controlcircle.Point1);
			this.Point2 = new Dynamic.Tekla.Structures.Geometry3d.Point(controlcircle.Point2);
			this.Point3 = new Dynamic.Tekla.Structures.Geometry3d.Point(controlcircle.Point3);
			this.ModificationTime = controlcircle.ModificationTime;
			this.IsUpToDate = controlcircle.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(controlcircle.Identifier);

        }


        public dynamic GetTSObject() => controlcircle;

		public System.Boolean Insert()
			 => controlcircle.Insert();

		public System.Boolean Select()
			 => controlcircle.Select();

		public System.Boolean Modify()
			 => controlcircle.Modify();

		public System.Boolean Delete()
			 => controlcircle.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(controlcircle.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(controlcircle.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(controlcircle.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => controlcircle.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => controlcircle.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => controlcircle.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => controlcircle.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => controlcircle.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => controlcircle.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => controlcircle.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => controlcircle.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => controlcircle.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => controlcircle.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => controlcircle.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => controlcircle.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => controlcircle.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => controlcircle.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => controlcircle.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => controlcircle.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => controlcircle.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => controlcircle.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => controlcircle.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(controlcircle.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => controlcircle.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => controlcircle.GetPhase(ref phase.GetTSObject());

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

    public static class ControlCircleColorEnum_
    {
        public static dynamic GetTSObject(ControlCircleColorEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ControlCircleColorEnum");

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

}
    
