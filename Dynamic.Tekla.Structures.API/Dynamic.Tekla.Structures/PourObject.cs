//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class PourObject 
    {

		public System.Int32 Class
		{
			get => pourobject.Class;
			set { pourobject.Class = value; }
		}

		public System.String PourNumber
		{
			get => pourobject.PourNumber;
			set { pourobject.PourNumber = value; }
		}

		public System.String PourType
		{
			get => pourobject.PourType;
			set { pourobject.PourType = value; }
		}

		public System.String ConcreteMixture
		{
			get => pourobject.ConcreteMixture;
			set { pourobject.ConcreteMixture = value; }
		}

		public System.DateTime ModificationTime
		{
			get => pourobject.ModificationTime;
			set { pourobject.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => pourobject.IsUpToDate;
			set { pourobject.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(pourobject.Identifier.GetTSObject());
			set { pourobject.Identifier = value.GetTSObject(); }
		}

        

        dynamic pourobject;
        
        public PourObject()
        {
            this.pourobject =  new Tekla.Structures.Model.PourObject();
        }

        public PourObject(dynamic tsObject)
        {
            this.pourobject = tsObject;
			this.Class = pourobject.Class;
			this.PourNumber = pourobject.PourNumber;
			this.PourType = pourobject.PourType;
			this.ConcreteMixture = pourobject.ConcreteMixture;
			this.ModificationTime = pourobject.ModificationTime;
			this.IsUpToDate = pourobject.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(pourobject.Identifier);

        }


        public dynamic GetTSObject() => pourobject;

		public System.Boolean Insert()
			 => pourobject.Insert();

		public System.Boolean Select()
			 => pourobject.Select();

		public System.Boolean Modify()
			 => pourobject.Modify();

		public System.Boolean Delete()
			 => pourobject.Delete();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => new Dynamic.Tekla.Structures.Model.Solid(pourobject.GetSolid());

		public Dynamic.Tekla.Structures.Model.PolymeshEnumerator GetPourPolymeshes()
			 => new Dynamic.Tekla.Structures.Model.PolymeshEnumerator(pourobject.GetPourPolymeshes());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetParts()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourobject.GetParts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourobject.GetObjects());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => new Dynamic.Tekla.Structures.Model.PourUnit(pourobject.GetFatherPourUnit());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourobject.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => new Dynamic.Tekla.Structures.Model.Assembly(pourobject.GetAssembly());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourobject.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(pourobject.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(pourobject.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => pourobject.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => pourobject.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => pourobject.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => pourobject.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => pourobject.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => pourobject.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => pourobject.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => pourobject.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => pourobject.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => pourobject.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => pourobject.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => pourobject.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => pourobject.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => pourobject.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => pourobject.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => pourobject.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => pourobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => pourobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => pourobject.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(pourobject.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => pourobject.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => pourobject.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => pourobject.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => pourobject.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => pourobject.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => pourobject.Equals(obj);

		public System.Int32 GetHashCode()
			 => pourobject.GetHashCode();

		public System.Type GetType()
			 => pourobject.GetType();

		public System.String ToString()
			 => pourobject.ToString();





    }

}
    
