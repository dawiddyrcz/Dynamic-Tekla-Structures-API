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
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingUpToDateStatus UpToDateStatus
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingUpToDateStatus_.FromTSObject(teklaObject.UpToDateStatus);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpToDateStatus"); }
			}
			set
			{
				try {
				teklaObject.UpToDateStatus = Dynamic.Tekla.Structures.Drawing.DrawingUpToDateStatus_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("UpToDateStatus"); }
			}
		}

		public System.Boolean IsMasterDrawing
		{
			get
			{
				try {
					return teklaObject.IsMasterDrawing;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMasterDrawing"); }
			}
			set
			{
				try {
					teklaObject.IsMasterDrawing = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMasterDrawing"); }
			}
		}

		public System.Boolean IsLocked
		{
			get
			{
				try {
					return teklaObject.IsLocked;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsLocked"); }
			}
			set
			{
				try {
					teklaObject.IsLocked = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsLocked"); }
			}
		}

		public System.Boolean IsIssued
		{
			get
			{
				try {
					return teklaObject.IsIssued;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsIssued"); }
			}
			set
			{
				try {
					teklaObject.IsIssued = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsIssued"); }
			}
		}

		public System.Boolean IsIssuedButModified
		{
			get
			{
				try {
					return teklaObject.IsIssuedButModified;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsIssuedButModified"); }
			}
			set
			{
				try {
					teklaObject.IsIssuedButModified = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsIssuedButModified"); }
			}
		}

		public System.Boolean IsFrozen
		{
			get
			{
				try {
					return teklaObject.IsFrozen;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsFrozen"); }
			}
			set
			{
				try {
					teklaObject.IsFrozen = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsFrozen"); }
			}
		}

		public System.Boolean IsReadyForIssue
		{
			get
			{
				try {
					return teklaObject.IsReadyForIssue;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadyForIssue"); }
			}
			set
			{
				try {
					teklaObject.IsReadyForIssue = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadyForIssue"); }
			}
		}

		public System.String Title1
		{
			get
			{
				try {
					return teklaObject.Title1;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title1"); }
			}
			set
			{
				try {
					teklaObject.Title1 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title1"); }
			}
		}

		public System.String Title2
		{
			get
			{
				try {
					return teklaObject.Title2;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title2"); }
			}
			set
			{
				try {
					teklaObject.Title2 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title2"); }
			}
		}

		public System.String Title3
		{
			get
			{
				try {
					return teklaObject.Title3;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title3"); }
			}
			set
			{
				try {
					teklaObject.Title3 = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Title3"); }
			}
		}

		public System.String Mark
		{
			get
			{
				try {
					return teklaObject.Mark;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Mark"); }
			}
			set
			{
				try {
					teklaObject.Mark = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Mark"); }
			}
		}

		public System.DateTime CreationDate
		{
			get
			{
				try {
					return teklaObject.CreationDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreationDate"); }
			}
			set
			{
				try {
					teklaObject.CreationDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreationDate"); }
			}
		}

		public System.DateTime ModificationDate
		{
			get
			{
				try {
					return teklaObject.ModificationDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModificationDate"); }
			}
			set
			{
				try {
					teklaObject.ModificationDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ModificationDate"); }
			}
		}

		public System.DateTime IssuingDate
		{
			get
			{
				try {
					return teklaObject.IssuingDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IssuingDate"); }
			}
			set
			{
				try {
					teklaObject.IssuingDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IssuingDate"); }
			}
		}

		public System.DateTime OutputDate
		{
			get
			{
				try {
					return teklaObject.OutputDate;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OutputDate"); }
			}
			set
			{
				try {
					teklaObject.OutputDate = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OutputDate"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LayoutAttributes Layout
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LayoutAttributes_.FromTSObject(teklaObject.Layout);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Layout"); }
			}
			set
			{
				try {
				teklaObject.Layout = Dynamic.Tekla.Structures.Drawing.LayoutAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Layout"); }
			}
		}

		public System.String SectionViewStartLabel
		{
			get
			{
				try {
					return teklaObject.SectionViewStartLabel;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SectionViewStartLabel"); }
			}
			set
			{
				try {
					teklaObject.SectionViewStartLabel = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("SectionViewStartLabel"); }
			}
		}

		public System.String IsReadyForIssueBy
		{
			get
			{
				try {
					return teklaObject.IsReadyForIssueBy;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadyForIssueBy"); }
			}
			set
			{
				try {
					teklaObject.IsReadyForIssueBy = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsReadyForIssueBy"); }
			}
		}

		public System.String IsLockedBy
		{
			get
			{
				try {
					return teklaObject.IsLockedBy;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsLockedBy"); }
			}
			set
			{
				try {
					teklaObject.IsLockedBy = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsLockedBy"); }
			}
		}

		public System.String CommitMessage
		{
			get
			{
				try {
					return teklaObject.CommitMessage;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CommitMessage"); }
			}
			set
			{
				try {
					teklaObject.CommitMessage = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CommitMessage"); }
			}
		}

        

        


		public Dynamic.Tekla.Structures.Drawing.ContainerView GetSheet()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.ContainerView_.FromTSObject(teklaObject.GetSheet());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetSheet()"); }
		}

		public System.Boolean CommitChanges()
		{
			try {
			var result = teklaObject.CommitChanges();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CommitChanges()"); }
		}

		public System.Boolean CommitChanges(System.String Message)
		{
			try {
			var result = teklaObject.CommitChanges(Message);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CommitChanges()"); }
		}

		public System.Boolean PlaceViews()
		{
			try {
			var result = teklaObject.PlaceViews();
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PlaceViews()"); }
		}

		public System.String GetPlotFileName(System.Boolean includeRevisionInfo)
		{
			try {
			var result = teklaObject.GetPlotFileName(includeRevisionInfo);
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPlotFileName()"); }
		}

		public System.String GetPlotFileNameExt(Dynamic.Tekla.Structures.Drawing.IncludeRevisionMarkEnum includeRevisionInfo)
		{
			try {
			var result = teklaObject.GetPlotFileNameExt(Dynamic.Tekla.Structures.Drawing.IncludeRevisionMarkEnum_.GetTSObject(includeRevisionInfo));
			return result;
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPlotFileNameExt()"); }
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
    
