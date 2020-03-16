//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class CylindricalSurface 
    {

		public System.Double Radius
		{
			get => cylindricalsurface.Radius;
			set { cylindricalsurface.Radius = value; }
		}

		public System.Boolean InwardCurved
		{
			get => cylindricalsurface.InwardCurved;
			set { cylindricalsurface.InwardCurved = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Line IntersectionLine
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Line(cylindricalsurface.IntersectionLine.GetTSObject());
			set { cylindricalsurface.IntersectionLine = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal1
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(cylindricalsurface.EndFaceNormal1.GetTSObject());
			set { cylindricalsurface.EndFaceNormal1 = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector EndFaceNormal2
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(cylindricalsurface.EndFaceNormal2.GetTSObject());
			set { cylindricalsurface.EndFaceNormal2 = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Line CenterLine
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Line(cylindricalsurface.CenterLine.GetTSObject());
			set { cylindricalsurface.CenterLine = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxis
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.Vector(cylindricalsurface.RotationAxis.GetTSObject());
			set { cylindricalsurface.RotationAxis = value.GetTSObject(); }
		}

		public System.Collections.Generic.ListTekla.Structures.Geometry3d.Point, Tekla.Structures, Version=2019.1.0.0, Culture=neutral, PublicKeyToken=2f04dbe497b71114<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary1
		{
			get => cylindricalsurface.LateralBoundary1;
			set { cylindricalsurface.LateralBoundary1 = value; }
		}

		public System.Collections.Generic.ListTekla.Structures.Geometry3d.Point, Tekla.Structures, Version=2019.1.0.0, Culture=neutral, PublicKeyToken=2f04dbe497b71114<Dynamic.Tekla.Structures.Geometry3d.Point> LateralBoundary2
		{
			get => cylindricalsurface.LateralBoundary2;
			set { cylindricalsurface.LateralBoundary2 = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary1
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.LineSegment(cylindricalsurface.SideBoundary1.GetTSObject());
			set { cylindricalsurface.SideBoundary1 = value.GetTSObject(); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.LineSegment SideBoundary2
		{
			get => new Dynamic.Tekla.Structures.Geometry3d.LineSegment(cylindricalsurface.SideBoundary2.GetTSObject());
			set { cylindricalsurface.SideBoundary2 = value.GetTSObject(); }
		}

        

        dynamic cylindricalsurface;
        
        public CylindricalSurface()
        {
            this.cylindricalsurface =  new Tekla.Structures.Model.CylindricalSurface();
        }

        public CylindricalSurface(dynamic tsObject)
        {
            this.cylindricalsurface = tsObject;
			this.Radius = cylindricalsurface.Radius;
			this.InwardCurved = cylindricalsurface.InwardCurved;
			this.IntersectionLine = new Dynamic.Tekla.Structures.Geometry3d.Line(cylindricalsurface.IntersectionLine);
			this.EndFaceNormal1 = new Dynamic.Tekla.Structures.Geometry3d.Vector(cylindricalsurface.EndFaceNormal1);
			this.EndFaceNormal2 = new Dynamic.Tekla.Structures.Geometry3d.Vector(cylindricalsurface.EndFaceNormal2);
			this.CenterLine = new Dynamic.Tekla.Structures.Geometry3d.Line(cylindricalsurface.CenterLine);
			this.RotationAxis = new Dynamic.Tekla.Structures.Geometry3d.Vector(cylindricalsurface.RotationAxis);
			this.LateralBoundary1 = cylindricalsurface.LateralBoundary1;
			this.LateralBoundary2 = cylindricalsurface.LateralBoundary2;
			this.SideBoundary1 = new Dynamic.Tekla.Structures.Geometry3d.LineSegment(cylindricalsurface.SideBoundary1);
			this.SideBoundary2 = new Dynamic.Tekla.Structures.Geometry3d.LineSegment(cylindricalsurface.SideBoundary2);

        }


        public dynamic GetTSObject() => cylindricalsurface;

		public System.Boolean Equals(System.Object obj)
			 => cylindricalsurface.Equals(obj);

		public System.Int32 GetHashCode()
			 => cylindricalsurface.GetHashCode();

		public System.Type GetType()
			 => cylindricalsurface.GetType();

		public System.String ToString()
			 => cylindricalsurface.ToString();





    }

}
    
