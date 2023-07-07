/*Copyright (C) Yury Isachenkov 2023
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

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


        public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial CreateCurvedDimensionSetRadial(
			Dynamic.Tekla.Structures.Drawing.ViewBase View_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3_,
			Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints_,
			System.Double Distance,
			Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes Attributes_)
        {
            var View = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View_);
var ArcPoint1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1_);
var ArcPoint2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2_);
var ArcPoint3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3_);
var DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints_);
var Attributes = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial.CurvedDimensionSetRadialAttributes_.GetTSObject(Attributes_);
            try
            {
                var result = teklaObject.CreateCurvedDimensionSetRadial(View, ArcPoint1, ArcPoint2, ArcPoint3, DimensionPoints, Distance, Attributes);
            
                var _result = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateCurvedDimensionSetRadial), ex);
            }
        }



        public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial CreateCurvedDimensionSetRadial(
			Dynamic.Tekla.Structures.Drawing.ViewBase View_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3_,
			Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints_,
			System.Double Distance)
        {
            var View = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View_);
var ArcPoint1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1_);
var ArcPoint2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2_);
var ArcPoint3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3_);
var DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints_);
            try
            {
                var result = teklaObject.CreateCurvedDimensionSetRadial(View, ArcPoint1, ArcPoint2, ArcPoint3, DimensionPoints, Distance);
            
                var _result = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetRadial_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateCurvedDimensionSetRadial), ex);
            }
        }



        public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal CreateCurvedDimensionSetOrthogonal(
			Dynamic.Tekla.Structures.Drawing.ViewBase View_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3_,
			Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints_,
			System.Double Distance,
			Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes Attributes_)
        {
            var View = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View_);
var ArcPoint1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1_);
var ArcPoint2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2_);
var ArcPoint3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3_);
var DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints_);
var Attributes = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal.CurvedDimensionSetOrthogonalAttributes_.GetTSObject(Attributes_);
            try
            {
                var result = teklaObject.CreateCurvedDimensionSetOrthogonal(View, ArcPoint1, ArcPoint2, ArcPoint3, DimensionPoints, Distance, Attributes);
            
                var _result = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateCurvedDimensionSetOrthogonal), ex);
            }
        }



        public Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal CreateCurvedDimensionSetOrthogonal(
			Dynamic.Tekla.Structures.Drawing.ViewBase View_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint1_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint2_,
			Dynamic.Tekla.Structures.Geometry3d.Point ArcPoint3_,
			Dynamic.Tekla.Structures.Drawing.PointList DimensionPoints_,
			System.Double Distance)
        {
            var View = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(View_);
var ArcPoint1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint1_);
var ArcPoint2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint2_);
var ArcPoint3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(ArcPoint3_);
var DimensionPoints = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(DimensionPoints_);
            try
            {
                var result = teklaObject.CreateCurvedDimensionSetOrthogonal(View, ArcPoint1, ArcPoint2, ArcPoint3, DimensionPoints, Distance);
            
                var _result = Dynamic.Tekla.Structures.Drawing.CurvedDimensionSetOrthogonal_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CreateCurvedDimensionSetOrthogonal), ex);
            }
        }






    }

    internal static class CurvedDimensionSetHandler_
    {
        public static dynamic GetTSObject(CurvedDimensionSetHandler dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static CurvedDimensionSetHandler FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(CurvedDimensionSetHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static CurvedDimensionSetHandler[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<CurvedDimensionSetHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(CurvedDimensionSetHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
