//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class LoadLine 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Position1
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(loadline.Position1.GetTSObject());
			set { loadline.Position1 = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position2
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(loadline.Position2.GetTSObject());
			set { loadline.Position2 = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P1
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(loadline.P1.GetTSObject());
			set { loadline.P1 = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P2
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(loadline.P2.GetTSObject());
			set { loadline.P2 = value.GetTSObject(); }
		}

		public System.Double Torsion1
		{
			get => loadline.Torsion1;
			set { loadline.Torsion1 = value; }
		}

		public System.Double Torsion2
		{
			get => loadline.Torsion2;
			set { loadline.Torsion2 = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoadLine.LineLoadFormEnum LoadForm
		{
			get => Dynamic.Tekla.Structures.Model.LoadLine.LineLoadFormEnum_.FromTSObject(loadline.LoadForm);
			set { loadline.LoadForm = Dynamic.Tekla.Structures.Model.LoadLine.LineLoadFormEnum_.FromTSObject(value); }
		}

		public System.Double DistanceA
		{
			get => loadline.DistanceA;
			set { loadline.DistanceA = value; }
		}

		public System.Double DistanceB
		{
			get => loadline.DistanceB;
			set { loadline.DistanceB = value; }
		}

		public Dynamic.Tekla.Structures.Identifier FatherId
		{
			get => new Dynamic.Tekla.Structures.Identifier(loadline.FatherId.GetTSObject());
			set { loadline.FatherId = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(loadline.Spanning);
			set { loadline.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(loadline.PrimaryAxisDirection.GetTSObject());
			set { loadline.PrimaryAxisDirection = value.GetTSObject(); }
		}

		public System.Boolean AutomaticPrimaryAxisWeight
		{
			get => loadline.AutomaticPrimaryAxisWeight;
			set { loadline.AutomaticPrimaryAxisWeight = value; }
		}

		public System.Double Weight
		{
			get => loadline.Weight;
			set { loadline.Weight = value; }
		}

		public System.Double LoadDispersionAngle
		{
			get => loadline.LoadDispersionAngle;
			set { loadline.LoadDispersionAngle = value; }
		}

		public System.Boolean CreateFixedSupportConditionsAutomatically
		{
			get => loadline.CreateFixedSupportConditionsAutomatically;
			set { loadline.CreateFixedSupportConditionsAutomatically = value; }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum LoadAttachment
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(loadline.LoadAttachment);
			set { loadline.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum PartNames
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(loadline.PartNames);
			set { loadline.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(value); }
		}

		public System.String PartFilter
		{
			get => loadline.PartFilter;
			set { loadline.PartFilter = value; }
		}

		public System.Double BoundingBoxDx
		{
			get => loadline.BoundingBoxDx;
			set { loadline.BoundingBoxDx = value; }
		}

		public System.Double BoundingBoxDy
		{
			get => loadline.BoundingBoxDy;
			set { loadline.BoundingBoxDy = value; }
		}

		public System.Double BoundingBoxDz
		{
			get => loadline.BoundingBoxDz;
			set { loadline.BoundingBoxDz = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup Group
		{
			get => new Dynamic.Tekla.Structures.Model.LoadGroup(loadline.Group.GetTSObject());
			set { loadline.Group = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => loadline.ModificationTime;
			set { loadline.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => loadline.IsUpToDate;
			set { loadline.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(loadline.Identifier.GetTSObject());
			set { loadline.Identifier = value.GetTSObject(); }
		}

        

        dynamic loadline;
        
        public LoadLine()
        {
            this.loadline =  TSActivator.CreateInstance("Tekla.Structures.Model.LoadLine");
        }

        public LoadLine(dynamic tsObject)
        {
            this.loadline = tsObject;
			this.Position1 = new Dynamic.Tekla.Structures.Geometry3d.Point(loadline.Position1);
			this.Position2 = new Dynamic.Tekla.Structures.Geometry3d.Point(loadline.Position2);
			this.P1 = new Dynamic.Tekla.Structures.Geometry3d.Vector(loadline.P1);
			this.P2 = new Dynamic.Tekla.Structures.Geometry3d.Vector(loadline.P2);
			this.Torsion1 = loadline.Torsion1;
			this.Torsion2 = loadline.Torsion2;
			this.LoadForm = Dynamic.Tekla.Structures.Model.LoadLine.LineLoadFormEnum_.FromTSObject(loadline.LoadForm);
			this.DistanceA = loadline.DistanceA;
			this.DistanceB = loadline.DistanceB;
			this.FatherId = new Dynamic.Tekla.Structures.Identifier(loadline.FatherId);
			this.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(loadline.Spanning);
			this.PrimaryAxisDirection = new Dynamic.Tekla.Structures.Geometry3d.Vector(loadline.PrimaryAxisDirection);
			this.AutomaticPrimaryAxisWeight = loadline.AutomaticPrimaryAxisWeight;
			this.Weight = loadline.Weight;
			this.LoadDispersionAngle = loadline.LoadDispersionAngle;
			this.CreateFixedSupportConditionsAutomatically = loadline.CreateFixedSupportConditionsAutomatically;
			this.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(loadline.LoadAttachment);
			this.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(loadline.PartNames);
			this.PartFilter = loadline.PartFilter;
			this.BoundingBoxDx = loadline.BoundingBoxDx;
			this.BoundingBoxDy = loadline.BoundingBoxDy;
			this.BoundingBoxDz = loadline.BoundingBoxDz;
			this.Group = new Dynamic.Tekla.Structures.Model.LoadGroup(loadline.Group);
			this.ModificationTime = loadline.ModificationTime;
			this.IsUpToDate = loadline.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(loadline.Identifier);

        }


        public dynamic GetTSObject() => loadline;

		public System.Boolean Insert()
			 => loadline.Insert();

		public System.Boolean Select()
			 => loadline.Select();

		public System.Boolean Modify()
			 => loadline.Modify();

		public System.Boolean Delete()
			 => loadline.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(loadline.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(loadline.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(loadline.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => loadline.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => loadline.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => loadline.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => loadline.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => loadline.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadline.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadline.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadline.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => loadline.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => loadline.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => loadline.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => loadline.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => loadline.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => loadline.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => loadline.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => loadline.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => loadline.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => loadline.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => loadline.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(loadline.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loadline.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loadline.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => loadline.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => loadline.CompareTo(obj);




    public enum LineLoadFormEnum
    {
			LOAD_FORM_LINE_1,
			LOAD_FORM_LINE_2,
			LOAD_FORM_LINE_3,
			LOAD_FORM_LINE_4        
    }

    public static class LineLoadFormEnum_
    {
        public static dynamic GetTSObject(LineLoadFormEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LineLoadFormEnum");

            switch (dynEnum)
            {
				case LineLoadFormEnum.LOAD_FORM_LINE_1:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_1");
				case LineLoadFormEnum.LOAD_FORM_LINE_2:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_2");
				case LineLoadFormEnum.LOAD_FORM_LINE_3:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_3");
				case LineLoadFormEnum.LOAD_FORM_LINE_4:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_4");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LineLoadFormEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOAD_FORM_LINE_1", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_1;
			else if (tsEnumValue.Equals("LOAD_FORM_LINE_2", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_2;
			else if (tsEnumValue.Equals("LOAD_FORM_LINE_3", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_3;
			else if (tsEnumValue.Equals("LOAD_FORM_LINE_4", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_4;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
