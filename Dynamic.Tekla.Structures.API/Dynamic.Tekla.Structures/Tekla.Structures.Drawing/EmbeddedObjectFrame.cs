/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class EmbeddedObjectFrame 
    {


        public Dynamic.Tekla.Structures.Drawing.FrameTypes Type
        {
            get
            {
                try
                {
                var value = teklaObject.Type;
                var value_ = Dynamic.Tekla.Structures.Drawing.FrameTypes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.FrameTypes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.FrameTypes_.GetTSObject(value);
                teklaObject.Type = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.LineTypeAttributes Line
        {
            get
            {
                try
                {
                var value = teklaObject.Line;
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.LineTypeAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Line), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypeAttributes_.GetTSObject(value);
                teklaObject.Line = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Line), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.LineTypes LineType
        {
            get
            {
                try
                {
                var value = teklaObject.LineType;
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.LineTypes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LineType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.LineTypes_.GetTSObject(value);
                teklaObject.LineType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LineType), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.DrawingColors Color
        {
            get
            {
                try
                {
                var value = teklaObject.Color;
                var value_ = Dynamic.Tekla.Structures.Drawing.DrawingColors_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.DrawingColors) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.DrawingColors_.GetTSObject(value);
                teklaObject.Color = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
                }
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
			System.Object ObjectToCompare)
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
    
