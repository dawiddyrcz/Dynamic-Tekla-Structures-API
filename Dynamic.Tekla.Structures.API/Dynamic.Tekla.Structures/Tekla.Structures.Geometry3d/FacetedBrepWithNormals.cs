/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class FacetedBrepWithNormals  : Dynamic.Tekla.Structures.Geometry3d.FacetedBrep
    {

		public Dynamic.Tekla.Structures.Geometry3d.Vector[] Normals
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector[]_.FromTSObject(teklaObject.Normals);
			set { teklaObject.Normals = Dynamic.Tekla.Structures.Geometry3d.Vector[]_.GetTSObject(value); }
		}

        

        

		public FacetedBrepWithNormals() {}
		public FacetedBrepWithNormals(Dynamic.Tekla.Structures.Geometry3d.Vector[] vertices, System.Int32[][] outerWires, System.Collections.Generic.IDictionary<System.Int32, System.Int32[][]> innerWires, Dynamic.Tekla.Structures.Geometry3d.Vector[] normals)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector[]_.GetTSObject(vertices);
			args[1] = outerWires;
			args[2] = innerWires;
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector[]_.GetTSObject(normals);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.FacetedBrepWithNormals", args);
		}





    }

    internal static class FacetedBrepWithNormals_
    {
        public static dynamic GetTSObject(FacetedBrepWithNormals dynObject)
        {
            return dynObject.teklaObject;
        }

        public static FacetedBrepWithNormals FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.FacetedBrepWithNormals)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
