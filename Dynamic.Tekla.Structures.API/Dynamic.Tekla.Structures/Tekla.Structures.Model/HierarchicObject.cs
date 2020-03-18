//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class HierarchicObject 
    {

		public System.String Name
		{
			get => hierarchicobject.Name;
			set { hierarchicobject.Name = value; }
		}

		public Dynamic.Tekla.Structures.Model.HierarchicDefinition Definition
		{
			get => new Dynamic.Tekla.Structures.Model.HierarchicDefinition(hierarchicobject.Definition);
			set { hierarchicobject.Definition = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Model.HierarchicObject Father
		{
			get => new Dynamic.Tekla.Structures.Model.HierarchicObject(hierarchicobject.Father);
			set { hierarchicobject.Father = value.GetTSObject(); }
		}

		public System.Collections.ArrayList HierarchicChildren
		{
			get => hierarchicobject.HierarchicChildren;
			set { hierarchicobject.HierarchicChildren = value; }
		}

		public System.DateTime ModificationTime
		{
			get => hierarchicobject.ModificationTime;
			set { hierarchicobject.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => hierarchicobject.IsUpToDate;
			set { hierarchicobject.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(hierarchicobject.Identifier);
			set { hierarchicobject.Identifier = value.GetTSObject(); }
		}

        

        dynamic hierarchicobject;
        
        public HierarchicObject()
        {
            this.hierarchicobject =  TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicObject");
        }

        public HierarchicObject(dynamic tsObject)
        {
            this.hierarchicobject = tsObject;
        }

        internal dynamic GetTSObject() => hierarchicobject;

		public System.Boolean Insert()
			 => hierarchicobject.Insert();

		public System.Boolean Select()
			 => hierarchicobject.Select();

		public System.Boolean Modify()
			 => hierarchicobject.Modify();

		public System.Boolean Delete()
			 => hierarchicobject.Delete();

		public System.Boolean AddObjects(System.Collections.ArrayList Objects)
			 => hierarchicobject.AddObjects(Objects);

		public System.Boolean RemoveObjects(System.Collections.ArrayList Objects)
			 => hierarchicobject.RemoveObjects(Objects);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(hierarchicobject.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(hierarchicobject.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(hierarchicobject.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => hierarchicobject.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => hierarchicobject.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => hierarchicobject.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => hierarchicobject.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => hierarchicobject.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => hierarchicobject.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => hierarchicobject.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => hierarchicobject.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => hierarchicobject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => hierarchicobject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => hierarchicobject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => hierarchicobject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => hierarchicobject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => hierarchicobject.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => hierarchicobject.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => hierarchicobject.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => hierarchicobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => hierarchicobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => hierarchicobject.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(hierarchicobject.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => hierarchicobject.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => hierarchicobject.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => hierarchicobject.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => hierarchicobject.CompareTo(obj);





    }

}
    
