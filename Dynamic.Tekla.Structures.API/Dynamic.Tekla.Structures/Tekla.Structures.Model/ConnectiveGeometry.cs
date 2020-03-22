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

        

        internal dynamic teklaObject;

		public ConnectiveGeometry() {}
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
			return teklaObject.IsEmpty();
		}

		public Dynamic.Tekla.Structures.Model.GeometrySectionEnumerator GetGeometryEnumerator()
		{
			return Dynamic.Tekla.Structures.Model.GeometrySectionEnumerator_.FromTSObject(teklaObject.GetGeometryEnumerator());
		}





    }

    internal static class ConnectiveGeometry_
    {
        public static dynamic GetTSObject(ConnectiveGeometry dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ConnectiveGeometry FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.ConnectiveGeometry)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
