//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class Grid  : Dynamic.Tekla.Structures.Model.GridBase
    {

		public System.String CoordinateX
		{
			get => teklaObject.CoordinateX;
			set { teklaObject.CoordinateX = value; }
		}

		public System.String CoordinateY
		{
			get => teklaObject.CoordinateY;
			set { teklaObject.CoordinateY = value; }
		}

		public System.String CoordinateZ
		{
			get => teklaObject.CoordinateZ;
			set { teklaObject.CoordinateZ = value; }
		}

		public System.String LabelX
		{
			get => teklaObject.LabelX;
			set { teklaObject.LabelX = value; }
		}

		public System.String LabelY
		{
			get => teklaObject.LabelY;
			set { teklaObject.LabelY = value; }
		}

		public System.String LabelZ
		{
			get => teklaObject.LabelZ;
			set { teklaObject.LabelZ = value; }
		}

		public System.Double ExtensionLeftX
		{
			get => teklaObject.ExtensionLeftX;
			set { teklaObject.ExtensionLeftX = value; }
		}

		public System.Double ExtensionLeftY
		{
			get => teklaObject.ExtensionLeftY;
			set { teklaObject.ExtensionLeftY = value; }
		}

		public System.Double ExtensionLeftZ
		{
			get => teklaObject.ExtensionLeftZ;
			set { teklaObject.ExtensionLeftZ = value; }
		}

		public System.Double ExtensionRightX
		{
			get => teklaObject.ExtensionRightX;
			set { teklaObject.ExtensionRightX = value; }
		}

		public System.Double ExtensionRightY
		{
			get => teklaObject.ExtensionRightY;
			set { teklaObject.ExtensionRightY = value; }
		}

		public System.Double ExtensionRightZ
		{
			get => teklaObject.ExtensionRightZ;
			set { teklaObject.ExtensionRightZ = value; }
		}

		public System.Double ExtensionForMagneticArea
		{
			get => teklaObject.ExtensionForMagneticArea;
			set { teklaObject.ExtensionForMagneticArea = value; }
		}

		public System.Int32 Color
		{
			get => teklaObject.Color;
			set { teklaObject.Color = value; }
		}

        

        

		public Grid()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Grid");
		}

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Select()
			 => teklaObject.Select();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(teklaObject.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => teklaObject.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => teklaObject.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => teklaObject.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => teklaObject.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => teklaObject.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => teklaObject.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => teklaObject.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => teklaObject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => teklaObject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => teklaObject.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(teklaObject.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => teklaObject.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => teklaObject.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => teklaObject.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => teklaObject.CompareTo(obj);





    }

    internal static class Grid_
    {
        public static dynamic GetTSObject(Grid dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Grid FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Grid)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
