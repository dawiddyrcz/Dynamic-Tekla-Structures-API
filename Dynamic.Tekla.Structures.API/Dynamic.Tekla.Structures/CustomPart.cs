//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class CustomPart 
    {

		public Dynamic.Tekla.Structures.Model.Position Position
		{
			get => new Dynamic.Tekla.Structures.Model.Position(custompart.Position.GetTSObject());
			set { custompart.Position = value.GetTSObject(); }
		}

		public System.String Name
		{
			get => custompart.Name;
			set { custompart.Name = value; }
		}

		public System.Int32 Number
		{
			get => custompart.Number;
			set { custompart.Number = value; }
		}

		public System.DateTime ModificationTime
		{
			get => custompart.ModificationTime;
			set { custompart.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => custompart.IsUpToDate;
			set { custompart.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(custompart.Identifier.GetTSObject());
			set { custompart.Identifier = value.GetTSObject(); }
		}

        

        dynamic custompart;
        
        public CustomPart()
        {
            this.custompart =  TSActivator.CreateInstance("Tekla.Structures.Model.CustomPart");
        }

        public CustomPart(dynamic tsObject)
        {
            this.custompart = tsObject;
			this.Position = new Dynamic.Tekla.Structures.Model.Position(custompart.Position);
			this.Name = custompart.Name;
			this.Number = custompart.Number;
			this.ModificationTime = custompart.ModificationTime;
			this.IsUpToDate = custompart.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(custompart.Identifier);

        }


        public dynamic GetTSObject() => custompart;

		public System.Boolean SetInputPositions(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
			 => custompart.SetInputPositions(StartPoint.GetTSObject(), EndPoint.GetTSObject());

		public System.Boolean GetStartAndEndPositions(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
			 => custompart.GetStartAndEndPositions(StartPoint.GetTSObject(), EndPoint.GetTSObject());

		public Dynamic.Tekla.Structures.Model.Assembly GetAssembly()
			 => new Dynamic.Tekla.Structures.Model.Assembly(custompart.GetAssembly());

		public System.Boolean Insert()
			 => custompart.Insert();

		public System.Boolean Select()
			 => custompart.Select();

		public System.Boolean Modify()
			 => custompart.Modify();

		public System.Boolean Delete()
			 => custompart.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetComponents()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(custompart.GetComponents());

		public void SetAttribute(System.String AttrName, System.String StrValue)
			 => custompart.SetAttribute(AttrName, StrValue);

		public void SetAttribute(System.String AttrName, System.Int32 Value)
			 => custompart.SetAttribute(AttrName, Value);

		public void SetAttribute(System.String AttrName, System.Double DValue)
			 => custompart.SetAttribute(AttrName, DValue);

		public System.Boolean GetAttribute(System.String AttrName, System.String StrValue)
			 => custompart.GetAttribute(AttrName, StrValue);

		public System.Boolean GetAttribute(System.String AttrName, System.Int32 Value)
			 => custompart.GetAttribute(AttrName, Value);

		public System.Boolean GetAttribute(System.String AttrName, System.Double DValue)
			 => custompart.GetAttribute(AttrName, DValue);

		public System.Boolean LoadAttributesFromFile(System.String Filename)
			 => custompart.LoadAttributesFromFile(Filename);

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(custompart.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(custompart.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(custompart.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => custompart.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => custompart.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => custompart.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => custompart.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => custompart.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => custompart.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => custompart.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => custompart.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => custompart.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => custompart.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => custompart.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => custompart.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => custompart.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => custompart.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => custompart.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => custompart.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => custompart.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => custompart.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => custompart.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(custompart.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => custompart.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => custompart.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => custompart.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => custompart.CompareTo(obj);





    }

}
    
