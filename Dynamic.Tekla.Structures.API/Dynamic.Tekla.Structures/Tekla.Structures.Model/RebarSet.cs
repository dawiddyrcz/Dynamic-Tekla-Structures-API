//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarSet  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.RebarProperties RebarProperties
		{
			get => Dynamic.Tekla.Structures.Model.RebarProperties_.FromTSObject(teklaObject.RebarProperties);
			set { teklaObject.RebarProperties = Dynamic.Tekla.Structures.Model.RebarProperties_.GetTSObject(value); }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarLegFace> LegFaces
		{
			get => teklaObject.LegFaces;
			set { teklaObject.LegFaces = value; }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarGuideline> Guidelines
		{
			get => teklaObject.Guidelines;
			set { teklaObject.Guidelines = value; }
		}

		public System.Int32 LayerOrderNumber
		{
			get => teklaObject.LayerOrderNumber;
			set { teklaObject.LayerOrderNumber = value; }
		}

        

        

		public RebarSet()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSet");
		}

		public System.Boolean Insert()
			 => teklaObject.Insert();

		public System.Boolean Modify()
			 => teklaObject.Modify();

		public System.Boolean Delete()
			 => teklaObject.Delete();

		public System.Boolean Select()
			 => teklaObject.Select();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetRebarSetAdditions()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetRebarSetAdditions());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetRebarModifiers()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetRebarModifiers());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetReinforcements());

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

    internal static class RebarSet_
    {
        public static dynamic GetTSObject(RebarSet dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarSet FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.RebarSet)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
