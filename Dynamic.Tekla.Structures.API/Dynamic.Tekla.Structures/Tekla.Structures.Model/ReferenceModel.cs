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
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position);
			}
			set
			{
				teklaObject.Position = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
			}
		}

		public System.Double Scale
		{
			get => teklaObject.Scale;
			set { teklaObject.Scale = value; }
		}

		public Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum Visibility
		{
			get
			{
				 return Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum_.FromTSObject(teklaObject.Visibility);
			}
			set
			{
				teklaObject.Visibility = Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum_.GetTSObject(value);
			}
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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ReferenceModel(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
			try {
			return Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(teklaObject.GetConvertedObjects());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetConvertedObjects()"); }
		}

		public System.Boolean RefreshFile()
		{
			try {
			return teklaObject.RefreshFile();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("RefreshFile()"); }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ReferenceModel.Revision> GetRevisions()
		{
			try {
			return teklaObject.GetRevisions();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetRevisions()"); }
		}

		public Dynamic.Tekla.Structures.Model.ReferenceModelObject GetReferenceModelObjectByExternalGuid(System.String externalGuid)
		{
			try {
			return Dynamic.Tekla.Structures.Model.ReferenceModelObject_.FromTSObject(teklaObject.GetReferenceModelObjectByExternalGuid(externalGuid));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetReferenceModelObjectByExternalGuid()"); }
		}

		public System.Boolean SetAsCurrentRevision(Dynamic.Tekla.Structures.Model.ReferenceModel.Revision revision)
		{
			try {
			return teklaObject.SetAsCurrentRevision(Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.GetTSObject(revision));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetAsCurrentRevision()"); }
		}

		public System.Boolean SetAsCurrentRevision(System.Int32 modelId, System.Int32 revisionId)
		{
			try {
			return teklaObject.SetAsCurrentRevision(modelId, revisionId);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetAsCurrentRevision()"); }
		}

		public Dynamic.Tekla.Structures.Model.ReferenceModel.Revision GetCurrentRevision()
		{
			try {
			return Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.FromTSObject(teklaObject.GetCurrentRevision());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetCurrentRevision()"); }
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
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
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
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class ReferenceModel_
    {
        public static dynamic GetTSObject(ReferenceModel dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReferenceModel FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ReferenceModel)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelArray_
    {
        public static dynamic GetTSObject(ReferenceModel[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModel_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModel[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReferenceModel>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModel_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
