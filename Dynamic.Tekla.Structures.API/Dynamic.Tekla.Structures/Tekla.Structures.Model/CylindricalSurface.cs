//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public  class CylindricalSurface  : Dynamic.Tekla.Structures.Model.BendSurface
    {

		public System.Double Radius
		{
			get => teklaObject.Radius;
			set { teklaObject.Radius = value; }
		}

		public System.Boolean InwardCurved
		{
			get => teklaObject.InwardCurved;
			set { teklaObject.InwardCurved = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Line IntersectionLine
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(teklaObject.IntersectionLine);
			set { teklaObject.IntersectionLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.EndFaceNormal1);
			set { teklaObject.EndFaceNormal1 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.EndFaceNormal2);
			set { teklaObject.EndFaceNormal2 = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Line CenterLine
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Line_.FromTSObject(teklaObject.CenterLine);
			set { teklaObject.CenterLine = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxis
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.RotationAxis);
			set { teklaObject.RotationAxis = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary1
		{
			get => teklaObject.LateralBoundary1;
			set { teklaObject.LateralBoundary1 = value; }
		}

		public System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary2
		{
			get => teklaObject.LateralBoundary2;
			set { teklaObject.LateralBoundary2 = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.SideBoundary1);
			set { teklaObject.SideBoundary1 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(teklaObject.SideBoundary2);
			set { teklaObject.SideBoundary2 = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		internal CylindricalSurface() {}
		public CylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary1, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary2)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary1);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary2);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
		}
		public CylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
			args[2] = lateralBoundary1;
			args[3] = lateralBoundary2;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
		}
		public CylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Arc baseArc, System.Double height)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(baseArc);
			args[1] = height;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
		}
		public CylindricalSurface(System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2, Dynamic.Tekla.Structures.Geometry3d.Line centerLine, Dynamic.Tekla.Structures.Geometry3d.Vector rotationAxis)
		{
			var args = new object[4];
			args[0] = lateralBoundary1;
			args[1] = lateralBoundary2;
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(centerLine);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(rotationAxis);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
		}





    }

    internal static class CylindricalSurface_
    {
        public static dynamic GetTSObject(CylindricalSurface dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CylindricalSurface FromTSObject(dynamic tsObject)
        {
            return new CylindricalSurface() { teklaObject = tsObject };
        }
    }


}
    
