//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class PourBreak 
    {

		public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep Polymesh
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.FacetedBrep(pourbreak.Polymesh.GetTSObject());
			set { pourbreak.Polymesh = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => pourbreak.ModificationTime;
			set { pourbreak.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => pourbreak.IsUpToDate;
			set { pourbreak.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(pourbreak.Identifier.GetTSObject());
			set { pourbreak.Identifier = value.GetTSObject(); }
		}

        

        dynamic pourbreak;
        
        public PourBreak()
        {
            this.pourbreak =  new Tekla.Structures.Model.PourBreak();
        }

        public PourBreak(dynamic tsObject)
        {
            this.pourbreak = tsObject;
			this.Polymesh = new Dynamic.Tekla.Structures.Geometry3d.FacetedBrep(pourbreak.Polymesh);
			this.ModificationTime = pourbreak.ModificationTime;
			this.IsUpToDate = pourbreak.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(pourbreak.Identifier);

        }


        public dynamic GetTSObject() => pourbreak;

		public System.Boolean Insert()
			 => pourbreak.Insert();

		public System.Boolean Select()
			 => pourbreak.Select();

		public System.Boolean Modify()
			 => pourbreak.Modify();

		public System.Boolean Delete()
			 => pourbreak.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourbreak.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(pourbreak.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourbreak.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => pourbreak.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => pourbreak.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => pourbreak.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => pourbreak.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => pourbreak.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => pourbreak.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => pourbreak.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => pourbreak.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => pourbreak.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => pourbreak.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => pourbreak.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => pourbreak.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => pourbreak.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => pourbreak.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => pourbreak.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => pourbreak.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => pourbreak.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => pourbreak.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => pourbreak.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(pourbreak.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => pourbreak.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => pourbreak.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => pourbreak.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => pourbreak.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => pourbreak.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => pourbreak.Equals(obj);

		public System.Int32 GetHashCode()
			 => pourbreak.GetHashCode();

		public System.Type GetType()
			 => pourbreak.GetType();

		public System.String ToString()
			 => pourbreak.ToString();





    }

}
    
