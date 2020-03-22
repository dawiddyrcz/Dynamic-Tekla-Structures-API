/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.UI
{

    public  class DrawingObjectSelector 
    {

        

        internal dynamic teklaObject;

		public DrawingObjectSelector() {}

		public System.Boolean SelectObject(Dynamic.Tekla.Structures.Drawing.DrawingObject DrawingObject)
		{
			return teklaObject.SelectObject(Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(DrawingObject));
		}

		public System.Boolean SelectObjects(System.Collections.ArrayList DrawingObjects, System.Boolean ExtendSelection)
		{
			return teklaObject.SelectObjects(DrawingObjects, ExtendSelection);
		}

		public System.Boolean UnselectObject(Dynamic.Tekla.Structures.Drawing.DrawingObject DrawingObject)
		{
			return teklaObject.UnselectObject(Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(DrawingObject));
		}

		public System.Boolean UnselectObjects(System.Collections.ArrayList DrawingObjects)
		{
			return teklaObject.UnselectObjects(DrawingObjects);
		}

		public System.Boolean UnselectAllObjects()
		{
			return teklaObject.UnselectAllObjects();
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetSelected()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetSelected());
		}





    }

    internal static class DrawingObjectSelector_
    {
        public static dynamic GetTSObject(DrawingObjectSelector dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DrawingObjectSelector FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.UI.DrawingObjectSelector)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
