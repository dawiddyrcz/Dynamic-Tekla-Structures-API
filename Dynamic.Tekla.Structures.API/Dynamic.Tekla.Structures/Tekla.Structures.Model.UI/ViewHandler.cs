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

		public Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetAllViews()
		{
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(teklaObject.GetAllViews());
		}

		public Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetVisibleViews()
		{
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(teklaObject.GetVisibleViews());
		}

		public Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetPermanentViews()
		{
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(teklaObject.GetPermanentViews());
		}

		public Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetTemporaryViews()
		{
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(teklaObject.GetTemporaryViews());
		}

		public Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetSelectedViews()
		{
			return Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(teklaObject.GetSelectedViews());
		}

		public System.Boolean ShowView(Dynamic.Tekla.Structures.Model.UI.View view)
		{
			return teklaObject.ShowView(Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view));
		}

		public System.Boolean HideView(Dynamic.Tekla.Structures.Model.UI.View view)
		{
			return teklaObject.HideView(Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view));
		}

		public System.Boolean RedrawView(Dynamic.Tekla.Structures.Model.UI.View view)
		{
			return teklaObject.RedrawView(Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view));
		}

		public System.Boolean ZoomToBoundingBox(Dynamic.Tekla.Structures.Model.UI.View view, Dynamic.Tekla.Structures.Geometry3d.AABB B)
		{
			return teklaObject.ZoomToBoundingBox(Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view), Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(B));
		}

		public System.Boolean ZoomToBoundingBox(Dynamic.Tekla.Structures.Geometry3d.AABB box)
		{
			return teklaObject.ZoomToBoundingBox(Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(box));
		}

		public System.Boolean SetRepresentation(System.String Representation)
		{
			return teklaObject.SetRepresentation(Representation);
		}

		public System.Boolean RedrawWorkplane()
		{
			return teklaObject.RedrawWorkplane();
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
    
