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
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.FrameOrigin);
			}
			set
			{
				teklaObject.FrameOrigin = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Origin
		{
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Origin);
			}
			set
			{
				teklaObject.Origin = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
			}
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point ExtremaCenter
		{
			get
			{
				 return Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.ExtremaCenter);
			}
			set
			{
				teklaObject.ExtremaCenter = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
			}
		}

		public System.Boolean IsSheet
		{
			get => teklaObject.IsSheet;
			set { teklaObject.IsSheet = value; }
		}

        

        


		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAxisAlignedBoundingBox()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetObjects()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetObjects());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetObjects()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetAllObjects()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetAllObjects());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAllObjects()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetAllObjects(System.Type Type)
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetAllObjects(Type));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAllObjects()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator GetModelObjects(Dynamic.Tekla.Structures.Identifier ModelIdentifier)
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.DrawingObjectEnumerator_.FromTSObject(teklaObject.GetModelObjects(Dynamic.Tekla.Structures.Identifier_.GetTSObject(ModelIdentifier)));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetModelObjects()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.Drawing GetOriginalDrawing()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.Drawing_.FromTSObject(teklaObject.GetOriginalDrawing());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetOriginalDrawing()"); }
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
    
