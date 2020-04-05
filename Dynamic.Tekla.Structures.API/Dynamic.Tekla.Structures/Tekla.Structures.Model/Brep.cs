/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Brep  : Dynamic.Tekla.Structures.Model.Part
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.StartPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
			set
			{
				try {
				teklaObject.StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.EndPoint);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
			set
			{
				try {
				teklaObject.EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPoint"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Offset StartPointOffset
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Offset_.FromTSObject(teklaObject.StartPointOffset);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPointOffset"); }
			}
			set
			{
				try {
				teklaObject.StartPointOffset = Dynamic.Tekla.Structures.Model.Offset_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("StartPointOffset"); }
			}
		}

		public Dynamic.Tekla.Structures.Model.Offset EndPointOffset
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Model.Offset_.FromTSObject(teklaObject.EndPointOffset);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPointOffset"); }
			}
			set
			{
				try {
				teklaObject.EndPointOffset = Dynamic.Tekla.Structures.Model.Offset_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("EndPointOffset"); }
			}
		}

        

        

		public Brep()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Brep");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Brep(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Brep(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Brep", args);
		}





    }

    internal static class Brep_
    {
        public static dynamic GetTSObject(Brep dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Brep FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Brep)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class BrepArray_
    {
        public static dynamic GetTSObject(Brep[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Brep_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Brep[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Brep>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Brep_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
