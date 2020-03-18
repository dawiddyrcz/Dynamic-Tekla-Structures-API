//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Boolean 
    {

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(boolean.Father);
			set { boolean.Father = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => boolean.ModificationTime;
			set { boolean.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => boolean.IsUpToDate;
			set { boolean.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(boolean.Identifier);
			set { boolean.Identifier = value.GetTSObject(); }
		}

        

        dynamic boolean;
        
        private Boolean()
        {
            this.boolean =  TSActivator.CreateInstance("Tekla.Structures.Model.Boolean");
        }

        public Boolean(dynamic tsObject)
        {
            this.boolean = tsObject;
        }

        internal dynamic GetTSObject() => boolean;

		public System.Boolean Insert()
			 => boolean.Insert();

		public System.Boolean Select()
			 => boolean.Select();

		public System.Boolean Modify()
			 => boolean.Modify();

		public System.Boolean Delete()
			 => boolean.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(boolean.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(boolean.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(boolean.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => boolean.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => boolean.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => boolean.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => boolean.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => boolean.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => boolean.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => boolean.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => boolean.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => boolean.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => boolean.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => boolean.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => boolean.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => boolean.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => boolean.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => boolean.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => boolean.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => boolean.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => boolean.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => boolean.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(boolean.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => boolean.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => boolean.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => boolean.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => boolean.CompareTo(obj);





    }

}
    
