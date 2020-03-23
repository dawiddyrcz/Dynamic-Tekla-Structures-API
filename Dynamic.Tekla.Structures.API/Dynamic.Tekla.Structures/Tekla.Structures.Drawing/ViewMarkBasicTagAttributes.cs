/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class ViewMarkBasicTagAttributes  : Dynamic.Tekla.Structures.Drawing.GenericAttributesBase
    {

		public Dynamic.Tekla.Structures.Geometry3d.Vector Offset
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.Offset);
			set { teklaObject.Offset = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.TagLocation Location
		{
			get => Dynamic.Tekla.Structures.Drawing.TagLocation_.FromTSObject(teklaObject.Location);
			set { teklaObject.Location = Dynamic.Tekla.Structures.Drawing.TagLocation_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.ContainerElement TagContent
		{
			get => Dynamic.Tekla.Structures.Drawing.ContainerElement_.FromTSObject(teklaObject.TagContent);
			set { teklaObject.TagContent = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(value); }
		}

        

        

		public ViewMarkBasicTagAttributes()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ViewMarkBasicTagAttributes");
		}
		public ViewMarkBasicTagAttributes(Dynamic.Tekla.Structures.Geometry3d.Vector offset, Dynamic.Tekla.Structures.Drawing.TagLocation location, Dynamic.Tekla.Structures.Drawing.ContainerElement tagContent)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(offset);
			args[1] = Dynamic.Tekla.Structures.Drawing.TagLocation_.GetTSObject(location);
			args[2] = Dynamic.Tekla.Structures.Drawing.ContainerElement_.GetTSObject(tagContent);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.ViewMarkBasicTagAttributes", args);
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}





    }

    internal static class ViewMarkBasicTagAttributes_
    {
        public static dynamic GetTSObject(ViewMarkBasicTagAttributes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ViewMarkBasicTagAttributes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Drawing.ViewMarkBasicTagAttributes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ViewMarkBasicTagAttributesArray_
    {
        public static dynamic GetTSObject(ViewMarkBasicTagAttributes[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ViewMarkBasicTagAttributes_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ViewMarkBasicTagAttributes[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<ViewMarkBasicTagAttributes>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ViewMarkBasicTagAttributes_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
