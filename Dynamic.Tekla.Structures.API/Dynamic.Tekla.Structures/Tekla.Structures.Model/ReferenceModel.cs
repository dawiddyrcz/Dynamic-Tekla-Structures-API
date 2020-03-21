//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class ReferenceModel  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.String Filename
		{
			get => teklaObject.Filename;
			set { teklaObject.Filename = value; }
		}

		public System.String ActiveFilePath
		{
			get => teklaObject.ActiveFilePath;
			set { teklaObject.ActiveFilePath = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position);
			set { teklaObject.Position = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Double Scale
		{
			get => teklaObject.Scale;
			set { teklaObject.Scale = value; }
		}

		public Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum Visibility
		{
			get => Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum_.FromTSObject(teklaObject.Visibility);
			set { teklaObject.Visibility = Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum_.GetTSObject(value); }
		}

		public System.Guid BasePointGuid
		{
			get => teklaObject.BasePointGuid;
			set { teklaObject.BasePointGuid = value; }
		}

		public System.Double Rotation
		{
			get => teklaObject.Rotation;
			set { teklaObject.Rotation = value; }
		}

		public System.Guid ProjectGUID
		{
			get => teklaObject.ProjectGUID;
			set { teklaObject.ProjectGUID = value; }
		}

		public System.Guid ModelGUID
		{
			get => teklaObject.ModelGUID;
			set { teklaObject.ModelGUID = value; }
		}

		public System.Guid VersionGUID
		{
			get => teklaObject.VersionGUID;
			set { teklaObject.VersionGUID = value; }
		}

        

        

		public ReferenceModel()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModel");
		}
		public ReferenceModel(System.String filename, Dynamic.Tekla.Structures.Geometry3d.Point position, System.Double scale)
		{
			var args = new object[3];
			args[0] = filename;
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(position);
			args[2] = scale;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModel", args);
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetConvertedObjects()
			 => Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetConvertedObjects());

		public System.Boolean RefreshFile()
			 => teklaObject.RefreshFile();

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ReferenceModel.Revision> GetRevisions()
			 => teklaObject.GetRevisions();

		public Dynamic.Tekla.Structures.Model.ReferenceModelObject GetReferenceModelObjectByExternalGuid(System.String externalGuid)
			 => Dynamic.Tekla.Structures.Model.ReferenceModelObject_.FromTSObject(teklaObject.GetReferenceModelObjectByExternalGuid(externalGuid));

		public System.Boolean SetAsCurrentRevision(Dynamic.Tekla.Structures.Model.ReferenceModel.Revision revision)
			 => teklaObject.SetAsCurrentRevision(Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.GetTSObject(revision));

		public System.Boolean SetAsCurrentRevision(System.Int32 modelId, System.Int32 revisionId)
			 => teklaObject.SetAsCurrentRevision(modelId, revisionId);

		public Dynamic.Tekla.Structures.Model.ReferenceModel.Revision GetCurrentRevision()
			 => Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.FromTSObject(teklaObject.GetCurrentRevision());

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
            return dynObject.teklaObject;
        }

        public static ReferenceModel FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ReferenceModel)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
