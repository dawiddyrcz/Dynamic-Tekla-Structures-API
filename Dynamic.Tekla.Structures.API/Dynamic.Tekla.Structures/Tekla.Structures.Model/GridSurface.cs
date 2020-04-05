/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public abstract class GridSurface  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.GridBase Parent
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.GridBase_.FromTSObject(teklaObject.Parent);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Parent"); }
			}
			set
			{
				try {
				teklaObject.Parent = Dynamic.Tekla.Structures.Model.GridBase_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Parent"); }
			}
		}

		public System.String Label
		{
			get
			{
				try {
					return teklaObject.Label;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Label"); }
			}
			set
			{
				try {
					teklaObject.Label = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Label"); }
			}
		}

		public System.Boolean IsMagnetic
		{
			get
			{
				try {
					return teklaObject.IsMagnetic;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMagnetic"); }
			}
			set
			{
				try {
					teklaObject.IsMagnetic = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMagnetic"); }
			}
		}

		public System.Double ExtensionLeft
		{
			get
			{
				try {
					return teklaObject.ExtensionLeft;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeft"); }
			}
			set
			{
				try {
					teklaObject.ExtensionLeft = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeft"); }
			}
		}

		public System.Double ExtensionRight
		{
			get
			{
				try {
					return teklaObject.ExtensionRight;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRight"); }
			}
			set
			{
				try {
					teklaObject.ExtensionRight = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRight"); }
			}
		}

		public System.Double ExtensionBelow
		{
			get
			{
				try {
					return teklaObject.ExtensionBelow;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionBelow"); }
			}
			set
			{
				try {
					teklaObject.ExtensionBelow = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionBelow"); }
			}
		}

		public System.Double ExtensionAbove
		{
			get
			{
				try {
					return teklaObject.ExtensionAbove;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionAbove"); }
			}
			set
			{
				try {
					teklaObject.ExtensionAbove = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionAbove"); }
			}
		}

		public System.Boolean DrawingVisibility
		{
			get
			{
				try {
					return teklaObject.DrawingVisibility;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawingVisibility"); }
			}
			set
			{
				try {
					teklaObject.DrawingVisibility = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawingVisibility"); }
			}
		}

		public System.Boolean IsManual
		{
			get
			{
				try {
					return teklaObject.IsManual;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsManual"); }
			}
			set
			{
				try {
					teklaObject.IsManual = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsManual"); }
			}
		}

        

        






    }

    internal static class GridSurface_
    {
        public static dynamic GetTSObject(GridSurface dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GridSurface FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.GridSurface)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridSurfaceArray_
    {
        public static dynamic GetTSObject(GridSurface[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GridSurface_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GridSurface[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GridSurface>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GridSurface_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
