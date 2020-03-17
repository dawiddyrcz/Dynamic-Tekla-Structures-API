//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Component 
    {

		public System.String Name
		{
			get => component.Name;
			set { component.Name = value; }
		}

		public System.Int32 Number
		{
			get => component.Number;
			set { component.Number = value; }
		}

		public System.DateTime ModificationTime
		{
			get => component.ModificationTime;
			set { component.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => component.IsUpToDate;
			set { component.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(component.Identifier.GetTSObject());
			set { component.Identifier = value.GetTSObject(); }
		}

        

        dynamic component;
        
        public Component()
        {
            this.component =  TSActivator.CreateInstance("Tekla.Structures.Model.Component");
        }

        public Component(dynamic tsObject)
        {
            this.component = tsObject;
			this.Name = component.Name;
			this.Number = component.Number;
			this.ModificationTime = component.ModificationTime;
			this.IsUpToDate = component.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(component.Identifier);

        }


        public dynamic GetTSObject() => component;

		public System.Boolean SetComponentInput(Dynamic.Tekla.Structures.Model.ComponentInput I)
			 => component.SetComponentInput(I.GetTSObject());

		public Dynamic.Tekla.Structures.Model.ComponentInput GetComponentInput()
			 => new Dynamic.Tekla.Structures.Model.ComponentInput(component.GetComponentInput());

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => new Dynamic.Tekla.Structures.Model.Assembly(component.GetAssembly());

		public System.Boolean Insert()
			 => component.Insert();

		public System.Boolean Select()
			 => component.Select();

		public System.Boolean Modify()
			 => component.Modify();

		public System.Boolean Delete()
			 => component.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(component.GetComponents());

		public void SetAttribute(System.String AttrName, System.String StrValue)
			 => component.SetAttribute(AttrName, StrValue);

		public void SetAttribute(System.String AttrName, System.Int32 Value)
			 => component.SetAttribute(AttrName, Value);

		public void SetAttribute(System.String AttrName, System.Double DValue)
			 => component.SetAttribute(AttrName, DValue);

		public System.Boolean GetAttribute(System.String AttrName, System.String StrValue)
			 => component.GetAttribute(AttrName, StrValue);

		public System.Boolean GetAttribute(System.String AttrName, System.Int32 Value)
			 => component.GetAttribute(AttrName, Value);

		public System.Boolean GetAttribute(System.String AttrName, System.Double DValue)
			 => component.GetAttribute(AttrName, DValue);

		public System.Boolean LoadAttributesFromFile(System.String Filename)
			 => component.LoadAttributesFromFile(Filename);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(component.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(component.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(component.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => component.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => component.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => component.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => component.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => component.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => component.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => component.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => component.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => component.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => component.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => component.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => component.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => component.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => component.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => component.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => component.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => component.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => component.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => component.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(component.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => component.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => component.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => component.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => component.CompareTo(obj);





    }

}
    
