//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class GridBase 
    {

		public System.Boolean IsMagnetic
		{
			get => gridbase.IsMagnetic;
			set { gridbase.IsMagnetic = value; }
		}

		public System.String Name
		{
			get => gridbase.Name;
			set { gridbase.Name = value; }
		}

		public System.Int32 FontSize
		{
			get => gridbase.FontSize;
			set { gridbase.FontSize = value; }
		}

		public System.Drawing.Color FontColor
		{
			get => gridbase.FontColor;
			set { gridbase.FontColor = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(gridbase.Origin.GetTSObject());
			set { gridbase.Origin = value.GetTSObject(); }
		}

		public System.DateTime ModificationTime
		{
			get => gridbase.ModificationTime;
			set { gridbase.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => gridbase.IsUpToDate;
			set { gridbase.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(gridbase.Identifier.GetTSObject());
			set { gridbase.Identifier = value.GetTSObject(); }
		}

        

        dynamic gridbase;
        
        public GridBase()
        {
            this.gridbase =  TSActivator.CreateInstance("Tekla.Structures.Model.GridBase");
        }

        public GridBase(dynamic tsObject)
        {
            this.gridbase = tsObject;
			this.IsMagnetic = gridbase.IsMagnetic;
			this.Name = gridbase.Name;
			this.FontSize = gridbase.FontSize;
			this.FontColor = gridbase.FontColor;
			this.Origin = new Dynamic.Tekla.Structures.Geometry3d.Point(gridbase.Origin);
			this.ModificationTime = gridbase.ModificationTime;
			this.IsUpToDate = gridbase.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(gridbase.Identifier);

        }


        public dynamic GetTSObject() => gridbase;

		public System.Boolean Insert()
			 => gridbase.Insert();

		public System.Boolean Select()
			 => gridbase.Select();

		public System.Boolean Modify()
			 => gridbase.Modify();

		public System.Boolean Delete()
			 => gridbase.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(gridbase.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(gridbase.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(gridbase.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => gridbase.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => gridbase.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => gridbase.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => gridbase.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => gridbase.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => gridbase.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => gridbase.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => gridbase.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => gridbase.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => gridbase.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => gridbase.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => gridbase.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => gridbase.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => gridbase.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => gridbase.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => gridbase.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => gridbase.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => gridbase.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => gridbase.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(gridbase.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => gridbase.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => gridbase.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => gridbase.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => gridbase.CompareTo(obj);





    }

}
    
