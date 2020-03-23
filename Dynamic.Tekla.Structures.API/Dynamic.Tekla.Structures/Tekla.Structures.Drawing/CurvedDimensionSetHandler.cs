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
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public CurvedDimensionSetHandler(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
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
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetHandler)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class CurvedDimensionSetHandlerArray_
    {
        public static dynamic GetTSObject(CurvedDimensionSetHandler[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionSetHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionSetHandler[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<CurvedDimensionSetHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedDimensionSetHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
