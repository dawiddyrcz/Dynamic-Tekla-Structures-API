/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class Polycurve 
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);

		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);

		}

		public System.Double Length
		{
			get => teklaObject.Length;

		}

        

        internal dynamic teklaObject;

		public Polycurve()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Polycurve");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Polycurve(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Polycurve(Dynamic.Tekla.Structures.Geometry3d.ICurve geometry)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.ICurve_.GetTSObject(geometry);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Polycurve", args);
		}
		public Polycurve(Dynamic.Tekla.Structures.Geometry3d.PolyLine polyLine)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(polyLine);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Polycurve", args);
		}





    }

    internal static class Polycurve_
    {
        public static dynamic GetTSObject(Polycurve dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static Polycurve FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Polycurve)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PolycurveArray_
    {
        public static dynamic GetTSObject(Polycurve[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Polycurve_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Polycurve[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<Polycurve>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Polycurve_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
