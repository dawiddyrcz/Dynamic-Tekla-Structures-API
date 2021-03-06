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

    public  class DetailMarkTagsAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {


        public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA1
        {
            get
            {
                try
                {
                var value = teklaObject.TagA1;
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA1), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
                teklaObject.TagA1 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA1), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA2
        {
            get
            {
                try
                {
                var value = teklaObject.TagA2;
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA2), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
                teklaObject.TagA2 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA2), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA3
        {
            get
            {
                try
                {
                var value = teklaObject.TagA3;
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA3), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
                teklaObject.TagA3 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA3), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA4
        {
            get
            {
                try
                {
                var value = teklaObject.TagA4;
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA4), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
                teklaObject.TagA4 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA4), ex); 
                }
            }
        }

        public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA5
        {
            get
            {
                try
                {
                var value = teklaObject.TagA5;
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA5), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
                teklaObject.TagA5 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TagA5), ex); 
                }
            }
        }
        

        

		public DetailMarkTagsAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMarkTagsAttributes");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public DetailMarkTagsAttributes(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public DetailMarkTagsAttributes(Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes tagA1, Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes tagA2, Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes tagA3, Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes tagA4, Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes tagA5)
		{
			var args = new object[5];
			args[0] = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(tagA1);
			args[1] = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(tagA2);
			args[2] = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(tagA3);
			args[3] = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(tagA4);
			args[4] = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(tagA5);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMarkTagsAttributes", args);
		}





    }

    internal static class DetailMarkTagsAttributes_
    {
        public static dynamic GetTSObject(DetailMarkTagsAttributes dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static DetailMarkTagsAttributes FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.DetailMarkTagsAttributes)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class DetailMarkTagsAttributesArray_
    {
        public static dynamic GetTSObject(DetailMarkTagsAttributes[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(DetailMarkTagsAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static DetailMarkTagsAttributes[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<DetailMarkTagsAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(DetailMarkTagsAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
