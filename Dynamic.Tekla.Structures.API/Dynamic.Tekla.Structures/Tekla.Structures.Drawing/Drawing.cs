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
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingUpToDateStatus UpToDateStatus
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.DrawingUpToDateStatus_.FromTSObject(teklaObject.UpToDateStatus);
			}
			set
			{
				teklaObject.UpToDateStatus = Dynamic.Tekla.Structures.Drawing.DrawingUpToDateStatus_.GetTSObject(value);
			}
		}

		public System.Boolean IsMasterDrawing
		{
			get => teklaObject.IsMasterDrawing;
			set { teklaObject.IsMasterDrawing = value; }
		}

		public System.Boolean IsLocked
		{
			get => teklaObject.IsLocked;
			set { teklaObject.IsLocked = value; }
		}

		public System.Boolean IsIssued
		{
			get => teklaObject.IsIssued;
			set { teklaObject.IsIssued = value; }
		}

		public System.Boolean IsIssuedButModified
		{
			get => teklaObject.IsIssuedButModified;
			set { teklaObject.IsIssuedButModified = value; }
		}

		public System.Boolean IsFrozen
		{
			get => teklaObject.IsFrozen;
			set { teklaObject.IsFrozen = value; }
		}

		public System.Boolean IsReadyForIssue
		{
			get => teklaObject.IsReadyForIssue;
			set { teklaObject.IsReadyForIssue = value; }
		}

		public System.String Title1
		{
			get => teklaObject.Title1;
			set { teklaObject.Title1 = value; }
		}

		public System.String Title2
		{
			get => teklaObject.Title2;
			set { teklaObject.Title2 = value; }
		}

		public System.String Title3
		{
			get => teklaObject.Title3;
			set { teklaObject.Title3 = value; }
		}

		public System.String Mark
		{
			get => teklaObject.Mark;
			set { teklaObject.Mark = value; }
		}

		public System.DateTime CreationDate
		{
			get => teklaObject.CreationDate;
			set { teklaObject.CreationDate = value; }
		}

		public System.DateTime ModificationDate
		{
			get => teklaObject.ModificationDate;
			set { teklaObject.ModificationDate = value; }
		}

		public System.DateTime IssuingDate
		{
			get => teklaObject.IssuingDate;
			set { teklaObject.IssuingDate = value; }
		}

		public System.DateTime OutputDate
		{
			get => teklaObject.OutputDate;
			set { teklaObject.OutputDate = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.LayoutAttributes Layout
		{
			get
			{
				 return Dynamic.Tekla.Structures.Drawing.LayoutAttributes_.FromTSObject(teklaObject.Layout);
			}
			set
			{
				teklaObject.Layout = Dynamic.Tekla.Structures.Drawing.LayoutAttributes_.GetTSObject(value);
			}
		}

		public System.String SectionViewStartLabel
		{
			get => teklaObject.SectionViewStartLabel;
			set { teklaObject.SectionViewStartLabel = value; }
		}

		public System.String IsReadyForIssueBy
		{
			get => teklaObject.IsReadyForIssueBy;
			set { teklaObject.IsReadyForIssueBy = value; }
		}

		public System.String IsLockedBy
		{
			get => teklaObject.IsLockedBy;
			set { teklaObject.IsLockedBy = value; }
		}

		public System.String CommitMessage
		{
			get => teklaObject.CommitMessage;
			set { teklaObject.CommitMessage = value; }
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
			return teklaObject.CommitChanges();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CommitChanges()"); }
		}

		public System.Boolean CommitChanges(System.String Message)
		{
			try {
			return teklaObject.CommitChanges(Message);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("CommitChanges()"); }
		}

		public System.Boolean PlaceViews()
		{
			try {
			return teklaObject.PlaceViews();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PlaceViews()"); }
		}

		public System.String GetPlotFileName(System.Boolean includeRevisionInfo)
		{
			try {
			return teklaObject.GetPlotFileName(includeRevisionInfo);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetPlotFileName()"); }
		}

		public System.String GetPlotFileNameExt(Dynamic.Tekla.Structures.Drawing.IncludeRevisionMarkEnum includeRevisionInfo)
		{
			try {
			return teklaObject.GetPlotFileNameExt(Dynamic.Tekla.Structures.Drawing.IncludeRevisionMarkEnum_.GetTSObject(includeRevisionInfo));
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
    
