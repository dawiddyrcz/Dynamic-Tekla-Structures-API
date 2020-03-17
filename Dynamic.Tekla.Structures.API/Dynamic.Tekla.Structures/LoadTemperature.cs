//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class LoadTemperature 
    {

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(loadtemperature.Spanning);
			set { loadtemperature.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(loadtemperature.PrimaryAxisDirection.GetTSObject());
			set { loadtemperature.PrimaryAxisDirection = value.GetTSObject(); }
		}

		public System.Boolean AutomaticPrimaryAxisWeight
		{
			get => loadtemperature.AutomaticPrimaryAxisWeight;
			set { loadtemperature.AutomaticPrimaryAxisWeight = value; }
		}

		public System.Double Weight
		{
			get => loadtemperature.Weight;
			set { loadtemperature.Weight = value; }
		}

		public System.Double LoadDispersionAngle
		{
			get => loadtemperature.LoadDispersionAngle;
			set { loadtemperature.LoadDispersionAngle = value; }
		}

		public System.Boolean CreateFixedSupportConditionsAutomatically
		{
			get => loadtemperature.CreateFixedSupportConditionsAutomatically;
			set { loadtemperature.CreateFixedSupportConditionsAutomatically = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position1
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(loadtemperature.Position1.GetTSObject());
			set { loadtemperature.Position1 = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position2
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(loadtemperature.Position2.GetTSObject());
			set { loadtemperature.Position2 = value.GetTSObject(); }
		}

		public System.Double TemperatureChangeForAxialElongation
		{
			get => loadtemperature.TemperatureChangeForAxialElongation;
			set { loadtemperature.TemperatureChangeForAxialElongation = value; }
		}

		public System.Double TemperatureDifferentialTopToBottom
		{
			get => loadtemperature.TemperatureDifferentialTopToBottom;
			set { loadtemperature.TemperatureDifferentialTopToBottom = value; }
		}

		public System.Double TemperatureDifferentialSideToSide
		{
			get => loadtemperature.TemperatureDifferentialSideToSide;
			set { loadtemperature.TemperatureDifferentialSideToSide = value; }
		}

		public System.Double InitialAxialElongation
		{
			get => loadtemperature.InitialAxialElongation;
			set { loadtemperature.InitialAxialElongation = value; }
		}

		public Dynamic.Tekla.Structures.Identifier FatherId
		{
			get => new Dynamic.Tekla.Structures.Identifier(loadtemperature.FatherId.GetTSObject());
			set { loadtemperature.FatherId = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum LoadAttachment
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(loadtemperature.LoadAttachment);
			set { loadtemperature.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum PartNames
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(loadtemperature.PartNames);
			set { loadtemperature.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(value); }
		}

		public System.String PartFilter
		{
			get => loadtemperature.PartFilter;
			set { loadtemperature.PartFilter = value; }
		}

		public System.Double BoundingBoxDx
		{
			get => loadtemperature.BoundingBoxDx;
			set { loadtemperature.BoundingBoxDx = value; }
		}

		public System.Double BoundingBoxDy
		{
			get => loadtemperature.BoundingBoxDy;
			set { loadtemperature.BoundingBoxDy = value; }
		}

		public System.Double BoundingBoxDz
		{
			get => loadtemperature.BoundingBoxDz;
			set { loadtemperature.BoundingBoxDz = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup Group
		{
			get => new Dynamic.Tekla.Structures.Model.LoadGroup(loadtemperature.Group.GetTSObject());
			set { loadtemperature.Group = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => loadtemperature.ModificationTime;
			set { loadtemperature.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => loadtemperature.IsUpToDate;
			set { loadtemperature.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(loadtemperature.Identifier.GetTSObject());
			set { loadtemperature.Identifier = value.GetTSObject(); }
		}

        

        dynamic loadtemperature;
        
        public LoadTemperature()
        {
            this.loadtemperature =  TSActivator.CreateInstance("Tekla.Structures.Model.LoadTemperature");
        }

        public LoadTemperature(dynamic tsObject)
        {
            this.loadtemperature = tsObject;
			this.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(loadtemperature.Spanning);
			this.PrimaryAxisDirection = new Dynamic.Tekla.Structures.Geometry3d.Vector(loadtemperature.PrimaryAxisDirection);
			this.AutomaticPrimaryAxisWeight = loadtemperature.AutomaticPrimaryAxisWeight;
			this.Weight = loadtemperature.Weight;
			this.LoadDispersionAngle = loadtemperature.LoadDispersionAngle;
			this.CreateFixedSupportConditionsAutomatically = loadtemperature.CreateFixedSupportConditionsAutomatically;
			this.Position1 = new Dynamic.Tekla.Structures.Geometry3d.Point(loadtemperature.Position1);
			this.Position2 = new Dynamic.Tekla.Structures.Geometry3d.Point(loadtemperature.Position2);
			this.TemperatureChangeForAxialElongation = loadtemperature.TemperatureChangeForAxialElongation;
			this.TemperatureDifferentialTopToBottom = loadtemperature.TemperatureDifferentialTopToBottom;
			this.TemperatureDifferentialSideToSide = loadtemperature.TemperatureDifferentialSideToSide;
			this.InitialAxialElongation = loadtemperature.InitialAxialElongation;
			this.FatherId = new Dynamic.Tekla.Structures.Identifier(loadtemperature.FatherId);
			this.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(loadtemperature.LoadAttachment);
			this.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(loadtemperature.PartNames);
			this.PartFilter = loadtemperature.PartFilter;
			this.BoundingBoxDx = loadtemperature.BoundingBoxDx;
			this.BoundingBoxDy = loadtemperature.BoundingBoxDy;
			this.BoundingBoxDz = loadtemperature.BoundingBoxDz;
			this.Group = new Dynamic.Tekla.Structures.Model.LoadGroup(loadtemperature.Group);
			this.ModificationTime = loadtemperature.ModificationTime;
			this.IsUpToDate = loadtemperature.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(loadtemperature.Identifier);

        }


        public dynamic GetTSObject() => loadtemperature;

		public System.Boolean Insert()
			 => loadtemperature.Insert();

		public System.Boolean Select()
			 => loadtemperature.Select();

		public System.Boolean Modify()
			 => loadtemperature.Modify();

		public System.Boolean Delete()
			 => loadtemperature.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(loadtemperature.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(loadtemperature.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(loadtemperature.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => loadtemperature.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => loadtemperature.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => loadtemperature.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => loadtemperature.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => loadtemperature.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadtemperature.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadtemperature.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadtemperature.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => loadtemperature.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => loadtemperature.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => loadtemperature.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => loadtemperature.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => loadtemperature.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => loadtemperature.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => loadtemperature.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => loadtemperature.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => loadtemperature.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => loadtemperature.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => loadtemperature.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(loadtemperature.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loadtemperature.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loadtemperature.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => loadtemperature.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => loadtemperature.CompareTo(obj);





    }

}
    
