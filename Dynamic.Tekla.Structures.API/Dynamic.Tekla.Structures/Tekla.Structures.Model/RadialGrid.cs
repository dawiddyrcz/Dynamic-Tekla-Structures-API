/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RadialGrid  : Dynamic.Tekla.Structures.Model.GridBase
    {

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

		public System.String RadialCoordinates
		{
			get
			{
				try {
					return teklaObject.RadialCoordinates;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RadialCoordinates"); }
			}
			set
			{
				try {
					teklaObject.RadialCoordinates = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RadialCoordinates"); }
			}
		}

		public System.String AngularCoordinates
		{
			get
			{
				try {
					return teklaObject.AngularCoordinates;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularCoordinates"); }
			}
			set
			{
				try {
					teklaObject.AngularCoordinates = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularCoordinates"); }
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

		public System.String RadialLabels
		{
			get
			{
				try {
					return teklaObject.RadialLabels;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RadialLabels"); }
			}
			set
			{
				try {
					teklaObject.RadialLabels = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RadialLabels"); }
			}
		}

		public System.String AngularLabels
		{
			get
			{
				try {
					return teklaObject.AngularLabels;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLabels"); }
			}
			set
			{
				try {
					teklaObject.AngularLabels = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLabels"); }
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

		public System.Double ArcStartExtension
		{
			get
			{
				try {
					return teklaObject.ArcStartExtension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcStartExtension"); }
			}
			set
			{
				try {
					teklaObject.ArcStartExtension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcStartExtension"); }
			}
		}

		public System.Double AngularLinesStartExtension
		{
			get
			{
				try {
					return teklaObject.AngularLinesStartExtension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLinesStartExtension"); }
			}
			set
			{
				try {
					teklaObject.AngularLinesStartExtension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLinesStartExtension"); }
			}
		}

		public System.Double ExtensionBelowZ
		{
			get
			{
				try {
					return teklaObject.ExtensionBelowZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionBelowZ"); }
			}
			set
			{
				try {
					teklaObject.ExtensionBelowZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionBelowZ"); }
			}
		}

		public System.Double ArcEndExtension
		{
			get
			{
				try {
					return teklaObject.ArcEndExtension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcEndExtension"); }
			}
			set
			{
				try {
					teklaObject.ArcEndExtension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcEndExtension"); }
			}
		}

		public System.Double AngularLinesEndExtension
		{
			get
			{
				try {
					return teklaObject.AngularLinesEndExtension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLinesEndExtension"); }
			}
			set
			{
				try {
					teklaObject.AngularLinesEndExtension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLinesEndExtension"); }
			}
		}

		public System.Double ExtensionAboveZ
		{
			get
			{
				try {
					return teklaObject.ExtensionAboveZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionAboveZ"); }
			}
			set
			{
				try {
					teklaObject.ExtensionAboveZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionAboveZ"); }
			}
		}

		public System.Drawing.Color Color
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

        

        

		public RadialGrid()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RadialGrid");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public RadialGrid(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class RadialGrid_
    {
        public static dynamic GetTSObject(RadialGrid dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RadialGrid FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.RadialGrid)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RadialGridArray_
    {
        public static dynamic GetTSObject(RadialGrid[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RadialGrid_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RadialGrid[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RadialGrid>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RadialGrid_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
