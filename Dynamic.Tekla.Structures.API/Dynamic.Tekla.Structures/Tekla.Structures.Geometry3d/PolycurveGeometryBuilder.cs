//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Geometry3d
{

    public sealed class PolycurveGeometryBuilder 
    {

        

        internal dynamic polycurvegeometrybuilder;
        
        public PolycurveGeometryBuilder()
        {
            this.polycurvegeometrybuilder =  TSActivator.CreateInstance("Tekla.Structures.Geometry3d.PolycurveGeometryBuilder");
        }

        internal PolycurveGeometryBuilder(dynamic tsObject)
        {
            this.polycurvegeometrybuilder = tsObject;
        }

		public Dynamic.Tekla.Structures.Geometry3d.Polycurve GetPolycurve()
			 => Dynamic.Tekla.Structures.Geometry3d.Polycurve_.FromTSObject(polycurvegeometrybuilder.GetPolycurve());

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Append(Dynamic.Tekla.Structures.Geometry3d.Arc arc)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.Append(Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(arc)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Append(Dynamic.Tekla.Structures.Geometry3d.LineSegment segment)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.Append(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Append(Dynamic.Tekla.Structures.Geometry3d.Polycurve otherPolycurve)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.Append(Dynamic.Tekla.Structures.Geometry3d.Polycurve_.GetTSObject(otherPolycurve)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder AppendArc(Dynamic.Tekla.Structures.Geometry3d.Point middlePoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.AppendArc(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(middlePoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder AppendSegment(Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.AppendSegment(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder AppendTangentArc(Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.AppendTangentArc(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder AppendTangentSegment(System.Double length)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.AppendTangentSegment(length));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Prepend(Dynamic.Tekla.Structures.Geometry3d.Arc arc)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.Prepend(Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(arc)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Prepend(Dynamic.Tekla.Structures.Geometry3d.LineSegment segment)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.Prepend(Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder PrependArc(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point middlePoint)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.PrependArc(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(middlePoint)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder PrependSegment(Dynamic.Tekla.Structures.Geometry3d.Point startPoint)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.PrependSegment(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder PrependTangentArc(Dynamic.Tekla.Structures.Geometry3d.Point startPoint)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.PrependTangentArc(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder PrependTangentSegment(System.Double length)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.PrependTangentSegment(length));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Replace(System.Int32 index, Dynamic.Tekla.Structures.Geometry3d.Arc arc)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.Replace(index, Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(arc)));

		public Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder Replace(System.Int32 index, Dynamic.Tekla.Structures.Geometry3d.LineSegment segment)
			 => Dynamic.Tekla.Structures.Geometry3d.PolycurveGeometryBuilder_.FromTSObject(polycurvegeometrybuilder.Replace(index, Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(segment)));





    }

    internal static class PolycurveGeometryBuilder_
    {
        public static dynamic GetTSObject(PolycurveGeometryBuilder dynObject)
        {
            return dynObject.polycurvegeometrybuilder;
        }

        public static PolycurveGeometryBuilder FromTSObject(dynamic tsObject)
        {
            return new PolycurveGeometryBuilder(tsObject);
        }
    }


}
    