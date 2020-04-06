/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class GridPlane  : Dynamic.Tekla.Structures.Model.GridSurface
    {

		public Dynamic.Tekla.Structures.Model.Plane Plane
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Plane_.FromTSObject(teklaObject.Plane);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Plane", ex); }
			}
			set
			{
				try {
				teklaObject.Plane = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Plane", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Grid Father
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Grid_.FromTSObject(teklaObject.Father);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father", ex); }
			}
			set
			{
				try {
				teklaObject.Father = Dynamic.Tekla.Structures.Model.Grid_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father", ex); }
			}
		}

		public System.String Label
		{
			get
			{
				try {
					return teklaObject.Label;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Label", ex); }
			}
			set
			{
				try {
					teklaObject.Label = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Label", ex); }
			}
		}

		public System.Boolean IsMagnetic
		{
			get
			{
				try {
					return teklaObject.IsMagnetic;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMagnetic", ex); }
			}
			set
			{
				try {
					teklaObject.IsMagnetic = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsMagnetic", ex); }
			}
		}

		public System.Double ExtensionLeft
		{
			get
			{
				try {
					return teklaObject.ExtensionLeft;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeft", ex); }
			}
			set
			{
				try {
					teklaObject.ExtensionLeft = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeft", ex); }
			}
		}

		public System.Double ExtensionRight
		{
			get
			{
				try {
					return teklaObject.ExtensionRight;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRight", ex); }
			}
			set
			{
				try {
					teklaObject.ExtensionRight = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRight", ex); }
			}
		}

		public System.Double ExtensionBelow
		{
			get
			{
				try {
					return teklaObject.ExtensionBelow;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionBelow", ex); }
			}
			set
			{
				try {
					teklaObject.ExtensionBelow = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionBelow", ex); }
			}
		}

		public System.Double ExtensionAbove
		{
			get
			{
				try {
					return teklaObject.ExtensionAbove;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionAbove", ex); }
			}
			set
			{
				try {
					teklaObject.ExtensionAbove = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionAbove", ex); }
			}
		}

		public System.Boolean DrawingVisibility
		{
			get
			{
				try {
					return teklaObject.DrawingVisibility;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawingVisibility", ex); }
			}
			set
			{
				try {
					teklaObject.DrawingVisibility = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("DrawingVisibility", ex); }
			}
		}

		public System.Int32 Color
		{
			get
			{
				try {
					return teklaObject.Color;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
			set
			{
				try {
					teklaObject.Color = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
		}

		public System.Double ExtensionForMagneticArea
		{
			get
			{
				try {
					return teklaObject.ExtensionForMagneticArea;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionForMagneticArea", ex); }
			}
			set
			{
				try {
					teklaObject.ExtensionForMagneticArea = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionForMagneticArea", ex); }
			}
		}

        

        

		public GridPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridPlane");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public GridPlane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public GridPlane(Dynamic.Tekla.Structures.Model.Plane Plane, System.String Label)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(Plane);
			args[1] = Label;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridPlane", args);
		}





    }

    internal static class GridPlane_
    {
        public static dynamic GetTSObject(GridPlane dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static GridPlane FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.GridPlane)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class GridPlaneArray_
    {
        public static dynamic GetTSObject(GridPlane[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(GridPlane_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static GridPlane[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<GridPlane>();
            foreach(var tsItem in tsArray)
            {
                list.Add(GridPlane_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
