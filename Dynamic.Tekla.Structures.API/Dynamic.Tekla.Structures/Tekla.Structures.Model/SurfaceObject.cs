/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class SurfaceObject  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep Polymesh
		{
			get => Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(teklaObject.Polymesh);
			set { teklaObject.Polymesh = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value); }
		}

		public System.String Class
		{
			get => teklaObject.Class;
			set { teklaObject.Class = value; }
		}

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.Boolean CreateHoles
		{
			get => teklaObject.CreateHoles;
			set { teklaObject.CreateHoles = value; }
		}

		public System.String Type
		{
			get => teklaObject.Type;
			set { teklaObject.Type = value; }
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get => Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.Father);
			set { teklaObject.Father = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value); }
		}

        

        

		public SurfaceObject()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SurfaceObject");
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

    internal static class SurfaceObject_
    {
        public static dynamic GetTSObject(SurfaceObject dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SurfaceObject FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.SurfaceObject)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SurfaceObjectArray_
    {
        public static dynamic GetTSObject(SurfaceObject[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SurfaceObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SurfaceObject[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<SurfaceObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SurfaceObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
