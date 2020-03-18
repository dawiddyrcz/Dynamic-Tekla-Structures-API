//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class LoadUniform 
    {

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(loaduniform.Polygon);
			set { loaduniform.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(loaduniform.P1);
			set { loaduniform.P1 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.Double DistanceA
		{
			get => loaduniform.DistanceA;
			set { loaduniform.DistanceA = value; }
		}

		public Dynamic.Tekla.Structures.Identifier FatherId
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(loaduniform.FatherId);
			set { loaduniform.FatherId = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(loaduniform.Spanning);
			set { loaduniform.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(loaduniform.PrimaryAxisDirection);
			set { loaduniform.PrimaryAxisDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
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
			set { loaduniform.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum PartNames
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(loaduniform.PartNames);
			set { loaduniform.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.GetTSObject(value); }
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
			get => Dynamic.Tekla.Structures.Model.LoadGroup_.FromTSObject(loaduniform.Group);
			set { loaduniform.Group = Dynamic.Tekla.Structures.Model.LoadGroup_.GetTSObject(value); }
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
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(loaduniform.Identifier);
			set { loaduniform.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic loaduniform;
        
        public LoadUniform()
        {
            this.loaduniform =  TSActivator.CreateInstance("Tekla.Structures.Model.LoadUniform");
        }

        internal LoadUniform(dynamic tsObject)
        {
            this.loaduniform = tsObject;
        }

		public System.Boolean Insert()
			 => loaduniform.Insert();

		public System.Boolean Select()
			 => loaduniform.Select();

		public System.Boolean Modify()
			 => loaduniform.Modify();

		public System.Boolean Delete()
			 => loaduniform.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loaduniform.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(loaduniform.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loaduniform.GetHierarchicObjects());

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
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(loaduniform.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loaduniform.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loaduniform.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => loaduniform.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => loaduniform.CompareTo(obj);





    }

    internal static class LoadUniform_
    {
        public static dynamic GetTSObject(LoadUniform dynObject)
        {
            return dynObject.loaduniform;
        }

        public static LoadUniform FromTSObject(dynamic tsObject)
        {
            return new LoadUniform(tsObject);
        }
    }


}
    
