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
			get => teklaObject.IsMagnetic;
			set { teklaObject.IsMagnetic = value; }
		}

		public System.String RadialCoordinates
		{
			get => teklaObject.RadialCoordinates;
			set { teklaObject.RadialCoordinates = value; }
		}

		public System.String AngularCoordinates
		{
			get => teklaObject.AngularCoordinates;
			set { teklaObject.AngularCoordinates = value; }
		}

		public System.String CoordinateZ
		{
			get => teklaObject.CoordinateZ;
			set { teklaObject.CoordinateZ = value; }
		}

		public System.String RadialLabels
		{
			get => teklaObject.RadialLabels;
			set { teklaObject.RadialLabels = value; }
		}

		public System.String AngularLabels
		{
			get => teklaObject.AngularLabels;
			set { teklaObject.AngularLabels = value; }
		}

		public System.String LabelZ
		{
			get => teklaObject.LabelZ;
			set { teklaObject.LabelZ = value; }
		}

		public System.Double ArcStartExtension
		{
			get => teklaObject.ArcStartExtension;
			set { teklaObject.ArcStartExtension = value; }
		}

		public System.Double AngularLinesStartExtension
		{
			get => teklaObject.AngularLinesStartExtension;
			set { teklaObject.AngularLinesStartExtension = value; }
		}

		public System.Double ExtensionBelowZ
		{
			get => teklaObject.ExtensionBelowZ;
			set { teklaObject.ExtensionBelowZ = value; }
		}

		public System.Double ArcEndExtension
		{
			get => teklaObject.ArcEndExtension;
			set { teklaObject.ArcEndExtension = value; }
		}

		public System.Double AngularLinesEndExtension
		{
			get => teklaObject.AngularLinesEndExtension;
			set { teklaObject.AngularLinesEndExtension = value; }
		}

		public System.Double ExtensionAboveZ
		{
			get => teklaObject.ExtensionAboveZ;
			set { teklaObject.ExtensionAboveZ = value; }
		}

		public System.Drawing.Color Color
		{
			get => teklaObject.Color;
			set { teklaObject.Color = value; }
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
            return dynObject.teklaObject;
        }

        public static RadialGrid FromTSObject(dynamic tsObject)
        {
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
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RadialGrid_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RadialGrid[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<RadialGrid>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RadialGrid_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
