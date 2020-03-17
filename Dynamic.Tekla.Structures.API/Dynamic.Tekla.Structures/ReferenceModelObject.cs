//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ReferenceModelObject 
    {

		public System.DateTime ModificationTime
		{
			get => referencemodelobject.ModificationTime;
			set { referencemodelobject.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => referencemodelobject.IsUpToDate;
			set { referencemodelobject.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(referencemodelobject.Identifier.GetTSObject());
			set { referencemodelobject.Identifier = value.GetTSObject(); }
		}

        

        dynamic referencemodelobject;
        
        public ReferenceModelObject()
        {
            this.referencemodelobject =  TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModelObject");
        }

        public ReferenceModelObject(dynamic tsObject)
        {
            this.referencemodelobject = tsObject;
			this.ModificationTime = referencemodelobject.ModificationTime;
			this.IsUpToDate = referencemodelobject.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(referencemodelobject.Identifier);

        }


        public dynamic GetTSObject() => referencemodelobject;

		public Dynamic.Tekla.Structures.Model.ReferenceModel GetReferenceModel()
			 => new Dynamic.Tekla.Structures.Model.ReferenceModel(referencemodelobject.GetReferenceModel());

		public System.Boolean Insert()
			 => referencemodelobject.Insert();

		public System.Boolean Select()
			 => referencemodelobject.Select();

		public System.Boolean Modify()
			 => referencemodelobject.Modify();

		public System.Boolean Delete()
			 => referencemodelobject.Delete();

		public Dynamic.Tekla.Structures.Model.ReferenceModelObject GetFather()
			 => new Dynamic.Tekla.Structures.Model.ReferenceModelObject(referencemodelobject.GetFather());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(referencemodelobject.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(referencemodelobject.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(referencemodelobject.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => referencemodelobject.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => referencemodelobject.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => referencemodelobject.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => referencemodelobject.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => referencemodelobject.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => referencemodelobject.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => referencemodelobject.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => referencemodelobject.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => referencemodelobject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => referencemodelobject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => referencemodelobject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => referencemodelobject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => referencemodelobject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => referencemodelobject.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => referencemodelobject.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => referencemodelobject.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => referencemodelobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => referencemodelobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => referencemodelobject.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(referencemodelobject.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => referencemodelobject.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => referencemodelobject.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => referencemodelobject.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => referencemodelobject.CompareTo(obj);





    }

}
    
