/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ControlPlane  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.Plane Plane
		{
			get => Dynamic.Tekla.Structures.Model.Plane_.FromTSObject(teklaObject.Plane);
			set { teklaObject.Plane = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(value); }
		}

		public System.Boolean IsMagnetic
		{
			get => teklaObject.IsMagnetic;
			set { teklaObject.IsMagnetic = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

        

        

		public ControlPlane()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPlane");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ControlPlane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ControlPlane(Dynamic.Tekla.Structures.Model.Plane P, System.Boolean IsMagnetic)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Model.Plane_.GetTSObject(P);
			args[1] = IsMagnetic;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPlane", args);
		}





    }

    internal static class ControlPlane_
    {
        public static dynamic GetTSObject(ControlPlane dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ControlPlane FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ControlPlane)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ControlPlaneArray_
    {
        public static dynamic GetTSObject(ControlPlane[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ControlPlane_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ControlPlane[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ControlPlane>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ControlPlane_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
