//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class SurfaceObject 
    {

		public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep Polymesh
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.FacetedBrep(surfaceobject.Polymesh.GetTSObject());
			set { surfaceobject.Polymesh = value.GetTSObject(); }
		}

		public System.String Class
		{
			get => surfaceobject.Class;
			set { surfaceobject.Class = value; }
		}

		public System.String Name
		{
			get => surfaceobject.Name;
			set { surfaceobject.Name = value; }
		}

		public System.Boolean CreateHoles
		{
			get => surfaceobject.CreateHoles;
			set { surfaceobject.CreateHoles = value; }
		}

		public System.String Type
		{
			get => surfaceobject.Type;
			set { surfaceobject.Type = value; }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => new Dynamic.Tekla.Structures.Model.ModelObject(surfaceobject.Father.GetTSObject());
			set { surfaceobject.Father = value.GetTSObject(); }
		}

		public System.Nullable<System.DateTime> ModificationTime
		{
			get => surfaceobject.ModificationTime;
			set { surfaceobject.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => surfaceobject.IsUpToDate;
			set { surfaceobject.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(surfaceobject.Identifier.GetTSObject());
			set { surfaceobject.Identifier = value.GetTSObject(); }
		}

        

        dynamic surfaceobject;
        
        public SurfaceObject()
        {
            this.surfaceobject =  new Tekla.Structures.Model.SurfaceObject();
        }

        public SurfaceObject(dynamic tsObject)
        {
            this.surfaceobject = tsObject;
			this.Polymesh = new Dynamic.Tekla.Structures.Geometry3d.FacetedBrep(surfaceobject.Polymesh);
			this.Class = surfaceobject.Class;
			this.Name = surfaceobject.Name;
			this.CreateHoles = surfaceobject.CreateHoles;
			this.Type = surfaceobject.Type;
			this.Father = new Dynamic.Tekla.Structures.Model.ModelObject(surfaceobject.Father);
			this.ModificationTime = surfaceobject.ModificationTime;
			this.IsUpToDate = surfaceobject.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(surfaceobject.Identifier);

        }


        public dynamic GetTSObject() => surfaceobject;

		public System.Boolean Insert()
			 => surfaceobject.Insert();

		public System.Boolean Select()
			 => surfaceobject.Select();

		public System.Boolean Modify()
			 => surfaceobject.Modify();

		public System.Boolean Delete()
			 => surfaceobject.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(surfaceobject.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(surfaceobject.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(surfaceobject.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => surfaceobject.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => surfaceobject.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => surfaceobject.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => surfaceobject.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => surfaceobject.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => surfaceobject.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => surfaceobject.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => surfaceobject.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => surfaceobject.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => surfaceobject.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => surfaceobject.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => surfaceobject.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => surfaceobject.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => surfaceobject.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => surfaceobject.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => surfaceobject.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => surfaceobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => surfaceobject.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => surfaceobject.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(surfaceobject.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => surfaceobject.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => surfaceobject.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => surfaceobject.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => surfaceobject.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => surfaceobject.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => surfaceobject.Equals(obj);

		public System.Int32 GetHashCode()
			 => surfaceobject.GetHashCode();

		public System.Type GetType()
			 => surfaceobject.GetType();

		public System.String ToString()
			 => surfaceobject.ToString();





    }

}
    
