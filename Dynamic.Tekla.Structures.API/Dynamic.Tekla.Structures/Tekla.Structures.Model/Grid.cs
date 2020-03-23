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
			get => teklaObject.CoordinateX;
			set { teklaObject.CoordinateX = value; }
		}

		public System.String CoordinateY
		{
			get => teklaObject.CoordinateY;
			set { teklaObject.CoordinateY = value; }
		}

		public System.String CoordinateZ
		{
			get => teklaObject.CoordinateZ;
			set { teklaObject.CoordinateZ = value; }
		}

		public System.String LabelX
		{
			get => teklaObject.LabelX;
			set { teklaObject.LabelX = value; }
		}

		public System.String LabelY
		{
			get => teklaObject.LabelY;
			set { teklaObject.LabelY = value; }
		}

		public System.String LabelZ
		{
			get => teklaObject.LabelZ;
			set { teklaObject.LabelZ = value; }
		}

		public System.Double ExtensionLeftX
		{
			get => teklaObject.ExtensionLeftX;
			set { teklaObject.ExtensionLeftX = value; }
		}

		public System.Double ExtensionLeftY
		{
			get => teklaObject.ExtensionLeftY;
			set { teklaObject.ExtensionLeftY = value; }
		}

		public System.Double ExtensionLeftZ
		{
			get => teklaObject.ExtensionLeftZ;
			set { teklaObject.ExtensionLeftZ = value; }
		}

		public System.Double ExtensionRightX
		{
			get => teklaObject.ExtensionRightX;
			set { teklaObject.ExtensionRightX = value; }
		}

		public System.Double ExtensionRightY
		{
			get => teklaObject.ExtensionRightY;
			set { teklaObject.ExtensionRightY = value; }
		}

		public System.Double ExtensionRightZ
		{
			get => teklaObject.ExtensionRightZ;
			set { teklaObject.ExtensionRightZ = value; }
		}

		public System.Double ExtensionForMagneticArea
		{
			get => teklaObject.ExtensionForMagneticArea;
			set { teklaObject.ExtensionForMagneticArea = value; }
		}

		public System.Int32 Color
		{
			get => teklaObject.Color;
			set { teklaObject.Color = value; }
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
            return dynObject.teklaObject;
        }

        public static Grid FromTSObject(dynamic tsObject)
        {
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
    
