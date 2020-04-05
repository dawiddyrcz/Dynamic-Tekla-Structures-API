/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public abstract class EmbeddedObjectBase  : Dynamic.Tekla.Structures.Drawing.DrawingObject
    {

		public Dynamic.Tekla.Structures.Geometry3d.Point InsertionPoint
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.InsertionPoint);
			set { teklaObject.InsertionPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.String FileName
		{
			get => teklaObject.FileName;
			set { teklaObject.FileName = value; }
		}

		public System.Double Angle
		{
			get => teklaObject.Angle;
			set { teklaObject.Angle = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.Size Size
		{
			get => Dynamic.Tekla.Structures.Drawing.Size_.FromTSObject(teklaObject.Size);
			set { teklaObject.Size = Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes Attributes
		{
			get => Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes_.FromTSObject(teklaObject.Attributes);
			set { teklaObject.Attributes = Dynamic.Tekla.Structures.Drawing.EmbeddedObjectAttributes_.GetTSObject(value); }
		}

        

        


		public System.Boolean MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector moveVector)
		{
			return teklaObject.MoveObjectRelative(Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(moveVector));
		}

		public System.Boolean Resize(Dynamic.Tekla.Structures.Drawing.Size size)
		{
			return teklaObject.Resize(Dynamic.Tekla.Structures.Drawing.Size_.GetTSObject(size));
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetObjectAlignedBoundingBox());
		}





    }

    internal static class EmbeddedObjectBase_
    {
        public static dynamic GetTSObject(EmbeddedObjectBase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static EmbeddedObjectBase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.EmbeddedObjectBase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EmbeddedObjectBaseArray_
    {
        public static dynamic GetTSObject(EmbeddedObjectBase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EmbeddedObjectBase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EmbeddedObjectBase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<EmbeddedObjectBase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EmbeddedObjectBase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
