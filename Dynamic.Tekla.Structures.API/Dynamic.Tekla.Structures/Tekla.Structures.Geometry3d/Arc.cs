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

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point CenterPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.CenterPoint);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ArcMiddlePoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ArcMiddlePoint);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector Normal
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Normal);

		}

		public System.Double Angle
		{
			get => teklaObject.Angle;

		}

		public System.Double Radius
		{
			get => teklaObject.Radius;

		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector StartTangent
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.StartTangent);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector StartDirection
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.StartDirection);

		}

        

        internal dynamic teklaObject;

		public Arc()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Arc");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Arc(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
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
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Arc FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Arc)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ArcArray_
    {
        public static dynamic GetTSObject(Arc[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Arc_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Arc[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Arc>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Arc_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
