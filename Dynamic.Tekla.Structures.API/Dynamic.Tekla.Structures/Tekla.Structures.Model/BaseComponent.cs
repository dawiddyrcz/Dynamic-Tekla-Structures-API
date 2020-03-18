//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class BaseComponent 
    {

		public System.String Name
		{
			get => basecomponent.Name;
			set { basecomponent.Name = value; }
		}

		public System.Int32 Number
		{
			get => basecomponent.Number;
			set { basecomponent.Number = value; }
		}

		public System.DateTime ModificationTime
		{
			get => basecomponent.ModificationTime;
			set { basecomponent.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => basecomponent.IsUpToDate;
			set { basecomponent.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(basecomponent.Identifier);
			set { basecomponent.Identifier = value.GetTSObject(); }
		}

        

        dynamic basecomponent;
        
        private BaseComponent()
        {
            this.basecomponent =  TSActivator.CreateInstance("Tekla.Structures.Model.BaseComponent");
        }

        public BaseComponent(dynamic tsObject)
        {
            this.basecomponent = tsObject;
        }

        internal dynamic GetTSObject() => basecomponent;

		public void SetAttribute(System.String AttrName, System.String StrValue)
			 => basecomponent.SetAttribute(AttrName, StrValue);

		public void SetAttribute(System.String AttrName, System.Int32 Value)
			 => basecomponent.SetAttribute(AttrName, Value);

		public void SetAttribute(System.String AttrName, System.Double DValue)
			 => basecomponent.SetAttribute(AttrName, DValue);

		public System.Boolean GetAttribute(System.String AttrName, System.String StrValue)
			 => basecomponent.GetAttribute(AttrName, StrValue);

		public System.Boolean GetAttribute(System.String AttrName, System.Int32 Value)
			 => basecomponent.GetAttribute(AttrName, Value);

		public System.Boolean GetAttribute(System.String AttrName, System.Double DValue)
			 => basecomponent.GetAttribute(AttrName, DValue);

		public System.Boolean LoadAttributesFromFile(System.String Filename)
			 => basecomponent.LoadAttributesFromFile(Filename);

		public System.Boolean Insert()
			 => basecomponent.Insert();

		public System.Boolean Select()
			 => basecomponent.Select();

		public System.Boolean Modify()
			 => basecomponent.Modify();

		public System.Boolean Delete()
			 => basecomponent.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(basecomponent.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(basecomponent.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(basecomponent.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => basecomponent.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => basecomponent.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => basecomponent.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => basecomponent.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => basecomponent.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => basecomponent.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => basecomponent.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => basecomponent.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => basecomponent.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => basecomponent.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => basecomponent.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => basecomponent.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => basecomponent.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => basecomponent.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => basecomponent.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => basecomponent.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => basecomponent.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => basecomponent.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => basecomponent.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(basecomponent.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => basecomponent.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => basecomponent.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => basecomponent.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => basecomponent.CompareTo(obj);





    }

}
    
