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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes_.FromTSObject(teklaObject.Attributes);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
			set
			{
				try {
				teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Attributes"); }
			}
		}

        

        

		internal Grid() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Grid(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetObjects()"); }
		}




    public  class GridAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font"); }
			}
			set
			{
				try {
				teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Font"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.Line);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Line"); }
			}
			set
			{
				try {
				teklaObject.Line = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Line"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.Frame Frame
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.Frame_.FromTSObject(teklaObject.Frame);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame"); }
			}
			set
			{
				try {
				teklaObject.Frame = Dynamic.Tekla.Structures.Drawing.Frame_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Frame"); }
			}
		}

		public System.Boolean DrawTextAtBottomOfGrid
		{
			get
			{
				try {
					return teklaObject.DrawTextAtBottomOfGrid;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawTextAtBottomOfGrid"); }
			}
			set
			{
				try {
					teklaObject.DrawTextAtBottomOfGrid = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawTextAtBottomOfGrid"); }
			}
		}

		public System.Boolean DrawTextAtTopOfGrid
		{
			get
			{
				try {
					return teklaObject.DrawTextAtTopOfGrid;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawTextAtTopOfGrid"); }
			}
			set
			{
				try {
					teklaObject.DrawTextAtTopOfGrid = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawTextAtTopOfGrid"); }
			}
		}

		public System.Boolean DrawTextAtLeftOfGrid
		{
			get
			{
				try {
					return teklaObject.DrawTextAtLeftOfGrid;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawTextAtLeftOfGrid"); }
			}
			set
			{
				try {
					teklaObject.DrawTextAtLeftOfGrid = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawTextAtLeftOfGrid"); }
			}
		}

		public System.Boolean DrawTextAtRightOfGrid
		{
			get
			{
				try {
					return teklaObject.DrawTextAtRightOfGrid;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawTextAtRightOfGrid"); }
			}
			set
			{
				try {
					teklaObject.DrawTextAtRightOfGrid = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawTextAtRightOfGrid"); }
			}
		}

		public System.Boolean DrawOnlyTextLabelsNotGrids
		{
			get
			{
				try {
					return teklaObject.DrawOnlyTextLabelsNotGrids;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawOnlyTextLabelsNotGrids"); }
			}
			set
			{
				try {
					teklaObject.DrawOnlyTextLabelsNotGrids = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawOnlyTextLabelsNotGrids"); }
			}
		}

		public System.Double OffsetAtStartOfLine
		{
			get
			{
				try {
					return teklaObject.OffsetAtStartOfLine;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OffsetAtStartOfLine"); }
			}
			set
			{
				try {
					teklaObject.OffsetAtStartOfLine = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OffsetAtStartOfLine"); }
			}
		}

		public System.Double OffsetAtEndOfLine
		{
			get
			{
				try {
					return teklaObject.OffsetAtEndOfLine;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OffsetAtEndOfLine"); }
			}
			set
			{
				try {
					teklaObject.OffsetAtEndOfLine = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("OffsetAtEndOfLine"); }
			}
		}

        

        

		public GridAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Grid.GridAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GridAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public GridAttributes(System.String AttributesFile)
		{
			var args = new object[1];
			args[0] = AttributesFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Grid.GridAttributes", args);
		}





    }

    internal static class GridAttributes_
    {
        public static dynamic GetTSObject(GridAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GridAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridAttributesArray_
    {
        public static dynamic GetTSObject(GridAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GridAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GridAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
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
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Grid FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Grid)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridArray_
    {
        public static dynamic GetTSObject(Grid[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Grid_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Grid[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Grid>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Grid_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
