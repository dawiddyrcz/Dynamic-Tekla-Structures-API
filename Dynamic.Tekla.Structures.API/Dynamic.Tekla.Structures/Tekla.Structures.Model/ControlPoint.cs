/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ControlPoint  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point Point
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Point);
			set { teklaObject.Point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

        

        

		public ControlPoint()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPoint");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ControlPoint(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ControlPoint(Dynamic.Tekla.Structures.Geometry3d.Point existPoint)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(existPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPoint", args);
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}





    }

    internal static class ControlPoint_
    {
        public static dynamic GetTSObject(ControlPoint dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ControlPoint FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ControlPoint)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ControlPointArray_
    {
        public static dynamic GetTSObject(ControlPoint[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ControlPoint_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ControlPoint[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ControlPoint>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ControlPoint_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
