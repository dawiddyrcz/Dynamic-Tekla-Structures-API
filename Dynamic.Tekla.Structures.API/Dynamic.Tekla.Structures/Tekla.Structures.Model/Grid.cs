//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Grid 
    {

		public System.String CoordinateX
		{
			get => grid.CoordinateX;
			set { grid.CoordinateX = value; }
		}

		public System.String CoordinateY
		{
			get => grid.CoordinateY;
			set { grid.CoordinateY = value; }
		}

		public System.String CoordinateZ
		{
			get => grid.CoordinateZ;
			set { grid.CoordinateZ = value; }
		}

		public System.String LabelX
		{
			get => grid.LabelX;
			set { grid.LabelX = value; }
		}

		public System.String LabelY
		{
			get => grid.LabelY;
			set { grid.LabelY = value; }
		}

		public System.String LabelZ
		{
			get => grid.LabelZ;
			set { grid.LabelZ = value; }
		}

		public System.Double ExtensionLeftX
		{
			get => grid.ExtensionLeftX;
			set { grid.ExtensionLeftX = value; }
		}

		public System.Double ExtensionLeftY
		{
			get => grid.ExtensionLeftY;
			set { grid.ExtensionLeftY = value; }
		}

		public System.Double ExtensionLeftZ
		{
			get => grid.ExtensionLeftZ;
			set { grid.ExtensionLeftZ = value; }
		}

		public System.Double ExtensionRightX
		{
			get => grid.ExtensionRightX;
			set { grid.ExtensionRightX = value; }
		}

		public System.Double ExtensionRightY
		{
			get => grid.ExtensionRightY;
			set { grid.ExtensionRightY = value; }
		}

		public System.Double ExtensionRightZ
		{
			get => grid.ExtensionRightZ;
			set { grid.ExtensionRightZ = value; }
		}

		public System.Double ExtensionForMagneticArea
		{
			get => grid.ExtensionForMagneticArea;
			set { grid.ExtensionForMagneticArea = value; }
		}

		public System.Int32 Color
		{
			get => grid.Color;
			set { grid.Color = value; }
		}

		public System.Boolean IsMagnetic
		{
			get => grid.IsMagnetic;
			set { grid.IsMagnetic = value; }
		}

		public System.String Name
		{
			get => grid.Name;
			set { grid.Name = value; }
		}

		public System.Int32 FontSize
		{
			get => grid.FontSize;
			set { grid.FontSize = value; }
		}

		public System.Drawing.Color FontColor
		{
			get => grid.FontColor;
			set { grid.FontColor = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(grid.Origin);
			set { grid.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.DateTime ModificationTime
		{
			get => grid.ModificationTime;
			set { grid.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => grid.IsUpToDate;
			set { grid.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(grid.Identifier);
			set { grid.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic grid;
        
        public Grid()
        {
            this.grid =  TSActivator.CreateInstance("Tekla.Structures.Model.Grid");
        }

        internal Grid(dynamic tsObject)
        {
            this.grid = tsObject;
        }

		public System.Boolean Insert()
			 => grid.Insert();

		public System.Boolean Select()
			 => grid.Select();

		public System.Boolean Modify()
			 => grid.Modify();

		public System.Boolean Delete()
			 => grid.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(grid.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(grid.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(grid.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => grid.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => grid.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => grid.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => grid.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => grid.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => grid.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => grid.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => grid.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => grid.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => grid.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => grid.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => grid.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => grid.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => grid.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => grid.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => grid.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => grid.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => grid.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => grid.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(grid.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => grid.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => grid.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => grid.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => grid.CompareTo(obj);





    }

    internal static class Grid_
    {
        public static dynamic GetTSObject(Grid dynObject)
        {
            return dynObject.grid;
        }

        public static Grid FromTSObject(dynamic tsObject)
        {
            return new Grid(tsObject);
        }
    }


}
    