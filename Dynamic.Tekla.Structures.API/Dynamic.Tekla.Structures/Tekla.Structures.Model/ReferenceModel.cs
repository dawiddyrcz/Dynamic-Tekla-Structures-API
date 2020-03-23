/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
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
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetConvertedObjects());
		}

		public System.Boolean RefreshFile()
		{
			return teklaObject.RefreshFile();
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ReferenceModel.Revision> GetRevisions()
		{
			return teklaObject.GetRevisions();
		}

		public Dynamic.Tekla.Structures.Model.ReferenceModelObject GetReferenceModelObjectByExternalGuid(System.String externalGuid)
		{
			return Dynamic.Tekla.Structures.Model.ReferenceModelObject_.FromTSObject(teklaObject.GetReferenceModelObjectByExternalGuid(externalGuid));
		}

		public System.Boolean SetAsCurrentRevision(Dynamic.Tekla.Structures.Model.ReferenceModel.Revision revision)
		{
			return teklaObject.SetAsCurrentRevision(Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.GetTSObject(revision));
		}

		public System.Boolean SetAsCurrentRevision(System.Int32 modelId, System.Int32 revisionId)
		{
			return teklaObject.SetAsCurrentRevision(modelId, revisionId);
		}

		public Dynamic.Tekla.Structures.Model.ReferenceModel.Revision GetCurrentRevision()
		{
			return Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.FromTSObject(teklaObject.GetCurrentRevision());
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public Dynamic.Tekla.Structures.Model.ModelObjectEnumerator GetChildren()
		{
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetChildren());
		}




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
            var dynObject = (Dynamic.Tekla.Structures.Model.ReferenceModel)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelArray_
    {
        public static dynamic GetTSObject(ReferenceModel[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModel_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModel[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ReferenceModel>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModel_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
