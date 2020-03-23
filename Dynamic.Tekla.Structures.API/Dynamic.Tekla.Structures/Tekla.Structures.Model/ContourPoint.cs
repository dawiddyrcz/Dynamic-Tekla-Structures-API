/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ContourPoint  : Dynamic.Tekla.Structures.Geometry3d.Point
    {

		public Dynamic.Tekla.Structures.Model.Chamfer Chamfer
		{
			get => Dynamic.Tekla.Structures.Model.Chamfer_.FromTSObject(teklaObject.Chamfer);
			set { teklaObject.Chamfer = Dynamic.Tekla.Structures.Model.Chamfer_.GetTSObject(value); }
		}

        

        

		public ContourPoint()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPoint");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ContourPoint(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ContourPoint(Dynamic.Tekla.Structures.Geometry3d.Point P, Dynamic.Tekla.Structures.Model.Chamfer C)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(P);
			args[1] = Dynamic.Tekla.Structures.Model.Chamfer_.GetTSObject(C);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPoint", args);
		}

		public void SetPoint(Dynamic.Tekla.Structures.Geometry3d.Point P)
		{
			teklaObject.SetPoint(Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(P));
		}





    }

    internal static class ContourPoint_
    {
        public static dynamic GetTSObject(ContourPoint dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static ContourPoint FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ContourPoint)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ContourPointArray_
    {
        public static dynamic GetTSObject(ContourPoint[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ContourPoint_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ContourPoint[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<ContourPoint>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ContourPoint_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
