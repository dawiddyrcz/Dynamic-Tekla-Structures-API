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

		public System.String RadialCoordinates
		{
			get
			{
				try {
					return teklaObject.RadialCoordinates;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RadialCoordinates", ex); }
			}
			set
			{
				try {
					teklaObject.RadialCoordinates = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RadialCoordinates", ex); }
			}
		}

		public System.String AngularCoordinates
		{
			get
			{
				try {
					return teklaObject.AngularCoordinates;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularCoordinates", ex); }
			}
			set
			{
				try {
					teklaObject.AngularCoordinates = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularCoordinates", ex); }
			}
		}

		public System.String CoordinateZ
		{
			get
			{
				try {
					return teklaObject.CoordinateZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CoordinateZ", ex); }
			}
			set
			{
				try {
					teklaObject.CoordinateZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CoordinateZ", ex); }
			}
		}

		public System.String RadialLabels
		{
			get
			{
				try {
					return teklaObject.RadialLabels;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RadialLabels", ex); }
			}
			set
			{
				try {
					teklaObject.RadialLabels = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("RadialLabels", ex); }
			}
		}

		public System.String AngularLabels
		{
			get
			{
				try {
					return teklaObject.AngularLabels;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLabels", ex); }
			}
			set
			{
				try {
					teklaObject.AngularLabels = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLabels", ex); }
			}
		}

		public System.String LabelZ
		{
			get
			{
				try {
					return teklaObject.LabelZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelZ", ex); }
			}
			set
			{
				try {
					teklaObject.LabelZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LabelZ", ex); }
			}
		}

		public System.Double ArcStartExtension
		{
			get
			{
				try {
					return teklaObject.ArcStartExtension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcStartExtension", ex); }
			}
			set
			{
				try {
					teklaObject.ArcStartExtension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcStartExtension", ex); }
			}
		}

		public System.Double AngularLinesStartExtension
		{
			get
			{
				try {
					return teklaObject.AngularLinesStartExtension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLinesStartExtension", ex); }
			}
			set
			{
				try {
					teklaObject.AngularLinesStartExtension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLinesStartExtension", ex); }
			}
		}

		public System.Double ExtensionBelowZ
		{
			get
			{
				try {
					return teklaObject.ExtensionBelowZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionBelowZ", ex); }
			}
			set
			{
				try {
					teklaObject.ExtensionBelowZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionBelowZ", ex); }
			}
		}

		public System.Double ArcEndExtension
		{
			get
			{
				try {
					return teklaObject.ArcEndExtension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcEndExtension", ex); }
			}
			set
			{
				try {
					teklaObject.ArcEndExtension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ArcEndExtension", ex); }
			}
		}

		public System.Double AngularLinesEndExtension
		{
			get
			{
				try {
					return teklaObject.AngularLinesEndExtension;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLinesEndExtension", ex); }
			}
			set
			{
				try {
					teklaObject.AngularLinesEndExtension = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("AngularLinesEndExtension", ex); }
			}
		}

		public System.Double ExtensionAboveZ
		{
			get
			{
				try {
					return teklaObject.ExtensionAboveZ;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionAboveZ", ex); }
			}
			set
			{
				try {
					teklaObject.ExtensionAboveZ = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("ExtensionAboveZ", ex); }
			}
		}

		public System.Drawing.Color Color
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
    
