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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(teklaObject.Polymesh);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polymesh"); }
			}
			set
			{
				try {
				teklaObject.Polymesh = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Polymesh"); }
			}
		}

		public System.String Class
		{
			get
			{
				try {
					return teklaObject.Class;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Class"); }
			}
			set
			{
				try {
					teklaObject.Class = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Class"); }
			}
		}

		public System.String Name
		{
			get
			{
				try {
					return teklaObject.Name;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
			set
			{
				try {
					teklaObject.Name = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Name"); }
			}
		}

		public System.Boolean CreateHoles
		{
			get
			{
				try {
					return teklaObject.CreateHoles;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreateHoles"); }
			}
			set
			{
				try {
					teklaObject.CreateHoles = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("CreateHoles"); }
			}
		}

		public System.String Type
		{
			get
			{
				try {
					return teklaObject.Type;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
			set
			{
				try {
					teklaObject.Type = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.ModelObject Father
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(teklaObject.Father);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father"); }
			}
			set
			{
				try {
				teklaObject.Father = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Father"); }
			}
		}

        

        

		public SurfaceObject()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SurfaceObject");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public SurfaceObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}





    }

    internal static class SurfaceObject_
    {
        public static dynamic GetTSObject(SurfaceObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SurfaceObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.SurfaceObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SurfaceObjectArray_
    {
        public static dynamic GetTSObject(SurfaceObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SurfaceObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SurfaceObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SurfaceObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SurfaceObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
