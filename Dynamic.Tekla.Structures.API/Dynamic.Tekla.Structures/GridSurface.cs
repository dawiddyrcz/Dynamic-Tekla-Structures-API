//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class GridSurface 
    {

		public Dynamic.Tekla.Structures.Model.GridBase Parent
		{
			get => new Dynamic.Tekla.Structures.Model.GridBase(gridsurface.Parent.GetTSObject());
			set { gridsurface.Parent = value.GetTSObject(); }
		}

		public System.String Label
		{
			get => gridsurface.Label;
			set { gridsurface.Label = value; }
		}

		public System.Boolean IsMagnetic
		{
			get => gridsurface.IsMagnetic;
			set { gridsurface.IsMagnetic = value; }
		}

		public System.Double ExtensionLeft
		{
			get => gridsurface.ExtensionLeft;
			set { gridsurface.ExtensionLeft = value; }
		}

		public System.Double ExtensionRight
		{
			get => gridsurface.ExtensionRight;
			set { gridsurface.ExtensionRight = value; }
		}

		public System.Double ExtensionBelow
		{
			get => gridsurface.ExtensionBelow;
			set { gridsurface.ExtensionBelow = value; }
		}

		public System.Double ExtensionAbove
		{
			get => gridsurface.ExtensionAbove;
			set { gridsurface.ExtensionAbove = value; }
		}

		public System.Boolean DrawingVisibility
		{
			get => gridsurface.DrawingVisibility;
			set { gridsurface.DrawingVisibility = value; }
		}

		public System.Boolean IsManual
		{
			get => gridsurface.IsManual;
			set { gridsurface.IsManual = value; }
		}

		public System.DateTime ModificationTime
		{
			get => gridsurface.ModificationTime;
			set { gridsurface.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => gridsurface.IsUpToDate;
			set { gridsurface.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(gridsurface.Identifier.GetTSObject());
			set { gridsurface.Identifier = value.GetTSObject(); }
		}

        

        dynamic gridsurface;
        
        public GridSurface()
        {
            this.gridsurface =  TSActivator.CreateInstance("Tekla.Structures.Model.GridSurface");
        }

        public GridSurface(dynamic tsObject)
        {
            this.gridsurface = tsObject;
			this.Parent = new Dynamic.Tekla.Structures.Model.GridBase(gridsurface.Parent);
			this.Label = gridsurface.Label;
			this.IsMagnetic = gridsurface.IsMagnetic;
			this.ExtensionLeft = gridsurface.ExtensionLeft;
			this.ExtensionRight = gridsurface.ExtensionRight;
			this.ExtensionBelow = gridsurface.ExtensionBelow;
			this.ExtensionAbove = gridsurface.ExtensionAbove;
			this.DrawingVisibility = gridsurface.DrawingVisibility;
			this.IsManual = gridsurface.IsManual;
			this.ModificationTime = gridsurface.ModificationTime;
			this.IsUpToDate = gridsurface.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(gridsurface.Identifier);

        }


        public dynamic GetTSObject() => gridsurface;

		public System.Boolean Insert()
			 => gridsurface.Insert();

		public System.Boolean Select()
			 => gridsurface.Select();

		public System.Boolean Modify()
			 => gridsurface.Modify();

		public System.Boolean Delete()
			 => gridsurface.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(gridsurface.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(gridsurface.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(gridsurface.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => gridsurface.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => gridsurface.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => gridsurface.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => gridsurface.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => gridsurface.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => gridsurface.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => gridsurface.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => gridsurface.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => gridsurface.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => gridsurface.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => gridsurface.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => gridsurface.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => gridsurface.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => gridsurface.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => gridsurface.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => gridsurface.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => gridsurface.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => gridsurface.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => gridsurface.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(gridsurface.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => gridsurface.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => gridsurface.GetPhase(phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => gridsurface.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => gridsurface.CompareTo(obj);





    }

}
    
