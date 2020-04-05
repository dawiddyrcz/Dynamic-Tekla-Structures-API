/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class GridLine  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {

		public Dynamic.Tekla.Structures.Drawing.GridLine.GridLineAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.GridLine.GridLineAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.GridLine.GridLineAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.GridLine.GridLabel StartLabel
		{
			get => Dynamic.Tekla.Structures.Drawing.GridLine.GridLabel_.FromTSObject(teklaObject.StartLabel);
			set { teklaObject.StartLabel = Dynamic.Tekla.Structures.Drawing.GridLine.GridLabel_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.GridLine.GridLabel EndLabel
		{
			get => Dynamic.Tekla.Structures.Drawing.GridLine.GridLabel_.FromTSObject(teklaObject.EndLabel);
			set { teklaObject.EndLabel = Dynamic.Tekla.Structures.Drawing.GridLine.GridLabel_.GetTSObject(value); }
		}

        

        

		internal GridLine() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GridLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}




    public  class GridLabel 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point CenterPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.CenterPoint);
			set { teklaObject.CenterPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Double FrameWidth
		{
			get => teklaObject.FrameWidth;
			set { teklaObject.FrameWidth = value; }
		}

		public System.Double FrameHeight
		{
			get => teklaObject.FrameHeight;
			set { teklaObject.FrameHeight = value; }
		}

		public System.Double TextWidth
		{
			get => teklaObject.TextWidth;
			set { teklaObject.TextWidth = value; }
		}

		public System.Double TextHeight
		{
			get => teklaObject.TextHeight;

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point GridPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.GridPoint);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point OffsetGridPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.OffsetGridPoint);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point GridLabelPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.GridLabelPoint);
			set { teklaObject.GridLabelPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.String GridLabelText
		{
			get => teklaObject.GridLabelText;
			set { teklaObject.GridLabelText = value; }
		}

        

        internal dynamic teklaObject;

		public GridLabel()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.GridLine.GridLabel");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GridLabel(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBoxOfTextLabel()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBoxOfTextLabel());
		}

		public System.Boolean MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector MoveVector)
		{
			return teklaObject.MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(MoveVector));
		}





    }

    internal static class GridLabel_
    {
        public static dynamic GetTSObject(GridLabel dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GridLabel FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.GridLine.GridLabel)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridLabelArray_
    {
        public static dynamic GetTSObject(GridLabel[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GridLabel_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GridLabel[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GridLabel>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GridLabel_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    public  class GridLineAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get => Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
			set { teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.Line);
			set { teklaObject.Line = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.Frame Frame
		{
			get => Dynamic.Tekla.Structures.Drawing.Frame_.FromTSObject(teklaObject.Frame);
			set { teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.Frame_.GetTSObject(value); }
		}

		public System.Double OffsetAtStartOfLine
		{
			get => teklaObject.OffsetAtStartOfLine;
			set { teklaObject.OffsetAtStartOfLine = value; }
		}

		public System.Double OffsetAtEndOfLine
		{
			get => teklaObject.OffsetAtEndOfLine;
			set { teklaObject.OffsetAtEndOfLine = value; }
		}

		public System.Boolean DrawTextAtStartOfGridLine
		{
			get => teklaObject.DrawTextAtStartOfGridLine;
			set { teklaObject.DrawTextAtStartOfGridLine = value; }
		}

		public System.Boolean DrawTextAtEndOfGridLine
		{
			get => teklaObject.DrawTextAtEndOfGridLine;
			set { teklaObject.DrawTextAtEndOfGridLine = value; }
		}

		public System.Boolean DrawOnlyTextLabelsNotGridLines
		{
			get => teklaObject.DrawOnlyTextLabelsNotGridLines;
			set { teklaObject.DrawOnlyTextLabelsNotGridLines = value; }
		}

		public System.String CustomPresentation
		{
			get => teklaObject.CustomPresentation;
			set { teklaObject.CustomPresentation = value; }
		}

        

        

		public GridLineAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.GridLine.GridLineAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GridLineAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public GridLineAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.GridLine.GridLineAttributes", args);
		}

		public System.Boolean LoadAttributes(System.String AttributeFile)
		{
			return teklaObject.LoadAttributes(AttributeFile);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class GridLineAttributes_
    {
        public static dynamic GetTSObject(GridLineAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GridLineAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.GridLine.GridLineAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridLineAttributesArray_
    {
        public static dynamic GetTSObject(GridLineAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GridLineAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GridLineAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GridLineAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GridLineAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class GridLine_
    {
        public static dynamic GetTSObject(GridLine dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GridLine FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.GridLine)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridLineArray_
    {
        public static dynamic GetTSObject(GridLine[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GridLine_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GridLine[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GridLine>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GridLine_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
