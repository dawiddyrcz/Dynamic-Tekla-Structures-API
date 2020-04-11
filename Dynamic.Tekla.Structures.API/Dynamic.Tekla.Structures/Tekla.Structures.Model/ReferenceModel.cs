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
			get
			{
				try {
					return teklaObject.Filename;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Filename", ex); }
			}
			set
			{
				try {
					teklaObject.Filename = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Filename", ex); }
			}
		}

		public System.String ActiveFilePath
		{
			get
			{
				try {
					return teklaObject.ActiveFilePath;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActiveFilePath", ex); }
			}
			set
			{
				try {
					teklaObject.ActiveFilePath = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ActiveFilePath", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position", ex); }
			}
			set
			{
				try {
				teklaObject.Position = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Position", ex); }
			}
		}

		public System.Double Scale
		{
			get
			{
				try {
					return teklaObject.Scale;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scale", ex); }
			}
			set
			{
				try {
					teklaObject.Scale = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Scale", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum Visibility
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum_.FromTSObject(teklaObject.Visibility);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Visibility", ex); }
			}
			set
			{
				try {
				teklaObject.Visibility = Dynamic.Tekla.Structures.Model.ReferenceModel.VisibilityEnum_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Visibility", ex); }
			}
		}

		public System.Guid BasePointGuid
		{
			get
			{
				try {
					return teklaObject.BasePointGuid;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BasePointGuid", ex); }
			}
			set
			{
				try {
					teklaObject.BasePointGuid = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("BasePointGuid", ex); }
			}
		}

		public System.Double Rotation
		{
			get
			{
				try {
					return teklaObject.Rotation;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Rotation", ex); }
			}
			set
			{
				try {
					teklaObject.Rotation = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Rotation", ex); }
			}
		}

		public System.Guid ProjectGUID
		{
			get
			{
				try {
					return teklaObject.ProjectGUID;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProjectGUID", ex); }
			}
			set
			{
				try {
					teklaObject.ProjectGUID = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ProjectGUID", ex); }
			}
		}

		public System.Guid ModelGUID
		{
			get
			{
				try {
					return teklaObject.ModelGUID;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelGUID", ex); }
			}
			set
			{
				try {
					teklaObject.ModelGUID = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModelGUID", ex); }
			}
		}

		public System.Guid VersionGUID
		{
			get
			{
				try {
					return teklaObject.VersionGUID;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("VersionGUID", ex); }
			}
			set
			{
				try {
					teklaObject.VersionGUID = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("VersionGUID", ex); }
			}
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

    try
    {
        	var result = teklaObject.GetConvertedObjects();

        	var _result = Dynamic.Tekla.Structures.Model.ModelObjectEnumerator_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetConvertedObjects), ex);
    }
}



public System.Boolean RefreshFile()
{

    try
    {
        	var result = (System.Boolean) teklaObject.RefreshFile();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RefreshFile), ex);
    }
}



public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ReferenceModel.Revision> GetRevisions()
{

    try
    {
        	var result = teklaObject.GetRevisions();

        	var _result = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Model.ReferenceModel.Revision>(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetRevisions), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ReferenceModelObject GetReferenceModelObjectByExternalGuid(
	System.String externalGuid
	)
{
	
    try
    {
        	var result = teklaObject.GetReferenceModelObjectByExternalGuid(externalGuid);

        	var _result = Dynamic.Tekla.Structures.Model.ReferenceModelObject_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReferenceModelObjectByExternalGuid), ex);
    }
}



public System.Boolean SetAsCurrentRevision(
	Dynamic.Tekla.Structures.Model.ReferenceModel.Revision revision_
	)
{
	var revision = Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.GetTSObject(revision_);
    try
    {
        	var result = (System.Boolean) teklaObject.SetAsCurrentRevision(revision);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAsCurrentRevision), ex);
    }
}



public System.Boolean SetAsCurrentRevision(
	System.Int32 modelId,
	System.Int32 revisionId
	)
{
	
	
    try
    {
        	var result = (System.Boolean) teklaObject.SetAsCurrentRevision(modelId, revisionId);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAsCurrentRevision), ex);
    }
}



public Dynamic.Tekla.Structures.Model.ReferenceModel.Revision GetCurrentRevision()
{

    try
    {
        	var result = teklaObject.GetCurrentRevision();

        	var _result = Dynamic.Tekla.Structures.Model.ReferenceModel.Revision_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCurrentRevision), ex);
    }
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
    
