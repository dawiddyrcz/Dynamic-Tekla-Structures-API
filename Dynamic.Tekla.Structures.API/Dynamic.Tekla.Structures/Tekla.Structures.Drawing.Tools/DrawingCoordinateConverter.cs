/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.Tools
{

    public  class DrawingCoordinateConverter 
    {

        

        internal dynamic teklaObject;

		public DrawingCoordinateConverter()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Tools.DrawingCoordinateConverter");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DrawingCoordinateConverter(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


public static Dynamic.Tekla.Structures.Geometry3d.Point Convert(
	Dynamic.Tekla.Structures.Drawing.ViewBase fromView_,
	Dynamic.Tekla.Structures.Drawing.ViewBase toView_,
	Dynamic.Tekla.Structures.Geometry3d.Point point_
	)
{
	var fromView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(fromView_);
	var toView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(toView_);
	var point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.Tools.DrawingCoordinateConverter", "Convert", fromView, toView, point);
	var _result = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
	return _result;
}



public static Dynamic.Tekla.Structures.Drawing.PointList Convert(
	Dynamic.Tekla.Structures.Drawing.ViewBase fromView_,
	Dynamic.Tekla.Structures.Drawing.ViewBase toView_,
	Dynamic.Tekla.Structures.Drawing.PointList pointList_
	)
{
	var fromView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(fromView_);
	var toView = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(toView_);
	var pointList = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pointList_);
	var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Drawing.Tools.DrawingCoordinateConverter", "Convert", fromView, toView, pointList);
	var _result = Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(result);
	return _result;
}






    }

    internal static class DrawingCoordinateConverter_
    {
        public static dynamic GetTSObject(DrawingCoordinateConverter dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DrawingCoordinateConverter FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Tools.DrawingCoordinateConverter)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DrawingCoordinateConverterArray_
    {
        public static dynamic GetTSObject(DrawingCoordinateConverter[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DrawingCoordinateConverter_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DrawingCoordinateConverter[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DrawingCoordinateConverter>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DrawingCoordinateConverter_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
