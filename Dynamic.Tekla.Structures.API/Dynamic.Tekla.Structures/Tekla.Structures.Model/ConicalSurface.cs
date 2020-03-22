/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ConicalSurface  : Dynamic.Tekla.Structures.Model.BendSurface
    {

		public System.Tuple<System.Double, System.Double> Radiuses
		{
			get => teklaObject.Radiuses;
			set { teklaObject.Radiuses = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Apex
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Apex);
			set { teklaObject.Apex = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        

		public ConicalSurface() {}
		public ConicalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary1, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary2)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary1);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary2);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurface", args);
		}
		public ConicalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
			args[2] = lateralBoundary1;
			args[3] = lateralBoundary2;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurface", args);
		}
		public ConicalSurface(Dynamic.Tekla.Structures.Geometry3d.Arc baseArc, System.Double height, System.Double radiusAtHeight)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(baseArc);
			args[1] = height;
			args[2] = radiusAtHeight;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurface", args);
		}
		public ConicalSurface(System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2, Dynamic.Tekla.Structures.Geometry3d.Line centerLine, Dynamic.Tekla.Structures.Geometry3d.Vector rotationAxis)
		{
			var args = new object[4];
			args[0] = lateralBoundary1;
			args[1] = lateralBoundary2;
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(centerLine);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(rotationAxis);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurface", args);
		}





    }

    internal static class ConicalSurface_
    {
        public static dynamic GetTSObject(ConicalSurface dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ConicalSurface FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ConicalSurface)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
