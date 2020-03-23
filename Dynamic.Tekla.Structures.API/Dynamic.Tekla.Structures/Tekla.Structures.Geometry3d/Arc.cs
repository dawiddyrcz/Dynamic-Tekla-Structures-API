/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class Arc 
    {

		public System.Double Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point CenterPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.CenterPoint);
			set { teklaObject.CenterPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcMiddlePoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcMiddlePoint);
			set { teklaObject.ArcMiddlePoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Normal
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Normal);
			set { teklaObject.Normal = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.Double Angle
		{
			get => teklaObject.Angle;
			set { teklaObject.Angle = value; }
		}

		public System.Double Radius
		{
			get => teklaObject.Radius;
			set { teklaObject.Radius = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector StartTangent
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.StartTangent);
			set { teklaObject.StartTangent = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector StartDirection
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.StartDirection);
			set { teklaObject.StartDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public Arc() {}
		public Arc(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, Dynamic.Tekla.Structures.Geometry3d.Point pointOnArc)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(pointOnArc);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Arc", args);
		}
		public Arc(Dynamic.Tekla.Structures.Geometry3d.Point centerPoint, Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Vector normal, System.Double deltaAngleRadians)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(centerPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(normal);
			args[3] = deltaAngleRadians;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Arc", args);
		}
		public Arc(Dynamic.Tekla.Structures.Geometry3d.Point centerPoint, Dynamic.Tekla.Structures.Geometry3d.Vector startDirection, Dynamic.Tekla.Structures.Geometry3d.Vector startTangent, System.Double radius, System.Double deltaAngleRadians)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(centerPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(startDirection);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(startTangent);
			args[3] = radius;
			args[4] = deltaAngleRadians;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Arc", args);
		}





    }

    internal static class Arc_
    {
        public static dynamic GetTSObject(Arc dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Arc FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Arc)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
