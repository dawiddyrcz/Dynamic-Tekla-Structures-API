//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class GridCylindricalSurface 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Arc CylinderBase
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Arc(gridcylindricalsurface.CylinderBase.GetTSObject());
			set { gridcylindricalsurface.CylinderBase = value.GetTSObject(); }
		}

		public System.Double CylinderHeight
		{
			get => gridcylindricalsurface.CylinderHeight;
			set { gridcylindricalsurface.CylinderHeight = value; }
		}

		public Dynamic.Tekla.Structures.Model.GridBase Parent
		{
			get => new Dynamic.Tekla.Structures.Model.GridBase(gridcylindricalsurface.Parent.GetTSObject());
			set { gridcylindricalsurface.Parent = value.GetTSObject(); }
		}

		public System.String Label
		{
			get => gridcylindricalsurface.Label;
			set { gridcylindricalsurface.Label = value; }
		}

		public System.Boolean IsMagnetic
		{
			get => gridcylindricalsurface.IsMagnetic;
			set { gridcylindricalsurface.IsMagnetic = value; }
		}

		public System.Double ExtensionLeft
		{
			get => gridcylindricalsurface.ExtensionLeft;
			set { gridcylindricalsurface.ExtensionLeft = value; }
		}

		public System.Double ExtensionRight
		{
			get => gridcylindricalsurface.ExtensionRight;
			set { gridcylindricalsurface.ExtensionRight = value; }
		}

		public System.Double ExtensionBelow
		{
			get => gridcylindricalsurface.ExtensionBelow;
			set { gridcylindricalsurface.ExtensionBelow = value; }
		}

		public System.Double ExtensionAbove
		{
			get => gridcylindricalsurface.ExtensionAbove;
			set { gridcylindricalsurface.ExtensionAbove = value; }
		}

		public System.Boolean DrawingVisibility
		{
			get => gridcylindricalsurface.DrawingVisibility;
			set { gridcylindricalsurface.DrawingVisibility = value; }
		}

		public System.Boolean IsManual
		{
			get => gridcylindricalsurface.IsManual;
			set { gridcylindricalsurface.IsManual = value; }
		}

		public System.DateTime ModificationTime
		{
			get => gridcylindricalsurface.ModificationTime;
			set { gridcylindricalsurface.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => gridcylindricalsurface.IsUpToDate;
			set { gridcylindricalsurface.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(gridcylindricalsurface.Identifier.GetTSObject());
			set { gridcylindricalsurface.Identifier = value.GetTSObject(); }
		}

        

        dynamic gridcylindricalsurface;
        
        public GridCylindricalSurface()
        {
            this.gridcylindricalsurface =  new Tekla.Structures.Model.GridCylindricalSurface();
        }

        public GridCylindricalSurface(dynamic tsObject)
        {
            this.gridcylindricalsurface = tsObject;
			this.CylinderBase = new Dynamic.Tekla.Structures.Geometry3d.Arc(gridcylindricalsurface.CylinderBase);
			this.CylinderHeight = gridcylindricalsurface.CylinderHeight;
			this.Parent = new Dynamic.Tekla.Structures.Model.GridBase(gridcylindricalsurface.Parent);
			this.Label = gridcylindricalsurface.Label;
			this.IsMagnetic = gridcylindricalsurface.IsMagnetic;
			this.ExtensionLeft = gridcylindricalsurface.ExtensionLeft;
			this.ExtensionRight = gridcylindricalsurface.ExtensionRight;
			this.ExtensionBelow = gridcylindricalsurface.ExtensionBelow;
			this.ExtensionAbove = gridcylindricalsurface.ExtensionAbove;
			this.DrawingVisibility = gridcylindricalsurface.DrawingVisibility;
			this.IsManual = gridcylindricalsurface.IsManual;
			this.ModificationTime = gridcylindricalsurface.ModificationTime;
			this.IsUpToDate = gridcylindricalsurface.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(gridcylindricalsurface.Identifier);

        }


        public dynamic GetTSObject() => gridcylindricalsurface;

		public System.Boolean Modify()
			 => gridcylindricalsurface.Modify();

		public System.Boolean Insert()
			 => gridcylindricalsurface.Insert();

		public System.Boolean Select()
			 => gridcylindricalsurface.Select();

		public System.Boolean Delete()
			 => gridcylindricalsurface.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(gridcylindricalsurface.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(gridcylindricalsurface.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(gridcylindricalsurface.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => gridcylindricalsurface.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => gridcylindricalsurface.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => gridcylindricalsurface.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => gridcylindricalsurface.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => gridcylindricalsurface.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => gridcylindricalsurface.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => gridcylindricalsurface.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => gridcylindricalsurface.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => gridcylindricalsurface.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => gridcylindricalsurface.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => gridcylindricalsurface.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => gridcylindricalsurface.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => gridcylindricalsurface.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => gridcylindricalsurface.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => gridcylindricalsurface.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => gridcylindricalsurface.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => gridcylindricalsurface.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => gridcylindricalsurface.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => gridcylindricalsurface.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(gridcylindricalsurface.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => gridcylindricalsurface.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => gridcylindricalsurface.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => gridcylindricalsurface.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => gridcylindricalsurface.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => gridcylindricalsurface.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => gridcylindricalsurface.Equals(obj);

		public System.Int32 GetHashCode()
			 => gridcylindricalsurface.GetHashCode();

		public System.Type GetType()
			 => gridcylindricalsurface.GetType();

		public System.String ToString()
			 => gridcylindricalsurface.ToString();





    }

}
    
