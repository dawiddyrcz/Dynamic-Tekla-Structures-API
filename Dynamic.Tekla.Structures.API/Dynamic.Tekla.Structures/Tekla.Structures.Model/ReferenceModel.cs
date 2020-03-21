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
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(referencemodel.Position);
			set { referencemodel.Position = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Double Scale
		{
			get => referencemodel.Scale;
			set { referencemodel.Scale = value; }
		}

		public Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum Visibility
		{
			get => Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum_.FromTSObject(referencemodel.Visibility);
			set { referencemodel.Visibility = Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum_.GetTSObject(value); }
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

		public System.DateTime ModificationTime
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
			get => Dynamic.Tekla.Structures.Identifier_.FromTSObject(referencemodel.Identifier);
			set { referencemodel.Identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value); }
		}

        

        internal dynamic referencemodel;
        
        public ReferenceModel()
        {
            this.referencemodel =  TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModel");
        }

        internal ReferenceModel(dynamic tsObject)
        {
            this.referencemodel = tsObject;
        }

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetConvertedObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(referencemodel.GetConvertedObjects());

		public System.Boolean RefreshFile()
			 => referencemodel.RefreshFile();

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ReferenceModel.Revision> GetRevisions()
			 => referencemodel.GetRevisions();

		public Dynamic.Tekla.Structures.Model.ReferenceModelObject GetReferenceModelObjectByExternalGuid(System.String externalGuid)
			 => Dynamic.Tekla.Structures.Model.ReferenceModelObject_.FromTSObject(referencemodel.GetReferenceModelObjectByExternalGuid(externalGuid));

		public System.Boolean SetAsCurrentRevision(Dynamic.Tekla.Structures.Model.ReferenceModel.Revision revision)
			 => referencemodel.SetAsCurrentRevision(Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.GetTSObject(revision));

		public System.Boolean SetAsCurrentRevision(System.Int32 modelId, System.Int32 revisionId)
			 => referencemodel.SetAsCurrentRevision(modelId, revisionId);

		public Dynamic.Tekla.Structures.Model.ReferenceModel.Revision GetCurrentRevision()
			 => Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.FromTSObject(referencemodel.GetCurrentRevision());

		public System.Boolean Insert()
			 => referencemodel.Insert();

		public System.Boolean Select()
			 => referencemodel.Select();

		public System.Boolean Modify()
			 => referencemodel.Modify();

		public System.Boolean Delete()
			 => referencemodel.Delete();

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(referencemodel.GetChildren());

		public Dynamic.Tekla.Structures.Model.BaseComponent GetFatherComponent()
			 => Dynamic.Tekla.Structures.Model.BaseComponent_.FromTSObject(referencemodel.GetFatherComponent());

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetHierarchicObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(referencemodel.GetHierarchicObjects());

		public System.Boolean GetAllUserProperties(System.Collections.Hashtable values)
			 => referencemodel.GetAllUserProperties(values);

		public System.Boolean GetIntegerUserProperties(System.Collections.Hashtable values)
			 => referencemodel.GetIntegerUserProperties(values);

		public System.Boolean GetDoubleUserProperties(System.Collections.Hashtable values)
			 => referencemodel.GetDoubleUserProperties(values);

		public System.Boolean GetStringUserProperties(System.Collections.Hashtable values)
			 => referencemodel.GetStringUserProperties(values);

		public System.Boolean GetAllReportProperties(System.Collections.ArrayList stringNames, System.Collections.ArrayList doubleNames, System.Collections.ArrayList integerNames, System.Collections.Hashtable values)
			 => referencemodel.GetAllReportProperties(stringNames, doubleNames, integerNames, values);

		public System.Boolean GetIntegerReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => referencemodel.GetIntegerReportProperties(names, values);

		public System.Boolean GetDoubleReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => referencemodel.GetDoubleReportProperties(names, values);

		public System.Boolean GetStringReportProperties(System.Collections.ArrayList names, System.Collections.Hashtable values)
			 => referencemodel.GetStringReportProperties(names, values);

		public System.Boolean GetUserProperty(System.String name, System.String value)
			 => referencemodel.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.String value)
			 => referencemodel.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Double value)
			 => referencemodel.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Double value)
			 => referencemodel.GetReportProperty(name, value);

		public System.Boolean GetUserProperty(System.String name, System.Int32 value)
			 => referencemodel.GetUserProperty(name, value);

		public System.Boolean GetReportProperty(System.String name, System.Int32 value)
			 => referencemodel.GetReportProperty(name, value);

		public System.Boolean GetDynamicStringProperty(System.String name, System.String value)
			 => referencemodel.GetDynamicStringProperty(name, value);

		public System.Boolean SetDynamicStringProperty(System.String name, System.String value)
			 => referencemodel.SetDynamicStringProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.String value)
			 => referencemodel.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Double value)
			 => referencemodel.SetUserProperty(name, value);

		public System.Boolean SetUserProperty(System.String name, System.Int32 value)
			 => referencemodel.SetUserProperty(name, value);

		public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem GetCoordinateSystem()
			 => Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(referencemodel.GetCoordinateSystem());

		public System.Boolean SetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => referencemodel.SetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean GetPhase(Dynamic.Tekla.Structures.Model.Phase phase)
			 => referencemodel.GetPhase(Dynamic.Tekla.Structures.Model.Phase_.GetTSObject(phase));

		public System.Boolean SetLabel(System.String label)
			 => referencemodel.SetLabel(label);

		public System.Int32 CompareTo(System.Object obj)
			 => referencemodel.CompareTo(obj);




    public struct Revision
    {
       
    }

    internal static class Revision_
    {
        public static dynamic GetTSObject(Revision dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Revision");

            return tsType;
        }
    
        public static Revision FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new Revision();
 
            return dynStruct;
        }
    }


    public enum VisibilityEnum
    {
			HIDDEN,
			VISIBLE        
    }

    internal static class VisibilityEnum_
    {
        public static dynamic GetTSObject(VisibilityEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModel.VisibilityEnum").GetType();

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

    internal static class ReferenceModel_
    {
        public static dynamic GetTSObject(ReferenceModel dynObject)
        {
            return dynObject.referencemodel;
        }

        public static ReferenceModel FromTSObject(dynamic tsObject)
        {
            return new ReferenceModel(tsObject);
        }
    }


}
    
