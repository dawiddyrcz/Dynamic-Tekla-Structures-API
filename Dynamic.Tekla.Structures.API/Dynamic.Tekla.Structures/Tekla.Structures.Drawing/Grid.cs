/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Grid  : Dynamic.Tekla.Structures.Drawing.ModelObject
    {


        public Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes Attributes
        {
            get
            {
                try
                {
                var value = teklaObject.Attributes;
                var value_ = Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.Grid.GridAttributes_.GetTSObject(value);
                teklaObject.Attributes = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Attributes), ex); 
                }
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
            
            try
            {
                var result = teklaObject.GetObjects();
            
                var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
            }
        }



        public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects(
			System.Type[] TypeFilter_)
        {
            var TypeFilter = TypeConverter.ToTSObjects(TypeFilter_);
            try
            {
                var result = teklaObject.GetObjects(TypeFilter);
            
                var _result = Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
            }
        }





    public  class GridAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {


        public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
        {
            get
            {
                try
                {
                var value = teklaObject.Font;
                var value_ = Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.FontAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Font), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value);
                teklaObject.Font = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Font), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
        {
            get
            {
                try
                {
                var value = teklaObject.Line;
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.LineTypeAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Line), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
                teklaObject.Line = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Line), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.Frame Frame
        {
            get
            {
                try
                {
                var value = teklaObject.Frame;
                var value_ = Dynamic.Tekla.Structures.Drawing.Frame_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.Frame) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Frame), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.Frame_.GetTSObject(value);
                teklaObject.Frame = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Frame), ex); 
                }
            }
        }

        public System.Boolean DrawTextAtBottomOfGrid
        {
            get
            {
                try
                {
                return teklaObject.DrawTextAtBottomOfGrid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawTextAtBottomOfGrid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.DrawTextAtBottomOfGrid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawTextAtBottomOfGrid), ex); 
                }
            }
        }

        public System.Boolean DrawTextAtTopOfGrid
        {
            get
            {
                try
                {
                return teklaObject.DrawTextAtTopOfGrid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawTextAtTopOfGrid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.DrawTextAtTopOfGrid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawTextAtTopOfGrid), ex); 
                }
            }
        }

        public System.Boolean DrawTextAtLeftOfGrid
        {
            get
            {
                try
                {
                return teklaObject.DrawTextAtLeftOfGrid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawTextAtLeftOfGrid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.DrawTextAtLeftOfGrid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawTextAtLeftOfGrid), ex); 
                }
            }
        }

        public System.Boolean DrawTextAtRightOfGrid
        {
            get
            {
                try
                {
                return teklaObject.DrawTextAtRightOfGrid;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawTextAtRightOfGrid), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.DrawTextAtRightOfGrid = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawTextAtRightOfGrid), ex); 
                }
            }
        }

        public System.Boolean DrawOnlyTextLabelsNotGrids
        {
            get
            {
                try
                {
                return teklaObject.DrawOnlyTextLabelsNotGrids;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawOnlyTextLabelsNotGrids), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.DrawOnlyTextLabelsNotGrids = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawOnlyTextLabelsNotGrids), ex); 
                }
            }
        }

        public System.Double OffsetAtStartOfLine
        {
            get
            {
                try
                {
                return teklaObject.OffsetAtStartOfLine;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetAtStartOfLine), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.OffsetAtStartOfLine = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetAtStartOfLine), ex); 
                }
            }
        }

        public System.Double OffsetAtEndOfLine
        {
            get
            {
                try
                {
                return teklaObject.OffsetAtEndOfLine;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetAtEndOfLine), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.OffsetAtEndOfLine = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetAtEndOfLine), ex); 
                }
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
    
