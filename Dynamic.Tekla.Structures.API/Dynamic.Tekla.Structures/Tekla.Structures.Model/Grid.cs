/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Grid  : Dynamic.Tekla.Structures.Model.GridBase
    {

		public System.String CoordinateX
		{
			get
			{
				try {
					return teklaObject.CoordinateX;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CoordinateX"); }
			}
			set
			{
				try {
					teklaObject.CoordinateX = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CoordinateX"); }
			}
		}

		public System.String CoordinateY
		{
			get
			{
				try {
					return teklaObject.CoordinateY;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CoordinateY"); }
			}
			set
			{
				try {
					teklaObject.CoordinateY = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CoordinateY"); }
			}
		}

		public System.String CoordinateZ
		{
			get
			{
				try {
					return teklaObject.CoordinateZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CoordinateZ"); }
			}
			set
			{
				try {
					teklaObject.CoordinateZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CoordinateZ"); }
			}
		}

		public System.String LabelX
		{
			get
			{
				try {
					return teklaObject.LabelX;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelX"); }
			}
			set
			{
				try {
					teklaObject.LabelX = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelX"); }
			}
		}

		public System.String LabelY
		{
			get
			{
				try {
					return teklaObject.LabelY;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelY"); }
			}
			set
			{
				try {
					teklaObject.LabelY = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelY"); }
			}
		}

		public System.String LabelZ
		{
			get
			{
				try {
					return teklaObject.LabelZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelZ"); }
			}
			set
			{
				try {
					teklaObject.LabelZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelZ"); }
			}
		}

		public System.Double ExtensionLeftX
		{
			get
			{
				try {
					return teklaObject.ExtensionLeftX;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeftX"); }
			}
			set
			{
				try {
					teklaObject.ExtensionLeftX = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeftX"); }
			}
		}

		public System.Double ExtensionLeftY
		{
			get
			{
				try {
					return teklaObject.ExtensionLeftY;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeftY"); }
			}
			set
			{
				try {
					teklaObject.ExtensionLeftY = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeftY"); }
			}
		}

		public System.Double ExtensionLeftZ
		{
			get
			{
				try {
					return teklaObject.ExtensionLeftZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeftZ"); }
			}
			set
			{
				try {
					teklaObject.ExtensionLeftZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionLeftZ"); }
			}
		}

		public System.Double ExtensionRightX
		{
			get
			{
				try {
					return teklaObject.ExtensionRightX;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRightX"); }
			}
			set
			{
				try {
					teklaObject.ExtensionRightX = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRightX"); }
			}
		}

		public System.Double ExtensionRightY
		{
			get
			{
				try {
					return teklaObject.ExtensionRightY;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRightY"); }
			}
			set
			{
				try {
					teklaObject.ExtensionRightY = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRightY"); }
			}
		}

		public System.Double ExtensionRightZ
		{
			get
			{
				try {
					return teklaObject.ExtensionRightZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRightZ"); }
			}
			set
			{
				try {
					teklaObject.ExtensionRightZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionRightZ"); }
			}
		}

		public System.Double ExtensionForMagneticArea
		{
			get
			{
				try {
					return teklaObject.ExtensionForMagneticArea;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionForMagneticArea"); }
			}
			set
			{
				try {
					teklaObject.ExtensionForMagneticArea = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionForMagneticArea"); }
			}
		}

		public System.Int32 Color
		{
			get
			{
				try {
					return teklaObject.Color;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
			}
			set
			{
				try {
					teklaObject.Color = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
			}
		}

        

        

		public Grid()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Grid");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Grid(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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

            var dynObject = (Dynamic.Tekla.Structures.Model.Grid)System.Activator.CreateInstance(type, parameters);
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
    
