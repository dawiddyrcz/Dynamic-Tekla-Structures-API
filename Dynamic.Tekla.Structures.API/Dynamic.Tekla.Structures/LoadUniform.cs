//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class LoadUniform 
    {

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => new Dynamic.Tekla.Structures.Model.Polygon(loaduniform.Polygon.GetTSObject());
			set { loaduniform.Polygon = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P1
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(loaduniform.P1.GetTSObject());
			set { loaduniform.P1 = value.GetTSObject(); }
		}

		public System.Double DistanceA
		{
			get => loaduniform.DistanceA;
			set { loaduniform.DistanceA = value; }
		}

		public Dynamic.Tekla.Structures.Identifier FatherId
		{
			get => new Dynamic.Tekla.Structures.Identifier(loaduniform.FatherId.GetTSObject());
			set { loaduniform.FatherId = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(loaduniform.Spanning);
			set { loaduniform.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(loaduniform.PrimaryAxisDirection.GetTSObject());
			set { loaduniform.PrimaryAxisDirection = value.GetTSObject(); }
		}

		public System.Boolean AutomaticPrimaryAxisWeight
		{
			get => loaduniform.AutomaticPrimaryAxisWeight;
			set { loaduniform.AutomaticPrimaryAxisWeight = value; }
		}

		public System.Double Weight
		{
			get => loaduniform.Weight;
			set { loaduniform.Weight = value; }
		}

		public System.Double LoadDispersionAngle
		{
			get => loaduniform.LoadDispersionAngle;
			set { loaduniform.LoadDispersionAngle = value; }
		}

		public System.Boolean CreateFixedSupportConditionsAutomatically
		{
			get => loaduniform.CreateFixedSupportConditionsAutomatically;
			set { loaduniform.CreateFixedSupportConditionsAutomatically = value; }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum LoadAttachment
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(loaduniform.LoadAttachment);
			set { loaduniform.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum PartNames
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(loaduniform.PartNames);
			set { loaduniform.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(value); }
		}

		public System.String PartFilter
		{
			get => loaduniform.PartFilter;
			set { loaduniform.PartFilter = value; }
		}

		public System.Double BoundingBoxDx
		{
			get => loaduniform.BoundingBoxDx;
			set { loaduniform.BoundingBoxDx = value; }
		}

		public System.Double BoundingBoxDy
		{
			get => loaduniform.BoundingBoxDy;
			set { loaduniform.BoundingBoxDy = value; }
		}

		public System.Double BoundingBoxDz
		{
			get => loaduniform.BoundingBoxDz;
			set { loaduniform.BoundingBoxDz = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup Group
		{
			get => new Dynamic.Tekla.Structures.Model.LoadGroup(loaduniform.Group.GetTSObject());
			set { loaduniform.Group = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => loaduniform.ModificationTime;
			set { loaduniform.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => loaduniform.IsUpToDate;
			set { loaduniform.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(loaduniform.Identifier.GetTSObject());
			set { loaduniform.Identifier = value.GetTSObject(); }
		}

        

        dynamic loaduniform;
        
        public LoadUniform()
        {
            this.loaduniform =  TSActivator.CreateInstance("Tekla.Structures.Model.LoadUniform");
        }

        public LoadUniform(dynamic tsObject)
        {
            this.loaduniform = tsObject;
			this.Polygon = new Dynamic.Tekla.Structures.Model.Polygon(loaduniform.Polygon);
			this.P1 = new Dynamic.Tekla.Structures.Geometry3d.Vector(loaduniform.P1);
			this.DistanceA = loaduniform.DistanceA;
			this.FatherId = new Dynamic.Tekla.Structures.Identifier(loaduniform.FatherId);
			this.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(loaduniform.Spanning);
			this.PrimaryAxisDirection = new Dynamic.Tekla.Structures.Geometry3d.Vector(loaduniform.PrimaryAxisDirection);
			this.AutomaticPrimaryAxisWeight = loaduniform.AutomaticPrimaryAxisWeight;
			this.Weight = loaduniform.Weight;
			this.LoadDispersionAngle = loaduniform.LoadDispersionAngle;
			this.CreateFixedSupportConditionsAutomatically = loaduniform.CreateFixedSupportConditionsAutomatically;
			this.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(loaduniform.LoadAttachment);
			this.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(loaduniform.PartNames);
			this.PartFilter = loaduniform.PartFilter;
			this.BoundingBoxDx = loaduniform.BoundingBoxDx;
			this.BoundingBoxDy = loaduniform.BoundingBoxDy;
			this.BoundingBoxDz = loaduniform.BoundingBoxDz;
			this.Group = new Dynamic.Tekla.Structures.Model.LoadGroup(loaduniform.Group);
			this.ModificationTime = loaduniform.ModificationTime;
			this.IsUpToDate = loaduniform.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(loaduniform.Identifier);

        }


        public dynamic GetTSObject() => loaduniform;

		public System.Boolean Insert()
			 => loaduniform.Insert();

		public System.Boolean Select()
			 => loaduniform.Select();

		public System.Boolean Modify()
			 => loaduniform.Modify();

		public System.Boolean Delete()
			 => loaduniform.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(loaduniform.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(loaduniform.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(loaduniform.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => loaduniform.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => loaduniform.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => loaduniform.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => loaduniform.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => loaduniform.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loaduniform.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loaduniform.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loaduniform.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => loaduniform.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => loaduniform.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => loaduniform.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => loaduniform.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => loaduniform.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => loaduniform.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => loaduniform.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => loaduniform.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => loaduniform.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => loaduniform.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => loaduniform.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(loaduniform.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loaduniform.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loaduniform.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => loaduniform.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => loaduniform.CompareTo(obj);





    }

}
    
