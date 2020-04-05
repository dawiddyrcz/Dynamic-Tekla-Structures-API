/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class DetailMarkTagsAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA1
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA1);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA1"); }
			}
			set
			{
				try {
				teklaObject.TagA1 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA1"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA2
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA2);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA2"); }
			}
			set
			{
				try {
				teklaObject.TagA2 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA2"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA3
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA3);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA3"); }
			}
			set
			{
				try {
				teklaObject.TagA3 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA3"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA4
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA4);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA4"); }
			}
			set
			{
				try {
				teklaObject.TagA4 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA4"); }
			}
		}

		public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA5
		{
			get
			{
				try {
				return Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA5);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA5"); }
			}
			set
			{
				try {
				teklaObject.TagA5 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value);
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("TagA5"); }
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
    
