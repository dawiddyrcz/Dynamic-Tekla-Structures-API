//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarSet 
    {

		public Dynamic.Tekla.Structures.Model.RebarProperties RebarProperties
		{
			get => Dynamic.Tekla.Structures.Model.RebarProperties_.FromTSObject(rebarset.RebarProperties);
			set { rebarset.RebarProperties = Dynamic.Tekla.Structures.Model.RebarProperties_.GetTSObject(value); }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarLegFace> LegFaces
		{
			get => rebarset.LegFaces;
			set { rebarset.LegFaces = value; }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.RebarGuideline> Guidelines
		{
			get => rebarset.Guidelines;
			set { rebarset.Guidelines = value; }
		}

		public System.Int32 LayerOrderNumber
		{
			get => rebarset.LayerOrderNumber;
			set { rebarset.LayerOrderNumber = value; }
		}

		public System.DateTime ModificationTime
		{
			get => rebarset.ModificationTime;
			set { rebarset.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => rebarset.IsUpToDate;
			set { rebarset.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(rebarset.Identifier);
			set { rebarset.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic rebarset;
        
        public RebarSet()
        {
            this.rebarset =  TSActivator.CreateInstance("Tekla.Structures.Model.RebarSet");
        }

        internal RebarSet(dynamic tsObject)
        {
            this.rebarset = tsObject;
        }

		public System.Boolean Insert()
			 => rebarset.Insert();

		public System.Boolean Modify()
			 => rebarset.Modify();

		public System.Boolean Delete()
			 => rebarset.Delete();

		public System.Boolean Select()
			 => rebarset.Select();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetRebarSetAdditions()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(rebarset.GetRebarSetAdditions());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetRebarModifiers()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(rebarset.GetRebarModifiers());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetReinforcements()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(rebarset.GetReinforcements());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(rebarset.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(rebarset.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(rebarset.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => rebarset.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => rebarset.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => rebarset.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => rebarset.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => rebarset.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => rebarset.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => rebarset.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => rebarset.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => rebarset.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => rebarset.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => rebarset.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => rebarset.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => rebarset.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => rebarset.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => rebarset.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => rebarset.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => rebarset.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => rebarset.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => rebarset.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(rebarset.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => rebarset.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => rebarset.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => rebarset.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => rebarset.CompareTo(obj);





    }

    internal static class RebarSet_
    {
        public static dynamic GetTSObject(RebarSet dynObject)
        {
            return dynObject.rebarset;
        }

        public static RebarSet FromTSObject(dynamic tsObject)
        {
            return new RebarSet(tsObject);
        }
    }


}
    