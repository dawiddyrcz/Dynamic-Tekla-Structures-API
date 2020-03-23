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
			set { teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
			set { teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Double Length
		{
			get => teklaObject.Length;
			set { teklaObject.Length = value; }
		}

        

        internal dynamic teklaObject;

		public Polycurve()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Polycurve");
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
            return dynObject.teklaObject;
        }

        public static Polycurve FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Polycurve)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
