/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
* 
* This library connects with the Tekla Structures Software which is protected by copyright.
* To use this library you have to obtain commercial license for Tekla Structures Software. 
*/
//This file is generated by CodeGenerator

namespace Dynamic.Tekla.Structures.Drawing
{

    public  class LinkAttributes  : Dynamic.Tekla.Structures.Drawing.AttributesBase
    {


        public System.Boolean IsUnderlined
        {
            get
            {
                try
                {
                return teklaObject.IsUnderlined;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsUnderlined), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.IsUnderlined = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsUnderlined), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
        {
            get
            {
                try
                {
                var value = teklaObject.Font;
                var value_ = Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.FontAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Font), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value);
                teklaObject.Font = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Font), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ScalingOptions Scaling
        {
            get
            {
                try
                {
                var value = teklaObject.Scaling;
                var value_ = Dynamic.Tekla.Structures.Drawing.ScalingOptions_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ScalingOptions) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Scaling), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ScalingOptions_.GetTSObject(value);
                teklaObject.Scaling = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Scaling), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.LinkFrameAttributes Frame
        {
            get
            {
                try
                {
                var value = teklaObject.Frame;
                var value_ = Dynamic.Tekla.Structures.Drawing.LinkFrameAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.LinkFrameAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Frame), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.LinkFrameAttributes_.GetTSObject(value);
                teklaObject.Frame = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Frame), ex); 
                }
            }
        }
        

        

		public LinkAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LinkAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public LinkAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public LinkAttributes(System.String AttributeFile)
		{
			var args = new object[1];
			args[0] = AttributeFile;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.LinkAttributes", args);
		}





    }

    internal static class LinkAttributes_
    {
        public static dynamic GetTSObject(LinkAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LinkAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.LinkAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LinkAttributesArray_
    {
        public static dynamic GetTSObject(LinkAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LinkAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LinkAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LinkAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LinkAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
