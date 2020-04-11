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
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.FrameTypes_.FromTSObject(teklaObject.Type);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type", ex); }
			}
			set
			{
				try {
				teklaObject.Type = Dynamic.Tekla.Structures.Drawing.FrameTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Type", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(teklaObject.Line);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Line", ex); }
			}
			set
			{
				try {
				teklaObject.Line = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Line", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.LineTypes LineType
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(teklaObject.LineType);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType", ex); }
			}
			set
			{
				try {
				teklaObject.LineType = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("LineType", ex); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(teklaObject.Color);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
			set
			{
				try {
				teklaObject.Color = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("Color", ex); }
			}
		}

        

        internal dynamic teklaObject;

		internal EmbeddedObjectFrame() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public EmbeddedObjectFrame(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public EmbeddedObjectFrame(Dynamic.Tekla.Structures.Drawing.LineTypes LineType, Dynamic.Tekla.Structures.Drawing.DrawingColors FrameColor)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(LineType);
			args[1] = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(FrameColor);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.EmbeddedObjectFrame", args);
		}


public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetAxisAlignedBoundingBox()
{

    try
    {
        	var result = teklaObject.GetAxisAlignedBoundingBox();

        	var _result = Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAxisAlignedBoundingBox), ex);
    }
}



public Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox GetObjectAlignedBoundingBox()
{

    try
    {
        	var result = teklaObject.GetObjectAlignedBoundingBox();

        	var _result = Dynamic.Tekla.Structures.Drawing.RectangleBoundingBox_.FromTSObject(result);
	return _result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjectAlignedBoundingBox), ex);
    }
}



public System.Boolean IsEqual(
	System.Object ObjectToCompare
	)
{
	
    try
    {
        	var result = (System.Boolean) teklaObject.IsEqual(ObjectToCompare);

        	return result;
    }
    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    {
        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsEqual), ex);
    }
}






    }

    internal static class EmbeddedObjectFrame_
    {
        public static dynamic GetTSObject(EmbeddedObjectFrame dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static EmbeddedObjectFrame FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.EmbeddedObjectFrame)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class EmbeddedObjectFrameArray_
    {
        public static dynamic GetTSObject(EmbeddedObjectFrame[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(EmbeddedObjectFrame_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static EmbeddedObjectFrame[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<EmbeddedObjectFrame>();
            foreach(var tsItem in tsArray)
            {
                list.Add(EmbeddedObjectFrame_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
