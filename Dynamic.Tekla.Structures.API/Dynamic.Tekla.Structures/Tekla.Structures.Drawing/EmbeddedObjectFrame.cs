/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class EmbeddedObjectFrame 
    {

		public Dynamic.Tekla.Structures.Drawing.FrameTypes Type
		{
			get => Dynamic.Tekla.Structures.Drawing.FrameTypes_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Drawing.FrameTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.Line);
			set { teklaObject.Line = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypes LineType
		{
			get => Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(teklaObject.LineType);
			set { teklaObject.LineType = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public EmbeddedObjectFrame() {}
		public EmbeddedObjectFrame(Dynamic.Tekla.Structures.Drawing.LineTypes LineType, Dynamic.Tekla.Structures.Drawing.DrawingColors FrameColor)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(LineType);
			args[1] = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(FrameColor);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.EmbeddedObjectFrame", args);
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
		{
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetObjectAlignedBoundingBox());
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class EmbeddedObjectFrame_
    {
        public static dynamic GetTSObject(EmbeddedObjectFrame dynObject)
        {
            return dynObject.teklaObject;
        }

        public static EmbeddedObjectFrame FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.EmbeddedObjectFrame)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EmbeddedObjectFrameArray_
    {
        public static dynamic GetTSObject(EmbeddedObjectFrame[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EmbeddedObjectFrame_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EmbeddedObjectFrame[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<EmbeddedObjectFrame>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EmbeddedObjectFrame_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
