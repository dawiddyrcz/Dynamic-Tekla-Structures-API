/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class ViewBase  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public System.Double Width
		{
			get => teklaObject.Width;
			set { teklaObject.Width = value; }
		}

		public System.Double Height
		{
			get => teklaObject.Height;
			set { teklaObject.Height = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector FrameOrigin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.FrameOrigin);
			set { teklaObject.FrameOrigin = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
			set { teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ExtremaCenter
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ExtremaCenter);
			set { teklaObject.ExtremaCenter = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Boolean IsSheet
		{
			get => teklaObject.IsSheet;
			set { teklaObject.IsSheet = value; }
		}

        

        


		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Insert()
		{
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects());
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetAllObjects()
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetAllObjects());
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetAllObjects(System.Type Type)
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetAllObjects(Type));
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetModelObjects(Dynamic.Tekla.Structures.Identifier ModelIdentifier)
		{
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetModelObjects(Dynamic.Tekla.Structures.Identifier_.GetTSObject(ModelIdentifier)));
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public Dynamic.Tekla.Structures.Drawing.Drawing GetOriginalDrawing()
		{
			return Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(teklaObject.GetOriginalDrawing());
		}





    }

    internal static class ViewBase_
    {
        public static dynamic GetTSObject(ViewBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ViewBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.ViewBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewBaseArray_
    {
        public static dynamic GetTSObject(ViewBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ViewBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
