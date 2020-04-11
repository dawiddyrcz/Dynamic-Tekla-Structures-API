/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class Drawing  : Dynamic.Tekla.Structures.Drawing.DatabaseObject
    {

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingUpToDateStatus UpToDateStatus
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingUpToDateStatus_.FromTSObject(teklaObject.UpToDateStatus);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpToDateStatus", ex); }
			}
			set
			{
				try {
				teklaObject.UpToDateStatus = Dynamic.Tekla.Structures.Drawing.DrawingUpToDateStatus_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpToDateStatus", ex); }
			}
		}

		public System.Boolean IsMasterDrawing
		{
			get
			{
				try {
					return teklaObject.IsMasterDrawing;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMasterDrawing", ex); }
			}
			set
			{
				try {
					teklaObject.IsMasterDrawing = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMasterDrawing", ex); }
			}
		}

		public System.Boolean IsLocked
		{
			get
			{
				try {
					return teklaObject.IsLocked;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsLocked", ex); }
			}
			set
			{
				try {
					teklaObject.IsLocked = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsLocked", ex); }
			}
		}

		public System.Boolean IsIssued
		{
			get
			{
				try {
					return teklaObject.IsIssued;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsIssued", ex); }
			}
			set
			{
				try {
					teklaObject.IsIssued = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsIssued", ex); }
			}
		}

		public System.Boolean IsIssuedButModified
		{
			get
			{
				try {
					return teklaObject.IsIssuedButModified;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsIssuedButModified", ex); }
			}
			set
			{
				try {
					teklaObject.IsIssuedButModified = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsIssuedButModified", ex); }
			}
		}

		public System.Boolean IsFrozen
		{
			get
			{
				try {
					return teklaObject.IsFrozen;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsFrozen", ex); }
			}
			set
			{
				try {
					teklaObject.IsFrozen = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsFrozen", ex); }
			}
		}

		public System.Boolean IsReadyForIssue
		{
			get
			{
				try {
					return teklaObject.IsReadyForIssue;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadyForIssue", ex); }
			}
			set
			{
				try {
					teklaObject.IsReadyForIssue = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadyForIssue", ex); }
			}
		}

		public System.String Title1
		{
			get
			{
				try {
					return teklaObject.Title1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title1", ex); }
			}
			set
			{
				try {
					teklaObject.Title1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title1", ex); }
			}
		}

		public System.String Title2
		{
			get
			{
				try {
					return teklaObject.Title2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title2", ex); }
			}
			set
			{
				try {
					teklaObject.Title2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title2", ex); }
			}
		}

		public System.String Title3
		{
			get
			{
				try {
					return teklaObject.Title3;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title3", ex); }
			}
			set
			{
				try {
					teklaObject.Title3 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title3", ex); }
			}
		}

		public System.String Mark
		{
			get
			{
				try {
					return teklaObject.Mark;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Mark", ex); }
			}
			set
			{
				try {
					teklaObject.Mark = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Mark", ex); }
			}
		}

		public System.DateTime CreationDate
		{
			get
			{
				try {
					return teklaObject.CreationDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreationDate", ex); }
			}
			set
			{
				try {
					teklaObject.CreationDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreationDate", ex); }
			}
		}

		public System.DateTime ModificationDate
		{
			get
			{
				try {
					return teklaObject.ModificationDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModificationDate", ex); }
			}
			set
			{
				try {
					teklaObject.ModificationDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModificationDate", ex); }
			}
		}

		public System.DateTime IssuingDate
		{
			get
			{
				try {
					return teklaObject.IssuingDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IssuingDate", ex); }
			}
			set
			{
				try {
					teklaObject.IssuingDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IssuingDate", ex); }
			}
		}

		public System.DateTime OutputDate
		{
			get
			{
				try {
					return teklaObject.OutputDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OutputDate", ex); }
			}
			set
			{
				try {
					teklaObject.OutputDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OutputDate", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LayoutAttributes Layout
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LayoutAttributes_.FromTSObject(teklaObject.Layout);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Layout", ex); }
			}
			set
			{
				try {
				teklaObject.Layout = Dynamic.Tekla.Structures.Drawing.LayoutAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Layout", ex); }
			}
		}

		public System.String SectionViewStartLabel
		{
			get
			{
				try {
					return teklaObject.SectionViewStartLabel;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SectionViewStartLabel", ex); }
			}
			set
			{
				try {
					teklaObject.SectionViewStartLabel = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SectionViewStartLabel", ex); }
			}
		}

		public System.String IsReadyForIssueBy
		{
			get
			{
				try {
					return teklaObject.IsReadyForIssueBy;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadyForIssueBy", ex); }
			}
			set
			{
				try {
					teklaObject.IsReadyForIssueBy = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadyForIssueBy", ex); }
			}
		}

		public System.String IsLockedBy
		{
			get
			{
				try {
					return teklaObject.IsLockedBy;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsLockedBy", ex); }
			}
			set
			{
				try {
					teklaObject.IsLockedBy = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsLockedBy", ex); }
			}
		}

		public System.String CommitMessage
		{
			get
			{
				try {
					return teklaObject.CommitMessage;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CommitMessage", ex); }
			}
			set
			{
				try {
					teklaObject.CommitMessage = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CommitMessage", ex); }
			}
		}

        

        



public Dynamic.Tekla.Structures.Drawing.ContainerView GetSheet()
{

    try
    {
        	var result = teklaObject.GetSheet();

        	var _result = Dynamic.Tekla.Structures.Drawing.ContainerView_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSheet), ex);
    }
}



public System.Boolean CommitChanges()
{

    try
    {
        	var result = (System.Boolean) teklaObject.CommitChanges();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CommitChanges), ex);
    }
}



public System.Boolean CommitChanges(
	System.String Message
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.CommitChanges(Message);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CommitChanges), ex);
    }
}



public System.Boolean PlaceViews()
{

    try
    {
        	var result = (System.Boolean) teklaObject.PlaceViews();

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(PlaceViews), ex);
    }
}



public System.String GetPlotFileName(
	System.Boolean includeRevisionInfo
	)
{
	
    try
    {
        	var result = (System.String) teklaObject.GetPlotFileName(includeRevisionInfo);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPlotFileName), ex);
    }
}



public System.String GetPlotFileNameExt(
	Dynamic.Tekla.Structures.Drawing.IncludeRevisionMarkEnum includeRevisionInfo_
	)
{
	var includeRevisionInfo = Dynamic.Tekla.Structures.Drawing.IncludeRevisionMarkEnum_.GetTSObject(includeRevisionInfo_);
    try
    {
        	var result = (System.String) teklaObject.GetPlotFileNameExt(includeRevisionInfo);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPlotFileNameExt), ex);
    }
}






    }

    internal static class Drawing_
    {
        public static dynamic GetTSObject(Drawing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Drawing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Drawing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingArray_
    {
        public static dynamic GetTSObject(Drawing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Drawing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Drawing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Drawing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Drawing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
