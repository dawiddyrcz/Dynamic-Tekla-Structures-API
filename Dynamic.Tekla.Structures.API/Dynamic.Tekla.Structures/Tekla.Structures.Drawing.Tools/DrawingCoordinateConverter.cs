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

		public static Dynamic.Tekla.Structures.Geometry3d.Point Convert(Dynamic.Tekla.Structures.Drawing.ViewBase fromView, Dynamic.Tekla.Structures.Drawing.ViewBase toView, Dynamic.Tekla.Structures.Geometry3d.Point point)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(fromView);
			parameters[1] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(toView);
			parameters[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.Tools.DrawingCoordinateConverter", "Convert", parameters);
			return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PointList Convert(Dynamic.Tekla.Structures.Drawing.ViewBase fromView, Dynamic.Tekla.Structures.Drawing.ViewBase toView, Dynamic.Tekla.Structures.Drawing.PointList pointList)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(fromView);
			parameters[1] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(toView);
			parameters[2] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pointList);
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.Tools.DrawingCoordinateConverter", "Convert", parameters);
			return Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(result);
		}





    }

    internal static class DrawingCoordinateConverter_
    {
        public static dynamic GetTSObject(DrawingCoordinateConverter dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingCoordinateConverter FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.Tools.DrawingCoordinateConverter)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
