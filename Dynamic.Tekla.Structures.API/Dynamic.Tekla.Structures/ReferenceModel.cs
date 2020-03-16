//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class ReferenceModel 
    {

		public System.String Filename
		{
			get => referencemodel.Filename;
			set { referencemodel.Filename = value; }
		}

		public System.String ActiveFilePath
		{
			get => referencemodel.ActiveFilePath;
			set { referencemodel.ActiveFilePath = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Point(referencemodel.Position.GetTSObject());
			set { referencemodel.Position = value.GetTSObject(); }
		}

		public System.Double Scale
		{
			get => referencemodel.Scale;
			set { referencemodel.Scale = value; }
		}

		public Dynamic.Tekla.Structures.Model.VisibilityEnum Visibility
		{
			get => Dynamic.Tekla.Structures.Model.VisibilityEnum_.FromTSObject(referencemodel.Visibility);
			set { referencemodel.Visibility = Dynamic.Tekla.Structures.Model.VisibilityEnum_.FromTSObject(value); }
		}

		public System.Guid BasePointGuid
		{
			get => referencemodel.BasePointGuid;
			set { referencemodel.BasePointGuid = value; }
		}

		public System.Double Rotation
		{
			get => referencemodel.Rotation;
			set { referencemodel.Rotation = value; }
		}

		public System.Guid ProjectGUID
		{
			get => referencemodel.ProjectGUID;
			set { referencemodel.ProjectGUID = value; }
		}

		public System.Guid ModelGUID
		{
			get => referencemodel.ModelGUID;
			set { referencemodel.ModelGUID = value; }
		}

		public System.Guid VersionGUID
		{
			get => referencemodel.VersionGUID;
			set { referencemodel.VersionGUID = value; }
		}

		public System.Nullable<System.DateTime> ModificationTime
		{
			get => referencemodel.ModificationTime;
			set { referencemodel.ModificationTime = value; }
		}

		public System.Boolean IsUpToDate
		{
			get => referencemodel.IsUpToDate;
			set { referencemodel.IsUpToDate = value; }
		}

		public Dynamic.Tekla.Structures.Identifier Identifier
		{
			get => new Dynamic.Tekla.Structures.Identifier(referencemodel.Identifier.GetTSObject());
			set { referencemodel.Identifier = value.GetTSObject(); }
		}

        

        dynamic referencemodel;
        
        public ReferenceModel()
        {
            this.referencemodel =  new Tekla.Structures.Model.ReferenceModel();
        }

        public ReferenceModel(dynamic tsObject)
        {
            this.referencemodel = tsObject;
			this.Filename = referencemodel.Filename;
			this.ActiveFilePath = referencemodel.ActiveFilePath;
			this.Position = new Dynamic.Tekla.Structures.Geometry3d.Point(referencemodel.Position);
			this.Scale = referencemodel.Scale;
			this.Visibility = Dynamic.Tekla.Structures.Model.VisibilityEnum_.FromTSObject(referencemodel.Visibility);
			this.BasePointGuid = referencemodel.BasePointGuid;
			this.Rotation = referencemodel.Rotation;
			this.ProjectGUID = referencemodel.ProjectGUID;
			this.ModelGUID = referencemodel.ModelGUID;
			this.VersionGUID = referencemodel.VersionGUID;
			this.ModificationTime = referencemodel.ModificationTime;
			this.IsUpToDate = referencemodel.IsUpToDate;
			this.Identifier = new Dynamic.Tekla.Structures.Identifier(referencemodel.Identifier);

        }


        public dynamic GetTSObject() => referencemodel;

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetConvertedObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(referencemodel.GetConvertedObjects());

		public System.Boolean RefreshFile()
			 => referencemodel.RefreshFile();

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.Revision> GetRevisions()
			 => referencemodel.GetRevisions();

		public Dynamic.Tekla.Structures.Model.ReferenceModelObject GetReferenceModelObjectByExternalGuid(System.String externalGuid)
			 => new Dynamic.Tekla.Structures.Model.ReferenceModelObject(referencemodel.GetReferenceModelObjectByExternalGuid(externalGuid));

		public System.Boolean SetAsCurrentRevision(Dynamic.Tekla.Structures.Model.Revision revision)
			 => referencemodel.SetAsCurrentRevision(revision.GetTSObject());

		public System.Boolean SetAsCurrentRevision(System.Int32 modelId, System.Int32 revisionId)
			 => referencemodel.SetAsCurrentRevision(modelId, revisionId);

		public Dynamic.Tekla.Structures.Model.Revision GetCurrentRevision()
			 => new Dynamic.Tekla.Structures.Model.Revision(referencemodel.GetCurrentRevision());

		public System.Boolean Insert()
			 => referencemodel.Insert();

		public System.Boolean Select()
			 => referencemodel.Select();

		public System.Boolean Modify()
			 => referencemodel.Modify();

		public System.Boolean Delete()
			 => referencemodel.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(referencemodel.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => new Dynamic.Tekla.Structures.Model.BaseComponent(referencemodel.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => new Dynamic.Tekla.Structures.Model.ModelObjectEnumerator(referencemodel.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(ref System.Collections.Hashtable values)
			 => referencemodel.GetAllUserProperties(ref values);

		public System.Boolean GetIntegerUserProperties(ref System.Collections.Hashtable values)
			 => referencemodel.GetIntegerUserProperties(ref values);

		public System.Boolean GetDoubleUserProperties(ref System.Collections.Hashtable values)
			 => referencemodel.GetDoubleUserProperties(ref values);

		public System.Boolean GetStringUserProperties(ref System.Collections.Hashtable values)
			 => referencemodel.GetStringUserProperties(ref values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, ref System.Collections.Hashtable values)
			 => referencemodel.GetAllReportProperties(stringNames, doubleNames, integerNames, ref values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => referencemodel.GetIntegerReportProperties(names, ref values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => referencemodel.GetDoubleReportProperties(names, ref values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, ref System.Collections.Hashtable values)
			 => referencemodel.GetStringReportProperties(names, ref values);

		public System.Boolean GetUserProperty(System.String name, ref System.String value)
			 => referencemodel.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.String value)
			 => referencemodel.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Double value)
			 => referencemodel.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Double value)
			 => referencemodel.GetReportProperty(name, ref value);

		public System.Boolean GetUserProperty(System.String name, ref System.Int32 value)
			 => referencemodel.GetUserProperty(name, ref value);

		public System.Boolean GetReportProperty(System.String name, ref System.Int32 value)
			 => referencemodel.GetReportProperty(name, ref value);

		public System.Boolean GetDynamicStringProperty(System.String name, ref System.String value)
			 => referencemodel.GetDynamicStringProperty(name, ref value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => referencemodel.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => referencemodel.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => referencemodel.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => referencemodel.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => new Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem(referencemodel.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => referencemodel.SetPhase(phase.GetTSObject());

		public System.Boolean GetPhase(ref Dynamic.Tekla.Structures.Model.Phase phase)
			 => referencemodel.GetPhase(ref phase.GetTSObject());

		public System.Boolean SetLabel(System.String label)
			 => referencemodel.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => referencemodel.CompareTo(obj);

		public System.Boolean Equals(Dynamic.Tekla.Structures.Model.ModelObject other)
			 => referencemodel.Equals(other.GetTSObject());

		public System.Boolean Equals(System.Object obj)
			 => referencemodel.Equals(obj);

		public System.Int32 GetHashCode()
			 => referencemodel.GetHashCode();

		public System.Type GetType()
			 => referencemodel.GetType();

		public System.String ToString()
			 => referencemodel.ToString();





    public enum VisibilityEnum
    {
			HIDDEN,
			VISIBLE        
    }

    public static class VisibilityEnum_
    {
        public static dynamic GetTSObject(VisibilityEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.VisibilityEnum");

            switch (dynEnum)
            {
				case VisibilityEnum.HIDDEN:
					return System.Enum.Parse(tsType, "HIDDEN");
				case VisibilityEnum.VISIBLE:
					return System.Enum.Parse(tsType, "VISIBLE");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static VisibilityEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("HIDDEN", System.StringComparison.InvariantCulture))
				return VisibilityEnum.HIDDEN;
			else if (tsEnumValue.Equals("VISIBLE", System.StringComparison.InvariantCulture))
				return VisibilityEnum.VISIBLE;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

}
    
