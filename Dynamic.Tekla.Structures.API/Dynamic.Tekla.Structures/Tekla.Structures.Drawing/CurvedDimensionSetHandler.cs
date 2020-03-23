/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class CurvedDimensionSetHandler 
    {

        

        internal dynamic teklaObject;

		public CurvedDimensionSetHandler()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.CurvedDimensionSetHandler");
		}

		public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial CreateCurvedDimensionSetRadial(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints, System.Double Distance, Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes Attributes)
		{
			return Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial_.FromTSObject(teklaObject.CreateCurvedDimensionSetRadial(Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3), Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints), Distance, Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes_.GetTSObject(Attributes)));
		}

		public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial CreateCurvedDimensionSetRadial(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints, System.Double Distance)
		{
			return Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial_.FromTSObject(teklaObject.CreateCurvedDimensionSetRadial(Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3), Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints), Distance));
		}

		public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal CreateCurvedDimensionSetOrthogonal(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints, System.Double Distance, Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes Attributes)
		{
			return Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal_.FromTSObject(teklaObject.CreateCurvedDimensionSetOrthogonal(Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3), Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints), Distance, Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes_.GetTSObject(Attributes)));
		}

		public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal CreateCurvedDimensionSetOrthogonal(Dynamic.Tekla.Structures.Drawing.ViewBase View, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2, Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3, Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints, System.Double Distance)
		{
			return Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal_.FromTSObject(teklaObject.CreateCurvedDimensionSetOrthogonal(Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2), Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3), Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints), Distance));
		}





    }

    internal static class CurvedDimensionSetHandler_
    {
        public static dynamic GetTSObject(CurvedDimensionSetHandler dynObject)
        {
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetHandler FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetHandler)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
