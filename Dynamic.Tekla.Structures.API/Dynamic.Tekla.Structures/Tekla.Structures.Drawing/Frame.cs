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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.FrameTypes_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
			set
			{
				try {
				teklaObject.Type = Dynamic.Tekla.Structures.Drawing.FrameTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
			}
			set
			{
				try {
				teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color"); }
			}
		}

        

        internal dynamic teklaObject;

		internal Frame() {}
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
			try {
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAxisAlignedBoundingBox()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetObjectAlignedBoundingBox());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetObjectAlignedBoundingBox()"); }
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			try {
			return teklaObject.IsEqual(ObjectToCompare);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsEqual()"); }
		}

		public System.Object Clone()
		{
			try {
			return teklaObject.Clone();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Clone()"); }
		}





    }

    internal static class Frame_
    {
        public static dynamic GetTSObject(Frame dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Frame FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
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
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Frame_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Frame[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Frame>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Frame_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
