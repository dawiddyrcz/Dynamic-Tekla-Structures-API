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
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(pourobject.Identifier);
			set { pourobject.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic pourobject;
        
        public PourObject()
        {
            this.pourobject =  TSActivator.CreateInstance("Tekla.Structures.Model.PourObject");
        }

        internal PourObject(dynamic tsObject)
        {
            this.pourobject = tsObject;
        }

		public System.Boolean Insert()
			 => pourobject.Insert();

		public System.Boolean Select()
			 => pourobject.Select();

		public System.Boolean Modify()
			 => pourobject.Modify();

		public System.Boolean Delete()
			 => pourobject.Delete();

		public Dynamic.Tekla.Structures.Model.Solid GetSolid()
			 => Dynamic.Tekla.Structures.Model.Solid_.FromTSObject(pourobject.GetSolid());

		public Dynamic.Tekla.Structures.Model.PolymeshEnumerator GetPourPolymeshes()
			 => Dynamic.Tekla.Structures.Model.PolymeshEnumerator_.FromTSObject(pourobject.GetPourPolymeshes());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetParts()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(pourobject.GetParts());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(pourobject.GetObjects());

		public Dynamic.Tekla.Structures.Model.PourUnit GetFatherPourUnit()
			 => Dynamic.Tekla.Structures.Model.PourUnit_.FromTSObject(pourobject.GetFatherPourUnit());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetSurfaceObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(pourobject.GetSurfaceObjects());

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => Dynamic.Tekla.Structures.Model.Assembly_.FromTSObject(pourobject.GetAssembly());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(pourobject.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(pourobject.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(pourobject.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => pourobject.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => pourobject.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => pourobject.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => pourobject.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => pourobject.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => pourobject.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => pourobject.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => pourobject.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => pourobject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => pourobject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => pourobject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => pourobject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => pourobject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => pourobject.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => pourobject.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => pourobject.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => pourobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => pourobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => pourobject.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(pourobject.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => pourobject.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => pourobject.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => pourobject.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => pourobject.CompareTo(obj);





    }

    internal static class PourObject_
    {
        public static dynamic GetTSObject(PourObject dynObject)
        {
            return dynObject.pourobject;
        }

        public static PourObject FromTSObject(dynamic tsObject)
        {
            return new PourObject(tsObject);
        }
    }


}
    