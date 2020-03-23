/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class GridCylindricalSurface  : Dynamic.Tekla.Structures.Model.GridSurface
    {

		public Dynamic.Tekla.Structures.Geometry3d.Arc CylinderBase
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Arc_.FromTSObject(teklaObject.CylinderBase);
			set { teklaObject.CylinderBase = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(value); }
		}

		public System.Double CylinderHeight
		{
			get => teklaObject.CylinderHeight;
			set { teklaObject.CylinderHeight = value; }
		}

        

        

		public GridCylindricalSurface()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridCylindricalSurface");
		}
		public GridCylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Arc cylinderBase, System.Double cylinderHeight, System.String label)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(cylinderBase);
			args[1] = cylinderHeight;
			args[2] = label;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridCylindricalSurface", args);
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}





    }

    internal static class GridCylindricalSurface_
    {
        public static dynamic GetTSObject(GridCylindricalSurface dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GridCylindricalSurface FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.GridCylindricalSurface)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
