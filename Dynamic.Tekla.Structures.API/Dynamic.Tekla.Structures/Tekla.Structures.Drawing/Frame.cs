/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class Frame 
    {

		public Dynamic.Tekla.Structures.Drawing.FrameTypes Type
		{
			get => Dynamic.Tekla.Structures.Drawing.FrameTypes_.FromTSObject(teklaObject.Type);
			set { teklaObject.Type = Dynamic.Tekla.Structures.Drawing.FrameTypes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
		{
			get => Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
			set { teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public Frame() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Frame(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Frame(Dynamic.Tekla.Structures.Drawing.FrameTypes FrameType, Dynamic.Tekla.Structures.Drawing.DrawingColors FrameColor)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.FrameTypes_.GetTSObject(FrameType);
			args[1] = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(FrameColor);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.Frame", args);
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

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}





    }

    internal static class Frame_
    {
        public static dynamic GetTSObject(Frame dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Frame FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.Frame)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class FrameArray_
    {
        public static dynamic GetTSObject(Frame[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Frame_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Frame[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Frame>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Frame_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
