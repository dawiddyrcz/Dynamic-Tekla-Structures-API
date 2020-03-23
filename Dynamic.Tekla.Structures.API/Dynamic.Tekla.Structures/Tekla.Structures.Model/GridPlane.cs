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
			get => Dynamic.Tekla.Structures.Model.Plane_.FromTSObject(teklaObject.Plane);
			set { teklaObject.Plane = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Grid Father
		{
			get => Dynamic.Tekla.Structures.Model.Grid_.FromTSObject(teklaObject.Father);
			set { teklaObject.Father = Dynamic.Tekla.Structures.Model.Grid_.GetTSObject(value); }
		}

		public System.String Label
		{
			get => teklaObject.Label;
			set { teklaObject.Label = value; }
		}

		public System.Boolean IsMagnetic
		{
			get => teklaObject.IsMagnetic;
			set { teklaObject.IsMagnetic = value; }
		}

		public System.Double ExtensionLeft
		{
			get => teklaObject.ExtensionLeft;
			set { teklaObject.ExtensionLeft = value; }
		}

		public System.Double ExtensionRight
		{
			get => teklaObject.ExtensionRight;
			set { teklaObject.ExtensionRight = value; }
		}

		public System.Double ExtensionBelow
		{
			get => teklaObject.ExtensionBelow;
			set { teklaObject.ExtensionBelow = value; }
		}

		public System.Double ExtensionAbove
		{
			get => teklaObject.ExtensionAbove;
			set { teklaObject.ExtensionAbove = value; }
		}

		public System.Boolean DrawingVisibility
		{
			get => teklaObject.DrawingVisibility;
			set { teklaObject.DrawingVisibility = value; }
		}

		public System.Int32 Color
		{
			get => teklaObject.Color;
			set { teklaObject.Color = value; }
		}

		public System.Double ExtensionForMagneticArea
		{
			get => teklaObject.ExtensionForMagneticArea;
			set { teklaObject.ExtensionForMagneticArea = value; }
		}

        

        

		public GridPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridPlane");
		}
		public GridPlane(Dynamic.Tekla.Structures.Model.Plane Plane, System.String Label)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(Plane);
			args[1] = Label;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridPlane", args);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}





    }

    internal static class GridPlane_
    {
        public static dynamic GetTSObject(GridPlane dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GridPlane FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.GridPlane)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
