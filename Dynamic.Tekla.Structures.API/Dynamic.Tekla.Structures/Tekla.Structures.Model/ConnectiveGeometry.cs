/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class ConnectiveGeometry 
    {

		public static System.Int32 InvalidGeometrySectionIndex
		{
			get => (System.Int32) TSActivator.Get_StaticPropertyOrFieldValue("Tekla.Structures.Model.ConnectiveGeometry","InvalidGeometrySectionIndex");

		}

        

        internal dynamic teklaObject;

		internal ConnectiveGeometry() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public ConnectiveGeometry(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public ConnectiveGeometry(Dynamic.Tekla.Structures.Model.Contour contour)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(contour);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometry", args);
		}
		public ConnectiveGeometry(Dynamic.Tekla.Structures.Model.BendSurface bendSurface)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.BendSurface_.GetTSObject(bendSurface);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometry", args);
		}

		public System.Boolean IsEmpty()
		{
			try {
			return teklaObject.IsEmpty();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsEmpty()"); }
		}

		public Dynamic.Tekla.Structures.Model.GeometrySectionEnumerator GetGeometryEnumerator()
		{
			try {
			return Dynamic.Tekla.Structures.Model.GeometrySectionEnumerator_.FromTSObject(teklaObject.GetGeometryEnumerator());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetGeometryEnumerator()"); }
		}





    }

    internal static class ConnectiveGeometry_
    {
        public static dynamic GetTSObject(ConnectiveGeometry dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ConnectiveGeometry FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.ConnectiveGeometry)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ConnectiveGeometryArray_
    {
        public static dynamic GetTSObject(ConnectiveGeometry[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ConnectiveGeometry_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ConnectiveGeometry[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ConnectiveGeometry>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ConnectiveGeometry_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
