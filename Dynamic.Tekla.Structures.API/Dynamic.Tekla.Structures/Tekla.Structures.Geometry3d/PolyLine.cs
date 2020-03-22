/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Geometry3d
{

    public  class PolyLine 
    {

		public System.Collections.ArrayList Points
		{
			get => teklaObject.Points;
			set { teklaObject.Points = value; }
		}

        

        internal dynamic teklaObject;

		public PolyLine() {}
		public PolyLine(System.Collections.IEnumerable Points)
		{
			var args = new object[1];
			args[0] = Points;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.PolyLine", args);
		}

		public System.Double Length()
		{
			return teklaObject.Length();
		}

		public System.Boolean op_Equality(Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine1, Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine2)
		{
			return teklaObject.op_Equality(Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(PolyLine1), Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(PolyLine2));
		}

		public System.Boolean op_Inequality(Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine1, Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine2)
		{
			return teklaObject.op_Inequality(Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(PolyLine1), Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(PolyLine2));
		}





    }

    internal static class PolyLine_
    {
        public static dynamic GetTSObject(PolyLine dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PolyLine FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Geometry3d.PolyLine)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
