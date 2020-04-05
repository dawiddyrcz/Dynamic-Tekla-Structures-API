/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class LinkFrameAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.Line);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Line"); }
			}
			set
			{
				try {
				teklaObject.Line = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Line"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypes LineType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(teklaObject.LineType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType"); }
			}
			set
			{
				try {
				teklaObject.LineType = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType"); }
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

        

        

		public LinkFrameAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LinkFrameAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LinkFrameAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetObjectAlignedBoundingBox());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetObjectAlignedBoundingBox()"); }
		}

		public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
		{
			try {
			return Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(teklaObject.GetAxisAlignedBoundingBox());
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetAxisAlignedBoundingBox()"); }
		}





    }

    internal static class LinkFrameAttributes_
    {
        public static dynamic GetTSObject(LinkFrameAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LinkFrameAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.LinkFrameAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LinkFrameAttributesArray_
    {
        public static dynamic GetTSObject(LinkFrameAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LinkFrameAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LinkFrameAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LinkFrameAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LinkFrameAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
