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
			get => Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA1);
			set { teklaObject.TagA1 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA2
		{
			get => Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA2);
			set { teklaObject.TagA2 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA3
		{
			get => Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA3);
			set { teklaObject.TagA3 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA4
		{
			get => Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA4);
			set { teklaObject.TagA4 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes TagA5
		{
			get => Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.FromTSObject(teklaObject.TagA5);
			set { teklaObject.TagA5 = Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes_.GetTSObject(value); }
		}

        

        

		public DetailMarkTagsAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.DetailMarkTagsAttributes");
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

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class DetailMarkTagsAttributes_
    {
        public static dynamic GetTSObject(DetailMarkTagsAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DetailMarkTagsAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.DetailMarkTagsAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
