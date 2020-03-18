//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class LoadArea 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Position1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(loadarea.Position1);
			set { loadarea.Position1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(loadarea.Position2);
			set { loadarea.Position2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position3
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(loadarea.Position3);
			set { loadarea.Position3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(loadarea.P1);
			set { loadarea.P1 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(loadarea.P2);
			set { loadarea.P2 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P3
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(loadarea.P3);
			set { loadarea.P3 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector P4
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(loadarea.P4);
			set { loadarea.P4 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum LoadForm
		{
			get => Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum_.FromTSObject(loadarea.LoadForm);
			set { loadarea.LoadForm = Dynamic.Tekla.Structures.Model.LoadArea.AreaLoadFormEnum_.GetTSObject(value); }
		}

		public System.Double DistanceA
		{
			get => loadarea.DistanceA;
			set { loadarea.DistanceA = value; }
		}

		public Dynamic.Tekla.Structures.Identifier FatherId
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(loadarea.FatherId);
			set { loadarea.FatherId = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(loadarea.Spanning);
			set { loadarea.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(loadarea.PrimaryAxisDirection);
			set { loadarea.PrimaryAxisDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.Boolean AutomaticPrimaryAxisWeight
		{
			get => loadarea.AutomaticPrimaryAxisWeight;
			set { loadarea.AutomaticPrimaryAxisWeight = value; }
		}

		public System.Double Weight
		{
			get => loadarea.Weight;
			set { loadarea.Weight = value; }
		}

		public System.Double LoadDispersionAngle
		{
			get => loadarea.LoadDispersionAngle;
			set { loadarea.LoadDispersionAngle = value; }
		}

		public System.Boolean CreateFixedSupportConditionsAutomatically
		{
			get => loadarea.CreateFixedSupportConditionsAutomatically;
			set { loadarea.CreateFixedSupportConditionsAutomatically = value; }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum LoadAttachment
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.FromTSObject(loadarea.LoadAttachment);
			set { loadarea.LoadAttachment = Dynamic.Tekla.Structures.Model.Load.LoadAttachmentEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum PartNames
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.FromTSObject(loadarea.PartNames);
			set { loadarea.PartNames = Dynamic.Tekla.Structures.Model.Load.LoadPartNamesEnum_.GetTSObject(value); }
		}

		public System.String PartFilter
		{
			get => loadarea.PartFilter;
			set { loadarea.PartFilter = value; }
		}

		public System.Double BoundingBoxDx
		{
			get => loadarea.BoundingBoxDx;
			set { loadarea.BoundingBoxDx = value; }
		}

		public System.Double BoundingBoxDy
		{
			get => loadarea.BoundingBoxDy;
			set { loadarea.BoundingBoxDy = value; }
		}

		public System.Double BoundingBoxDz
		{
			get => loadarea.BoundingBoxDz;
			set { loadarea.BoundingBoxDz = value; }
		}

		public Dynamic.Tekla.Structures.Model.LoadGroup Group
		{
			get => Dynamic.Tekla.Structures.Model.LoadGroup_.FromTSObject(loadarea.Group);
			set { loadarea.Group = Dynamic.Tekla.Structures.Model.LoadGroup_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => loadarea.ModificationTime;
			set { loadarea.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => loadarea.IsUpToDate;
			set { loadarea.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(loadarea.Identifier);
			set { loadarea.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic loadarea;
        
        public LoadArea()
        {
            this.loadarea =  TSActivator.CreateInstance("Tekla.Structures.Model.LoadArea");
        }

        internal LoadArea(dynamic tsObject)
        {
            this.loadarea = tsObject;
        }

		public System.Boolean Insert()
			 => loadarea.Insert();

		public System.Boolean Select()
			 => loadarea.Select();

		public System.Boolean Modify()
			 => loadarea.Modify();

		public System.Boolean Delete()
			 => loadarea.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loadarea.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(loadarea.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(loadarea.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => loadarea.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => loadarea.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => loadarea.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => loadarea.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => loadarea.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadarea.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadarea.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => loadarea.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => loadarea.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => loadarea.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => loadarea.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => loadarea.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => loadarea.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => loadarea.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => loadarea.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => loadarea.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => loadarea.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => loadarea.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => loadarea.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(loadarea.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loadarea.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => loadarea.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => loadarea.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => loadarea.CompareTo(obj);




    public enum AreaLoadFormEnum
    {
			LOAD_FORM_AREA_PARALLELOGRAM,
			LOAD_FORM_AREA_TRIANGLE        
    }

    internal static class AreaLoadFormEnum_
    {
        public static dynamic GetTSObject(AreaLoadFormEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.AreaLoadFormEnum");

            switch (dynEnum)
            {
				case AreaLoadFormEnum.LOAD_FORM_AREA_PARALLELOGRAM:
					return System.Enum.Parse(tsType, "LOAD_FORM_AREA_PARALLELOGRAM");
				case AreaLoadFormEnum.LOAD_FORM_AREA_TRIANGLE:
					return System.Enum.Parse(tsType, "LOAD_FORM_AREA_TRIANGLE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static AreaLoadFormEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LOAD_FORM_AREA_PARALLELOGRAM", System.StringComparison.InvariantCulture))
				return AreaLoadFormEnum.LOAD_FORM_AREA_PARALLELOGRAM;
			else if (tsEnumValue.Equals("LOAD_FORM_AREA_TRIANGLE", System.StringComparison.InvariantCulture))
				return AreaLoadFormEnum.LOAD_FORM_AREA_TRIANGLE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class LoadArea_
    {
        public static dynamic GetTSObject(LoadArea dynObject)
        {
            return dynObject.loadarea;
        }

        public static LoadArea FromTSObject(dynamic tsObject)
        {
            return new LoadArea(tsObject);
        }
    }


}
    
