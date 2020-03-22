/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model.UI
{

    public  class ViewHandler 
    {

        

        internal dynamic teklaObject;

		public ViewHandler()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewHandler");
		}

		public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetAllViews()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetAllViews", parameters);
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetVisibleViews()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetVisibleViews", parameters);
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetPermanentViews()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetPermanentViews", parameters);
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetTemporaryViews()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetTemporaryViews", parameters);
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetSelectedViews()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetSelectedViews", parameters);
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
		}

		public static System.Boolean ShowView(Dynamic.Tekla.Structures.Model.UI.View view)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "ShowView", parameters);
		}

		public static System.Boolean HideView(Dynamic.Tekla.Structures.Model.UI.View view)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "HideView", parameters);
		}

		public static System.Boolean RedrawView(Dynamic.Tekla.Structures.Model.UI.View view)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "RedrawView", parameters);
		}

		public static System.Boolean ZoomToBoundingBox(Dynamic.Tekla.Structures.Model.UI.View view, Dynamic.Tekla.Structures.Geometry3d.AABB B)
		{
			var parameters = new object[2];
			parameters[0] = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view);
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(B);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "ZoomToBoundingBox", parameters);
		}

		public static System.Boolean ZoomToBoundingBox(Dynamic.Tekla.Structures.Geometry3d.AABB box)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(box);
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "ZoomToBoundingBox", parameters);
		}

		public static System.Boolean SetRepresentation(System.String Representation)
		{
			var parameters = new object[1];
			parameters[0] = Representation;
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "SetRepresentation", parameters);
		}

		public static System.Boolean RedrawWorkplane()
		{
			var parameters = new object[0];
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "RedrawWorkplane", parameters);
		}





    }

    internal static class ViewHandler_
    {
        public static dynamic GetTSObject(ViewHandler dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ViewHandler FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.UI.ViewHandler)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
