/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Grid  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {

		public Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes_.GetTSObject(value); }
		}

        

        

		public Grid() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects());
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects(System.Type[] TypeFilter)
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects(TypeFilter));
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




    public  class GridAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
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

		public System.Boolean DrawTextAtBottomOfGrid
		{
			get => teklaObject.DrawTextAtBottomOfGrid;
			set { teklaObject.DrawTextAtBottomOfGrid = value; }
		}

		public System.Boolean DrawTextAtTopOfGrid
		{
			get => teklaObject.DrawTextAtTopOfGrid;
			set { teklaObject.DrawTextAtTopOfGrid = value; }
		}

		public System.Boolean DrawTextAtLeftOfGrid
		{
			get => teklaObject.DrawTextAtLeftOfGrid;
			set { teklaObject.DrawTextAtLeftOfGrid = value; }
		}

		public System.Boolean DrawTextAtRightOfGrid
		{
			get => teklaObject.DrawTextAtRightOfGrid;
			set { teklaObject.DrawTextAtRightOfGrid = value; }
		}

		public System.Boolean DrawOnlyTextLabelsNotGrids
		{
			get => teklaObject.DrawOnlyTextLabelsNotGrids;
			set { teklaObject.DrawOnlyTextLabelsNotGrids = value; }
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

        

        

		public GridAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Grid.GridAttributes");
		}
		public GridAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Grid.GridAttributes", args);
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

    internal static class GridAttributes_
    {
        public static dynamic GetTSObject(GridAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GridAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridAttributesArray_
    {
        public static dynamic GetTSObject(GridAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GridAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GridAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<GridAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GridAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class Grid_
    {
        public static dynamic GetTSObject(Grid dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Grid FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.Grid)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridArray_
    {
        public static dynamic GetTSObject(Grid[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Grid_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Grid[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Grid>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Grid_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
