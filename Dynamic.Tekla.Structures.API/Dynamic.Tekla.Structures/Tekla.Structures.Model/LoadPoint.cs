//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class LoadPoint 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Position
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(loadpoint.Position);
			set { loadpoint.Position = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(loadpoint.P);
			set { loadpoint.P = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Moment
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(loadpoint.Moment);
			set { loadpoint.Moment = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Identifier FatherId
		{
			get => new Dynamic.Tekla.Structures.Identifier(loadpoint.FatherId);
			set { loadpoint.FatherId = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(loadpoint.Spanning);
			set { loadpoint.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(loadpoint.PrimaryAxisDirection);
			set { loadpoint.PrimaryAxisDirection = value.GetTSObject(); }
		}

		public System.Boolean AutomaticPrimaryAxisWeight
		{
			get => loadpoint.AutomaticPrimaryAxisWeight;
			set { loadpoint.AutomaticPrimaryAxisWeight = value; }
		}

		public System.Double Weight
		{
			get => loadpoint.Weight;
			set { loadpoint.Weight = value; }
		}

		public System.Double LoadDispersionAngle
		{
			get => loadpoint.LoadDispersionAngle;
			set { loadpoint.LoadDispersionAngle = value; }
		}

		public System.Boolean CreateFixedSupportConditionsAutomatically
		{
			get => loadpoint.CreateFixedSupportConditionsAutomatically;
			set { loadpoint.CreateFixedSupportConditionsAutomatically = value; }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum LoadAttachment
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(loadpoint.LoadAttachment);
			set { loadpoint.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum PartNames
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(loadpoint.PartNames);
			set { loadpoint.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(value); }
		}

		public System.String PartFilter
		{
			get => loadpoint.PartFilter;
			set { loadpoint.PartFilter = value; }
		}

		public System.Double BoundingBoxDx
		{
			get => loadpoint.BoundingBoxDx;
			set { loadpoint.BoundingBoxDx = value; }
		}

		public System.Double BoundingBoxDy
		{
			get => loadpoint.BoundingBoxDy;
			set { loadpoint.BoundingBoxDy = value; }
		}

		public System.Double BoundingBoxDz
		{
			get => loadpoint.BoundingBoxDz;
			set { loadpoint.BoundingBoxDz = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup Group
		{
			get => new Dynamic.Tekla.Structures.Model.LoadGroup(loadpoint.Group);
			set { loadpoint.Group = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => loadpoint.ModificationTime;
			set { loadpoint.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => loadpoint.IsUpToDate;
			set { loadpoint.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(loadpoint.Identifier);
			set { loadpoint.Identifier = value.GetTSObject(); }
		}

        

        dynamic loadpoint;
        
        public LoadPoint()
        {
            this.loadpoint =  TSActivator.CreateInstance("Tekla.Structures.Model.LoadPoint");
        }

        public LoadPoint(dynamic tsObject)
        {
            this.loadpoint = tsObject;
        }

        internal dynamic GetTSObject() => loadpoint;

		public System.Boolean Insert()
			 => loadpoint.Insert();

		public System.Boolean Select()
			 => loadpoint.Select();

		public System.Boolean Modify()
			 => loadpoint.Modify();

		public System.Boolean Delete()
			 => loadpoint.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(loadpoint.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(loadpoint.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(loadpoint.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => loadpoint.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => loadpoint.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => loadpoint.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => loadpoint.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => loadpoint.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadpoint.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadpoint.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadpoint.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => loadpoint.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => loadpoint.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => loadpoint.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => loadpoint.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => loadpoint.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => loadpoint.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => loadpoint.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => loadpoint.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => loadpoint.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => loadpoint.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => loadpoint.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(loadpoint.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loadpoint.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loadpoint.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => loadpoint.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => loadpoint.CompareTo(obj);





    }

}
    
