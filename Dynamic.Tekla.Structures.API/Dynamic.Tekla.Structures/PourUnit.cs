//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class PourUnit 
    {

		public System.String Name
		{
			get => pourunit.Name;
			set { pourunit.Name = value; }
		}

		public System.DateTime ModificationTime
		{
			get => pourunit.ModificationTime;
			set { pourunit.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => pourunit.IsUpToDate;
			set { pourunit.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(pourunit.Identifier.GetTSObject());
			set { pourunit.Identifier = value.GetTSObject(); }
		}

        

        dynamic pourunit;
        
        public PourUnit()
        {
            this.pourunit =  TSActivator.CreateInstance("Tekla.Structures.Model.PourUnit");
        }

        public PourUnit(dynamic tsObject)
        {
            this.pourunit = tsObject;
			this.Name = pourunit.Name;
			this.ModificationTime = pourunit.ModificationTime;
			this.IsUpToDate = pourunit.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(pourunit.Identifier);

        }


        public dynamic GetTSObject() => pourunit;

		public System.Boolean Insert()
			 => pourunit.Insert();

		public System.Boolean Select()
			 => pourunit.Select();

		public System.Boolean Modify()
			 => pourunit.Modify();

		public System.Boolean Delete()
			 => pourunit.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourunit.GetObjects());

		public Dynamic.Tekla.Structures.Model.PourObject GetPourObject()
			 => new Dynamic.Tekla.Structures.Model.PourObject(pourunit.GetPourObject());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourunit.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(pourunit.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourunit.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => pourunit.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => pourunit.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => pourunit.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => pourunit.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => pourunit.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => pourunit.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => pourunit.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => pourunit.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => pourunit.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => pourunit.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => pourunit.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => pourunit.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => pourunit.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => pourunit.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => pourunit.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => pourunit.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => pourunit.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => pourunit.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => pourunit.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(pourunit.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => pourunit.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => pourunit.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => pourunit.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => pourunit.CompareTo(obj);





    }

}
    
