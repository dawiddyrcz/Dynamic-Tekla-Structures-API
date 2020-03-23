/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class RectangleBoundingBox  : Dynamic.Tekla.Structures.Geometry3d.AABB
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point UpperLeft
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.UpperLeft);
			set { teklaObject.UpperLeft = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point UpperRight
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.UpperRight);
			set { teklaObject.UpperRight = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point LowerLeft
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.LowerLeft);
			set { teklaObject.LowerLeft = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point LowerRight
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.LowerRight);
			set { teklaObject.LowerRight = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Double Width
		{
			get => teklaObject.Width;
			set { teklaObject.Width = value; }
		}

		public System.Double Height
		{
			get => teklaObject.Height;
			set { teklaObject.Height = value; }
		}

		public System.Double AngleToAxis
		{
			get => teklaObject.AngleToAxis;
			set { teklaObject.AngleToAxis = value; }
		}

        

        

		public RectangleBoundingBox() {}

		public static Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox CreateRectangleBoundingBox(Dynamic.Tekla.Structures.Geometry3d.Point CenterPoint, System.Double Width, System.Double Height, System.Double AngleToAxis)
		{
			var parameters = new object[4];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(CenterPoint);
			parameters[1] = Width;
			parameters[2] = Height;
			parameters[3] = AngleToAxis;
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.RectangleBoundingBox", "CreateRectangleBoundingBox", parameters);
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(result);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class RectangleBoundingBox_
    {
        public static dynamic GetTSObject(RectangleBoundingBox dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RectangleBoundingBox FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
