//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RadialGrid 
    {

		public System.Boolean IsMagnetic
		{
			get => radialgrid.IsMagnetic;
			set { radialgrid.IsMagnetic = value; }
		}

		public System.String RadialCoordinates
		{
			get => radialgrid.RadialCoordinates;
			set { radialgrid.RadialCoordinates = value; }
		}

		public System.String AngularCoordinates
		{
			get => radialgrid.AngularCoordinates;
			set { radialgrid.AngularCoordinates = value; }
		}

		public System.String CoordinateZ
		{
			get => radialgrid.CoordinateZ;
			set { radialgrid.CoordinateZ = value; }
		}

		public System.String RadialLabels
		{
			get => radialgrid.RadialLabels;
			set { radialgrid.RadialLabels = value; }
		}

		public System.String AngularLabels
		{
			get => radialgrid.AngularLabels;
			set { radialgrid.AngularLabels = value; }
		}

		public System.String LabelZ
		{
			get => radialgrid.LabelZ;
			set { radialgrid.LabelZ = value; }
		}

		public System.Double ArcStartExtension
		{
			get => radialgrid.ArcStartExtension;
			set { radialgrid.ArcStartExtension = value; }
		}

		public System.Double AngularLinesStartExtension
		{
			get => radialgrid.AngularLinesStartExtension;
			set { radialgrid.AngularLinesStartExtension = value; }
		}

		public System.Double ExtensionBelowZ
		{
			get => radialgrid.ExtensionBelowZ;
			set { radialgrid.ExtensionBelowZ = value; }
		}

		public System.Double ArcEndExtension
		{
			get => radialgrid.ArcEndExtension;
			set { radialgrid.ArcEndExtension = value; }
		}

		public System.Double AngularLinesEndExtension
		{
			get => radialgrid.AngularLinesEndExtension;
			set { radialgrid.AngularLinesEndExtension = value; }
		}

		public System.Double ExtensionAboveZ
		{
			get => radialgrid.ExtensionAboveZ;
			set { radialgrid.ExtensionAboveZ = value; }
		}

		public System.Drawing.Color Color
		{
			get => radialgrid.Color;
			set { radialgrid.Color = value; }
		}

		public System.String Name
		{
			get => radialgrid.Name;
			set { radialgrid.Name = value; }
		}

		public System.Int32 FontSize
		{
			get => radialgrid.FontSize;
			set { radialgrid.FontSize = value; }
		}

		public System.Drawing.Color FontColor
		{
			get => radialgrid.FontColor;
			set { radialgrid.FontColor = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(radialgrid.Origin.GetTSObject());
			set { radialgrid.Origin = value.GetTSObject(); }
		}

		public System.NullableSystem.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089<System.DateTime> ModificationTime
		{
			get => radialgrid.ModificationTime;
			set { radialgrid.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => radialgrid.IsUpToDate;
			set { radialgrid.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(radialgrid.Identifier.GetTSObject());
			set { radialgrid.Identifier = value.GetTSObject(); }
		}

        

        dynamic radialgrid;
        
        public RadialGrid()
        {
            this.radialgrid =  new Tekla.Structures.Model.RadialGrid();
        }

        public RadialGrid(dynamic tsObject)
        {
            this.radialgrid = tsObject;
			this.IsMagnetic = radialgrid.IsMagnetic;
			this.RadialCoordinates = radialgrid.RadialCoordinates;
			this.AngularCoordinates = radialgrid.AngularCoordinates;
			this.CoordinateZ = radialgrid.CoordinateZ;
			this.RadialLabels = radialgrid.RadialLabels;
			this.AngularLabels = radialgrid.AngularLabels;
			this.LabelZ = radialgrid.LabelZ;
			this.ArcStartExtension = radialgrid.ArcStartExtension;
			this.AngularLinesStartExtension = radialgrid.AngularLinesStartExtension;
			this.ExtensionBelowZ = radialgrid.ExtensionBelowZ;
			this.ArcEndExtension = radialgrid.ArcEndExtension;
			this.AngularLinesEndExtension = radialgrid.AngularLinesEndExtension;
			this.ExtensionAboveZ = radialgrid.ExtensionAboveZ;
			this.Color = radialgrid.Color;
			this.Name = radialgrid.Name;
			this.FontSize = radialgrid.FontSize;
			this.FontColor = radialgrid.FontColor;
			this.Origin = new Dynamic.Tekla.Structures.Geometry3d.Point(radialgrid.Origin);
			this.ModificationTime = radialgrid.ModificationTime;
			this.IsUpToDate = radialgrid.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(radialgrid.Identifier);

        }


        public dynamic GetTSObject() => radialgrid;

		public System.Boolean Insert()
			 => radialgrid.Insert();

		public System.Boolean Select()
			 => radialgrid.Select();

		public System.Boolean Modify()
			 => radialgrid.Modify();

		public System.Boolean Delete()
			 => radialgrid.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(radialgrid.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(radialgrid.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(radialgrid.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => radialgrid.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => radialgrid.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => radialgrid.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => radialgrid.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => radialgrid.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => radialgrid.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => radialgrid.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => radialgrid.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => radialgrid.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => radialgrid.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => radialgrid.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => radialgrid.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => radialgrid.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => radialgrid.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => radialgrid.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => radialgrid.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => radialgrid.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => radialgrid.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => radialgrid.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(radialgrid.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => radialgrid.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => radialgrid.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => radialgrid.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => radialgrid.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => radialgrid.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => radialgrid.Equals(obj);

		public System.Int32 GetHashCode()
			 => radialgrid.GetHashCode();

		public System.Type GetType()
			 => radialgrid.GetType();

		public System.String ToString()
			 => radialgrid.ToString();





    }

}
    
